using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000424 RID: 1060
	public sealed class ConfiguredTaskAwaitable<TResult> : ValueType
	{
		// Token: 0x0600420F RID: 16911 RVA: 0x001309FC File Offset: 0x0012EBFC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfiguredTaskAwaitable()
		{
			Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredTaskAwaitable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr);
			ConfiguredTaskAwaitable<TResult>.NativeFieldInfoPtr_m_configuredTaskAwaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, "m_configuredTaskAwaiter");
			ConfiguredTaskAwaitable<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, 100672910);
			ConfiguredTaskAwaitable<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, 100672911);
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x00130AA4 File Offset: 0x0012ECA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357102, RefRangeEnd = 357103, XrefRangeStart = 357101, XrefRangeEnd = 357102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x00130B04 File Offset: 0x0012ED04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108457, RefRangeEnd = 108458, XrefRangeStart = 108457, XrefRangeEnd = 108458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter(intPtr);
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x000192E9 File Offset: 0x000174E9
		public ConfiguredTaskAwaitable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x000192F2 File Offset: 0x000174F2
		public ConfiguredTaskAwaitable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x00130B40 File Offset: 0x0012ED40
		// (set) Token: 0x06004215 RID: 16917 RVA: 0x00019304 File Offset: 0x00017504
		public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter m_configuredTaskAwaiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.NativeFieldInfoPtr_m_configuredTaskAwaiter);
				return new ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.NativeFieldInfoPtr_m_configuredTaskAwaiter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040035CC RID: 13772
		private static readonly IntPtr NativeFieldInfoPtr_m_configuredTaskAwaiter;

		// Token: 0x040035CD RID: 13773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0;

		// Token: 0x040035CE RID: 13774
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0;

		// Token: 0x0200063F RID: 1599
		public sealed class ConfiguredTaskAwaiter : ValueType, INotifyCompletion
		{
			// Token: 0x060054B1 RID: 21681 RVA: 0x001766DC File Offset: 0x001748DC
			// Note: this type is marked as 'beforefieldinit'.
			static ConfiguredTaskAwaiter()
			{
				Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, "ConfiguredTaskAwaiter"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, "m_task");
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, "m_continueOnCapturedContext");
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100672912);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100672913);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100672914);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100672915);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100672916);
			}

			// Token: 0x060054B2 RID: 21682 RVA: 0x001767D0 File Offset: 0x001749D0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 357066, RefRangeEnd = 357070, XrefRangeStart = 357066, XrefRangeEnd = 357070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015B4 RID: 5556
			// (get) Token: 0x060054B3 RID: 21683 RVA: 0x00176830 File Offset: 0x00174A30
			public unsafe bool IsCompleted
			{
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 356963, RefRangeEnd = 357021, XrefRangeStart = 356963, XrefRangeEnd = 357021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054B4 RID: 21684 RVA: 0x00176874 File Offset: 0x00174A74
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 357071, RefRangeEnd = 357073, XrefRangeStart = 357071, XrefRangeEnd = 357073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054B5 RID: 21685 RVA: 0x001768BC File Offset: 0x00174ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnsafeOnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054B6 RID: 21686 RVA: 0x00176904 File Offset: 0x00174B04
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 357030, RefRangeEnd = 357066, XrefRangeStart = 357030, XrefRangeEnd = 357066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TResult GetResult()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}

			// Token: 0x060054B7 RID: 21687 RVA: 0x00020B21 File Offset: 0x0001ED21
			public ConfiguredTaskAwaiter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060054B8 RID: 21688 RVA: 0x00020B2A File Offset: 0x0001ED2A
			public ConfiguredTaskAwaiter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
			}

			// Token: 0x170015B2 RID: 5554
			// (get) Token: 0x060054B9 RID: 21689 RVA: 0x00176944 File Offset: 0x00174B44
			// (set) Token: 0x060054BA RID: 21690 RVA: 0x00020B3C File Offset: 0x0001ED3C
			public unsafe Task<TResult> m_task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B3 RID: 5555
			// (get) Token: 0x060054BB RID: 21691 RVA: 0x00176974 File Offset: 0x00174B74
			// (set) Token: 0x060054BC RID: 21692 RVA: 0x00020B5B File Offset: 0x0001ED5B
			public unsafe bool m_continueOnCapturedContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext)) = value;
				}
			}

			// Token: 0x060054BD RID: 21693 RVA: 0x00020B76 File Offset: 0x0001ED76
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x0400441F RID: 17439
			private static readonly IntPtr NativeFieldInfoPtr_m_task;

			// Token: 0x04004420 RID: 17440
			private static readonly IntPtr NativeFieldInfoPtr_m_continueOnCapturedContext;

			// Token: 0x04004421 RID: 17441
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0;

			// Token: 0x04004422 RID: 17442
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x04004423 RID: 17443
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004424 RID: 17444
			private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004425 RID: 17445
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_TResult_0;
		}
	}
}
