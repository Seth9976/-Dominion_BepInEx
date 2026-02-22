using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000040 RID: 64
	public class ObjectListPool<T> : Object
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00016370 File Offset: 0x00014570
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListPool()
		{
			Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ObjectListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr);
			ObjectListPool<T>.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr, "pool");
			ObjectListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr, 100663583);
			ObjectListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListPool<T>>.NativeClassPtr, 100663584);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00016418 File Offset: 0x00014618
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 81548, RefRangeEnd = 81590, XrefRangeStart = 81548, XrefRangeEnd = 81590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001644C File Offset: 0x0001464C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93098, RefRangeEnd = 93099, XrefRangeStart = 93075, XrefRangeEnd = 93098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<T> elements)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000038A1 File Offset: 0x00001AA1
		public ObjectListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00016484 File Offset: 0x00014684
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000038AA File Offset: 0x00001AAA
		public unsafe static ObjectPool<List<T>> pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectListPool<T>.NativeFieldInfoPtr_pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<List<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectListPool<T>.NativeFieldInfoPtr_pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_pool;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0;
	}
}
