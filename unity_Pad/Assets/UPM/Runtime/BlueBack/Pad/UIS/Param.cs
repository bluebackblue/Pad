

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
	#if(DEF_BLUEBACK_PAD_UIS)
	public class Param
	{
		/** device
		*/
		public UnityEngine.InputSystem.Gamepad device;

		/** constructor
		*/
		public Param(UnityEngine.InputSystem.Gamepad a_device)
		{
			this.device = a_device;
		}
	}
	#endif
}

