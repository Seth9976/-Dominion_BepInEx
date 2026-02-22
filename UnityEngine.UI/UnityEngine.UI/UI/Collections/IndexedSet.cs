using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI.Collections
{
	// Token: 0x02000045 RID: 69
	public class IndexedSet<T> : Object
	{
		// Token: 0x06000829 RID: 2089 RVA: 0x00026B04 File Offset: 0x00024D04
		// Note: this type is marked as 'beforefieldinit'.
		static IndexedSet()
		{
			Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.Collections", "IndexedSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr);
			IndexedSet<T>.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, "m_List");
			IndexedSet<T>.NativeFieldInfoPtr_m_Dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, "m_Dictionary");
			IndexedSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664494);
			IndexedSet<T>.NativeMethodInfoPtr_AddUnique_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664495);
			IndexedSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664496);
			IndexedSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664497);
			IndexedSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664498);
			IndexedSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664499);
			IndexedSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664500);
			IndexedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664501);
			IndexedSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664502);
			IndexedSet<T>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664503);
			IndexedSet<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664504);
			IndexedSet<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664505);
			IndexedSet<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664506);
			IndexedSet<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664507);
			IndexedSet<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664508);
			IndexedSet<T>.NativeMethodInfoPtr_RemoveAll_Public_Void_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664509);
			IndexedSet<T>.NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664510);
			IndexedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr, 100664511);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00026D00 File Offset: 0x00024F00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120334, RefRangeEnd = 120336, XrefRangeStart = 120333, XrefRangeEnd = 120334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00026D78 File Offset: 0x00024F78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120336, RefRangeEnd = 120339, XrefRangeStart = 120336, XrefRangeEnd = 120336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddUnique(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_AddUnique_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00026DFC File Offset: 0x00024FFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 120339, RefRangeEnd = 120346, XrefRangeStart = 120339, XrefRangeEnd = 120339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00026E80 File Offset: 0x00025080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120346, XrefRangeEnd = 120351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00026EC0 File Offset: 0x000250C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120351, XrefRangeEnd = 120352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00026F00 File Offset: 0x00025100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120353, RefRangeEnd = 120355, XrefRangeStart = 120352, XrefRangeEnd = 120353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00026F34 File Offset: 0x00025134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120356, RefRangeEnd = 120357, XrefRangeStart = 120355, XrefRangeEnd = 120356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00026FB8 File Offset: 0x000251B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120357, XrefRangeEnd = 120358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00027008 File Offset: 0x00025208
		public unsafe virtual int Count
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 120359, RefRangeEnd = 120369, XrefRangeStart = 120358, XrefRangeEnd = 120359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00027044 File Offset: 0x00025244
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00027080 File Offset: 0x00025280
		[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00027104 File Offset: 0x00025304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120369, XrefRangeEnd = 120375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0002718C File Offset: 0x0002538C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 120377, RefRangeEnd = 120381, XrefRangeStart = 120375, XrefRangeEnd = 120377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002CA RID: 714
		public unsafe virtual T this[int index]
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 120382, RefRangeEnd = 120391, XrefRangeStart = 120381, XrefRangeEnd = 120382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120391, XrefRangeEnd = 120392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0002729C File Offset: 0x0002549C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120392, XrefRangeEnd = 120394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAll(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_RemoveAll_Public_Void_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000272E0 File Offset: 0x000254E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120395, RefRangeEnd = 120396, XrefRangeStart = 120394, XrefRangeEnd = 120395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(Comparison<T> sortLayoutFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortLayoutFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00027324 File Offset: 0x00025524
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 120401, RefRangeEnd = 120407, XrefRangeStart = 120396, XrefRangeEnd = 120401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00004D4D File Offset: 0x00002F4D
		public IndexedSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00027360 File Offset: 0x00025560
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00004D56 File Offset: 0x00002F56
		public unsafe List<T> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedSet<T>.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedSet<T>.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00027390 File Offset: 0x00025590
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00004D75 File Offset: 0x00002F75
		public unsafe Dictionary<T, int> m_Dictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedSet<T>.NativeFieldInfoPtr_m_Dictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedSet<T>.NativeFieldInfoPtr_m_Dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_m_Dictionary;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_AddUnique_Public_Boolean_T_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Void_Predicate_1_T_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_T_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
