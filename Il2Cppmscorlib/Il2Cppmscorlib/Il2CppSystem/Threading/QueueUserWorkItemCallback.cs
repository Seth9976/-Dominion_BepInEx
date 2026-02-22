using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000284 RID: 644
	public sealed class QueueUserWorkItemCallback : Object
	{
		// Token: 0x06002BEA RID: 11242 RVA: 0x000E0840 File Offset: 0x000DEA40
		// Note: this type is marked as 'beforefieldinit'.
		static QueueUserWorkItemCallback()
		{
			Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "QueueUserWorkItemCallback");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "callback");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "context");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "state");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "ccb");
			QueueUserWorkItemCallback.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100670280);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100670281);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100670282);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100670283);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000E0908 File Offset: 0x000DEB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333288, RefRangeEnd = 333289, XrefRangeStart = 333280, XrefRangeEnd = 333288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueueUserWorkItemCallback(WaitCallback waitCallback, Object stateObj, bool compressStack, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x000E0984 File Offset: 0x000DEB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333289, XrefRangeEnd = 333297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x000E09B8 File Offset: 0x000DEBB8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x000E09FC File Offset: 0x000DEBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333297, XrefRangeEnd = 333310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitCallback_Context(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0000F4DD File Offset: 0x0000D6DD
		public QueueUserWorkItemCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000E0A34 File Offset: 0x000DEC34
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x0000F4E6 File Offset: 0x0000D6E6
		public unsafe WaitCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x000E0A64 File Offset: 0x000DEC64
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x0000F505 File Offset: 0x0000D705
		public unsafe ExecutionContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x000E0A94 File Offset: 0x000DEC94
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x0000F524 File Offset: 0x0000D724
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x000E0AC4 File Offset: 0x000DECC4
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x0000F543 File Offset: 0x0000D743
		public unsafe static ContextCallback ccb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeFieldInfoPtr_ccb;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0;
	}
}
