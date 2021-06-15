

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Pad.UIM
*/
namespace BlueBack.Pad.UIM
{
	/** Param
	*/
	public class Param
	{
		/** Param
		*/
		public enum ParamType
		{
			/** PSコントローラ。全コントローラ。
			*/
			PS_ALL,
			PS_1,
			PS_2,
			
			/** Xコントローラ。全コントローラ。
			*/
			X_ALL,
			X_1,
			X_2,

			/** Aコントローラ。全コントローラ。
			*/
			A_ALL,
			A_1,
			A_2,
		}

		//アナログスティック。
		public string stick_lx;
		public string stick_ly;
		public string stick_rx;
		public string stick_ry;

		//十字。
		public string dir_x;
		public string dir_y;

		//ボタン。
		public string button_r;
		public string button_d;
		public string button_l;
		public string button_u;

		//トリガー。
		public string trigger_l1;
		public string trigger_l2;
		public string trigger_l3;
		public string trigger_r1;
		public string trigger_r2;
		public string trigger_r3;

		//メニュー。
		public string menu_l;
		public string menu_r;

		/** constructor
		*/
		public Param(ParamType a_type)
		{
			string t_prefix = null;

			switch(a_type){
			case ParamType.PS_ALL:
				{
					t_prefix = "p0_";
				}break;
			case ParamType.PS_1:
				{
					t_prefix = "p1_";
				}break;
			case ParamType.PS_2:
				{
					t_prefix = "p2_";
				}break;
			case ParamType.X_ALL:
				{
					t_prefix = "x0_";
				}break;
			case ParamType.X_1:
				{
					t_prefix = "x1_";
				}break;
			case ParamType.X_2:
				{
					t_prefix = "x2_";
				}break;
			case ParamType.A_ALL:
				{
					t_prefix = "a0_";
				}break;
			case ParamType.A_1:
				{
					t_prefix = "a1_";
				}break;
			case ParamType.A_2:
				{
					t_prefix = "a2_";
				}break;
			}

			{
				this.stick_lx		= t_prefix + "stick_lx";
				this.stick_ly		= t_prefix + "stick_ly";
				this.stick_rx		= t_prefix + "stick_rx";
				this.stick_ry		= t_prefix + "stick_ry";
				this.dir_x			= t_prefix + "dir_x";
				this.dir_y			= t_prefix + "dir_y";
				this.button_r		= t_prefix + "button_r";
				this.button_d		= t_prefix + "button_d";
				this.button_l		= t_prefix + "button_l";
				this.button_u		= t_prefix + "button_u";
				this.trigger_l1		= t_prefix + "trigger_l1";
				this.trigger_l2		= t_prefix + "trigger_l2";
				this.trigger_l3		= t_prefix + "trigger_l3";
				this.trigger_r1		= t_prefix + "trigger_r1";
				this.trigger_r2		= t_prefix + "trigger_r2";
				this.trigger_r3		= t_prefix + "trigger_r3";
				this.menu_l			= t_prefix + "menu_l";
				this.menu_r			= t_prefix + "menu_r";
			}
		}
	}
}

