

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Pad.UISKBD
*/
namespace BlueBack.Pad.UISKBD
{
	/** Param
	*/
	#if(ENABLE_INPUT_SYSTEM)
	public struct Param
	{
		/** device
		*/
		public UnityEngine.InputSystem.Keyboard device;

		/** enable
		*/
		public bool enable;

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
	}
	#endif
}

