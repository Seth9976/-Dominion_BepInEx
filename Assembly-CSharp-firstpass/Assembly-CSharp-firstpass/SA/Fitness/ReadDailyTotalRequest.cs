using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x0200033A RID: 826
	public class ReadDailyTotalRequest : Object
	{
		// Token: 0x060031BD RID: 12733 RVA: 0x000D0870 File Offset: 0x000CEA70
		// Note: this type is marked as 'beforefieldinit'.
		static ReadDailyTotalRequest()
		{
			Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "ReadDailyTotalRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr);
			ReadDailyTotalRequest.NativeFieldInfoPtr_OnRequestFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, "OnRequestFinished");
			ReadDailyTotalRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, "id");
			ReadDailyTotalRequest.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, "dataType");
			ReadDailyTotalRequest.NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_ReadDailyTotalResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, 100669701);
			ReadDailyTotalRequest.NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_ReadDailyTotalResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, 100669702);
			ReadDailyTotalRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, 100669703);
			ReadDailyTotalRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, 100669704);
			ReadDailyTotalRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, 100669705);
			ReadDailyTotalRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, 100669706);
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x000D0954 File Offset: 0x000CEB54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221702, RefRangeEnd = 221703, XrefRangeStart = 221698, XrefRangeEnd = 221702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRequestFinished(Action<ReadDailyTotalResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_ReadDailyTotalResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000D0998 File Offset: 0x000CEB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221703, XrefRangeEnd = 221707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRequestFinished(Action<ReadDailyTotalResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_ReadDailyTotalResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x000D09DC File Offset: 0x000CEBDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221725, RefRangeEnd = 221726, XrefRangeStart = 221707, XrefRangeEnd = 221725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadDailyTotalRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x000D0A18 File Offset: 0x000CEC18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221805, RefRangeEnd = 221806, XrefRangeStart = 221726, XrefRangeEnd = 221805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchResult(Il2CppStringArray bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x000D0A5C File Offset: 0x000CEC5C
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x000D0A98 File Offset: 0x000CEC98
		public unsafe DataType DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000133EB File Offset: 0x000115EB
		public ReadDailyTotalRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x000D0AD8 File Offset: 0x000CECD8
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x000133F4 File Offset: 0x000115F4
		public unsafe Action<ReadDailyTotalResult> OnRequestFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalRequest.NativeFieldInfoPtr_OnRequestFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReadDailyTotalResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalRequest.NativeFieldInfoPtr_OnRequestFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060031C7 RID: 12743 RVA: 0x000D0B08 File Offset: 0x000CED08
		// (set) Token: 0x060031C8 RID: 12744 RVA: 0x00013413 File Offset: 0x00011613
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x000D0B30 File Offset: 0x000CED30
		// (set) Token: 0x060031CA RID: 12746 RVA: 0x0001342E File Offset: 0x0001162E
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalRequest.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalRequest.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeFieldInfoPtr_OnRequestFinished;

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_ReadDailyTotalResult_0;

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_ReadDailyTotalResult_0;

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x020003E3 RID: 995
		public class Builder : Object
		{
			// Token: 0x06003964 RID: 14692 RVA: 0x000E89F0 File Offset: 0x000E6BF0
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<ReadDailyTotalRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadDailyTotalRequest.Builder>.NativeClassPtr);
				ReadDailyTotalRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadDailyTotalRequest.Builder>.NativeClassPtr, "request");
				ReadDailyTotalRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest.Builder>.NativeClassPtr, 100670533);
				ReadDailyTotalRequest.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest.Builder>.NativeClassPtr, 100670534);
				ReadDailyTotalRequest.Builder.NativeMethodInfoPtr_Build_Public_ReadDailyTotalRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest.Builder>.NativeClassPtr, 100670535);
			}

			// Token: 0x06003965 RID: 14693 RVA: 0x000E8A6C File Offset: 0x000E6C6C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221688, RefRangeEnd = 221689, XrefRangeStart = 221683, XrefRangeEnd = 221688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadDailyTotalRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003966 RID: 14694 RVA: 0x000E8AA8 File Offset: 0x000E6CA8
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadDailyTotalRequest.Builder SetDataType(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadDailyTotalRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003967 RID: 14695 RVA: 0x000E8AF8 File Offset: 0x000E6CF8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadDailyTotalRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.Builder.NativeMethodInfoPtr_Build_Public_ReadDailyTotalRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadDailyTotalRequest>(intPtr3) : null;
			}

			// Token: 0x06003968 RID: 14696 RVA: 0x00016379 File Offset: 0x00014579
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9B RID: 3483
			// (get) Token: 0x06003969 RID: 14697 RVA: 0x000E8B38 File Offset: 0x000E6D38
			// (set) Token: 0x0600396A RID: 14698 RVA: 0x00016382 File Offset: 0x00014582
			public unsafe ReadDailyTotalRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadDailyTotalRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400338D RID: 13197
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x0400338E RID: 13198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400338F RID: 13199
			private static readonly IntPtr NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0;

			// Token: 0x04003390 RID: 13200
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_ReadDailyTotalRequest_0;
		}

		// Token: 0x020003E4 RID: 996
		[ObfuscatedName("SA.Fitness.ReadDailyTotalRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600396B RID: 14699 RVA: 0x000E8B68 File Offset: 0x000E6D68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReadDailyTotalRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadDailyTotalRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadDailyTotalRequest.__c>.NativeClassPtr);
				ReadDailyTotalRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadDailyTotalRequest.__c>.NativeClassPtr, "<>9");
				ReadDailyTotalRequest.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadDailyTotalRequest.__c>.NativeClassPtr, "<>9__5_0");
				ReadDailyTotalRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest.__c>.NativeClassPtr, 100670537);
				ReadDailyTotalRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_ReadDailyTotalResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalRequest.__c>.NativeClassPtr, 100670538);
			}

			// Token: 0x0600396C RID: 14700 RVA: 0x000E8BE4 File Offset: 0x000E6DE4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadDailyTotalRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600396D RID: 14701 RVA: 0x000E8C20 File Offset: 0x000E6E20
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__5_0(ReadDailyTotalResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_ReadDailyTotalResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600396E RID: 14702 RVA: 0x000163A1 File Offset: 0x000145A1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9C RID: 3484
			// (get) Token: 0x0600396F RID: 14703 RVA: 0x000E8C64 File Offset: 0x000E6E64
			// (set) Token: 0x06003970 RID: 14704 RVA: 0x000163AA File Offset: 0x000145AA
			public unsafe static ReadDailyTotalRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadDailyTotalRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadDailyTotalRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadDailyTotalRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D9D RID: 3485
			// (get) Token: 0x06003971 RID: 14705 RVA: 0x000E8C8C File Offset: 0x000E6E8C
			// (set) Token: 0x06003972 RID: 14706 RVA: 0x000163BC File Offset: 0x000145BC
			public unsafe static Action<ReadDailyTotalResult> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadDailyTotalRequest.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReadDailyTotalResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadDailyTotalRequest.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003391 RID: 13201
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003392 RID: 13202
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04003393 RID: 13203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003394 RID: 13204
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_ReadDailyTotalResult_0;
		}
	}
}
