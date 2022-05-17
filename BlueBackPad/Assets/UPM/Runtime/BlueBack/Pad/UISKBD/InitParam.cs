

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** define
*/
#if(ASMDEF_COM_UNITY_INPUTSYSTEM)
#define ASMDEF_TRUE
#else
#warning "ASMDEF_TRUE"
#endif


/** BlueBack.Pad.UISKBD
*/
#if(ASMDEF_TRUE)
namespace BlueBack.Pad.UISKBD
{
	/** InitParam
	*/
	public struct InitParam
	{
		/** device
		*/
		public UnityEngine.InputSystem.Keyboard device;

		/** 十字。
		*/
		public UnityEngine.InputSystem.Key dir_l;
		public UnityEngine.InputSystem.Key dir_r;
		public UnityEngine.InputSystem.Key dir_u;
		public UnityEngine.InputSystem.Key dir_d;

		/** ボタン。
		*/
		public UnityEngine.InputSystem.Key button_l;
		public UnityEngine.InputSystem.Key button_r;
		public UnityEngine.InputSystem.Key button_u;
		public UnityEngine.InputSystem.Key button_d;

		/** メニュー。
		*/
		public UnityEngine.InputSystem.Key menu_l;
		public UnityEngine.InputSystem.Key menu_r;

		/** スティック。
		*/
		public UnityEngine.InputSystem.Key stick_l_xm;
		public UnityEngine.InputSystem.Key stick_l_xp;
		public UnityEngine.InputSystem.Key stick_l_ym;
		public UnityEngine.InputSystem.Key stick_l_yp;
		public UnityEngine.InputSystem.Key stick_r_xm;
		public UnityEngine.InputSystem.Key stick_r_xp;
		public UnityEngine.InputSystem.Key stick_r_ym;
		public UnityEngine.InputSystem.Key stick_r_yp;

		/** トリガー。
		*/
		public UnityEngine.InputSystem.Key trigger_l_1;
		public UnityEngine.InputSystem.Key trigger_l_2;
		public UnityEngine.InputSystem.Key trigger_l_3;
		public UnityEngine.InputSystem.Key trigger_r_1;
		public UnityEngine.InputSystem.Key trigger_r_2;
		public UnityEngine.InputSystem.Key trigger_r_3;

		/** CreateDefault
		*/
		public static InitParam CreateDefault()
		{
			return new InitParam(){
				device		= UnityEngine.InputSystem.Keyboard.current,

				dir_l		=  UnityEngine.InputSystem.Key.A,
				dir_r		=  UnityEngine.InputSystem.Key.D,
				dir_u		=  UnityEngine.InputSystem.Key.W,
				dir_d		=  UnityEngine.InputSystem.Key.S,

				button_l	=  UnityEngine.InputSystem.Key.Z,
				button_r	=  UnityEngine.InputSystem.Key.X,
				button_u	=  UnityEngine.InputSystem.Key.C,
				button_d	=  UnityEngine.InputSystem.Key.V,

				menu_l		=  UnityEngine.InputSystem.Key.Escape,
				menu_r		=  UnityEngine.InputSystem.Key.Backspace,

				stick_l_xm	= UnityEngine.InputSystem.Key.LeftArrow,
				stick_l_xp	= UnityEngine.InputSystem.Key.RightArrow,
				stick_l_ym	= UnityEngine.InputSystem.Key.UpArrow,
				stick_l_yp	= UnityEngine.InputSystem.Key.DownArrow,
				stick_r_xm	= UnityEngine.InputSystem.Key.Numpad4,
				stick_r_xp	= UnityEngine.InputSystem.Key.Numpad6,
				stick_r_ym	= UnityEngine.InputSystem.Key.Numpad8,
				stick_r_yp	= UnityEngine.InputSystem.Key.Numpad2,

				trigger_l_1	=  UnityEngine.InputSystem.Key.LeftCtrl,
				trigger_l_2	=  UnityEngine.InputSystem.Key.LeftShift,
				trigger_l_3	=  UnityEngine.InputSystem.Key.Tab,
				trigger_r_1	=  UnityEngine.InputSystem.Key.RightCtrl,
				trigger_r_2	=  UnityEngine.InputSystem.Key.RightShift,
				trigger_r_3	=  UnityEngine.InputSystem.Key.Enter,
			};
		}
	}
}
#endif

