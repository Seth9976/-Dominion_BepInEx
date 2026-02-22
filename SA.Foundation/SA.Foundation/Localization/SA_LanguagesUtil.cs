using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Localization
{
	// Token: 0x0200002D RID: 45
	public static class SA_LanguagesUtil : Object
	{
		// Token: 0x06000171 RID: 369 RVA: 0x0000957C File Offset: 0x0000777C
		// Note: this type is marked as 'beforefieldinit'.
		static SA_LanguagesUtil()
		{
			Il2CppClassPointerStore<SA_LanguagesUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Localization", "SA_LanguagesUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_LanguagesUtil>.NativeClassPtr);
			SA_LanguagesUtil.NativeFieldInfoPtr_m_isoLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_LanguagesUtil>.NativeClassPtr, "m_isoLanguages");
			SA_LanguagesUtil.NativeMethodInfoPtr_get_ISOLanguagesList_Public_Static_get_SA_ISOLanguagesList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_LanguagesUtil>.NativeClassPtr, 100663526);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000095D4 File Offset: 0x000077D4
		public unsafe static SA_ISOLanguagesList ISOLanguagesList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100384, XrefRangeEnd = 100403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_LanguagesUtil.NativeMethodInfoPtr_get_ISOLanguagesList_Public_Static_get_SA_ISOLanguagesList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_ISOLanguagesList>(intPtr3) : null;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000253C File Offset: 0x0000073C
		public SA_LanguagesUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00009608 File Offset: 0x00007808
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002545 File Offset: 0x00000745
		public unsafe static SA_ISOLanguagesList m_isoLanguages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_LanguagesUtil.NativeFieldInfoPtr_m_isoLanguages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_ISOLanguagesList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_LanguagesUtil.NativeFieldInfoPtr_m_isoLanguages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_m_isoLanguages;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_ISOLanguagesList_Public_Static_get_SA_ISOLanguagesList_0;
	}
}
