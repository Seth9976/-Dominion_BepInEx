using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Localization
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	public class SA_ISOLanguage : Object
	{
		// Token: 0x0600015C RID: 348 RVA: 0x000091B4 File Offset: 0x000073B4
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ISOLanguage()
		{
			Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Localization", "SA_ISOLanguage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr);
			SA_ISOLanguage.NativeFieldInfoPtr_m_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr, "m_code");
			SA_ISOLanguage.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr, "m_name");
			SA_ISOLanguage.NativeFieldInfoPtr_m_nativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr, "m_nativeName");
			SA_ISOLanguage.NativeMethodInfoPtr_get_Code_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr, 100663519);
			SA_ISOLanguage.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr, 100663520);
			SA_ISOLanguage.NativeMethodInfoPtr_get_NativeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr, 100663521);
			SA_ISOLanguage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr, 100663522);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00009270 File Offset: 0x00007470
		public unsafe string Code
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ISOLanguage.NativeMethodInfoPtr_get_Code_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000092A8 File Offset: 0x000074A8
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ISOLanguage.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000092E0 File Offset: 0x000074E0
		public unsafe string NativeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ISOLanguage.NativeMethodInfoPtr_get_NativeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00009318 File Offset: 0x00007518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100349, XrefRangeEnd = 100354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ISOLanguage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ISOLanguage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ISOLanguage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000248F File Offset: 0x0000068F
		public SA_ISOLanguage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00009354 File Offset: 0x00007554
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002498 File Offset: 0x00000698
		public unsafe string m_code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguage.NativeFieldInfoPtr_m_code);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguage.NativeFieldInfoPtr_m_code), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000937C File Offset: 0x0000757C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x000024B7 File Offset: 0x000006B7
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguage.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguage.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000093A4 File Offset: 0x000075A4
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000024D6 File Offset: 0x000006D6
		public unsafe string m_nativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguage.NativeFieldInfoPtr_m_nativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguage.NativeFieldInfoPtr_m_nativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_m_code;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_m_nativeName;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_String_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeName_Public_get_String_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
