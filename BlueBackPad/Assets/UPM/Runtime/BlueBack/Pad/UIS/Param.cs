

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Pad.UIS
*/
namespace BlueBack.Pad.UIS
{
	/** Param
	*/
	#if(ENABLE_INPUT_SYSTEM)
	public struct Param
	{
		/** device
		*/
		public UnityEngine.InputSystem.Gamepad device;

		/** enable
		*/
		public bool enable;
	}
	#endif
}

