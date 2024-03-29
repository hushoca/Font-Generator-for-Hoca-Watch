//definition of the FONT type:
struct FONT
{
	uint8_t block_size;
	uint8_t charCount;
	uint8_t charHeight;
	uint8_t charWidth;
	char *name;
	uint16_t chars[];
};

struct FONT baseFont;
baseFont.block_size = 4;
baseFont.charCount = 93;
baseFont.charHeight = 9;
baseFont.charWidth = 6;
baseFont.name = "baseFont";
baseFont.chars[] = {
0x82,0x820,0x200,0x0,	//!
0x369,0x2400,0x0,0x0,	//"
0x28A5,0x3E53,0xE528,0x0,	//#
0x10E4,0x1039,0x2704,0x0,	//$
0x4284,0x6E0,0x4284,0x0,	//%
0xC4,0x10AA,0x4680,0x0,	//&
0x2082,0x0,0x0,0x0,	//'
0x2104,0x1041,0x408,0x0,	//(
0x2041,0x410,0x4108,0x0,	//)
0x2,0x1C21,0x4000,0x0,	//*
0x2,0x8F8,0x8200,0x0,	//+
0x0,0x0,0x8610,0x0,	//,
0x0,0xF8,0x0,0x0,	//-
0x0,0x0,0x8,0x0,	//.
0x841,0x821,0x420,0x0,	///
0x7229,0xAAAB,0x289C,0x0,	//0
0x218A,0x820,0x823E,0x0,	//1
0x7228,0x8421,0x83E,0x0,	//2
0x7220,0x8230,0x289C,0x0,	//3
0x2084,0x1493,0xE104,0x0,	//4
0xFA08,0x3C08,0x289C,0x0,	//5
0x3104,0x3C8A,0x289C,0x0,	//6
0xFA21,0x410,0x4208,0x0,	//7
0x7228,0x9C8A,0x289C,0x0,	//8
0x7228,0x9E08,0x289C,0x0,	//9
0x2,0x0,0x8000,0x0,	//:
0x1,0x0,0x4200,0x0,	//;
0x1,0x9881,0x8180,0x0,	//<
0x0,0x3E03,0xE000,0x0,	//=
0xC,0xC08,0xCC00,0x0,	//>
0x7220,0x8420,0x8008,0x0,	//?
0x7229,0xAA9A,0x48C,0x0,	//@
0x2085,0x148B,0xE8A2,0x0,	//A
0xF228,0xBC8A,0x28BC,0x0,	//B
0x7228,0x2082,0x89C,0x0,	//C
0xF268,0xA28A,0x29BC,0x0,	//D
0xFA28,0x3C82,0x8BE,0x0,	//E
0xF924,0x3C41,0x438,0x0,	//F
0x7328,0x20BA,0x2C9E,0x0,	//G
0x8A28,0xBE8A,0x28A2,0x0,	//H
0x7082,0x820,0x821C,0x0,	//I
0x7841,0x412,0x4918,0x0,	//J
0x8A49,0x28C2,0x8922,0x0,	//K
0xE104,0x1041,0x43E,0x0,	//L
0x8B6D,0xAAAA,0x28A2,0x0,	//M
0x8B2C,0xAAAA,0x69A2,0x0,	//N
0x7228,0xA28A,0x289C,0x0,	//O
0xF228,0xA2F2,0x820,0x0,	//P
0x7228,0xA289,0xC302,0x0,	//Q
0xF228,0xA2F2,0x48A2,0x0,	//R
0x7228,0x1C0A,0x289C,0x0,	//S
0xFAA2,0x820,0x821C,0x0,	//T
0x8A28,0xA28A,0x289C,0x0,	//U
0x8A28,0xA251,0x4208,0x0,	//V
0x8A28,0xAAAA,0xA514,0x0,	//W
0x8945,0x821,0x4522,0x0,	//X
0x8A25,0x1420,0x8208,0x0,	//Y
0xF841,0x821,0x43E,0x0,	//Z
0x3082,0x820,0x820C,0x0,	//[
0x8104,0x820,0x4102,0x0,	//left slash
0x3041,0x410,0x410C,0x0,	//]
0x2140,0x0,0x0,0x0,	//^
0x0,0x0,0x3E,0x0,	//_
0x2040,0x0,0x0,0x0,	//`
0x6,0x2472,0x491E,0x0,	//a
0xC104,0x1C49,0x24BC,0x0,	//b
0x0,0x1C8A,0x89C,0x0,	//c
0x0,0x1C92,0x8C9C,0x0,	//d
0x10A2,0x3C20,0x8A10,0x0,	//e
0x3,0x1238,0x248C,0x0,	//f
0x304,0x1051,0xA492,0x0,	//g
0x80,0x1C20,0x821C,0x0,	//h
0x1003,0x8410,0x4918,0x0,	//i
0x4104,0x1251,0x8512,0x0,	//j
0x6082,0x820,0x821C,0x0,	//k
0x0,0x34AA,0xAAAA,0x0,	//l
0x0,0x2CCA,0x28A2,0x0,	//m
0x0,0x1C8A,0x289C,0x0,	//n
0xB,0x1249,0xC438,0x0,	//o
0x6,0xA491,0xC10E,0x0,	//p
0x0,0x2CCA,0x820,0x0,	//q
0x7,0xA070,0x289C,0x0,	//r
0x4104,0x3C41,0x248C,0x0,	//s
0x0,0x2692,0x491A,0x0,	//t
0x0,0x2289,0x4508,0x0,	//u
0x0,0x22AA,0xA514,0x0,	//v
0x0,0x2250,0x8522,0x0,	//w
0x9,0x2470,0x4918,0x0,	//x
0x0,0x3E10,0x843E,0x0,	//y
0x1082,0x840,0x8204,0x0,	//z
0x2082,0x820,0x8208,0x0,	//{
0x2041,0x408,0x4108,0x0,	//|
0x0,0x12B0,0x0,0x0 	//}
};