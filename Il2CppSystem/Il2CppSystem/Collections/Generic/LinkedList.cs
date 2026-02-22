using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000AE RID: 174
	[Serializable]
	public class LinkedList<T> : Object
	{
		// Token: 0x06000A6C RID: 2668 RVA: 0x000377BC File Offset: 0x000359BC
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedList()
		{
			Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "LinkedList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr);
			LinkedList<T>.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "head");
			LinkedList<T>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "count");
			LinkedList<T>.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "version");
			LinkedList<T>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "_syncRoot");
			LinkedList<T>.NativeFieldInfoPtr__siInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "_siInfo");
			LinkedList<T>.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "VersionName");
			LinkedList<T>.NativeFieldInfoPtr_CountName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "CountName");
			LinkedList<T>.NativeFieldInfoPtr_ValuesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "ValuesName");
			LinkedList<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664702);
			LinkedList<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664703);
			LinkedList<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664704);
			LinkedList<T>.NativeMethodInfoPtr_get_First_Public_get_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664705);
			LinkedList<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664706);
			LinkedList<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664707);
			LinkedList<T>.NativeMethodInfoPtr_AddFirst_Public_LinkedListNode_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664708);
			LinkedList<T>.NativeMethodInfoPtr_AddFirst_Public_Void_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664709);
			LinkedList<T>.NativeMethodInfoPtr_AddLast_Public_LinkedListNode_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664710);
			LinkedList<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664711);
			LinkedList<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664712);
			LinkedList<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664713);
			LinkedList<T>.NativeMethodInfoPtr_Find_Public_LinkedListNode_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664714);
			LinkedList<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664715);
			LinkedList<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664716);
			LinkedList<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664717);
			LinkedList<T>.NativeMethodInfoPtr_Remove_Public_Void_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664718);
			LinkedList<T>.NativeMethodInfoPtr_RemoveLast_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664719);
			LinkedList<T>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664720);
			LinkedList<T>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664721);
			LinkedList<T>.NativeMethodInfoPtr_InternalInsertNodeBefore_Private_Void_LinkedListNode_1_T_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664722);
			LinkedList<T>.NativeMethodInfoPtr_InternalInsertNodeToEmptyList_Private_Void_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664723);
			LinkedList<T>.NativeMethodInfoPtr_InternalRemoveNode_Internal_Void_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664724);
			LinkedList<T>.NativeMethodInfoPtr_ValidateNewNode_Internal_Void_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664725);
			LinkedList<T>.NativeMethodInfoPtr_ValidateNode_Internal_Void_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664726);
			LinkedList<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664727);
			LinkedList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, 100664728);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00037AE4 File Offset: 0x00035CE4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44515, XrefRangeEnd = 44661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00037B20 File Offset: 0x00035D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44678, XrefRangeEnd = 44679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedList(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00037B84 File Offset: 0x00035D84
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00037BC0 File Offset: 0x00035DC0
		public unsafe LinkedListNode<T> First
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_get_First_Public_get_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr3) : null;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00037C00 File Offset: 0x00035E00
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00037C3C File Offset: 0x00035E3C
		[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00037CB4 File Offset: 0x00035EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44679, XrefRangeEnd = 44682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedListNode<T> AddFirst(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_AddFirst_Public_LinkedListNode_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr4) : null;
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00037D3C File Offset: 0x00035F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44683, RefRangeEnd = 44685, XrefRangeStart = 44682, XrefRangeEnd = 44683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFirst(LinkedListNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_AddFirst_Public_Void_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00037D80 File Offset: 0x00035F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44688, RefRangeEnd = 44690, XrefRangeStart = 44685, XrefRangeEnd = 44688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedListNode<T> AddLast(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_AddLast_Public_LinkedListNode_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr4) : null;
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00037E08 File Offset: 0x00036008
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00037E3C File Offset: 0x0003603C
		[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00037EC0 File Offset: 0x000360C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44690, RefRangeEnd = 44691, XrefRangeStart = 44690, XrefRangeEnd = 44690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00037F10 File Offset: 0x00036110
		[CallerCount(0)]
		public unsafe LinkedListNode<T> Find(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_Find_Public_LinkedListNode_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr4) : null;
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00037F98 File Offset: 0x00036198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44691, XrefRangeEnd = 44692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedList<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LinkedList<T>.Enumerator(intPtr);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00037FD0 File Offset: 0x000361D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44692, XrefRangeEnd = 44694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00038010 File Offset: 0x00036210
		[CallerCount(0)]
		public unsafe virtual bool Remove(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00038094 File Offset: 0x00036294
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 44695, RefRangeEnd = 44702, XrefRangeStart = 44694, XrefRangeEnd = 44695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(LinkedListNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_Remove_Public_Void_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000380D8 File Offset: 0x000362D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44702, XrefRangeEnd = 44708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_RemoveLast_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0003810C File Offset: 0x0003630C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44708, XrefRangeEnd = 44723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinkedList<T>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00038170 File Offset: 0x00036370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44723, XrefRangeEnd = 44731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinkedList<T>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000381C0 File Offset: 0x000363C0
		[CallerCount(0)]
		public unsafe void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_InternalInsertNodeBefore_Private_Void_LinkedListNode_1_T_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00038214 File Offset: 0x00036414
		[CallerCount(0)]
		public unsafe void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_InternalInsertNodeToEmptyList_Private_Void_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00038258 File Offset: 0x00036458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44731, XrefRangeEnd = 44732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRemoveNode(LinkedListNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_InternalRemoveNode_Internal_Void_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0003829C File Offset: 0x0003649C
		[CallerCount(0)]
		public unsafe void ValidateNewNode(LinkedListNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_ValidateNewNode_Internal_Void_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000382E0 File Offset: 0x000364E0
		[CallerCount(0)]
		public unsafe void ValidateNode(LinkedListNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_ValidateNode_Internal_Void_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00038324 File Offset: 0x00036524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44732, XrefRangeEnd = 44744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00038374 File Offset: 0x00036574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000061F4 File Offset: 0x000043F4
		public LinkedList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x000383B4 File Offset: 0x000365B4
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000061FD File Offset: 0x000043FD
		public unsafe LinkedListNode<T> head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x000383E4 File Offset: 0x000365E4
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x0000621C File Offset: 0x0000441C
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0003840C File Offset: 0x0003660C
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00006237 File Offset: 0x00004437
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00038434 File Offset: 0x00036634
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00006252 File Offset: 0x00004452
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00038464 File Offset: 0x00036664
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00006271 File Offset: 0x00004471
		public unsafe SerializationInfo _siInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr__siInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.NativeFieldInfoPtr__siInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00038494 File Offset: 0x00036694
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00006290 File Offset: 0x00004490
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LinkedList<T>.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LinkedList<T>.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000384B4 File Offset: 0x000366B4
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x000062A2 File Offset: 0x000044A2
		public unsafe static string CountName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LinkedList<T>.NativeFieldInfoPtr_CountName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LinkedList<T>.NativeFieldInfoPtr_CountName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x000384D4 File Offset: 0x000366D4
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x000062B4 File Offset: 0x000044B4
		public unsafe static string ValuesName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LinkedList<T>.NativeFieldInfoPtr_ValuesName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LinkedList<T>.NativeFieldInfoPtr_ValuesName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr__siInfo;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeFieldInfoPtr_CountName;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeFieldInfoPtr_ValuesName;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_get_First_Public_get_LinkedListNode_1_T_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_AddFirst_Public_LinkedListNode_1_T_T_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_AddFirst_Public_Void_LinkedListNode_1_T_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_AddLast_Public_LinkedListNode_1_T_T_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_LinkedListNode_1_T_T_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_LinkedListNode_1_T_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLast_Public_Void_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_InternalInsertNodeBefore_Private_Void_LinkedListNode_1_T_LinkedListNode_1_T_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_InternalInsertNodeToEmptyList_Private_Void_LinkedListNode_1_T_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_InternalRemoveNode_Internal_Void_LinkedListNode_1_T_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNewNode_Internal_Void_LinkedListNode_1_T_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNode_Internal_Void_LinkedListNode_1_T_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200019F RID: 415
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x060017B0 RID: 6064 RVA: 0x0006620C File Offset: 0x0006440C
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LinkedList<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr);
				LinkedList<T>.Enumerator.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, "_list");
				LinkedList<T>.Enumerator.NativeFieldInfoPtr__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, "_node");
				LinkedList<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, "_version");
				LinkedList<T>.Enumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, "_current");
				LinkedList<T>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, "_index");
				LinkedList<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664729);
				LinkedList<T>.Enumerator.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664730);
				LinkedList<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664731);
				LinkedList<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664732);
				LinkedList<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664733);
				LinkedList<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664734);
				LinkedList<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664735);
				LinkedList<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664736);
				LinkedList<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr, 100664737);
			}

			// Token: 0x060017B1 RID: 6065 RVA: 0x0006638C File Offset: 0x0006458C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 44455, RefRangeEnd = 44456, XrefRangeStart = 44455, XrefRangeEnd = 44455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(LinkedList<T> list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017B2 RID: 6066 RVA: 0x000663DC File Offset: 0x000645DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44456, XrefRangeEnd = 44461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00066444 File Offset: 0x00064644
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00066484 File Offset: 0x00064684
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44461, XrefRangeEnd = 44467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017B5 RID: 6069 RVA: 0x000664C8 File Offset: 0x000646C8
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060017B6 RID: 6070 RVA: 0x0006650C File Offset: 0x0006470C
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017B7 RID: 6071 RVA: 0x00066544 File Offset: 0x00064744
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017B8 RID: 6072 RVA: 0x0006657C File Offset: 0x0006477C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44467, XrefRangeEnd = 44505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017B9 RID: 6073 RVA: 0x000665DC File Offset: 0x000647DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44505, XrefRangeEnd = 44515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedList<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017BA RID: 6074 RVA: 0x0000C863 File Offset: 0x0000AA63
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060017BB RID: 6075 RVA: 0x0000C86C File Offset: 0x0000AA6C
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedList<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x060017BC RID: 6076 RVA: 0x00066624 File Offset: 0x00064824
			// (set) Token: 0x060017BD RID: 6077 RVA: 0x0000C87E File Offset: 0x0000AA7E
			public unsafe LinkedList<T> _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x060017BE RID: 6078 RVA: 0x00066654 File Offset: 0x00064854
			// (set) Token: 0x060017BF RID: 6079 RVA: 0x0000C89D File Offset: 0x0000AA9D
			public unsafe LinkedListNode<T> _node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00066684 File Offset: 0x00064884
			// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0000C8BC File Offset: 0x0000AABC
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x060017C2 RID: 6082 RVA: 0x000666AC File Offset: 0x000648AC
			// (set) Token: 0x060017C3 RID: 6083 RVA: 0x000666D4 File Offset: 0x000648D4
			public unsafe T _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0006677C File Offset: 0x0006497C
			// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0000C8D7 File Offset: 0x0000AAD7
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedList<T>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x040012D8 RID: 4824
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x040012D9 RID: 4825
			private static readonly IntPtr NativeFieldInfoPtr__node;

			// Token: 0x040012DA RID: 4826
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x040012DB RID: 4827
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x040012DC RID: 4828
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x040012DD RID: 4829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_0;

			// Token: 0x040012DE RID: 4830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040012DF RID: 4831
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x040012E0 RID: 4832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012E1 RID: 4833
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040012E2 RID: 4834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012E3 RID: 4835
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040012E4 RID: 4836
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040012E5 RID: 4837
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;
		}
	}
}
