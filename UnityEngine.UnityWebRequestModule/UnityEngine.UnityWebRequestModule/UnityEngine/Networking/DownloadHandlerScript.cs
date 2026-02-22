using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Networking
{
	// Token: 0x0200000F RID: 15
	public class DownloadHandlerScript : DownloadHandler
	{
		// Token: 0x0600014E RID: 334 RVA: 0x000026BF File Offset: 0x000008BF
		public static IntPtr Create(DownloadHandlerScript obj)
		{
			return DownloadHandlerScript.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000026D1 File Offset: 0x000008D1
		public static IntPtr CreatePreallocated(DownloadHandlerScript obj, Il2CppStructArray<byte> preallocatedBuffer)
		{
			return DownloadHandlerScript.CreatePreallocatedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.Il2CppObjectBaseToPtr(preallocatedBuffer));
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000026E9 File Offset: 0x000008E9
		public void InternalCreateScript()
		{
			base.m_Ptr = DownloadHandlerScript.Create(this);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000026F8 File Offset: 0x000008F8
		public void InternalCreateScript(Il2CppStructArray<byte> preallocatedBuffer)
		{
			base.m_Ptr = DownloadHandlerScript.CreatePreallocated(this, preallocatedBuffer);
		}

		// Token: 0x040000BE RID: 190
		private static readonly DownloadHandlerScript.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerScript.CreateDelegate>("UnityEngine.Networking.DownloadHandlerScript::Create");

		// Token: 0x040000BF RID: 191
		private static readonly DownloadHandlerScript.CreatePreallocatedDelegate CreatePreallocatedDelegateField = IL2CPP.ResolveICall<DownloadHandlerScript.CreatePreallocatedDelegate>("UnityEngine.Networking.DownloadHandlerScript::CreatePreallocated");

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000190 RID: 400
		private delegate IntPtr CreateDelegate(IntPtr obj);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000192 RID: 402
		private delegate IntPtr CreatePreallocatedDelegate(IntPtr obj, IntPtr preallocatedBuffer);
	}
}
