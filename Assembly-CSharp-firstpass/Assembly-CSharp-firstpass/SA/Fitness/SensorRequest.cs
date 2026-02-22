using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Fitness
{
	// Token: 0x02000341 RID: 833
	public class SensorRequest : Object
	{
		// Token: 0x06003255 RID: 12885 RVA: 0x000D2854 File Offset: 0x000D0A54
		// Note: this type is marked as 'beforefieldinit'.
		static SensorRequest()
		{
			Il2CppClassPointerStore<SensorRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "SensorRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr);
			SensorRequest.NativeFieldInfoPtr_OnRequestFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, "OnRequestFinished");
			SensorRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, "id");
			SensorRequest.NativeFieldInfoPtr_dataTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, "dataTypes");
			SensorRequest.NativeFieldInfoPtr_dataSourceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, "dataSourceTypes");
			SensorRequest.NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_SensorRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, 100669765);
			SensorRequest.NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_SensorRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, 100669766);
			SensorRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, 100669767);
			SensorRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, 100669768);
			SensorRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, 100669769);
			SensorRequest.NativeMethodInfoPtr_get_DataTypes_Public_get_List_1_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, 100669770);
			SensorRequest.NativeMethodInfoPtr_get_DataSourceTypes_Public_get_List_1_DataSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, 100669771);
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000D2960 File Offset: 0x000D0B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222452, RefRangeEnd = 222453, XrefRangeStart = 222448, XrefRangeEnd = 222452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRequestFinished(Action<SensorRequestResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_SensorRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000D29A4 File Offset: 0x000D0BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222453, XrefRangeEnd = 222457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRequestFinished(Action<SensorRequestResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_SensorRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x000D29E8 File Offset: 0x000D0BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222486, RefRangeEnd = 222487, XrefRangeStart = 222457, XrefRangeEnd = 222486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensorRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x000D2A24 File Offset: 0x000D0C24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222540, RefRangeEnd = 222541, XrefRangeStart = 222487, XrefRangeEnd = 222540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchResult(Il2CppStringArray bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000D2A68 File Offset: 0x000D0C68
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x000D2AA4 File Offset: 0x000D0CA4
		public unsafe List<DataType> DataTypes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.NativeMethodInfoPtr_get_DataTypes_Public_get_List_1_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000D2AE4 File Offset: 0x000D0CE4
		public unsafe List<DataSourceType> DataSourceTypes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.NativeMethodInfoPtr_get_DataSourceTypes_Public_get_List_1_DataSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataSourceType>>(intPtr3) : null;
			}
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x00013851 File Offset: 0x00011A51
		public SensorRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x000D2B24 File Offset: 0x000D0D24
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x0001385A File Offset: 0x00011A5A
		public unsafe Action<SensorRequestResult> OnRequestFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.NativeFieldInfoPtr_OnRequestFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SensorRequestResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.NativeFieldInfoPtr_OnRequestFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x000D2B54 File Offset: 0x000D0D54
		// (set) Token: 0x06003261 RID: 12897 RVA: 0x00013879 File Offset: 0x00011A79
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x000D2B7C File Offset: 0x000D0D7C
		// (set) Token: 0x06003263 RID: 12899 RVA: 0x00013894 File Offset: 0x00011A94
		public unsafe List<DataType> dataTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.NativeFieldInfoPtr_dataTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.NativeFieldInfoPtr_dataTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x000D2BAC File Offset: 0x000D0DAC
		// (set) Token: 0x06003265 RID: 12901 RVA: 0x000138B3 File Offset: 0x00011AB3
		public unsafe List<DataSourceType> dataSourceTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.NativeFieldInfoPtr_dataSourceTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataSourceType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.NativeFieldInfoPtr_dataSourceTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F23 RID: 12067
		private static readonly IntPtr NativeFieldInfoPtr_OnRequestFinished;

		// Token: 0x04002F24 RID: 12068
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F25 RID: 12069
		private static readonly IntPtr NativeFieldInfoPtr_dataTypes;

		// Token: 0x04002F26 RID: 12070
		private static readonly IntPtr NativeFieldInfoPtr_dataSourceTypes;

		// Token: 0x04002F27 RID: 12071
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_SensorRequestResult_0;

		// Token: 0x04002F28 RID: 12072
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_SensorRequestResult_0;

		// Token: 0x04002F29 RID: 12073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002F2A RID: 12074
		private static readonly IntPtr NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002F2B RID: 12075
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F2C RID: 12076
		private static readonly IntPtr NativeMethodInfoPtr_get_DataTypes_Public_get_List_1_DataType_0;

		// Token: 0x04002F2D RID: 12077
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSourceTypes_Public_get_List_1_DataSourceType_0;

		// Token: 0x020003EB RID: 1003
		public class Builder : Object
		{
			// Token: 0x060039B0 RID: 14768 RVA: 0x000E9A90 File Offset: 0x000E7C90
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<SensorRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorRequest.Builder>.NativeClassPtr);
				SensorRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequest.Builder>.NativeClassPtr, "request");
				SensorRequest.Builder.NativeMethodInfoPtr_AddDataType_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest.Builder>.NativeClassPtr, 100670569);
				SensorRequest.Builder.NativeMethodInfoPtr_AddDataSourceType_Public_Builder_DataSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest.Builder>.NativeClassPtr, 100670570);
				SensorRequest.Builder.NativeMethodInfoPtr_Build_Public_SensorRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest.Builder>.NativeClassPtr, 100670571);
				SensorRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest.Builder>.NativeClassPtr, 100670572);
			}

			// Token: 0x060039B1 RID: 14769 RVA: 0x000E9B20 File Offset: 0x000E7D20
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 222430, RefRangeEnd = 222434, XrefRangeStart = 222424, XrefRangeEnd = 222430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SensorRequest.Builder AddDataType(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.Builder.NativeMethodInfoPtr_AddDataType_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SensorRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039B2 RID: 14770 RVA: 0x000E9B70 File Offset: 0x000E7D70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222440, RefRangeEnd = 222442, XrefRangeStart = 222434, XrefRangeEnd = 222440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SensorRequest.Builder AddDataSourceType(DataSourceType dataSourceType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dataSourceType;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.Builder.NativeMethodInfoPtr_AddDataSourceType_Public_Builder_DataSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SensorRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039B3 RID: 14771 RVA: 0x000E9BBC File Offset: 0x000E7DBC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SensorRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.Builder.NativeMethodInfoPtr_Build_Public_SensorRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SensorRequest>(intPtr3) : null;
			}

			// Token: 0x060039B4 RID: 14772 RVA: 0x000E9BFC File Offset: 0x000E7DFC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222447, RefRangeEnd = 222448, XrefRangeStart = 222442, XrefRangeEnd = 222447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039B5 RID: 14773 RVA: 0x000164F1 File Offset: 0x000146F1
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA9 RID: 3497
			// (get) Token: 0x060039B6 RID: 14774 RVA: 0x000E9C38 File Offset: 0x000E7E38
			// (set) Token: 0x060039B7 RID: 14775 RVA: 0x000164FA File Offset: 0x000146FA
			public unsafe SensorRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SensorRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033BB RID: 13243
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040033BC RID: 13244
			private static readonly IntPtr NativeMethodInfoPtr_AddDataType_Public_Builder_DataType_0;

			// Token: 0x040033BD RID: 13245
			private static readonly IntPtr NativeMethodInfoPtr_AddDataSourceType_Public_Builder_DataSourceType_0;

			// Token: 0x040033BE RID: 13246
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_SensorRequest_0;

			// Token: 0x040033BF RID: 13247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003EC RID: 1004
		[ObfuscatedName("SA.Fitness.SensorRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060039B8 RID: 14776 RVA: 0x000E9C68 File Offset: 0x000E7E68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SensorRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SensorRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorRequest.__c>.NativeClassPtr);
				SensorRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequest.__c>.NativeClassPtr, "<>9");
				SensorRequest.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequest.__c>.NativeClassPtr, "<>9__6_0");
				SensorRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest.__c>.NativeClassPtr, 100670574);
				SensorRequest.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_SensorRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequest.__c>.NativeClassPtr, 100670575);
			}

			// Token: 0x060039B9 RID: 14777 RVA: 0x000E9CE4 File Offset: 0x000E7EE4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039BA RID: 14778 RVA: 0x000E9D20 File Offset: 0x000E7F20
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__6_0(SensorRequestResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequest.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_SensorRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039BB RID: 14779 RVA: 0x00016519 File Offset: 0x00014719
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x060039BC RID: 14780 RVA: 0x000E9D64 File Offset: 0x000E7F64
			// (set) Token: 0x060039BD RID: 14781 RVA: 0x00016522 File Offset: 0x00014722
			public unsafe static SensorRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SensorRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SensorRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SensorRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DAB RID: 3499
			// (get) Token: 0x060039BE RID: 14782 RVA: 0x000E9D8C File Offset: 0x000E7F8C
			// (set) Token: 0x060039BF RID: 14783 RVA: 0x00016534 File Offset: 0x00014734
			public unsafe static Action<SensorRequestResult> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SensorRequest.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SensorRequestResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SensorRequest.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033C0 RID: 13248
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033C1 RID: 13249
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040033C2 RID: 13250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033C3 RID: 13251
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_SensorRequestResult_0;
		}
	}
}
