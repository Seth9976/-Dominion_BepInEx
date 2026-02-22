using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000C RID: 12
	public static class RuntimeMarshal : Object
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00023760 File Offset: 0x00021960
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeMarshal()
		{
			Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeMarshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr);
			RuntimeMarshal.NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663339);
			RuntimeMarshal.NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663340);
			RuntimeMarshal.NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663341);
			RuntimeMarshal.NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663342);
			RuntimeMarshal.NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663343);
			RuntimeMarshal.NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663344);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00023808 File Offset: 0x00021A08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258423, RefRangeEnd = 258425, XrefRangeStart = 258416, XrefRangeEnd = 258423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToUtf8String(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00023840 File Offset: 0x00021A40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258426, RefRangeEnd = 258428, XrefRangeStart = 258425, XrefRangeEnd = 258426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeStringMarshal MarshalString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SafeStringMarshal(intPtr);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0002387C File Offset: 0x00021A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258428, XrefRangeEnd = 258432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref in_ptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &out_ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000238C8 File Offset: 0x00021AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258443, RefRangeEnd = 258444, XrefRangeStart = 258432, XrefRangeEnd = 258443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> DecodeBlobArray(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00023908 File Offset: 0x00021B08
		[CallerCount(0)]
		public unsafe static int AsciHexDigitValue(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00023948 File Offset: 0x00021B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258445, RefRangeEnd = 258446, XrefRangeStart = 258444, XrefRangeEnd = 258445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref freeStruct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000020EE File Offset: 0x000002EE
		public RuntimeMarshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0;
	}
}
