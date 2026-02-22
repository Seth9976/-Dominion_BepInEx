using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000080 RID: 128
	public static class BitConverter : Object
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x00043EFC File Offset: 0x000420FC
		// Note: this type is marked as 'beforefieldinit'.
		static BitConverter()
		{
			Il2CppClassPointerStore<BitConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "BitConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitConverter>.NativeClassPtr);
			BitConverter.NativeFieldInfoPtr_IsLittleEndian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, "IsLittleEndian");
			BitConverter.NativeMethodInfoPtr_AmILittleEndian_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664476);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664477);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664478);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664479);
			BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664480);
			BitConverter.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664481);
			BitConverter.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664482);
			BitConverter.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664483);
			BitConverter.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664484);
			BitConverter.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664485);
			BitConverter.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664486);
			BitConverter.NativeMethodInfoPtr_GetHexValue_Private_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664487);
			BitConverter.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664488);
			BitConverter.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664489);
			BitConverter.NativeMethodInfoPtr_DoubleToInt64Bits_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664490);
			BitConverter.NativeMethodInfoPtr_Int64BitsToDouble_Public_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverter>.NativeClassPtr, 100664491);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00044080 File Offset: 0x00042280
		[CallerCount(0)]
		public unsafe static bool AmILittleEndian()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_AmILittleEndian_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000440B0 File Offset: 0x000422B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276523, RefRangeEnd = 276524, XrefRangeStart = 276520, XrefRangeEnd = 276523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000440F0 File Offset: 0x000422F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276527, RefRangeEnd = 276528, XrefRangeStart = 276524, XrefRangeEnd = 276527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00044130 File Offset: 0x00042330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276531, RefRangeEnd = 276534, XrefRangeStart = 276528, XrefRangeEnd = 276531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00044170 File Offset: 0x00042370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276540, RefRangeEnd = 276542, XrefRangeStart = 276534, XrefRangeEnd = 276540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000441B0 File Offset: 0x000423B0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 276548, RefRangeEnd = 276564, XrefRangeStart = 276542, XrefRangeEnd = 276548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00044200 File Offset: 0x00042400
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276570, RefRangeEnd = 276573, XrefRangeStart = 276564, XrefRangeEnd = 276570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00044250 File Offset: 0x00042450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276579, RefRangeEnd = 276580, XrefRangeStart = 276573, XrefRangeEnd = 276579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000442A0 File Offset: 0x000424A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276594, RefRangeEnd = 276595, XrefRangeStart = 276580, XrefRangeEnd = 276594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000442F0 File Offset: 0x000424F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276609, RefRangeEnd = 276610, XrefRangeStart = 276595, XrefRangeEnd = 276609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00044340 File Offset: 0x00042540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276620, RefRangeEnd = 276621, XrefRangeStart = 276610, XrefRangeEnd = 276620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00044390 File Offset: 0x00042590
		[CallerCount(0)]
		public unsafe static char GetHexValue(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_GetHexValue_Private_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000443D0 File Offset: 0x000425D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276630, RefRangeEnd = 276631, XrefRangeStart = 276621, XrefRangeEnd = 276630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<byte> value, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00044428 File Offset: 0x00042628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276631, XrefRangeEnd = 276641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00044464 File Offset: 0x00042664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20243, RefRangeEnd = 20244, XrefRangeStart = 20243, XrefRangeEnd = 20244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DoubleToInt64Bits(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_DoubleToInt64Bits_Public_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000444A4 File Offset: 0x000426A4
		[CallerCount(0)]
		public unsafe static double Int64BitsToDouble(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverter.NativeMethodInfoPtr_Int64BitsToDouble_Public_Static_Double_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0000466D File Offset: 0x0000286D
		public BitConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000444E4 File Offset: 0x000426E4
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00004676 File Offset: 0x00002876
		public unsafe static bool IsLittleEndian
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BitConverter.NativeFieldInfoPtr_IsLittleEndian, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BitConverter.NativeFieldInfoPtr_IsLittleEndian, (void*)(&value));
			}
		}

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_IsLittleEndian;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_AmILittleEndian_Private_Static_Boolean_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int16_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_UInt64_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_GetHexValue_Private_Static_Char_Int32_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToInt64Bits_Public_Static_Int64_Double_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_Int64BitsToDouble_Public_Static_Double_Int64_0;
	}
}
