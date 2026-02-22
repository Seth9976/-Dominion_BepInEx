using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200000A RID: 10
	public static class BinHexEncoder : Object
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000A6D8 File Offset: 0x000088D8
		// Note: this type is marked as 'beforefieldinit'.
		static BinHexEncoder()
		{
			Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinHexEncoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr);
			BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr, 100663351);
			BinHexEncoder.NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr, 100663352);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000A730 File Offset: 0x00008930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11714, RefRangeEnd = 11716, XrefRangeStart = 11705, XrefRangeEnd = 11714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Encode(Il2CppStructArray<byte> inArray, int offsetIn, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000A788 File Offset: 0x00008988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11716, XrefRangeEnd = 11721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Encode(Il2CppStructArray<byte> inArray, int offsetIn, int count, Il2CppStructArray<char> outArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexEncoder.NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002405 File Offset: 0x00000605
		public BinHexEncoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0;
	}
}
