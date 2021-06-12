

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンフィグ。
*/


/** BlueBack.Pad
*/
namespace BlueBack.Pad
{
	/** Config
	*/
	public class Config
	{
		/** ERRORPROC
		*/
		#if(DEF_BLUEBACK_PAD_ASSERT)
		public delegate void ErrorProcType(System.Exception a_exception,string a_message);
		public static ErrorProcType ERRORPROC = DebugTool.ErrorProc;
		#endif

		/** LOGPROC
		*/
		#if(DEF_BLUEBACK_PAD_LOG)
		public delegate void LogProcType(string a_message);
		public static LogProcType LOGPROC = DebugTool.LogProc;
		#endif
	}
}

