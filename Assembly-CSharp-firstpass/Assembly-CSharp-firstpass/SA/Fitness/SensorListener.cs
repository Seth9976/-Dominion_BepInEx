using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000340 RID: 832
	public class SensorListener : Object
	{
		// Token: 0x06003237 RID: 12855 RVA: 0x000D21D4 File Offset: 0x000D03D4
		// Note: this type is marked as 'beforefieldinit'.
		static SensorListener()
		{
			Il2CppClassPointerStore<SensorListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "SensorListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorListener>.NativeClassPtr);
			SensorListener.NativeFieldInfoPtr_OnRegisterSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "OnRegisterSuccess");
			SensorListener.NativeFieldInfoPtr_OnRegisterFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "OnRegisterFail");
			SensorListener.NativeFieldInfoPtr_OnDataPointReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "OnDataPointReceived");
			SensorListener.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "id");
			SensorListener.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "dataType");
			SensorListener.NativeFieldInfoPtr_rateAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "rateAmount");
			SensorListener.NativeFieldInfoPtr_rateTimeUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "rateTimeUnit");
			SensorListener.NativeMethodInfoPtr_add_OnRegisterSuccess_Public_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669751);
			SensorListener.NativeMethodInfoPtr_remove_OnRegisterSuccess_Public_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669752);
			SensorListener.NativeMethodInfoPtr_add_OnRegisterFail_Public_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669753);
			SensorListener.NativeMethodInfoPtr_remove_OnRegisterFail_Public_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669754);
			SensorListener.NativeMethodInfoPtr_add_OnDataPointReceived_Public_add_Void_Action_2_Int32_DataPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669755);
			SensorListener.NativeMethodInfoPtr_remove_OnDataPointReceived_Public_rem_Void_Action_2_Int32_DataPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669756);
			SensorListener.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669757);
			SensorListener.NativeMethodInfoPtr_DispatchRegisterSuccess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669758);
			SensorListener.NativeMethodInfoPtr_DispatchRegisterFail_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669759);
			SensorListener.NativeMethodInfoPtr_DispatchDataPointEvent_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669760);
			SensorListener.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669761);
			SensorListener.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669762);
			SensorListener.NativeMethodInfoPtr_get_RateAmount_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669763);
			SensorListener.NativeMethodInfoPtr_get_RateTimeUnit_Public_get_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, 100669764);
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x000D23A8 File Offset: 0x000D05A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222339, RefRangeEnd = 222340, XrefRangeStart = 222335, XrefRangeEnd = 222339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRegisterSuccess(Action<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_add_OnRegisterSuccess_Public_add_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x000D23EC File Offset: 0x000D05EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222340, XrefRangeEnd = 222344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRegisterSuccess(Action<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_remove_OnRegisterSuccess_Public_rem_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x000D2430 File Offset: 0x000D0630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222348, RefRangeEnd = 222349, XrefRangeStart = 222344, XrefRangeEnd = 222348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRegisterFail(Action<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_add_OnRegisterFail_Public_add_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x000D2474 File Offset: 0x000D0674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222349, XrefRangeEnd = 222353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRegisterFail(Action<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_remove_OnRegisterFail_Public_rem_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x000D24B8 File Offset: 0x000D06B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222357, RefRangeEnd = 222358, XrefRangeStart = 222353, XrefRangeEnd = 222357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnDataPointReceived(Action<int, DataPoint> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_add_OnDataPointReceived_Public_add_Void_Action_2_Int32_DataPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000D24FC File Offset: 0x000D06FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222358, XrefRangeEnd = 222362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnDataPointReceived(Action<int, DataPoint> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_remove_OnDataPointReceived_Public_rem_Void_Action_2_Int32_DataPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x000D2540 File Offset: 0x000D0740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222405, RefRangeEnd = 222406, XrefRangeStart = 222362, XrefRangeEnd = 222405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensorListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x000D257C File Offset: 0x000D077C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222406, XrefRangeEnd = 222410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchRegisterSuccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_DispatchRegisterSuccess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000D25B0 File Offset: 0x000D07B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222410, XrefRangeEnd = 222414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchRegisterFail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_DispatchRegisterFail_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000D25E4 File Offset: 0x000D07E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222414, XrefRangeEnd = 222424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchDataPointEvent(Il2CppStringArray bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_DispatchDataPointEvent_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x000D2628 File Offset: 0x000D0828
		public unsafe int Id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06003243 RID: 12867 RVA: 0x000D2664 File Offset: 0x000D0864
		public unsafe DataType DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000D26A4 File Offset: 0x000D08A4
		public unsafe long RateAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_get_RateAmount_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06003245 RID: 12869 RVA: 0x000D26E0 File Offset: 0x000D08E0
		public unsafe TimeUnit RateTimeUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.NativeMethodInfoPtr_get_RateTimeUnit_Public_get_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x0001377B File Offset: 0x0001197B
		public SensorListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06003247 RID: 12871 RVA: 0x000D271C File Offset: 0x000D091C
		// (set) Token: 0x06003248 RID: 12872 RVA: 0x00013784 File Offset: 0x00011984
		public unsafe Action<int> OnRegisterSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_OnRegisterSuccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_OnRegisterSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06003249 RID: 12873 RVA: 0x000D274C File Offset: 0x000D094C
		// (set) Token: 0x0600324A RID: 12874 RVA: 0x000137A3 File Offset: 0x000119A3
		public unsafe Action<int> OnRegisterFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_OnRegisterFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_OnRegisterFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x000D277C File Offset: 0x000D097C
		// (set) Token: 0x0600324C RID: 12876 RVA: 0x000137C2 File Offset: 0x000119C2
		public unsafe Action<int, DataPoint> OnDataPointReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_OnDataPointReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, DataPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_OnDataPointReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600324D RID: 12877 RVA: 0x000D27AC File Offset: 0x000D09AC
		// (set) Token: 0x0600324E RID: 12878 RVA: 0x000137E1 File Offset: 0x000119E1
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x000D27D4 File Offset: 0x000D09D4
		// (set) Token: 0x06003250 RID: 12880 RVA: 0x000137FC File Offset: 0x000119FC
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x000D2804 File Offset: 0x000D0A04
		// (set) Token: 0x06003252 RID: 12882 RVA: 0x0001381B File Offset: 0x00011A1B
		public unsafe long rateAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_rateAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_rateAmount)) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x000D282C File Offset: 0x000D0A2C
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x00013836 File Offset: 0x00011A36
		public unsafe TimeUnit rateTimeUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_rateTimeUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.NativeFieldInfoPtr_rateTimeUnit)) = value;
			}
		}

		// Token: 0x04002F0E RID: 12046
		private static readonly IntPtr NativeFieldInfoPtr_OnRegisterSuccess;

		// Token: 0x04002F0F RID: 12047
		private static readonly IntPtr NativeFieldInfoPtr_OnRegisterFail;

		// Token: 0x04002F10 RID: 12048
		private static readonly IntPtr NativeFieldInfoPtr_OnDataPointReceived;

		// Token: 0x04002F11 RID: 12049
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F12 RID: 12050
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002F13 RID: 12051
		private static readonly IntPtr NativeFieldInfoPtr_rateAmount;

		// Token: 0x04002F14 RID: 12052
		private static readonly IntPtr NativeFieldInfoPtr_rateTimeUnit;

		// Token: 0x04002F15 RID: 12053
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRegisterSuccess_Public_add_Void_Action_1_Int32_0;

		// Token: 0x04002F16 RID: 12054
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRegisterSuccess_Public_rem_Void_Action_1_Int32_0;

		// Token: 0x04002F17 RID: 12055
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRegisterFail_Public_add_Void_Action_1_Int32_0;

		// Token: 0x04002F18 RID: 12056
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRegisterFail_Public_rem_Void_Action_1_Int32_0;

		// Token: 0x04002F19 RID: 12057
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDataPointReceived_Public_add_Void_Action_2_Int32_DataPoint_0;

		// Token: 0x04002F1A RID: 12058
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDataPointReceived_Public_rem_Void_Action_2_Int32_DataPoint_0;

		// Token: 0x04002F1B RID: 12059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002F1C RID: 12060
		private static readonly IntPtr NativeMethodInfoPtr_DispatchRegisterSuccess_Public_Void_0;

		// Token: 0x04002F1D RID: 12061
		private static readonly IntPtr NativeMethodInfoPtr_DispatchRegisterFail_Public_Void_0;

		// Token: 0x04002F1E RID: 12062
		private static readonly IntPtr NativeMethodInfoPtr_DispatchDataPointEvent_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002F1F RID: 12063
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F20 RID: 12064
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x04002F21 RID: 12065
		private static readonly IntPtr NativeMethodInfoPtr_get_RateAmount_Public_get_Int64_0;

		// Token: 0x04002F22 RID: 12066
		private static readonly IntPtr NativeMethodInfoPtr_get_RateTimeUnit_Public_get_TimeUnit_0;

		// Token: 0x020003E9 RID: 1001
		public class Builder : Object
		{
			// Token: 0x0600399A RID: 14746 RVA: 0x000E9630 File Offset: 0x000E7830
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<SensorListener.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorListener.Builder>.NativeClassPtr);
				SensorListener.Builder.NativeFieldInfoPtr_listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener.Builder>.NativeClassPtr, "listener");
				SensorListener.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener.Builder>.NativeClassPtr, 100670560);
				SensorListener.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener.Builder>.NativeClassPtr, 100670561);
				SensorListener.Builder.NativeMethodInfoPtr_SetSamplingRate_Public_Builder_Int64_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener.Builder>.NativeClassPtr, 100670562);
				SensorListener.Builder.NativeMethodInfoPtr_Build_Public_SensorListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener.Builder>.NativeClassPtr, 100670563);
			}

			// Token: 0x0600399B RID: 14747 RVA: 0x000E96C0 File Offset: 0x000E78C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222332, RefRangeEnd = 222333, XrefRangeStart = 222327, XrefRangeEnd = 222332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorListener.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600399C RID: 14748 RVA: 0x000E96FC File Offset: 0x000E78FC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 222117, RefRangeEnd = 222121, XrefRangeStart = 222117, XrefRangeEnd = 222121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SensorListener.Builder SetDataType(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SensorListener.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x0600399D RID: 14749 RVA: 0x000E974C File Offset: 0x000E794C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222333, RefRangeEnd = 222335, XrefRangeStart = 222333, XrefRangeEnd = 222333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SensorListener.Builder SetSamplingRate(long amount, TimeUnit unit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref amount;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.Builder.NativeMethodInfoPtr_SetSamplingRate_Public_Builder_Int64_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SensorListener.Builder>(intPtr3) : null;
			}

			// Token: 0x0600399E RID: 14750 RVA: 0x000E97A8 File Offset: 0x000E79A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SensorListener Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.Builder.NativeMethodInfoPtr_Build_Public_SensorListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SensorListener>(intPtr3) : null;
			}

			// Token: 0x0600399F RID: 14751 RVA: 0x00016478 File Offset: 0x00014678
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA4 RID: 3492
			// (get) Token: 0x060039A0 RID: 14752 RVA: 0x000E97E8 File Offset: 0x000E79E8
			// (set) Token: 0x060039A1 RID: 14753 RVA: 0x00016481 File Offset: 0x00014681
			public unsafe SensorListener listener
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.Builder.NativeFieldInfoPtr_listener);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SensorListener>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorListener.Builder.NativeFieldInfoPtr_listener), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033AE RID: 13230
			private static readonly IntPtr NativeFieldInfoPtr_listener;

			// Token: 0x040033AF RID: 13231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033B0 RID: 13232
			private static readonly IntPtr NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0;

			// Token: 0x040033B1 RID: 13233
			private static readonly IntPtr NativeMethodInfoPtr_SetSamplingRate_Public_Builder_Int64_TimeUnit_0;

			// Token: 0x040033B2 RID: 13234
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_SensorListener_0;
		}

		// Token: 0x020003EA RID: 1002
		[ObfuscatedName("SA.Fitness.SensorListener+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060039A2 RID: 14754 RVA: 0x000E9818 File Offset: 0x000E7A18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SensorListener>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr);
				SensorListener.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr, "<>9");
				SensorListener.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr, "<>9__13_0");
				SensorListener.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr, "<>9__13_1");
				SensorListener.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr, "<>9__13_2");
				SensorListener.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr, 100670565);
				SensorListener.__c.NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr, 100670566);
				SensorListener.__c.NativeMethodInfoPtr___ctor_b__13_1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr, 100670567);
				SensorListener.__c.NativeMethodInfoPtr___ctor_b__13_2_Internal_Void_Int32_DataPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr, 100670568);
			}

			// Token: 0x060039A3 RID: 14755 RVA: 0x000E98E4 File Offset: 0x000E7AE4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorListener.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039A4 RID: 14756 RVA: 0x000E9920 File Offset: 0x000E7B20
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__13_0(int <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <p0>;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.__c.NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039A5 RID: 14757 RVA: 0x000E9960 File Offset: 0x000E7B60
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__13_1(int <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <p0>;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.__c.NativeMethodInfoPtr___ctor_b__13_1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039A6 RID: 14758 RVA: 0x000E99A0 File Offset: 0x000E7BA0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__13_2(int <p0>, DataPoint <p1>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <p0>;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorListener.__c.NativeMethodInfoPtr___ctor_b__13_2_Internal_Void_Int32_DataPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039A7 RID: 14759 RVA: 0x000164A0 File Offset: 0x000146A0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA5 RID: 3493
			// (get) Token: 0x060039A8 RID: 14760 RVA: 0x000E99F0 File Offset: 0x000E7BF0
			// (set) Token: 0x060039A9 RID: 14761 RVA: 0x000164A9 File Offset: 0x000146A9
			public unsafe static SensorListener.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SensorListener.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SensorListener.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SensorListener.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA6 RID: 3494
			// (get) Token: 0x060039AA RID: 14762 RVA: 0x000E9A18 File Offset: 0x000E7C18
			// (set) Token: 0x060039AB RID: 14763 RVA: 0x000164BB File Offset: 0x000146BB
			public unsafe static Action<int> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SensorListener.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SensorListener.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA7 RID: 3495
			// (get) Token: 0x060039AC RID: 14764 RVA: 0x000E9A40 File Offset: 0x000E7C40
			// (set) Token: 0x060039AD RID: 14765 RVA: 0x000164CD File Offset: 0x000146CD
			public unsafe static Action<int> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SensorListener.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SensorListener.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x060039AE RID: 14766 RVA: 0x000E9A68 File Offset: 0x000E7C68
			// (set) Token: 0x060039AF RID: 14767 RVA: 0x000164DF File Offset: 0x000146DF
			public unsafe static Action<int, DataPoint> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SensorListener.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, DataPoint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SensorListener.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033B3 RID: 13235
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033B4 RID: 13236
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040033B5 RID: 13237
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040033B6 RID: 13238
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x040033B7 RID: 13239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033B8 RID: 13240
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_Int32_0;

			// Token: 0x040033B9 RID: 13241
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_1_Internal_Void_Int32_0;

			// Token: 0x040033BA RID: 13242
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_2_Internal_Void_Int32_DataPoint_0;
		}
	}
}
