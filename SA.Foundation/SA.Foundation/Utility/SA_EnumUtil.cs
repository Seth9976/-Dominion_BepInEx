using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace SA.Foundation.Utility
{
	// Token: 0x02000012 RID: 18
	public static class SA_EnumUtil : Object
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00005694 File Offset: 0x00003894
		// Note: this type is marked as 'beforefieldinit'.
		static SA_EnumUtil()
		{
			Il2CppClassPointerStore<SA_EnumUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_EnumUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_EnumUtil>.NativeClassPtr);
			SA_EnumUtil.NativeMethodInfoPtr_CanBeParsedToEnum_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EnumUtil>.NativeClassPtr, 100663376);
			SA_EnumUtil.NativeMethodInfoPtr_TryParseEnum_Public_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EnumUtil>.NativeClassPtr, 100663377);
			SA_EnumUtil.NativeMethodInfoPtr_ParseEnum_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EnumUtil>.NativeClassPtr, 100663378);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005700 File Offset: 0x00003900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98711, XrefRangeEnd = 98720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeParsedToEnum<T>(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EnumUtil.MethodInfoStoreGeneric_CanBeParsedToEnum_Public_Static_Boolean_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005744 File Offset: 0x00003944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98720, XrefRangeEnd = 98734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseEnum<T>(string value, out T result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref result;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SA_EnumUtil.MethodInfoStoreGeneric_TryParseEnum_Public_Static_Boolean_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000057D4 File Offset: 0x000039D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98734, XrefRangeEnd = 98753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ParseEnum<T>(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EnumUtil.MethodInfoStoreGeneric_ParseEnum_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000219E File Offset: 0x0000039E
		public SA_EnumUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_CanBeParsedToEnum_Public_Static_Boolean_String_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_TryParseEnum_Public_Static_Boolean_String_byref_T_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_ParseEnum_Public_Static_T_String_0;

		// Token: 0x02000047 RID: 71
		private sealed class MethodInfoStoreGeneric_CanBeParsedToEnum_Public_Static_Boolean_String_0<T>
		{
			// Token: 0x040002E7 RID: 743
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_EnumUtil.NativeMethodInfoPtr_CanBeParsedToEnum_Public_Static_Boolean_String_0, Il2CppClassPointerStore<SA_EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000048 RID: 72
		private sealed class MethodInfoStoreGeneric_TryParseEnum_Public_Static_Boolean_String_byref_T_0<T>
		{
			// Token: 0x040002E8 RID: 744
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_EnumUtil.NativeMethodInfoPtr_TryParseEnum_Public_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<SA_EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000049 RID: 73
		private sealed class MethodInfoStoreGeneric_ParseEnum_Public_Static_T_String_0<T>
		{
			// Token: 0x040002E9 RID: 745
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_EnumUtil.NativeMethodInfoPtr_ParseEnum_Public_Static_T_String_0, Il2CppClassPointerStore<SA_EnumUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
