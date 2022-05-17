

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
	/** InitParam
	*/
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
	
}
#endif

