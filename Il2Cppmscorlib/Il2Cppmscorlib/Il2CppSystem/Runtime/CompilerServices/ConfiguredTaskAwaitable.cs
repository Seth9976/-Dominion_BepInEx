using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000423 RID: 1059
	public sealed class ConfiguredTaskAwaitable : ValueType
	{
		// Token: 0x06004208 RID: 16904 RVA: 0x001308C4 File Offset: 0x0012EAC4
		// Note: this type is marked as 'beforefieldinit'.
		static ConfiguredTaskAwaitable()
		{
			Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredTaskAwaitable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr);
			ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, "m_configuredTaskAwaiter");
			ConfiguredTaskAwaitable.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, 100672903);
			ConfiguredTaskAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, 100672904);
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00130930 File Offset: 0x0012EB30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 357098, RefRangeEnd = 357101, XrefRangeStart = 357097, XrefRangeEnd = 357098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00130990 File Offset: 0x0012EB90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108457, RefRangeEnd = 108458, XrefRangeStart = 108457, XrefRangeEnd = 108458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(intPtr);
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x000192A0 File Offset: 0x000174A0
		public ConfiguredTaskAwaitable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x000192A9 File Offset: 0x000174A9
		public ConfiguredTaskAwaitable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr))
		{
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x001309CC File Offset: 0x0012EBCC
		// (set) Token: 0x0600420E RID: 16910 RVA: 0x000192BB File Offset: 0x000174BB
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter);
				return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040035C9 RID: 13769
		private static readonly IntPtr NativeFieldInfoPtr_m_configuredTaskAwaiter;

		// Token: 0x040035CA RID: 13770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0;

		// Token: 0x040035CB RID: 13771
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0;

		// Token: 0x0200063E RID: 1598
		public sealed class ConfiguredTaskAwaiter : ValueType, INotifyCompletion
		{
			// Token: 0x060054A4 RID: 21668 RVA: 0x00176460 File Offset: 0x00174660
			// Note: this type is marked as 'beforefieldinit'.
			static ConfiguredTaskAwaiter()
			{
				Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, "ConfiguredTaskAwaiter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, "m_task");
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, "m_continueOnCapturedContext");
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100672905);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100672906);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100672907);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100672908);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100672909);
			}

			// Token: 0x060054A5 RID: 21669 RVA: 0x00176518 File Offset: 0x00174718
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 357066, RefRangeEnd = 357070, XrefRangeStart = 357066, XrefRangeEnd = 357066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015B1 RID: 5553
			// (get) Token: 0x060054A6 RID: 21670 RVA: 0x00176578 File Offset: 0x00174778
			public unsafe bool IsCompleted
			{
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 356963, RefRangeEnd = 357021, XrefRangeStart = 356963, XrefRangeEnd = 357021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054A7 RID: 21671 RVA: 0x001765BC File Offset: 0x001747BC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 357071, RefRangeEnd = 357073, XrefRangeStart = 357070, XrefRangeEnd = 357071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054A8 RID: 21672 RVA: 0x00176604 File Offset: 0x00174804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357073, XrefRangeEnd = 357074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnsafeOnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054A9 RID: 21673 RVA: 0x0017664C File Offset: 0x0017484C
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 357075, RefRangeEnd = 357097, XrefRangeStart = 357074, XrefRangeEnd = 357075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetResult()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054AA RID: 21674 RVA: 0x00020ABE File Offset: 0x0001ECBE
			public ConfiguredTaskAwaiter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060054AB RID: 21675 RVA: 0x00020AC7 File Offset: 0x0001ECC7
			public ConfiguredTaskAwaiter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
			}

			// Token: 0x170015AF RID: 5551
			// (get) Token: 0x060054AC RID: 21676 RVA: 0x00176684 File Offset: 0x00174884
			// (set) Token: 0x060054AD RID: 21677 RVA: 0x00020AD9 File Offset: 0x0001ECD9
			public unsafe Task m_task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B0 RID: 5552
			// (get) Token: 0x060054AE RID: 21678 RVA: 0x001766B4 File Offset: 0x001748B4
			// (set) Token: 0x060054AF RID: 21679 RVA: 0x00020AF8 File Offset: 0x0001ECF8
			public unsafe bool m_continueOnCapturedContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext)) = value;
				}
			}

			// Token: 0x060054B0 RID: 21680 RVA: 0x00020B13 File Offset: 0x0001ED13
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x04004418 RID: 17432
			private static readonly IntPtr NativeFieldInfoPtr_m_task;

			// Token: 0x04004419 RID: 17433
			private static readonly IntPtr NativeFieldInfoPtr_m_continueOnCapturedContext;

			// Token: 0x0400441A RID: 17434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0;

			// Token: 0x0400441B RID: 17435
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x0400441C RID: 17436
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x0400441D RID: 17437
			private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x0400441E RID: 17438
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;
		}
	}
}
