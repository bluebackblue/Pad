

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Pad.UISKBD
*/
namespace BlueBack.Pad.UISKBD
{
	/** InitParam
	*/
	public struct InitParam
	{
		/** dir
		*/
		public UnityEngine.InputSystem.Controls.ButtonControl dir_l;
		public UnityEngine.InputSystem.Controls.ButtonControl dir_r;
		public UnityEngine.InputSystem.Controls.ButtonControl dir_u;
		public UnityEngine.InputSystem.Controls.ButtonControl dir_d;

		/** button
		*/
		public UnityEngine.InputSystem.Controls.ButtonControl button_l;
		public UnityEngine.InputSystem.Controls.ButtonControl button_r;
		public UnityEngine.InputSystem.Controls.ButtonControl button_u;
		public UnityEngine.InputSystem.Controls.ButtonControl button_d;

		/** menu
		*/
		public UnityEngine.InputSystem.Controls.ButtonControl menu_l;
		public UnityEngine.InputSystem.Controls.ButtonControl menu_r;

		/** stick
		*/
		public UnityEngine.InputSystem.Controls.ButtonControl stick_l_xm;
		public UnityEngine.InputSystem.Controls.ButtonControl stick_l_xp;
		public UnityEngine.InputSystem.Controls.ButtonControl stick_l_ym;
		public UnityEngine.InputSystem.Controls.ButtonControl stick_l_yp;
		public UnityEngine.InputSystem.Controls.ButtonControl stick_r_xm;
		public UnityEngine.InputSystem.Controls.ButtonControl stick_r_xp;
		public UnityEngine.InputSystem.Controls.ButtonControl stick_r_ym;
		public UnityEngine.InputSystem.Controls.ButtonControl stick_r_yp;

		/** trigger
		*/
		public UnityEngine.InputSystem.Controls.ButtonControl trigger_l_1;
		public UnityEngine.InputSystem.Controls.ButtonControl trigger_l_2;
		public UnityEngine.InputSystem.Controls.ButtonControl trigger_l_3;
		public UnityEngine.InputSystem.Controls.ButtonControl trigger_r_1;
		public UnityEngine.InputSystem.Controls.ButtonControl trigger_r_2;
		public UnityEngine.InputSystem.Controls.ButtonControl trigger_r_3;

		/** CreateDefault
		*/
		public static InitParam CreateDefault()
		{
			return new InitParam(){
				dir_l =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.A],
				dir_r =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.D],
				dir_u =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.W],
				dir_d =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.S],

				button_l =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Z],
				button_r =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.X],
				button_u =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.C],
				button_d =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.V],

				menu_l =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Escape],
				menu_r =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Backspace],

				stick_l_xm = UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.LeftArrow],
				stick_l_xp = UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.RightArrow],
				stick_l_ym = UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.UpArrow],
				stick_l_yp = UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.DownArrow],
				stick_r_xm = UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Numpad4],
				stick_r_xp = UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Numpad6],
				stick_r_ym = UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Numpad8],
				stick_r_yp = UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Numpad2],

				trigger_l_1 =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.LeftCtrl],
				trigger_l_2 =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.LeftShift],
				trigger_l_3 =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Tab],
				trigger_r_1 =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.RightCtrl],
				trigger_r_2 =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.RightShift],
				trigger_r_3 =  UnityEngine.InputSystem.Keyboard.current[UnityEngine.InputSystem.Key.Enter],
			};
		}
	}
}

