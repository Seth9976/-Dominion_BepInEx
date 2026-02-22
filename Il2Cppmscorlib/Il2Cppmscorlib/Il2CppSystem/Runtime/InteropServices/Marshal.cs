using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Security;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000459 RID: 1113
	public static class Marshal : Object
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x00134500 File Offset: 0x00132700
		// Note: this type is marked as 'beforefieldinit'.
		static Marshal()
		{
			Il2CppClassPointerStore<Marshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "Marshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marshal>.NativeClassPtr);
			Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SystemMaxDBCSCharSize");
			Marshal.NativeFieldInfoPtr_SystemDefaultCharSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SystemDefaultCharSize");
			Marshal.NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673034);
			Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673035);
			Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673036);
			Marshal.NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673037);
			Marshal.NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673038);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673039);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673040);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673041);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673042);
			Marshal.NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673043);
			Marshal.NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673044);
			Marshal.NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673045);
			Marshal.NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673046);
			Marshal.NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673047);
			Marshal.NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673048);
			Marshal.NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673049);
			Marshal.NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673050);
			Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673051);
			Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673052);
			Marshal.NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673053);
			Marshal.NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673054);
			Marshal.NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673055);
			Marshal.NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673056);
			Marshal.NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673057);
			Marshal.NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673058);
			Marshal.NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673059);
			Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673060);
			Marshal.NativeMethodInfoPtr_SecureStringToCoTaskMemUnicode_Public_Static_IntPtr_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673061);
			Marshal.NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673062);
			Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673063);
			Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673064);
			Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673065);
			Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673066);
			Marshal.NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673067);
			Marshal.NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673068);
			Marshal.NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673069);
			Marshal.NativeMethodInfoPtr_WriteIntPtr_Public_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673070);
			Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673071);
			Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673072);
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00134864 File Offset: 0x00132A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358397, XrefRangeEnd = 358398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocCoTaskMem(int cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x001348A4 File Offset: 0x00132AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358398, XrefRangeEnd = 358399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocHGlobal(IntPtr cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x001348E4 File Offset: 0x00132AE4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 358404, RefRangeEnd = 358478, XrefRangeStart = 358399, XrefRangeEnd = 358404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocHGlobal(int cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00134924 File Offset: 0x00132B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358478, XrefRangeEnd = 358479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00134984 File Offset: 0x00132B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358479, XrefRangeEnd = 358480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x001349E4 File Offset: 0x00132BE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 358484, RefRangeEnd = 358490, XrefRangeStart = 358480, XrefRangeEnd = 358484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppStructArray<byte> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00134A44 File Offset: 0x00132C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358494, RefRangeEnd = 358495, XrefRangeStart = 358490, XrefRangeEnd = 358494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppStructArray<IntPtr> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00134AA4 File Offset: 0x00132CA4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 358499, RefRangeEnd = 358510, XrefRangeStart = 358495, XrefRangeEnd = 358499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<byte> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00134B04 File Offset: 0x00132D04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358514, RefRangeEnd = 358516, XrefRangeStart = 358510, XrefRangeEnd = 358514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<char> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00134B64 File Offset: 0x00132D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358517, RefRangeEnd = 358518, XrefRangeStart = 358516, XrefRangeEnd = 358517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeBSTR(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00134B98 File Offset: 0x00132D98
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 358519, RefRangeEnd = 358591, XrefRangeStart = 358518, XrefRangeEnd = 358519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeHGlobal(IntPtr hglobal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hglobal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00134BCC File Offset: 0x00132DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358591, XrefRangeEnd = 358603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearUnicode(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00134C00 File Offset: 0x00132E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358626, RefRangeEnd = 358627, XrefRangeStart = 358603, XrefRangeEnd = 358626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00134C34 File Offset: 0x00132E34
		[CallerCount(0)]
		public unsafe static int GetHRForException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00134C78 File Offset: 0x00132E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358628, RefRangeEnd = 358630, XrefRangeStart = 358627, XrefRangeEnd = 358628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLastWin32Error()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00134CA8 File Offset: 0x00132EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358631, RefRangeEnd = 358633, XrefRangeStart = 358630, XrefRangeEnd = 358631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringAnsi(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x00134CE0 File Offset: 0x00132EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358634, RefRangeEnd = 358636, XrefRangeStart = 358633, XrefRangeEnd = 358634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringUni(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00134D18 File Offset: 0x00132F18
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 358637, RefRangeEnd = 358711, XrefRangeStart = 358636, XrefRangeEnd = 358637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PtrToStructure(IntPtr ptr, Type structureType)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(structureType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x00134D6C File Offset: 0x00132F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358720, RefRangeEnd = 358721, XrefRangeStart = 358711, XrefRangeEnd = 358720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T PtrToStructure<T>(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_PtrToStructure_Public_Static_T_IntPtr_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x00134DA8 File Offset: 0x00132FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358722, RefRangeEnd = 358723, XrefRangeStart = 358721, XrefRangeEnd = 358722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ReadByte(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x00134DF4 File Offset: 0x00132FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358723, XrefRangeEnd = 358725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ReadInt16(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x00134E40 File Offset: 0x00133040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358725, XrefRangeEnd = 358727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadInt32(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00134E80 File Offset: 0x00133080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358727, XrefRangeEnd = 358729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ReadInt64(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00134EC0 File Offset: 0x001330C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 358743, RefRangeEnd = 358746, XrefRangeStart = 358729, XrefRangeEnd = 358743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ReadIntPtr(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x00134F00 File Offset: 0x00133100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358746, XrefRangeEnd = 358747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReleaseInternal(IntPtr pUnk)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pUnk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x00134F40 File Offset: 0x00133140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358760, RefRangeEnd = 358761, XrefRangeStart = 358747, XrefRangeEnd = 358760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Release(IntPtr pUnk)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pUnk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x00134F80 File Offset: 0x00133180
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 358762, RefRangeEnd = 358789, XrefRangeStart = 358761, XrefRangeEnd = 358762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00134FC4 File Offset: 0x001331C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358805, RefRangeEnd = 358806, XrefRangeStart = 358789, XrefRangeEnd = 358805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SecureStringToCoTaskMemUnicode_Public_Static_IntPtr_SecureString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00135008 File Offset: 0x00133208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358816, RefRangeEnd = 358817, XrefRangeStart = 358806, XrefRangeEnd = 358816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x0013504C File Offset: 0x0013324C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358818, RefRangeEnd = 358819, XrefRangeStart = 358817, XrefRangeEnd = 358818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StructureToPtr(Object structure, IntPtr ptr, bool fDeleteOld)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(structure);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fDeleteOld;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x001350A0 File Offset: 0x001332A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358825, RefRangeEnd = 358826, XrefRangeStart = 358819, XrefRangeEnd = 358825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr3 = ref *ptr2;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = structure;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref structure;
				}
				ptr3 = intPtr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fDeleteOld;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0<T>.Pointer, 0, (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x00135128 File Offset: 0x00133328
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358827, RefRangeEnd = 358829, XrefRangeStart = 358826, XrefRangeEnd = 358827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x00135178 File Offset: 0x00133378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358837, RefRangeEnd = 358839, XrefRangeStart = 358829, XrefRangeEnd = 358837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr UnsafeAddrOfPinnedArrayElement<T>(Il2CppArrayBase<T> arr, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x001351C8 File Offset: 0x001333C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358841, RefRangeEnd = 358842, XrefRangeStart = 358839, XrefRangeEnd = 358841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt16(IntPtr ptr, int ofs, short val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x00135218 File Offset: 0x00133418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358842, XrefRangeEnd = 358844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt32(IntPtr ptr, int val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00135258 File Offset: 0x00133458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358844, XrefRangeEnd = 358846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt64(IntPtr ptr, long val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int64_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x00135298 File Offset: 0x00133498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358853, RefRangeEnd = 358854, XrefRangeStart = 358846, XrefRangeEnd = 358853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteIntPtr(IntPtr ptr, IntPtr val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteIntPtr_Public_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x001352D8 File Offset: 0x001334D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358855, RefRangeEnd = 358856, XrefRangeStart = 358854, XrefRangeEnd = 358855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFunctionPointerForDelegateInternal(Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x0013531C File Offset: 0x0013351C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358870, RefRangeEnd = 358871, XrefRangeStart = 358856, XrefRangeEnd = 358870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDelegate).IsValueType)
				{
					TDelegate tdelegate = d;
					intPtr = ((tdelegate is string) ? IL2CPP.ManagedStringToIl2Cpp(tdelegate as string) : IL2CPP.Il2CppObjectBaseToPtr(tdelegate as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref d;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0<TDelegate>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x00019C85 File Offset: 0x00017E85
		public Marshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06004366 RID: 17254 RVA: 0x00135394 File Offset: 0x00133594
		// (set) Token: 0x06004367 RID: 17255 RVA: 0x00019C8E File Offset: 0x00017E8E
		public unsafe static int SystemMaxDBCSCharSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize, (void*)(&value));
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x001353B0 File Offset: 0x001335B0
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x00019C9C File Offset: 0x00017E9C
		public unsafe static int SystemDefaultCharSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Marshal.NativeFieldInfoPtr_SystemDefaultCharSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marshal.NativeFieldInfoPtr_SystemDefaultCharSize, (void*)(&value));
			}
		}

		// Token: 0x040036EE RID: 14062
		private static readonly IntPtr NativeFieldInfoPtr_SystemMaxDBCSCharSize;

		// Token: 0x040036EF RID: 14063
		private static readonly IntPtr NativeFieldInfoPtr_SystemDefaultCharSize;

		// Token: 0x040036F0 RID: 14064
		private static readonly IntPtr NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0;

		// Token: 0x040036F1 RID: 14065
		private static readonly IntPtr NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x040036F2 RID: 14066
		private static readonly IntPtr NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0;

		// Token: 0x040036F3 RID: 14067
		private static readonly IntPtr NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0;

		// Token: 0x040036F4 RID: 14068
		private static readonly IntPtr NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0;

		// Token: 0x040036F5 RID: 14069
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0;

		// Token: 0x040036F6 RID: 14070
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x040036F7 RID: 14071
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040036F8 RID: 14072
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040036F9 RID: 14073
		private static readonly IntPtr NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0;

		// Token: 0x040036FA RID: 14074
		private static readonly IntPtr NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0;

		// Token: 0x040036FB RID: 14075
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0;

		// Token: 0x040036FC RID: 14076
		private static readonly IntPtr NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0;

		// Token: 0x040036FD RID: 14077
		private static readonly IntPtr NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0;

		// Token: 0x040036FE RID: 14078
		private static readonly IntPtr NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0;

		// Token: 0x040036FF RID: 14079
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0;

		// Token: 0x04003700 RID: 14080
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0;

		// Token: 0x04003701 RID: 14081
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0;

		// Token: 0x04003702 RID: 14082
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0;

		// Token: 0x04003703 RID: 14083
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0;

		// Token: 0x04003704 RID: 14084
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0;

		// Token: 0x04003705 RID: 14085
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_0;

		// Token: 0x04003706 RID: 14086
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_0;

		// Token: 0x04003707 RID: 14087
		private static readonly IntPtr NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04003708 RID: 14088
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0;

		// Token: 0x04003709 RID: 14089
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0;

		// Token: 0x0400370A RID: 14090
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0;

		// Token: 0x0400370B RID: 14091
		private static readonly IntPtr NativeMethodInfoPtr_SecureStringToCoTaskMemUnicode_Public_Static_IntPtr_SecureString_0;

		// Token: 0x0400370C RID: 14092
		private static readonly IntPtr NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0;

		// Token: 0x0400370D RID: 14093
		private static readonly IntPtr NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0;

		// Token: 0x0400370E RID: 14094
		private static readonly IntPtr NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0;

		// Token: 0x0400370F RID: 14095
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0;

		// Token: 0x04003710 RID: 14096
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04003711 RID: 14097
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0;

		// Token: 0x04003712 RID: 14098
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_0;

		// Token: 0x04003713 RID: 14099
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int64_0;

		// Token: 0x04003714 RID: 14100
		private static readonly IntPtr NativeMethodInfoPtr_WriteIntPtr_Public_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x04003715 RID: 14101
		private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0;

		// Token: 0x04003716 RID: 14102
		private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0;

		// Token: 0x02000645 RID: 1605
		private sealed class MethodInfoStoreGeneric_PtrToStructure_Public_Static_T_IntPtr_0<T>
		{
			// Token: 0x0400442C RID: 17452
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000646 RID: 1606
		private sealed class MethodInfoStoreGeneric_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0<T>
		{
			// Token: 0x0400442D RID: 17453
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000647 RID: 1607
		private sealed class MethodInfoStoreGeneric_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x0400442E RID: 17454
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000648 RID: 1608
		private sealed class MethodInfoStoreGeneric_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0<TDelegate>
		{
			// Token: 0x0400442F RID: 17455
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) }))));
		}
	}
}
