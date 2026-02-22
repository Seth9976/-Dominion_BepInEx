using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050D RID: 1293
	public class ActivityTracker : Object
	{
		// Token: 0x06004AAB RID: 19115 RVA: 0x00155F38 File Offset: 0x00154138
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityTracker()
		{
			Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ActivityTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr);
			ActivityTracker.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "m_current");
			ActivityTracker.NativeFieldInfoPtr_m_checkedForEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "m_checkedForEnable");
			ActivityTracker.NativeFieldInfoPtr_s_activityTrackerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "s_activityTrackerInstance");
			ActivityTracker.NativeFieldInfoPtr_m_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "m_nextId");
			ActivityTracker.NativeMethodInfoPtr_OnStart_Public_Void_String_String_Int32_byref_Guid_byref_Guid_EventActivityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674352);
			ActivityTracker.NativeMethodInfoPtr_OnStop_Public_Void_String_String_Int32_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674353);
			ActivityTracker.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674354);
			ActivityTracker.NativeMethodInfoPtr_get_Instance_Public_Static_get_ActivityTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674355);
			ActivityTracker.NativeMethodInfoPtr_FindActiveActivity_Private_ActivityInfo_String_ActivityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674356);
			ActivityTracker.NativeMethodInfoPtr_NormalizeActivityName_Private_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674357);
			ActivityTracker.NativeMethodInfoPtr_ActivityChanging_Private_Void_AsyncLocalValueChangedArgs_1_ActivityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674358);
			ActivityTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674359);
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x00156058 File Offset: 0x00154258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372691, RefRangeEnd = 372693, XrefRangeStart = 372638, XrefRangeEnd = 372691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref task;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &activityId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &relatedActivityId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_OnStart_Public_Void_String_String_Int32_byref_Guid_byref_Guid_EventActivityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x001560E8 File Offset: 0x001542E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372725, RefRangeEnd = 372728, XrefRangeStart = 372693, XrefRangeEnd = 372725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStop(string providerName, string activityName, int task, ref Guid activityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref task;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &activityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_OnStop_Public_Void_String_String_Int32_byref_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x0015615C File Offset: 0x0015435C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372728, XrefRangeEnd = 372742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06004AAF RID: 19119 RVA: 0x00156190 File Offset: 0x00154390
		public unsafe static ActivityTracker Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372742, XrefRangeEnd = 372746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_get_Instance_Public_Static_get_ActivityTracker_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivityTracker>(intPtr3) : null;
			}
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x001561C4 File Offset: 0x001543C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372746, XrefRangeEnd = 372747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityTracker.ActivityInfo FindActiveActivity(string name, ActivityTracker.ActivityInfo startLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_FindActiveActivity_Private_ActivityInfo_String_ActivityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivityTracker.ActivityInfo>(intPtr3) : null;
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00156228 File Offset: 0x00154428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372763, RefRangeEnd = 372765, XrefRangeStart = 372747, XrefRangeEnd = 372763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NormalizeActivityName(string providerName, string activityName, int task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref task;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_NormalizeActivityName_Private_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00156290 File Offset: 0x00154490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372765, XrefRangeEnd = 372773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivityChanging(AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_ActivityChanging_Private_Void_AsyncLocalValueChangedArgs_1_ActivityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x001562D8 File Offset: 0x001544D8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityTracker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x0001C07A File Offset: 0x0001A27A
		public ActivityTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06004AB5 RID: 19125 RVA: 0x00156314 File Offset: 0x00154514
		// (set) Token: 0x06004AB6 RID: 19126 RVA: 0x0001C083 File Offset: 0x0001A283
		public unsafe AsyncLocal<ActivityTracker.ActivityInfo> m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.NativeFieldInfoPtr_m_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<ActivityTracker.ActivityInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.NativeFieldInfoPtr_m_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06004AB7 RID: 19127 RVA: 0x00156344 File Offset: 0x00154544
		// (set) Token: 0x06004AB8 RID: 19128 RVA: 0x0001C0A2 File Offset: 0x0001A2A2
		public unsafe bool m_checkedForEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.NativeFieldInfoPtr_m_checkedForEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.NativeFieldInfoPtr_m_checkedForEnable)) = value;
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06004AB9 RID: 19129 RVA: 0x0015636C File Offset: 0x0015456C
		// (set) Token: 0x06004ABA RID: 19130 RVA: 0x0001C0BD File Offset: 0x0001A2BD
		public unsafe static ActivityTracker s_activityTrackerInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActivityTracker.NativeFieldInfoPtr_s_activityTrackerInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityTracker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActivityTracker.NativeFieldInfoPtr_s_activityTrackerInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x00156394 File Offset: 0x00154594
		// (set) Token: 0x06004ABC RID: 19132 RVA: 0x0001C0CF File Offset: 0x0001A2CF
		public unsafe static long m_nextId
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ActivityTracker.NativeFieldInfoPtr_m_nextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActivityTracker.NativeFieldInfoPtr_m_nextId, (void*)(&value));
			}
		}

		// Token: 0x04003C45 RID: 15429
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x04003C46 RID: 15430
		private static readonly IntPtr NativeFieldInfoPtr_m_checkedForEnable;

		// Token: 0x04003C47 RID: 15431
		private static readonly IntPtr NativeFieldInfoPtr_s_activityTrackerInstance;

		// Token: 0x04003C48 RID: 15432
		private static readonly IntPtr NativeFieldInfoPtr_m_nextId;

		// Token: 0x04003C49 RID: 15433
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Public_Void_String_String_Int32_byref_Guid_byref_Guid_EventActivityOptions_0;

		// Token: 0x04003C4A RID: 15434
		private static readonly IntPtr NativeMethodInfoPtr_OnStop_Public_Void_String_String_Int32_byref_Guid_0;

		// Token: 0x04003C4B RID: 15435
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x04003C4C RID: 15436
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ActivityTracker_0;

		// Token: 0x04003C4D RID: 15437
		private static readonly IntPtr NativeMethodInfoPtr_FindActiveActivity_Private_ActivityInfo_String_ActivityInfo_0;

		// Token: 0x04003C4E RID: 15438
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeActivityName_Private_String_String_String_Int32_0;

		// Token: 0x04003C4F RID: 15439
		private static readonly IntPtr NativeMethodInfoPtr_ActivityChanging_Private_Void_AsyncLocalValueChangedArgs_1_ActivityInfo_0;

		// Token: 0x04003C50 RID: 15440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200067A RID: 1658
		public class ActivityInfo : Object
		{
			// Token: 0x060056EA RID: 22250 RVA: 0x0017EE44 File Offset: 0x0017D044
			// Note: this type is marked as 'beforefieldinit'.
			static ActivityInfo()
			{
				Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "ActivityInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr);
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_name");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_uniqueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_uniqueId");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_guid");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityPathGuidOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_activityPathGuidOffset");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_level");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_eventOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_eventOptions");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_lastChildID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_lastChildID");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_stopped");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_creator");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityIdToRestore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_activityIdToRestore");
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_ActivityInfo_Guid_EventActivityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674361);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_get_ActivityId_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674362);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_Path_Public_Static_String_ActivityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674363);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674364);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_LiveActivities_Public_Static_String_ActivityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674365);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CanBeOrphan_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674366);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CreateActivityPathGuid_Private_Void_byref_Guid_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674367);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CreateOverflowGuid_Private_Void_ptr_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674368);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_AddIdToGuid_Private_Static_Int32_ptr_Guid_Int32_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674369);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_WriteNibble_Private_Static_Void_byref_ptr_Byte_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674370);
			}

			// Token: 0x060056EB RID: 22251 RVA: 0x0017F000 File Offset: 0x0017D200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372542, XrefRangeEnd = 372550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActivityInfo(string name, long uniqueId, ActivityTracker.ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(creator);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIDToRestore;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_ActivityInfo_Guid_EventActivityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001667 RID: 5735
			// (get) Token: 0x060056EC RID: 22252 RVA: 0x0017F088 File Offset: 0x0017D288
			public unsafe Guid ActivityId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_get_ActivityId_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056ED RID: 22253 RVA: 0x0017F0C4 File Offset: 0x0017D2C4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 372558, RefRangeEnd = 372560, XrefRangeStart = 372550, XrefRangeEnd = 372558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Path(ActivityTracker.ActivityInfo activityInfo)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(activityInfo);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_Path_Public_Static_String_ActivityInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060056EE RID: 22254 RVA: 0x0017F100 File Offset: 0x0017D300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372560, XrefRangeEnd = 372608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivityTracker.ActivityInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060056EF RID: 22255 RVA: 0x0017F144 File Offset: 0x0017D344
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372614, RefRangeEnd = 372617, XrefRangeStart = 372608, XrefRangeEnd = 372614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string LiveActivities(ActivityTracker.ActivityInfo list)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_LiveActivities_Public_Static_String_ActivityInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060056F0 RID: 22256 RVA: 0x0017F180 File Offset: 0x0017D380
			[CallerCount(0)]
			public unsafe bool CanBeOrphan()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CanBeOrphan_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060056F1 RID: 22257 RVA: 0x0017F1BC File Offset: 0x0017D3BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372617, XrefRangeEnd = 372623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &idRet;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &activityPathGuidOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CreateActivityPathGuid_Private_Void_byref_Guid_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F2 RID: 22258 RVA: 0x0017F208 File Offset: 0x0017D408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372623, XrefRangeEnd = 372625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CreateOverflowGuid(Guid* outPtr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = outPtr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CreateOverflowGuid_Private_Void_ptr_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056F3 RID: 22259 RVA: 0x0017F248 File Offset: 0x0017D448
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 372631, RefRangeEnd = 372638, XrefRangeStart = 372625, XrefRangeEnd = 372631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = false)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = outPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref whereToAddId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overflow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_AddIdToGuid_Private_Static_Int32_ptr_Guid_Int32_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060056F4 RID: 22260 RVA: 0x0017F2B0 File Offset: 0x0017D4B0
			[CallerCount(0)]
			public unsafe static void WriteNibble(ref byte* ptr, byte* endPtr, uint value)
			{
				IntPtr* ptr2;
				IntPtr intPtr;
				checked
				{
					ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr3 = ref *ptr2;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(ptr);
					ptr3 = &intPtr;
				}
				ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = endPtr;
				ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_WriteNibble_Private_Static_Void_byref_ptr_Byte_ptr_Byte_UInt32_0, 0, (void**)ptr2, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				ptr = ((intPtr4 == 0) ? null : new byte*(intPtr4));
			}

			// Token: 0x060056F5 RID: 22261 RVA: 0x000219F2 File Offset: 0x0001FBF2
			public ActivityInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700165D RID: 5725
			// (get) Token: 0x060056F6 RID: 22262 RVA: 0x0017F318 File Offset: 0x0017D518
			// (set) Token: 0x060056F7 RID: 22263 RVA: 0x000219FB File Offset: 0x0001FBFB
			public unsafe string m_name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700165E RID: 5726
			// (get) Token: 0x060056F8 RID: 22264 RVA: 0x0017F340 File Offset: 0x0017D540
			// (set) Token: 0x060056F9 RID: 22265 RVA: 0x00021A1A File Offset: 0x0001FC1A
			public unsafe long m_uniqueId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_uniqueId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_uniqueId)) = value;
				}
			}

			// Token: 0x1700165F RID: 5727
			// (get) Token: 0x060056FA RID: 22266 RVA: 0x0017F368 File Offset: 0x0017D568
			// (set) Token: 0x060056FB RID: 22267 RVA: 0x00021A35 File Offset: 0x0001FC35
			public unsafe Guid m_guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_guid)) = value;
				}
			}

			// Token: 0x17001660 RID: 5728
			// (get) Token: 0x060056FC RID: 22268 RVA: 0x0017F390 File Offset: 0x0017D590
			// (set) Token: 0x060056FD RID: 22269 RVA: 0x00021A50 File Offset: 0x0001FC50
			public unsafe int m_activityPathGuidOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityPathGuidOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityPathGuidOffset)) = value;
				}
			}

			// Token: 0x17001661 RID: 5729
			// (get) Token: 0x060056FE RID: 22270 RVA: 0x0017F3B8 File Offset: 0x0017D5B8
			// (set) Token: 0x060056FF RID: 22271 RVA: 0x00021A6B File Offset: 0x0001FC6B
			public unsafe int m_level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_level)) = value;
				}
			}

			// Token: 0x17001662 RID: 5730
			// (get) Token: 0x06005700 RID: 22272 RVA: 0x0017F3E0 File Offset: 0x0017D5E0
			// (set) Token: 0x06005701 RID: 22273 RVA: 0x00021A86 File Offset: 0x0001FC86
			public unsafe EventActivityOptions m_eventOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_eventOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_eventOptions)) = value;
				}
			}

			// Token: 0x17001663 RID: 5731
			// (get) Token: 0x06005702 RID: 22274 RVA: 0x0017F408 File Offset: 0x0017D608
			// (set) Token: 0x06005703 RID: 22275 RVA: 0x00021AA1 File Offset: 0x0001FCA1
			public unsafe long m_lastChildID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_lastChildID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_lastChildID)) = value;
				}
			}

			// Token: 0x17001664 RID: 5732
			// (get) Token: 0x06005704 RID: 22276 RVA: 0x0017F430 File Offset: 0x0017D630
			// (set) Token: 0x06005705 RID: 22277 RVA: 0x00021ABC File Offset: 0x0001FCBC
			public unsafe int m_stopped
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_stopped);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_stopped)) = value;
				}
			}

			// Token: 0x17001665 RID: 5733
			// (get) Token: 0x06005706 RID: 22278 RVA: 0x0017F458 File Offset: 0x0017D658
			// (set) Token: 0x06005707 RID: 22279 RVA: 0x00021AD7 File Offset: 0x0001FCD7
			public unsafe ActivityTracker.ActivityInfo m_creator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_creator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityTracker.ActivityInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_creator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001666 RID: 5734
			// (get) Token: 0x06005708 RID: 22280 RVA: 0x0017F488 File Offset: 0x0017D688
			// (set) Token: 0x06005709 RID: 22281 RVA: 0x00021AF6 File Offset: 0x0001FCF6
			public unsafe Guid m_activityIdToRestore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityIdToRestore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityIdToRestore)) = value;
				}
			}

			// Token: 0x04004598 RID: 17816
			private static readonly IntPtr NativeFieldInfoPtr_m_name;

			// Token: 0x04004599 RID: 17817
			private static readonly IntPtr NativeFieldInfoPtr_m_uniqueId;

			// Token: 0x0400459A RID: 17818
			private static readonly IntPtr NativeFieldInfoPtr_m_guid;

			// Token: 0x0400459B RID: 17819
			private static readonly IntPtr NativeFieldInfoPtr_m_activityPathGuidOffset;

			// Token: 0x0400459C RID: 17820
			private static readonly IntPtr NativeFieldInfoPtr_m_level;

			// Token: 0x0400459D RID: 17821
			private static readonly IntPtr NativeFieldInfoPtr_m_eventOptions;

			// Token: 0x0400459E RID: 17822
			private static readonly IntPtr NativeFieldInfoPtr_m_lastChildID;

			// Token: 0x0400459F RID: 17823
			private static readonly IntPtr NativeFieldInfoPtr_m_stopped;

			// Token: 0x040045A0 RID: 17824
			private static readonly IntPtr NativeFieldInfoPtr_m_creator;

			// Token: 0x040045A1 RID: 17825
			private static readonly IntPtr NativeFieldInfoPtr_m_activityIdToRestore;

			// Token: 0x040045A2 RID: 17826
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int64_ActivityInfo_Guid_EventActivityOptions_0;

			// Token: 0x040045A3 RID: 17827
			private static readonly IntPtr NativeMethodInfoPtr_get_ActivityId_Public_get_Guid_0;

			// Token: 0x040045A4 RID: 17828
			private static readonly IntPtr NativeMethodInfoPtr_Path_Public_Static_String_ActivityInfo_0;

			// Token: 0x040045A5 RID: 17829
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040045A6 RID: 17830
			private static readonly IntPtr NativeMethodInfoPtr_LiveActivities_Public_Static_String_ActivityInfo_0;

			// Token: 0x040045A7 RID: 17831
			private static readonly IntPtr NativeMethodInfoPtr_CanBeOrphan_Public_Boolean_0;

			// Token: 0x040045A8 RID: 17832
			private static readonly IntPtr NativeMethodInfoPtr_CreateActivityPathGuid_Private_Void_byref_Guid_byref_Int32_0;

			// Token: 0x040045A9 RID: 17833
			private static readonly IntPtr NativeMethodInfoPtr_CreateOverflowGuid_Private_Void_ptr_Guid_0;

			// Token: 0x040045AA RID: 17834
			private static readonly IntPtr NativeMethodInfoPtr_AddIdToGuid_Private_Static_Int32_ptr_Guid_Int32_UInt32_Boolean_0;

			// Token: 0x040045AB RID: 17835
			private static readonly IntPtr NativeMethodInfoPtr_WriteNibble_Private_Static_Void_byref_ptr_Byte_ptr_Byte_UInt32_0;
		}
	}
}
