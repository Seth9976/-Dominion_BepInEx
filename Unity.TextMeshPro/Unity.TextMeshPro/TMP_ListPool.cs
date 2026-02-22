using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000043 RID: 67
	public static class TMP_ListPool<T> : Object
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00023E90 File Offset: 0x00022090
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ListPool()
		{
			Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr);
			TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, "s_ListPool");
			TMP_ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, 100664108);
			TMP_ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, 100664109);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00023F38 File Offset: 0x00022138
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 81548, RefRangeEnd = 81590, XrefRangeStart = 81548, XrefRangeEnd = 81590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00023F6C File Offset: 0x0002216C
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 81639, RefRangeEnd = 81680, XrefRangeStart = 81639, XrefRangeEnd = 81680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<T> toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000059C4 File Offset: 0x00003BC4
		public TMP_ListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00023FA4 File Offset: 0x000221A4
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x000059CD File Offset: 0x00003BCD
		public unsafe static TMP_ObjectPool<List<T>> s_ListPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ObjectPool<List<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_s_ListPool;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0;

		// Token: 0x0200009D RID: 157
		[ObfuscatedName("TMPro.TMP_ListPool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F7C RID: 3964 RVA: 0x0003D9C4 File Offset: 0x0003BBC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr);
				TMP_ListPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, "<>9");
				TMP_ListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, 100664876);
				TMP_ListPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, 100664877);
			}

			// Token: 0x06000F7D RID: 3965 RVA: 0x0003DA68 File Offset: 0x0003BC68
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F7E RID: 3966 RVA: 0x0003DAA4 File Offset: 0x0003BCA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142921, XrefRangeEnd = 142922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__3_0(List<T> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F7F RID: 3967 RVA: 0x00009588 File Offset: 0x00007788
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0003DAE8 File Offset: 0x0003BCE8
			// (set) Token: 0x06000F81 RID: 3969 RVA: 0x00009591 File Offset: 0x00007791
			public unsafe static TMP_ListPool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_ListPool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ListPool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_ListPool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C3D RID: 3133
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C3E RID: 3134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C3F RID: 3135
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0;
		}
	}
}
