using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000B0 RID: 176
	[Serializable]
	public class Queue<T> : Object
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x000388A4 File Offset: 0x00036AA4
		// Note: this type is marked as 'beforefieldinit'.
		static Queue()
		{
			Il2CppClassPointerStore<Queue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "Queue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr);
			Queue<T>.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_array");
			Queue<T>.NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_head");
			Queue<T>.NativeFieldInfoPtr__tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_tail");
			Queue<T>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_size");
			Queue<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_version");
			Queue<T>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_syncRoot");
			Queue<T>.NativeFieldInfoPtr_MinimumGrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "MinimumGrow");
			Queue<T>.NativeFieldInfoPtr_GrowFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "GrowFactor");
			Queue<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664742);
			Queue<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664743);
			Queue<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664744);
			Queue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664745);
			Queue<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664746);
			Queue<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664747);
			Queue<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664748);
			Queue<T>.NativeMethodInfoPtr_Dequeue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664749);
			Queue<T>.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664750);
			Queue<T>.NativeMethodInfoPtr_MoveNext_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664751);
			Queue<T>.NativeMethodInfoPtr_ThrowForEmptyQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100664752);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00038A8C File Offset: 0x00036C8C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 44768, RefRangeEnd = 44784, XrefRangeStart = 44767, XrefRangeEnd = 44768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00038AC8 File Offset: 0x00036CC8
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00038B04 File Offset: 0x00036D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44784, XrefRangeEnd = 44789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00038B54 File Offset: 0x00036D54
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 44789, RefRangeEnd = 44798, XrefRangeStart = 44789, XrefRangeEnd = 44789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00038BCC File Offset: 0x00036DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44799, RefRangeEnd = 44800, XrefRangeStart = 44798, XrefRangeEnd = 44799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Queue<T>.Enumerator(intPtr);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00038C04 File Offset: 0x00036E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44800, XrefRangeEnd = 44803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00038C44 File Offset: 0x00036E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00038C84 File Offset: 0x00036E84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 44803, RefRangeEnd = 44808, XrefRangeStart = 44803, XrefRangeEnd = 44803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_Dequeue_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00038CC0 File Offset: 0x00036EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44808, XrefRangeEnd = 44813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00038D00 File Offset: 0x00036F00
		[CallerCount(0)]
		public unsafe void MoveNext(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_MoveNext_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00038D40 File Offset: 0x00036F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44813, XrefRangeEnd = 44819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowForEmptyQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_ThrowForEmptyQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0000632C File Offset: 0x0000452C
		public Queue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00038D74 File Offset: 0x00036F74
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00006335 File Offset: 0x00004535
		public unsafe Il2CppArrayBase<T> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__array);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00038D9C File Offset: 0x00036F9C
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00006354 File Offset: 0x00004554
		public unsafe int _head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__head);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__head)) = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00038DC4 File Offset: 0x00036FC4
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x0000636F File Offset: 0x0000456F
		public unsafe int _tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__tail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__tail)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00038DEC File Offset: 0x00036FEC
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0000638A File Offset: 0x0000458A
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00038E14 File Offset: 0x00037014
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x000063A5 File Offset: 0x000045A5
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00038E3C File Offset: 0x0003703C
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x000063C0 File Offset: 0x000045C0
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00038E6C File Offset: 0x0003706C
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x000063DF File Offset: 0x000045DF
		public unsafe static int MinimumGrow
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Queue<T>.NativeFieldInfoPtr_MinimumGrow, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Queue<T>.NativeFieldInfoPtr_MinimumGrow, (void*)(&value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00038E88 File Offset: 0x00037088
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x000063ED File Offset: 0x000045ED
		public unsafe static int GrowFactor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Queue<T>.NativeFieldInfoPtr_GrowFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Queue<T>.NativeFieldInfoPtr_GrowFactor, (void*)(&value));
			}
		}

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr__head;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr__tail;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_MinimumGrow;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_GrowFactor;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_T_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_T_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Void_byref_Int32_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_ThrowForEmptyQueue_Private_Void_0;

		// Token: 0x020001A0 RID: 416
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x060017C6 RID: 6086 RVA: 0x000667A4 File Offset: 0x000649A4
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr);
				Queue<T>.Enumerator.NativeFieldInfoPtr__q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, "_q");
				Queue<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, "_version");
				Queue<T>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, "_index");
				Queue<T>.Enumerator.NativeFieldInfoPtr__currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, "_currentElement");
				Queue<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Queue_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100664753);
				Queue<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100664754);
				Queue<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100664755);
				Queue<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100664756);
				Queue<T>.Enumerator.NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100664757);
				Queue<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100664758);
				Queue<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100664759);
			}

			// Token: 0x060017C7 RID: 6087 RVA: 0x000668E8 File Offset: 0x00064AE8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 44752, RefRangeEnd = 44755, XrefRangeStart = 44752, XrefRangeEnd = 44752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Queue<T> q)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Queue_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017C8 RID: 6088 RVA: 0x00066938 File Offset: 0x00064B38
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 44755, RefRangeEnd = 44757, XrefRangeStart = 44755, XrefRangeEnd = 44755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017C9 RID: 6089 RVA: 0x00066970 File Offset: 0x00064B70
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 44757, RefRangeEnd = 44758, XrefRangeStart = 44757, XrefRangeEnd = 44757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x060017CA RID: 6090 RVA: 0x000669B4 File Offset: 0x00064BB4
			public unsafe T Current
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 44758, RefRangeEnd = 44759, XrefRangeStart = 44758, XrefRangeEnd = 44758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060017CB RID: 6091 RVA: 0x000669F4 File Offset: 0x00064BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44759, XrefRangeEnd = 44766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowEnumerationNotStartedOrEnded()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x060017CC RID: 6092 RVA: 0x00066A2C File Offset: 0x00064C2C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44766, XrefRangeEnd = 44767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017CD RID: 6093 RVA: 0x00066A70 File Offset: 0x00064C70
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017CE RID: 6094 RVA: 0x0000C8F2 File Offset: 0x0000AAF2
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060017CF RID: 6095 RVA: 0x0000C8FB File Offset: 0x0000AAFB
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00066AA8 File Offset: 0x00064CA8
			// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0000C90D File Offset: 0x0000AB0D
			public unsafe Queue<T> _q
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__q);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__q), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00066AD8 File Offset: 0x00064CD8
			// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0000C92C File Offset: 0x0000AB2C
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00066B00 File Offset: 0x00064D00
			// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0000C947 File Offset: 0x0000AB47
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00066B28 File Offset: 0x00064D28
			// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00066B50 File Offset: 0x00064D50
			public unsafe T _currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__currentElement);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__currentElement);
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

			// Token: 0x040012E6 RID: 4838
			private static readonly IntPtr NativeFieldInfoPtr__q;

			// Token: 0x040012E7 RID: 4839
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x040012E8 RID: 4840
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x040012E9 RID: 4841
			private static readonly IntPtr NativeFieldInfoPtr__currentElement;

			// Token: 0x040012EA RID: 4842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Queue_1_T_0;

			// Token: 0x040012EB RID: 4843
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040012EC RID: 4844
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040012ED RID: 4845
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x040012EE RID: 4846
			private static readonly IntPtr NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0;

			// Token: 0x040012EF RID: 4847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012F0 RID: 4848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
