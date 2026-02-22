using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000050 RID: 80
	public class XmlConvert : Object
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x00026960 File Offset: 0x00024B60
		// Note: this type is marked as 'beforefieldinit'.
		static XmlConvert()
		{
			Il2CppClassPointerStore<XmlConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlConvert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr);
			XmlConvert.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "xmlCharType");
			XmlConvert.NativeFieldInfoPtr_crt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "crt");
			XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_EncodedCharLength");
			XmlConvert.NativeFieldInfoPtr_WhitespaceChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "WhitespaceChars");
			XmlConvert.NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664438);
			XmlConvert.NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664439);
			XmlConvert.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664440);
			XmlConvert.NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664441);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664442);
			XmlConvert.NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664443);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664444);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664445);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664446);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664447);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664448);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664449);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664450);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664451);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664452);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664453);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664454);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664455);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664456);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664457);
			XmlConvert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664458);
			XmlConvert.NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664459);
			XmlConvert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664460);
			XmlConvert.NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664461);
			XmlConvert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664462);
			XmlConvert.NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664463);
			XmlConvert.NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664464);
			XmlConvert.NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664465);
			XmlConvert.NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664466);
			XmlConvert.NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664467);
			XmlConvert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664468);
			XmlConvert.NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664469);
			XmlConvert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664470);
			XmlConvert.NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664471);
			XmlConvert.NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664472);
			XmlConvert.NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664473);
			XmlConvert.NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664474);
			XmlConvert.NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664475);
			XmlConvert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664476);
			XmlConvert.NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664477);
			XmlConvert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664478);
			XmlConvert.NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664479);
			XmlConvert.NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664480);
			XmlConvert.NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664481);
			XmlConvert.NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664482);
			XmlConvert.NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664483);
			XmlConvert.NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664484);
			XmlConvert.NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664485);
			XmlConvert.NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664486);
			XmlConvert.NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664487);
			XmlConvert.NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664488);
			XmlConvert.NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664489);
			XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664490);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664491);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664492);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00026E2C File Offset: 0x0002502C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19693, RefRangeEnd = 19695, XrefRangeStart = 19685, XrefRangeEnd = 19693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBinHexString(string s, bool allowOddCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOddCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00026E80 File Offset: 0x00025080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19695, XrefRangeEnd = 19702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBinHexString(Il2CppStructArray<byte> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00026EBC File Offset: 0x000250BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19706, RefRangeEnd = 19707, XrefRangeStart = 19702, XrefRangeEnd = 19706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00026EF8 File Offset: 0x000250F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19716, RefRangeEnd = 19717, XrefRangeStart = 19707, XrefRangeEnd = 19716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00026F3C File Offset: 0x0002513C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19721, RefRangeEnd = 19722, XrefRangeStart = 19717, XrefRangeEnd = 19721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNCName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00026F80 File Offset: 0x00025180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19738, RefRangeEnd = 19739, XrefRangeStart = 19722, XrefRangeEnd = 19738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyTOKEN(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00026FC4 File Offset: 0x000251C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19747, RefRangeEnd = 19748, XrefRangeStart = 19739, XrefRangeEnd = 19747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNMTOKEN(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00027008 File Offset: 0x00025208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19755, RefRangeEnd = 19756, XrefRangeStart = 19748, XrefRangeEnd = 19755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNormalizedString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0002704C File Offset: 0x0002524C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19760, RefRangeEnd = 19761, XrefRangeStart = 19756, XrefRangeEnd = 19760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00027084 File Offset: 0x00025284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19763, RefRangeEnd = 19765, XrefRangeStart = 19761, XrefRangeEnd = 19763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000270BC File Offset: 0x000252BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19765, XrefRangeEnd = 19767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000270F4 File Offset: 0x000252F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19767, XrefRangeEnd = 19769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0002712C File Offset: 0x0002532C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 19771, RefRangeEnd = 19780, XrefRangeStart = 19769, XrefRangeEnd = 19771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00027164 File Offset: 0x00025364
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19782, RefRangeEnd = 19785, XrefRangeStart = 19780, XrefRangeEnd = 19782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0002719C File Offset: 0x0002539C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19785, XrefRangeEnd = 19787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000271D4 File Offset: 0x000253D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19787, XrefRangeEnd = 19789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0002720C File Offset: 0x0002540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19789, XrefRangeEnd = 19791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00027244 File Offset: 0x00025444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19791, XrefRangeEnd = 19793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0002727C File Offset: 0x0002547C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19806, RefRangeEnd = 19809, XrefRangeStart = 19793, XrefRangeEnd = 19806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000272B4 File Offset: 0x000254B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19827, RefRangeEnd = 19830, XrefRangeStart = 19809, XrefRangeEnd = 19827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000272EC File Offset: 0x000254EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19851, RefRangeEnd = 19854, XrefRangeStart = 19830, XrefRangeEnd = 19851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00027330 File Offset: 0x00025530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19890, RefRangeEnd = 19891, XrefRangeStart = 19854, XrefRangeEnd = 19890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToBoolean(string s, out bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00027384 File Offset: 0x00025584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19905, RefRangeEnd = 19906, XrefRangeStart = 19891, XrefRangeEnd = 19905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000273C8 File Offset: 0x000255C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19914, RefRangeEnd = 19915, XrefRangeStart = 19906, XrefRangeEnd = 19914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToChar(string s, out char result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0002741C File Offset: 0x0002561C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 19920, RefRangeEnd = 19927, XrefRangeStart = 19915, XrefRangeEnd = 19920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00027460 File Offset: 0x00025660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19936, RefRangeEnd = 19938, XrefRangeStart = 19927, XrefRangeEnd = 19936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToDecimal(string s, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000274B4 File Offset: 0x000256B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19943, RefRangeEnd = 19944, XrefRangeStart = 19938, XrefRangeEnd = 19943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToInteger(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000274F8 File Offset: 0x000256F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19953, RefRangeEnd = 19954, XrefRangeStart = 19944, XrefRangeEnd = 19953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInteger(string s, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0002754C File Offset: 0x0002574C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19960, RefRangeEnd = 19961, XrefRangeStart = 19954, XrefRangeEnd = 19960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToSByte(string s, out sbyte result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000275A0 File Offset: 0x000257A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19967, RefRangeEnd = 19968, XrefRangeStart = 19961, XrefRangeEnd = 19967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt16(string s, out short result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000275F4 File Offset: 0x000257F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 19970, RefRangeEnd = 19977, XrefRangeStart = 19968, XrefRangeEnd = 19970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00027638 File Offset: 0x00025838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19983, RefRangeEnd = 19984, XrefRangeStart = 19977, XrefRangeEnd = 19983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt32(string s, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0002768C File Offset: 0x0002588C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 19986, RefRangeEnd = 19991, XrefRangeStart = 19984, XrefRangeEnd = 19986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000276D0 File Offset: 0x000258D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19997, RefRangeEnd = 19998, XrefRangeStart = 19991, XrefRangeEnd = 19997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt64(string s, out long result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00027724 File Offset: 0x00025924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20004, RefRangeEnd = 20005, XrefRangeStart = 19998, XrefRangeEnd = 20004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToByte(string s, out byte result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00027778 File Offset: 0x00025978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20011, RefRangeEnd = 20012, XrefRangeStart = 20005, XrefRangeEnd = 20011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt16(string s, out ushort result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000277CC File Offset: 0x000259CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20018, RefRangeEnd = 20019, XrefRangeStart = 20012, XrefRangeEnd = 20018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt32(string s, out uint result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00027820 File Offset: 0x00025A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20025, RefRangeEnd = 20026, XrefRangeStart = 20019, XrefRangeEnd = 20025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt64(string s, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00027874 File Offset: 0x00025A74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20044, RefRangeEnd = 20048, XrefRangeStart = 20026, XrefRangeEnd = 20044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000278B8 File Offset: 0x00025AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20070, RefRangeEnd = 20071, XrefRangeStart = 20048, XrefRangeEnd = 20070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToSingle(string s, out float result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0002790C File Offset: 0x00025B0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 20092, RefRangeEnd = 20097, XrefRangeStart = 20071, XrefRangeEnd = 20092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00027950 File Offset: 0x00025B50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20122, RefRangeEnd = 20123, XrefRangeStart = 20097, XrefRangeEnd = 20122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToDouble(string s, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000279A4 File Offset: 0x00025BA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20126, RefRangeEnd = 20127, XrefRangeStart = 20123, XrefRangeEnd = 20126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToTimeSpan(string s, out TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000279F8 File Offset: 0x00025BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20128, RefRangeEnd = 20129, XrefRangeStart = 20127, XrefRangeEnd = 20128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid ToGuid(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00027A3C File Offset: 0x00025C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20153, RefRangeEnd = 20154, XrefRangeStart = 20129, XrefRangeEnd = 20153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToGuid(string s, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00027A90 File Offset: 0x00025C90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20170, RefRangeEnd = 20174, XrefRangeStart = 20154, XrefRangeEnd = 20170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ToUri(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00027AD4 File Offset: 0x00025CD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20202, RefRangeEnd = 20204, XrefRangeStart = 20174, XrefRangeEnd = 20202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUri(string s, out Uri result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00027B3C File Offset: 0x00025D3C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 20205, RefRangeEnd = 20220, XrefRangeStart = 20204, XrefRangeEnd = 20205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StrEqual(Il2CppStructArray<char> chars, int strPos1, int strLen1, string str2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strPos1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strLen1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00027BAC File Offset: 0x00025DAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20226, RefRangeEnd = 20229, XrefRangeStart = 20220, XrefRangeEnd = 20226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00027BE8 File Offset: 0x00025DE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20235, RefRangeEnd = 20238, XrefRangeStart = 20229, XrefRangeEnd = 20235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray SplitString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00027C2C File Offset: 0x00025E2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20241, RefRangeEnd = 20243, XrefRangeStart = 20238, XrefRangeEnd = 20241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNegativeZero(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00027C6C File Offset: 0x00025E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20243, RefRangeEnd = 20244, XrefRangeStart = 20243, XrefRangeEnd = 20243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DoubleToInt64Bits(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00027CAC File Offset: 0x00025EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20244, XrefRangeEnd = 20254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateException(string res, Il2CppStringArray args, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00027D2C File Offset: 0x00025F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20254, XrefRangeEnd = 20275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00027D8C File Offset: 0x00025F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20275, XrefRangeEnd = 20281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argumentName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000044FF File Offset: 0x000026FF
		public XmlConvert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00027DE4 File Offset: 0x00025FE4
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00004508 File Offset: 0x00002708
		public unsafe static XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_xmlCharType, intPtr);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_xmlCharType, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00027E20 File Offset: 0x00026020
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0000451F File Offset: 0x0000271F
		public unsafe static Il2CppStructArray<char> crt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_crt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_crt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00027E48 File Offset: 0x00026048
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00004531 File Offset: 0x00002731
		public unsafe static int c_EncodedCharLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength, (void*)(&value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00027E64 File Offset: 0x00026064
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0000453F File Offset: 0x0000273F
		public unsafe static Il2CppStructArray<char> WhitespaceChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_WhitespaceChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_WhitespaceChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_crt;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr_c_EncodedCharLength;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_WhitespaceChars;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Single_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Double_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0;
	}
}
