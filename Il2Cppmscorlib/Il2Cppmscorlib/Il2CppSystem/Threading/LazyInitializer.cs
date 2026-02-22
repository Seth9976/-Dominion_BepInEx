using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025E RID: 606
	public static class LazyInitializer : Object
	{
		// Token: 0x06002A15 RID: 10773 RVA: 0x000D9B80 File Offset: 0x000D7D80
		// Note: this type is marked as 'beforefieldinit'.
		static LazyInitializer()
		{
			Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LazyInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100669990);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100669991);
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000D9BD8 File Offset: 0x000D7DD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330578, RefRangeEnd = 330580, XrefRangeStart = 330576, XrefRangeEnd = 330578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			target = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000D9C44 File Offset: 0x000D7E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330580, XrefRangeEnd = 330581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			target = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x0000EB1E File Offset: 0x0000CD1E
		public LazyInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0;

		// Token: 0x040024F1 RID: 9457
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0;

		// Token: 0x020005E5 RID: 1509
		private sealed class MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0<T>
		{
			// Token: 0x040042AB RID: 17067
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005E6 RID: 1510
		private sealed class MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0<T>
		{
			// Token: 0x040042AC RID: 17068
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
