using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000AF RID: 175
	public sealed class LinkedListNode<T> : Object
	{
		// Token: 0x06000A99 RID: 2713 RVA: 0x000384F4 File Offset: 0x000366F4
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedListNode()
		{
			Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "LinkedListNode`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr);
			LinkedListNode<T>.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, "list");
			LinkedListNode<T>.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, "next");
			LinkedListNode<T>.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, "prev");
			LinkedListNode<T>.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, "item");
			LinkedListNode<T>.NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100664738);
			LinkedListNode<T>.NativeMethodInfoPtr_get_Next_Public_get_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100664739);
			LinkedListNode<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100664740);
			LinkedListNode<T>.NativeMethodInfoPtr_Invalidate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100664741);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00038600 File Offset: 0x00036800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44744, XrefRangeEnd = 44745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedListNode(LinkedList<T> list, T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00038694 File Offset: 0x00036894
		public unsafe LinkedListNode<T> Next
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 44745, RefRangeEnd = 44752, XrefRangeStart = 44745, XrefRangeEnd = 44745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_get_Next_Public_get_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr3) : null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000386D4 File Offset: 0x000368D4
		public unsafe T Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00038710 File Offset: 0x00036910
		[CallerCount(0)]
		public unsafe void Invalidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_Invalidate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000062C6 File Offset: 0x000044C6
		public LinkedListNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00038744 File Offset: 0x00036944
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x000062CF File Offset: 0x000044CF
		public unsafe LinkedList<T> list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00038774 File Offset: 0x00036974
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x000062EE File Offset: 0x000044EE
		public unsafe LinkedListNode<T> next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000387A4 File Offset: 0x000369A4
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0000630D File Offset: 0x0000450D
		public unsafe LinkedListNode<T> prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000387D4 File Offset: 0x000369D4
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x000387FC File Offset: 0x000369FC
		public unsafe T item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_item);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_item);
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

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_prev;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_T_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_get_Next_Public_get_LinkedListNode_1_T_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_Invalidate_Internal_Void_0;
	}
}
