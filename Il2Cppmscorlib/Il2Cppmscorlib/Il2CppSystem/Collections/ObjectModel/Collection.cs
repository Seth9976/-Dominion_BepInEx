using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Collections.ObjectModel
{
	// Token: 0x02000485 RID: 1157
	[Serializable]
	public class Collection<T> : Object
	{
		// Token: 0x06004535 RID: 17717 RVA: 0x0013C090 File Offset: 0x0013A290
		// Note: this type is marked as 'beforefieldinit'.
		static Collection()
		{
			Il2CppClassPointerStore<Collection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.ObjectModel", "Collection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr);
			Collection<T>.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, "items");
			Collection<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673457);
			Collection<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673458);
			Collection<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673459);
			Collection<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673460);
			Collection<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673461);
			Collection<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673462);
			Collection<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673463);
			Collection<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673464);
			Collection<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673465);
			Collection<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673466);
			Collection<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673467);
			Collection<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673468);
			Collection<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673469);
			Collection<T>.NativeMethodInfoPtr_ClearItems_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673470);
			Collection<T>.NativeMethodInfoPtr_InsertItem_Protected_Virtual_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673471);
			Collection<T>.NativeMethodInfoPtr_RemoveItem_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673472);
			Collection<T>.NativeMethodInfoPtr_SetItem_Protected_Virtual_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673473);
			Collection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673474);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673475);
			Collection<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673476);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673477);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673478);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673479);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673480);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673481);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673482);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673483);
			Collection<T>.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673484);
			Collection<T>.NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673485);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x0013C354 File Offset: 0x0013A554
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 336363, RefRangeEnd = 336375, XrefRangeStart = 336363, XrefRangeEnd = 336375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x0013C390 File Offset: 0x0013A590
		public unsafe virtual int Count
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 360869, RefRangeEnd = 360874, XrefRangeStart = 360854, XrefRangeEnd = 360869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011A5 RID: 4517
		public unsafe virtual T this[int index]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 360877, RefRangeEnd = 360879, XrefRangeStart = 360874, XrefRangeEnd = 360877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360879, XrefRangeEnd = 360886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x0013C49C File Offset: 0x0013A69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360886, XrefRangeEnd = 360892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x0013C514 File Offset: 0x0013A714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360892, XrefRangeEnd = 360896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x0013C548 File Offset: 0x0013A748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360896, XrefRangeEnd = 360898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x0013C598 File Offset: 0x0013A798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360898, XrefRangeEnd = 360902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x0013C61C File Offset: 0x0013A81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360902, XrefRangeEnd = 360905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x0013C65C File Offset: 0x0013A85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360905, XrefRangeEnd = 360908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x0013C6E0 File Offset: 0x0013A8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360908, XrefRangeEnd = 360915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Insert(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x0013C768 File Offset: 0x0013A968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360915, XrefRangeEnd = 360920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x0013C7EC File Offset: 0x0013A9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360920, XrefRangeEnd = 360927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x0013C82C File Offset: 0x0013AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360927, XrefRangeEnd = 360930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Collection<T>.NativeMethodInfoPtr_ClearItems_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x0013C868 File Offset: 0x0013AA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360930, XrefRangeEnd = 360932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItem(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Collection<T>.NativeMethodInfoPtr_InsertItem_Protected_Virtual_New_Void_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x0013C8FC File Offset: 0x0013AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360932, XrefRangeEnd = 360936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Collection<T>.NativeMethodInfoPtr_RemoveItem_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x0013C948 File Offset: 0x0013AB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360936, XrefRangeEnd = 360938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItem(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Collection<T>.NativeMethodInfoPtr_SetItem_Protected_Virtual_New_Void_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x0013C9DC File Offset: 0x0013ABDC
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360938, XrefRangeEnd = 360941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x0013CA18 File Offset: 0x0013AC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360941, XrefRangeEnd = 360945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x0013CA58 File Offset: 0x0013AC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360945, XrefRangeEnd = 360974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x0013CAA8 File Offset: 0x0013ACA8
		// (set) Token: 0x0600454B RID: 17739 RVA: 0x0013CAF4 File Offset: 0x0013ACF4
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 360877, RefRangeEnd = 360879, XrefRangeStart = 360877, XrefRangeEnd = 360879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360974, XrefRangeEnd = 360984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600454C RID: 17740 RVA: 0x0013CB44 File Offset: 0x0013AD44
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x0013CB80 File Offset: 0x0013AD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360984, XrefRangeEnd = 360997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x0013CBD0 File Offset: 0x0013ADD0
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x0013CC20 File Offset: 0x0013AE20
		[CallerCount(0)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x0013CC70 File Offset: 0x0013AE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360997, XrefRangeEnd = 361010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x0013CCC0 File Offset: 0x0013AEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361010, XrefRangeEnd = 361016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x0013CD04 File Offset: 0x0013AF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361016, XrefRangeEnd = 361019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleObject(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x0001A809 File Offset: 0x00018A09
		public Collection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x0013CD48 File Offset: 0x0013AF48
		// (set) Token: 0x06004555 RID: 17749 RVA: 0x0001A812 File Offset: 0x00018A12
		public unsafe IList<T> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collection<T>.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collection<T>.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003842 RID: 14402
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04003843 RID: 14403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003844 RID: 14404
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003845 RID: 14405
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x04003846 RID: 14406
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0;

		// Token: 0x04003847 RID: 14407
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04003848 RID: 14408
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003849 RID: 14409
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400384A RID: 14410
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x0400384B RID: 14411
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x0400384C RID: 14412
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0;

		// Token: 0x0400384D RID: 14413
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0;

		// Token: 0x0400384E RID: 14414
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x0400384F RID: 14415
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04003850 RID: 14416
		private static readonly IntPtr NativeMethodInfoPtr_ClearItems_Protected_Virtual_New_Void_0;

		// Token: 0x04003851 RID: 14417
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Protected_Virtual_New_Void_Int32_T_0;

		// Token: 0x04003852 RID: 14418
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04003853 RID: 14419
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Protected_Virtual_New_Void_Int32_T_0;

		// Token: 0x04003854 RID: 14420
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003855 RID: 14421
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003856 RID: 14422
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003857 RID: 14423
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x04003858 RID: 14424
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x04003859 RID: 14425
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400385A RID: 14426
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400385B RID: 14427
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400385C RID: 14428
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400385D RID: 14429
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x0400385E RID: 14430
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400385F RID: 14431
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0;
	}
}
