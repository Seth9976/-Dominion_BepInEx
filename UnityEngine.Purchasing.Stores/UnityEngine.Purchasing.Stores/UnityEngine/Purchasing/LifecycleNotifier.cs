using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000059 RID: 89
	public class LifecycleNotifier : MonoBehaviour
	{
		// Token: 0x0600031B RID: 795 RVA: 0x000102E4 File Offset: 0x0000E4E4
		// Note: this type is marked as 'beforefieldinit'.
		static LifecycleNotifier()
		{
			Il2CppClassPointerStore<LifecycleNotifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "LifecycleNotifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LifecycleNotifier>.NativeClassPtr);
			LifecycleNotifier.NativeFieldInfoPtr_OnDestroyCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifecycleNotifier>.NativeClassPtr, "OnDestroyCallback");
			LifecycleNotifier.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifecycleNotifier>.NativeClassPtr, 100663686);
			LifecycleNotifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifecycleNotifier>.NativeClassPtr, 100663687);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00010350 File Offset: 0x0000E550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154319, XrefRangeEnd = 154320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifecycleNotifier.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00010384 File Offset: 0x0000E584
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LifecycleNotifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LifecycleNotifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifecycleNotifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000038AC File Offset: 0x00001AAC
		public LifecycleNotifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000103C0 File Offset: 0x0000E5C0
		// (set) Token: 0x06000320 RID: 800 RVA: 0x000038B5 File Offset: 0x00001AB5
		public unsafe Action OnDestroyCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleNotifier.NativeFieldInfoPtr_OnDestroyCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleNotifier.NativeFieldInfoPtr_OnDestroyCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_OnDestroyCallback;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
