using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000482 RID: 1154
	[Serializable]
	public class Queue : Object
	{
		// Token: 0x060044D2 RID: 17618 RVA: 0x0013A6E8 File Offset: 0x001388E8
		// Note: this type is marked as 'beforefieldinit'.
		static Queue()
		{
			Il2CppClassPointerStore<Queue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Queue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue>.NativeClassPtr);
			Queue.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_array");
			Queue.NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_head");
			Queue.NativeFieldInfoPtr__tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_tail");
			Queue.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_size");
			Queue.NativeFieldInfoPtr__growFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_growFactor");
			Queue.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_version");
			Queue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673338);
			Queue.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673339);
			Queue.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673340);
			Queue.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673341);
			Queue.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673342);
			Queue.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673343);
			Queue.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673344);
			Queue.NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673345);
			Queue.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673346);
			Queue.NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673347);
			Queue.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673348);
			Queue.NativeMethodInfoPtr_GetElement_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673349);
			Queue.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100673350);
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x0013A894 File Offset: 0x00138A94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 360433, RefRangeEnd = 360435, XrefRangeStart = 360432, XrefRangeEnd = 360433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x0013A8D0 File Offset: 0x00138AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360435, XrefRangeEnd = 360436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x0013A918 File Offset: 0x00138B18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 360440, RefRangeEnd = 360444, XrefRangeStart = 360436, XrefRangeEnd = 360440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue(int capacity, float growFactor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x0013A970 File Offset: 0x00138B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360444, XrefRangeEnd = 360461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue(ICollection col)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x060044D7 RID: 17623 RVA: 0x0013A9BC File Offset: 0x00138BBC
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x0013AA04 File Offset: 0x00138C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360461, XrefRangeEnd = 360467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x0013AA50 File Offset: 0x00138C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360467, XrefRangeEnd = 360471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x0013AAAC File Offset: 0x00138CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360471, XrefRangeEnd = 360478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enqueue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x0013AAFC File Offset: 0x00138CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360478, XrefRangeEnd = 360482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x0013AB48 File Offset: 0x00138D48
		[CallerCount(0)]
		public unsafe virtual Object Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x0013AB94 File Offset: 0x00138D94
		[CallerCount(0)]
		public unsafe virtual Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x0013ABE0 File Offset: 0x00138DE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360482, RefRangeEnd = 360483, XrefRangeStart = 360482, XrefRangeEnd = 360482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetElement(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr_GetElement_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x0013AC2C File Offset: 0x00138E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360483, XrefRangeEnd = 360489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x0001A5C4 File Offset: 0x000187C4
		public Queue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x0013AC6C File Offset: 0x00138E6C
		// (set) Token: 0x060044E2 RID: 17634 RVA: 0x0001A5CD File Offset: 0x000187CD
		public unsafe Il2CppReferenceArray<Object> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x0013AC9C File Offset: 0x00138E9C
		// (set) Token: 0x060044E4 RID: 17636 RVA: 0x0001A5EC File Offset: 0x000187EC
		public unsafe int _head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__head);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__head)) = value;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x0013ACC4 File Offset: 0x00138EC4
		// (set) Token: 0x060044E6 RID: 17638 RVA: 0x0001A607 File Offset: 0x00018807
		public unsafe int _tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__tail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__tail)) = value;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x0013ACEC File Offset: 0x00138EEC
		// (set) Token: 0x060044E8 RID: 17640 RVA: 0x0001A622 File Offset: 0x00018822
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x0013AD14 File Offset: 0x00138F14
		// (set) Token: 0x060044EA RID: 17642 RVA: 0x0001A63D File Offset: 0x0001883D
		public unsafe int _growFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__growFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__growFactor)) = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x0013AD3C File Offset: 0x00138F3C
		// (set) Token: 0x060044EC RID: 17644 RVA: 0x0001A658 File Offset: 0x00018858
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x040037F9 RID: 14329
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x040037FA RID: 14330
		private static readonly IntPtr NativeFieldInfoPtr__head;

		// Token: 0x040037FB RID: 14331
		private static readonly IntPtr NativeFieldInfoPtr__tail;

		// Token: 0x040037FC RID: 14332
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x040037FD RID: 14333
		private static readonly IntPtr NativeFieldInfoPtr__growFactor;

		// Token: 0x040037FE RID: 14334
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x040037FF RID: 14335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003800 RID: 14336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003801 RID: 14337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

		// Token: 0x04003802 RID: 14338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

		// Token: 0x04003803 RID: 14339
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003804 RID: 14340
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003805 RID: 14341
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003806 RID: 14342
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003807 RID: 14343
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04003808 RID: 14344
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0;

		// Token: 0x04003809 RID: 14345
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0;

		// Token: 0x0400380A RID: 14346
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Internal_Object_Int32_0;

		// Token: 0x0400380B RID: 14347
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0;

		// Token: 0x02000656 RID: 1622
		[Serializable]
		public class QueueEnumerator : Object
		{
			// Token: 0x06005574 RID: 21876 RVA: 0x001795A0 File Offset: 0x001777A0
			// Note: this type is marked as 'beforefieldinit'.
			static QueueEnumerator()
			{
				Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Queue>.NativeClassPtr, "QueueEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr);
				Queue.QueueEnumerator.NativeFieldInfoPtr__q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, "_q");
				Queue.QueueEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, "_index");
				Queue.QueueEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, "_version");
				Queue.QueueEnumerator.NativeFieldInfoPtr_currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, "currentElement");
				Queue.QueueEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Queue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100673351);
				Queue.QueueEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100673352);
				Queue.QueueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100673353);
				Queue.QueueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100673354);
				Queue.QueueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100673355);
			}

			// Token: 0x06005575 RID: 21877 RVA: 0x00179680 File Offset: 0x00177880
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 360429, RefRangeEnd = 360430, XrefRangeStart = 360428, XrefRangeEnd = 360429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QueueEnumerator(Queue q)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.QueueEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Queue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005576 RID: 21878 RVA: 0x001796CC File Offset: 0x001778CC
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267191, XrefRangeEnd = 267283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.QueueEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005577 RID: 21879 RVA: 0x0017970C File Offset: 0x0017790C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360430, XrefRangeEnd = 360431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.QueueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015F0 RID: 5616
			// (get) Token: 0x06005578 RID: 21880 RVA: 0x00179754 File Offset: 0x00177954
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360431, XrefRangeEnd = 360432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.QueueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005579 RID: 21881 RVA: 0x001797A0 File Offset: 0x001779A0
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.QueueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600557A RID: 21882 RVA: 0x00020FC5 File Offset: 0x0001F1C5
			public QueueEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015EC RID: 5612
			// (get) Token: 0x0600557B RID: 21883 RVA: 0x001797DC File Offset: 0x001779DC
			// (set) Token: 0x0600557C RID: 21884 RVA: 0x00020FCE File Offset: 0x0001F1CE
			public unsafe Queue _q
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__q);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__q), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015ED RID: 5613
			// (get) Token: 0x0600557D RID: 21885 RVA: 0x0017980C File Offset: 0x00177A0C
			// (set) Token: 0x0600557E RID: 21886 RVA: 0x00020FED File Offset: 0x0001F1ED
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170015EE RID: 5614
			// (get) Token: 0x0600557F RID: 21887 RVA: 0x00179834 File Offset: 0x00177A34
			// (set) Token: 0x06005580 RID: 21888 RVA: 0x00021008 File Offset: 0x0001F208
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170015EF RID: 5615
			// (get) Token: 0x06005581 RID: 21889 RVA: 0x0017985C File Offset: 0x00177A5C
			// (set) Token: 0x06005582 RID: 21890 RVA: 0x00021023 File Offset: 0x0001F223
			public unsafe Object currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr_currentElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr_currentElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400449F RID: 17567
			private static readonly IntPtr NativeFieldInfoPtr__q;

			// Token: 0x040044A0 RID: 17568
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x040044A1 RID: 17569
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x040044A2 RID: 17570
			private static readonly IntPtr NativeFieldInfoPtr_currentElement;

			// Token: 0x040044A3 RID: 17571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Queue_0;

			// Token: 0x040044A4 RID: 17572
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x040044A5 RID: 17573
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x040044A6 RID: 17574
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x040044A7 RID: 17575
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000657 RID: 1623
		public class QueueDebugView : Object
		{
			// Token: 0x06005583 RID: 21891 RVA: 0x00021042 File Offset: 0x0001F242
			// Note: this type is marked as 'beforefieldinit'.
			static QueueDebugView()
			{
				Il2CppClassPointerStore<Queue.QueueDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Queue>.NativeClassPtr, "QueueDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue.QueueDebugView>.NativeClassPtr);
			}

			// Token: 0x06005584 RID: 21892 RVA: 0x00021062 File Offset: 0x0001F262
			public QueueDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
