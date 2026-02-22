using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000470 RID: 1136
	[Serializable]
	public class CollectionBase : Object
	{
		// Token: 0x060043ED RID: 17389 RVA: 0x00136B08 File Offset: 0x00134D08
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionBase()
		{
			Il2CppClassPointerStore<CollectionBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "CollectionBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr);
			CollectionBase.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, "list");
			CollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673149);
			CollectionBase.NativeMethodInfoPtr_get_InnerList_Protected_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673150);
			CollectionBase.NativeMethodInfoPtr_get_List_Protected_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673151);
			CollectionBase.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673152);
			CollectionBase.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673153);
			CollectionBase.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673154);
			CollectionBase.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673155);
			CollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673156);
			CollectionBase.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673157);
			CollectionBase.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673158);
			CollectionBase.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673159);
			CollectionBase.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673160);
			CollectionBase.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673161);
			CollectionBase.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673162);
			CollectionBase.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673163);
			CollectionBase.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673164);
			CollectionBase.NativeMethodInfoPtr_OnSet_Protected_Virtual_New_Void_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673165);
			CollectionBase.NativeMethodInfoPtr_OnInsert_Protected_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673166);
			CollectionBase.NativeMethodInfoPtr_OnClear_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673167);
			CollectionBase.NativeMethodInfoPtr_OnRemove_Protected_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673168);
			CollectionBase.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673169);
			CollectionBase.NativeMethodInfoPtr_OnSetComplete_Protected_Virtual_New_Void_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673170);
			CollectionBase.NativeMethodInfoPtr_OnInsertComplete_Protected_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673171);
			CollectionBase.NativeMethodInfoPtr_OnClearComplete_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673172);
			CollectionBase.NativeMethodInfoPtr_OnRemoveComplete_Protected_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr, 100673173);
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00136D40 File Offset: 0x00134F40
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 359446, RefRangeEnd = 359460, XrefRangeStart = 359441, XrefRangeEnd = 359446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x00136D7C File Offset: 0x00134F7C
		public unsafe ArrayList InnerList
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 359464, RefRangeEnd = 359492, XrefRangeStart = 359460, XrefRangeEnd = 359464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_get_InnerList_Protected_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060043F0 RID: 17392 RVA: 0x00136DBC File Offset: 0x00134FBC
		public unsafe IList List
		{
			[CallerCount(734)]
			[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_get_List_Protected_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x00136DFC File Offset: 0x00134FFC
		public unsafe virtual int Count
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 359492, RefRangeEnd = 359498, XrefRangeStart = 359492, XrefRangeEnd = 359492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00136E38 File Offset: 0x00135038
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 359503, RefRangeEnd = 359506, XrefRangeStart = 359498, XrefRangeEnd = 359503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00136E6C File Offset: 0x0013506C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359506, XrefRangeEnd = 359508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x00136EAC File Offset: 0x001350AC
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359508, XrefRangeEnd = 359513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00136EE8 File Offset: 0x001350E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359513, XrefRangeEnd = 359518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x060043F6 RID: 17398 RVA: 0x00136F38 File Offset: 0x00135138
		// (set) Token: 0x060043F7 RID: 17399 RVA: 0x00136F84 File Offset: 0x00135184
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359518, XrefRangeEnd = 359528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359528, XrefRangeEnd = 359530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00136FD4 File Offset: 0x001351D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359530, XrefRangeEnd = 359535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x00137024 File Offset: 0x00135224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359535, XrefRangeEnd = 359543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x00137074 File Offset: 0x00135274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359543, XrefRangeEnd = 359551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x001370B8 File Offset: 0x001352B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359551, XrefRangeEnd = 359556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x00137108 File Offset: 0x00135308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359556, XrefRangeEnd = 359557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x00137158 File Offset: 0x00135358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359557, XrefRangeEnd = 359562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionBase.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00137198 File Offset: 0x00135398
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSet(int index, Object oldValue, Object newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnSet_Protected_Virtual_New_Void_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00137208 File Offset: 0x00135408
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInsert(int index, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnInsert_Protected_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x00137264 File Offset: 0x00135464
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnClear_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x001372A0 File Offset: 0x001354A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemove(int index, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnRemove_Protected_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x001372FC File Offset: 0x001354FC
		[CallerCount(0)]
		public unsafe virtual void OnValidate(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x0013734C File Offset: 0x0013554C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSetComplete(int index, Object oldValue, Object newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnSetComplete_Protected_Virtual_New_Void_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x001373BC File Offset: 0x001355BC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInsertComplete(int index, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnInsertComplete_Protected_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x00137418 File Offset: 0x00135618
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClearComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnClearComplete_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x00137454 File Offset: 0x00135654
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemoveComplete(int index, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionBase.NativeMethodInfoPtr_OnRemoveComplete_Protected_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x0001A164 File Offset: 0x00018364
		public CollectionBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x001374B0 File Offset: 0x001356B0
		// (set) Token: 0x06004409 RID: 17417 RVA: 0x0001A16D File Offset: 0x0001836D
		public unsafe ArrayList list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionBase.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionBase.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003758 RID: 14168
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x04003759 RID: 14169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400375A RID: 14170
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerList_Protected_get_ArrayList_0;

		// Token: 0x0400375B RID: 14171
		private static readonly IntPtr NativeMethodInfoPtr_get_List_Protected_get_IList_0;

		// Token: 0x0400375C RID: 14172
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400375D RID: 14173
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400375E RID: 14174
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x0400375F RID: 14175
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003760 RID: 14176
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003761 RID: 14177
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x04003762 RID: 14178
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x04003763 RID: 14179
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04003764 RID: 14180
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04003765 RID: 14181
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04003766 RID: 14182
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04003767 RID: 14183
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x04003768 RID: 14184
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003769 RID: 14185
		private static readonly IntPtr NativeMethodInfoPtr_OnSet_Protected_Virtual_New_Void_Int32_Object_Object_0;

		// Token: 0x0400376A RID: 14186
		private static readonly IntPtr NativeMethodInfoPtr_OnInsert_Protected_Virtual_New_Void_Int32_Object_0;

		// Token: 0x0400376B RID: 14187
		private static readonly IntPtr NativeMethodInfoPtr_OnClear_Protected_Virtual_New_Void_0;

		// Token: 0x0400376C RID: 14188
		private static readonly IntPtr NativeMethodInfoPtr_OnRemove_Protected_Virtual_New_Void_Int32_Object_0;

		// Token: 0x0400376D RID: 14189
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_Object_0;

		// Token: 0x0400376E RID: 14190
		private static readonly IntPtr NativeMethodInfoPtr_OnSetComplete_Protected_Virtual_New_Void_Int32_Object_Object_0;

		// Token: 0x0400376F RID: 14191
		private static readonly IntPtr NativeMethodInfoPtr_OnInsertComplete_Protected_Virtual_New_Void_Int32_Object_0;

		// Token: 0x04003770 RID: 14192
		private static readonly IntPtr NativeMethodInfoPtr_OnClearComplete_Protected_Virtual_New_Void_0;

		// Token: 0x04003771 RID: 14193
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoveComplete_Protected_Virtual_New_Void_Int32_Object_0;
	}
}
