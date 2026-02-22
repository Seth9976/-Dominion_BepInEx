using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Pool
{
	// Token: 0x02000127 RID: 295
	public class CollectionPool<TCollection, TItem> : Object where TCollection : class, new()
	{
		// Token: 0x0600172F RID: 5935 RVA: 0x00057328 File Offset: 0x00055528
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionPool()
		{
			Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "CollectionPool`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr);
			CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, "s_Pool");
			CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100665023);
			CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100665024);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000573E4 File Offset: 0x000555E4
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 81548, RefRangeEnd = 81590, XrefRangeStart = 81535, XrefRangeEnd = 81548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TCollection Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_TCollection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TCollection>(intPtr, false, true);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00057414 File Offset: 0x00055614
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 81639, RefRangeEnd = 81680, XrefRangeStart = 81590, XrefRangeEnd = 81639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(TCollection toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TCollection).IsValueType)
				{
					TCollection tcollection = toRelease;
					intPtr = ((tcollection is string) ? IL2CPP.ManagedStringToIl2Cpp(tcollection as string) : IL2CPP.Il2CppObjectBaseToPtr(tcollection as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref toRelease;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0000D0A0 File Offset: 0x0000B2A0
		public CollectionPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00057480 File Offset: 0x00055680
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x0000D0A9 File Offset: 0x0000B2A9
		public unsafe static ObjectPool<TCollection> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<TCollection>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_TCollection_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0;

		// Token: 0x02000958 RID: 2392
		[ObfuscatedName("UnityEngine.Pool.CollectionPool`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060030B1 RID: 12465 RVA: 0x0006DA98 File Offset: 0x0006BC98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr);
				CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, "<>9");
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100665027);
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100665028);
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100665029);
			}

			// Token: 0x060030B2 RID: 12466 RVA: 0x0006DB60 File Offset: 0x0006BD60
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030B3 RID: 12467 RVA: 0x0006DB9C File Offset: 0x0006BD9C
			[CallerCount(0)]
			public unsafe TCollection __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TCollection>(intPtr, false, true);
			}

			// Token: 0x060030B4 RID: 12468 RVA: 0x0006DBD8 File Offset: 0x0006BDD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81528, XrefRangeEnd = 81535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__5_1(TCollection l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TCollection).IsValueType)
					{
						TCollection tcollection = l;
						intPtr = ((tcollection is string) ? IL2CPP.ManagedStringToIl2Cpp(tcollection as string) : IL2CPP.Il2CppObjectBaseToPtr(tcollection as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref l;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060030B5 RID: 12469 RVA: 0x00017593 File Offset: 0x00015793
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x060030B6 RID: 12470 RVA: 0x0006DC50 File Offset: 0x0006BE50
			// (set) Token: 0x060030B7 RID: 12471 RVA: 0x0001759C File Offset: 0x0001579C
			public unsafe static CollectionPool<TCollection, TItem>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionPool<TCollection, TItem>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D03 RID: 7427
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001D04 RID: 7428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D05 RID: 7429
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0;

			// Token: 0x04001D06 RID: 7430
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0;
		}
	}
}
