using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000349 RID: 841
	public class SubscriptionsRequest : Object
	{
		// Token: 0x060032D0 RID: 13008 RVA: 0x000D4098 File Offset: 0x000D2298
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriptionsRequest()
		{
			Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "SubscriptionsRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr);
			SubscriptionsRequest.NativeFieldInfoPtr_OnRequestFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, "OnRequestFinished");
			SubscriptionsRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, "id");
			SubscriptionsRequest.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, "dataType");
			SubscriptionsRequest.NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_SubscriptionsRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, 100669810);
			SubscriptionsRequest.NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_SubscriptionsRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, 100669811);
			SubscriptionsRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, 100669812);
			SubscriptionsRequest.NativeMethodInfoPtr_DispatchRequestResult_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, 100669813);
			SubscriptionsRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, 100669814);
			SubscriptionsRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, 100669815);
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000D417C File Offset: 0x000D237C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222819, RefRangeEnd = 222820, XrefRangeStart = 222815, XrefRangeEnd = 222819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRequestFinished(Action<SubscriptionsRequestResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_SubscriptionsRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000D41C0 File Offset: 0x000D23C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222820, XrefRangeEnd = 222824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRequestFinished(Action<SubscriptionsRequestResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_SubscriptionsRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x000D4204 File Offset: 0x000D2404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222842, RefRangeEnd = 222843, XrefRangeStart = 222824, XrefRangeEnd = 222842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionsRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x000D4240 File Offset: 0x000D2440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222894, RefRangeEnd = 222895, XrefRangeStart = 222843, XrefRangeEnd = 222894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchRequestResult(Il2CppStringArray bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.NativeMethodInfoPtr_DispatchRequestResult_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060032D5 RID: 13013 RVA: 0x000D4284 File Offset: 0x000D2484
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x000D42C0 File Offset: 0x000D24C0
		public unsafe DataType DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x00013C32 File Offset: 0x00011E32
		public SubscriptionsRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x000D4300 File Offset: 0x000D2500
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00013C3B File Offset: 0x00011E3B
		public unsafe Action<SubscriptionsRequestResult> OnRequestFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequest.NativeFieldInfoPtr_OnRequestFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SubscriptionsRequestResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequest.NativeFieldInfoPtr_OnRequestFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x000D4330 File Offset: 0x000D2530
		// (set) Token: 0x060032DB RID: 13019 RVA: 0x00013C5A File Offset: 0x00011E5A
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x000D4358 File Offset: 0x000D2558
		// (set) Token: 0x060032DD RID: 13021 RVA: 0x00013C75 File Offset: 0x00011E75
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequest.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequest.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F6F RID: 12143
		private static readonly IntPtr NativeFieldInfoPtr_OnRequestFinished;

		// Token: 0x04002F70 RID: 12144
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F71 RID: 12145
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002F72 RID: 12146
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRequestFinished_Public_add_Void_Action_1_SubscriptionsRequestResult_0;

		// Token: 0x04002F73 RID: 12147
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRequestFinished_Public_rem_Void_Action_1_SubscriptionsRequestResult_0;

		// Token: 0x04002F74 RID: 12148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002F75 RID: 12149
		private static readonly IntPtr NativeMethodInfoPtr_DispatchRequestResult_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002F76 RID: 12150
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F77 RID: 12151
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x020003F3 RID: 1011
		public class Builder : Object
		{
			// Token: 0x060039F1 RID: 14833 RVA: 0x000EA79C File Offset: 0x000E899C
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<SubscriptionsRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriptionsRequest.Builder>.NativeClassPtr);
				SubscriptionsRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionsRequest.Builder>.NativeClassPtr, "request");
				SubscriptionsRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest.Builder>.NativeClassPtr, 100670598);
				SubscriptionsRequest.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest.Builder>.NativeClassPtr, 100670599);
				SubscriptionsRequest.Builder.NativeMethodInfoPtr_Build_Public_SubscriptionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest.Builder>.NativeClassPtr, 100670600);
			}

			// Token: 0x060039F2 RID: 14834 RVA: 0x000EA818 File Offset: 0x000E8A18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222814, RefRangeEnd = 222815, XrefRangeStart = 222809, XrefRangeEnd = 222814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriptionsRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039F3 RID: 14835 RVA: 0x000EA854 File Offset: 0x000E8A54
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubscriptionsRequest.Builder SetDataType(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionsRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039F4 RID: 14836 RVA: 0x000EA8A4 File Offset: 0x000E8AA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubscriptionsRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.Builder.NativeMethodInfoPtr_Build_Public_SubscriptionsRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionsRequest>(intPtr3) : null;
			}

			// Token: 0x060039F5 RID: 14837 RVA: 0x00016645 File Offset: 0x00014845
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB5 RID: 3509
			// (get) Token: 0x060039F6 RID: 14838 RVA: 0x000EA8E4 File Offset: 0x000E8AE4
			// (set) Token: 0x060039F7 RID: 14839 RVA: 0x0001664E File Offset: 0x0001484E
			public unsafe SubscriptionsRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionsRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033E0 RID: 13280
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040033E1 RID: 13281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033E2 RID: 13282
			private static readonly IntPtr NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0;

			// Token: 0x040033E3 RID: 13283
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_SubscriptionsRequest_0;
		}

		// Token: 0x020003F4 RID: 1012
		[ObfuscatedName("SA.Fitness.SubscriptionsRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060039F8 RID: 14840 RVA: 0x000EA914 File Offset: 0x000E8B14
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SubscriptionsRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubscriptionsRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriptionsRequest.__c>.NativeClassPtr);
				SubscriptionsRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionsRequest.__c>.NativeClassPtr, "<>9");
				SubscriptionsRequest.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionsRequest.__c>.NativeClassPtr, "<>9__5_0");
				SubscriptionsRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest.__c>.NativeClassPtr, 100670602);
				SubscriptionsRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_SubscriptionsRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequest.__c>.NativeClassPtr, 100670603);
			}

			// Token: 0x060039F9 RID: 14841 RVA: 0x000EA990 File Offset: 0x000E8B90
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriptionsRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039FA RID: 14842 RVA: 0x000EA9CC File Offset: 0x000E8BCC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__5_0(SubscriptionsRequestResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_SubscriptionsRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039FB RID: 14843 RVA: 0x0001666D File Offset: 0x0001486D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB6 RID: 3510
			// (get) Token: 0x060039FC RID: 14844 RVA: 0x000EAA10 File Offset: 0x000E8C10
			// (set) Token: 0x060039FD RID: 14845 RVA: 0x00016676 File Offset: 0x00014876
			public unsafe static SubscriptionsRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SubscriptionsRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionsRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SubscriptionsRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB7 RID: 3511
			// (get) Token: 0x060039FE RID: 14846 RVA: 0x000EAA38 File Offset: 0x000E8C38
			// (set) Token: 0x060039FF RID: 14847 RVA: 0x00016688 File Offset: 0x00014888
			public unsafe static Action<SubscriptionsRequestResult> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SubscriptionsRequest.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SubscriptionsRequestResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SubscriptionsRequest.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033E4 RID: 13284
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033E5 RID: 13285
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040033E6 RID: 13286
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033E7 RID: 13287
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_SubscriptionsRequestResult_0;
		}
	}
}
