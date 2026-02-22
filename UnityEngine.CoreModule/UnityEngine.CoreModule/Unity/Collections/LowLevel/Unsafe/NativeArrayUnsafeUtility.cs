using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002B RID: 43
	public static class NativeArrayUnsafeUtility : Object
	{
		// Token: 0x06000113 RID: 275 RVA: 0x000197C0 File Offset: 0x000179C0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayUnsafeUtility()
		{
			Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeArrayUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663345);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663346);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00019818 File Offset: 0x00017A18
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 59091, RefRangeEnd = 59099, XrefRangeStart = 59091, XrefRangeEnd = 59091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dataPointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>(intPtr);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001986C File Offset: 0x00017A6C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 59099, RefRangeEnd = 59118, XrefRangeStart = 59099, XrefRangeEnd = 59099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeArray<T> nativeArray) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002CC1 File Offset: 0x00000EC1
		public NativeArrayUnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000198A8 File Offset: 0x00017AA8
		public static void CheckConvertArguments<T>(int length, Allocator allocator) where T : struct
		{
			bool flag = length < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("length", "Length must be >= 0");
			}
			NativeArray<T>.IsUnmanagedAndThrow();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000198D4 File Offset: 0x00017AD4
		public unsafe static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) where T : struct
		{
			return nativeArray.m_Buffer;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000198EC File Offset: 0x00017AEC
		public unsafe static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) where T : struct
		{
			return nativeArray.m_Buffer;
		}

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0;

		// Token: 0x020002FB RID: 763
		private sealed class MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>
		{
			// Token: 0x04001C1E RID: 7198
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002FC RID: 764
		private sealed class MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04001C1F RID: 7199
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
