using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000011 RID: 17
	public sealed class UploadHandlerFile : UploadHandler
	{
		// Token: 0x0600015B RID: 347 RVA: 0x000027AD File Offset: 0x000009AD
		public static IntPtr Create(UploadHandlerFile self, string filePath)
		{
			return UploadHandlerFile.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(filePath));
		}

		// Token: 0x040000C3 RID: 195
		private static readonly UploadHandlerFile.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<UploadHandlerFile.CreateDelegate>("UnityEngine.Networking.UploadHandlerFile::Create");

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate IntPtr CreateDelegate(IntPtr self, IntPtr filePath);
	}
}
