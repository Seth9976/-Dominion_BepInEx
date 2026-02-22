using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000484 RID: 1156
	[Serializable]
	public class Stack : Object
	{
		// Token: 0x0600451F RID: 17695 RVA: 0x0013BB84 File Offset: 0x00139D84
		// Note: this type is marked as 'beforefieldinit'.
		static Stack()
		{
			Il2CppClassPointerStore<Stack>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Stack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack>.NativeClassPtr);
			Stack.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_array");
			Stack.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_size");
			Stack.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_version");
			Stack.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_syncRoot");
			Stack.NativeFieldInfoPtr__defaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_defaultCapacity");
			Stack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673442);
			Stack.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673443);
			Stack.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673444);
			Stack.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673445);
			Stack.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673446);
			Stack.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673447);
			Stack.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673448);
			Stack.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673449);
			Stack.NativeMethodInfoPtr_Pop_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673450);
			Stack.NativeMethodInfoPtr_Push_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100673451);
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x0013BCE0 File Offset: 0x00139EE0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 360813, RefRangeEnd = 360825, XrefRangeStart = 360809, XrefRangeEnd = 360813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x0013BD1C File Offset: 0x00139F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360825, XrefRangeEnd = 360829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack(int initialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x0013BD64 File Offset: 0x00139F64
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x0013BDAC File Offset: 0x00139FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360830, RefRangeEnd = 360831, XrefRangeStart = 360829, XrefRangeEnd = 360830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x0013BDE8 File Offset: 0x00139FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360831, XrefRangeEnd = 360839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x0013BE34 File Offset: 0x0013A034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360839, XrefRangeEnd = 360845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x0013BE90 File Offset: 0x0013A090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360845, XrefRangeEnd = 360849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x0013BEDC File Offset: 0x0013A0DC
		[CallerCount(0)]
		public unsafe virtual Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x0013BF28 File Offset: 0x0013A128
		[CallerCount(0)]
		public unsafe virtual Object Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Pop_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x0013BF74 File Offset: 0x0013A174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360849, XrefRangeEnd = 360854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Push(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Push_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x0001A77E File Offset: 0x0001897E
		public Stack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x0600452B RID: 17707 RVA: 0x0013BFC4 File Offset: 0x0013A1C4
		// (set) Token: 0x0600452C RID: 17708 RVA: 0x0001A787 File Offset: 0x00018987
		public unsafe Il2CppReferenceArray<Object> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x0013BFF4 File Offset: 0x0013A1F4
		// (set) Token: 0x0600452E RID: 17710 RVA: 0x0001A7A6 File Offset: 0x000189A6
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x0013C01C File Offset: 0x0013A21C
		// (set) Token: 0x06004530 RID: 17712 RVA: 0x0001A7C1 File Offset: 0x000189C1
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x0013C044 File Offset: 0x0013A244
		// (set) Token: 0x06004532 RID: 17714 RVA: 0x0001A7DC File Offset: 0x000189DC
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x0013C074 File Offset: 0x0013A274
		// (set) Token: 0x06004534 RID: 17716 RVA: 0x0001A7FB File Offset: 0x000189FB
		public unsafe static int _defaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Stack.NativeFieldInfoPtr__defaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stack.NativeFieldInfoPtr__defaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x04003833 RID: 14387
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04003834 RID: 14388
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04003835 RID: 14389
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003836 RID: 14390
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003837 RID: 14391
		private static readonly IntPtr NativeFieldInfoPtr__defaultCapacity;

		// Token: 0x04003838 RID: 14392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003839 RID: 14393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400383A RID: 14394
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400383B RID: 14395
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x0400383C RID: 14396
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x0400383D RID: 14397
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x0400383E RID: 14398
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x0400383F RID: 14399
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0;

		// Token: 0x04003840 RID: 14400
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_New_Object_0;

		// Token: 0x04003841 RID: 14401
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Virtual_New_Void_Object_0;

		// Token: 0x0200065D RID: 1629
		[Serializable]
		public class StackEnumerator : Object
		{
			// Token: 0x060055E0 RID: 21984 RVA: 0x0017B244 File Offset: 0x00179444
			// Note: this type is marked as 'beforefieldinit'.
			static StackEnumerator()
			{
				Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stack>.NativeClassPtr, "StackEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr);
				Stack.StackEnumerator.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "_stack");
				Stack.StackEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "_index");
				Stack.StackEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "_version");
				Stack.StackEnumerator.NativeFieldInfoPtr_currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "currentElement");
				Stack.StackEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Stack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100673452);
				Stack.StackEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100673453);
				Stack.StackEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100673454);
				Stack.StackEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100673455);
				Stack.StackEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100673456);
			}

			// Token: 0x060055E1 RID: 21985 RVA: 0x0017B324 File Offset: 0x00179524
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 360808, RefRangeEnd = 360809, XrefRangeStart = 360807, XrefRangeEnd = 360808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StackEnumerator(Stack stack)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.StackEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Stack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055E2 RID: 21986 RVA: 0x0017B370 File Offset: 0x00179570
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267191, XrefRangeEnd = 267283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.StackEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060055E3 RID: 21987 RVA: 0x0017B3B0 File Offset: 0x001795B0
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.StackEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001610 RID: 5648
			// (get) Token: 0x060055E4 RID: 21988 RVA: 0x0017B3F8 File Offset: 0x001795F8
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.StackEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060055E5 RID: 21989 RVA: 0x0017B444 File Offset: 0x00179644
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.StackEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055E6 RID: 21990 RVA: 0x00021233 File Offset: 0x0001F433
			public StackEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700160C RID: 5644
			// (get) Token: 0x060055E7 RID: 21991 RVA: 0x0017B480 File Offset: 0x00179680
			// (set) Token: 0x060055E8 RID: 21992 RVA: 0x0002123C File Offset: 0x0001F43C
			public unsafe Stack _stack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__stack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700160D RID: 5645
			// (get) Token: 0x060055E9 RID: 21993 RVA: 0x0017B4B0 File Offset: 0x001796B0
			// (set) Token: 0x060055EA RID: 21994 RVA: 0x0002125B File Offset: 0x0001F45B
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x1700160E RID: 5646
			// (get) Token: 0x060055EB RID: 21995 RVA: 0x0017B4D8 File Offset: 0x001796D8
			// (set) Token: 0x060055EC RID: 21996 RVA: 0x00021276 File Offset: 0x0001F476
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x1700160F RID: 5647
			// (get) Token: 0x060055ED RID: 21997 RVA: 0x0017B500 File Offset: 0x00179700
			// (set) Token: 0x060055EE RID: 21998 RVA: 0x00021291 File Offset: 0x0001F491
			public unsafe Object currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_currentElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_currentElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044EC RID: 17644
			private static readonly IntPtr NativeFieldInfoPtr__stack;

			// Token: 0x040044ED RID: 17645
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x040044EE RID: 17646
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x040044EF RID: 17647
			private static readonly IntPtr NativeFieldInfoPtr_currentElement;

			// Token: 0x040044F0 RID: 17648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stack_0;

			// Token: 0x040044F1 RID: 17649
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x040044F2 RID: 17650
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x040044F3 RID: 17651
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x040044F4 RID: 17652
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x0200065E RID: 1630
		public class StackDebugView : Object
		{
			// Token: 0x060055EF RID: 21999 RVA: 0x000212B0 File Offset: 0x0001F4B0
			// Note: this type is marked as 'beforefieldinit'.
			static StackDebugView()
			{
				Il2CppClassPointerStore<Stack.StackDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stack>.NativeClassPtr, "StackDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack.StackDebugView>.NativeClassPtr);
			}

			// Token: 0x060055F0 RID: 22000 RVA: 0x000212D0 File Offset: 0x0001F4D0
			public StackDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
