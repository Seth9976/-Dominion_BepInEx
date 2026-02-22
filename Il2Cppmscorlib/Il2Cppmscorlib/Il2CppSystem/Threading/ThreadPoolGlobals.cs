using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000280 RID: 640
	public static class ThreadPoolGlobals : Object
	{
		// Token: 0x06002BBA RID: 11194 RVA: 0x000E009C File Offset: 0x000DE29C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolGlobals()
		{
			Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolGlobals");
			ThreadPoolGlobals.NativeFieldInfoPtr_tpQuantum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "tpQuantum");
			ThreadPoolGlobals.NativeFieldInfoPtr_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "processorCount");
			ThreadPoolGlobals.NativeFieldInfoPtr_tpHosted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "tpHosted");
			ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "vmTpInitialized");
			ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "enableWorkerTracking");
			ThreadPoolGlobals.NativeFieldInfoPtr_workQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "workQueue");
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x0000F34E File Offset: 0x0000D54E
		public ThreadPoolGlobals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x000E013C File Offset: 0x000DE33C
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x0000F357 File Offset: 0x0000D557
		public unsafe static uint tpQuantum
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_tpQuantum, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_tpQuantum, (void*)(&value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000E0158 File Offset: 0x000DE358
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x0000F365 File Offset: 0x0000D565
		public unsafe static int processorCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_processorCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_processorCount, (void*)(&value));
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x000E0174 File Offset: 0x000DE374
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x0000F373 File Offset: 0x0000D573
		public unsafe static bool tpHosted
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_tpHosted, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_tpHosted, (void*)(&value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x000E0190 File Offset: 0x000DE390
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x0000F381 File Offset: 0x0000D581
		public unsafe static bool vmTpInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x000E01AC File Offset: 0x000DE3AC
		// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x0000F38F File Offset: 0x0000D58F
		public unsafe static bool enableWorkerTracking
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking, (void*)(&value));
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x000E01C8 File Offset: 0x000DE3C8
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x0000F39D File Offset: 0x0000D59D
		public unsafe static ThreadPoolWorkQueue workQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_workQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_workQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeFieldInfoPtr_tpQuantum;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeFieldInfoPtr_processorCount;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeFieldInfoPtr_tpHosted;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeFieldInfoPtr_vmTpInitialized;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeFieldInfoPtr_enableWorkerTracking;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeFieldInfoPtr_workQueue;
	}
}
