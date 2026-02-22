using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000062 RID: 98
	public class EventCallbackList : Object
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x0001F080 File Offset: 0x0001D280
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackList()
		{
			Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr);
			EventCallbackList.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, "m_List");
			EventCallbackList.NativeFieldInfoPtr__trickleDownCallbackCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, "<trickleDownCallbackCount>k__BackingField");
			EventCallbackList.NativeFieldInfoPtr__bubbleUpCallbackCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, "<bubbleUpCallbackCount>k__BackingField");
			EventCallbackList.NativeMethodInfoPtr_get_trickleDownCallbackCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663808);
			EventCallbackList.NativeMethodInfoPtr_set_trickleDownCallbackCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663809);
			EventCallbackList.NativeMethodInfoPtr_get_bubbleUpCallbackCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663810);
			EventCallbackList.NativeMethodInfoPtr_set_bubbleUpCallbackCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663811);
			EventCallbackList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663812);
			EventCallbackList.NativeMethodInfoPtr__ctor_Public_Void_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663813);
			EventCallbackList.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663814);
			EventCallbackList.NativeMethodInfoPtr_Find_Public_EventCallbackFunctorBase_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663815);
			EventCallbackList.NativeMethodInfoPtr_Remove_Public_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663816);
			EventCallbackList.NativeMethodInfoPtr_Add_Public_Void_EventCallbackFunctorBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663817);
			EventCallbackList.NativeMethodInfoPtr_AddRange_Public_Void_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663818);
			EventCallbackList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663819);
			EventCallbackList.NativeMethodInfoPtr_get_Item_Public_get_EventCallbackFunctorBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663820);
			EventCallbackList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100663821);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001F204 File Offset: 0x0001D404
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x0001F240 File Offset: 0x0001D440
		public unsafe int trickleDownCallbackCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_get_trickleDownCallbackCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_set_trickleDownCallbackCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001F280 File Offset: 0x0001D480
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x0001F2BC File Offset: 0x0001D4BC
		public unsafe int bubbleUpCallbackCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_get_bubbleUpCallbackCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_set_bubbleUpCallbackCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001F2FC File Offset: 0x0001D4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94494, XrefRangeEnd = 94501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001F338 File Offset: 0x0001D538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94501, XrefRangeEnd = 94508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList(EventCallbackList source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr__ctor_Public_Void_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0001F384 File Offset: 0x0001D584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94514, RefRangeEnd = 94515, XrefRangeStart = 94508, XrefRangeEnd = 94514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_Delegate_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94515, XrefRangeEnd = 94521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Find_Public_EventCallbackFunctorBase_Int64_Delegate_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackFunctorBase>(intPtr3) : null;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001F45C File Offset: 0x0001D65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94521, XrefRangeEnd = 94529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Remove_Public_Boolean_Int64_Delegate_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94532, RefRangeEnd = 94533, XrefRangeStart = 94529, XrefRangeEnd = 94532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(EventCallbackFunctorBase item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Add_Public_Void_EventCallbackFunctorBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001F50C File Offset: 0x0001D70C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94551, RefRangeEnd = 94553, XrefRangeStart = 94533, XrefRangeEnd = 94551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(EventCallbackList list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_AddRange_Public_Void_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001F550 File Offset: 0x0001D750
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94553, XrefRangeEnd = 94554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000210 RID: 528
		public unsafe EventCallbackFunctorBase this[int i]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94556, RefRangeEnd = 94558, XrefRangeStart = 94554, XrefRangeEnd = 94556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_get_Item_Public_get_EventCallbackFunctorBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackFunctorBase>(intPtr3) : null;
				}
			}
			set
			{
				this.m_List[i] = value;
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94558, XrefRangeEnd = 94561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00004C67 File Offset: 0x00002E67
		public EventCallbackList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001F60C File Offset: 0x0001D80C
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00004C70 File Offset: 0x00002E70
		public unsafe List<EventCallbackFunctorBase> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventCallbackFunctorBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001F63C File Offset: 0x0001D83C
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00004C8F File Offset: 0x00002E8F
		public unsafe int _trickleDownCallbackCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr__trickleDownCallbackCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr__trickleDownCallbackCount_k__BackingField)) = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001F664 File Offset: 0x0001D864
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00004CAA File Offset: 0x00002EAA
		public unsafe int _bubbleUpCallbackCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr__bubbleUpCallbackCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr__bubbleUpCallbackCount_k__BackingField)) = value;
			}
		}

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr__trickleDownCallbackCount_k__BackingField;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr__bubbleUpCallbackCount_k__BackingField;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_get_trickleDownCallbackCount_Public_get_Int32_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_set_trickleDownCallbackCount_Private_set_Void_Int32_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_get_bubbleUpCallbackCount_Public_get_Int32_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_set_bubbleUpCallbackCount_Private_set_Void_Int32_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventCallbackList_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int64_Delegate_CallbackPhase_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_EventCallbackFunctorBase_Int64_Delegate_CallbackPhase_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_Int64_Delegate_CallbackPhase_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_EventCallbackFunctorBase_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_EventCallbackList_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_EventCallbackFunctorBase_Int32_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}
