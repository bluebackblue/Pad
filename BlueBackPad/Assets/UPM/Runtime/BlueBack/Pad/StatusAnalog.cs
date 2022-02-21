

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ステータス。
*/


/** BlueBack.Pad
*/
namespace BlueBack.Pad
{
	/** StatusAnalog
	*/
	public struct StatusAnalog
	{
		/** 位置。
		*/
		public float value;
		public float value_old;

		/** リセット。
		*/
		public void Reset()
		{
			this.value = 0.0f;
			this.value_old =  0.0f;
		}

		/** 初期化。
		*/
		public void Init()
		{
			this.value =  0.0f;
			this.value_old =  0.0f;
		}
	}
}

