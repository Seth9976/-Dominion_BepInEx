using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Fitness
{
	// Token: 0x02000336 RID: 822
	public class DeleteDataRequest : Object
	{
		// Token: 0x0600307C RID: 12412 RVA: 0x000CDD98 File Offset: 0x000CBF98
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteDataRequest()
		{
			Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "DeleteDataRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr);
			DeleteDataRequest.NativeFieldInfoPtr_OnRequestFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "OnRequestFinished");
			DeleteDataRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "id");
			DeleteDataRequest.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "startTime");
			DeleteDataRequest.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "endTime");
			DeleteDataRequest.NativeFieldInfoPtr_timeUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "timeUnit");
			DeleteDataRequest.NativeFieldInfoPtr_dataTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "dataTypes");
			DeleteDataRequest.NativeFieldInfoPtr_sessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "sessions");
			DeleteDataRequest.NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669673);
			DeleteDataRequest.NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669674);
			DeleteDataRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669675);
			DeleteDataRequest.NativeMethodInfoPtr_DispatchRequestResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669676);
			DeleteDataRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669677);
			DeleteDataRequest.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669678);
			DeleteDataRequest.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669679);
			DeleteDataRequest.NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669680);
			DeleteDataRequest.NativeMethodInfoPtr_get_DataTypes_Public_get_List_1_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669681);
			DeleteDataRequest.NativeMethodInfoPtr_get_Sessions_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, 100669682);
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x000CDF1C File Offset: 0x000CC11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221597, XrefRangeEnd = 221601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRequestFinished(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x000CDF60 File Offset: 0x000CC160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221601, XrefRangeEnd = 221605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRequestFinished(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x000CDFA4 File Offset: 0x000CC1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221633, RefRangeEnd = 221634, XrefRangeStart = 221605, XrefRangeEnd = 221633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteDataRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x000CDFE0 File Offset: 0x000CC1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221634, XrefRangeEnd = 221636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchRequestResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_DispatchRequestResult_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x000CE014 File Offset: 0x000CC214
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x000CE050 File Offset: 0x000CC250
		public unsafe long StartTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x000CE08C File Offset: 0x000CC28C
		public unsafe long EndTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x000CE0C8 File Offset: 0x000CC2C8
		public unsafe TimeUnit TimeUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x000CE104 File Offset: 0x000CC304
		public unsafe List<DataType> DataTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_get_DataTypes_Public_get_List_1_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x000CE144 File Offset: 0x000CC344
		public unsafe List<string> Sessions
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.NativeMethodInfoPtr_get_Sessions_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x00012935 File Offset: 0x00010B35
		public DeleteDataRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x000CE184 File Offset: 0x000CC384
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x0001293E File Offset: 0x00010B3E
		public unsafe Action OnRequestFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_OnRequestFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_OnRequestFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x000CE1B4 File Offset: 0x000CC3B4
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x0001295D File Offset: 0x00010B5D
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x000CE1DC File Offset: 0x000CC3DC
		// (set) Token: 0x0600308D RID: 12429 RVA: 0x00012978 File Offset: 0x00010B78
		public unsafe long startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x000CE204 File Offset: 0x000CC404
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x00012993 File Offset: 0x00010B93
		public unsafe long endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x000CE22C File Offset: 0x000CC42C
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x000129AE File Offset: 0x00010BAE
		public unsafe TimeUnit timeUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_timeUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_timeUnit)) = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x000CE254 File Offset: 0x000CC454
		// (set) Token: 0x06003093 RID: 12435 RVA: 0x000129C9 File Offset: 0x00010BC9
		public unsafe List<DataType> dataTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_dataTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_dataTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x000CE284 File Offset: 0x000CC484
		// (set) Token: 0x06003095 RID: 12437 RVA: 0x000129E8 File Offset: 0x00010BE8
		public unsafe List<string> sessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_sessions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.NativeFieldInfoPtr_sessions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E15 RID: 11797
		private static readonly IntPtr NativeFieldInfoPtr_OnRequestFinished;

		// Token: 0x04002E16 RID: 11798
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002E17 RID: 11799
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04002E18 RID: 11800
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04002E19 RID: 11801
		private static readonly IntPtr NativeFieldInfoPtr_timeUnit;

		// Token: 0x04002E1A RID: 11802
		private static readonly IntPtr NativeFieldInfoPtr_dataTypes;

		// Token: 0x04002E1B RID: 11803
		private static readonly IntPtr NativeFieldInfoPtr_sessions;

		// Token: 0x04002E1C RID: 11804
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_0;

		// Token: 0x04002E1D RID: 11805
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_0;

		// Token: 0x04002E1E RID: 11806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeMethodInfoPtr_DispatchRequestResult_Public_Void_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0;

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0;

		// Token: 0x04002E24 RID: 11812
		private static readonly IntPtr NativeMethodInfoPtr_get_DataTypes_Public_get_List_1_DataType_0;

		// Token: 0x04002E25 RID: 11813
		private static readonly IntPtr NativeMethodInfoPtr_get_Sessions_Public_get_List_1_String_0;

		// Token: 0x020003E1 RID: 993
		public class Builder : Object
		{
			// Token: 0x06003952 RID: 14674 RVA: 0x000E8608 File Offset: 0x000E6808
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr);
				DeleteDataRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr, "request");
				DeleteDataRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr, 100670524);
				DeleteDataRequest.Builder.NativeMethodInfoPtr_SetTimeInterval_Public_Builder_Int64_Int64_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr, 100670525);
				DeleteDataRequest.Builder.NativeMethodInfoPtr_AddDataType_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr, 100670526);
				DeleteDataRequest.Builder.NativeMethodInfoPtr_AddSession_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr, 100670527);
				DeleteDataRequest.Builder.NativeMethodInfoPtr_DeleteAllSessions_Public_Builder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr, 100670528);
				DeleteDataRequest.Builder.NativeMethodInfoPtr_Build_Public_DeleteDataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr, 100670529);
			}

			// Token: 0x06003953 RID: 14675 RVA: 0x000E86C0 File Offset: 0x000E68C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221576, XrefRangeEnd = 221581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteDataRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003954 RID: 14676 RVA: 0x000E86FC File Offset: 0x000E68FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221581, RefRangeEnd = 221582, XrefRangeStart = 221581, XrefRangeEnd = 221581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteDataRequest.Builder SetTimeInterval(long startTime, long endTime, TimeUnit unit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref startTime;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.Builder.NativeMethodInfoPtr_SetTimeInterval_Public_Builder_Int64_Int64_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDataRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x06003955 RID: 14677 RVA: 0x000E8764 File Offset: 0x000E6964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221582, XrefRangeEnd = 221588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteDataRequest.Builder AddDataType(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.Builder.NativeMethodInfoPtr_AddDataType_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDataRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003956 RID: 14678 RVA: 0x000E87B4 File Offset: 0x000E69B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221588, XrefRangeEnd = 221594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteDataRequest.Builder AddSession(string sessionId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(sessionId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.Builder.NativeMethodInfoPtr_AddSession_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDataRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003957 RID: 14679 RVA: 0x000E8804 File Offset: 0x000E6A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221594, XrefRangeEnd = 221597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteDataRequest.Builder DeleteAllSessions()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.Builder.NativeMethodInfoPtr_DeleteAllSessions_Public_Builder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDataRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x06003958 RID: 14680 RVA: 0x000E8844 File Offset: 0x000E6A44
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteDataRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.Builder.NativeMethodInfoPtr_Build_Public_DeleteDataRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDataRequest>(intPtr3) : null;
			}

			// Token: 0x06003959 RID: 14681 RVA: 0x00016324 File Offset: 0x00014524
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D98 RID: 3480
			// (get) Token: 0x0600395A RID: 14682 RVA: 0x000E8884 File Offset: 0x000E6A84
			// (set) Token: 0x0600395B RID: 14683 RVA: 0x0001632D File Offset: 0x0001452D
			public unsafe DeleteDataRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteDataRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDataRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003382 RID: 13186
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04003383 RID: 13187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003384 RID: 13188
			private static readonly IntPtr NativeMethodInfoPtr_SetTimeInterval_Public_Builder_Int64_Int64_TimeUnit_0;

			// Token: 0x04003385 RID: 13189
			private static readonly IntPtr NativeMethodInfoPtr_AddDataType_Public_Builder_DataType_0;

			// Token: 0x04003386 RID: 13190
			private static readonly IntPtr NativeMethodInfoPtr_AddSession_Public_Builder_String_0;

			// Token: 0x04003387 RID: 13191
			private static readonly IntPtr NativeMethodInfoPtr_DeleteAllSessions_Public_Builder_0;

			// Token: 0x04003388 RID: 13192
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_DeleteDataRequest_0;
		}

		// Token: 0x020003E2 RID: 994
		[ObfuscatedName("SA.Fitness.DeleteDataRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600395C RID: 14684 RVA: 0x000E88B4 File Offset: 0x000E6AB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeleteDataRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeleteDataRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteDataRequest.__c>.NativeClassPtr);
				DeleteDataRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest.__c>.NativeClassPtr, "<>9");
				DeleteDataRequest.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDataRequest.__c>.NativeClassPtr, "<>9__9_0");
				DeleteDataRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest.__c>.NativeClassPtr, 100670531);
				DeleteDataRequest.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDataRequest.__c>.NativeClassPtr, 100670532);
			}

			// Token: 0x0600395D RID: 14685 RVA: 0x000E8930 File Offset: 0x000E6B30
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteDataRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600395E RID: 14686 RVA: 0x000E896C File Offset: 0x000E6B6C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__9_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDataRequest.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600395F RID: 14687 RVA: 0x0001634C File Offset: 0x0001454C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D99 RID: 3481
			// (get) Token: 0x06003960 RID: 14688 RVA: 0x000E89A0 File Offset: 0x000E6BA0
			// (set) Token: 0x06003961 RID: 14689 RVA: 0x00016355 File Offset: 0x00014555
			public unsafe static DeleteDataRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeleteDataRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteDataRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeleteDataRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D9A RID: 3482
			// (get) Token: 0x06003962 RID: 14690 RVA: 0x000E89C8 File Offset: 0x000E6BC8
			// (set) Token: 0x06003963 RID: 14691 RVA: 0x00016367 File Offset: 0x00014567
			public unsafe static Action __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeleteDataRequest.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeleteDataRequest.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003389 RID: 13193
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400338A RID: 13194
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400338B RID: 13195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400338C RID: 13196
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_0;
		}
	}
}
