/*================================================RTOS================================================*/
/*CREATOR : THAI VAN SANG*/
/*DATE    :              */
#include "MY_RTOS.h"
#include "My_application_stm32f1xx.h"
#include "My_sensors_lib.h"
#define OUTHOUSE_IDE 0x00
#define OUTHOUSE_PULL 0x02
#define OUTHOUSE_PUSH 0x03
static volatile uint8_t check_status_outhouse = OUTHOUSE_IDE;
volatile uint8_t position_control = 0U;
/*address bootloader*/
/*initialize variable in BSS region*/
static volatile uint32_t dem_time_equal_time_setting = 0U;
static volatile  bool status_start_water = false;
#define TIME_REPEAT_WATER (uint8_t)0x05
/*initialize variable in BSS region*/
/*variable send to computer through uart communication, it 's common variable*/
static char common_char[10] = "";
union my_byte
{
	uint8_t data;
	struct 
	{
		uint8_t bit_l:4;
		uint8_t bit_h:4;
	}_data;
};
typedef union my_byte BYTE_typedef;
static BYTE_typedef byte_demo = {0x00};
uint8_t get_hex(char c_1,char c_2);
uint8_t get_hex(char c_1,char c_2)
{
	byte_demo.data = 0x00;
	if(c_1 <= '9')
	{
		byte_demo._data.bit_h = c_1 - '0'; // 48
	}
	else byte_demo._data.bit_h = c_1 - 87;//ASCI
	if(c_2 <= '9')
	{
		byte_demo._data.bit_l = c_2 - '0'; // 48
	}
	else byte_demo._data.bit_l = c_2 - 87;//ASCI
	return byte_demo.data;
}
/*define variable global ADC*/
static ADC_Channel_Typedef adc_channel[2]={Channel_1,Channel_4};
static uint16_t adc_data[2] = {0x00U,0x00U};
static volatile uint8_t check_button_bootloader = 0U;
/*define variable global buffer uart receive*/
typedef enum
{
	_SIZE_BOOTLOADER = 7U*1023U,
	_SIZE_CONTROL = 5U,
}SIZE_Typedef;
volatile uint8_t frame_data_bootloader[5U] = {0U};
typedef enum
{
	_CASE_0 = 0U,
	_CASE_1,
	_CASE_2,
	_CASE_3,
	_CASE_4,
	_CASE_5,
}TYPE_FUNCTION_Typedef;
void gpio_config(void);
__attribute__((noreturn)) void my_task_ide(void);
__attribute__((noreturn)) void my_task_1(void);
__attribute__((noreturn)) void my_task_2(void);
__attribute__((noreturn)) void my_task_3(void);
my_func_tasks ARR_MY_FUNCTION[MAX_TASKS] = {my_task_ide,my_task_1,my_task_2,my_task_3};
void SysTick_Handler(void);
void PendSV_Handler(void);

volatile MENU_Typedef* MENU_ACTIVE = &MAIN_MENU;
static volatile uint8_t position_current = 2U;
volatile DATA_DHT11_Typedef data_dht11 = {10U,10U,10U,10U,10U};
FUNC_DHT11_Typedef DHT11_INITIAL = {(TIM_TypeDef*)TIM1_ADRESS,(GPIO_TypeDef*)GPIOA_ADRESS,(DHT11_PIN_Typedef)GPIO_0,&data_dht11,(I2C_TypeDef*)_I2C1_ADRESS};
DATA_THRESOLD_Typedef data_thresold;
volatile BYTE_Typedef DATA_PERIPHERAL = {0xFF};
/*initial value for rtc*/
static volatile uint8_t rtc_value = 0U;

void EXTI0_IRQHandler(void);
void EXTI1_IRQHandler(void);
void EXTI2_IRQHandler(void);
void EXTI3_IRQHandler(void);
void EXTI4_IRQHandler(void);
void RTC_IRQHandler(void);
void DMA1_Channel5_IRQHandler(void);
void TIM1_UP_IRQHandler(void);
/*task4*/
void EXTI0_IRQHandler(void)
{
	if(EXTI->PR&(1U<<0))
	{
	//	value_ext[0] += 1U;
		/*----------------*/
		if(MENU_ACTIVE->p_tail != NULL)
		{
			MENU_ACTIVE = MENU_ACTIVE->p_tail;
		}
		hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
		EXTI->PR |= (1U<<0);
	}
}
void EXTI1_IRQHandler(void)
{
	if(EXTI->PR&(1U<<1))
	{
	//	value_ext[1] += 1U;
		/*----------------*/
		if(MENU_ACTIVE->ID == ID_THRESOLD_1)
		{
	   FLash_read_half_word(adress_flash_start,(volatile uint32_t*)&data_thresold,4U);
			switch(position_current)
			{
				case 2:
					(data_thresold.THRESOLD_TEM_VAL < 40U) ? (data_thresold.THRESOLD_TEM_VAL += 1U) : (data_thresold.THRESOLD_TEM_VAL = 20);
					break;
				case 3:
					(data_thresold.THRESOLD_HUM_VAL < 100U) ? (data_thresold.THRESOLD_HUM_VAL += 1U) : (data_thresold.THRESOLD_HUM_VAL = 40);
					break;
				default:
					break;
			}
			FLash_erase(adress_flash_start);
			volatile uint16_t data_tmp[4] = {(volatile uint16_t)data_thresold.THRESOLD_TEM_VAL,(volatile uint16_t)data_thresold.THRESOLD_HUM_VAL,(volatile uint16_t)data_thresold.DATA_CONTROL_PERIPHERAL,(volatile uint16_t)data_thresold.value_time_setting};
			Flash_write(adress_flash_start,&data_tmp[0],8U);
			hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
		}
		else if(MENU_ACTIVE->ID == ID_PUMP_1)
		{
			FLash_read_half_word(adress_flash_start,(volatile uint32_t*)&data_thresold,4U);
			switch(position_current)
			{
				case 2:
					/*start water tree*/
				  DATA_PERIPHERAL.data &= ~(1U<<1);
				  dem_time_equal_time_setting = 0;
				  status_start_water = true;
					break;
				case 3:
					/*stop water tree*/
				  DATA_PERIPHERAL.data |= (1U<<1);
				  dem_time_equal_time_setting = 0;
				  status_start_water = false;
					break;
				case 4:
					(data_thresold.value_time_setting < 48U) ? (data_thresold.value_time_setting += 1U) : (data_thresold.value_time_setting = 12);
					break;
				default:
					break;
			}
			IC74HC595_start(DATA_PERIPHERAL.data);
			data_thresold.DATA_CONTROL_PERIPHERAL = DATA_PERIPHERAL.data;
			FLash_erase(adress_flash_start);
			volatile uint16_t data_tmp[4] = {(volatile uint16_t)data_thresold.THRESOLD_TEM_VAL,(volatile uint16_t)data_thresold.THRESOLD_HUM_VAL,(volatile uint16_t)data_thresold.DATA_CONTROL_PERIPHERAL,(volatile uint16_t)data_thresold.value_time_setting};
			Flash_write(adress_flash_start,&data_tmp[0],8U);
			hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
		}
		else if(MENU_ACTIVE->ID == ID_UPDATE)
		{
			check_button_bootloader += 1;
			switch(position_current)
			{
				case 2:
					if(check_button_bootloader == 3U)
					{
						if(MENU_ACTIVE->my_active_1[2] != NULL)
					  {
						((void (*)(void*,TYPE_Typedef))MENU_ACTIVE->my_active_1[2])(NULL,0);
					  }
						check_button_bootloader = 0U;
					}
					break;
				case 3:
					break;
				default:
					break;
			}
		}
		else if(MENU_ACTIVE->ID == ID_CONTROL_1)
		{
			switch(position_control)
			{
				case 2:
					DATA_PERIPHERAL._data.bit0 = ~DATA_PERIPHERAL._data.bit0;
					break;
				case 4:
					DATA_PERIPHERAL._data.bit1 = ~DATA_PERIPHERAL._data.bit1;
					break;
				case 6:
					DATA_PERIPHERAL._data.bit2 = ~DATA_PERIPHERAL._data.bit2;
					break;
				case 8:
					DATA_PERIPHERAL._data.bit3 = ~DATA_PERIPHERAL._data.bit3;
					break;
				case 10:
					DATA_PERIPHERAL._data.bit4 = ~DATA_PERIPHERAL._data.bit4;
					break;
				case 12:
					DATA_PERIPHERAL._data.bit5 = ~DATA_PERIPHERAL._data.bit5;
					break;
				case 14:
					DATA_PERIPHERAL._data.bit6 = ~DATA_PERIPHERAL._data.bit6;
					break;
				case 16:
					DATA_PERIPHERAL._data.bit7 = ~DATA_PERIPHERAL._data.bit7;
					break;
				default:
					break;		
			}
			IC74HC595_start(DATA_PERIPHERAL.data);
			data_thresold.DATA_CONTROL_PERIPHERAL = DATA_PERIPHERAL.data;
			FLash_erase(adress_flash_start);
			volatile uint16_t data_tmp[4] = {(volatile uint16_t)data_thresold.THRESOLD_TEM_VAL,(volatile uint16_t)data_thresold.THRESOLD_HUM_VAL,(volatile uint16_t)data_thresold.DATA_CONTROL_PERIPHERAL,(volatile uint16_t)data_thresold.value_time_setting};
			Flash_write(adress_flash_start,&data_tmp[0],8U);
			hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
			*(common_char + 0) = 'C';
			*(common_char + 1) = 'L';
			*(common_char + 2) = '/';
			covert_string((uint16_t)DATA_PERIPHERAL.data,common_char + 3);
			*(common_char + 6) = '\0';
			UART_string((USART_TypeDef*)_USART1,common_char);		
		}
		else if(MENU_ACTIVE->ID == ID_OUTHOUSE_1)
		{
			switch(position_current)
			{
				case 2:
					/*PULL IN*/
				  check_status_outhouse = OUTHOUSE_PULL;
					break;
				case 3:
					check_status_outhouse = OUTHOUSE_PUSH;
				  START_ROTATION(_1_circle,clockwise);
				  task_delay(500);
					/*PUSH OUT*/
					break;
				default:
					break;
			}
		}
		else
		{
			/*ide*/
		}
		EXTI->PR |= (1U<<1);
	}
}
void EXTI2_IRQHandler(void)
{
	if(EXTI->PR&(1U<<2))
	{
	//	value_ext[2] += 1U;
		/*----------------*/
		if(position_current < 3U)
		{
			position_current = 4U;
		}
		else position_current -= 1U;
		hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
		/*----------------*/
		EXTI->PR |= (1U<<2);
	}
}
void EXTI3_IRQHandler(void)
{
	if(EXTI->PR&(1U<<3))
	{
	//	value_ext[3] += 1U;
		/*----------------*/
		if(MENU_ACTIVE->ID == ID_CONTROL_1)
		{
				position_control += 2U;
			  if(position_control == 18U)
				{
					position_control = 2U;
				}
				hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
		}
		switch(position_current)
		{
			case 2:
				if(MENU_ACTIVE->p_menu_1 != NULL)
				{
					MENU_ACTIVE = MENU_ACTIVE->p_menu_1;
				}
				break;
			case 3:
				if(MENU_ACTIVE->p_menu_2 != NULL)
				{
					MENU_ACTIVE = MENU_ACTIVE->p_menu_2;
				}
			
				break;
			case 4:
				if(MENU_ACTIVE->p_menu_3 != NULL)
				{
					MENU_ACTIVE = MENU_ACTIVE->p_menu_3;
				}
				break;
			default:
				break;
		}
		hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
		EXTI->PR |= (1U<<3);
	}
}
void EXTI4_IRQHandler(void)
{
	if(EXTI->PR&(1U<<4))
	{
		//value_ext[4] += 1U;
		/*----------------*/
		if(position_current > 3U)
		{
			position_current = 2U;
		}
		else position_current += 1U;
		hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
		EXTI->PR |= (1U<<4);
	}
}
void RTC_IRQHandler(void)
{
	if(RTC->CRL&(1U<<0))
	{
		rtc_value+=1;/*a step equivalent ten minutes*/
		RTC->CRL &= ~(1U<<0);
	}
}
void DMA1_Channel5_IRQHandler(void)
{
	if(DMA1->ISR &(1U<<17))
	{
		if(frame_data_bootloader[0] == 'c' && frame_data_bootloader[1] == 'm' && frame_data_bootloader[2] == 'd')
		{
				/*CONNECT_SYNTAX =@= DATA */
				/*cmd byte_data*/
				/*cmd 18*/
				uint8_t data_cmd = get_hex(frame_data_bootloader[3],frame_data_bootloader[4]);
				DATA_PERIPHERAL.data = data_cmd; // 0x000 xxxx control by 4 bit LSB
			  IC74HC595_start(DATA_PERIPHERAL.data);
				FLash_erase(adress_flash_start);
			  volatile uint16_t data_tmp[4] = {(volatile uint16_t)data_thresold.THRESOLD_TEM_VAL,(volatile uint16_t)data_thresold.THRESOLD_HUM_VAL,(volatile uint16_t)data_thresold.DATA_CONTROL_PERIPHERAL,(volatile uint16_t)data_thresold.value_time_setting};
			  Flash_write(adress_flash_start,&data_tmp[0],8U);
				frame_data_bootloader[0] = 'x';
		}
		if(frame_data_bootloader[0] == '@')
		{
				/*T hum tem*/
				/*cmd 18*/
				uint8_t hum = get_hex(frame_data_bootloader[1],frame_data_bootloader[2]);
				uint8_t tem = get_hex(frame_data_bootloader[3],frame_data_bootloader[4]);
		  	data_thresold.THRESOLD_HUM_VAL = (uint32_t)hum;
			  data_thresold.THRESOLD_TEM_VAL = (uint32_t)tem;
			  FLash_erase(adress_flash_start);
			  volatile uint16_t data_tmp[4] = {(volatile uint16_t)data_thresold.THRESOLD_TEM_VAL,(volatile uint16_t)data_thresold.THRESOLD_HUM_VAL,(volatile uint16_t)data_thresold.DATA_CONTROL_PERIPHERAL,(volatile uint16_t)data_thresold.value_time_setting};
			  Flash_write(adress_flash_start,&data_tmp[0],8U);
				hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
				frame_data_bootloader[0] = 'x';
		}
		DMA1->IFCR |= (1U<<17);
	}
}

void TIM1_UP_IRQHandler(void)
{
	if(TIM1->SR&(1U<<0))
	{
		dem_time_equal_time_setting++;
		uint32_t calculator_time = data_thresold.value_time_setting*60;
		if(((DATA_PERIPHERAL.data>>1)&0x01U) == 1U)
		{
			if(dem_time_equal_time_setting == calculator_time)
			{
				DATA_PERIPHERAL.data &= ~(1U<<1);//temporatery
				status_start_water = true;
				dem_time_equal_time_setting = 0;
			}
		}
		else
		{
		if(dem_time_equal_time_setting == TIME_REPEAT_WATER*60 && status_start_water == true)
		{
			DATA_PERIPHERAL.data |= (1U<<1);//temporatery
			status_start_water = false;
			dem_time_equal_time_setting = 0;
		}
  	}
		IC74HC595_start(DATA_PERIPHERAL.data);
		data_thresold.DATA_CONTROL_PERIPHERAL = DATA_PERIPHERAL.data;
		TIM1->SR &= ~(1U<<0);
	}
}
int main(void)
{
  enable_faults_exceptions();
	initial_stack_handler_mode(MSP_STACK);
	initial_stacks();
	thread_mode_using_psp();
	gpio_config();
	systick_config();
	UART_init((USART_TypeDef*)_USART1);
	FLash_read_half_word(adress_flash_start,(volatile uint32_t*)&data_thresold,4U);
	DATA_PERIPHERAL.data = (uint8_t)data_thresold.DATA_CONTROL_PERIPHERAL;
	IC74HC595_config();
	STEP_MOTOR_INIT();
	NVIC_SetPriority(SysTick_IRQn,0U);
	NVIC_EnableIRQ(SysTick_IRQn);
	NVIC_SetPriority(PendSV_IRQn,10U);
	my_task_1();
}
void SysTick_Handler(void)
{
	g_count++;
	uint8_t dem = 0U;
	for(dem = 1U; dem < MAX_TASKS; dem++)
	{
		if(TASKS[dem].STATUS != STATE_READY)
		{
       if(TASKS[dem].TIME_BLOCK == g_count)
			 {
				 TASKS[dem].STATUS = STATE_READY;
			 }
		}
	}
	SCB->ICSR |= (1U<<28);
}
void gpio_config(void)
{
   /*configuration for pins*/
}
void my_task_ide(void)
{
	while(1)
	{
		
	}
}
/*variable essential when using bootloader*/
//static volatile	uint8_t size[2] = {0U};
//static volatile uint8_t data_flash[1023U*7U] = {0};
/*variable essential when using bootloader*/
//static volatile uint8_t check_write_flash = 0U;
/*define size of DMA*/
void my_task_1(void)
{
	i2c_init((I2C_TypeDef*)_I2C1_ADRESS);
	lcd_init((I2C_TypeDef*)_I2C1_ADRESS);
	UART_DMA_RX_init((USART_TypeDef*)_USART1);
	DMA_UART_RX((volatile uint8_t*)&frame_data_bootloader[0],&USART1->DR,_SIZE_CONTROL);
	NVIC_EnableIRQ(DMA1_Channel5_IRQn);
	NVIC_SetPriority(DMA1_Channel5_IRQn,2);
	while(1)
	{
		
		//ISSUE : error conflict when data received with size bootloader and dat received from signal control
			/*if(frame_data_bootloader[0] == 's' && frame_data_bootloader[1] == 'a' && frame_data_bootloader[2] == 'n' && frame_data_bootloader[3] == 'g' )
			{
				//CONNECT_SYNTAX =@= SIZE_DATA =@= DATA
				//sang0010600600206D0100087501000877010008
				//sang 0010 60 06 00 20 6D 01 00 08 75 01 00 08 77 01 00 08
				++check_write_flash;
				uint32_t dem =0;
				uint32_t i = 0;
				for(dem = 4; dem < 8;dem+=2)
			  {
					size[i] =get_hex(frame_data_bootloader[dem],frame_data_bootloader[dem+1]);
					i++;
				}
			  uint32_t *length = (uint32_t*)&size[0];
				dem = 0;
				i=0;
				for(dem = 8U;dem < (uint32_t)*length;dem+=2U)
				{
					data_flash[i] = get_hex(frame_data_bootloader[dem],frame_data_bootloader[dem+1]);
					i++;
				}
				dem = 0;
				for(dem = 0U;dem < 7U;dem++)
				{
					 FLash_erase(ADDRESS_BOOTLOADER + 1023U*dem);
				}
				Flash_write(ADDRESS_BOOTLOADER,(volatile uint16_t*)&data_flash[0],*length);
	      task_delay(100);
				if(check_write_flash == 2U)
				{
					frame_data_bootloader[0] = 'x';
				}
			}*/
			
	}	
}
static volatile uint8_t position_out_house = 0;
void my_task_2(void)
{
	ADC_init((ADC_TypeDef*)_ADC1_adress,&adc_channel[0],2U);
	ADC_DMA_init();
	ADC_DMA_start(&adc_data[0],(volatile uint16_t *)&ADC1->DR,2U);
	IC74HC595_start(DATA_PERIPHERAL.data);
	while(1)
	{
		if(adc_data[0] < 256U)
		{
	//	START_ROTATION(_1_circle,unclockwise);
		task_delay(500);
		}
		if(check_status_outhouse == OUTHOUSE_PULL)
		{
			for(position_out_house=0;position_out_house<91;position_out_house++)
			{
				START_ROTATION(_1_circle,unclockwise);
		    task_delay(300);
				if(check_status_outhouse == OUTHOUSE_PUSH) break;
			}
			check_status_outhouse = 0;
		}
		if(check_status_outhouse == OUTHOUSE_PUSH)
		{
  		for(uint8_t i=position_out_house;i>0;i--)
			{
			START_ROTATION(_1_circle,clockwise);
			task_delay(300);//500
			if(check_status_outhouse == OUTHOUSE_PULL) break;
			}
			position_out_house = 0;
			check_status_outhouse = 0;
		}
	}
}
void my_task_3(void)
{
	i2c_init((I2C_TypeDef*)_I2C1_ADRESS);
	lcd_init((I2C_TypeDef*)_I2C1_ADRESS);
	hienthi((I2C_TypeDef*)_I2C1_ADRESS,MENU_ACTIVE,position_current);
	EXT_config();
	timer1_configuration();
	//RTC_init();
	NVIC_SetPriority(EXTI0_IRQn,1U);
	NVIC_EnableIRQ(EXTI0_IRQn);
	NVIC_SetPriority(EXTI1_IRQn,1U);
	NVIC_EnableIRQ(EXTI1_IRQn);
	NVIC_SetPriority(EXTI2_IRQn,1U);
	NVIC_EnableIRQ(EXTI2_IRQn);
	NVIC_SetPriority(EXTI3_IRQn,1U);
	NVIC_EnableIRQ(EXTI3_IRQn);
	NVIC_SetPriority(EXTI4_IRQn,1U);
	NVIC_EnableIRQ(EXTI4_IRQn);
	NVIC_SetPriority(TIM1_UP_IRQn,2U);
	NVIC_EnableIRQ(TIM1_UP_IRQn);
	while(1)
	{
		if(MENU_ACTIVE->my_active_1[0] != NULL)
		{
		   ((void (*)(void *,TYPE_Typedef))(MENU_ACTIVE->my_active_1[0]))((FUNC_DHT11_Typedef*)&DHT11_INITIAL,_DHT11_FUNC_TYPEDEF);	 	
			  FLash_read_half_word(adress_flash_start,(volatile uint32_t*)&data_thresold,4U);
        task_delay(3000);	
        
		}
		if(data_dht11.nhiet_do_in < data_thresold.THRESOLD_TEM_VAL)		
		{
		//	DATA_PERIPHERAL.data &= ~(1U<<3);
			IC74HC595_start(DATA_PERIPHERAL.data);
		}
		else
		{
		//	DATA_PERIPHERAL.data |= (1U<<3);
			IC74HC595_start(DATA_PERIPHERAL.data);
		}
    if(data_dht11.do_am_in < data_thresold.THRESOLD_HUM_VAL)		
		{
		//	DATA_PERIPHERAL.data &= ~(1U<<1);
			IC74HC595_start(DATA_PERIPHERAL.data);
		}
		else
		{
		//	DATA_PERIPHERAL.data |= (1U<<1);
			IC74HC595_start(DATA_PERIPHERAL.data);
		}
	}
}
