using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000282 RID: 642
	public sealed class ThreadPoolWorkQueueThreadLocals : Object
	{
		// Token: 0x06002BDA RID: 11226 RVA: 0x000E05E8 File Offset: 0x000DE7E8
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolWorkQueueThreadLocals()
		{
			Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolWorkQueueThreadLocals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr);
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "threadLocals");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "workQueue");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "workStealingQueue");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "random");
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100670275);
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_CleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100670276);
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100670277);
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000E06A4 File Offset: 0x000DE8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333234, XrefRangeEnd = 333256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tpq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000E06F0 File Offset: 0x000DE8F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333268, RefRangeEnd = 333269, XrefRangeStart = 333256, XrefRangeEnd = 333268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_CleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000E0724 File Offset: 0x000DE924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333269, XrefRangeEnd = 333276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x0000F423 File Offset: 0x0000D623
		public ThreadPoolWorkQueueThreadLocals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x000E0758 File Offset: 0x000DE958
		// (set) Token: 0x06002BE0 RID: 11232 RVA: 0x0000F42C File Offset: 0x0000D62C
		public unsafe static ThreadPoolWorkQueueThreadLocals threadLocals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueueThreadLocals>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x000E0780 File Offset: 0x000DE980
		// (set) Token: 0x06002BE2 RID: 11234 RVA: 0x0000F43E File Offset: 0x0000D63E
		public unsafe ThreadPoolWorkQueue workQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x000E07B0 File Offset: 0x000DE9B0
		// (set) Token: 0x06002BE4 RID: 11236 RVA: 0x0000F45D File Offset: 0x0000D65D
		public unsafe ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.WorkStealingQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x000E07E0 File Offset: 0x000DE9E0
		// (set) Token: 0x06002BE6 RID: 11238 RVA: 0x0000F47C File Offset: 0x0000D67C
		public unsafe Random random
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400262B RID: 9771
		private static readonly IntPtr NativeFieldInfoPtr_threadLocals;

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeFieldInfoPtr_workQueue;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeFieldInfoPtr_workStealingQueue;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeFieldInfoPtr_random;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_0;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
