using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.CrashReportHandler
{
	// Token: 0x02000002 RID: 2
	public class CrashReportHandler
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000205C File Offset: 0x0000025C
		public static bool enableCaptureExceptions
		{
			get
			{
				return CrashReportHandler.get_enableCaptureExceptionsDelegateField();
			}
			set
			{
				CrashReportHandler.set_enableCaptureExceptionsDelegateField(value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002075 File Offset: 0x00000275
		public static uint logBufferSize
		{
			get
			{
				return CrashReportHandler.get_logBufferSizeDelegateField();
			}
			set
			{
				CrashReportHandler.set_logBufferSizeDelegateField(value);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002104 File Offset: 0x00000304
		public static string GetUserMetadata(string key)
		{
			IntPtr intPtr = CrashReportHandler.GetUserMetadataDelegateField(IL2CPP.ManagedStringToIl2Cpp(key));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002082 File Offset: 0x00000282
		public static void SetUserMetadata(string key, string value)
		{
			CrashReportHandler.SetUserMetadataDelegateField(IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x04000001 RID: 1
		private static readonly CrashReportHandler.get_enableCaptureExceptionsDelegate get_enableCaptureExceptionsDelegateField = IL2CPP.ResolveICall<CrashReportHandler.get_enableCaptureExceptionsDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::get_enableCaptureExceptions");

		// Token: 0x04000002 RID: 2
		private static readonly CrashReportHandler.set_enableCaptureExceptionsDelegate set_enableCaptureExceptionsDelegateField = IL2CPP.ResolveICall<CrashReportHandler.set_enableCaptureExceptionsDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::set_enableCaptureExceptions");

		// Token: 0x04000003 RID: 3
		private static readonly CrashReportHandler.get_logBufferSizeDelegate get_logBufferSizeDelegateField = IL2CPP.ResolveICall<CrashReportHandler.get_logBufferSizeDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::get_logBufferSize");

		// Token: 0x04000004 RID: 4
		private static readonly CrashReportHandler.set_logBufferSizeDelegate set_logBufferSizeDelegateField = IL2CPP.ResolveICall<CrashReportHandler.set_logBufferSizeDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::set_logBufferSize");

		// Token: 0x04000005 RID: 5
		private static readonly CrashReportHandler.GetUserMetadataDelegate GetUserMetadataDelegateField = IL2CPP.ResolveICall<CrashReportHandler.GetUserMetadataDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::GetUserMetadata");

		// Token: 0x04000006 RID: 6
		private static readonly CrashReportHandler.SetUserMetadataDelegate SetUserMetadataDelegateField = IL2CPP.ResolveICall<CrashReportHandler.SetUserMetadataDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::SetUserMetadata");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000009 RID: 9
		private delegate bool get_enableCaptureExceptionsDelegate();

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000B RID: 11
		private delegate void set_enableCaptureExceptionsDelegate(bool value);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000D RID: 13
		private delegate uint get_logBufferSizeDelegate();

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600000F RID: 15
		private delegate void set_logBufferSizeDelegate(uint value);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000011 RID: 17
		private delegate IntPtr GetUserMetadataDelegate(IntPtr key);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000013 RID: 19
		private delegate void SetUserMetadataDelegate(IntPtr key, IntPtr value);
	}
}
