using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x020000B8 RID: 184
	public sealed class NoAllocHelpers : Object
	{
		// Token: 0x060010DA RID: 4314 RVA: 0x00044DB8 File Offset: 0x00042FB8
		// Note: this type is marked as 'beforefieldinit'.
		static NoAllocHelpers()
		{
			Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "NoAllocHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr);
			NoAllocHelpers.NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100664442);
			NoAllocHelpers.NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100664443);
			NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100664444);
			NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100664445);
			NoAllocHelpers.NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100664446);
			NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100664447);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00044E60 File Offset: 0x00043060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72332, XrefRangeEnd = 72333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeList<T>(List<T> list, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_ResizeList_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00044EA4 File Offset: 0x000430A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72333, XrefRangeEnd = 72334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureListElemCount<T>(List<T> list, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00044EE8 File Offset: 0x000430E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72335, RefRangeEnd = 72337, XrefRangeStart = 72334, XrefRangeEnd = 72335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SafeLength(Array values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00044F2C File Offset: 0x0004312C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 72337, RefRangeEnd = 72347, XrefRangeStart = 72337, XrefRangeEnd = 72337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SafeLength<T>(List<T> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_SafeLength_Public_Static_Int32_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00044F70 File Offset: 0x00043170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72349, RefRangeEnd = 72350, XrefRangeStart = 72347, XrefRangeEnd = 72349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ResizeList(Object list, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00044FB4 File Offset: 0x000431B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72352, RefRangeEnd = 72355, XrefRangeStart = 72350, XrefRangeEnd = 72352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array ExtractArrayFromList(Object list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0000A442 File Offset: 0x00008642
		public NoAllocHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00044FF8 File Offset: 0x000431F8
		public static Il2CppArrayBase<T> ExtractArrayFromListT<T>(List<T> list)
		{
			return NoAllocHelpers.ExtractArrayFromList(list).Cast<Il2CppArrayBase<T>>();
		}

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0;

		// Token: 0x020007A0 RID: 1952
		private sealed class MethodInfoStoreGeneric_ResizeList_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x04001C9A RID: 7322
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007A1 RID: 1953
		private sealed class MethodInfoStoreGeneric_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x04001C9B RID: 7323
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007A2 RID: 1954
		private sealed class MethodInfoStoreGeneric_SafeLength_Public_Static_Int32_List_1_T_0<T>
		{
			// Token: 0x04001C9C RID: 7324
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
