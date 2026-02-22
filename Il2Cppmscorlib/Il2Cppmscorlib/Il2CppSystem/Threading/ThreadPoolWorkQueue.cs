using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000281 RID: 641
	public sealed class ThreadPoolWorkQueue : Object
	{
		// Token: 0x06002BC8 RID: 11208 RVA: 0x000E01F0 File Offset: 0x000DE3F0
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolWorkQueue()
		{
			Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolWorkQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr);
			ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "queueHead");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "queueTail");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "allThreadQueues");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "numOutstandingThreadRequests");
			ThreadPoolWorkQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670250);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670251);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670252);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670253);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670254);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670255);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670256);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670257);
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000E0310 File Offset: 0x000DE510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333068, XrefRangeEnd = 333075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000E034C File Offset: 0x000DE54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333075, XrefRangeEnd = 333105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueueThreadLocals>(intPtr3) : null;
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000E038C File Offset: 0x000DE58C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333114, RefRangeEnd = 333117, XrefRangeStart = 333105, XrefRangeEnd = 333114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureThreadRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000E03C0 File Offset: 0x000DE5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333117, XrefRangeEnd = 333120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkThreadRequestSatisfied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000E03F4 File Offset: 0x000DE5F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333141, RefRangeEnd = 333144, XrefRangeStart = 333120, XrefRangeEnd = 333141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGlobal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000E0444 File Offset: 0x000DE644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333144, XrefRangeEnd = 333148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LocalFindAndPop(IThreadPoolWorkItem callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000E0494 File Offset: 0x000DE694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333167, RefRangeEnd = 333168, XrefRangeStart = 333148, XrefRangeEnd = 333167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tl);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			callback = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000E0508 File Offset: 0x000DE708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333233, RefRangeEnd = 333234, XrefRangeStart = 333168, XrefRangeEnd = 333233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Dispatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x0000F3AF File Offset: 0x0000D5AF
		public ThreadPoolWorkQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000E0538 File Offset: 0x000DE738
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
		public unsafe ThreadPoolWorkQueue.QueueSegment queueHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000E0568 File Offset: 0x000DE768
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x0000F3D7 File Offset: 0x0000D5D7
		public unsafe ThreadPoolWorkQueue.QueueSegment queueTail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000E0598 File Offset: 0x000DE798
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x0000F3F6 File Offset: 0x0000D5F6
		public unsafe static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000E05C0 File Offset: 0x000DE7C0
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x0000F408 File Offset: 0x0000D608
		public unsafe int numOutstandingThreadRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests)) = value;
			}
		}

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeFieldInfoPtr_queueHead;

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeFieldInfoPtr_queueTail;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeFieldInfoPtr_allThreadQueues;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeFieldInfoPtr_numOutstandingThreadRequests;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0;

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0;

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0;

		// Token: 0x020005F1 RID: 1521
		public class SparseArray<T> : Object where T : class
		{
			// Token: 0x06005280 RID: 21120 RVA: 0x0016FB24 File Offset: 0x0016DD24
			// Note: this type is marked as 'beforefieldinit'.
			static SparseArray()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "SparseArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr);
				ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, "m_array");
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100670259);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100670260);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Add_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100670261);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Remove_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100670262);
			}

			// Token: 0x06005281 RID: 21121 RVA: 0x0016FBF0 File Offset: 0x0016DDF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332893, XrefRangeEnd = 332897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SparseArray(int initialSize)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref initialSize;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001514 RID: 5396
			// (get) Token: 0x06005282 RID: 21122 RVA: 0x0016FC38 File Offset: 0x0016DE38
			public unsafe Il2CppArrayBase<T> Current
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 330539, RefRangeEnd = 330541, XrefRangeStart = 330539, XrefRangeEnd = 330541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
				}
			}

			// Token: 0x06005283 RID: 21123 RVA: 0x0016FC70 File Offset: 0x0016DE70
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 332910, RefRangeEnd = 332913, XrefRangeStart = 332897, XrefRangeEnd = 332910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Add(T e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = e;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref e;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Add_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005284 RID: 21124 RVA: 0x0016FCF4 File Offset: 0x0016DEF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332923, RefRangeEnd = 332924, XrefRangeStart = 332913, XrefRangeEnd = 332923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(T e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = e;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref e;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Remove_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06005285 RID: 21125 RVA: 0x0001F899 File Offset: 0x0001DA99
			public SparseArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001513 RID: 5395
			// (get) Token: 0x06005286 RID: 21126 RVA: 0x0016FD6C File Offset: 0x0016DF6C
			// (set) Token: 0x06005287 RID: 21127 RVA: 0x0001F8A2 File Offset: 0x0001DAA2
			public unsafe Il2CppArrayBase<T> m_array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042DD RID: 17117
			private static readonly IntPtr NativeFieldInfoPtr_m_array;

			// Token: 0x040042DE RID: 17118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x040042DF RID: 17119
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0;

			// Token: 0x040042E0 RID: 17120
			private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Int32_T_0;

			// Token: 0x040042E1 RID: 17121
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_T_0;
		}

		// Token: 0x020005F2 RID: 1522
		public class WorkStealingQueue : Object
		{
			// Token: 0x06005288 RID: 21128 RVA: 0x0016FD94 File Offset: 0x0016DF94
			// Note: this type is marked as 'beforefieldinit'.
			static WorkStealingQueue()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "WorkStealingQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_array");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_mask");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_headIndex");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_tailIndex");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_foreignLock");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670263);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670264);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670265);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670266);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670267);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670268);
			}

			// Token: 0x06005289 RID: 21129 RVA: 0x0016FE9C File Offset: 0x0016E09C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332967, RefRangeEnd = 332968, XrefRangeStart = 332924, XrefRangeEnd = 332967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void LocalPush(IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600528A RID: 21130 RVA: 0x0016FEE0 File Offset: 0x0016E0E0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 332991, RefRangeEnd = 332993, XrefRangeStart = 332968, XrefRangeEnd = 332991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool LocalFindAndPop(IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600528B RID: 21131 RVA: 0x0016FF30 File Offset: 0x0016E130
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 333011, RefRangeEnd = 333013, XrefRangeStart = 332993, XrefRangeEnd = 333011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool LocalPop(out IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600528C RID: 21132 RVA: 0x0016FF90 File Offset: 0x0016E190
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333014, RefRangeEnd = 333015, XrefRangeStart = 333013, XrefRangeEnd = 333014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600528D RID: 21133 RVA: 0x0016FFFC File Offset: 0x0016E1FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333032, RefRangeEnd = 333033, XrefRangeStart = 333015, XrefRangeEnd = 333032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600528E RID: 21134 RVA: 0x00170078 File Offset: 0x0016E278
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 333040, RefRangeEnd = 333043, XrefRangeStart = 333033, XrefRangeEnd = 333040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkStealingQueue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600528F RID: 21135 RVA: 0x0001F8C1 File Offset: 0x0001DAC1
			public WorkStealingQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001515 RID: 5397
			// (get) Token: 0x06005290 RID: 21136 RVA: 0x001700B4 File Offset: 0x0016E2B4
			// (set) Token: 0x06005291 RID: 21137 RVA: 0x0001F8CA File Offset: 0x0001DACA
			public unsafe Il2CppReferenceArray<IThreadPoolWorkItem> m_array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IThreadPoolWorkItem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001516 RID: 5398
			// (get) Token: 0x06005292 RID: 21138 RVA: 0x001700E4 File Offset: 0x0016E2E4
			// (set) Token: 0x06005293 RID: 21139 RVA: 0x0001F8E9 File Offset: 0x0001DAE9
			public unsafe int m_mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask)) = value;
				}
			}

			// Token: 0x17001517 RID: 5399
			// (get) Token: 0x06005294 RID: 21140 RVA: 0x0017010C File Offset: 0x0016E30C
			// (set) Token: 0x06005295 RID: 21141 RVA: 0x0001F904 File Offset: 0x0001DB04
			public unsafe int m_headIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex)) = value;
				}
			}

			// Token: 0x17001518 RID: 5400
			// (get) Token: 0x06005296 RID: 21142 RVA: 0x00170134 File Offset: 0x0016E334
			// (set) Token: 0x06005297 RID: 21143 RVA: 0x0001F91F File Offset: 0x0001DB1F
			public unsafe int m_tailIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex)) = value;
				}
			}

			// Token: 0x17001519 RID: 5401
			// (get) Token: 0x06005298 RID: 21144 RVA: 0x0017015C File Offset: 0x0016E35C
			// (set) Token: 0x06005299 RID: 21145 RVA: 0x0001F93A File Offset: 0x0001DB3A
			public unsafe SpinLock m_foreignLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock)) = value;
				}
			}

			// Token: 0x040042E2 RID: 17122
			private static readonly IntPtr NativeFieldInfoPtr_m_array;

			// Token: 0x040042E3 RID: 17123
			private static readonly IntPtr NativeFieldInfoPtr_m_mask;

			// Token: 0x040042E4 RID: 17124
			private static readonly IntPtr NativeFieldInfoPtr_m_headIndex;

			// Token: 0x040042E5 RID: 17125
			private static readonly IntPtr NativeFieldInfoPtr_m_tailIndex;

			// Token: 0x040042E6 RID: 17126
			private static readonly IntPtr NativeFieldInfoPtr_m_foreignLock;

			// Token: 0x040042E7 RID: 17127
			private static readonly IntPtr NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0;

			// Token: 0x040042E8 RID: 17128
			private static readonly IntPtr NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0;

			// Token: 0x040042E9 RID: 17129
			private static readonly IntPtr NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0;

			// Token: 0x040042EA RID: 17130
			private static readonly IntPtr NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0;

			// Token: 0x040042EB RID: 17131
			private static readonly IntPtr NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0;

			// Token: 0x040042EC RID: 17132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005F3 RID: 1523
		public class QueueSegment : Object
		{
			// Token: 0x0600529A RID: 21146 RVA: 0x00170184 File Offset: 0x0016E384
			// Note: this type is marked as 'beforefieldinit'.
			static QueueSegment()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "QueueSegment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr);
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "nodes");
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "indexes");
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "Next");
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670269);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670270);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670271);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670272);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670273);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670274);
			}

			// Token: 0x0600529B RID: 21147 RVA: 0x00170264 File Offset: 0x0016E464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333043, XrefRangeEnd = 333044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetIndexes(out int upper, out int lower)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &upper;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lower;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600529C RID: 21148 RVA: 0x001702B0 File Offset: 0x0016E4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333044, XrefRangeEnd = 333046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &prevUpper;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newUpper;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &prevLower;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newLower;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600529D RID: 21149 RVA: 0x00170324 File Offset: 0x0016E524
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 333050, RefRangeEnd = 333053, XrefRangeStart = 333046, XrefRangeEnd = 333050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QueueSegment()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600529E RID: 21150 RVA: 0x00170360 File Offset: 0x0016E560
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333054, RefRangeEnd = 333055, XrefRangeStart = 333053, XrefRangeEnd = 333054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsUsedUp()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600529F RID: 21151 RVA: 0x0017039C File Offset: 0x0016E59C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333059, RefRangeEnd = 333060, XrefRangeStart = 333055, XrefRangeEnd = 333059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryEnqueue(IThreadPoolWorkItem node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060052A0 RID: 21152 RVA: 0x001703EC File Offset: 0x0016E5EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333067, RefRangeEnd = 333068, XrefRangeStart = 333060, XrefRangeEnd = 333067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryDequeue(out IThreadPoolWorkItem node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					node = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060052A1 RID: 21153 RVA: 0x0001F955 File Offset: 0x0001DB55
			public QueueSegment(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700151A RID: 5402
			// (get) Token: 0x060052A2 RID: 21154 RVA: 0x0017044C File Offset: 0x0016E64C
			// (set) Token: 0x060052A3 RID: 21155 RVA: 0x0001F95E File Offset: 0x0001DB5E
			public unsafe Il2CppReferenceArray<IThreadPoolWorkItem> nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IThreadPoolWorkItem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700151B RID: 5403
			// (get) Token: 0x060052A4 RID: 21156 RVA: 0x0017047C File Offset: 0x0016E67C
			// (set) Token: 0x060052A5 RID: 21157 RVA: 0x0001F97D File Offset: 0x0001DB7D
			public unsafe int indexes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes)) = value;
				}
			}

			// Token: 0x1700151C RID: 5404
			// (get) Token: 0x060052A6 RID: 21158 RVA: 0x001704A4 File Offset: 0x0016E6A4
			// (set) Token: 0x060052A7 RID: 21159 RVA: 0x0001F998 File Offset: 0x0001DB98
			public unsafe ThreadPoolWorkQueue.QueueSegment Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042ED RID: 17133
			private static readonly IntPtr NativeFieldInfoPtr_nodes;

			// Token: 0x040042EE RID: 17134
			private static readonly IntPtr NativeFieldInfoPtr_indexes;

			// Token: 0x040042EF RID: 17135
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x040042F0 RID: 17136
			private static readonly IntPtr NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0;

			// Token: 0x040042F1 RID: 17137
			private static readonly IntPtr NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0;

			// Token: 0x040042F2 RID: 17138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040042F3 RID: 17139
			private static readonly IntPtr NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0;

			// Token: 0x040042F4 RID: 17140
			private static readonly IntPtr NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0;

			// Token: 0x040042F5 RID: 17141
			private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0;
		}
	}
}
