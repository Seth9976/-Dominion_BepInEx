using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000040 RID: 64
	public static class SetPropertyUtility : global::Il2CppSystem.Object
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x00023900 File Offset: 0x00021B00
		// Note: this type is marked as 'beforefieldinit'.
		static SetPropertyUtility()
		{
			Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "SetPropertyUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr);
			SetPropertyUtility.NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664102);
			SetPropertyUtility.NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664103);
			SetPropertyUtility.NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664104);
			SetPropertyUtility.NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664105);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00023980 File Offset: 0x00021B80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 118369, RefRangeEnd = 118374, XrefRangeStart = 118369, XrefRangeEnd = 118374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetColor(ref Color currentValue, Color newValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000239CC File Offset: 0x00021BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142915, XrefRangeEnd = 142917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEquatableStruct<T>(ref T currentValue, T newValue)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00023A70 File Offset: 0x00021C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142920, RefRangeEnd = 142921, XrefRangeStart = 142917, XrefRangeEnd = 142920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetStruct<T>(ref T currentValue, T newValue) where T : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00023B14 File Offset: 0x00021D14
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 118382, RefRangeEnd = 118410, XrefRangeStart = 118382, XrefRangeEnd = 118410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000059A0 File Offset: 0x00003BA0
		public SetPropertyUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x0200009A RID: 154
		private sealed class MethodInfoStoreGeneric_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C3A RID: 3130
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009B RID: 155
		private sealed class MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C3B RID: 3131
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009C RID: 156
		private sealed class MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C3C RID: 3132
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
