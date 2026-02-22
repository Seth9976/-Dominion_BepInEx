using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048A RID: 1162
	public static class CollectionExtensions : Object
	{
		// Token: 0x060045B5 RID: 17845 RVA: 0x0013F19C File Offset: 0x0013D39C
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionExtensions()
		{
			Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "CollectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr);
			CollectionExtensions.NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100673576);
			CollectionExtensions.NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100673577);
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x0013F1F4 File Offset: 0x0013D3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361542, RefRangeEnd = 361543, XrefRangeStart = 361542, XrefRangeEnd = 361542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x0013F27C File Offset: 0x0013D47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361543, XrefRangeEnd = 361545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = defaultValue;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref defaultValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr3, false, true);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x0001A908 File Offset: 0x00018B08
		public CollectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038B0 RID: 14512
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0;

		// Token: 0x040038B1 RID: 14513
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0;

		// Token: 0x02000663 RID: 1635
		private sealed class MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0<TKey, TValue>
		{
			// Token: 0x04004512 RID: 17682
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000664 RID: 1636
		private sealed class MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x04004513 RID: 17683
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}
}
