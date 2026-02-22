using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x0200034B RID: 843
	public class UnsubscribeRequest : Object
	{
		// Token: 0x060032E9 RID: 13033 RVA: 0x000D460C File Offset: 0x000D280C
		// Note: this type is marked as 'beforefieldinit'.
		static UnsubscribeRequest()
		{
			Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "UnsubscribeRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr);
			UnsubscribeRequest.NativeFieldInfoPtr_OnUnsubscribeFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, "OnUnsubscribeFinished");
			UnsubscribeRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, "id");
			UnsubscribeRequest.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, "dataType");
			UnsubscribeRequest.NativeMethodInfoPtr_add_OnUnsubscribeFinished_Public_add_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, 100669821);
			UnsubscribeRequest.NativeMethodInfoPtr_remove_OnUnsubscribeFinished_Public_rem_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, 100669822);
			UnsubscribeRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, 100669823);
			UnsubscribeRequest.NativeMethodInfoPtr_DispatchUnsubscribeResult_Public_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, 100669824);
			UnsubscribeRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, 100669825);
			UnsubscribeRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, 100669826);
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x000D46F0 File Offset: 0x000D28F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222946, RefRangeEnd = 222947, XrefRangeStart = 222942, XrefRangeEnd = 222946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnUnsubscribeFinished(Action<Result> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.NativeMethodInfoPtr_add_OnUnsubscribeFinished_Public_add_Void_Action_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x000D4734 File Offset: 0x000D2934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222947, XrefRangeEnd = 222951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnUnsubscribeFinished(Action<Result> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.NativeMethodInfoPtr_remove_OnUnsubscribeFinished_Public_rem_Void_Action_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x000D4778 File Offset: 0x000D2978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222951, XrefRangeEnd = 222969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsubscribeRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x000D47B4 File Offset: 0x000D29B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222973, RefRangeEnd = 222974, XrefRangeStart = 222969, XrefRangeEnd = 222973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchUnsubscribeResult(Result result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.NativeMethodInfoPtr_DispatchUnsubscribeResult_Public_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x000D47F8 File Offset: 0x000D29F8
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x000D4834 File Offset: 0x000D2A34
		public unsafe DataType DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x00013CD7 File Offset: 0x00011ED7
		public UnsubscribeRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060032F1 RID: 13041 RVA: 0x000D4874 File Offset: 0x000D2A74
		// (set) Token: 0x060032F2 RID: 13042 RVA: 0x00013CE0 File Offset: 0x00011EE0
		public unsafe Action<Result> OnUnsubscribeFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsubscribeRequest.NativeFieldInfoPtr_OnUnsubscribeFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsubscribeRequest.NativeFieldInfoPtr_OnUnsubscribeFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x000D48A4 File Offset: 0x000D2AA4
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x00013CFF File Offset: 0x00011EFF
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsubscribeRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsubscribeRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x000D48CC File Offset: 0x000D2ACC
		// (set) Token: 0x060032F6 RID: 13046 RVA: 0x00013D1A File Offset: 0x00011F1A
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsubscribeRequest.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsubscribeRequest.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F7F RID: 12159
		private static readonly IntPtr NativeFieldInfoPtr_OnUnsubscribeFinished;

		// Token: 0x04002F80 RID: 12160
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F81 RID: 12161
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002F82 RID: 12162
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUnsubscribeFinished_Public_add_Void_Action_1_Result_0;

		// Token: 0x04002F83 RID: 12163
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUnsubscribeFinished_Public_rem_Void_Action_1_Result_0;

		// Token: 0x04002F84 RID: 12164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002F85 RID: 12165
		private static readonly IntPtr NativeMethodInfoPtr_DispatchUnsubscribeResult_Public_Void_Result_0;

		// Token: 0x04002F86 RID: 12166
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F87 RID: 12167
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x020003F5 RID: 1013
		public class Builder : Object
		{
			// Token: 0x06003A00 RID: 14848 RVA: 0x000EAA60 File Offset: 0x000E8C60
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<UnsubscribeRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsubscribeRequest.Builder>.NativeClassPtr);
				UnsubscribeRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsubscribeRequest.Builder>.NativeClassPtr, "request");
				UnsubscribeRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest.Builder>.NativeClassPtr, 100670604);
				UnsubscribeRequest.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest.Builder>.NativeClassPtr, 100670605);
				UnsubscribeRequest.Builder.NativeMethodInfoPtr_Build_Public_UnsubscribeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest.Builder>.NativeClassPtr, 100670606);
			}

			// Token: 0x06003A01 RID: 14849 RVA: 0x000EAADC File Offset: 0x000E8CDC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222941, RefRangeEnd = 222942, XrefRangeStart = 222919, XrefRangeEnd = 222941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsubscribeRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A02 RID: 14850 RVA: 0x000EAB18 File Offset: 0x000E8D18
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnsubscribeRequest.Builder SetDataType(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.Builder.NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnsubscribeRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003A03 RID: 14851 RVA: 0x000EAB68 File Offset: 0x000E8D68
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnsubscribeRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.Builder.NativeMethodInfoPtr_Build_Public_UnsubscribeRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnsubscribeRequest>(intPtr3) : null;
			}

			// Token: 0x06003A04 RID: 14852 RVA: 0x0001669A File Offset: 0x0001489A
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB8 RID: 3512
			// (get) Token: 0x06003A05 RID: 14853 RVA: 0x000EABA8 File Offset: 0x000E8DA8
			// (set) Token: 0x06003A06 RID: 14854 RVA: 0x000166A3 File Offset: 0x000148A3
			public unsafe UnsubscribeRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsubscribeRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnsubscribeRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsubscribeRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033E8 RID: 13288
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040033E9 RID: 13289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033EA RID: 13290
			private static readonly IntPtr NativeMethodInfoPtr_SetDataType_Public_Builder_DataType_0;

			// Token: 0x040033EB RID: 13291
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_UnsubscribeRequest_0;
		}

		// Token: 0x020003F6 RID: 1014
		[ObfuscatedName("SA.Fitness.UnsubscribeRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003A07 RID: 14855 RVA: 0x000EABD8 File Offset: 0x000E8DD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnsubscribeRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsubscribeRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsubscribeRequest.__c>.NativeClassPtr);
				UnsubscribeRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsubscribeRequest.__c>.NativeClassPtr, "<>9");
				UnsubscribeRequest.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsubscribeRequest.__c>.NativeClassPtr, "<>9__5_0");
				UnsubscribeRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest.__c>.NativeClassPtr, 100670608);
				UnsubscribeRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsubscribeRequest.__c>.NativeClassPtr, 100670609);
			}

			// Token: 0x06003A08 RID: 14856 RVA: 0x000EAC54 File Offset: 0x000E8E54
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsubscribeRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A09 RID: 14857 RVA: 0x000EAC90 File Offset: 0x000E8E90
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsubscribeRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A0A RID: 14858 RVA: 0x000166C2 File Offset: 0x000148C2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB9 RID: 3513
			// (get) Token: 0x06003A0B RID: 14859 RVA: 0x000EACD4 File Offset: 0x000E8ED4
			// (set) Token: 0x06003A0C RID: 14860 RVA: 0x000166CB File Offset: 0x000148CB
			public unsafe static UnsubscribeRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnsubscribeRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnsubscribeRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnsubscribeRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBA RID: 3514
			// (get) Token: 0x06003A0D RID: 14861 RVA: 0x000EACFC File Offset: 0x000E8EFC
			// (set) Token: 0x06003A0E RID: 14862 RVA: 0x000166DD File Offset: 0x000148DD
			public unsafe static Action<Result> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnsubscribeRequest.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnsubscribeRequest.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033EC RID: 13292
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033ED RID: 13293
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040033EE RID: 13294
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033EF RID: 13295
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Result_0;
		}
	}
}
