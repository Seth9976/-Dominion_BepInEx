using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Foundation.Localization
{
	// Token: 0x0200002C RID: 44
	[Serializable]
	public class SA_ISOLanguagesList : Object
	{
		// Token: 0x06000168 RID: 360 RVA: 0x000093CC File Offset: 0x000075CC
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ISOLanguagesList()
		{
			Il2CppClassPointerStore<SA_ISOLanguagesList>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Localization", "SA_ISOLanguagesList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ISOLanguagesList>.NativeClassPtr);
			SA_ISOLanguagesList.NativeFieldInfoPtr_m_lanuages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ISOLanguagesList>.NativeClassPtr, "m_lanuages");
			SA_ISOLanguagesList.NativeFieldInfoPtr_m_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ISOLanguagesList>.NativeClassPtr, "m_names");
			SA_ISOLanguagesList.NativeMethodInfoPtr_get_Languages_Public_get_List_1_SA_ISOLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ISOLanguagesList>.NativeClassPtr, 100663523);
			SA_ISOLanguagesList.NativeMethodInfoPtr_get_Names_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ISOLanguagesList>.NativeClassPtr, 100663524);
			SA_ISOLanguagesList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ISOLanguagesList>.NativeClassPtr, 100663525);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00009460 File Offset: 0x00007660
		public unsafe List<SA_ISOLanguage> Languages
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ISOLanguagesList.NativeMethodInfoPtr_get_Languages_Public_get_List_1_SA_ISOLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SA_ISOLanguage>>(intPtr3) : null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000094A0 File Offset: 0x000076A0
		public unsafe List<string> Names
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100354, XrefRangeEnd = 100377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ISOLanguagesList.NativeMethodInfoPtr_get_Names_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000094E0 File Offset: 0x000076E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100377, XrefRangeEnd = 100384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ISOLanguagesList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ISOLanguagesList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ISOLanguagesList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000024F5 File Offset: 0x000006F5
		public SA_ISOLanguagesList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000951C File Offset: 0x0000771C
		// (set) Token: 0x0600016E RID: 366 RVA: 0x000024FE File Offset: 0x000006FE
		public unsafe List<SA_ISOLanguage> m_lanuages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguagesList.NativeFieldInfoPtr_m_lanuages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SA_ISOLanguage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguagesList.NativeFieldInfoPtr_m_lanuages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000954C File Offset: 0x0000774C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000251D File Offset: 0x0000071D
		public unsafe List<string> m_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguagesList.NativeFieldInfoPtr_m_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ISOLanguagesList.NativeFieldInfoPtr_m_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_m_lanuages;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_m_names;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_get_Languages_Public_get_List_1_SA_ISOLanguage_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_get_List_1_String_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
