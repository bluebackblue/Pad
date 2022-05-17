

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Pad.UIM
*/
namespace BlueBack.Pad.UIM
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
			this.param.stick_lx		= a_initparam.stick_lx;
			this.param.stick_ly		= a_initparam.stick_ly;
			this.param.stick_rx		= a_initparam.stick_rx;
			this.param.stick_ry		= a_initparam.stick_ry;

			this.param.dir_x		= a_initparam.dir_x;
			this.param.dir_y		= a_initparam.dir_y;

			this.param.button_r		= a_initparam.button_r;
			this.param.button_d		= a_initparam.button_d;
			this.param.button_l		= a_initparam.button_l;
			this.param.button_u		= a_initparam.button_u;

			this.param.trigger_l1	= a_initparam.trigger_l1;
			this.param.trigger_l2	= a_initparam.trigger_l2;
			this.param.trigger_l3	= a_initparam.trigger_l3;
			this.param.trigger_r1	= a_initparam.trigger_r1;
			this.param.trigger_r2	= a_initparam.trigger_r2;
			this.param.trigger_r3	= a_initparam.trigger_r3;
			this.param.trigger_add	= a_initparam.trigger_add;
			this.param.trigger_mul	= a_initparam.trigger_mul;

			this.param.menu_l		= a_initparam.menu_l;
			this.param.menu_r		= a_initparam.menu_r;
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
			return new UnityEngine.Vector2(UnityEngine.Input.GetAxis(this.param.stick_lx),UnityEngine.Input.GetAxis(this.param.stick_ly));
		}

		/** [BlueBack.Pad.Engine_Base]スティック。左。取得。
		*/
		public UnityEngine.Vector2 GetStickR()
		{
			return new UnityEngine.Vector2(UnityEngine.Input.GetAxis(this.param.stick_rx),UnityEngine.Input.GetAxis(this.param.stick_ry));
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。右。取得。
		*/
		public bool GetDirR()
		{
			return UnityEngine.Input.GetAxis(this.param.dir_x) > 0.5f;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。下。取得。
		*/
		public bool GetDirD()
		{
			return UnityEngine.Input.GetAxis(this.param.dir_y) > 0.5f;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。左。取得。
		*/
		public bool GetDirL()
		{
			return UnityEngine.Input.GetAxis(this.param.dir_x) < -0.5f;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。上。取得。
		*/
		public bool GetDirU()
		{
			return UnityEngine.Input.GetAxis(this.param.dir_y) < -0.5f;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。右。取得。
		*/
		public bool GetButtonR()
		{
			return UnityEngine.Input.GetButton(this.param.button_r);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。下。取得。
		*/
		public bool GetButtonD()
		{
			return UnityEngine.Input.GetButton(this.param.button_d);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。左。取得。
		*/
		public bool GetButtonL()
		{
			return UnityEngine.Input.GetButton(this.param.button_l);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。上。取得。
		*/
		public bool GetButtonU()
		{
			return UnityEngine.Input.GetButton(this.param.button_u);
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左１。取得。
		*/
		public bool GetTriggerL1()
		{
			return UnityEngine.Input.GetButton(this.param.trigger_l1);
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左２。取得。
		*/
		public float GetTriggerL2()
		{
			float t_value = UnityEngine.Input.GetAxis(this.param.trigger_l2);
			if(t_value != 0.0f){
				return UnityEngine.Mathf.Clamp01((t_value + this.param.trigger_add) * this.param.trigger_mul);
			}
			return 0.0f;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左３。取得。
		*/
		public bool GetTriggerL3()
		{
			return UnityEngine.Input.GetButton(this.param.trigger_l3);
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右１。取得。
		*/
		public bool GetTriggerR1()
		{
			return UnityEngine.Input.GetButton(this.param.trigger_r1);
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右２。取得。
		*/
		public float GetTriggerR2()
		{
			float t_value = UnityEngine.Input.GetAxis(this.param.trigger_r2);
			if(t_value != 0.0f){
				return UnityEngine.Mathf.Clamp01((t_value + this.param.trigger_add) * this.param.trigger_mul);
			}
			return 0.0f;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右３。取得。
		*/
		public bool GetTriggerR3()
		{
			return UnityEngine.Input.GetButton(this.param.trigger_r3);
		}

		/** [BlueBack.Pad.Engine_Base]メニュー。左。取得。
		*/
		public bool GetMenuL()
		{
			return UnityEngine.Input.GetButton(this.param.menu_l);
		}

		/** [BlueBack.Pad.Engine_Base]メニュー。右。取得。
		*/
		public bool GetMenuR()
		{
			return UnityEngine.Input.GetButton(this.param.menu_r);
		}
	}
}

