using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000249 RID: 585
	[Serializable]
	public class CodePageDataItem : Object
	{
		// Token: 0x0600282A RID: 10282 RVA: 0x000D3534 File Offset: 0x000D1734
		// Note: this type is marked as 'beforefieldinit'.
		static CodePageDataItem()
		{
			Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CodePageDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr);
			CodePageDataItem.NativeFieldInfoPtr_m_dataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_dataIndex");
			CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_uiFamilyCodePage");
			CodePageDataItem.NativeFieldInfoPtr_m_webName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_webName");
			CodePageDataItem.NativeFieldInfoPtr_m_headerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_headerName");
			CodePageDataItem.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_flags");
			CodePageDataItem.NativeFieldInfoPtr_sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "sep");
			CodePageDataItem.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100669796);
			CodePageDataItem.NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100669797);
			CodePageDataItem.NativeMethodInfoPtr_get_WebName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100669798);
			CodePageDataItem.NativeMethodInfoPtr_get_HeaderName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100669799);
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000D362C File Offset: 0x000D182C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328476, RefRangeEnd = 328477, XrefRangeStart = 328470, XrefRangeEnd = 328476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CodePageDataItem(int dataIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000D3674 File Offset: 0x000D1874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328479, RefRangeEnd = 328481, XrefRangeStart = 328477, XrefRangeEnd = 328479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateString(string pStrings, uint index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pStrings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x000D36C0 File Offset: 0x000D18C0
		public unsafe string WebName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 328489, RefRangeEnd = 328490, XrefRangeStart = 328481, XrefRangeEnd = 328489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_get_WebName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x000D36F8 File Offset: 0x000D18F8
		public unsafe string HeaderName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 328498, RefRangeEnd = 328499, XrefRangeStart = 328490, XrefRangeEnd = 328498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_get_HeaderName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x0000DCF7 File Offset: 0x0000BEF7
		public CodePageDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x000D3730 File Offset: 0x000D1930
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x0000DD00 File Offset: 0x0000BF00
		public unsafe int m_dataIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_dataIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_dataIndex)) = value;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x000D3758 File Offset: 0x000D1958
		// (set) Token: 0x06002833 RID: 10291 RVA: 0x0000DD1B File Offset: 0x0000BF1B
		public unsafe int m_uiFamilyCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage)) = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x000D3780 File Offset: 0x000D1980
		// (set) Token: 0x06002835 RID: 10293 RVA: 0x0000DD36 File Offset: 0x0000BF36
		public unsafe string m_webName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_webName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_webName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002836 RID: 10294 RVA: 0x000D37A8 File Offset: 0x000D19A8
		// (set) Token: 0x06002837 RID: 10295 RVA: 0x0000DD55 File Offset: 0x0000BF55
		public unsafe string m_headerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_headerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_headerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002838 RID: 10296 RVA: 0x000D37D0 File Offset: 0x000D19D0
		// (set) Token: 0x06002839 RID: 10297 RVA: 0x0000DD74 File Offset: 0x0000BF74
		public unsafe uint m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x000D37F8 File Offset: 0x000D19F8
		// (set) Token: 0x0600283B RID: 10299 RVA: 0x0000DD8F File Offset: 0x0000BF8F
		public unsafe static Il2CppStructArray<char> sep
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CodePageDataItem.NativeFieldInfoPtr_sep, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePageDataItem.NativeFieldInfoPtr_sep, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeFieldInfoPtr_m_dataIndex;

		// Token: 0x040023B7 RID: 9143
		private static readonly IntPtr NativeFieldInfoPtr_m_uiFamilyCodePage;

		// Token: 0x040023B8 RID: 9144
		private static readonly IntPtr NativeFieldInfoPtr_m_webName;

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeFieldInfoPtr_m_headerName;

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeFieldInfoPtr_sep;

		// Token: 0x040023BC RID: 9148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040023BD RID: 9149
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0;

		// Token: 0x040023BE RID: 9150
		private static readonly IntPtr NativeMethodInfoPtr_get_WebName_Public_get_String_0;

		// Token: 0x040023BF RID: 9151
		private static readonly IntPtr NativeMethodInfoPtr_get_HeaderName_Public_get_String_0;
	}
}
