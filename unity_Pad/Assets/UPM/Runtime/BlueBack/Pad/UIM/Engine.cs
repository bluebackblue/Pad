

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Pad.UIM
*/
namespace BlueBack.Pad.UIM
{
	/** Engine
	*/
	public class Engine : Engine_Base
	{
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

		/** GetCursorPos
		*/
		public UnityEngine.Vector2 GetCursorPos()
		{
			//TODO:
			return new UnityEngine.Vector2(UnityEngine.Input.mousePosition.x / UnityEngine.Screen.width,1.0f - UnityEngine.Input.mousePosition.y / UnityEngine.Screen.height);
		}

		/** GetLeftButton
		*/
		public bool GetLeftButton()
		{
			//TODO:
			return UnityEngine.Input.GetMouseButton(0);
		}

		/** GetRightButton
		*/
		public bool GetRightButton()
		{
			//TODO:
			return UnityEngine.Input.GetMouseButton(1);
		}

		/** GetCenterButton
		*/
		public bool GetCenterButton()
		{
			//TODO:
			return UnityEngine.Input.GetMouseButton(2);
		}

		/** GetWheelDelta
		*/
		public UnityEngine.Vector2 GetWheelDelta()
		{
			//TODO:
			return UnityEngine.Input.mouseScrollDelta;
		}
	}
}

