using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android
{
	// Token: 0x0200001A RID: 26
	public struct Permission
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x000029BE File Offset: 0x00000BBE
		public static AndroidJavaObject GetActivity()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000029CB File Offset: 0x00000BCB
		public static AndroidJavaObject GetUnityPermissions()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public static bool HasUserAuthorizedPermission(string permission)
		{
			bool flag = permission == null;
			return !flag;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000029D8 File Offset: 0x00000BD8
		public static void RequestUserPermission(string permission)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000A300 File Offset: 0x00008500
		public static void RequestUserPermissions(Il2CppStringArray permissions)
		{
			bool flag = permissions == null || permissions.Length == 0;
			if (!flag)
			{
				Permission.RequestUserPermissions(permissions, null);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000029E5 File Offset: 0x00000BE5
		public static void RequestUserPermission(string permission, PermissionCallbacks callbacks)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000A32C File Offset: 0x0000852C
		public static void RequestUserPermissions(Il2CppStringArray permissions, PermissionCallbacks callbacks)
		{
			bool flag = permissions == null || permissions.Length == 0;
			if (flag)
			{
			}
		}

		// Token: 0x0400016F RID: 367
		public const string Camera = "android.permission.CAMERA";

		// Token: 0x04000170 RID: 368
		public const string Microphone = "android.permission.RECORD_AUDIO";

		// Token: 0x04000171 RID: 369
		public const string FineLocation = "android.permission.ACCESS_FINE_LOCATION";

		// Token: 0x04000172 RID: 370
		public const string CoarseLocation = "android.permission.ACCESS_COARSE_LOCATION";

		// Token: 0x04000173 RID: 371
		public const string ExternalStorageRead = "android.permission.READ_EXTERNAL_STORAGE";

		// Token: 0x04000174 RID: 372
		public const string ExternalStorageWrite = "android.permission.WRITE_EXTERNAL_STORAGE";
	}
}
