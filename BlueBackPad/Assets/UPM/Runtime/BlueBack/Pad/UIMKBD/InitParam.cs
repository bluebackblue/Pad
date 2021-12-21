

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Pad.UIMKBD
*/
namespace BlueBack.Pad.UIMKBD
{
	/** InitParam
	*/
	public struct InitParam
	{
		public UnityEngine.KeyCode dir_l;
		public UnityEngine.KeyCode dir_r;
		public UnityEngine.KeyCode dir_u;
		public UnityEngine.KeyCode dir_d;

		public UnityEngine.KeyCode button_l;
		public UnityEngine.KeyCode button_r;
		public UnityEngine.KeyCode button_u;
		public UnityEngine.KeyCode button_d;

		public UnityEngine.KeyCode menu_l;
		public UnityEngine.KeyCode menu_r;

		public UnityEngine.KeyCode stick_l_xm;
		public UnityEngine.KeyCode stick_l_xp;
		public UnityEngine.KeyCode stick_l_ym;
		public UnityEngine.KeyCode stick_l_yp;
		public UnityEngine.KeyCode stick_r_xm;
		public UnityEngine.KeyCode stick_r_xp;
		public UnityEngine.KeyCode stick_r_ym;
		public UnityEngine.KeyCode stick_r_yp;

		public UnityEngine.KeyCode trigger_l_1;
		public UnityEngine.KeyCode trigger_l_2;
		public UnityEngine.KeyCode trigger_l_3;
		public UnityEngine.KeyCode trigger_r_1;
		public UnityEngine.KeyCode trigger_r_2;
		public UnityEngine.KeyCode trigger_r_3;

		/** CreateDefault
		*/
		public static InitParam CreateDefault()
		{
			return new InitParam(){
				dir_l = UnityEngine.KeyCode.A,
				dir_r = UnityEngine.KeyCode.D,
				dir_u = UnityEngine.KeyCode.W,
				dir_d = UnityEngine.KeyCode.S,

				button_l = UnityEngine.KeyCode.Z,
				button_r = UnityEngine.KeyCode.X,
				button_u = UnityEngine.KeyCode.C,
				button_d = UnityEngine.KeyCode.V,

				menu_l = UnityEngine.KeyCode.Escape,
				menu_r = UnityEngine.KeyCode.Backspace,

				stick_l_xm = UnityEngine.KeyCode.LeftArrow,
				stick_l_xp = UnityEngine.KeyCode.RightArrow,
				stick_l_ym = UnityEngine.KeyCode.UpArrow,
				stick_l_yp = UnityEngine.KeyCode.DownArrow,
				stick_r_xm = UnityEngine.KeyCode.Keypad4,
				stick_r_xp = UnityEngine.KeyCode.Keypad6,
				stick_r_ym = UnityEngine.KeyCode.Keypad8,
				stick_r_yp = UnityEngine.KeyCode.Keypad2,

				trigger_l_1 = UnityEngine.KeyCode.LeftControl,
				trigger_l_2 = UnityEngine.KeyCode.LeftShift,
				trigger_l_3 = UnityEngine.KeyCode.Tab,
				trigger_r_1 = UnityEngine.KeyCode.RightControl,
				trigger_r_2 = UnityEngine.KeyCode.RightShift,
				trigger_r_3 = UnityEngine.KeyCode.Return,
			};
		}
	}
}

