using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x02000347 RID: 839
	public class SubscribeRequest : Object
	{
		// Token: 0x060032BC RID: 12988 RVA: 0x000D3C80 File Offset: 0x000D1E80
		// Note: this type is marked as 'beforefieldinit'.
		static SubscribeRequest()
		{
			Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "SubscribeRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr);
			SubscribeRequest.NativeFieldInfoPtr_OnSubscribeFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, "OnSubscribeFinished");
			SubscribeRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, "id");
			SubscribeRequest.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, "dataType");
			SubscribeRequest.NativeMethodInfoPtr_add_OnSubscribeFinished_Public_add_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, 100669802);
			SubscribeRequest.NativeMethodInfoPtr_remove_OnSubscribeFinished_Public_rem_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, 100669803);
			SubscribeRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, 100669804);
			SubscribeRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, 100669805);
			SubscribeRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, 100669806);
			SubscribeRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, 100669807);
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x000D3D64 File Offset: 0x000D1F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222780, RefRangeEnd = 222781, XrefRangeStart = 222776, XrefRangeEnd = 222780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSubscribeFinished(Action<Result> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.NativeMethodInfoPtr_add_OnSubscribeFinished_Public_add_Void_Action_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x000D3DA8 File Offset: 0x000D1FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222781, XrefRangeEnd = 222785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSubscribeFinished(Action<Result> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.NativeMethodInfoPtr_remove_OnSubscribeFinished_Public_rem_Void_Action_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000D3DEC File Offset: 0x000D1FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222803, RefRangeEnd = 222804, XrefRangeStart = 222785, XrefRangeEnd = 222803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscribeRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x000D3E28 File Offset: 0x000D2028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222808, RefRangeEnd = 222809, XrefRangeStart = 222804, XrefRangeEnd = 222808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchResult(Result result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x000D3E6C File Offset: 0x000D206C
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x000D3EA8 File Offset: 0x000D20A8
		public unsafe DataType DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x00013BA8 File Offset: 0x00011DA8
		public SubscribeRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x000D3EE8 File Offset: 0x000D20E8
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x00013BB1 File Offset: 0x00011DB1
		public unsafe Action<Result> OnSubscribeFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribeRequest.NativeFieldInfoPtr_OnSubscribeFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribeRequest.NativeFieldInfoPtr_OnSubscribeFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x000D3F18 File Offset: 0x000D2118
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x00013BD0 File Offset: 0x00011DD0
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribeRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribeRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x000D3F40 File Offset: 0x000D2140
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x00013BEB File Offset: 0x00011DEB
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribeRequest.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribeRequest.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F63 RID: 12131
		private static readonly IntPtr NativeFieldInfoPtr_OnSubscribeFinished;

		// Token: 0x04002F64 RID: 12132
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F65 RID: 12133
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002F66 RID: 12134
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSubscribeFinished_Public_add_Void_Action_1_Result_0;

		// Token: 0x04002F67 RID: 12135
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSubscribeFinished_Public_rem_Void_Action_1_Result_0;

		// Token: 0x04002F68 RID: 12136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002F69 RID: 12137
		private static readonly IntPtr NativeMethodInfoPtr_DispatchResult_Public_Void_Result_0;

		// Token: 0x04002F6A RID: 12138
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F6B RID: 12139
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x020003F1 RID: 1009
		public class Builder : Object
		{
			// Token: 0x060039E2 RID: 14818 RVA: 0x000EA4D8 File Offset: 0x000E86D8
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<SubscribeRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscribeRequest.Builder>.NativeClassPtr);
				SubscribeRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribeRequest.Builder>.NativeClassPtr, "request");
				SubscribeRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest.Builder>.NativeClassPtr, 100670592);
				SubscribeRequest.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest.Builder>.NativeClassPtr, 100670593);
				SubscribeRequest.Builder.NativeMethodInfoPtr_Build_Public_SubscribeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest.Builder>.NativeClassPtr, 100670594);
			}

			// Token: 0x060039E3 RID: 14819 RVA: 0x000EA554 File Offset: 0x000E8754
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222775, RefRangeEnd = 222776, XrefRangeStart = 222770, XrefRangeEnd = 222775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscribeRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039E4 RID: 14820 RVA: 0x000EA590 File Offset: 0x000E8790
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubscribeRequest.Builder SetDataType(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscribeRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039E5 RID: 14821 RVA: 0x000EA5E0 File Offset: 0x000E87E0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubscribeRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.Builder.NativeMethodInfoPtr_Build_Public_SubscribeRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscribeRequest>(intPtr3) : null;
			}

			// Token: 0x060039E6 RID: 14822 RVA: 0x000165F0 File Offset: 0x000147F0
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB2 RID: 3506
			// (get) Token: 0x060039E7 RID: 14823 RVA: 0x000EA620 File Offset: 0x000E8820
			// (set) Token: 0x060039E8 RID: 14824 RVA: 0x000165F9 File Offset: 0x000147F9
			public unsafe SubscribeRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribeRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscribeRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribeRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033D8 RID: 13272
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040033D9 RID: 13273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033DA RID: 13274
			private static readonly IntPtr NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0;

			// Token: 0x040033DB RID: 13275
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_SubscribeRequest_0;
		}

		// Token: 0x020003F2 RID: 1010
		[ObfuscatedName("SA.Fitness.SubscribeRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060039E9 RID: 14825 RVA: 0x000EA650 File Offset: 0x000E8850
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SubscribeRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubscribeRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscribeRequest.__c>.NativeClassPtr);
				SubscribeRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribeRequest.__c>.NativeClassPtr, "<>9");
				SubscribeRequest.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribeRequest.__c>.NativeClassPtr, "<>9__5_0");
				SubscribeRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest.__c>.NativeClassPtr, 100670596);
				SubscribeRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribeRequest.__c>.NativeClassPtr, 100670597);
			}

			// Token: 0x060039EA RID: 14826 RVA: 0x000EA6CC File Offset: 0x000E88CC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscribeRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039EB RID: 14827 RVA: 0x000EA708 File Offset: 0x000E8908
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__5_0(Result <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribeRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039EC RID: 14828 RVA: 0x00016618 File Offset: 0x00014818
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB3 RID: 3507
			// (get) Token: 0x060039ED RID: 14829 RVA: 0x000EA74C File Offset: 0x000E894C
			// (set) Token: 0x060039EE RID: 14830 RVA: 0x00016621 File Offset: 0x00014821
			public unsafe static SubscribeRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SubscribeRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscribeRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SubscribeRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB4 RID: 3508
			// (get) Token: 0x060039EF RID: 14831 RVA: 0x000EA774 File Offset: 0x000E8974
			// (set) Token: 0x060039F0 RID: 14832 RVA: 0x00016633 File Offset: 0x00014833
			public unsafe static Action<Result> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SubscribeRequest.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SubscribeRequest.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033DC RID: 13276
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033DD RID: 13277
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040033DE RID: 13278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033DF RID: 13279
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Result_0;
		}
	}
}
