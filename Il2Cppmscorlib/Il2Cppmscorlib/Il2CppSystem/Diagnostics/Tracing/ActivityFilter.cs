using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051C RID: 1308
	public sealed class ActivityFilter : Object
	{
		// Token: 0x06004B99 RID: 19353 RVA: 0x00159380 File Offset: 0x00157580
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityFilter()
		{
			Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ActivityFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr);
			ActivityFilter.NativeFieldInfoPtr_m_activeActivities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_activeActivities");
			ActivityFilter.NativeFieldInfoPtr_m_rootActiveActivities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_rootActiveActivities");
			ActivityFilter.NativeFieldInfoPtr_m_providerGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_providerGuid");
			ActivityFilter.NativeFieldInfoPtr_m_eventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_eventId");
			ActivityFilter.NativeFieldInfoPtr_m_samplingFreq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_samplingFreq");
			ActivityFilter.NativeFieldInfoPtr_m_curSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_curSampleCount");
			ActivityFilter.NativeFieldInfoPtr_m_perEventSourceSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_perEventSourceSessionId");
			ActivityFilter.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_next");
			ActivityFilter.NativeFieldInfoPtr_m_myActivityDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_myActivityDelegate");
			ActivityFilter.NativeMethodInfoPtr_DisableFilter_Public_Static_Void_byref_ActivityFilter_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674467);
			ActivityFilter.NativeMethodInfoPtr_UpdateFilter_Public_Static_Void_byref_ActivityFilter_EventSource_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674468);
			ActivityFilter.NativeMethodInfoPtr_PassesActivityFilter_Public_Static_Boolean_ActivityFilter_ptr_Guid_Boolean_EventSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674469);
			ActivityFilter.NativeMethodInfoPtr_FlowActivityIfNeeded_Public_Static_Void_ActivityFilter_ptr_Guid_ptr_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674470);
			ActivityFilter.NativeMethodInfoPtr_UpdateKwdTriggers_Public_Static_Void_ActivityFilter_Guid_EventSource_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674471);
			ActivityFilter.NativeMethodInfoPtr_GetFilterAsTuple_Public_IEnumerable_1_Tuple_2_Int32_Int32_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674472);
			ActivityFilter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674473);
			ActivityFilter.NativeMethodInfoPtr__ctor_Private_Void_EventSource_Int32_Int32_Int32_ActivityFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674474);
			ActivityFilter.NativeMethodInfoPtr_EnsureActivityCleanupDelegate_Private_Static_Void_ActivityFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674475);
			ActivityFilter.NativeMethodInfoPtr_GetActivityDyingDelegate_Private_Static_Action_1_Guid_ActivityFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674476);
			ActivityFilter.NativeMethodInfoPtr_EnableFilter_Private_Static_Boolean_byref_ActivityFilter_EventSource_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674477);
			ActivityFilter.NativeMethodInfoPtr_TrimActiveActivityStore_Private_Static_Void_ConcurrentDictionary_2_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674478);
			ActivityFilter.NativeMethodInfoPtr_GetActiveActivities_Private_Static_ConcurrentDictionary_2_Guid_Int32_ActivityFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674479);
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x00159568 File Offset: 0x00157768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373514, RefRangeEnd = 373517, XrefRangeStart = 373491, XrefRangeEnd = 373514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableFilter(ref ActivityFilter filterList, EventSource source)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_DisableFilter_Public_Static_Void_byref_ActivityFilter_EventSource_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			filterList = ((intPtr4 == 0) ? null : new ActivityFilter(intPtr4));
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x001595C8 File Offset: 0x001577C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373547, RefRangeEnd = 373548, XrefRangeStart = 373517, XrefRangeEnd = 373547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(startEvents);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_UpdateFilter_Public_Static_Void_byref_ActivityFilter_EventSource_Int32_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			filterList = ((intPtr4 == 0) ? null : new ActivityFilter(intPtr4));
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x00159648 File Offset: 0x00157848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373587, RefRangeEnd = 373589, XrefRangeStart = 373548, XrefRangeEnd = 373587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggeringEvent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_PassesActivityFilter_Public_Static_Boolean_ActivityFilter_ptr_Guid_Boolean_EventSource_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x001596C4 File Offset: 0x001578C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373633, RefRangeEnd = 373634, XrefRangeStart = 373589, XrefRangeEnd = 373633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = currentActivityId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_FlowActivityIfNeeded_Public_Static_Void_ActivityFilter_ptr_Guid_ptr_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00159714 File Offset: 0x00157914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373641, RefRangeEnd = 373642, XrefRangeStart = 373634, XrefRangeEnd = 373641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activityFilter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceGuid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessKeywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_UpdateKwdTriggers_Public_Static_Void_ActivityFilter_Guid_EventSource_EventKeywords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00159778 File Offset: 0x00157978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373646, RefRangeEnd = 373647, XrefRangeStart = 373642, XrefRangeEnd = 373646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Tuple<int, int>> GetFilterAsTuple(Guid sourceGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_GetFilterAsTuple_Public_IEnumerable_1_Tuple_2_Int32_Int32_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Tuple<int, int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x001597C4 File Offset: 0x001579C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373655, RefRangeEnd = 373657, XrefRangeStart = 373647, XrefRangeEnd = 373655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x001597F8 File Offset: 0x001579F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373657, XrefRangeEnd = 373679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityFilter(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingFreq;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr__ctor_Private_Void_EventSource_Int32_Int32_Int32_ActivityFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA2 RID: 19362 RVA: 0x00159880 File Offset: 0x00157A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373679, XrefRangeEnd = 373688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureActivityCleanupDelegate(ActivityFilter filterList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_EnsureActivityCleanupDelegate_Private_Static_Void_ActivityFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x001598B8 File Offset: 0x00157AB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 373700, RefRangeEnd = 373704, XrefRangeStart = 373688, XrefRangeEnd = 373700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_GetActivityDyingDelegate_Private_Static_Action_1_Guid_ActivityFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Guid>>(intPtr3) : null;
			}
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x001598FC File Offset: 0x00157AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373733, RefRangeEnd = 373734, XrefRangeStart = 373704, XrefRangeEnd = 373733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingFreq;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_EnableFilter_Private_Static_Boolean_byref_ActivityFilter_EventSource_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			filterList = ((intPtr4 == 0) ? null : new ActivityFilter(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x00159990 File Offset: 0x00157B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373734, XrefRangeEnd = 373761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrimActiveActivityStore(ConcurrentDictionary<Guid, int> activities)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_TrimActiveActivityStore_Private_Static_Void_ConcurrentDictionary_2_Guid_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x001599C8 File Offset: 0x00157BC8
		[CallerCount(0)]
		public unsafe static ConcurrentDictionary<Guid, int> GetActiveActivities(ActivityFilter filterList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_GetActiveActivities_Private_Static_ConcurrentDictionary_2_Guid_Int32_ActivityFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Guid, int>>(intPtr3) : null;
			}
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x0001C74B File Offset: 0x0001A94B
		public ActivityFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06004BA8 RID: 19368 RVA: 0x00159A0C File Offset: 0x00157C0C
		// (set) Token: 0x06004BA9 RID: 19369 RVA: 0x0001C754 File Offset: 0x0001A954
		public unsafe ConcurrentDictionary<Guid, int> m_activeActivities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_activeActivities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Guid, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_activeActivities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x00159A3C File Offset: 0x00157C3C
		// (set) Token: 0x06004BAB RID: 19371 RVA: 0x0001C773 File Offset: 0x0001A973
		public unsafe ConcurrentDictionary<Guid, Tuple<Guid, int>> m_rootActiveActivities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_rootActiveActivities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Guid, Tuple<Guid, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_rootActiveActivities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06004BAC RID: 19372 RVA: 0x00159A6C File Offset: 0x00157C6C
		// (set) Token: 0x06004BAD RID: 19373 RVA: 0x0001C792 File Offset: 0x0001A992
		public unsafe Guid m_providerGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_providerGuid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_providerGuid)) = value;
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06004BAE RID: 19374 RVA: 0x00159A94 File Offset: 0x00157C94
		// (set) Token: 0x06004BAF RID: 19375 RVA: 0x0001C7AD File Offset: 0x0001A9AD
		public unsafe int m_eventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_eventId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_eventId)) = value;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06004BB0 RID: 19376 RVA: 0x00159ABC File Offset: 0x00157CBC
		// (set) Token: 0x06004BB1 RID: 19377 RVA: 0x0001C7C8 File Offset: 0x0001A9C8
		public unsafe int m_samplingFreq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_samplingFreq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_samplingFreq)) = value;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06004BB2 RID: 19378 RVA: 0x00159AE4 File Offset: 0x00157CE4
		// (set) Token: 0x06004BB3 RID: 19379 RVA: 0x0001C7E3 File Offset: 0x0001A9E3
		public unsafe int m_curSampleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_curSampleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_curSampleCount)) = value;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06004BB4 RID: 19380 RVA: 0x00159B0C File Offset: 0x00157D0C
		// (set) Token: 0x06004BB5 RID: 19381 RVA: 0x0001C7FE File Offset: 0x0001A9FE
		public unsafe int m_perEventSourceSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_perEventSourceSessionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_perEventSourceSessionId)) = value;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x00159B34 File Offset: 0x00157D34
		// (set) Token: 0x06004BB7 RID: 19383 RVA: 0x0001C819 File Offset: 0x0001AA19
		public unsafe ActivityFilter m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06004BB8 RID: 19384 RVA: 0x00159B64 File Offset: 0x00157D64
		// (set) Token: 0x06004BB9 RID: 19385 RVA: 0x0001C838 File Offset: 0x0001AA38
		public unsafe Action<Guid> m_myActivityDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_myActivityDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Guid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_myActivityDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D05 RID: 15621
		private static readonly IntPtr NativeFieldInfoPtr_m_activeActivities;

		// Token: 0x04003D06 RID: 15622
		private static readonly IntPtr NativeFieldInfoPtr_m_rootActiveActivities;

		// Token: 0x04003D07 RID: 15623
		private static readonly IntPtr NativeFieldInfoPtr_m_providerGuid;

		// Token: 0x04003D08 RID: 15624
		private static readonly IntPtr NativeFieldInfoPtr_m_eventId;

		// Token: 0x04003D09 RID: 15625
		private static readonly IntPtr NativeFieldInfoPtr_m_samplingFreq;

		// Token: 0x04003D0A RID: 15626
		private static readonly IntPtr NativeFieldInfoPtr_m_curSampleCount;

		// Token: 0x04003D0B RID: 15627
		private static readonly IntPtr NativeFieldInfoPtr_m_perEventSourceSessionId;

		// Token: 0x04003D0C RID: 15628
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x04003D0D RID: 15629
		private static readonly IntPtr NativeFieldInfoPtr_m_myActivityDelegate;

		// Token: 0x04003D0E RID: 15630
		private static readonly IntPtr NativeMethodInfoPtr_DisableFilter_Public_Static_Void_byref_ActivityFilter_EventSource_0;

		// Token: 0x04003D0F RID: 15631
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFilter_Public_Static_Void_byref_ActivityFilter_EventSource_Int32_String_0;

		// Token: 0x04003D10 RID: 15632
		private static readonly IntPtr NativeMethodInfoPtr_PassesActivityFilter_Public_Static_Boolean_ActivityFilter_ptr_Guid_Boolean_EventSource_Int32_0;

		// Token: 0x04003D11 RID: 15633
		private static readonly IntPtr NativeMethodInfoPtr_FlowActivityIfNeeded_Public_Static_Void_ActivityFilter_ptr_Guid_ptr_Guid_0;

		// Token: 0x04003D12 RID: 15634
		private static readonly IntPtr NativeMethodInfoPtr_UpdateKwdTriggers_Public_Static_Void_ActivityFilter_Guid_EventSource_EventKeywords_0;

		// Token: 0x04003D13 RID: 15635
		private static readonly IntPtr NativeMethodInfoPtr_GetFilterAsTuple_Public_IEnumerable_1_Tuple_2_Int32_Int32_Guid_0;

		// Token: 0x04003D14 RID: 15636
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003D15 RID: 15637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_EventSource_Int32_Int32_Int32_ActivityFilter_0;

		// Token: 0x04003D16 RID: 15638
		private static readonly IntPtr NativeMethodInfoPtr_EnsureActivityCleanupDelegate_Private_Static_Void_ActivityFilter_0;

		// Token: 0x04003D17 RID: 15639
		private static readonly IntPtr NativeMethodInfoPtr_GetActivityDyingDelegate_Private_Static_Action_1_Guid_ActivityFilter_0;

		// Token: 0x04003D18 RID: 15640
		private static readonly IntPtr NativeMethodInfoPtr_EnableFilter_Private_Static_Boolean_byref_ActivityFilter_EventSource_Int32_Int32_Int32_0;

		// Token: 0x04003D19 RID: 15641
		private static readonly IntPtr NativeMethodInfoPtr_TrimActiveActivityStore_Private_Static_Void_ConcurrentDictionary_2_Guid_Int32_0;

		// Token: 0x04003D1A RID: 15642
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActivities_Private_Static_ConcurrentDictionary_2_Guid_Int32_ActivityFilter_0;

		// Token: 0x02000681 RID: 1665
		[ObfuscatedName("System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__7")]
		public sealed class _GetFilterAsTuple_d__7 : Object
		{
			// Token: 0x0600571C RID: 22300 RVA: 0x0017F748 File Offset: 0x0017D948
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFilterAsTuple_d__7()
			{
				Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "<GetFilterAsTuple>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr);
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>1__state");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>2__current");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>l__initialThreadId");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>4__this");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr_sourceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "sourceGuid");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___3__sourceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>3__sourceGuid");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr__af_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<af>5__1");
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674480);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674481);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674482);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Tuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674483);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674484);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674485);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Tuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674486);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674487);
			}

			// Token: 0x0600571D RID: 22301 RVA: 0x0017F8A0 File Offset: 0x0017DAA0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 254576, RefRangeEnd = 254582, XrefRangeStart = 254576, XrefRangeEnd = 254582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFilterAsTuple_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600571E RID: 22302 RVA: 0x0017F8E8 File Offset: 0x0017DAE8
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600571F RID: 22303 RVA: 0x0017F91C File Offset: 0x0017DB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373464, XrefRangeEnd = 373472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001671 RID: 5745
			// (get) Token: 0x06005720 RID: 22304 RVA: 0x0017F958 File Offset: 0x0017DB58
			public unsafe Tuple<int, int> prop_Tuple_2_Int32_Int32_0
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Tuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<int, int>>(intPtr3) : null;
				}
			}

			// Token: 0x06005721 RID: 22305 RVA: 0x0017F998 File Offset: 0x0017DB98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373472, XrefRangeEnd = 373477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001672 RID: 5746
			// (get) Token: 0x06005722 RID: 22306 RVA: 0x0017F9CC File Offset: 0x0017DBCC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005723 RID: 22307 RVA: 0x0017FA0C File Offset: 0x0017DC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373477, XrefRangeEnd = 373484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Tuple<int, int>> Method_Private_Virtual_Final_New_IEnumerator_1_Tuple_2_Int32_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Tuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Tuple<int, int>>>(intPtr3) : null;
			}

			// Token: 0x06005724 RID: 22308 RVA: 0x0017FA4C File Offset: 0x0017DC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005725 RID: 22309 RVA: 0x00021BE5 File Offset: 0x0001FDE5
			public _GetFilterAsTuple_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700166A RID: 5738
			// (get) Token: 0x06005726 RID: 22310 RVA: 0x0017FA8C File Offset: 0x0017DC8C
			// (set) Token: 0x06005727 RID: 22311 RVA: 0x00021BEE File Offset: 0x0001FDEE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700166B RID: 5739
			// (get) Token: 0x06005728 RID: 22312 RVA: 0x0017FAB4 File Offset: 0x0017DCB4
			// (set) Token: 0x06005729 RID: 22313 RVA: 0x00021C09 File Offset: 0x0001FE09
			public unsafe Tuple<int, int> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166C RID: 5740
			// (get) Token: 0x0600572A RID: 22314 RVA: 0x0017FAE4 File Offset: 0x0017DCE4
			// (set) Token: 0x0600572B RID: 22315 RVA: 0x00021C28 File Offset: 0x0001FE28
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700166D RID: 5741
			// (get) Token: 0x0600572C RID: 22316 RVA: 0x0017FB0C File Offset: 0x0017DD0C
			// (set) Token: 0x0600572D RID: 22317 RVA: 0x00021C43 File Offset: 0x0001FE43
			public unsafe ActivityFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166E RID: 5742
			// (get) Token: 0x0600572E RID: 22318 RVA: 0x0017FB3C File Offset: 0x0017DD3C
			// (set) Token: 0x0600572F RID: 22319 RVA: 0x00021C62 File Offset: 0x0001FE62
			public unsafe Guid sourceGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr_sourceGuid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr_sourceGuid)) = value;
				}
			}

			// Token: 0x1700166F RID: 5743
			// (get) Token: 0x06005730 RID: 22320 RVA: 0x0017FB64 File Offset: 0x0017DD64
			// (set) Token: 0x06005731 RID: 22321 RVA: 0x00021C7D File Offset: 0x0001FE7D
			public unsafe Guid __3__sourceGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___3__sourceGuid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___3__sourceGuid)) = value;
				}
			}

			// Token: 0x17001670 RID: 5744
			// (get) Token: 0x06005732 RID: 22322 RVA: 0x0017FB8C File Offset: 0x0017DD8C
			// (set) Token: 0x06005733 RID: 22323 RVA: 0x00021C98 File Offset: 0x0001FE98
			public unsafe ActivityFilter _af_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr__af_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr__af_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045C3 RID: 17859
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040045C4 RID: 17860
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040045C5 RID: 17861
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040045C6 RID: 17862
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040045C7 RID: 17863
			private static readonly IntPtr NativeFieldInfoPtr_sourceGuid;

			// Token: 0x040045C8 RID: 17864
			private static readonly IntPtr NativeFieldInfoPtr___3__sourceGuid;

			// Token: 0x040045C9 RID: 17865
			private static readonly IntPtr NativeFieldInfoPtr__af_5__1;

			// Token: 0x040045CA RID: 17866
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040045CB RID: 17867
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045CC RID: 17868
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040045CD RID: 17869
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Tuple_2_Int32_Int32_0;

			// Token: 0x040045CE RID: 17870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045CF RID: 17871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040045D0 RID: 17872
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Tuple_2_Int32_Int32_0;

			// Token: 0x040045D1 RID: 17873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000682 RID: 1666
		[ObfuscatedName("System.Diagnostics.Tracing.ActivityFilter+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06005734 RID: 22324 RVA: 0x0017FBBC File Offset: 0x0017DDBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr);
				ActivityFilter.__c__DisplayClass11_0.NativeFieldInfoPtr_filterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr, "filterList");
				ActivityFilter.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr, 100674488);
				ActivityFilter.__c__DisplayClass11_0.NativeMethodInfoPtr__GetActivityDyingDelegate_b__0_Internal_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr, 100674489);
			}

			// Token: 0x06005735 RID: 22325 RVA: 0x0017FC24 File Offset: 0x0017DE24
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005736 RID: 22326 RVA: 0x0017FC60 File Offset: 0x0017DE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373484, XrefRangeEnd = 373490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetActivityDyingDelegate_b__0(Guid oldActivity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref oldActivity;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.__c__DisplayClass11_0.NativeMethodInfoPtr__GetActivityDyingDelegate_b__0_Internal_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005737 RID: 22327 RVA: 0x00021CB7 File Offset: 0x0001FEB7
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001673 RID: 5747
			// (get) Token: 0x06005738 RID: 22328 RVA: 0x0017FCA0 File Offset: 0x0017DEA0
			// (set) Token: 0x06005739 RID: 22329 RVA: 0x00021CC0 File Offset: 0x0001FEC0
			public unsafe ActivityFilter filterList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.__c__DisplayClass11_0.NativeFieldInfoPtr_filterList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.__c__DisplayClass11_0.NativeFieldInfoPtr_filterList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045D2 RID: 17874
			private static readonly IntPtr NativeFieldInfoPtr_filterList;

			// Token: 0x040045D3 RID: 17875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040045D4 RID: 17876
			private static readonly IntPtr NativeMethodInfoPtr__GetActivityDyingDelegate_b__0_Internal_Void_Guid_0;
		}

		// Token: 0x02000683 RID: 1667
		[ObfuscatedName("System.Diagnostics.Tracing.ActivityFilter+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600573A RID: 22330 RVA: 0x0017FCD0 File Offset: 0x0017DED0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr);
				ActivityFilter.__c__DisplayClass13_0.NativeFieldInfoPtr_tickNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr, "tickNow");
				ActivityFilter.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr, 100674490);
				ActivityFilter.__c__DisplayClass13_0.NativeMethodInfoPtr__TrimActiveActivityStore_b__0_Internal_Int32_KeyValuePair_2_Guid_Int32_KeyValuePair_2_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr, 100674491);
			}

			// Token: 0x0600573B RID: 22331 RVA: 0x0017FD38 File Offset: 0x0017DF38
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600573C RID: 22332 RVA: 0x0017FD74 File Offset: 0x0017DF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373490, XrefRangeEnd = 373491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TrimActiveActivityStore_b__0(KeyValuePair<Guid, int> x, KeyValuePair<Guid, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.__c__DisplayClass13_0.NativeMethodInfoPtr__TrimActiveActivityStore_b__0_Internal_Int32_KeyValuePair_2_Guid_Int32_KeyValuePair_2_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600573D RID: 22333 RVA: 0x00021CDF File Offset: 0x0001FEDF
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001674 RID: 5748
			// (get) Token: 0x0600573E RID: 22334 RVA: 0x0017FDE0 File Offset: 0x0017DFE0
			// (set) Token: 0x0600573F RID: 22335 RVA: 0x00021CE8 File Offset: 0x0001FEE8
			public unsafe int tickNow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.__c__DisplayClass13_0.NativeFieldInfoPtr_tickNow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.__c__DisplayClass13_0.NativeFieldInfoPtr_tickNow)) = value;
				}
			}

			// Token: 0x040045D5 RID: 17877
			private static readonly IntPtr NativeFieldInfoPtr_tickNow;

			// Token: 0x040045D6 RID: 17878
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040045D7 RID: 17879
			private static readonly IntPtr NativeMethodInfoPtr__TrimActiveActivityStore_b__0_Internal_Int32_KeyValuePair_2_Guid_Int32_KeyValuePair_2_Guid_Int32_0;
		}
	}
}
