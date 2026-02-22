using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000483 RID: 1155
	[Serializable]
	public class SortedList : Object
	{
		// Token: 0x060044ED RID: 17645 RVA: 0x0013AD64 File Offset: 0x00138F64
		// Note: this type is marked as 'beforefieldinit'.
		static SortedList()
		{
			Il2CppClassPointerStore<SortedList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "SortedList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList>.NativeClassPtr);
			SortedList.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "keys");
			SortedList.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "values");
			SortedList.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "_size");
			SortedList.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "version");
			SortedList.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "comparer");
			SortedList.NativeFieldInfoPtr_keyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "keyList");
			SortedList.NativeFieldInfoPtr_valueList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "valueList");
			SortedList.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "_syncRoot");
			SortedList.NativeFieldInfoPtr_emptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "emptyArray");
			SortedList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673356);
			SortedList.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673357);
			SortedList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673358);
			SortedList.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673359);
			SortedList.NativeMethodInfoPtr__ctor_Public_Void_IComparer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673360);
			SortedList.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673361);
			SortedList.NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673362);
			SortedList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673363);
			SortedList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673364);
			SortedList.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673365);
			SortedList.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673366);
			SortedList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673367);
			SortedList.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673368);
			SortedList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673369);
			SortedList.NativeMethodInfoPtr_ContainsValue_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673370);
			SortedList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673371);
			SortedList.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673372);
			SortedList.NativeMethodInfoPtr_GetByIndex_Public_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673373);
			SortedList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673374);
			SortedList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673375);
			SortedList.NativeMethodInfoPtr_GetKey_Public_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673376);
			SortedList.NativeMethodInfoPtr_GetKeyList_Public_Virtual_New_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673377);
			SortedList.NativeMethodInfoPtr_GetValueList_Public_Virtual_New_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673378);
			SortedList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673379);
			SortedList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673380);
			SortedList.NativeMethodInfoPtr_IndexOfKey_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673381);
			SortedList.NativeMethodInfoPtr_IndexOfValue_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673382);
			SortedList.NativeMethodInfoPtr_Insert_Private_Void_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673383);
			SortedList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673384);
			SortedList.NativeMethodInfoPtr_Synchronized_Public_Static_SortedList_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100673385);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x0013B0A0 File Offset: 0x001392A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 360670, RefRangeEnd = 360672, XrefRangeStart = 360656, XrefRangeEnd = 360670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x0013B0DC File Offset: 0x001392DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360672, XrefRangeEnd = 360685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x0013B110 File Offset: 0x00139310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360685, XrefRangeEnd = 360699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedList(int initialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x0013B158 File Offset: 0x00139358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360713, RefRangeEnd = 360714, XrefRangeStart = 360699, XrefRangeEnd = 360713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedList(IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x0013B1A4 File Offset: 0x001393A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 360728, RefRangeEnd = 360730, XrefRangeStart = 360714, XrefRangeEnd = 360728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedList(IComparer comparer, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr__ctor_Public_Void_IComparer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x0013B200 File Offset: 0x00139400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360730, XrefRangeEnd = 360732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x0013B260 File Offset: 0x00139460
		// (set) Token: 0x060044F5 RID: 17653 RVA: 0x0013B2A8 File Offset: 0x001394A8
		public unsafe virtual int Capacity
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 275445, RefRangeEnd = 275457, XrefRangeStart = 275445, XrefRangeEnd = 275457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360732, XrefRangeEnd = 360738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x0013B2F4 File Offset: 0x001394F4
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060044F7 RID: 17655 RVA: 0x0013B33C File Offset: 0x0013953C
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x0013B388 File Offset: 0x00139588
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x060044F9 RID: 17657 RVA: 0x0013B3D4 File Offset: 0x001395D4
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360738, XrefRangeEnd = 360743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x0013B420 File Offset: 0x00139620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360743, XrefRangeEnd = 360762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x0013B46C File Offset: 0x0013966C
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x0013B4C4 File Offset: 0x001396C4
		[CallerCount(0)]
		public unsafe virtual bool ContainsValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_ContainsValue_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x0013B51C File Offset: 0x0013971C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360762, XrefRangeEnd = 360769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x0013B578 File Offset: 0x00139778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360769, XrefRangeEnd = 360771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureCapacity(int min)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x0013B5B8 File Offset: 0x001397B8
		[CallerCount(0)]
		public unsafe virtual Object GetByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetByIndex_Public_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x0013B610 File Offset: 0x00139810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360771, XrefRangeEnd = 360775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x0013B650 File Offset: 0x00139850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360775, XrefRangeEnd = 360779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x0013B69C File Offset: 0x0013989C
		[CallerCount(0)]
		public unsafe virtual Object GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetKey_Public_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x0013B6F4 File Offset: 0x001398F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360779, XrefRangeEnd = 360783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList GetKeyList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetKeyList_Public_Virtual_New_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x0013B740 File Offset: 0x00139940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360783, XrefRangeEnd = 360787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList GetValueList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetValueList_Public_Virtual_New_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x1700119C RID: 4508
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360787, XrefRangeEnd = 360789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x0013B848 File Offset: 0x00139A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360789, XrefRangeEnd = 360790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOfKey(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_IndexOfKey_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x0013B8A0 File Offset: 0x00139AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360790, XrefRangeEnd = 360793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOfValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_IndexOfValue_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x0013B8F8 File Offset: 0x00139AF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 360798, RefRangeEnd = 360800, XrefRangeStart = 360793, XrefRangeEnd = 360798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_Insert_Private_Void_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x0013B95C File Offset: 0x00139B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360800, XrefRangeEnd = 360802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x0013B9A8 File Offset: 0x00139BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360806, RefRangeEnd = 360807, XrefRangeStart = 360802, XrefRangeEnd = 360806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SortedList Synchronized(SortedList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_Synchronized_Public_Static_SortedList_SortedList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr3) : null;
			}
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x0001A673 File Offset: 0x00018873
		public SortedList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x0600450D RID: 17677 RVA: 0x0013B9EC File Offset: 0x00139BEC
		// (set) Token: 0x0600450E RID: 17678 RVA: 0x0001A67C File Offset: 0x0001887C
		public unsafe Il2CppReferenceArray<Object> keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x0013BA1C File Offset: 0x00139C1C
		// (set) Token: 0x06004510 RID: 17680 RVA: 0x0001A69B File Offset: 0x0001889B
		public unsafe Il2CppReferenceArray<Object> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x0013BA4C File Offset: 0x00139C4C
		// (set) Token: 0x06004512 RID: 17682 RVA: 0x0001A6BA File Offset: 0x000188BA
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06004513 RID: 17683 RVA: 0x0013BA74 File Offset: 0x00139C74
		// (set) Token: 0x06004514 RID: 17684 RVA: 0x0001A6D5 File Offset: 0x000188D5
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x0013BA9C File Offset: 0x00139C9C
		// (set) Token: 0x06004516 RID: 17686 RVA: 0x0001A6F0 File Offset: 0x000188F0
		public unsafe IComparer comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06004517 RID: 17687 RVA: 0x0013BACC File Offset: 0x00139CCC
		// (set) Token: 0x06004518 RID: 17688 RVA: 0x0001A70F File Offset: 0x0001890F
		public unsafe SortedList.KeyList keyList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_keyList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList.KeyList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_keyList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06004519 RID: 17689 RVA: 0x0013BAFC File Offset: 0x00139CFC
		// (set) Token: 0x0600451A RID: 17690 RVA: 0x0001A72E File Offset: 0x0001892E
		public unsafe SortedList.ValueList valueList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_valueList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList.ValueList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_valueList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x0013BB2C File Offset: 0x00139D2C
		// (set) Token: 0x0600451C RID: 17692 RVA: 0x0001A74D File Offset: 0x0001894D
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x0013BB5C File Offset: 0x00139D5C
		// (set) Token: 0x0600451E RID: 17694 RVA: 0x0001A76C File Offset: 0x0001896C
		public unsafe static Il2CppReferenceArray<Object> emptyArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedList.NativeFieldInfoPtr_emptyArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedList.NativeFieldInfoPtr_emptyArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400380C RID: 14348
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x0400380D RID: 14349
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x0400380E RID: 14350
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x0400380F RID: 14351
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04003810 RID: 14352
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04003811 RID: 14353
		private static readonly IntPtr NativeFieldInfoPtr_keyList;

		// Token: 0x04003812 RID: 14354
		private static readonly IntPtr NativeFieldInfoPtr_valueList;

		// Token: 0x04003813 RID: 14355
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003814 RID: 14356
		private static readonly IntPtr NativeFieldInfoPtr_emptyArray;

		// Token: 0x04003815 RID: 14357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003816 RID: 14358
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04003817 RID: 14359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003818 RID: 14360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_0;

		// Token: 0x04003819 RID: 14361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_Int32_0;

		// Token: 0x0400381A RID: 14362
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0;

		// Token: 0x0400381B RID: 14363
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400381C RID: 14364
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400381D RID: 14365
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400381E RID: 14366
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0;

		// Token: 0x0400381F RID: 14367
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0;

		// Token: 0x04003820 RID: 14368
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x04003821 RID: 14369
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003822 RID: 14370
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003823 RID: 14371
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003824 RID: 14372
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003825 RID: 14373
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0;

		// Token: 0x04003826 RID: 14374
		private static readonly IntPtr NativeMethodInfoPtr_GetByIndex_Public_Virtual_New_Object_Int32_0;

		// Token: 0x04003827 RID: 14375
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003828 RID: 14376
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0;

		// Token: 0x04003829 RID: 14377
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_New_Object_Int32_0;

		// Token: 0x0400382A RID: 14378
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyList_Public_Virtual_New_IList_0;

		// Token: 0x0400382B RID: 14379
		private static readonly IntPtr NativeMethodInfoPtr_GetValueList_Public_Virtual_New_IList_0;

		// Token: 0x0400382C RID: 14380
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0;

		// Token: 0x0400382D RID: 14381
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0;

		// Token: 0x0400382E RID: 14382
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfKey_Public_Virtual_New_Int32_Object_0;

		// Token: 0x0400382F RID: 14383
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfValue_Public_Virtual_New_Int32_Object_0;

		// Token: 0x04003830 RID: 14384
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Int32_Object_Object_0;

		// Token: 0x04003831 RID: 14385
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04003832 RID: 14386
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_SortedList_SortedList_0;

		// Token: 0x02000658 RID: 1624
		[Serializable]
		public class SyncSortedList : SortedList
		{
			// Token: 0x06005585 RID: 21893 RVA: 0x0017988C File Offset: 0x00177A8C
			// Note: this type is marked as 'beforefieldinit'.
			static SyncSortedList()
			{
				Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "SyncSortedList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr);
				SortedList.SyncSortedList.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, "_list");
				SortedList.SyncSortedList.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, "_root");
				SortedList.SyncSortedList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673387);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673388);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673389);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673390);
				SortedList.SyncSortedList.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673391);
				SortedList.SyncSortedList.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673392);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_Capacity_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673393);
				SortedList.SyncSortedList.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673394);
				SortedList.SyncSortedList.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673395);
				SortedList.SyncSortedList.NativeMethodInfoPtr_ContainsValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673396);
				SortedList.SyncSortedList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673397);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetByIndex_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673398);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673399);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetKey_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673400);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetKeyList_Public_Virtual_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673401);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetValueList_Public_Virtual_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673402);
				SortedList.SyncSortedList.NativeMethodInfoPtr_IndexOfKey_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673403);
				SortedList.SyncSortedList.NativeMethodInfoPtr_IndexOfValue_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673404);
				SortedList.SyncSortedList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100673405);
			}

			// Token: 0x06005586 RID: 21894 RVA: 0x00179A5C File Offset: 0x00177C5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 360493, RefRangeEnd = 360494, XrefRangeStart = 360489, XrefRangeEnd = 360493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncSortedList(SortedList list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.SyncSortedList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170015F3 RID: 5619
			// (get) Token: 0x06005587 RID: 21895 RVA: 0x00179AA8 File Offset: 0x00177CA8
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360494, XrefRangeEnd = 360497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170015F4 RID: 5620
			// (get) Token: 0x06005588 RID: 21896 RVA: 0x00179AF0 File Offset: 0x00177CF0
			public unsafe override Object SyncRoot
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170015F5 RID: 5621
			public unsafe override Object this[Object key]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360497, XrefRangeEnd = 360500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360500, XrefRangeEnd = 360503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600558B RID: 21899 RVA: 0x00179BF8 File Offset: 0x00177DF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360503, XrefRangeEnd = 360506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Add(Object key, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015F6 RID: 5622
			// (get) Token: 0x0600558C RID: 21900 RVA: 0x00179C58 File Offset: 0x00177E58
			public unsafe override int Capacity
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360506, XrefRangeEnd = 360509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_Capacity_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600558D RID: 21901 RVA: 0x00179CA0 File Offset: 0x00177EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360509, XrefRangeEnd = 360512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x0600558E RID: 21902 RVA: 0x00179CEC File Offset: 0x00177EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360512, XrefRangeEnd = 360515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600558F RID: 21903 RVA: 0x00179D44 File Offset: 0x00177F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360515, XrefRangeEnd = 360518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ContainsValue(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_ContainsValue_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005590 RID: 21904 RVA: 0x00179D9C File Offset: 0x00177F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360518, XrefRangeEnd = 360521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005591 RID: 21905 RVA: 0x00179DF8 File Offset: 0x00177FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360521, XrefRangeEnd = 360524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object GetByIndex(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetByIndex_Public_Virtual_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005592 RID: 21906 RVA: 0x00179E50 File Offset: 0x00178050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360524, XrefRangeEnd = 360527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IDictionaryEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005593 RID: 21907 RVA: 0x00179E9C File Offset: 0x0017809C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360527, XrefRangeEnd = 360530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object GetKey(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetKey_Public_Virtual_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005594 RID: 21908 RVA: 0x00179EF4 File Offset: 0x001780F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360530, XrefRangeEnd = 360533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IList GetKeyList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetKeyList_Public_Virtual_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}

			// Token: 0x06005595 RID: 21909 RVA: 0x00179F40 File Offset: 0x00178140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360533, XrefRangeEnd = 360536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IList GetValueList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetValueList_Public_Virtual_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}

			// Token: 0x06005596 RID: 21910 RVA: 0x00179F8C File Offset: 0x0017818C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360536, XrefRangeEnd = 360539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int IndexOfKey(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_IndexOfKey_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005597 RID: 21911 RVA: 0x00179FE4 File Offset: 0x001781E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360539, XrefRangeEnd = 360542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int IndexOfValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_IndexOfValue_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005598 RID: 21912 RVA: 0x0017A03C File Offset: 0x0017823C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360542, XrefRangeEnd = 360545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005599 RID: 21913 RVA: 0x0002106B File Offset: 0x0001F26B
			public SyncSortedList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015F1 RID: 5617
			// (get) Token: 0x0600559A RID: 21914 RVA: 0x0017A088 File Offset: 0x00178288
			// (set) Token: 0x0600559B RID: 21915 RVA: 0x00021074 File Offset: 0x0001F274
			public unsafe SortedList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SyncSortedList.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SyncSortedList.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F2 RID: 5618
			// (get) Token: 0x0600559C RID: 21916 RVA: 0x0017A0B8 File Offset: 0x001782B8
			// (set) Token: 0x0600559D RID: 21917 RVA: 0x00021093 File Offset: 0x0001F293
			public unsafe Object _root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SyncSortedList.NativeFieldInfoPtr__root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SyncSortedList.NativeFieldInfoPtr__root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044A8 RID: 17576
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x040044A9 RID: 17577
			private static readonly IntPtr NativeFieldInfoPtr__root;

			// Token: 0x040044AA RID: 17578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0;

			// Token: 0x040044AB RID: 17579
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x040044AC RID: 17580
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x040044AD RID: 17581
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0;

			// Token: 0x040044AE RID: 17582
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0;

			// Token: 0x040044AF RID: 17583
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0;

			// Token: 0x040044B0 RID: 17584
			private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_Virtual_get_Int32_0;

			// Token: 0x040044B1 RID: 17585
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x040044B2 RID: 17586
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x040044B3 RID: 17587
			private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Virtual_Boolean_Object_0;

			// Token: 0x040044B4 RID: 17588
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x040044B5 RID: 17589
			private static readonly IntPtr NativeMethodInfoPtr_GetByIndex_Public_Virtual_Object_Int32_0;

			// Token: 0x040044B6 RID: 17590
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0;

			// Token: 0x040044B7 RID: 17591
			private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_Object_Int32_0;

			// Token: 0x040044B8 RID: 17592
			private static readonly IntPtr NativeMethodInfoPtr_GetKeyList_Public_Virtual_IList_0;

			// Token: 0x040044B9 RID: 17593
			private static readonly IntPtr NativeMethodInfoPtr_GetValueList_Public_Virtual_IList_0;

			// Token: 0x040044BA RID: 17594
			private static readonly IntPtr NativeMethodInfoPtr_IndexOfKey_Public_Virtual_Int32_Object_0;

			// Token: 0x040044BB RID: 17595
			private static readonly IntPtr NativeMethodInfoPtr_IndexOfValue_Public_Virtual_Int32_Object_0;

			// Token: 0x040044BC RID: 17596
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0;
		}

		// Token: 0x02000659 RID: 1625
		[Serializable]
		public class SortedListEnumerator : Object
		{
			// Token: 0x0600559E RID: 21918 RVA: 0x0017A0E8 File Offset: 0x001782E8
			// Note: this type is marked as 'beforefieldinit'.
			static SortedListEnumerator()
			{
				Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "SortedListEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr);
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_sortedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "sortedList");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "key");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "value");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "index");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "startIndex");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "endIndex");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "version");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "current");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr_getObjectRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "getObjectRetType");
				SortedList.SortedListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100673406);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100673407);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100673408);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100673409);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100673410);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100673411);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100673412);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100673413);
			}

			// Token: 0x0600559F RID: 21919 RVA: 0x0017A268 File Offset: 0x00178468
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 360546, RefRangeEnd = 360548, XrefRangeStart = 360545, XrefRangeEnd = 360546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortedList);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getObjRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.SortedListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055A0 RID: 21920 RVA: 0x0017A2E0 File Offset: 0x001784E0
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267191, XrefRangeEnd = 267283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.SortedListEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x17001600 RID: 5632
			// (get) Token: 0x060055A1 RID: 21921 RVA: 0x0017A320 File Offset: 0x00178520
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060055A2 RID: 21922 RVA: 0x0017A36C File Offset: 0x0017856C
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001601 RID: 5633
			// (get) Token: 0x060055A3 RID: 21923 RVA: 0x0017A3B4 File Offset: 0x001785B4
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360548, XrefRangeEnd = 360549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17001602 RID: 5634
			// (get) Token: 0x060055A4 RID: 21924 RVA: 0x0017A3F8 File Offset: 0x001785F8
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360549, XrefRangeEnd = 360553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001603 RID: 5635
			// (get) Token: 0x060055A5 RID: 21925 RVA: 0x0017A444 File Offset: 0x00178644
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060055A6 RID: 21926 RVA: 0x0017A490 File Offset: 0x00178690
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055A7 RID: 21927 RVA: 0x000210B2 File Offset: 0x0001F2B2
			public SortedListEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015F7 RID: 5623
			// (get) Token: 0x060055A8 RID: 21928 RVA: 0x0017A4CC File Offset: 0x001786CC
			// (set) Token: 0x060055A9 RID: 21929 RVA: 0x000210BB File Offset: 0x0001F2BB
			public unsafe SortedList sortedList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_sortedList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_sortedList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F8 RID: 5624
			// (get) Token: 0x060055AA RID: 21930 RVA: 0x0017A4FC File Offset: 0x001786FC
			// (set) Token: 0x060055AB RID: 21931 RVA: 0x000210DA File Offset: 0x0001F2DA
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F9 RID: 5625
			// (get) Token: 0x060055AC RID: 21932 RVA: 0x0017A52C File Offset: 0x0017872C
			// (set) Token: 0x060055AD RID: 21933 RVA: 0x000210F9 File Offset: 0x0001F2F9
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015FA RID: 5626
			// (get) Token: 0x060055AE RID: 21934 RVA: 0x0017A55C File Offset: 0x0017875C
			// (set) Token: 0x060055AF RID: 21935 RVA: 0x00021118 File Offset: 0x0001F318
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170015FB RID: 5627
			// (get) Token: 0x060055B0 RID: 21936 RVA: 0x0017A584 File Offset: 0x00178784
			// (set) Token: 0x060055B1 RID: 21937 RVA: 0x00021133 File Offset: 0x0001F333
			public unsafe int startIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_startIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_startIndex)) = value;
				}
			}

			// Token: 0x170015FC RID: 5628
			// (get) Token: 0x060055B2 RID: 21938 RVA: 0x0017A5AC File Offset: 0x001787AC
			// (set) Token: 0x060055B3 RID: 21939 RVA: 0x0002114E File Offset: 0x0001F34E
			public unsafe int endIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_endIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_endIndex)) = value;
				}
			}

			// Token: 0x170015FD RID: 5629
			// (get) Token: 0x060055B4 RID: 21940 RVA: 0x0017A5D4 File Offset: 0x001787D4
			// (set) Token: 0x060055B5 RID: 21941 RVA: 0x00021169 File Offset: 0x0001F369
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170015FE RID: 5630
			// (get) Token: 0x060055B6 RID: 21942 RVA: 0x0017A5FC File Offset: 0x001787FC
			// (set) Token: 0x060055B7 RID: 21943 RVA: 0x00021184 File Offset: 0x0001F384
			public unsafe bool current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_current)) = value;
				}
			}

			// Token: 0x170015FF RID: 5631
			// (get) Token: 0x060055B8 RID: 21944 RVA: 0x0017A624 File Offset: 0x00178824
			// (set) Token: 0x060055B9 RID: 21945 RVA: 0x0002119F File Offset: 0x0001F39F
			public unsafe int getObjectRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_getObjectRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr_getObjectRetType)) = value;
				}
			}

			// Token: 0x040044BD RID: 17597
			private static readonly IntPtr NativeFieldInfoPtr_sortedList;

			// Token: 0x040044BE RID: 17598
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040044BF RID: 17599
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040044C0 RID: 17600
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040044C1 RID: 17601
			private static readonly IntPtr NativeFieldInfoPtr_startIndex;

			// Token: 0x040044C2 RID: 17602
			private static readonly IntPtr NativeFieldInfoPtr_endIndex;

			// Token: 0x040044C3 RID: 17603
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x040044C4 RID: 17604
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040044C5 RID: 17605
			private static readonly IntPtr NativeFieldInfoPtr_getObjectRetType;

			// Token: 0x040044C6 RID: 17606
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedList_Int32_Int32_Int32_0;

			// Token: 0x040044C7 RID: 17607
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x040044C8 RID: 17608
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0;

			// Token: 0x040044C9 RID: 17609
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x040044CA RID: 17610
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0;

			// Token: 0x040044CB RID: 17611
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x040044CC RID: 17612
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0;

			// Token: 0x040044CD RID: 17613
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x0200065A RID: 1626
		[Serializable]
		public class KeyList : Object
		{
			// Token: 0x060055BA RID: 21946 RVA: 0x0017A64C File Offset: 0x0017884C
			// Note: this type is marked as 'beforefieldinit'.
			static KeyList()
			{
				Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "KeyList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr);
				SortedList.KeyList.NativeFieldInfoPtr_sortedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, "sortedList");
				SortedList.KeyList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673414);
				SortedList.KeyList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673415);
				SortedList.KeyList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673416);
				SortedList.KeyList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673417);
				SortedList.KeyList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673418);
				SortedList.KeyList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673419);
				SortedList.KeyList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673420);
				SortedList.KeyList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673421);
				SortedList.KeyList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673422);
				SortedList.KeyList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673423);
				SortedList.KeyList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673424);
				SortedList.KeyList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673425);
				SortedList.KeyList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673426);
				SortedList.KeyList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100673427);
			}

			// Token: 0x060055BB RID: 21947 RVA: 0x0017A7A4 File Offset: 0x001789A4
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyList(SortedList sortedList)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortedList);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.KeyList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001605 RID: 5637
			// (get) Token: 0x060055BC RID: 21948 RVA: 0x0017A7F0 File Offset: 0x001789F0
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001606 RID: 5638
			// (get) Token: 0x060055BD RID: 21949 RVA: 0x0017A838 File Offset: 0x00178A38
			public unsafe virtual bool IsReadOnly
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055BE RID: 21950 RVA: 0x0017A880 File Offset: 0x00178A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360553, XrefRangeEnd = 360560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Add(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055BF RID: 21951 RVA: 0x0017A8D8 File Offset: 0x00178AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360560, XrefRangeEnd = 360567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055C0 RID: 21952 RVA: 0x0017A914 File Offset: 0x00178B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360567, XrefRangeEnd = 360568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Contains(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055C1 RID: 21953 RVA: 0x0017A96C File Offset: 0x00178B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360568, XrefRangeEnd = 360570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055C2 RID: 21954 RVA: 0x0017A9C8 File Offset: 0x00178BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360570, XrefRangeEnd = 360577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001607 RID: 5639
			public unsafe virtual Object this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360577, XrefRangeEnd = 360578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360578, XrefRangeEnd = 360585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055C5 RID: 21957 RVA: 0x0017AAD8 File Offset: 0x00178CD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360585, XrefRangeEnd = 360589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060055C6 RID: 21958 RVA: 0x0017AB24 File Offset: 0x00178D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360589, XrefRangeEnd = 360590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int IndexOf(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055C7 RID: 21959 RVA: 0x0017AB7C File Offset: 0x00178D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360590, XrefRangeEnd = 360597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Remove(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055C8 RID: 21960 RVA: 0x0017ABCC File Offset: 0x00178DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360597, XrefRangeEnd = 360604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055C9 RID: 21961 RVA: 0x000211BA File Offset: 0x0001F3BA
			public KeyList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001604 RID: 5636
			// (get) Token: 0x060055CA RID: 21962 RVA: 0x0017AC18 File Offset: 0x00178E18
			// (set) Token: 0x060055CB RID: 21963 RVA: 0x000211C3 File Offset: 0x0001F3C3
			public unsafe SortedList sortedList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.KeyList.NativeFieldInfoPtr_sortedList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.KeyList.NativeFieldInfoPtr_sortedList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044CE RID: 17614
			private static readonly IntPtr NativeFieldInfoPtr_sortedList;

			// Token: 0x040044CF RID: 17615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0;

			// Token: 0x040044D0 RID: 17616
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

			// Token: 0x040044D1 RID: 17617
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

			// Token: 0x040044D2 RID: 17618
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0;

			// Token: 0x040044D3 RID: 17619
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

			// Token: 0x040044D4 RID: 17620
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

			// Token: 0x040044D5 RID: 17621
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x040044D6 RID: 17622
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0;

			// Token: 0x040044D7 RID: 17623
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0;

			// Token: 0x040044D8 RID: 17624
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0;

			// Token: 0x040044D9 RID: 17625
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x040044DA RID: 17626
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0;

			// Token: 0x040044DB RID: 17627
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

			// Token: 0x040044DC RID: 17628
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0;
		}

		// Token: 0x0200065B RID: 1627
		[Serializable]
		public class ValueList : Object
		{
			// Token: 0x060055CC RID: 21964 RVA: 0x0017AC48 File Offset: 0x00178E48
			// Note: this type is marked as 'beforefieldinit'.
			static ValueList()
			{
				Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "ValueList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr);
				SortedList.ValueList.NativeFieldInfoPtr_sortedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, "sortedList");
				SortedList.ValueList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673428);
				SortedList.ValueList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673429);
				SortedList.ValueList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673430);
				SortedList.ValueList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673431);
				SortedList.ValueList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673432);
				SortedList.ValueList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673433);
				SortedList.ValueList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673434);
				SortedList.ValueList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673435);
				SortedList.ValueList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673436);
				SortedList.ValueList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673437);
				SortedList.ValueList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673438);
				SortedList.ValueList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673439);
				SortedList.ValueList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673440);
				SortedList.ValueList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100673441);
			}

			// Token: 0x060055CD RID: 21965 RVA: 0x0017ADA0 File Offset: 0x00178FA0
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueList(SortedList sortedList)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortedList);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.ValueList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001609 RID: 5641
			// (get) Token: 0x060055CE RID: 21966 RVA: 0x0017ADEC File Offset: 0x00178FEC
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700160A RID: 5642
			// (get) Token: 0x060055CF RID: 21967 RVA: 0x0017AE34 File Offset: 0x00179034
			public unsafe virtual bool IsReadOnly
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055D0 RID: 21968 RVA: 0x0017AE7C File Offset: 0x0017907C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360604, XrefRangeEnd = 360611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Add(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055D1 RID: 21969 RVA: 0x0017AED4 File Offset: 0x001790D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360611, XrefRangeEnd = 360618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055D2 RID: 21970 RVA: 0x0017AF10 File Offset: 0x00179110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360618, XrefRangeEnd = 360619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Contains(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055D3 RID: 21971 RVA: 0x0017AF68 File Offset: 0x00179168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360619, XrefRangeEnd = 360621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055D4 RID: 21972 RVA: 0x0017AFC4 File Offset: 0x001791C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360621, XrefRangeEnd = 360628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700160B RID: 5643
			public unsafe virtual Object this[int index]
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 41402, RefRangeEnd = 41405, XrefRangeStart = 41402, XrefRangeEnd = 41405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360628, XrefRangeEnd = 360635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055D7 RID: 21975 RVA: 0x0017B0D4 File Offset: 0x001792D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360635, XrefRangeEnd = 360639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060055D8 RID: 21976 RVA: 0x0017B120 File Offset: 0x00179320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360639, XrefRangeEnd = 360642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int IndexOf(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055D9 RID: 21977 RVA: 0x0017B178 File Offset: 0x00179378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360642, XrefRangeEnd = 360649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Remove(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055DA RID: 21978 RVA: 0x0017B1C8 File Offset: 0x001793C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360649, XrefRangeEnd = 360656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055DB RID: 21979 RVA: 0x000211E2 File Offset: 0x0001F3E2
			public ValueList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001608 RID: 5640
			// (get) Token: 0x060055DC RID: 21980 RVA: 0x0017B214 File Offset: 0x00179414
			// (set) Token: 0x060055DD RID: 21981 RVA: 0x000211EB File Offset: 0x0001F3EB
			public unsafe SortedList sortedList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.ValueList.NativeFieldInfoPtr_sortedList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.ValueList.NativeFieldInfoPtr_sortedList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044DD RID: 17629
			private static readonly IntPtr NativeFieldInfoPtr_sortedList;

			// Token: 0x040044DE RID: 17630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0;

			// Token: 0x040044DF RID: 17631
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

			// Token: 0x040044E0 RID: 17632
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

			// Token: 0x040044E1 RID: 17633
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0;

			// Token: 0x040044E2 RID: 17634
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

			// Token: 0x040044E3 RID: 17635
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

			// Token: 0x040044E4 RID: 17636
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x040044E5 RID: 17637
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0;

			// Token: 0x040044E6 RID: 17638
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0;

			// Token: 0x040044E7 RID: 17639
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0;

			// Token: 0x040044E8 RID: 17640
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x040044E9 RID: 17641
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0;

			// Token: 0x040044EA RID: 17642
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

			// Token: 0x040044EB RID: 17643
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0;
		}

		// Token: 0x0200065C RID: 1628
		public class SortedListDebugView : Object
		{
			// Token: 0x060055DE RID: 21982 RVA: 0x0002120A File Offset: 0x0001F40A
			// Note: this type is marked as 'beforefieldinit'.
			static SortedListDebugView()
			{
				Il2CppClassPointerStore<SortedList.SortedListDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "SortedListDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.SortedListDebugView>.NativeClassPtr);
			}

			// Token: 0x060055DF RID: 21983 RVA: 0x0002122A File Offset: 0x0001F42A
			public SortedListDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
