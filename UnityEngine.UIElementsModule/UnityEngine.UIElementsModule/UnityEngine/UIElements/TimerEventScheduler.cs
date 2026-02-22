using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000028 RID: 40
	public class TimerEventScheduler : Object
	{
		// Token: 0x060002AB RID: 683 RVA: 0x000146B0 File Offset: 0x000128B0
		// Note: this type is marked as 'beforefieldinit'.
		static TimerEventScheduler()
		{
			Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TimerEventScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr);
			TimerEventScheduler.NativeFieldInfoPtr_m_ScheduledItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_ScheduledItems");
			TimerEventScheduler.NativeFieldInfoPtr_m_TransactionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_TransactionMode");
			TimerEventScheduler.NativeFieldInfoPtr_m_ScheduleTransactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_ScheduleTransactions");
			TimerEventScheduler.NativeFieldInfoPtr_m_UnscheduleTransactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_UnscheduleTransactions");
			TimerEventScheduler.NativeFieldInfoPtr_disableThrottling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "disableThrottling");
			TimerEventScheduler.NativeFieldInfoPtr_m_LastUpdatedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_LastUpdatedIndex");
			TimerEventScheduler.NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100663517);
			TimerEventScheduler.NativeMethodInfoPtr_RemovedScheduledItemAt_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100663518);
			TimerEventScheduler.NativeMethodInfoPtr_Unschedule_Public_Virtual_Final_New_Void_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100663519);
			TimerEventScheduler.NativeMethodInfoPtr_PrivateUnSchedule_Private_Boolean_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100663520);
			TimerEventScheduler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100663521);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000147BC File Offset: 0x000129BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92288, XrefRangeEnd = 92295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Schedule(ScheduledItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_ScheduledItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00014800 File Offset: 0x00012A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92295, XrefRangeEnd = 92296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemovedScheduledItemAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_RemovedScheduledItemAt_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0001484C File Offset: 0x00012A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92296, XrefRangeEnd = 92318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unschedule(ScheduledItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_Unschedule_Public_Virtual_Final_New_Void_ScheduledItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00014890 File Offset: 0x00012A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92318, XrefRangeEnd = 92325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrivateUnSchedule(ScheduledItem sItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_PrivateUnSchedule_Private_Boolean_ScheduledItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000148E0 File Offset: 0x00012AE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92342, RefRangeEnd = 92344, XrefRangeStart = 92325, XrefRangeEnd = 92342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerEventScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003586 File Offset: 0x00001786
		public TimerEventScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001491C File Offset: 0x00012B1C
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000358F File Offset: 0x0000178F
		public unsafe List<ScheduledItem> m_ScheduledItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_ScheduledItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScheduledItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_ScheduledItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0001494C File Offset: 0x00012B4C
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000035AE File Offset: 0x000017AE
		public unsafe bool m_TransactionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_TransactionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_TransactionMode)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00014974 File Offset: 0x00012B74
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x000035C9 File Offset: 0x000017C9
		public unsafe List<ScheduledItem> m_ScheduleTransactions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_ScheduleTransactions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScheduledItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_ScheduleTransactions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x000149A4 File Offset: 0x00012BA4
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x000035E8 File Offset: 0x000017E8
		public unsafe HashSet<ScheduledItem> m_UnscheduleTransactions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_UnscheduleTransactions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ScheduledItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_UnscheduleTransactions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000149D4 File Offset: 0x00012BD4
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00003607 File Offset: 0x00001807
		public unsafe bool disableThrottling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_disableThrottling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_disableThrottling)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000149FC File Offset: 0x00012BFC
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00003622 File Offset: 0x00001822
		public unsafe int m_LastUpdatedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_LastUpdatedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_LastUpdatedIndex)) = value;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000363D File Offset: 0x0000183D
		public void UpdateScheduledEvents()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_m_ScheduledItems;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_m_TransactionMode;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_m_ScheduleTransactions;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_m_UnscheduleTransactions;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_disableThrottling;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_m_LastUpdatedIndex;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_ScheduledItem_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_RemovedScheduledItemAt_Private_Boolean_Int32_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_Unschedule_Public_Virtual_Final_New_Void_ScheduledItem_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_PrivateUnSchedule_Private_Boolean_ScheduledItem_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001F3 RID: 499
		public class TimerEventSchedulerItem : ScheduledItem
		{
		}
	}
}
