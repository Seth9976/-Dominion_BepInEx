using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000226 RID: 550
	public static class CharUnicodeInfo : Object
	{
		// Token: 0x060023A6 RID: 9126 RVA: 0x000C2674 File Offset: 0x000C0874
		// Note: this type is marked as 'beforefieldinit'.
		static CharUnicodeInfo()
		{
			Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CharUnicodeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr);
			CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoryLevel1Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pCategoryLevel1Index");
			CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoriesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pCategoriesValue");
			CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericLevel1Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pNumericLevel1Index");
			CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pNumericValues");
			CharUnicodeInfo.NativeFieldInfoPtr_s_pDigitValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pDigitValues");
			CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669271);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669272);
			CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669273);
			CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669274);
			CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669275);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669276);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669277);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669278);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669279);
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x000C27BC File Offset: 0x000C09BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324542, XrefRangeEnd = 324553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalConvertToUtf32(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000C280C File Offset: 0x000C0A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324553, XrefRangeEnd = 324565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalConvertToUtf32(string s, int index, out int charLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000C286C File Offset: 0x000C0A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324565, XrefRangeEnd = 324573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000C28AC File Offset: 0x000C0AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324573, XrefRangeEnd = 324577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000C28EC File Offset: 0x000C0AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324577, XrefRangeEnd = 324593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x000C293C File Offset: 0x000C0B3C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 324604, RefRangeEnd = 324619, XrefRangeStart = 324593, XrefRangeEnd = 324604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory InternalGetUnicodeCategory(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000C297C File Offset: 0x000C0B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324619, XrefRangeEnd = 324627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte InternalGetCategoryValue(int ch, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000C29C8 File Offset: 0x000C0BC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 324649, RefRangeEnd = 324652, XrefRangeStart = 324627, XrefRangeEnd = 324649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x000C2A18 File Offset: 0x000C0C18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324680, RefRangeEnd = 324682, XrefRangeStart = 324652, XrefRangeEnd = 324680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0000BFEA File Offset: 0x0000A1EA
		public CharUnicodeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x000C2A78 File Offset: 0x000C0C78
		// (set) Token: 0x060023B2 RID: 9138 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
		public unsafe static Il2CppStructArray<ushort> s_pCategoryLevel1Index
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoryLevel1Index, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoryLevel1Index, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x000C2AA0 File Offset: 0x000C0CA0
		// (set) Token: 0x060023B4 RID: 9140 RVA: 0x0000C005 File Offset: 0x0000A205
		public unsafe static Il2CppStructArray<byte> s_pCategoriesValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoriesValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoriesValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x000C2AC8 File Offset: 0x000C0CC8
		// (set) Token: 0x060023B6 RID: 9142 RVA: 0x0000C017 File Offset: 0x0000A217
		public unsafe static Il2CppStructArray<ushort> s_pNumericLevel1Index
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericLevel1Index, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericLevel1Index, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x000C2AF0 File Offset: 0x000C0CF0
		// (set) Token: 0x060023B8 RID: 9144 RVA: 0x0000C029 File Offset: 0x0000A229
		public unsafe static Il2CppStructArray<byte> s_pNumericValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x000C2B18 File Offset: 0x000C0D18
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x0000C03B File Offset: 0x0000A23B
		public unsafe static Il2CppStructArray<ushort> s_pDigitValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pDigitValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pDigitValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeFieldInfoPtr_s_pCategoryLevel1Index;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeFieldInfoPtr_s_pCategoriesValue;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeFieldInfoPtr_s_pNumericLevel1Index;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeFieldInfoPtr_s_pNumericValues;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeFieldInfoPtr_s_pDigitValues;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_Int32_0;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0;

		// Token: 0x020005DC RID: 1500
		public static class Debug : Object
		{
			// Token: 0x06005209 RID: 21001 RVA: 0x0001F3CB File Offset: 0x0001D5CB
			// Note: this type is marked as 'beforefieldinit'.
			static Debug()
			{
				Il2CppClassPointerStore<CharUnicodeInfo.Debug>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "Debug");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharUnicodeInfo.Debug>.NativeClassPtr);
				CharUnicodeInfo.Debug.NativeMethodInfoPtr_Assert_Internal_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo.Debug>.NativeClassPtr, 100669281);
			}

			// Token: 0x0600520A RID: 21002 RVA: 0x0016E67C File Offset: 0x0016C87C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Assert(bool condition, string message)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref condition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.Debug.NativeMethodInfoPtr_Assert_Internal_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600520B RID: 21003 RVA: 0x0001F3FF File Offset: 0x0001D5FF
			public Debug(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400425D RID: 16989
			private static readonly IntPtr NativeMethodInfoPtr_Assert_Internal_Static_Void_Boolean_String_0;
		}
	}
}
