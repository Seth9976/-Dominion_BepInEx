using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004C RID: 76
	public static class ValidateNames : Object
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x00025AFC File Offset: 0x00023CFC
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateNames()
		{
			Il2CppClassPointerStore<ValidateNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ValidateNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr);
			ValidateNames.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, "xmlCharType");
			ValidateNames.NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664403);
			ValidateNames.NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664404);
			ValidateNames.NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664405);
			ValidateNames.NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664406);
			ValidateNames.NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664407);
			ValidateNames.NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664408);
			ValidateNames.NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664409);
			ValidateNames.NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664410);
			ValidateNames.NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664411);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00025BF4 File Offset: 0x00023DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19377, RefRangeEnd = 19378, XrefRangeStart = 19371, XrefRangeEnd = 19377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNmtoken(string s, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00025C44 File Offset: 0x00023E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19385, RefRangeEnd = 19386, XrefRangeStart = 19378, XrefRangeEnd = 19385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNmtokenNoNamespaces(string s, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00025C94 File Offset: 0x00023E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19392, RefRangeEnd = 19394, XrefRangeStart = 19386, XrefRangeEnd = 19392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNameNoNamespaces(string s, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00025CE4 File Offset: 0x00023EE4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 19399, RefRangeEnd = 19408, XrefRangeStart = 19394, XrefRangeEnd = 19399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNCName(string s, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00025D34 File Offset: 0x00023F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19412, RefRangeEnd = 19413, XrefRangeStart = 19408, XrefRangeEnd = 19412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNCName(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00025D78 File Offset: 0x00023F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19413, XrefRangeEnd = 19421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseQName(string s, int offset, out int colonOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colonOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00025DD8 File Offset: 0x00023FD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19435, RefRangeEnd = 19437, XrefRangeStart = 19421, XrefRangeEnd = 19435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseQNameThrow(string s, out string prefix, out string localName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			localName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00025E44 File Offset: 0x00024044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19437, XrefRangeEnd = 19474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetStartChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetBadChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00025E98 File Offset: 0x00024098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19474, XrefRangeEnd = 19495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetStartChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetBadChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00004478 File Offset: 0x00002678
		public ValidateNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00025EF8 File Offset: 0x000240F8
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00004481 File Offset: 0x00002681
		public unsafe static XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ValidateNames.NativeFieldInfoPtr_xmlCharType, intPtr);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidateNames.NativeFieldInfoPtr_xmlCharType, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0;
	}
}
