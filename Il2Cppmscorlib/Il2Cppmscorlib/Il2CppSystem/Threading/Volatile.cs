using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000294 RID: 660
	public static class Volatile : Object
	{
		// Token: 0x06002CF7 RID: 11511 RVA: 0x000E3F7C File Offset: 0x000E217C
		// Note: this type is marked as 'beforefieldinit'.
		static Volatile()
		{
			Il2CppClassPointerStore<Volatile>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Volatile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volatile>.NativeClassPtr);
			Volatile.NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100670387);
			Volatile.NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100670388);
			Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100670389);
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x000E3FE8 File Offset: 0x000E21E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334086, XrefRangeEnd = 334087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Read(ref bool location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volatile.NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x000E4028 File Offset: 0x000E2228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334087, XrefRangeEnd = 334088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Read<T>(ref T location) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(location);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Volatile.MethodInfoStoreGeneric_Read_Public_Static_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				location = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000E4080 File Offset: 0x000E2280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334088, XrefRangeEnd = 334089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write<T>(ref T location, T value) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Volatile.MethodInfoStoreGeneric_Write_Public_Static_Void_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			location = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x0000FD4B File Offset: 0x0000DF4B
		public Volatile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040026EA RID: 9962
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0;

		// Token: 0x040026EB RID: 9963
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0;

		// Token: 0x040026EC RID: 9964
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0;

		// Token: 0x020005F8 RID: 1528
		private sealed class MethodInfoStoreGeneric_Read_Public_Static_T_byref_T_0<T>
		{
			// Token: 0x04004307 RID: 17159
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Volatile.NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0, Il2CppClassPointerStore<Volatile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005F9 RID: 1529
		private sealed class MethodInfoStoreGeneric_Write_Public_Static_Void_byref_T_T_0<T>
		{
			// Token: 0x04004308 RID: 17160
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0, Il2CppClassPointerStore<Volatile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
