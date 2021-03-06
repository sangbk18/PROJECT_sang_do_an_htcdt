#include "My_application_stm32f1xx.h"
#include "MY_RTOS.h"
static char str[21] ="< 0=0=0=0=0=0=0=0  >";/*control all device outside board*/
/*=====================================define_fuction_pointer======================================*/
/*--------------------------------dht11_define----------------------------*/
void my_fuction_dht_implement(void *p,TYPE_Typedef type)
{
if(type == _DHT11_FUNC_TYPEDEF)
	{
		char s[10] = "";
    DHT11_init((TIM_TypeDef*)(((FUNC_DHT11_Typedef*)p)->time_dht11_used),(GPIO_TypeDef*)(((FUNC_DHT11_Typedef*)p)->gpio_dht11_used),(DHT11_PIN_Typedef)(((FUNC_DHT11_Typedef*)p)->pin_dht11_used));
		read_5_byte((TIM_TypeDef*)(((FUNC_DHT11_Typedef*)p)->time_dht11_used),(GPIO_TypeDef*)(((FUNC_DHT11_Typedef*)p)->gpio_dht11_used),(DHT11_PIN_Typedef)(((FUNC_DHT11_Typedef*)p)->pin_dht11_used),(DATA_DHT11_Typedef*)(((FUNC_DHT11_Typedef*)p)->data_dht11));
		lcd_gotoxy((I2C_TypeDef*)(((FUNC_DHT11_Typedef*)p)->I2C),2,16);
		lcd_string((I2C_TypeDef*)(((FUNC_DHT11_Typedef*)p)->I2C),covert_string((( volatile DATA_DHT11_Typedef*)(((FUNC_DHT11_Typedef*)p)->data_dht11))->nhiet_do_in,s));
	  lcd_gotoxy((I2C_TypeDef*)(((FUNC_DHT11_Typedef*)p)->I2C),3,16);
	  lcd_string((I2C_TypeDef*)(((FUNC_DHT11_Typedef*)p)->I2C),covert_string(((volatile DATA_DHT11_Typedef*)(((FUNC_DHT11_Typedef*)p)->data_dht11))->do_am_in,s));
	}
}
/*=====================================define_fuction_pointer======================================*/
/*=======================================BOOTLOADER================================================*/
void start_update_application(void *p,TYPE_Typedef type)
{
	p=NULL;
	type = 0;
	task_delay(3000);
	bootloader_init(ADDRESS_BOOTLOADER);
	
}
/*=======================================BOOTLOADER================================================*/
MENU_Typedef MAIN_MENU = {
	ID_MAIN_MENU,
	NULL,
	"      MAIN_MENU    ",
	"  GARDEN_1         ",
	&GARDEN_1,{NULL,NULL,NULL},
	"  GARDEN_2         ",
	&GARDEN_2,{NULL,NULL,NULL},
	"  UPDATE_VERSION:",
	NULL,{NULL,NULL,NULL},
};
/*===========================*/
MENU_Typedef GARDEN_1 = {
	ID_GARDEN_1,
	&MAIN_MENU,
	"      GARDEN_1      ",
	"  SENSORS           ",
	&SENSORS_1,{NULL,NULL,NULL},
	"  ACTUATORS         ",
	&ACTUATORS_1,{NULL,NULL,NULL},
	"  SETTING           ",
	&SETTING_1,{NULL,NULL,NULL},
};
MENU_Typedef GARDEN_2 = {
	ID_GARDEN_2,
	&MAIN_MENU,
	"      GARDEN_2      ",
	"  SENSORS           ",
	NULL,{NULL,NULL,NULL},
	"  ACTUATORS         ",
	NULL,{NULL,NULL,NULL},
	"  SETTING           ",
	NULL,{NULL,NULL,NULL},
};
MENU_Typedef UPDATE = {
	ID_UPDATE,
	&MAIN_MENU,
	"      UPDATE        ",
	"  YES_UPDATE        ",
	NULL,{NULL,NULL,&start_update_application},
	"  NO_UPDATE         ",
	NULL,{NULL,NULL,NULL},
	"  THAI_VAN_SANG     ",
	NULL,{NULL,NULL,NULL},
};
/*===========================*/
/*---------------------------------------------------------DEFINNE GARDEN 1------------------------------------------------------------*/
MENU_Typedef SENSORS_1 = {
	ID_SENSORS_1,
	&GARDEN_1,
	"     SENSORS_1      ",
	"  DHT11             ",
	&DHT11_1,{NULL,NULL,NULL},
	"  RAIN_SENSOR       ",
	NULL,{NULL,NULL,NULL},
	"  ADD_SENSORS       ",
	NULL,{NULL,NULL,NULL},
};
MENU_Typedef ACTUATORS_1 = {
	ID_ACTUATORS_1,
	&GARDEN_1,
	"    ACTUATORS_1     ",
	"  PUMP              ",
	&PUMP_1,{NULL,NULL,NULL},
	"  OUTHOUSE          ",
	&OUTHOUSE_1,{NULL,NULL,NULL},
	"  CONTROL           ",
	&CONTROL_1,{NULL,NULL,NULL},
};
MENU_Typedef PUMP_1 = {
	ID_PUMP_1,
	&ACTUATORS_1,
	"       PUMP1        ",
	"  ON                ",
	NULL,{NULL,NULL,NULL},
	"  OFF               ",
	NULL,{NULL,NULL,NULL},
	"  AUTOMATION :      ",
	NULL,{NULL,NULL,NULL},
};
MENU_Typedef CONTROL_1 = {
	ID_CONTROL_1,
	&ACTUATORS_1,
	"      CONTROL       ",
	"< 0=0=0=0=0=0=0=0  >",
	NULL,{NULL,NULL,NULL},
	"                    ",
	NULL,{NULL,NULL,NULL},
	" TVS  : 1:OFF / O:ON",
	NULL,{NULL,NULL,NULL},
};
MENU_Typedef SETTING_1 = {
	ID_SETTING_1,
	&GARDEN_1,
	"     SETTING_1      ",
	"  ACTIVE_1          ",
	NULL,{NULL,NULL,NULL},
	"  ACTIVE_2          ",
	NULL,{NULL,NULL,NULL},
	"  ACTIVE_3          ",
	NULL,{NULL,NULL,NULL},
};
MENU_Typedef DHT11_1 = {
	ID_DHT11_1,
	&SENSORS_1,
	"       DHT11        ",
	"  NHIET DO :        ",
	NULL,{&my_fuction_dht_implement,NULL,NULL},
	"  DO AM    :        ",
	NULL,{NULL,NULL,NULL},
	"  THRESOLD          ",
	&THRESOLD_1,{NULL,NULL,NULL},
};
MENU_Typedef THRESOLD_1= {
	ID_THRESOLD_1,
	&DHT11_1,
	"     THRESOLD_1     ",
	" THRESOLD_TEM :      ",
	NULL,{NULL,NULL,NULL},
	" THRESOLD_HUM :      ",
	NULL,{NULL,NULL,NULL},
	" SAVE_DATA           ",
	NULL,{NULL,NULL,NULL},
};
MENU_Typedef OUTHOUSE_1 = {
	ID_OUTHOUSE_1,
	&ACTUATORS_1,
	"     OUTHOUSE_1     ",
	"  PULL IN           ",
	NULL,{NULL,NULL,NULL},
	"  PUSH OUT          ",
	NULL,{NULL,NULL,NULL},
	"  HINT ! 1_STEP = 45",
	NULL,{NULL,NULL,NULL},
};
/*---------------------------------------------------------DEFINNE GARDEN 1------------------------------------------------------------*/
/*===================================define_fuction======================================*/
char S_SAMPLE[20] = "";

void hienthi(I2C_TypeDef* I2C,volatile MENU_Typedef *menu,volatile uint8_t position)
{
	  if(menu->ID == ID_THRESOLD_1)
		{
			lcd_gotoxy(I2C,1,0);
			lcd_string(I2C,menu->title_main);
			lcd_gotoxy(I2C,2,0);
			lcd_string(I2C,menu->title_node_1);
			lcd_gotoxy(I2C,3,0);
			lcd_string(I2C,menu->title_node_2);
			lcd_gotoxy(I2C,4,0);
			lcd_string(I2C,menu->title_node_3);
			lcd_gotoxy(I2C,position,0);
			lcd_string(I2C,">");
			FLash_read_half_word(adress_flash_start,(volatile uint32_t*)&data_thresold,2U);
			lcd_gotoxy(I2C,2,16);
			lcd_string(I2C,covert_string((uint16_t)data_thresold.THRESOLD_TEM_VAL,S_SAMPLE));
			lcd_gotoxy(I2C,3,16);
			lcd_string(I2C,covert_string((uint16_t)data_thresold.THRESOLD_HUM_VAL,S_SAMPLE));
		}
		else if(menu->ID == ID_PUMP_1)
		{
			lcd_gotoxy(I2C,1,0);
			lcd_string(I2C,menu->title_main);
			lcd_gotoxy(I2C,2,0);
			lcd_string(I2C,menu->title_node_1);
			lcd_gotoxy(I2C,3,0);
			lcd_string(I2C,menu->title_node_2);
			lcd_gotoxy(I2C,4,0);
			lcd_string(I2C,menu->title_node_3);
			lcd_gotoxy(I2C,position,0);
			lcd_string(I2C,">");
			FLash_read_half_word(adress_flash_start,(volatile uint32_t*)&data_thresold,4U);
			lcd_gotoxy(I2C,4,15);
      lcd_string(I2C,covert_string((uint16_t)data_thresold.value_time_setting,S_SAMPLE));
		}
		else if(menu->ID == ID_OUTHOUSE_1)
		{
			lcd_gotoxy(I2C,1,0);
			lcd_string(I2C,menu->title_main);
			lcd_gotoxy(I2C,2,0);
			lcd_string(I2C,menu->title_node_1);
			lcd_gotoxy(I2C,3,0);
			lcd_string(I2C,menu->title_node_2);
			lcd_gotoxy(I2C,4,0);
			lcd_string(I2C,menu->title_node_3);
			lcd_gotoxy(I2C,position,0);
			lcd_string(I2C,">");
		}
		else if(menu->ID == ID_MAIN_MENU)
		{
			lcd_gotoxy(I2C,1,0);
			lcd_string(I2C,menu->title_main);
			lcd_gotoxy(I2C,2,0);
			lcd_string(I2C,menu->title_node_1);
			lcd_gotoxy(I2C,3,0);
			lcd_string(I2C,menu->title_node_2);
			lcd_gotoxy(I2C,4,0);
			lcd_string(I2C,menu->title_node_3);
			lcd_gotoxy(I2C,position,0);
			lcd_string(I2C,">");
			if(frame_data_bootloader[1] == 'a' && frame_data_bootloader[2] == 'n' && frame_data_bootloader[3] == 'g' )
			{
				lcd_gotoxy((I2C_TypeDef*)_I2C1_ADRESS,4,17);
				lcd_string((I2C_TypeDef*)_I2C1_ADRESS,"(*)");
				MAIN_MENU.p_menu_3 = &UPDATE;
			}
		}
		else if(menu->ID == ID_CONTROL_1)
		{
			lcd_gotoxy(I2C,1,0);
			lcd_string(I2C,menu->title_main);
			lcd_gotoxy(I2C,2,0);
			menu->title_node_1 = update_value(DATA_PERIPHERAL.data,&str[0]);/*display on screen bit 7 - bit 0*/
			lcd_string(I2C,menu->title_node_1);
			lcd_gotoxy(I2C,3,0);
			lcd_string(I2C,menu->title_node_2);
			lcd_gotoxy(I2C,4,0);
			lcd_string(I2C,menu->title_node_3);
			lcd_gotoxy(I2C,3U,position_control);
			lcd_string(I2C,"^");
		}
		else
		{
			lcd_gotoxy(I2C,1,0);
			lcd_string(I2C,menu->title_main);
			lcd_gotoxy(I2C,2,0);
			lcd_string(I2C,menu->title_node_1);
			lcd_gotoxy(I2C,3,0);
			lcd_string(I2C,menu->title_node_2);
			lcd_gotoxy(I2C,4,0);
			lcd_string(I2C,menu->title_node_3);
			lcd_gotoxy(I2C,position,0);
			lcd_string(I2C,">");
		}
}
/*===================================define_fuction======================================*/
