using System.Collections;
using UnityEngine;
using System.Runtime.InteropServices;

namespace TestFairyUnity
{
	public class TestFairy : MonoBehaviour
	{
		#if UNITY_IPHONE		
		
		[DllImport("__Internal")]
		private static extern void TestFairy_begin(string APIKey);
		
		public static void begin(string APIKey)
		{
			TestFairy_begin(APIKey);
		}

		[DllImport("__Internal")]
		private static extern void TestFairy_pushFeedbackController();

		public static void pushFeedbackController()
		{
			TestFairy_pushFeedbackController();
		}

		[DllImport("__Internal")]
		private static extern void TestFairy_checkpoint(string name);
		
		public static void checkpoint(string name)
		{
			TestFairy_checkpoint(name);
		}

		[DllImport("__Internal")]
		private static extern void TestFairy_setCorrelationId(string correlationId);
		
		public static void setCorrelationId(string correlationId)
		{
			TestFairy_setCorrelationId(correlationId);
		}

		[DllImport("__Internal")]
		private static extern void TestFairy_pause();
		
		public static void pause()
		{
			TestFairy_pause();
		}

		[DllImport("__Internal")]
		private static extern void TestFairy_resume();
		
		public static void resume()
		{
			TestFairy_resume();
		}

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