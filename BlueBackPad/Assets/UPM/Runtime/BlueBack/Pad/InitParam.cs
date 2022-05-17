

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief パラメータ。
*/


/** BlueBack.Pad
*/
namespace BlueBack.Pad
{
	/** InitParam
	*/
	public struct InitParam
	{
		/** 初回のラピッド間隔。
		*/
		public float rapid_time_max_first;

		/** 二回目からのラピッド間隔。
		*/
		public float rapid_time_max;

		/** CreateDefault
		*/
		public static InitParam CreateDefault()
		{
			return new InitParam(){
				rapid_time_max_first = 0.5f,
				rapid_time_max = 0.1f,
			};
		}
	}
}

