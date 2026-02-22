using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UI
{
	// Token: 0x02000035 RID: 53
	public static class SetPropertyUtility : Object
	{
		// Token: 0x060006D0 RID: 1744 RVA: 0x00021590 File Offset: 0x0001F790
		// Note: this type is marked as 'beforefieldinit'.
		static SetPropertyUtility()
		{
			Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "SetPropertyUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr);
			SetPropertyUtility.NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664296);
			SetPropertyUtility.NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664297);
			SetPropertyUtility.NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664298);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000215FC File Offset: 0x0001F7FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 118369, RefRangeEnd = 118374, XrefRangeStart = 118369, XrefRangeEnd = 118369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060006D2 RID: 1746 RVA: 0x00021648 File Offset: 0x0001F848
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 118374, RefRangeEnd = 118382, XrefRangeStart = 118374, XrefRangeEnd = 118374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060006D3 RID: 1747 RVA: 0x000216EC File Offset: 0x0001F8EC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 118382, RefRangeEnd = 118410, XrefRangeStart = 118382, XrefRangeEnd = 118382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060006D4 RID: 1748 RVA: 0x000045F1 File Offset: 0x000027F1
		public SetPropertyUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x020000AC RID: 172
		private sealed class MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x040009B9 RID: 2489
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AD RID: 173
		private sealed class MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x040009BA RID: 2490
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
