using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000335 RID: 821
	public sealed class DataType : Object
	{
		// Token: 0x0600302D RID: 12333 RVA: 0x000CD348 File Offset: 0x000CB548
		// Note: this type is marked as 'beforefieldinit'.
		static DataType()
		{
			Il2CppClassPointerStore<DataType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "DataType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataType>.NativeClassPtr);
			DataType.NativeFieldInfoPtr_AGGREGATE_ACTIVITY_SUMMARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_ACTIVITY_SUMMARY");
			DataType.NativeFieldInfoPtr_AGGREGATE_BASAL_METABOLIC_RATE_SUMMARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_BASAL_METABOLIC_RATE_SUMMARY");
			DataType.NativeFieldInfoPtr_AGGREGATE_BODY_FAT_PERCENTAGE_SUMMARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_BODY_FAT_PERCENTAGE_SUMMARY");
			DataType.NativeFieldInfoPtr_AGGREGATE_CALORIES_EXPENDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_CALORIES_EXPENDED");
			DataType.NativeFieldInfoPtr_AGGREGATE_DISTANCE_DELTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_DISTANCE_DELTA");
			DataType.NativeFieldInfoPtr_AGGREGATE_HEART_RATE_SUMMARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_HEART_RATE_SUMMARY");
			DataType.NativeFieldInfoPtr_AGGREGATE_HYDRATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_HYDRATION");
			DataType.NativeFieldInfoPtr_AGGREGATE_LOCATION_BOUNDING_BOX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_LOCATION_BOUNDING_BOX");
			DataType.NativeFieldInfoPtr_AGGREGATE_NUTRITION_SUMMARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_NUTRITION_SUMMARY");
			DataType.NativeFieldInfoPtr_AGGREGATE_POWER_SUMMARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_POWER_SUMMARY");
			DataType.NativeFieldInfoPtr_AGGREGATE_SPEED_SUMMARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_SPEED_SUMMARY");
			DataType.NativeFieldInfoPtr_AGGREGATE_STEP_COUNT_DELTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_STEP_COUNT_DELTA");
			DataType.NativeFieldInfoPtr_AGGREGATE_WEIGHT_SUMMARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "AGGREGATE_WEIGHT_SUMMARY");
			DataType.NativeFieldInfoPtr_TYPE_ACTIVITY_SAMPLES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_ACTIVITY_SAMPLES");
			DataType.NativeFieldInfoPtr_TYPE_ACTIVITY_SEGMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_ACTIVITY_SEGMENT");
			DataType.NativeFieldInfoPtr_TYPE_BASAL_METABOLIC_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_BASAL_METABOLIC_RATE");
			DataType.NativeFieldInfoPtr_TYPE_BODY_FAT_PERCENTAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_BODY_FAT_PERCENTAGE");
			DataType.NativeFieldInfoPtr_TYPE_CALORIES_EXPENDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_CALORIES_EXPENDED");
			DataType.NativeFieldInfoPtr_TYPE_CYCLING_PEDALING_CADENCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_CYCLING_PEDALING_CADENCE");
			DataType.NativeFieldInfoPtr_TYPE_CYCLING_PEDALING_CUMULATIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_CYCLING_PEDALING_CUMULATIVE");
			DataType.NativeFieldInfoPtr_TYPE_CYCLING_WHEEL_REVOLUTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_CYCLING_WHEEL_REVOLUTION");
			DataType.NativeFieldInfoPtr_TYPE_CYCLING_WHEEL_RPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_CYCLING_WHEEL_RPM");
			DataType.NativeFieldInfoPtr_TYPE_DISTANCE_DELTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_DISTANCE_DELTA");
			DataType.NativeFieldInfoPtr_TYPE_HEART_RATE_BPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_HEART_RATE_BPM");
			DataType.NativeFieldInfoPtr_TYPE_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_HEIGHT");
			DataType.NativeFieldInfoPtr_TYPE_HYDRATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_HYDRATION");
			DataType.NativeFieldInfoPtr_TYPE_LOCATION_SAMPLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_LOCATION_SAMPLE");
			DataType.NativeFieldInfoPtr_TYPE_LOCATION_TRACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_LOCATION_TRACK");
			DataType.NativeFieldInfoPtr_TYPE_NUTRITION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_NUTRITION");
			DataType.NativeFieldInfoPtr_TYPE_POWER_SAMPLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_POWER_SAMPLE");
			DataType.NativeFieldInfoPtr_TYPE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_SPEED");
			DataType.NativeFieldInfoPtr_TYPE_STEP_COUNT_CADENCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_STEP_COUNT_CADENCE");
			DataType.NativeFieldInfoPtr_TYPE_STEP_COUNT_DELTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_STEP_COUNT_DELTA");
			DataType.NativeFieldInfoPtr_TYPE_WEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_WEIGHT");
			DataType.NativeFieldInfoPtr_TYPE_WORKOUT_EXERCISE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "TYPE_WORKOUT_EXERCISE");
			DataType.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataType>.NativeClassPtr, "value");
			DataType.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataType>.NativeClassPtr, 100669667);
			DataType.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataType>.NativeClassPtr, 100669668);
			DataType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataType>.NativeClassPtr, 100669669);
			DataType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataType>.NativeClassPtr, 100669670);
			DataType.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataType>.NativeClassPtr, 100669671);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x000CD6AC File Offset: 0x000CB8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221483, XrefRangeEnd = 221486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataType.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x000CD6E8 File Offset: 0x000CB8E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 221489, RefRangeEnd = 221497, XrefRangeStart = 221486, XrefRangeEnd = 221489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataType(string dataType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataType.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x000CD734 File Offset: 0x000CB934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221497, XrefRangeEnd = 221506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x000CD784 File Offset: 0x000CB984
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221506, XrefRangeEnd = 221564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x000CD7C0 File Offset: 0x000CB9C0
		public unsafe string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataType.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x00012697 File Offset: 0x00010897
		public DataType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x000CD7F8 File Offset: 0x000CB9F8
		// (set) Token: 0x06003035 RID: 12341 RVA: 0x000126A0 File Offset: 0x000108A0
		public unsafe static DataType AGGREGATE_ACTIVITY_SUMMARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_ACTIVITY_SUMMARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_ACTIVITY_SUMMARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x000CD820 File Offset: 0x000CBA20
		// (set) Token: 0x06003037 RID: 12343 RVA: 0x000126B2 File Offset: 0x000108B2
		public unsafe static DataType AGGREGATE_BASAL_METABOLIC_RATE_SUMMARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_BASAL_METABOLIC_RATE_SUMMARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_BASAL_METABOLIC_RATE_SUMMARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x000CD848 File Offset: 0x000CBA48
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x000126C4 File Offset: 0x000108C4
		public unsafe static DataType AGGREGATE_BODY_FAT_PERCENTAGE_SUMMARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_BODY_FAT_PERCENTAGE_SUMMARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_BODY_FAT_PERCENTAGE_SUMMARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x000CD870 File Offset: 0x000CBA70
		// (set) Token: 0x0600303B RID: 12347 RVA: 0x000126D6 File Offset: 0x000108D6
		public unsafe static DataType AGGREGATE_CALORIES_EXPENDED
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_CALORIES_EXPENDED, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_CALORIES_EXPENDED, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x000CD898 File Offset: 0x000CBA98
		// (set) Token: 0x0600303D RID: 12349 RVA: 0x000126E8 File Offset: 0x000108E8
		public unsafe static DataType AGGREGATE_DISTANCE_DELTA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_DISTANCE_DELTA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_DISTANCE_DELTA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x000CD8C0 File Offset: 0x000CBAC0
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x000126FA File Offset: 0x000108FA
		public unsafe static DataType AGGREGATE_HEART_RATE_SUMMARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_HEART_RATE_SUMMARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_HEART_RATE_SUMMARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x000CD8E8 File Offset: 0x000CBAE8
		// (set) Token: 0x06003041 RID: 12353 RVA: 0x0001270C File Offset: 0x0001090C
		public unsafe static DataType AGGREGATE_HYDRATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_HYDRATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_HYDRATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x000CD910 File Offset: 0x000CBB10
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x0001271E File Offset: 0x0001091E
		public unsafe static DataType AGGREGATE_LOCATION_BOUNDING_BOX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_LOCATION_BOUNDING_BOX, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_LOCATION_BOUNDING_BOX, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x000CD938 File Offset: 0x000CBB38
		// (set) Token: 0x06003045 RID: 12357 RVA: 0x00012730 File Offset: 0x00010930
		public unsafe static DataType AGGREGATE_NUTRITION_SUMMARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_NUTRITION_SUMMARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_NUTRITION_SUMMARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x000CD960 File Offset: 0x000CBB60
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x00012742 File Offset: 0x00010942
		public unsafe static DataType AGGREGATE_POWER_SUMMARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_POWER_SUMMARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_POWER_SUMMARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x000CD988 File Offset: 0x000CBB88
		// (set) Token: 0x06003049 RID: 12361 RVA: 0x00012754 File Offset: 0x00010954
		public unsafe static DataType AGGREGATE_SPEED_SUMMARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_SPEED_SUMMARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_SPEED_SUMMARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x000CD9B0 File Offset: 0x000CBBB0
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x00012766 File Offset: 0x00010966
		public unsafe static DataType AGGREGATE_STEP_COUNT_DELTA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_STEP_COUNT_DELTA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_STEP_COUNT_DELTA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x000CD9D8 File Offset: 0x000CBBD8
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x00012778 File Offset: 0x00010978
		public unsafe static DataType AGGREGATE_WEIGHT_SUMMARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_AGGREGATE_WEIGHT_SUMMARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_AGGREGATE_WEIGHT_SUMMARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x000CDA00 File Offset: 0x000CBC00
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x0001278A File Offset: 0x0001098A
		public unsafe static DataType TYPE_ACTIVITY_SAMPLES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_ACTIVITY_SAMPLES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_ACTIVITY_SAMPLES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x000CDA28 File Offset: 0x000CBC28
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x0001279C File Offset: 0x0001099C
		public unsafe static DataType TYPE_ACTIVITY_SEGMENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_ACTIVITY_SEGMENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_ACTIVITY_SEGMENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x000CDA50 File Offset: 0x000CBC50
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x000127AE File Offset: 0x000109AE
		public unsafe static DataType TYPE_BASAL_METABOLIC_RATE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_BASAL_METABOLIC_RATE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_BASAL_METABOLIC_RATE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x000CDA78 File Offset: 0x000CBC78
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x000127C0 File Offset: 0x000109C0
		public unsafe static DataType TYPE_BODY_FAT_PERCENTAGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_BODY_FAT_PERCENTAGE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_BODY_FAT_PERCENTAGE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x000CDAA0 File Offset: 0x000CBCA0
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x000127D2 File Offset: 0x000109D2
		public unsafe static DataType TYPE_CALORIES_EXPENDED
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_CALORIES_EXPENDED, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_CALORIES_EXPENDED, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x000CDAC8 File Offset: 0x000CBCC8
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x000127E4 File Offset: 0x000109E4
		public unsafe static DataType TYPE_CYCLING_PEDALING_CADENCE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_CYCLING_PEDALING_CADENCE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_CYCLING_PEDALING_CADENCE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x000CDAF0 File Offset: 0x000CBCF0
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x000127F6 File Offset: 0x000109F6
		public unsafe static DataType TYPE_CYCLING_PEDALING_CUMULATIVE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_CYCLING_PEDALING_CUMULATIVE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_CYCLING_PEDALING_CUMULATIVE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x000CDB18 File Offset: 0x000CBD18
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x00012808 File Offset: 0x00010A08
		public unsafe static DataType TYPE_CYCLING_WHEEL_REVOLUTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_CYCLING_WHEEL_REVOLUTION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_CYCLING_WHEEL_REVOLUTION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x000CDB40 File Offset: 0x000CBD40
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x0001281A File Offset: 0x00010A1A
		public unsafe static DataType TYPE_CYCLING_WHEEL_RPM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_CYCLING_WHEEL_RPM, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_CYCLING_WHEEL_RPM, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x000CDB68 File Offset: 0x000CBD68
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x0001282C File Offset: 0x00010A2C
		public unsafe static DataType TYPE_DISTANCE_DELTA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_DISTANCE_DELTA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_DISTANCE_DELTA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x000CDB90 File Offset: 0x000CBD90
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x0001283E File Offset: 0x00010A3E
		public unsafe static DataType TYPE_HEART_RATE_BPM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_HEART_RATE_BPM, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_HEART_RATE_BPM, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x000CDBB8 File Offset: 0x000CBDB8
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00012850 File Offset: 0x00010A50
		public unsafe static DataType TYPE_HEIGHT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_HEIGHT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_HEIGHT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x000CDBE0 File Offset: 0x000CBDE0
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x00012862 File Offset: 0x00010A62
		public unsafe static DataType TYPE_HYDRATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_HYDRATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_HYDRATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x000CDC08 File Offset: 0x000CBE08
		// (set) Token: 0x06003069 RID: 12393 RVA: 0x00012874 File Offset: 0x00010A74
		public unsafe static DataType TYPE_LOCATION_SAMPLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_LOCATION_SAMPLE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_LOCATION_SAMPLE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x000CDC30 File Offset: 0x000CBE30
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x00012886 File Offset: 0x00010A86
		public unsafe static DataType TYPE_LOCATION_TRACK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_LOCATION_TRACK, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_LOCATION_TRACK, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x000CDC58 File Offset: 0x000CBE58
		// (set) Token: 0x0600306D RID: 12397 RVA: 0x00012898 File Offset: 0x00010A98
		public unsafe static DataType TYPE_NUTRITION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_NUTRITION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_NUTRITION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600306E RID: 12398 RVA: 0x000CDC80 File Offset: 0x000CBE80
		// (set) Token: 0x0600306F RID: 12399 RVA: 0x000128AA File Offset: 0x00010AAA
		public unsafe static DataType TYPE_POWER_SAMPLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_POWER_SAMPLE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_POWER_SAMPLE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x000CDCA8 File Offset: 0x000CBEA8
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x000128BC File Offset: 0x00010ABC
		public unsafe static DataType TYPE_SPEED
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_SPEED, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_SPEED, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x000CDCD0 File Offset: 0x000CBED0
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x000128CE File Offset: 0x00010ACE
		public unsafe static DataType TYPE_STEP_COUNT_CADENCE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_STEP_COUNT_CADENCE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_STEP_COUNT_CADENCE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x000CDCF8 File Offset: 0x000CBEF8
		// (set) Token: 0x06003075 RID: 12405 RVA: 0x000128E0 File Offset: 0x00010AE0
		public unsafe static DataType TYPE_STEP_COUNT_DELTA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_STEP_COUNT_DELTA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_STEP_COUNT_DELTA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x000CDD20 File Offset: 0x000CBF20
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x000128F2 File Offset: 0x00010AF2
		public unsafe static DataType TYPE_WEIGHT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_WEIGHT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_WEIGHT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x000CDD48 File Offset: 0x000CBF48
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x00012904 File Offset: 0x00010B04
		public unsafe static DataType TYPE_WORKOUT_EXERCISE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataType.NativeFieldInfoPtr_TYPE_WORKOUT_EXERCISE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataType.NativeFieldInfoPtr_TYPE_WORKOUT_EXERCISE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x000CDD70 File Offset: 0x000CBF70
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x00012916 File Offset: 0x00010B16
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataType.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataType.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_ACTIVITY_SUMMARY;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_BASAL_METABOLIC_RATE_SUMMARY;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_BODY_FAT_PERCENTAGE_SUMMARY;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_CALORIES_EXPENDED;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_DISTANCE_DELTA;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_HEART_RATE_SUMMARY;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_HYDRATION;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_LOCATION_BOUNDING_BOX;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_NUTRITION_SUMMARY;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_POWER_SUMMARY;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_SPEED_SUMMARY;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_STEP_COUNT_DELTA;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeFieldInfoPtr_AGGREGATE_WEIGHT_SUMMARY;

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_ACTIVITY_SAMPLES;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_ACTIVITY_SEGMENT;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_BASAL_METABOLIC_RATE;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_BODY_FAT_PERCENTAGE;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_CALORIES_EXPENDED;

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_CYCLING_PEDALING_CADENCE;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_CYCLING_PEDALING_CUMULATIVE;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_CYCLING_WHEEL_REVOLUTION;

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_CYCLING_WHEEL_RPM;

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_DISTANCE_DELTA;

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_HEART_RATE_BPM;

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_HEIGHT;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_HYDRATION;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_LOCATION_SAMPLE;

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_LOCATION_TRACK;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_NUTRITION;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_POWER_SAMPLE;

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_SPEED;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_STEP_COUNT_CADENCE;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_STEP_COUNT_DELTA;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_WEIGHT;

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeFieldInfoPtr_TYPE_WORKOUT_EXERCISE;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002E11 RID: 11793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002E12 RID: 11794
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002E13 RID: 11795
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002E14 RID: 11796
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
