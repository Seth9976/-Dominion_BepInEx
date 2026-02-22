using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000116 RID: 278
	public class WebCompletionSource : Object
	{
		// Token: 0x060011E8 RID: 4584 RVA: 0x0005317C File Offset: 0x0005137C
		// Note: this type is marked as 'beforefieldinit'.
		static WebCompletionSource()
		{
			Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebCompletionSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr);
			WebCompletionSource.NativeFieldInfoPtr_completion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, "completion");
			WebCompletionSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665766);
			WebCompletionSource.NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665767);
			WebCompletionSource.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665768);
			WebCompletionSource.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665769);
			WebCompletionSource.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665770);
			WebCompletionSource.NativeMethodInfoPtr_ThrowOnError_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665771);
			WebCompletionSource.NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665772);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0005324C File Offset: 0x0005144C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 53594, RefRangeEnd = 53599, XrefRangeStart = 53587, XrefRangeEnd = 53594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebCompletionSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00053288 File Offset: 0x00051488
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 53607, RefRangeEnd = 53611, XrefRangeStart = 53599, XrefRangeEnd = 53607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000532C4 File Offset: 0x000514C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53624, RefRangeEnd = 53625, XrefRangeStart = 53611, XrefRangeEnd = 53624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00053300 File Offset: 0x00051500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53625, XrefRangeEnd = 53634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetException(Exception error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00053350 File Offset: 0x00051550
		public unsafe bool IsCompleted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53637, RefRangeEnd = 53638, XrefRangeStart = 53634, XrefRangeEnd = 53637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0005338C File Offset: 0x0005158C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53644, RefRangeEnd = 53645, XrefRangeStart = 53638, XrefRangeEnd = 53644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOnError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_ThrowOnError_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000533C0 File Offset: 0x000515C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 53657, RefRangeEnd = 53660, XrefRangeStart = 53645, XrefRangeEnd = 53657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> WaitForCompletion(bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnError;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000094B1 File Offset: 0x000076B1
		public WebCompletionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0005340C File Offset: 0x0005160C
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x000094BA File Offset: 0x000076BA
		public unsafe TaskCompletionSource<WebCompletionSource.Result> completion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.NativeFieldInfoPtr_completion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebCompletionSource.Result>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.NativeFieldInfoPtr_completion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeFieldInfoPtr_completion;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnError_Public_Void_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_Boolean_Boolean_0;

		// Token: 0x020001D0 RID: 464
		public enum State
		{
			// Token: 0x0400142B RID: 5163
			Running,
			// Token: 0x0400142C RID: 5164
			Completed,
			// Token: 0x0400142D RID: 5165
			Canceled,
			// Token: 0x0400142E RID: 5166
			Faulted
		}

		// Token: 0x020001D1 RID: 465
		public class Result : Object
		{
			// Token: 0x060019CB RID: 6603 RVA: 0x0006CDF8 File Offset: 0x0006AFF8
			// Note: this type is marked as 'beforefieldinit'.
			static Result()
			{
				Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, "Result");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr);
				WebCompletionSource.Result.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, "<State>k__BackingField");
				WebCompletionSource.Result.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, "<Error>k__BackingField");
				WebCompletionSource.Result.NativeMethodInfoPtr_get_State_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, 100665773);
				WebCompletionSource.Result.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, 100665774);
				WebCompletionSource.Result.NativeMethodInfoPtr__ctor_Public_Void_State_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, 100665775);
			}

			// Token: 0x17000840 RID: 2112
			// (get) Token: 0x060019CC RID: 6604 RVA: 0x0006CE88 File Offset: 0x0006B088
			public unsafe WebCompletionSource.State State
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.Result.NativeMethodInfoPtr_get_State_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000841 RID: 2113
			// (get) Token: 0x060019CD RID: 6605 RVA: 0x0006CEC4 File Offset: 0x0006B0C4
			public unsafe ExceptionDispatchInfo Error
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.Result.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
				}
			}

			// Token: 0x060019CE RID: 6606 RVA: 0x0006CF04 File Offset: 0x0006B104
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 50515, RefRangeEnd = 50526, XrefRangeStart = 50515, XrefRangeEnd = 50526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Result(WebCompletionSource.State state, ExceptionDispatchInfo error)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.Result.NativeMethodInfoPtr__ctor_Public_Void_State_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019CF RID: 6607 RVA: 0x0000DB53 File Offset: 0x0000BD53
			public Result(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700083E RID: 2110
			// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0006CF60 File Offset: 0x0006B160
			// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0000DB5C File Offset: 0x0000BD5C
			public unsafe WebCompletionSource.State _State_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.Result.NativeFieldInfoPtr__State_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.Result.NativeFieldInfoPtr__State_k__BackingField)) = value;
				}
			}

			// Token: 0x1700083F RID: 2111
			// (get) Token: 0x060019D2 RID: 6610 RVA: 0x0006CF88 File Offset: 0x0006B188
			// (set) Token: 0x060019D3 RID: 6611 RVA: 0x0000DB77 File Offset: 0x0000BD77
			public unsafe ExceptionDispatchInfo _Error_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.Result.NativeFieldInfoPtr__Error_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.Result.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400142F RID: 5167
			private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

			// Token: 0x04001430 RID: 5168
			private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

			// Token: 0x04001431 RID: 5169
			private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_State_0;

			// Token: 0x04001432 RID: 5170
			private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0;

			// Token: 0x04001433 RID: 5171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_State_ExceptionDispatchInfo_0;
		}

		// Token: 0x020001D2 RID: 466
		[ObfuscatedName("System.Net.WebCompletionSource+<WaitForCompletion>d__8")]
		public sealed class _WaitForCompletion_d__8 : ValueType
		{
			// Token: 0x060019D4 RID: 6612 RVA: 0x0006CFB8 File Offset: 0x0006B1B8
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForCompletion_d__8()
			{
				Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, "<WaitForCompletion>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr);
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "<>1__state");
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "<>t__builder");
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "<>4__this");
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr_throwOnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "throwOnError");
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "<>u__1");
				WebCompletionSource._WaitForCompletion_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, 100665776);
				WebCompletionSource._WaitForCompletion_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, 100665777);
			}

			// Token: 0x060019D5 RID: 6613 RVA: 0x0006D070 File Offset: 0x0006B270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53566, XrefRangeEnd = 53584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource._WaitForCompletion_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019D6 RID: 6614 RVA: 0x0006D0A8 File Offset: 0x0006B2A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53584, XrefRangeEnd = 53587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource._WaitForCompletion_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019D7 RID: 6615 RVA: 0x0000DB96 File Offset: 0x0000BD96
			public _WaitForCompletion_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019D8 RID: 6616 RVA: 0x0000DB9F File Offset: 0x0000BD9F
			public _WaitForCompletion_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0006D0F0 File Offset: 0x0006B2F0
			// (set) Token: 0x060019DA RID: 6618 RVA: 0x0000DBB1 File Offset: 0x0000BDB1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x060019DB RID: 6619 RVA: 0x0006D118 File Offset: 0x0006B318
			// (set) Token: 0x060019DC RID: 6620 RVA: 0x0000DBCC File Offset: 0x0000BDCC
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000844 RID: 2116
			// (get) Token: 0x060019DD RID: 6621 RVA: 0x0006D148 File Offset: 0x0006B348
			// (set) Token: 0x060019DE RID: 6622 RVA: 0x0000DBFA File Offset: 0x0000BDFA
			public unsafe WebCompletionSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000845 RID: 2117
			// (get) Token: 0x060019DF RID: 6623 RVA: 0x0006D178 File Offset: 0x0006B378
			// (set) Token: 0x060019E0 RID: 6624 RVA: 0x0000DC19 File Offset: 0x0000BE19
			public unsafe bool throwOnError
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr_throwOnError);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr_throwOnError)) = value;
				}
			}

			// Token: 0x17000846 RID: 2118
			// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0006D1A0 File Offset: 0x0006B3A0
			// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0000DC34 File Offset: 0x0000BE34
			public ConfiguredTaskAwaitable<WebCompletionSource.Result>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebCompletionSource.Result>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebCompletionSource.Result>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebCompletionSource.Result>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001434 RID: 5172
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001435 RID: 5173
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001436 RID: 5174
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001437 RID: 5175
			private static readonly IntPtr NativeFieldInfoPtr_throwOnError;

			// Token: 0x04001438 RID: 5176
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001439 RID: 5177
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400143A RID: 5178
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
