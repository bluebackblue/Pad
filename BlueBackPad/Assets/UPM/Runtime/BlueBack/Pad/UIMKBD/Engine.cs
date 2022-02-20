

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Pad.UIMKBD
*/
namespace BlueBack.Pad.UIMKBD
{
	/** Engine
	*/
	public sealed class Engine : Engine_Base
	{
		/** param
		*/
		public Param param;

		/** constructor
		*/
		public Engine(in InitParam a_initparam)
		{
			this.param.dir_l		= a_initparam.dir_l;
			this.param.dir_r		= a_initparam.dir_r;
			this.param.dir_u		= a_initparam.dir_u;
			this.param.dir_d		= a_initparam.dir_d;

			this.param.button_l		= a_initparam.button_l;
			this.param.button_r		= a_initparam.button_r;
			this.param.button_u		= a_initparam.button_u;
			this.param.button_d		= a_initparam.button_d;

			this.param.menu_l		= a_initparam.menu_l;
			this.param.menu_r		= a_initparam.menu_r;
			this.param.stick_l_xm	= a_initparam.stick_l_xm;
			this.param.stick_l_xp	= a_initparam.stick_l_xp;
			this.param.stick_l_ym	= a_initparam.stick_l_ym;
			this.param.stick_l_yp	= a_initparam.stick_l_yp;
			this.param.stick_r_xm	= a_initparam.stick_r_xm;
			this.param.stick_r_xp	= a_initparam.stick_r_xp;
			this.param.stick_r_ym	= a_initparam.stick_r_ym;
			this.param.stick_r_yp	= a_initparam.stick_r_yp;

			this.param.trigger_l_1	= a_initparam.trigger_l_1;
			this.param.trigger_l_2	= a_initparam.trigger_l_2;
			this.param.trigger_l_3	= a_initparam.trigger_l_3;
			this.param.trigger_r_1	= a_initparam.trigger_r_1;
			this.param.trigger_r_2	= a_initparam.trigger_r_2;
			this.param.trigger_r_3	= a_initparam.trigger_r_3;
		}

		/** [BlueBack.Pad.Engine_Base]作成。
		*/
		public void Create()
		{
		}

		/** [BlueBack.Pad.Engine_Base]削除。
		*/
		public void Delete()
		{
		}

		/** [BlueBack.Pad.Engine_Base]更新。
		*/
		public void PreUpdate()
		{
		}

		/** [BlueBack.Pad.Engine_Base]スティック。左。取得。
		*/
		public UnityEngine.Vector2 GetStickL()
		{
			float t_x = 0.0f;

			if(UnityEngine.Input.GetKey(this.param.stick_l_xm) == true){
				t_x = -1.0f;
			}else if(UnityEngine.Input.GetKey(this.param.stick_l_xp) == true){
				t_x = 1.0f;
			}

			float t_y = 0.0f;

			if(UnityEngine.Input.GetKey(this.param.stick_l_ym) == true){
				t_y = -1.0f;
			}else if(UnityEngine.Input.GetKey(this.param.stick_l_yp) == true){
				t_y = 1.0f;
			}

			return new UnityEngine.Vector2(t_x,t_y);
		}

		/** [BlueBack.Pad.Engine_Base]スティック。左。取得。
		*/
		public UnityEngine.Vector2 GetStickR()
		{
			float t_x = 0.0f;

			if(UnityEngine.Input.GetKey(this.param.stick_r_xm) == true){
				t_x = -1.0f;
			}else if(UnityEngine.Input.GetKey(this.param.stick_r_xp) == true){
				t_x = 1.0f;
			}

			float t_y = 0.0f;

			if(UnityEngine.Input.GetKey(this.param.stick_r_ym) == true){
				t_y = -1.0f;
			}else if(UnityEngine.Input.GetKey(this.param.stick_r_yp) == true){
				t_y = 1.0f;
			}

			return new UnityEngine.Vector2(t_x,t_y);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。右。取得。
		*/
		public bool GetDirR()
		{
			return UnityEngine.Input.GetKey(this.param.dir_r);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。下。取得。
		*/
		public bool GetDirD()
		{
			return UnityEngine.Input.GetKey(this.param.dir_d);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。左。取得。
		*/
		public bool GetDirL()
		{
			return UnityEngine.Input.GetKey(this.param.dir_l);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。上。取得。
		*/
		public bool GetDirU()
		{
			return UnityEngine.Input.GetKey(this.param.dir_u);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。右。取得。
		*/
		public bool GetButtonR()
		{
			return UnityEngine.Input.GetKey(this.param.button_r);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。下。取得。
		*/
		public bool GetButtonD()
		{
			return UnityEngine.Input.GetKey(this.param.button_d);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。左。取得。
		*/
		public bool GetButtonL()
		{
			return UnityEngine.Input.GetKey(this.param.button_l);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。上。取得。
		*/
		public bool GetButtonU()
		{
			return UnityEngine.Input.GetKey(this.param.button_u);
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左１。取得。
		*/
		public bool GetTriggerL1()
		{
			return UnityEngine.Input.GetKey(this.param.trigger_l_1);
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左２。取得。
		*/
		public float GetTriggerL2()
		{
			return UnityEngine.Input.GetKey(this.param.trigger_l_2) ? 1.0f : 0.0f;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左３。取得。
		*/
		public bool GetTriggerL3()
		{
			return UnityEngine.Input.GetKey(this.param.trigger_l_3);
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右１。取得。
		*/
		public bool GetTriggerR1()
		{
			return UnityEngine.Input.GetKey(this.param.trigger_r_1);
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右２。取得。
		*/
		public float GetTriggerR2()
		{
			return UnityEngine.Input.GetKey(this.param.trigger_r_2) ? 1.0f : 0.0f;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右３。取得。
		*/
		public bool GetTriggerR3()
		{
			return UnityEngine.Input.GetKey(this.param.trigger_r_3);
		}

		/** [BlueBack.Pad.Engine_Base]メニュー。左。取得。
		*/
		public bool GetMenuL()
		{
			return UnityEngine.Input.GetKey(this.param.menu_l);
		}

		/** [BlueBack.Pad.Engine_Base]メニュー。右。取得。
		*/
		public bool GetMenuR()
		{
			return UnityEngine.Input.GetKey(this.param.menu_r);
		}
	}
}

