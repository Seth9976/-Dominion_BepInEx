using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AF RID: 687
	public sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06002E43 RID: 11843 RVA: 0x000EA3C4 File Offset: 0x000E85C4
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationContextAwaitTaskContinuation()
		{
			Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "SynchronizationContextAwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr);
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "s_postCallback");
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "s_postActionCallback");
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "m_syncContext");
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100670632);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100670633);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100670634);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100670635);
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000EA480 File Offset: 0x000E8680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336483, XrefRangeEnd = 336484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x000EA4FC File Offset: 0x000E86FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336484, XrefRangeEnd = 336521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task task, bool canInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x000EA54C File Offset: 0x000E874C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336521, XrefRangeEnd = 336527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostAction(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x000EA584 File Offset: 0x000E8784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336527, XrefRangeEnd = 336540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextCallback GetPostActionCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr3) : null;
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x00010274 File Offset: 0x0000E474
		public SynchronizationContextAwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x000EA5B8 File Offset: 0x000E87B8
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x0001027D File Offset: 0x0000E47D
		public unsafe static SendOrPostCallback s_postCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x000EA5E0 File Offset: 0x000E87E0
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x0001028F File Offset: 0x0000E48F
		public unsafe static ContextCallback s_postActionCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000EA608 File Offset: 0x000E8808
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x000102A1 File Offset: 0x0000E4A1
		public unsafe SynchronizationContext m_syncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeFieldInfoPtr_s_postCallback;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeFieldInfoPtr_s_postActionCallback;

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeFieldInfoPtr_m_syncContext;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0;

		// Token: 0x02000611 RID: 1553
		[ObfuscatedName("System.Threading.Tasks.SynchronizationContextAwaitTaskContinuation+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06005349 RID: 21321 RVA: 0x00172728 File Offset: 0x00170928
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr);
				SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, "<>9");
				SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, 100670638);
				SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, 100670639);
			}

			// Token: 0x0600534A RID: 21322 RVA: 0x00172790 File Offset: 0x00170990
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600534B RID: 21323 RVA: 0x001727CC File Offset: 0x001709CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336478, XrefRangeEnd = 336483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__7_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600534C RID: 21324 RVA: 0x0001FE61 File Offset: 0x0001E061
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001544 RID: 5444
			// (get) Token: 0x0600534D RID: 21325 RVA: 0x00172810 File Offset: 0x00170A10
			// (set) Token: 0x0600534E RID: 21326 RVA: 0x0001FE6A File Offset: 0x0001E06A
			public unsafe static SynchronizationContextAwaitTaskContinuation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContextAwaitTaskContinuation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004355 RID: 17237
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004356 RID: 17238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004357 RID: 17239
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0;
		}
	}
}
