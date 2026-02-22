using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004A RID: 74
	public sealed class SharedReference : Object
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x00021CB4 File Offset: 0x0001FEB4
		// Note: this type is marked as 'beforefieldinit'.
		static SharedReference()
		{
			Il2CppClassPointerStore<SharedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "SharedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedReference>.NativeClassPtr);
			SharedReference.NativeFieldInfoPtr__ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedReference>.NativeClassPtr, "_ref");
			SharedReference.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedReference>.NativeClassPtr, "_locked");
			SharedReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedReference>.NativeClassPtr, 100663950);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00021D20 File Offset: 0x0001FF20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37577, RefRangeEnd = 37578, XrefRangeStart = 37572, XrefRangeEnd = 37577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000039A7 File Offset: 0x00001BA7
		public SharedReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00021D5C File Offset: 0x0001FF5C
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x000039B0 File Offset: 0x00001BB0
		public unsafe WeakReference _ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedReference.NativeFieldInfoPtr__ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedReference.NativeFieldInfoPtr__ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00021D8C File Offset: 0x0001FF8C
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x000039CF File Offset: 0x00001BCF
		public unsafe int _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedReference.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedReference.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeFieldInfoPtr__ref;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
