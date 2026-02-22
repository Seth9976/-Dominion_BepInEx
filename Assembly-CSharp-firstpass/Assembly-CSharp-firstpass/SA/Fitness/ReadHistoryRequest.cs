using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x0200033C RID: 828
	public class ReadHistoryRequest : Object
	{
		// Token: 0x060031D6 RID: 12758 RVA: 0x000D0DE4 File Offset: 0x000CEFE4
		// Note: this type is marked as 'beforefieldinit'.
		static ReadHistoryRequest()
		{
			Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "ReadHistoryRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr);
			ReadHistoryRequest.NativeFieldInfoPtr_OnReadFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "OnReadFinished");
			ReadHistoryRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "id");
			ReadHistoryRequest.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "startTime");
			ReadHistoryRequest.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "endTime");
			ReadHistoryRequest.NativeFieldInfoPtr_timeUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "timeUnit");
			ReadHistoryRequest.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "dataType");
			ReadHistoryRequest.NativeFieldInfoPtr_aggregateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "aggregateType");
			ReadHistoryRequest.NativeFieldInfoPtr_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "limit");
			ReadHistoryRequest.NativeFieldInfoPtr_isAggregated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "isAggregated");
			ReadHistoryRequest.NativeFieldInfoPtr_minDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "minDuration");
			ReadHistoryRequest.NativeFieldInfoPtr_bucketUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "bucketUnit");
			ReadHistoryRequest.NativeFieldInfoPtr_bucketingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "bucketingType");
			ReadHistoryRequest.NativeMethodInfoPtr_add_OnReadFinished_Public_add_Void_Action_1_ReadHistoryResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669712);
			ReadHistoryRequest.NativeMethodInfoPtr_remove_OnReadFinished_Public_rem_Void_Action_1_ReadHistoryResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669713);
			ReadHistoryRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669714);
			ReadHistoryRequest.NativeMethodInfoPtr_DispatchReadResult_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669715);
			ReadHistoryRequest.NativeMethodInfoPtr_DispatchAggregatedResult_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669716);
			ReadHistoryRequest.NativeMethodInfoPtr_get_IsAggregated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669717);
			ReadHistoryRequest.NativeMethodInfoPtr_get_BucketingType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669718);
			ReadHistoryRequest.NativeMethodInfoPtr_get_BucketUnit_Public_get_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669719);
			ReadHistoryRequest.NativeMethodInfoPtr_get_MinDuration_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669720);
			ReadHistoryRequest.NativeMethodInfoPtr_get_Limit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669721);
			ReadHistoryRequest.NativeMethodInfoPtr_get_AggregateType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669722);
			ReadHistoryRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669723);
			ReadHistoryRequest.NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669724);
			ReadHistoryRequest.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669725);
			ReadHistoryRequest.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669726);
			ReadHistoryRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, 100669727);
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000D1044 File Offset: 0x000CF244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221823, RefRangeEnd = 221824, XrefRangeStart = 221819, XrefRangeEnd = 221823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnReadFinished(Action<ReadHistoryResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_add_OnReadFinished_Public_add_Void_Action_1_ReadHistoryResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000D1088 File Offset: 0x000CF288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221824, XrefRangeEnd = 221828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnReadFinished(Action<ReadHistoryResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_remove_OnReadFinished_Public_rem_Void_Action_1_ReadHistoryResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000D10CC File Offset: 0x000CF2CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221846, RefRangeEnd = 221847, XrefRangeStart = 221828, XrefRangeEnd = 221846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadHistoryRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000D1108 File Offset: 0x000CF308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221941, RefRangeEnd = 221942, XrefRangeStart = 221847, XrefRangeEnd = 221941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchReadResult(Il2CppStringArray bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_DispatchReadResult_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000D114C File Offset: 0x000CF34C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222065, RefRangeEnd = 222066, XrefRangeStart = 221942, XrefRangeEnd = 222065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchAggregatedResult(Il2CppStringArray bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_DispatchAggregatedResult_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x000D1190 File Offset: 0x000CF390
		public unsafe bool IsAggregated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_IsAggregated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x000D11CC File Offset: 0x000CF3CC
		public unsafe Bucket.Type BucketingType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24292, RefRangeEnd = 24293, XrefRangeStart = 24292, XrefRangeEnd = 24293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_BucketingType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060031DE RID: 12766 RVA: 0x000D1208 File Offset: 0x000CF408
		public unsafe TimeUnit BucketUnit
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 12351, RefRangeEnd = 12355, XrefRangeStart = 12351, XrefRangeEnd = 12355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_BucketUnit_Public_get_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x000D1244 File Offset: 0x000CF444
		public unsafe int MinDuration
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 11932, RefRangeEnd = 11934, XrefRangeStart = 11932, XrefRangeEnd = 11934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_MinDuration_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x000D1280 File Offset: 0x000CF480
		public unsafe int Limit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 11837, RefRangeEnd = 11840, XrefRangeStart = 11837, XrefRangeEnd = 11840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_Limit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x000D12BC File Offset: 0x000CF4BC
		public unsafe DataType AggregateType
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_AggregateType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x000D12FC File Offset: 0x000CF4FC
		public unsafe DataType DataType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x000D133C File Offset: 0x000CF53C
		public unsafe TimeUnit TimeUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x000D1378 File Offset: 0x000CF578
		public unsafe long EndTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x000D13B4 File Offset: 0x000CF5B4
		public unsafe long StartTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x000D13F0 File Offset: 0x000CF5F0
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00013490 File Offset: 0x00011690
		public ReadHistoryRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x000D142C File Offset: 0x000CF62C
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x00013499 File Offset: 0x00011699
		public unsafe Action<ReadHistoryResult> OnReadFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_OnReadFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReadHistoryResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_OnReadFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x000D145C File Offset: 0x000CF65C
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x000134B8 File Offset: 0x000116B8
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x000D1484 File Offset: 0x000CF684
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x000134D3 File Offset: 0x000116D3
		public unsafe long startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x000D14AC File Offset: 0x000CF6AC
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x000134EE File Offset: 0x000116EE
		public unsafe long endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x000D14D4 File Offset: 0x000CF6D4
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x00013509 File Offset: 0x00011709
		public unsafe TimeUnit timeUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_timeUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_timeUnit)) = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x000D14FC File Offset: 0x000CF6FC
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x00013524 File Offset: 0x00011724
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x000D152C File Offset: 0x000CF72C
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x00013543 File Offset: 0x00011743
		public unsafe DataType aggregateType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_aggregateType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_aggregateType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060031F6 RID: 12790 RVA: 0x000D155C File Offset: 0x000CF75C
		// (set) Token: 0x060031F7 RID: 12791 RVA: 0x00013562 File Offset: 0x00011762
		public unsafe int limit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_limit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_limit)) = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x000D1584 File Offset: 0x000CF784
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x0001357D File Offset: 0x0001177D
		public unsafe bool isAggregated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_isAggregated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_isAggregated)) = value;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x000D15AC File Offset: 0x000CF7AC
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x00013598 File Offset: 0x00011798
		public unsafe int minDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_minDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_minDuration)) = value;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x000D15D4 File Offset: 0x000CF7D4
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x000135B3 File Offset: 0x000117B3
		public unsafe TimeUnit bucketUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_bucketUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_bucketUnit)) = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x000D15FC File Offset: 0x000CF7FC
		// (set) Token: 0x060031FF RID: 12799 RVA: 0x000135CE File Offset: 0x000117CE
		public unsafe Bucket.Type bucketingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_bucketingType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.NativeFieldInfoPtr_bucketingType)) = value;
			}
		}

		// Token: 0x04002ECE RID: 11982
		private static readonly IntPtr NativeFieldInfoPtr_OnReadFinished;

		// Token: 0x04002ECF RID: 11983
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeFieldInfoPtr_timeUnit;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeFieldInfoPtr_aggregateType;

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeFieldInfoPtr_limit;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeFieldInfoPtr_isAggregated;

		// Token: 0x04002ED7 RID: 11991
		private static readonly IntPtr NativeFieldInfoPtr_minDuration;

		// Token: 0x04002ED8 RID: 11992
		private static readonly IntPtr NativeFieldInfoPtr_bucketUnit;

		// Token: 0x04002ED9 RID: 11993
		private static readonly IntPtr NativeFieldInfoPtr_bucketingType;

		// Token: 0x04002EDA RID: 11994
		private static readonly IntPtr NativeMethodInfoPtr_add_OnReadFinished_Public_add_Void_Action_1_ReadHistoryResult_0;

		// Token: 0x04002EDB RID: 11995
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnReadFinished_Public_rem_Void_Action_1_ReadHistoryResult_0;

		// Token: 0x04002EDC RID: 11996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002EDD RID: 11997
		private static readonly IntPtr NativeMethodInfoPtr_DispatchReadResult_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002EDE RID: 11998
		private static readonly IntPtr NativeMethodInfoPtr_DispatchAggregatedResult_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002EDF RID: 11999
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAggregated_Public_get_Boolean_0;

		// Token: 0x04002EE0 RID: 12000
		private static readonly IntPtr NativeMethodInfoPtr_get_BucketingType_Public_get_Type_0;

		// Token: 0x04002EE1 RID: 12001
		private static readonly IntPtr NativeMethodInfoPtr_get_BucketUnit_Public_get_TimeUnit_0;

		// Token: 0x04002EE2 RID: 12002
		private static readonly IntPtr NativeMethodInfoPtr_get_MinDuration_Public_get_Int32_0;

		// Token: 0x04002EE3 RID: 12003
		private static readonly IntPtr NativeMethodInfoPtr_get_Limit_Public_get_Int32_0;

		// Token: 0x04002EE4 RID: 12004
		private static readonly IntPtr NativeMethodInfoPtr_get_AggregateType_Public_get_DataType_0;

		// Token: 0x04002EE5 RID: 12005
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x04002EE6 RID: 12006
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0;

		// Token: 0x04002EE7 RID: 12007
		private static readonly IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0;

		// Token: 0x04002EE8 RID: 12008
		private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0;

		// Token: 0x04002EE9 RID: 12009
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x020003E5 RID: 997
		public class Builder : Object
		{
			// Token: 0x06003973 RID: 14707 RVA: 0x000E8CB4 File Offset: 0x000E6EB4
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr);
				ReadHistoryRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, "request");
				ReadHistoryRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670539);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_Aggregate_Public_Builder_DataType_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670540);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_Read_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670541);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_BucketByActivitySegment_Public_Builder_Int32_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670542);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_BucketByActivityType_Public_Builder_Int32_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670543);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_BucketBySession_Public_Builder_Int32_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670544);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_BucketByTime_Public_Builder_Int32_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670545);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_SetLimit_Public_Builder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670546);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_SetTimeRange_Public_Builder_Int64_Int64_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670547);
				ReadHistoryRequest.Builder.NativeMethodInfoPtr_Build_Public_ReadHistoryRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr, 100670548);
			}

			// Token: 0x06003974 RID: 14708 RVA: 0x000E8DBC File Offset: 0x000E6FBC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221816, RefRangeEnd = 221817, XrefRangeStart = 221811, XrefRangeEnd = 221816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadHistoryRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003975 RID: 14709 RVA: 0x000E8DF8 File Offset: 0x000E6FF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221817, RefRangeEnd = 221818, XrefRangeStart = 221817, XrefRangeEnd = 221817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadHistoryRequest.Builder Aggregate(DataType inputDataType, DataType outputDataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDataType);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputDataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_Aggregate_Public_Builder_DataType_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x06003976 RID: 14710 RVA: 0x000E8E5C File Offset: 0x000E705C
			[CallerCount(0)]
			public unsafe ReadHistoryRequest.Builder Read(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_Read_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003977 RID: 14711 RVA: 0x000E8EAC File Offset: 0x000E70AC
			[CallerCount(0)]
			public unsafe ReadHistoryRequest.Builder BucketByActivitySegment(int minDuration, TimeUnit timeUnit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref minDuration;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUnit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_BucketByActivitySegment_Public_Builder_Int32_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x06003978 RID: 14712 RVA: 0x000E8F08 File Offset: 0x000E7108
			[CallerCount(0)]
			public unsafe ReadHistoryRequest.Builder BucketByActivityType(int minDuration, TimeUnit timeUnit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref minDuration;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUnit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_BucketByActivityType_Public_Builder_Int32_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x06003979 RID: 14713 RVA: 0x000E8F64 File Offset: 0x000E7164
			[CallerCount(0)]
			public unsafe ReadHistoryRequest.Builder BucketBySession(int minDuration, TimeUnit timeUnit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref minDuration;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUnit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_BucketBySession_Public_Builder_Int32_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x0600397A RID: 14714 RVA: 0x000E8FC0 File Offset: 0x000E71C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221818, RefRangeEnd = 221819, XrefRangeStart = 221818, XrefRangeEnd = 221818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadHistoryRequest.Builder BucketByTime(int minDuration, TimeUnit timeUnit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref minDuration;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUnit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_BucketByTime_Public_Builder_Int32_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x0600397B RID: 14715 RVA: 0x000E901C File Offset: 0x000E721C
			[CallerCount(0)]
			public unsafe ReadHistoryRequest.Builder SetLimit(int limit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref limit;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_SetLimit_Public_Builder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x0600397C RID: 14716 RVA: 0x000E9068 File Offset: 0x000E7268
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221581, RefRangeEnd = 221582, XrefRangeStart = 221581, XrefRangeEnd = 221582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadHistoryRequest.Builder SetTimeRange(long startTime, long endTime, TimeUnit unit)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_SetTimeRange_Public_Builder_Int64_Int64_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x0600397D RID: 14717 RVA: 0x000E90D0 File Offset: 0x000E72D0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadHistoryRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.Builder.NativeMethodInfoPtr_Build_Public_ReadHistoryRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest>(intPtr3) : null;
			}

			// Token: 0x0600397E RID: 14718 RVA: 0x000163CE File Offset: 0x000145CE
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x0600397F RID: 14719 RVA: 0x000E9110 File Offset: 0x000E7310
			// (set) Token: 0x06003980 RID: 14720 RVA: 0x000163D7 File Offset: 0x000145D7
			public unsafe ReadHistoryRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003395 RID: 13205
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04003396 RID: 13206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003397 RID: 13207
			private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Builder_DataType_DataType_0;

			// Token: 0x04003398 RID: 13208
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Builder_DataType_0;

			// Token: 0x04003399 RID: 13209
			private static readonly IntPtr NativeMethodInfoPtr_BucketByActivitySegment_Public_Builder_Int32_TimeUnit_0;

			// Token: 0x0400339A RID: 13210
			private static readonly IntPtr NativeMethodInfoPtr_BucketByActivityType_Public_Builder_Int32_TimeUnit_0;

			// Token: 0x0400339B RID: 13211
			private static readonly IntPtr NativeMethodInfoPtr_BucketBySession_Public_Builder_Int32_TimeUnit_0;

			// Token: 0x0400339C RID: 13212
			private static readonly IntPtr NativeMethodInfoPtr_BucketByTime_Public_Builder_Int32_TimeUnit_0;

			// Token: 0x0400339D RID: 13213
			private static readonly IntPtr NativeMethodInfoPtr_SetLimit_Public_Builder_Int32_0;

			// Token: 0x0400339E RID: 13214
			private static readonly IntPtr NativeMethodInfoPtr_SetTimeRange_Public_Builder_Int64_Int64_TimeUnit_0;

			// Token: 0x0400339F RID: 13215
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_ReadHistoryRequest_0;
		}

		// Token: 0x020003E6 RID: 998
		[ObfuscatedName("SA.Fitness.ReadHistoryRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003981 RID: 14721 RVA: 0x000E9140 File Offset: 0x000E7340
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReadHistoryRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadHistoryRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadHistoryRequest.__c>.NativeClassPtr);
				ReadHistoryRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest.__c>.NativeClassPtr, "<>9");
				ReadHistoryRequest.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryRequest.__c>.NativeClassPtr, "<>9__14_0");
				ReadHistoryRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.__c>.NativeClassPtr, 100670550);
				ReadHistoryRequest.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_ReadHistoryResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryRequest.__c>.NativeClassPtr, 100670551);
			}

			// Token: 0x06003982 RID: 14722 RVA: 0x000E91BC File Offset: 0x000E73BC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadHistoryRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003983 RID: 14723 RVA: 0x000E91F8 File Offset: 0x000E73F8
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__14_0(ReadHistoryResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryRequest.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_ReadHistoryResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003984 RID: 14724 RVA: 0x000163F6 File Offset: 0x000145F6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9F RID: 3487
			// (get) Token: 0x06003985 RID: 14725 RVA: 0x000E923C File Offset: 0x000E743C
			// (set) Token: 0x06003986 RID: 14726 RVA: 0x000163FF File Offset: 0x000145FF
			public unsafe static ReadHistoryRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadHistoryRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadHistoryRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadHistoryRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06003987 RID: 14727 RVA: 0x000E9264 File Offset: 0x000E7464
			// (set) Token: 0x06003988 RID: 14728 RVA: 0x00016411 File Offset: 0x00014611
			public unsafe static Action<ReadHistoryResult> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadHistoryRequest.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReadHistoryResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadHistoryRequest.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033A0 RID: 13216
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033A1 RID: 13217
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040033A2 RID: 13218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033A3 RID: 13219
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_ReadHistoryResult_0;
		}
	}
}
