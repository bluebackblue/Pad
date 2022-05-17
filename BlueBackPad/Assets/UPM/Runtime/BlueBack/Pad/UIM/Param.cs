

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Pad.UIM
*/
namespace BlueBack.Pad.UIM
{
	/** Param
	*/
	public struct Param
	{
		/** アナログスティック。
		*/
		public string stick_lx;
		public string stick_ly;
		public string stick_rx;
		public string stick_ry;

		/** 十字。
		*/
		public string dir_x;
		public string dir_y;

		/** ボタン。
		*/
		public string button_r;
		public string button_d;
		public string button_l;
		public string button_u;

		/** トリガー。
		*/
		public string trigger_l1;
		public string trigger_l2;
		public string trigger_l3;
		public string trigger_r1;
		public string trigger_r2;
		public string trigger_r3;
		public float trigger_mul;
		public float trigger_add;

		/** メニュー。
		*/
		public string menu_l;
		public string menu_r;
	}
}

