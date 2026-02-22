using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C1 RID: 1217
	public sealed class ConcurrentSet<KeyType, ItemType> : ValueType where ItemType : ConcurrentSetItem<KeyType, ItemType>
	{
		// Token: 0x0600479D RID: 18333 RVA: 0x00148E14 File Offset: 0x00147014
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentSet()
		{
			Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ConcurrentSet`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<KeyType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ItemType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr);
			ConcurrentSet<KeyType, ItemType>.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr, "items");
			ConcurrentSet<KeyType, ItemType>.NativeMethodInfoPtr_TryGet_Public_ItemType_KeyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr, 100673909);
			ConcurrentSet<KeyType, ItemType>.NativeMethodInfoPtr_GetOrAdd_Public_ItemType_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr, 100673910);
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x00148ED0 File Offset: 0x001470D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365969, RefRangeEnd = 365970, XrefRangeStart = 365968, XrefRangeEnd = 365969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemType TryGet(KeyType key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(KeyType).IsValueType)
				{
					KeyType keyType = key;
					intPtr = ((keyType is string) ? IL2CPP.ManagedStringToIl2Cpp(keyType as string) : IL2CPP.Il2CppObjectBaseToPtr(keyType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentSet<KeyType, ItemType>.NativeMethodInfoPtr_TryGet_Public_ItemType_KeyType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<ItemType>(intPtr2, false, true);
			}
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x00148F58 File Offset: 0x00147158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365982, RefRangeEnd = 365983, XrefRangeStart = 365970, XrefRangeEnd = 365982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemType GetOrAdd(ItemType newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(ItemType).IsValueType)
				{
					ItemType itemType = newItem;
					intPtr = ((itemType is string) ? IL2CPP.ManagedStringToIl2Cpp(itemType as string) : IL2CPP.Il2CppObjectBaseToPtr(itemType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newItem;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentSet<KeyType, ItemType>.NativeMethodInfoPtr_GetOrAdd_Public_ItemType_ItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<ItemType>(intPtr2, false, true);
			}
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x0001B106 File Offset: 0x00019306
		public ConcurrentSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x0001B10F File Offset: 0x0001930F
		public ConcurrentSet()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr))
		{
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060047A2 RID: 18338 RVA: 0x00148FE0 File Offset: 0x001471E0
		// (set) Token: 0x060047A3 RID: 18339 RVA: 0x0001B121 File Offset: 0x00019321
		public unsafe Il2CppArrayBase<ItemType> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentSet<KeyType, ItemType>.NativeFieldInfoPtr_items);
				return Il2CppArrayBase<ItemType>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentSet<KeyType, ItemType>.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A01 RID: 14849
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04003A02 RID: 14850
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_ItemType_KeyType_0;

		// Token: 0x04003A03 RID: 14851
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_ItemType_ItemType_0;
	}
}
