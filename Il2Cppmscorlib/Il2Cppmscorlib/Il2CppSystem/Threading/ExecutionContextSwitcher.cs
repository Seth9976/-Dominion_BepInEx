using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026D RID: 621
	public sealed class ExecutionContextSwitcher : ValueType
	{
		// Token: 0x06002AB0 RID: 10928 RVA: 0x000DC1B8 File Offset: 0x000DA3B8
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionContextSwitcher()
		{
			Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ExecutionContextSwitcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr);
			ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "outerEC");
			ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "outerECBelongsToScope");
			ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "hecsw");
			ExecutionContextSwitcher.NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "thread");
			ExecutionContextSwitcher.NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, 100670077);
			ExecutionContextSwitcher.NativeMethodInfoPtr_Undo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, 100670078);
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000DC260 File Offset: 0x000DA460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331291, XrefRangeEnd = 331292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UndoNoThrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContextSwitcher.NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000DC2A4 File Offset: 0x000DA4A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 331298, RefRangeEnd = 331305, XrefRangeStart = 331292, XrefRangeEnd = 331298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContextSwitcher.NativeMethodInfoPtr_Undo_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0000EE49 File Offset: 0x0000D049
		public ExecutionContextSwitcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0000EE52 File Offset: 0x0000D052
		public ExecutionContextSwitcher()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr))
		{
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x000DC2DC File Offset: 0x000DA4DC
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x0000EE64 File Offset: 0x0000D064
		public ExecutionContext.Reader outerEC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC);
				return new ExecutionContext.Reader(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x000DC30C File Offset: 0x000DA50C
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x0000EE92 File Offset: 0x0000D092
		public unsafe bool outerECBelongsToScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope)) = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x000DC334 File Offset: 0x000DA534
		// (set) Token: 0x06002ABA RID: 10938 RVA: 0x0000EEAD File Offset: 0x0000D0AD
		public unsafe Object hecsw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x000DC364 File Offset: 0x000DA564
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x0000EECC File Offset: 0x0000D0CC
		public unsafe Thread thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeFieldInfoPtr_outerEC;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeFieldInfoPtr_outerECBelongsToScope;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeFieldInfoPtr_hecsw;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeFieldInfoPtr_thread;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Internal_Void_0;
	}
}
