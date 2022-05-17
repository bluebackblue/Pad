

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


/** BlueBack.Pad.UIS
*/
#if(ASMDEF_TRUE)
namespace BlueBack.Pad.UIS
{
	/** Param
	*/
	public struct Param
	{
		/** device
		*/
		public UnityEngine.InputSystem.Gamepad device;

		/** enable
		*/
		public bool enable;
	}
}
#endif

