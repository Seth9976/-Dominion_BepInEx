using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200003D RID: 61
	public class UncNameHelper : Object
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0001F7BC File Offset: 0x0001D9BC
		// Note: this type is marked as 'beforefieldinit'.
		static UncNameHelper()
		{
			Il2CppClassPointerStore<UncNameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UncNameHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UncNameHelper>.NativeClassPtr);
			UncNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncNameHelper>.NativeClassPtr, 100663885);
			UncNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncNameHelper>.NativeClassPtr, 100663886);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0001F814 File Offset: 0x0001DA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37065, XrefRangeEnd = 37066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &loopback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0001F87C File Offset: 0x0001DA7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37070, RefRangeEnd = 37071, XrefRangeStart = 37066, XrefRangeEnd = 37070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00003426 File Offset: 0x00001626
		public UncNameHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_Boolean_0;
	}
}
