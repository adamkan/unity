using System.Collections;
using UnityEngine;
using System.Runtime.InteropServices;

namespace TestFairyUnity
{
	public class TestFairy : MonoBehaviour
	{
		#if UNITY_IPHONE		
		
		/// <summary>
		/// Initialize a TestFairy session.
		/// </summary>
		/// <param name="APIKey"></param>
		[DllImport("__Internal")]
		private static extern void TestFairy_begin(string APIKey);
		
		public static void begin(string APIKey)
		{
			TestFairy_begin(APIKey);
		}

		/// <summary>
		/// Push the feedback view controller. Hook a button to this method
		/// to allow users to provide feedback about the current session. All
		/// feedback will appear in your build report page, and in the
		/// recorded session page.
		/// </summary>
		[DllImport("__Internal")]
		private static extern void TestFairy_pushFeedbackController();

		public static void pushFeedbackController()
		{
			TestFairy_pushFeedbackController();
		}

		/// <summary>
		/// Mark a checkpoint in session. Use this text to tag a session
		/// with a checkpoint name. Later you can filter sessions where your
		/// user passed through this checkpoint, for bettering understanding
		/// user experience and behavior.
		/// </summary>
		/// <param name="name">Name of checkpoint, make it short.</param>
		[DllImport("__Internal")]
		private static extern void TestFairy_checkpoint(string name);
		
		public static void checkpoint(string name)
		{
			TestFairy_checkpoint(name);
		}
		
		/// <summary>
		/// Sets a correlation identifier for this session. This value can
		/// be looked up via web dashboard. For example, setting correlation
		/// to the value of the user-id after they logged in. Can be called
		/// only once per session (subsequent calls will be ignored.)
		/// </summary>
		/// <param name="correlationId">Correlation value</param>
		[DllImport("__Internal")]
		private static extern void TestFairy_setCorrelationId(string correlationId);
		
		public static void setCorrelationId(string correlationId)
		{
			TestFairy_setCorrelationId(correlationId);
		}

		/// <summary>
		/// Pauses the current session. This method stops recoding of 
		/// the current session until Resume() has been called.
		/// </summary>
		[DllImport("__Internal")]
		private static extern void TestFairy_pause();
		
		public static void pause()
		{
			TestFairy_pause();
		}

		/// <summary>
		/// Resumes the recording of the current session. This method
		/// resumes a session after it was paused.
		/// </summary>
		[DllImport("__Internal")]
		private static extern void TestFairy_resume();
		
		public static void resume()
		{
			TestFairy_resume();
		}

		/// <summary>
		/// Returns the url of the current session while its being recorded.
		/// Will return null if session hasn't started yet.
		/// </summary>
		/// <returns>The session URL.</returns>
		[DllImport("__Internal")]
		private static extern string TestFairy_sessionUrl();

		public static string sessionUrl()
		{
			string sessionUrl = TestFairy_sessionUrl ();
			return sessionUrl;
		}

		#elif UNITY_ANDROID
		
		#endif
	}
}
