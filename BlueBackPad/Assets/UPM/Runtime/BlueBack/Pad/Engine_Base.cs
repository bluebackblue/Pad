

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

		/** [BlueBack.Pad.Engine_Base]スティック。左。取得。
		*/
		UnityEngine.Vector2 GetStickL();

		/** [BlueBack.Pad.Engine_Base]スティック。左。取得。
		*/
		UnityEngine.Vector2 GetStickR();

		/** [BlueBack.Pad.Engine_Base]十字。右。取得。
		*/
		bool GetDirR();

		/** [BlueBack.Pad.Engine_Base]十字。下。取得。
		*/
		bool GetDirD();

		/** [BlueBack.Pad.Engine_Base]十字。左。取得。
		*/
		bool GetDirL();

		/** [BlueBack.Pad.Engine_Base]十字。上。取得。
		*/
		bool GetDirU();

		/** [BlueBack.Pad.Engine_Base]ボタン。右。取得。
		*/
		bool GetButtonR();

		/** [BlueBack.Pad.Engine_Base]ボタン。下。取得。
		*/
		bool GetButtonD();

		/** [BlueBack.Pad.Engine_Base]ボタン。左。取得。
		*/
		bool GetButtonL();

		/** [BlueBack.Pad.Engine_Base]ボタン。上。取得。
		*/
		bool GetButtonU();

		/** [BlueBack.Pad.Engine_Base]トリガー。左１。取得。
		*/
		bool GetTriggerL1();

		/** [BlueBack.Pad.Engine_Base]トリガー。左２。取得。
		*/
		float GetTriggerL2();

		/** [BlueBack.Pad.Engine_Base]トリガー。左３。取得。
		*/
		bool GetTriggerL3();

		/** [BlueBack.Pad.Engine_Base]トリガー。右１。取得。
		*/
		bool GetTriggerR1();

		/** [BlueBack.Pad.Engine_Base]トリガー。右２。取得。
		*/
		float GetTriggerR2();

		/** [BlueBack.Pad.Engine_Base]トリガー。右３。取得。
		*/
		bool GetTriggerR3();

		/** [BlueBack.Pad.Engine_Base]メニュー。左。取得。
		*/
		bool GetMenuL();

		/** [BlueBack.Pad.Engine_Base]メニュー。右。取得。
		*/
		bool GetMenuR();

	}
}

