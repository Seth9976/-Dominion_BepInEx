using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Collections.ObjectModel
{
	// Token: 0x02000486 RID: 1158
	[Serializable]
	public class ReadOnlyCollection<T> : Object
	{
		// Token: 0x06004556 RID: 17750 RVA: 0x0013CD78 File Offset: 0x0013AF78
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyCollection()
		{
			Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.ObjectModel", "ReadOnlyCollection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr);
			ReadOnlyCollection<T>.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, "list");
			ReadOnlyCollection<T>.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673486);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673487);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673488);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673489);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673490);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673491);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673492);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673493);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673494);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673495);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673496);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673497);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673498);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673499);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673500);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673501);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673502);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673503);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673504);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673505);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673506);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673507);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673508);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673509);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673510);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673511);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673512);
			ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr, 100673513);
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x0013D028 File Offset: 0x0013B228
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 361021, RefRangeEnd = 361039, XrefRangeStart = 361019, XrefRangeEnd = 361021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection(IList<T> list)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyCollection<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06004558 RID: 17752 RVA: 0x0013D074 File Offset: 0x0013B274
		public unsafe virtual int Count
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 361042, RefRangeEnd = 361048, XrefRangeStart = 361039, XrefRangeEnd = 361042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011AB RID: 4523
		public unsafe virtual T this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361048, XrefRangeEnd = 361050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x0013D0F8 File Offset: 0x0013B2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361050, XrefRangeEnd = 361052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x0013D17C File Offset: 0x0013B37C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361054, RefRangeEnd = 361055, XrefRangeStart = 361052, XrefRangeEnd = 361054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x0013D1CC File Offset: 0x0013B3CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 360869, RefRangeEnd = 360874, XrefRangeStart = 360869, XrefRangeEnd = 360874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x0013D20C File Offset: 0x0013B40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361055, XrefRangeEnd = 361057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x0013D290 File Offset: 0x0013B490
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x0013D2CC File Offset: 0x0013B4CC
		// (set) Token: 0x06004560 RID: 17760 RVA: 0x0013D314 File Offset: 0x0013B514
		public unsafe virtual T System.Collections.Generic.IList<T>.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361057, XrefRangeEnd = 361058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x0013D39C File Offset: 0x0013B59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_ICollection_T__Add(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x0013D414 File Offset: 0x0013B614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_ICollection_T__Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x0013D448 File Offset: 0x0013B648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_IList_T__Insert(int index, T value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x0013D4D0 File Offset: 0x0013B6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361058, XrefRangeEnd = 361059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_Generic_ICollection_T__Remove(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x0013D554 File Offset: 0x0013B754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_IList_T__RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x0013D594 File Offset: 0x0013B794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361059, XrefRangeEnd = 361103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x0013D5D4 File Offset: 0x0013B7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361103, XrefRangeEnd = 361134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x0013D624 File Offset: 0x0013B824
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x0013D660 File Offset: 0x0013B860
		// (set) Token: 0x0600456A RID: 17770 RVA: 0x0013D6AC File Offset: 0x0013B8AC
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361134, XrefRangeEnd = 361138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x0013D6FC File Offset: 0x0013B8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361138, XrefRangeEnd = 361139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x0013D74C File Offset: 0x0013B94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x0013D780 File Offset: 0x0013B980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361139, XrefRangeEnd = 361142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleObject(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x0013D7C4 File Offset: 0x0013B9C4
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x0013D814 File Offset: 0x0013BA14
		[CallerCount(0)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x0013D864 File Offset: 0x0013BA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x0013D8B4 File Offset: 0x0013BAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x0013D8F8 File Offset: 0x0013BAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection<T>.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x0001A831 File Offset: 0x00018A31
		public ReadOnlyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x0013D938 File Offset: 0x0013BB38
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x0001A83A File Offset: 0x00018A3A
		public unsafe IList<T> list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyCollection<T>.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyCollection<T>.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003860 RID: 14432
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x04003861 RID: 14433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0;

		// Token: 0x04003862 RID: 14434
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003863 RID: 14435
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x04003864 RID: 14436
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04003865 RID: 14437
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04003866 RID: 14438
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04003867 RID: 14439
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0;

		// Token: 0x04003868 RID: 14440
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003869 RID: 14441
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x0400386A RID: 14442
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0;

		// Token: 0x0400386B RID: 14443
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x0400386C RID: 14444
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400386D RID: 14445
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0;

		// Token: 0x0400386E RID: 14446
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0;

		// Token: 0x0400386F RID: 14447
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04003870 RID: 14448
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003871 RID: 14449
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003872 RID: 14450
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003873 RID: 14451
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x04003874 RID: 14452
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x04003875 RID: 14453
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04003876 RID: 14454
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003877 RID: 14455
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0;

		// Token: 0x04003878 RID: 14456
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04003879 RID: 14457
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400387A RID: 14458
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x0400387B RID: 14459
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400387C RID: 14460
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0;
	}
}
