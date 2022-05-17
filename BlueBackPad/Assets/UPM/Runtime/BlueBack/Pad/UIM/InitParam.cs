

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Pad.UIM
*/
namespace BlueBack.Pad.UIM
{
	/** InitParam
	*/
	public struct InitParam
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

		/** CreateDefault
		*/
		public static InitParam CreateDefault(InitParamType a_type)
		{
			string t_prefix = null;

			switch(a_type){
			case InitParamType.PS_ALL:
				{
					t_prefix = "p0_";
				}break;
			case InitParamType.PS_1:
				{
					t_prefix = "p1_";
				}break;
			case InitParamType.PS_2:
				{
					t_prefix = "p2_";
				}break;
			case InitParamType.X_ALL:
				{
					t_prefix = "x0_";
				}break;
			case InitParamType.X_1:
				{
					t_prefix = "x1_";
				}break;
			case InitParamType.X_2:
				{
					t_prefix = "x2_";
				}break;
			case InitParamType.A_ALL:
				{
					t_prefix = "a0_";
				}break;
			case InitParamType.A_1:
				{
					t_prefix = "a1_";
				}break;
			case InitParamType.A_2:
				{
					t_prefix = "a2_";
				}break;
			}

			float t_trigger_add;
			float t_trigger_mul;
			{
				switch(a_type){
				case InitParamType.PS_1:
				case InitParamType.PS_2:
				case InitParamType.PS_ALL:
					{
						t_trigger_add = 1.0f;
						t_trigger_mul = 0.5f;
					}break;
				default:
					{
						t_trigger_add = 0.0f;
						t_trigger_mul = 1.0f;
					}break;
				}
			}

			return new InitParam(){
				stick_lx		= t_prefix + "stick_lx",
				stick_ly		= t_prefix + "stick_ly",
				stick_rx		= t_prefix + "stick_rx",
				stick_ry		= t_prefix + "stick_ry",
				dir_x			= t_prefix + "dir_x",
				dir_y			= t_prefix + "dir_y",
				button_r		= t_prefix + "button_r",
				button_d		= t_prefix + "button_d",
				button_l		= t_prefix + "button_l",
				button_u		= t_prefix + "button_u",
				trigger_l1		= t_prefix + "trigger_l1",
				trigger_l2		= t_prefix + "trigger_l2",
				trigger_l3		= t_prefix + "trigger_l3",
				trigger_r1		= t_prefix + "trigger_r1",
				trigger_r2		= t_prefix + "trigger_r2",
				trigger_r3		= t_prefix + "trigger_r3",
				trigger_add		= t_trigger_add,
				trigger_mul		= t_trigger_mul,
				menu_l			= t_prefix + "menu_l",
				menu_r			= t_prefix + "menu_r",
			};
		}
	}
}

