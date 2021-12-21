

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Pad.UIS
*/
namespace BlueBack.Pad.UIS
{
	/** Param
	*/
	#if(ENABLE_INPUT_SYSTEM)
	public struct InitParam
	{
		/** device
		*/
		public UnityEngine.InputSystem.Gamepad device;

		/** CreateDefault
		*/
		public static InitParam CreateDefault()
		{
			return new InitParam(){
				device = UnityEngine.InputSystem.Gamepad.current,
			};
		}
	}
	#endif
}

