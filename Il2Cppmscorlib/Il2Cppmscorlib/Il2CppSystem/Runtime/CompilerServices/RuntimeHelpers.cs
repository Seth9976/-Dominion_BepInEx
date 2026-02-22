using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000439 RID: 1081
	public static class RuntimeHelpers : Object
	{
		// Token: 0x0600427D RID: 17021 RVA: 0x00131F6C File Offset: 0x0013016C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeHelpers()
		{
			Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr);
			RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100672955);
			RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100672956);
			RuntimeHelpers.NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100672957);
			RuntimeHelpers.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100672958);
			RuntimeHelpers.NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100672959);
			RuntimeHelpers.NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100672960);
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x00132014 File Offset: 0x00130214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357191, XrefRangeEnd = 357192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeArray(Array array, IntPtr fldHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fldHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x00132058 File Offset: 0x00130258
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 357200, RefRangeEnd = 357276, XrefRangeStart = 357192, XrefRangeEnd = 357200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fldHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06004280 RID: 17024 RVA: 0x0013209C File Offset: 0x0013029C
		public unsafe static int OffsetToStringData
		{
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 357277, RefRangeEnd = 357420, XrefRangeStart = 357276, XrefRangeEnd = 357277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x001320CC File Offset: 0x001302CC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x00132110 File Offset: 0x00130310
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareConstrainedRegions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00132138 File Offset: 0x00130338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357420, XrefRangeEnd = 357426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsReferenceOrContainsReferences<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.MethodInfoStoreGeneric_IsReferenceOrContainsReferences_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x000196DD File Offset: 0x000178DD
		public RuntimeHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003608 RID: 13832
		private static readonly IntPtr NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0;

		// Token: 0x04003609 RID: 13833
		private static readonly IntPtr NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0;

		// Token: 0x0400360A RID: 13834
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0;

		// Token: 0x0400360B RID: 13835
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0;

		// Token: 0x0400360C RID: 13836
		private static readonly IntPtr NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0;

		// Token: 0x0400360D RID: 13837
		private static readonly IntPtr NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0;

		// Token: 0x02000644 RID: 1604
		private sealed class MethodInfoStoreGeneric_IsReferenceOrContainsReferences_Public_Static_Boolean_0<T>
		{
			// Token: 0x0400442B RID: 17451
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeHelpers.NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0, Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
