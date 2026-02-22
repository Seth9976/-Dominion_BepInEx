using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000009 RID: 9
	public class UnityActivity : Object
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000064E4 File Offset: 0x000046E4
		// Note: this type is marked as 'beforefieldinit'.
		static UnityActivity()
		{
			Il2CppClassPointerStore<UnityActivity>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UnityActivity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityActivity>.NativeClassPtr);
			UnityActivity.NativeMethodInfoPtr_GetUnityPlayerClass_Private_Static_AndroidJavaClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityActivity>.NativeClassPtr, 100663322);
			UnityActivity.NativeMethodInfoPtr_GetCurrentActivity_Internal_Static_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityActivity>.NativeClassPtr, 100663323);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000653C File Offset: 0x0000473C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150229, XrefRangeEnd = 150235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaClass GetUnityPlayerClass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityActivity.NativeMethodInfoPtr_GetUnityPlayerClass_Private_Static_AndroidJavaClass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006570 File Offset: 0x00004770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150247, RefRangeEnd = 150249, XrefRangeStart = 150235, XrefRangeEnd = 150247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject GetCurrentActivity()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityActivity.NativeMethodInfoPtr_GetCurrentActivity_Internal_Static_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000213C File Offset: 0x0000033C
		public UnityActivity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_GetUnityPlayerClass_Private_Static_AndroidJavaClass_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentActivity_Internal_Static_AndroidJavaObject_0;
	}
}
