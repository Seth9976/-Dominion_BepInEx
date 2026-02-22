using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000278 RID: 632
	public class ThreadHelper : Object
	{
		// Token: 0x06002B3F RID: 11071 RVA: 0x000DE568 File Offset: 0x000DC768
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadHelper()
		{
			Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadHelper");
			ThreadHelper.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_start");
			ThreadHelper.NativeFieldInfoPtr__startArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_startArg");
			ThreadHelper.NativeFieldInfoPtr__executionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_executionContext");
			ThreadHelper.NativeFieldInfoPtr__ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_ccb");
			ThreadHelper.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670184);
			ThreadHelper.NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670185);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670186);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670187);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670188);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000DE644 File Offset: 0x000DC844
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadHelper(Delegate start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000DE690 File Offset: 0x000DC890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExecutionContextHelper(ExecutionContext ec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000DE6D4 File Offset: 0x000DC8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332471, XrefRangeEnd = 332483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThreadStart_Context(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000DE70C File Offset: 0x000DC90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332483, XrefRangeEnd = 332496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThreadStart(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000DE750 File Offset: 0x000DC950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332496, XrefRangeEnd = 332517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThreadStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		public ThreadHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000DE784 File Offset: 0x000DC984
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x0000F0ED File Offset: 0x0000D2ED
		public unsafe Delegate _start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000DE7B4 File Offset: 0x000DC9B4
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x0000F10C File Offset: 0x0000D30C
		public unsafe Object _startArg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__startArg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__startArg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x000DE7E4 File Offset: 0x000DC9E4
		// (set) Token: 0x06002B4B RID: 11083 RVA: 0x0000F12B File Offset: 0x0000D32B
		public unsafe ExecutionContext _executionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__executionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__executionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x000DE814 File Offset: 0x000DCA14
		// (set) Token: 0x06002B4D RID: 11085 RVA: 0x0000F14A File Offset: 0x0000D34A
		public unsafe static ContextCallback _ccb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadHelper.NativeFieldInfoPtr__ccb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadHelper.NativeFieldInfoPtr__ccb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeFieldInfoPtr__start;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeFieldInfoPtr__startArg;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeFieldInfoPtr__executionContext;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeFieldInfoPtr__ccb;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0;

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Internal_Void_0;
	}
}
