using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004D RID: 77
	public sealed class XmlCharType : ValueType
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x00025F34 File Offset: 0x00024134
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCharType()
		{
			Il2CppClassPointerStore<XmlCharType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlCharType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr);
			XmlCharType.NativeFieldInfoPtr_s_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "s_Lock");
			XmlCharType.NativeFieldInfoPtr_s_CharProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "s_CharProperties");
			XmlCharType.NativeFieldInfoPtr_charProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "charProperties");
			XmlCharType.NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664413);
			XmlCharType.NativeMethodInfoPtr_InitInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664414);
			XmlCharType.NativeMethodInfoPtr_SetProperties_Private_Static_Void_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664415);
			XmlCharType.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664416);
			XmlCharType.NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664417);
			XmlCharType.NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664418);
			XmlCharType.NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664419);
			XmlCharType.NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664420);
			XmlCharType.NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664421);
			XmlCharType.NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664422);
			XmlCharType.NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664423);
			XmlCharType.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664424);
			XmlCharType.NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664425);
			XmlCharType.NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664426);
			XmlCharType.NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664427);
			XmlCharType.NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664428);
			XmlCharType.NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664429);
			XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664430);
			XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664431);
			XmlCharType.NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664432);
			XmlCharType.NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664433);
			XmlCharType.NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664434);
			XmlCharType.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100664435);
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0002616C File Offset: 0x0002436C
		public unsafe static Object StaticLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19495, XrefRangeEnd = 19504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000261A0 File Offset: 0x000243A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19548, RefRangeEnd = 19551, XrefRangeStart = 19504, XrefRangeEnd = 19548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_InitInstance_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000261C8 File Offset: 0x000243C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 19557, RefRangeEnd = 19565, XrefRangeStart = 19551, XrefRangeEnd = 19557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProperties(string ranges, byte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ranges);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_SetProperties_Private_Static_Void_String_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0002620C File Offset: 0x0002440C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlCharType(Il2CppStructArray<byte> charProperties)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(charProperties);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0002625C File Offset: 0x0002445C
		public unsafe static XmlCharType Instance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 19583, RefRangeEnd = 19589, XrefRangeStart = 19577, XrefRangeEnd = 19583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new XmlCharType(intPtr);
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00026288 File Offset: 0x00024488
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 19589, RefRangeEnd = 19595, XrefRangeStart = 19589, XrefRangeEnd = 19589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWhiteSpace(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000262D8 File Offset: 0x000244D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19595, RefRangeEnd = 19599, XrefRangeStart = 19595, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNCNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00026328 File Offset: 0x00024528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19599, RefRangeEnd = 19601, XrefRangeStart = 19599, XrefRangeEnd = 19599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStartNCNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00026378 File Offset: 0x00024578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19601, RefRangeEnd = 19603, XrefRangeStart = 19601, XrefRangeEnd = 19601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000263C8 File Offset: 0x000245C8
		[CallerCount(0)]
		public unsafe bool IsCharData(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00026418 File Offset: 0x00024618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19604, RefRangeEnd = 19605, XrefRangeStart = 19603, XrefRangeEnd = 19604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPubidChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00026468 File Offset: 0x00024668
		[CallerCount(0)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000264A8 File Offset: 0x000246A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 19605, RefRangeEnd = 19613, XrefRangeStart = 19605, XrefRangeEnd = 19605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHighSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000264E8 File Offset: 0x000246E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 19613, RefRangeEnd = 19621, XrefRangeStart = 19613, XrefRangeEnd = 19613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLowSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00026528 File Offset: 0x00024728
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19621, RefRangeEnd = 19625, XrefRangeStart = 19621, XrefRangeEnd = 19621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00026568 File Offset: 0x00024768
		[CallerCount(0)]
		public unsafe static int CombineSurrogateChar(int lowChar, int highChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lowChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000265B4 File Offset: 0x000247B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19625, RefRangeEnd = 19626, XrefRangeStart = 19625, XrefRangeEnd = 19625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref combinedChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lowChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00026604 File Offset: 0x00024804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19626, XrefRangeEnd = 19628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOnlyWhitespace(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00026658 File Offset: 0x00024858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19628, XrefRangeEnd = 19631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsOnlyWhitespaceWithPos(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000266AC File Offset: 0x000248AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19636, RefRangeEnd = 19637, XrefRangeStart = 19631, XrefRangeEnd = 19636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsOnlyCharData(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00026700 File Offset: 0x00024900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19637, XrefRangeEnd = 19638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOnlyDigits(string str, int startPos, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00026760 File Offset: 0x00024960
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19643, XrefRangeStart = 19638, XrefRangeEnd = 19641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsPublicId(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000267B4 File Offset: 0x000249B4
		[CallerCount(0)]
		public unsafe static bool InRange(int value, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00004498 File Offset: 0x00002698
		public XmlCharType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000044A1 File Offset: 0x000026A1
		public XmlCharType()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr))
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00026810 File Offset: 0x00024A10
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x000044B3 File Offset: 0x000026B3
		public unsafe static Object s_Lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlCharType.NativeFieldInfoPtr_s_Lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlCharType.NativeFieldInfoPtr_s_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00026838 File Offset: 0x00024A38
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x000044C5 File Offset: 0x000026C5
		public unsafe static Il2CppStructArray<byte> s_CharProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlCharType.NativeFieldInfoPtr_s_CharProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlCharType.NativeFieldInfoPtr_s_CharProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00026860 File Offset: 0x00024A60
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x000044D7 File Offset: 0x000026D7
		public unsafe Il2CppStructArray<byte> charProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCharType.NativeFieldInfoPtr_charProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCharType.NativeFieldInfoPtr_charProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_s_Lock;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_s_CharProperties;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_charProperties;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_InitInstance_Private_Static_Void_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Private_Static_Void_String_Byte_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0;
	}
}
