

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Pad.UIS
*/
namespace BlueBack.Pad.UIS
{
	/** Engine
	*/
	#if(DEF_BLUEBACK_PAD_UIS)
	public sealed class Engine : Engine_Base
	{
		/** param
		*/
		public InitParam param;

		/** constructor
		*/
		public Engine(in InitParam a_param)
		{
			this.param = a_param;
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

		/** [BlueBack.Pad.Engine_Base]スティック。左。取得。
		*/
		public UnityEngine.Vector2 GetStickL()
		{
			if(this.param.device != null){
				return new UnityEngine.Vector2(this.param.device.leftStick.x.ReadValue(),this.param.device.leftStick.y.ReadValue());
			}
			return new UnityEngine.Vector2(0.0f,0.0f);
		}

		/** [BlueBack.Pad.Engine_Base]スティック。左。取得。
		*/
		public UnityEngine.Vector2 GetStickR()
		{
			if(this.param.device != null){
				return new UnityEngine.Vector2(this.param.device.rightStick.x.ReadValue(),this.param.device.rightStick.y.ReadValue());
			}
			return new UnityEngine.Vector2(0.0f,0.0f);
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。右。取得。
		*/
		public bool GetDirR()
		{
			if(this.param.device != null){
				return this.param.device.dpad.right.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。下。取得。
		*/
		public bool GetDirD()
		{
			if(this.param.device != null){
				return this.param.device.dpad.down.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。左。取得。
		*/
		public bool GetDirL()
		{
			if(this.param.device != null){
				return this.param.device.dpad.left.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン左側。上。取得。
		*/
		public bool GetDirU()
		{
			if(this.param.device != null){
				return this.param.device.dpad.up.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。右。取得。
		*/
		public bool GetButtonR()
		{
			if(this.param.device != null){
				return this.param.device.buttonEast.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。下。取得。
		*/
		public bool GetButtonD()
		{
			if(this.param.device != null){
				return this.param.device.buttonSouth.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。左。取得。
		*/
		public bool GetButtonL()
		{
			if(this.param.device != null){
				return this.param.device.buttonWest.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]ボタン右側。上。取得。
		*/
		public bool GetButtonU()
		{
			if(this.param.device != null){
				return this.param.device.buttonNorth.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左１。取得。
		*/
		public bool GetTriggerL1()
		{
			if(this.param.device != null){
				return this.param.device.leftShoulder.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左２。取得。
		*/
		public float GetTriggerL2()
		{
			if(this.param.device != null){
				return this.param.device.leftTrigger.ReadValue();
			}
			return 0.0f;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。左３。取得。
		*/
		public bool GetTriggerL3()
		{
			if(this.param.device != null){
				return this.param.device.leftStickButton.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右１。取得。
		*/
		public bool GetTriggerR1()
		{
			if(this.param.device != null){
				return this.param.device.rightShoulder.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右２。取得。
		*/
		public float GetTriggerR2()
		{
			if(this.param.device != null){
				return this.param.device.rightTrigger.ReadValue();
			}
			return 0.0f;
		}

		/** [BlueBack.Pad.Engine_Base]トリガー。右３。取得。
		*/
		public bool GetTriggerR3()
		{
			if(this.param.device != null){
				return this.param.device.rightStickButton.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]メニュー。左。取得。
		*/
		public bool GetMenuL()
		{
			if(this.param.device != null){
				return this.param.device.selectButton.isPressed;
			}
			return false;
		}

		/** [BlueBack.Pad.Engine_Base]メニュー。右。取得。
		*/
		public bool GetMenuR()
		{
			if(this.param.device != null){
				return this.param.device.startButton.isPressed;
			}
			return false;
		}
	}
	#endif
}

