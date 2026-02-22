using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A8 RID: 680
	public sealed class UnwrapPromise<TResult> : Task<TResult>
	{
		// Token: 0x06002E09 RID: 11785 RVA: 0x000E9508 File Offset: 0x000E7708
		// Note: this type is marked as 'beforefieldinit'.
		static UnwrapPromise()
		{
			Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "UnwrapPromise`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr);
			UnwrapPromise<TResult>.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "_state");
			UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "_lookForOce");
			UnwrapPromise<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670603);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670604);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670605);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670606);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670607);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670608);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670609);
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000E9628 File Offset: 0x000E7828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336260, XrefRangeEnd = 336278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnwrapPromise(Task outerTask, bool lookForOce)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookForOce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000E9684 File Offset: 0x000E7884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336278, XrefRangeEnd = 336286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000E96C8 File Offset: 0x000E78C8
		[CallerCount(0)]
		public unsafe void InvokeCore(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000E970C File Offset: 0x000E790C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336286, XrefRangeEnd = 336302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCoreAsync(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000E9750 File Offset: 0x000E7950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336302, XrefRangeEnd = 336314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCompletedOuterTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x000E9794 File Offset: 0x000E7994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336314, XrefRangeEnd = 336347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetFromTask(Task task, bool lookForOce)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookForOce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x000E97F0 File Offset: 0x000E79F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336347, XrefRangeEnd = 336349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInnerTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0001012A File Offset: 0x0000E32A
		public UnwrapPromise(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x000E9834 File Offset: 0x000E7A34
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x00010133 File Offset: 0x0000E333
		public unsafe byte _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x000E985C File Offset: 0x000E7A5C
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x0001014E File Offset: 0x0000E34E
		public unsafe bool _lookForOce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce)) = value;
			}
		}

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeFieldInfoPtr__lookForOce;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0;

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0;

		// Token: 0x02000610 RID: 1552
		[ObfuscatedName("System.Threading.Tasks.UnwrapPromise`1+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06005341 RID: 21313 RVA: 0x001725A0 File Offset: 0x001707A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr);
				UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, "<>9");
				UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, "<>9__8_0");
				UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, 100670611);
				UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, 100670612);
			}

			// Token: 0x06005342 RID: 21314 RVA: 0x00172658 File Offset: 0x00170858
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005343 RID: 21315 RVA: 0x00172694 File Offset: 0x00170894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336256, XrefRangeEnd = 336260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InvokeCoreAsync_b__8_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005344 RID: 21316 RVA: 0x0001FE34 File Offset: 0x0001E034
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001542 RID: 5442
			// (get) Token: 0x06005345 RID: 21317 RVA: 0x001726D8 File Offset: 0x001708D8
			// (set) Token: 0x06005346 RID: 21318 RVA: 0x0001FE3D File Offset: 0x0001E03D
			public unsafe static UnwrapPromise<TResult>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnwrapPromise<TResult>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001543 RID: 5443
			// (get) Token: 0x06005347 RID: 21319 RVA: 0x00172700 File Offset: 0x00170900
			// (set) Token: 0x06005348 RID: 21320 RVA: 0x0001FE4F File Offset: 0x0001E04F
			public unsafe static WaitCallback __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004351 RID: 17233
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004352 RID: 17234
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04004353 RID: 17235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004354 RID: 17236
			private static readonly IntPtr NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0;
		}
	}
}
