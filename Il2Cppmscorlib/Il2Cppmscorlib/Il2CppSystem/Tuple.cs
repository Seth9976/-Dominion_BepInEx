using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000057 RID: 87
	public static class Tuple : Object
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x0003C8CC File Offset: 0x0003AACC
		// Note: this type is marked as 'beforefieldinit'.
		static Tuple()
		{
			Il2CppClassPointerStore<Tuple>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Tuple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tuple>.NativeClassPtr);
			Tuple.NativeMethodInfoPtr_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100664261);
			Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100664262);
			Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100664263);
			Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100664264);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0003C94C File Offset: 0x0003AB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274705, RefRangeEnd = 274706, XrefRangeStart = 274703, XrefRangeEnd = 274705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = item1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = item2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref item2;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Tuple.MethodInfoStoreGeneric_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0<T1, T2>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Tuple<T1, T2>>(intPtr5) : null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0003CA10 File Offset: 0x0003AC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269034, RefRangeEnd = 269035, XrefRangeStart = 269034, XrefRangeEnd = 269035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0003CA5C File Offset: 0x0003AC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274706, RefRangeEnd = 274707, XrefRangeStart = 274706, XrefRangeEnd = 274706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2, int h3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0003CAB8 File Offset: 0x0003ACB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274707, RefRangeEnd = 274708, XrefRangeStart = 274707, XrefRangeEnd = 274707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00003F2E File Offset: 0x0000212E
		public Tuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x0200058A RID: 1418
		private sealed class MethodInfoStoreGeneric_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0<T1, T2>
		{
			// Token: 0x04003F96 RID: 16278
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tuple.NativeMethodInfoPtr_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0, Il2CppClassPointerStore<Tuple>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}
	}
}
