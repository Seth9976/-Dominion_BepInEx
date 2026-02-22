using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E0 RID: 224
	public class HeaderInfo : Object
	{
		// Token: 0x06000CF5 RID: 3317 RVA: 0x00041700 File Offset: 0x0003F900
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderInfo()
		{
			Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr);
			HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "IsRequestRestricted");
			HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "IsResponseRestricted");
			HeaderInfo.NativeFieldInfoPtr_Parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "Parser");
			HeaderInfo.NativeFieldInfoPtr_HeaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "HeaderName");
			HeaderInfo.NativeFieldInfoPtr_AllowMultiValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "AllowMultiValues");
			HeaderInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100665132);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000417A8 File Offset: 0x0003F9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47520, XrefRangeEnd = 47521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestRestricted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref responseRestricted;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00007052 File Offset: 0x00005252
		public HeaderInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00041830 File Offset: 0x0003FA30
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x0000705B File Offset: 0x0000525B
		public unsafe bool IsRequestRestricted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted)) = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00041858 File Offset: 0x0003FA58
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00007076 File Offset: 0x00005276
		public unsafe bool IsResponseRestricted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted)) = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00041880 File Offset: 0x0003FA80
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00007091 File Offset: 0x00005291
		public unsafe HeaderParser Parser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_Parser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_Parser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x000418B0 File Offset: 0x0003FAB0
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x000070B0 File Offset: 0x000052B0
		public unsafe string HeaderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_HeaderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_HeaderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x000418D8 File Offset: 0x0003FAD8
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x000070CF File Offset: 0x000052CF
		public unsafe bool AllowMultiValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_AllowMultiValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_AllowMultiValues)) = value;
			}
		}

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_IsRequestRestricted;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_IsResponseRestricted;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_Parser;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeFieldInfoPtr_HeaderName;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeFieldInfoPtr_AllowMultiValues;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0;
	}
}
