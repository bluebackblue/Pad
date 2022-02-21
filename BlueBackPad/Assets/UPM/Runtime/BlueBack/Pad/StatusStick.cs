

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ステータス。
*/


/** BlueBack.Pad
*/
namespace BlueBack.Pad
{
	/** StatusStick
	*/
	public struct StatusStick
	{
		/** 位置。
		*/
		public UnityEngine.Vector2 pos;
		public UnityEngine.Vector2 pos_old;

		/** リセット。
		*/
		public void Reset()
		{
			this.pos = new UnityEngine.Vector2(0.0f,0.0f);
			this.pos_old = new UnityEngine.Vector2(0.0f,0.0f);
		}

		/** 初期化。
		*/
		public void Init()
		{
			this.pos = new UnityEngine.Vector2(0.0f,0.0f);
			this.pos_old = new UnityEngine.Vector2(0.0f,0.0f);
		}
	}
}

