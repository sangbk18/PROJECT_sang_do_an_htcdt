#include "My_sensors_lib.h"
#include "MY_RTOS.h"

/*===========================================DHT_11==================================================*/
void DHT11_init(TIM_TypeDef *tim,GPIO_TypeDef *GPIO,DHT11_PIN_Typedef PIN)
{
	uint8_t check_var = 0U;
	uint8_t time = 18U;
	bool check = true;
	check &= assert_paramater(IS_GPIO_ADRESS(GPIO));
	check &= assert_paramater(IS_TIM_ADRESS(tim));
	check &= assert_paramater(IS_DHT11_PIN(PIN));
	LOCK_NEXT_TASK = DHT11_RTOS_LOCK;
	if(check == true)
	{
		if(tim == (TIM_TypeDef*)TIM1_ADRESS)
		{
			RCC->APB2ENR |= (1U<<11);//enable clock for tim1 72MHz
			tim->CR1 |= (1U<<7);
			tim->CR1 &= ~(3U<<0);
			tim->ARR = 0xFFFF;
			tim->CNT = 0U;
			tim->PSC = 72U - 1U;
			tim->RCR = 0U;
			tim->EGR |= (1U<<0);
			tim->CR1 |= (1U<<0);
		}
		else if(tim == (TIM_TypeDef*)TIM2_ADRESS)
		{
			RCC->APB1ENR |= (1U<<0);
			tim->CR1 |= (1U<<7);
			tim->CR1 &= ~(3U<<0);
			tim->ARR = 0xFFFF;
			tim->CNT = 0U;
			tim->PSC = 36U - 1U;
			tim->RCR = 0U;
			tim->EGR |= (1U<<0);
			tim->CR1 |= (1U<<0);
		}
		if(GPIO == (GPIO_TypeDef*)GPIOA_ADRESS)
		{
			RCC->APB2ENR |= (1U<<2);
		}
		else if(GPIO == (GPIO_TypeDef*)GPIOB_ADRESS)
		{
			RCC->APB2ENR |= (1U<<3);
		}
		else if(GPIO == (GPIO_TypeDef*)GPIOC_ADRESS)
		{
			RCC->APB2ENR |= (1U<<4);
		}
		/*defaul pin arange 0 - 7*/
		GPIO->CRL &= ~(15U<<(PIN*4U));
		GPIO->CRL |= (3U<<(PIN*4U));
		GPIO->ODR |= (1U<<PIN);
		GPIO->ODR &= ~(1U<<PIN);
		/*delay 20 ms*/
		while(time  > 0U)
		{
		   tim->CNT = 0U;
			 while(tim->CNT < 1000U)
			 {
				 
			 }
			 time--;
		}
    /*delay 20 ms*/		
		GPIO->ODR |= (1U<<PIN);
		GPIO->CRL &= ~(15U<<(PIN*4U));
		GPIO->CRL |= (8U<<(PIN*4U));
		GPIO->BSRR |= (1U<<PIN);
		tim->CNT = 0U;
		while(tim->CNT < 60U)
		{
			if(!(GPIO->IDR&(1U<<PIN)))
			{
				check_var = 1U;
				break;
			}
		}
		
		if(check_var == 1U)
		{
			tim->CNT = 0U;
			while(tim->CNT < 100U)
			{
				if((GPIO->IDR&(1U<<PIN)))
				{
					check_var = 2U;
					break;
				}
			}
		}
		if(check_var == 2U)
		{
			tim->CNT = 0U;
			while(tim->CNT < 100U)
			{
				if(!(GPIO->IDR&(1U<<PIN)))
				{
					break;
				}
			}
		}	
	}
	else return;
}
uint8_t read_bit(TIM_TypeDef *tim,GPIO_TypeDef *GPIO,DHT11_PIN_Typedef PIN)
{
	uint16_t bit_check = 0U;
	uint16_t value = 0U;
	tim->CNT = 0U;
	while(tim->CNT < 100U)
	{
		if((GPIO->IDR&(1U<<PIN)))
    {
			bit_check = 1U;
			break;
		}
	}
	if(bit_check == 1U)
	{
		tim->CNT = 0U;
		while(tim->CNT < 100U)
		{
			if(!(GPIO->IDR&(1U<<PIN)))
			{
				value = tim->CNT;
				break;
			}
		}
	}
	if(value > 50) return 1U;
	else return 0U;
}
BYTE_Typedef _byte = {0U};
void read_5_byte(TIM_TypeDef *tim,GPIO_TypeDef *GPIO,DHT11_PIN_Typedef PIN,DATA_DHT11_Typedef *P_data)
{
	uint8_t dem = 0U;
	for(dem = 0U;dem < 5U ; dem++)
	{
		_byte.data = 0x00;
		_byte._data.bit7 = read_bit(tim,GPIO,PIN);
		_byte._data.bit6 = read_bit(tim,GPIO,PIN);
		_byte._data.bit5 = read_bit(tim,GPIO,PIN);
		_byte._data.bit4 = read_bit(tim,GPIO,PIN);
		_byte._data.bit3 = read_bit(tim,GPIO,PIN);
		_byte._data.bit2 = read_bit(tim,GPIO,PIN);
		_byte._data.bit1 = read_bit(tim,GPIO,PIN);
		_byte._data.bit0 = read_bit(tim,GPIO,PIN);
		*(volatile uint8_t*)((volatile uint8_t*)P_data + dem) = _byte.data;
	}
	LOCK_NEXT_TASK = DHT11_RTOS_UNLOCK;
}
/*===================================================DHT_11========================================================*/
/*===================================================LCD===========================================================*/
void lcd_lenh(I2C_TypeDef *i2c,uint8_t data)
{
	uint8_t nibble_high=data&(0xF0);
	uint8_t nibble_low=(data<<4)&(0xF0);
	uint8_t buf[4];
	buf[0]=nibble_high | 0x0C;
	buf[1]=nibble_high | 0x08;
	buf[2]=nibble_low | 0x0C;
	buf[3]=nibble_low | 0x08;
	i2c_mutil_data(i2c,0x4E,(uint8_t*)buf,4U);
}
void lcd_data(I2C_TypeDef *i2c,uint8_t data)
{
	uint8_t nibble_high=data&(0xF0);
	uint8_t nibble_low=(data<<4)&(0xF0);
	uint8_t buf[4];
	buf[0]=nibble_high | 0x0D;
	buf[1]=nibble_high | 0x09;
	buf[2]=nibble_low | 0x0D;
	buf[3]=nibble_low | 0x09;
	i2c_mutil_data(i2c,0x4E,(uint8_t*)buf,4U);
}
void lcd_init(I2C_TypeDef *i2c)
{
	 lcd_lenh(i2c,0x33);
   lcd_lenh(i2c,0x32);
   task_delay(2);
   lcd_lenh(i2c,0x28);
   task_delay(2);
   lcd_lenh(i2c,0x01);
   task_delay(2);
   lcd_lenh(i2c,0x06);
   task_delay(2);
   lcd_lenh(i2c,0x0C);
   task_delay(2);
   lcd_lenh(i2c,0x02);
   task_delay(2);
   lcd_lenh(i2c,0x80);
}
void lcd_string(I2C_TypeDef *i2c,const char* s)
{
	while(*s != '\0')
	{
		lcd_data(i2c,*s);
		s++;
	}
}
void lcd_gotoxy(I2C_TypeDef *i2c,uint8_t hang,uint8_t cot)
{
	uint8_t lenh=0x00;
	if(hang==1)
	{
		lenh= 0x80 + cot;
	}
	else if(hang==2)
	{
		lenh = 0xC0 + cot;
	}
	else if(hang==3)
	{
		lenh = 0x94 + cot;
	}
	else if(hang==4)
	{
		lenh = 0xD4 + cot;
	}
	lcd_lenh(i2c,lenh);
	task_delay(2);
}
char* covert_string(uint16_t data,char *s)
{
	uint16_t dem=0;
  uint16_t tmp=data;
  while(tmp / 10 != 0)
  {
    dem++;
    tmp=tmp/10;
  }
  dem++;
  s[dem]='\0';
  while(data / 10 != 0)
  {
    dem--;
    s[dem] = data%10 + '0';
    data=data/10;
  }
  dem--;
  s[dem] = (char)(data + '0');
  return s;
}
/*===================================================LCD===========================================================*/
/*===================================================STEP_MOTOR====================================================*/
void STEP_MOTOR_INIT(void)
{
	RCC->APB2ENR |= (1U<<2);
	/*configuration for pin A5 - DIRECTION*/
	GPIOA->CRL &= ~(15U<<20);
	GPIOA->CRL |= (3U<<20);
	GPIOA->BSRR |= (1U<<21);
	/*configuration for pin A6 - STEP*/
	GPIOA->CRL &= ~(15U<<24);
	GPIOA->CRL |= (3U<<24);
	GPIOA->BSRR |= (1U<<22);
	/*configuration for pin A7 - ENABLE*/
	GPIOA->CRL &= ~(15U<<28);
	GPIOA->CRL |= (3U<<28);
	GPIOA->BSRR |= (1U<<23); // enable module
}
void MOTOR_DIRECTION(Direction_Typedef direct)
{
	if(direct == clockwise)
	{
		GPIOA->BSRR |= (1U<<21);
	}
	else
	{
		GPIOA->BSRR |= (1U<<5);
	}
  uint32_t x;
  for(x = 0; x < 200; x++) 
  {
		GPIOA->BSRR |= (1U<<6);
		task_delay(1);
    GPIOA->BSRR |= (1U<<22);
		task_delay(1);
  }
}
void START_ROTATION(Revolution_Typedef Revolution,Direction_Typedef direct)
{
	bool check =  true;
	check &= assert_paramater(IS_REVOLUTION_TYPEDEF(Revolution));
	check &= assert_paramater(IS_DIRECTION_TYPEDEF(direct));
	if(check == true)
	{
		if(direct == clockwise)
		{
			GPIOA->BSRR |= (1U<<21);
		}
		else
		{
			GPIOA->BSRR |= (1U<<5);
		}
		uint32_t dem = 0U;
		for(dem = 0U;dem < (uint32_t)Revolution;dem++)
		{
		GPIOA->BSRR |= (1U<<6);
		task_delay(1);
    GPIOA->BSRR |= (1U<<22);
		task_delay(1);
		}
	}
	else return;
}
/*===================================================STEP_MOTOR====================================================*/
/*===================================================RTC_1307======================================================*/
DATA_RTC_Typedef data_RTC_initial = {0x00};
uint8_t bin_dec(uint8_t data)
{
	 uint8_t bit_h = data/10;
   uint8_t bit_l = data%10;
   return (uint8_t)((bit_h<<4) | bit_l);
}
uint8_t dec_bin(uint8_t data)
{
	data_RTC_initial.data = data;
  uint8_t bit_h = data_RTC_initial._data.bit7*8 + data_RTC_initial._data.bit6*4 + data_RTC_initial._data.bit5*2 + data_RTC_initial._data.bit4;
  uint8_t bit_l = data_RTC_initial._data.bit3*8 + data_RTC_initial._data.bit2*4 + data_RTC_initial._data.bit1*2 + data_RTC_initial._data.bit0;
  return bit_h*10 + bit_l;
}
void RTC_set(I2C_TypeDef *I2C,MY_RTC_Typedef *p_RTC)
{
	i2c_start((I2C_TypeDef *)I2C);
	i2c_adress((I2C_TypeDef *)I2C,0xD0);
	i2c_data((I2C_TypeDef *)I2C,0x00);
	i2c_data((I2C_TypeDef *)I2C,bin_dec(p_RTC->second));
	i2c_data((I2C_TypeDef *)I2C,bin_dec(p_RTC->minutes));
	i2c_data((I2C_TypeDef *)I2C,bin_dec(p_RTC->hours));
	i2c_data((I2C_TypeDef *)I2C,bin_dec(p_RTC->day));
	i2c_data((I2C_TypeDef *)I2C,bin_dec(p_RTC->date));
	i2c_data((I2C_TypeDef *)I2C,bin_dec(p_RTC->month));
	i2c_data((I2C_TypeDef *)I2C,bin_dec(p_RTC->year));
	i2c_stop((I2C_TypeDef *)I2C);
}
void RTC_get(I2C_TypeDef *I2C,MY_RTC_Typedef *p_RTC)
{
	uint8_t dem = 0U;
	uint8_t data[7U]={0U,0U,0U,0U,0U,0U,0U};
	i2c_start((I2C_TypeDef *)I2C);
	i2c_adress((I2C_TypeDef *)I2C,0xD0);
	i2c_data((I2C_TypeDef *)I2C,0x00);
	i2c_start((I2C_TypeDef *)I2C);
	i2c_read((I2C_TypeDef *)I2C,0xD1,(uint8_t*)data,1U);
	i2c_stop((I2C_TypeDef *)I2C);
	for(dem = 0U; dem < 7U; dem++)
	{
		*(uint8_t*)((uint8_t*)p_RTC + dem) = dec_bin(data[dem]);
	}
}
/*===================================================RTC_1307======================================================*/
/*===================================================74HC595=======================================================*/
void IC74HC595_config(void)
{
	RCC->APB2ENR |= (1U<<2);//enable clock for  port a
	/*configuration for pin A8 - ST*/
	GPIOA->CRH &= ~(15U<<0);
	GPIOA->CRH |= (3U<<0);
	GPIOA->BRR |= (1U<<8);//reset
	/*configuration for pin A11 - ds*/
	GPIOA->CRH &= ~(15U<<12);
	GPIOA->CRH |= (3U<<12);
	GPIOA->BRR |= (1U<<11);
	/*configuration for pin A12 - SH*/
	GPIOA->CRH &= ~(15U<<16);
	GPIOA->CRH |= (3U<<16);
	GPIOA->BRR |= (1U<<12);//set
}
void IC74HC595_start(uint8_t data)
{
	uint8_t dem =0;
	uint8_t data1 = data;
	for(dem =0;dem<8;dem++)
	{
		if(((data1>>7)&0x01) == 1U)
		{
			GPIOA->BSRR |= (1U<<11);
		}
		else 
		{
			GPIOA->BRR |= (1U<<11);
		}
		GPIOA->BRR |= (1U<<12);
		GPIOA->BSRR |= (1U<<12);
		data1 = (uint8_t)(data1 << 1U);
	}
	GPIOA->BRR |= (1U<<8);
	GPIOA->BSRR |= (1U<<8);
}
/*===================================================74HC595=======================================================*/
/*===================================================control_peripheral============================================*/
uint8_t str_len(char* s)
{
	static uint8_t i=0;
	while(*s != '\0')
	{
		i++;
		s++;
	}
	return i;
}
char* invert(char* s)
{
	uint8_t left = 2U;
	uint8_t right = str_len(s) - 4U;
	while(left < right)
	{
		char c = *(s+left);
		*(s+left) = *(s+right);
		*(s+right) = c;
		left++;
		right--;
	}
	return s;
}
char* update_value(uint8_t data,char *s)
{
	uint8_t i=0;
	for(i=0;i<8U;i++)
	{
		if((data&(1<<i)) != 0U)
		{
			*(s + (int)(((uint8_t)i+1U)*2U)) = '1';
		}
		else *(s+(int)(((uint8_t)i+1U)*2U)) = '0';
	}
//	invert(s);
	return s;
}
/*===================================================control_peripheral============================================*/
/*===================================================SETTING_TIME_WATER_TREE=======================================*/
void timer1_configuration(void)
{
	RCC->APB2ENR |= (1U<<11); // enable clock for timer 1
	TIM1->CR1 |= (1U<<7);
	TIM1->CR1 &= ~(3U);
	TIM1->ARR = 10000U - 1U;
	TIM1->PSC = 72U - 1U;
	TIM1->CNT = 0U;
	TIM1->RCR = 100U - 1U;
	TIM1->EGR |= (1U<<0);
	TIM1->DIER |= (1U<<0);//enable interrupt;
	TIM1->CR1 |= (1U<<0);
}
/*===================================================SETTING_TIME_WATER_TREE=======================================*/
