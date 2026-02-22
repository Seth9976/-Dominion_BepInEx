using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200046D RID: 1133
	[Serializable]
	public class ArrayList : Object
	{
		// Token: 0x060043B5 RID: 17333 RVA: 0x00135AE8 File Offset: 0x00133CE8
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayList()
		{
			Il2CppClassPointerStore<ArrayList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "ArrayList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList>.NativeClassPtr);
			ArrayList.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_items");
			ArrayList.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_size");
			ArrayList.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_version");
			ArrayList.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_syncRoot");
			ArrayList.NativeFieldInfoPtr_emptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "emptyArray");
			ArrayList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673083);
			ArrayList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673084);
			ArrayList.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673085);
			ArrayList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673086);
			ArrayList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673087);
			ArrayList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673088);
			ArrayList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673089);
			ArrayList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673090);
			ArrayList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673091);
			ArrayList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673092);
			ArrayList.NativeMethodInfoPtr_AddRange_Public_Virtual_New_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673093);
			ArrayList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673094);
			ArrayList.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673095);
			ArrayList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673096);
			ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673097);
			ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673098);
			ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673099);
			ArrayList.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673100);
			ArrayList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673101);
			ArrayList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673102);
			ArrayList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673103);
			ArrayList.NativeMethodInfoPtr_InsertRange_Public_Virtual_New_Void_Int32_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673104);
			ArrayList.NativeMethodInfoPtr_ReadOnly_Public_Static_ArrayList_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673105);
			ArrayList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673106);
			ArrayList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673107);
			ArrayList.NativeMethodInfoPtr_RemoveRange_Public_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673108);
			ArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673109);
			ArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Array_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100673110);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x00135DAC File Offset: 0x00133FAC
		[CallerCount(134)]
		[CachedScanResults(RefRangeStart = 359023, RefRangeEnd = 359157, XrefRangeStart = 359018, XrefRangeEnd = 359023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00135DE8 File Offset: 0x00133FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359162, RefRangeEnd = 359164, XrefRangeStart = 359157, XrefRangeEnd = 359162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x00135E30 File Offset: 0x00134030
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 359175, RefRangeEnd = 359180, XrefRangeStart = 359164, XrefRangeEnd = 359175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList(ICollection c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001142 RID: 4418
		// (set) Token: 0x060043B9 RID: 17337 RVA: 0x00135E7C File Offset: 0x0013407C
		public unsafe virtual int Capacity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359180, XrefRangeEnd = 359183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x060043BA RID: 17338 RVA: 0x00135EC8 File Offset: 0x001340C8
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x060043BB RID: 17339 RVA: 0x00135F10 File Offset: 0x00134110
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060043BC RID: 17340 RVA: 0x00135F58 File Offset: 0x00134158
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359183, XrefRangeEnd = 359188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001146 RID: 4422
		public unsafe virtual Object this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359188, XrefRangeEnd = 359189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00136058 File Offset: 0x00134258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359189, XrefRangeEnd = 359191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x001360B0 File Offset: 0x001342B0
		[CallerCount(0)]
		public unsafe virtual void AddRange(ICollection c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_AddRange_Public_Virtual_New_Void_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00136100 File Offset: 0x00134300
		[CallerCount(129)]
		[CachedScanResults(RefRangeStart = 359192, RefRangeEnd = 359321, XrefRangeStart = 359191, XrefRangeEnd = 359192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x0013613C File Offset: 0x0013433C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359321, XrefRangeEnd = 359334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00136188 File Offset: 0x00134388
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x001361E0 File Offset: 0x001343E0
		[CallerCount(0)]
		public unsafe virtual void CopyTo(Array array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00136230 File Offset: 0x00134430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359334, XrefRangeEnd = 359336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x0013628C File Offset: 0x0013448C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359336, XrefRangeEnd = 359352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(int index, Array array, int arrayIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Int32_Array_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00136304 File Offset: 0x00134504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359353, RefRangeEnd = 359355, XrefRangeStart = 359352, XrefRangeEnd = 359353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureCapacity(int min)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00136344 File Offset: 0x00134544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359355, XrefRangeEnd = 359359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00136390 File Offset: 0x00134590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359359, XrefRangeEnd = 359360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x001363E8 File Offset: 0x001345E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359360, XrefRangeEnd = 359363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Insert(int index, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00136444 File Offset: 0x00134644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359363, XrefRangeEnd = 359374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertRange(int index, ICollection c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_InsertRange_Public_Virtual_New_Void_Int32_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x001364A0 File Offset: 0x001346A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359378, RefRangeEnd = 359380, XrefRangeStart = 359374, XrefRangeEnd = 359378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayList ReadOnly(ArrayList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_ReadOnly_Public_Static_ArrayList_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x001364E4 File Offset: 0x001346E4
		[CallerCount(0)]
		public unsafe virtual void Remove(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x00136534 File Offset: 0x00134734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359380, XrefRangeEnd = 359381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00136580 File Offset: 0x00134780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359381, XrefRangeEnd = 359382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveRange(int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_RemoveRange_Public_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x001365D8 File Offset: 0x001347D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359382, XrefRangeEnd = 359386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x00136624 File Offset: 0x00134824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359386, XrefRangeEnd = 359395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Array ToArray(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Array_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
			}
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x0001A085 File Offset: 0x00018285
		public ArrayList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x00136680 File Offset: 0x00134880
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x0001A08E File Offset: 0x0001828E
		public unsafe Il2CppReferenceArray<Object> _items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x001366B0 File Offset: 0x001348B0
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x0001A0AD File Offset: 0x000182AD
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x001366D8 File Offset: 0x001348D8
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x0001A0C8 File Offset: 0x000182C8
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00136700 File Offset: 0x00134900
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x0001A0E3 File Offset: 0x000182E3
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x00136730 File Offset: 0x00134930
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x0001A102 File Offset: 0x00018302
		public unsafe static Il2CppReferenceArray<Object> emptyArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArrayList.NativeFieldInfoPtr_emptyArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrayList.NativeFieldInfoPtr_emptyArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400372D RID: 14125
		private static readonly IntPtr NativeFieldInfoPtr__items;

		// Token: 0x0400372E RID: 14126
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x0400372F RID: 14127
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003730 RID: 14128
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003731 RID: 14129
		private static readonly IntPtr NativeFieldInfoPtr_emptyArray;

		// Token: 0x04003732 RID: 14130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003733 RID: 14131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003734 RID: 14132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

		// Token: 0x04003735 RID: 14133
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04003736 RID: 14134
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003737 RID: 14135
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003738 RID: 14136
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x04003739 RID: 14137
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0;

		// Token: 0x0400373A RID: 14138
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0;

		// Token: 0x0400373B RID: 14139
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0;

		// Token: 0x0400373C RID: 14140
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Virtual_New_Void_ICollection_0;

		// Token: 0x0400373D RID: 14141
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x0400373E RID: 14142
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x0400373F RID: 14143
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003740 RID: 14144
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_0;

		// Token: 0x04003741 RID: 14145
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003742 RID: 14146
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Int32_Array_Int32_Int32_0;

		// Token: 0x04003743 RID: 14147
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0;

		// Token: 0x04003744 RID: 14148
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04003745 RID: 14149
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0;

		// Token: 0x04003746 RID: 14150
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0;

		// Token: 0x04003747 RID: 14151
		private static readonly IntPtr NativeMethodInfoPtr_InsertRange_Public_Virtual_New_Void_Int32_ICollection_0;

		// Token: 0x04003748 RID: 14152
		private static readonly IntPtr NativeMethodInfoPtr_ReadOnly_Public_Static_ArrayList_ArrayList_0;

		// Token: 0x04003749 RID: 14153
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

		// Token: 0x0400374A RID: 14154
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0;

		// Token: 0x0400374B RID: 14155
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x0400374C RID: 14156
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400374D RID: 14157
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_New_Array_Type_0;

		// Token: 0x02000649 RID: 1609
		[Serializable]
		public class ReadOnlyArrayList : ArrayList
		{
			// Token: 0x060054CD RID: 21709 RVA: 0x00176DB0 File Offset: 0x00174FB0
			// Note: this type is marked as 'beforefieldinit'.
			static ReadOnlyArrayList()
			{
				Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "ReadOnlyArrayList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr);
				ArrayList.ReadOnlyArrayList.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, "_list");
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673112);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673113);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673114);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673115);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673116);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673117);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673118);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673119);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673120);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673121);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673122);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673123);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673124);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673125);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673126);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673127);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673128);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673129);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673130);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673131);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673132);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673133);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100673134);
			}

			// Token: 0x060054CE RID: 21710 RVA: 0x00176FBC File Offset: 0x001751BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 358902, RefRangeEnd = 358903, XrefRangeStart = 358898, XrefRangeEnd = 358902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyArrayList(ArrayList l)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170015B6 RID: 5558
			// (get) Token: 0x060054CF RID: 21711 RVA: 0x00177008 File Offset: 0x00175208
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358903, XrefRangeEnd = 358904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170015B7 RID: 5559
			// (get) Token: 0x060054D0 RID: 21712 RVA: 0x00177050 File Offset: 0x00175250
			public unsafe override bool IsReadOnly
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170015B8 RID: 5560
			public unsafe override Object this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358904, XrefRangeEnd = 358905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358905, XrefRangeEnd = 358912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170015B9 RID: 5561
			// (get) Token: 0x060054D3 RID: 21715 RVA: 0x0017714C File Offset: 0x0017534C
			public unsafe override Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358912, XrefRangeEnd = 358913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060054D4 RID: 21716 RVA: 0x00177198 File Offset: 0x00175398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358913, XrefRangeEnd = 358920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Add(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054D5 RID: 21717 RVA: 0x001771F0 File Offset: 0x001753F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358920, XrefRangeEnd = 358927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void AddRange(ICollection c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170015BA RID: 5562
			// (set) Token: 0x060054D6 RID: 21718 RVA: 0x00177240 File Offset: 0x00175440
			public unsafe override int Capacity
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358927, XrefRangeEnd = 358934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060054D7 RID: 21719 RVA: 0x0017728C File Offset: 0x0017548C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358934, XrefRangeEnd = 358941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054D8 RID: 21720 RVA: 0x001772C8 File Offset: 0x001754C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358941, XrefRangeEnd = 358950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060054D9 RID: 21721 RVA: 0x00177314 File Offset: 0x00175514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358950, XrefRangeEnd = 358951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054DA RID: 21722 RVA: 0x0017736C File Offset: 0x0017556C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358951, XrefRangeEnd = 358952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(Array array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054DB RID: 21723 RVA: 0x001773C8 File Offset: 0x001755C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358952, XrefRangeEnd = 358953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054DC RID: 21724 RVA: 0x00177440 File Offset: 0x00175640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358953, XrefRangeEnd = 358954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060054DD RID: 21725 RVA: 0x0017748C File Offset: 0x0017568C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358954, XrefRangeEnd = 358955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int IndexOf(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054DE RID: 21726 RVA: 0x001774E4 File Offset: 0x001756E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358955, XrefRangeEnd = 358962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Insert(int index, Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054DF RID: 21727 RVA: 0x00177540 File Offset: 0x00175740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358962, XrefRangeEnd = 358969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void InsertRange(int index, ICollection c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054E0 RID: 21728 RVA: 0x0017759C File Offset: 0x0017579C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358969, XrefRangeEnd = 358976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Remove(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054E1 RID: 21729 RVA: 0x001775EC File Offset: 0x001757EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358976, XrefRangeEnd = 358983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054E2 RID: 21730 RVA: 0x00177638 File Offset: 0x00175838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358983, XrefRangeEnd = 358990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveRange(int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054E3 RID: 21731 RVA: 0x00177690 File Offset: 0x00175890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358990, XrefRangeEnd = 358991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Il2CppReferenceArray<Object> ToArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}

			// Token: 0x060054E4 RID: 21732 RVA: 0x001776DC File Offset: 0x001758DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358991, XrefRangeEnd = 358992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Array ToArray(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
				}
			}

			// Token: 0x060054E5 RID: 21733 RVA: 0x00020BB4 File Offset: 0x0001EDB4
			public ReadOnlyArrayList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015B5 RID: 5557
			// (get) Token: 0x060054E6 RID: 21734 RVA: 0x00177738 File Offset: 0x00175938
			// (set) Token: 0x060054E7 RID: 21735 RVA: 0x00020BBD File Offset: 0x0001EDBD
			public unsafe ArrayList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ReadOnlyArrayList.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ReadOnlyArrayList.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004430 RID: 17456
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04004431 RID: 17457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0;

			// Token: 0x04004432 RID: 17458
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x04004433 RID: 17459
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

			// Token: 0x04004434 RID: 17460
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0;

			// Token: 0x04004435 RID: 17461
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0;

			// Token: 0x04004436 RID: 17462
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x04004437 RID: 17463
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0;

			// Token: 0x04004438 RID: 17464
			private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0;

			// Token: 0x04004439 RID: 17465
			private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0;

			// Token: 0x0400443A RID: 17466
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x0400443B RID: 17467
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x0400443C RID: 17468
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x0400443D RID: 17469
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x0400443E RID: 17470
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0;

			// Token: 0x0400443F RID: 17471
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

			// Token: 0x04004440 RID: 17472
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0;

			// Token: 0x04004441 RID: 17473
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0;

			// Token: 0x04004442 RID: 17474
			private static readonly IntPtr NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0;

			// Token: 0x04004443 RID: 17475
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;

			// Token: 0x04004444 RID: 17476
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0;

			// Token: 0x04004445 RID: 17477
			private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0;

			// Token: 0x04004446 RID: 17478
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04004447 RID: 17479
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0;
		}

		// Token: 0x0200064A RID: 1610
		[Serializable]
		public sealed class ArrayListEnumeratorSimple : Object
		{
			// Token: 0x060054E8 RID: 21736 RVA: 0x00177768 File Offset: 0x00175968
			// Note: this type is marked as 'beforefieldinit'.
			static ArrayListEnumeratorSimple()
			{
				Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "ArrayListEnumeratorSimple");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr);
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "list");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "index");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "version");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "currentElement");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_isArrayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "isArrayList");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_dummyObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "dummyObject");
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100673135);
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100673136);
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100673137);
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100673138);
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100673139);
			}

			// Token: 0x060054E9 RID: 21737 RVA: 0x00177870 File Offset: 0x00175A70
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359005, RefRangeEnd = 359006, XrefRangeStart = 358992, XrefRangeEnd = 359005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArrayListEnumeratorSimple(ArrayList list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054EA RID: 21738 RVA: 0x001778BC File Offset: 0x00175ABC
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267191, XrefRangeEnd = 267283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060054EB RID: 21739 RVA: 0x001778FC File Offset: 0x00175AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359006, XrefRangeEnd = 359010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015C1 RID: 5569
			// (get) Token: 0x060054EC RID: 21740 RVA: 0x00177938 File Offset: 0x00175B38
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359010, XrefRangeEnd = 359014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060054ED RID: 21741 RVA: 0x00177978 File Offset: 0x00175B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359014, XrefRangeEnd = 359018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054EE RID: 21742 RVA: 0x00020BDC File Offset: 0x0001EDDC
			public ArrayListEnumeratorSimple(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015BB RID: 5563
			// (get) Token: 0x060054EF RID: 21743 RVA: 0x001779AC File Offset: 0x00175BAC
			// (set) Token: 0x060054F0 RID: 21744 RVA: 0x00020BE5 File Offset: 0x0001EDE5
			public unsafe ArrayList list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015BC RID: 5564
			// (get) Token: 0x060054F1 RID: 21745 RVA: 0x001779DC File Offset: 0x00175BDC
			// (set) Token: 0x060054F2 RID: 21746 RVA: 0x00020C04 File Offset: 0x0001EE04
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170015BD RID: 5565
			// (get) Token: 0x060054F3 RID: 21747 RVA: 0x00177A04 File Offset: 0x00175C04
			// (set) Token: 0x060054F4 RID: 21748 RVA: 0x00020C1F File Offset: 0x0001EE1F
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170015BE RID: 5566
			// (get) Token: 0x060054F5 RID: 21749 RVA: 0x00177A2C File Offset: 0x00175C2C
			// (set) Token: 0x060054F6 RID: 21750 RVA: 0x00020C3A File Offset: 0x0001EE3A
			public unsafe Object currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_currentElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_currentElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015BF RID: 5567
			// (get) Token: 0x060054F7 RID: 21751 RVA: 0x00177A5C File Offset: 0x00175C5C
			// (set) Token: 0x060054F8 RID: 21752 RVA: 0x00020C59 File Offset: 0x0001EE59
			public unsafe bool isArrayList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_isArrayList);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_isArrayList)) = value;
				}
			}

			// Token: 0x170015C0 RID: 5568
			// (get) Token: 0x060054F9 RID: 21753 RVA: 0x00177A84 File Offset: 0x00175C84
			// (set) Token: 0x060054FA RID: 21754 RVA: 0x00020C74 File Offset: 0x0001EE74
			public unsafe static Object dummyObject
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_dummyObject, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_dummyObject, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004448 RID: 17480
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x04004449 RID: 17481
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400444A RID: 17482
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x0400444B RID: 17483
			private static readonly IntPtr NativeFieldInfoPtr_currentElement;

			// Token: 0x0400444C RID: 17484
			private static readonly IntPtr NativeFieldInfoPtr_isArrayList;

			// Token: 0x0400444D RID: 17485
			private static readonly IntPtr NativeFieldInfoPtr_dummyObject;

			// Token: 0x0400444E RID: 17486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0;

			// Token: 0x0400444F RID: 17487
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004450 RID: 17488
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004451 RID: 17489
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004452 RID: 17490
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200064B RID: 1611
		public class ArrayListDebugView : Object
		{
			// Token: 0x060054FB RID: 21755 RVA: 0x00020C86 File Offset: 0x0001EE86
			// Note: this type is marked as 'beforefieldinit'.
			static ArrayListDebugView()
			{
				Il2CppClassPointerStore<ArrayList.ArrayListDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "ArrayListDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList.ArrayListDebugView>.NativeClassPtr);
			}

			// Token: 0x060054FC RID: 21756 RVA: 0x00020CA6 File Offset: 0x0001EEA6
			public ArrayListDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
