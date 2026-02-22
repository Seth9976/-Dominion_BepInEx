using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000EF RID: 239
	public sealed class HeaderVariantInfo : ValueType
	{
		// Token: 0x06000DFA RID: 3578 RVA: 0x00044BE0 File Offset: 0x00042DE0
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderVariantInfo()
		{
			Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderVariantInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr);
			HeaderVariantInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, "m_name");
			HeaderVariantInfo.NativeFieldInfoPtr_m_variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, "m_variant");
			HeaderVariantInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100665259);
			HeaderVariantInfo.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100665260);
			HeaderVariantInfo.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100665261);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00044C74 File Offset: 0x00042E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11679, RefRangeEnd = 11680, XrefRangeStart = 11679, XrefRangeEnd = 11680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderVariantInfo(string name, CookieVariant variant)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref variant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00044CD4 File Offset: 0x00042ED4
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00044D10 File Offset: 0x00042F10
		public unsafe CookieVariant Variant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000077CB File Offset: 0x000059CB
		public HeaderVariantInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x000077D4 File Offset: 0x000059D4
		public HeaderVariantInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00044D54 File Offset: 0x00042F54
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x000077E6 File Offset: 0x000059E6
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x00044D7C File Offset: 0x00042F7C
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00007805 File Offset: 0x00005A05
		public unsafe CookieVariant m_variant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_variant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_variant)) = value;
			}
		}

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_m_variant;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0;
	}
}
