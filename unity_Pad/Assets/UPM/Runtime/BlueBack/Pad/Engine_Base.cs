

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Pad
*/
namespace BlueBack.Pad
{
	/** Engine_Base
	*/
	public interface Engine_Base
	{
		/** [BlueBack.Pad.Engine_Base]作成。
		*/
		void Create();

		/** [BlueBack.Pad.Engine_Base]削除。
		*/
		void Delete();

		/** GetCursorPos
		*/
		UnityEngine.Vector2 GetCursorPos();

		/** GetLeftButton
		*/
		bool GetLeftButton();

		/** GetRightButton
		*/
		bool GetRightButton();

		/** GetCenterButton
		*/
		bool GetCenterButton();

		/** GetWheelDelta
		*/
		UnityEngine.Vector2 GetWheelDelta();
	}
}

