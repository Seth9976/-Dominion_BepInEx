using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200024A RID: 586
	public static class EncodingTable : Object
	{
		// Token: 0x0600283C RID: 10300 RVA: 0x000D3820 File Offset: 0x000D1A20
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingTable()
		{
			Il2CppClassPointerStore<EncodingTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "EncodingTable");
			EncodingTable.NativeFieldInfoPtr_encodingDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "encodingDataPtr");
			EncodingTable.NativeFieldInfoPtr_codePageDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "codePageDataPtr");
			EncodingTable.NativeFieldInfoPtr_lastEncodingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "lastEncodingItem");
			EncodingTable.NativeFieldInfoPtr_hashByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "hashByName");
			EncodingTable.NativeFieldInfoPtr_hashByCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "hashByCodePage");
			EncodingTable.NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669801);
			EncodingTable.NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669802);
			EncodingTable.NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669803);
			EncodingTable.NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669805);
			EncodingTable.NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669806);
			EncodingTable.NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669807);
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000D3924 File Offset: 0x000D1B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328499, XrefRangeEnd = 328503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumEncodingItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000D3954 File Offset: 0x000D1B54
		[CallerCount(0)]
		public unsafe static InternalEncodingDataItem ENC(string name, ushort cp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InternalEncodingDataItem(intPtr);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000D39A0 File Offset: 0x000D1BA0
		[CallerCount(0)]
		public unsafe static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fcp;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(names);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InternalCodePageDataItem(intPtr);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000D3A08 File Offset: 0x000D1C08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328520, RefRangeEnd = 328522, XrefRangeStart = 328503, XrefRangeEnd = 328520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int internalGetCodePageFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000D3A4C File Offset: 0x000D1C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328522, XrefRangeEnd = 328533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCodePageFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x000D3A90 File Offset: 0x000D1C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328554, RefRangeEnd = 328555, XrefRangeStart = 328533, XrefRangeEnd = 328554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CodePageDataItem GetCodePageDataItem(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CodePageDataItem>(intPtr3) : null;
			}
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x0000DDA1 File Offset: 0x0000BFA1
		public EncodingTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x000D3AD0 File Offset: 0x000D1CD0
		// (set) Token: 0x06002845 RID: 10309 RVA: 0x0000DDAA File Offset: 0x0000BFAA
		public unsafe static Il2CppReferenceArray<InternalEncodingDataItem> encodingDataPtr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_encodingDataPtr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternalEncodingDataItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_encodingDataPtr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x000D3AF8 File Offset: 0x000D1CF8
		// (set) Token: 0x06002847 RID: 10311 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		public unsafe static Il2CppReferenceArray<InternalCodePageDataItem> codePageDataPtr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_codePageDataPtr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternalCodePageDataItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_codePageDataPtr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000D3B20 File Offset: 0x000D1D20
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x0000DDCE File Offset: 0x0000BFCE
		public unsafe static int lastEncodingItem
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_lastEncodingItem, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_lastEncodingItem, (void*)(&value));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000D3B3C File Offset: 0x000D1D3C
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		public unsafe static Hashtable hashByName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_hashByName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_hashByName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x000D3B64 File Offset: 0x000D1D64
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x0000DDEE File Offset: 0x0000BFEE
		public unsafe static Hashtable hashByCodePage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_hashByCodePage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_hashByCodePage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023C0 RID: 9152
		private static readonly IntPtr NativeFieldInfoPtr_encodingDataPtr;

		// Token: 0x040023C1 RID: 9153
		private static readonly IntPtr NativeFieldInfoPtr_codePageDataPtr;

		// Token: 0x040023C2 RID: 9154
		private static readonly IntPtr NativeFieldInfoPtr_lastEncodingItem;

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeFieldInfoPtr_hashByName;

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeFieldInfoPtr_hashByCodePage;

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0;

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0;

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0;
	}
}
