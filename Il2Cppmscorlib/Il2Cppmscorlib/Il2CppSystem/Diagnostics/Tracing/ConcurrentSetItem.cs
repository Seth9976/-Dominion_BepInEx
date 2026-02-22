using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C2 RID: 1218
	public class ConcurrentSetItem<KeyType, ItemType> : Object where ItemType : ConcurrentSetItem<KeyType, ItemType>
	{
		// Token: 0x060047A4 RID: 18340 RVA: 0x00149008 File Offset: 0x00147208
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentSetItem()
		{
			Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ConcurrentSetItem`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<KeyType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ItemType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr);
			ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr, 100673911);
			ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_KeyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr, 100673912);
			ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr, 100673913);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x001490C4 File Offset: 0x001472C4
		[CallerCount(0)]
		public unsafe virtual int Compare(ItemType other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(ItemType).IsValueType)
				{
					ItemType itemType = other;
					intPtr = ((itemType is string) ? IL2CPP.ManagedStringToIl2Cpp(itemType as string) : IL2CPP.Il2CppObjectBaseToPtr(itemType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref other;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_ItemType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x00149154 File Offset: 0x00147354
		[CallerCount(0)]
		public unsafe virtual int Compare(KeyType key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_KeyType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x001491E4 File Offset: 0x001473E4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentSetItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x0001B140 File Offset: 0x00019340
		public ConcurrentSetItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003A04 RID: 14852
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_ItemType_0;

		// Token: 0x04003A05 RID: 14853
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_KeyType_0;

		// Token: 0x04003A06 RID: 14854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
