using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000110 RID: 272
	public sealed class DelegateData : Object
	{
		// Token: 0x06001415 RID: 5141 RVA: 0x0007DE94 File Offset: 0x0007C094
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateData()
		{
			Il2CppClassPointerStore<DelegateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DelegateData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateData>.NativeClassPtr);
			DelegateData.NativeFieldInfoPtr_target_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "target_type");
			DelegateData.NativeFieldInfoPtr_method_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "method_name");
			DelegateData.NativeFieldInfoPtr_curried_first_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "curried_first_arg");
			DelegateData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, 100666741);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0007DF14 File Offset: 0x0007C114
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00007024 File Offset: 0x00005224
		public DelegateData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0007DF50 File Offset: 0x0007C150
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0000702D File Offset: 0x0000522D
		public unsafe Type target_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_target_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_target_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0007DF80 File Offset: 0x0007C180
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x0000704C File Offset: 0x0000524C
		public unsafe string method_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_method_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_method_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0007DFA8 File Offset: 0x0007C1A8
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0000706B File Offset: 0x0000526B
		public unsafe bool curried_first_arg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_curried_first_arg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_curried_first_arg)) = value;
			}
		}

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeFieldInfoPtr_target_type;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeFieldInfoPtr_method_name;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeFieldInfoPtr_curried_first_arg;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
