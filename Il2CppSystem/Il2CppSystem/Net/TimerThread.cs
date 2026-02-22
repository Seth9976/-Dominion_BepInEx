using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E6 RID: 230
	public static class TimerThread : Object
	{
		// Token: 0x06000D39 RID: 3385 RVA: 0x00042480 File Offset: 0x00040680
		// Note: this type is marked as 'beforefieldinit'.
		static TimerThread()
		{
			Il2CppClassPointerStore<TimerThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "TimerThread");
			TimerThread.NativeFieldInfoPtr_s_Queues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_Queues");
			TimerThread.NativeFieldInfoPtr_s_NewQueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_NewQueues");
			TimerThread.NativeFieldInfoPtr_s_ThreadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadState");
			TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadReadyEvent");
			TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadShutdownEvent");
			TimerThread.NativeFieldInfoPtr_s_ThreadEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadEvents");
			TimerThread.NativeFieldInfoPtr_s_QueuesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_QueuesCache");
			TimerThread.NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100665159);
			TimerThread.NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100665160);
			TimerThread.NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100665161);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00042570 File Offset: 0x00040770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47708, XrefRangeEnd = 47734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimerThread.Queue CreateQueue(int durationMilliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationMilliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr3) : null;
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000425B0 File Offset: 0x000407B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47734, XrefRangeEnd = 47796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopTimerThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000425D8 File Offset: 0x000407D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47796, XrefRangeEnd = 47808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnDomainUnload(Object sender, EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00007268 File Offset: 0x00005468
		public TimerThread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00042620 File Offset: 0x00040820
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x00007271 File Offset: 0x00005471
		public unsafe static LinkedList<WeakReference> s_Queues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_Queues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_Queues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00042648 File Offset: 0x00040848
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00007283 File Offset: 0x00005483
		public unsafe static LinkedList<WeakReference> s_NewQueues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_NewQueues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_NewQueues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00042670 File Offset: 0x00040870
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x00007295 File Offset: 0x00005495
		public unsafe static int s_ThreadState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadState, (void*)(&value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0004268C File Offset: 0x0004088C
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x000072A3 File Offset: 0x000054A3
		public unsafe static AutoResetEvent s_ThreadReadyEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x000426B4 File Offset: 0x000408B4
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x000072B5 File Offset: 0x000054B5
		public unsafe static ManualResetEvent s_ThreadShutdownEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000426DC File Offset: 0x000408DC
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x000072C7 File Offset: 0x000054C7
		public unsafe static Il2CppReferenceArray<WaitHandle> s_ThreadEvents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadEvents, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WaitHandle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadEvents, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00042704 File Offset: 0x00040904
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x000072D9 File Offset: 0x000054D9
		public unsafe static Hashtable s_QueuesCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_QueuesCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_QueuesCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr_s_Queues;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr_s_NewQueues;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadState;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadReadyEvent;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadShutdownEvent;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadEvents;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeFieldInfoPtr_s_QueuesCache;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0;

		// Token: 0x020001B1 RID: 433
		public class Queue : Object
		{
			// Token: 0x06001887 RID: 6279 RVA: 0x00069748 File Offset: 0x00067948
			// Note: this type is marked as 'beforefieldinit'.
			static Queue()
			{
				Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Queue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr);
				TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr, "m_DurationMilliseconds");
				TimerThread.Queue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr, 100665162);
			}

			// Token: 0x06001888 RID: 6280 RVA: 0x0006979C File Offset: 0x0006799C
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Queue(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Queue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001889 RID: 6281 RVA: 0x0000CD72 File Offset: 0x0000AF72
			public Queue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x0600188A RID: 6282 RVA: 0x000697E4 File Offset: 0x000679E4
			// (set) Token: 0x0600188B RID: 6283 RVA: 0x0000CD7B File Offset: 0x0000AF7B
			public unsafe int m_DurationMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds)) = value;
				}
			}

			// Token: 0x0400136B RID: 4971
			private static readonly IntPtr NativeFieldInfoPtr_m_DurationMilliseconds;

			// Token: 0x0400136C RID: 4972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
		}

		// Token: 0x020001B2 RID: 434
		public class Timer : Object
		{
			// Token: 0x0600188C RID: 6284 RVA: 0x0006980C File Offset: 0x00067A0C
			// Note: this type is marked as 'beforefieldinit'.
			static Timer()
			{
				Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Timer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr);
				TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, "m_StartTimeMilliseconds");
				TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, "m_DurationMilliseconds");
				TimerThread.Timer.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100665163);
				TimerThread.Timer.NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100665164);
				TimerThread.Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100665165);
			}

			// Token: 0x0600188D RID: 6285 RVA: 0x0006989C File Offset: 0x00067A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47672, XrefRangeEnd = 47674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Timer(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Timer.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600188E RID: 6286 RVA: 0x000698E4 File Offset: 0x00067AE4
			[CallerCount(0)]
			public unsafe virtual bool Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.Timer.NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600188F RID: 6287 RVA: 0x0006992C File Offset: 0x00067B2C
			[CallerCount(0)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001890 RID: 6288 RVA: 0x0000CD96 File Offset: 0x0000AF96
			public Timer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x06001891 RID: 6289 RVA: 0x00069960 File Offset: 0x00067B60
			// (set) Token: 0x06001892 RID: 6290 RVA: 0x0000CD9F File Offset: 0x0000AF9F
			public unsafe int m_StartTimeMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds)) = value;
				}
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x06001893 RID: 6291 RVA: 0x00069988 File Offset: 0x00067B88
			// (set) Token: 0x06001894 RID: 6292 RVA: 0x0000CDBA File Offset: 0x0000AFBA
			public unsafe int m_DurationMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds)) = value;
				}
			}

			// Token: 0x0400136D RID: 4973
			private static readonly IntPtr NativeFieldInfoPtr_m_StartTimeMilliseconds;

			// Token: 0x0400136E RID: 4974
			private static readonly IntPtr NativeFieldInfoPtr_m_DurationMilliseconds;

			// Token: 0x0400136F RID: 4975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x04001370 RID: 4976
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0;

			// Token: 0x04001371 RID: 4977
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020001B3 RID: 435
		public sealed class Callback : MulticastDelegate
		{
			// Token: 0x06001895 RID: 6293 RVA: 0x0000CDD5 File Offset: 0x0000AFD5
			// Note: this type is marked as 'beforefieldinit'.
			static Callback()
			{
				Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Callback");
				TimerThread.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr, 100665166);
				TimerThread.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr, 100665167);
			}

			// Token: 0x06001896 RID: 6294 RVA: 0x000699B0 File Offset: 0x00067BB0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001897 RID: 6295 RVA: 0x00069A0C File Offset: 0x00067C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47674, XrefRangeEnd = 47693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(TimerThread.Timer timer, int timeNoticed, Object context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeNoticed;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001898 RID: 6296 RVA: 0x0000CE13 File Offset: 0x0000B013
			public Callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001899 RID: 6297 RVA: 0x0000CE1C File Offset: 0x0000B01C
			public static implicit operator TimerThread.Callback(Action<TimerThread.Timer, int, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<TimerThread.Callback>(A_0);
			}

			// Token: 0x0600189A RID: 6298 RVA: 0x0000CE24 File Offset: 0x0000B024
			public static TimerThread.Callback operator +(TimerThread.Callback A_0, TimerThread.Callback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TimerThread.Callback>();
			}

			// Token: 0x0600189B RID: 6299 RVA: 0x0000CE32 File Offset: 0x0000B032
			public static TimerThread.Callback operator -(TimerThread.Callback A_0, TimerThread.Callback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TimerThread.Callback>();
				}
				return delegate2;
			}

			// Token: 0x04001372 RID: 4978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001373 RID: 4979
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0;
		}

		// Token: 0x020001B4 RID: 436
		public class TimerQueue : TimerThread.Queue
		{
			// Token: 0x0600189C RID: 6300 RVA: 0x00069A70 File Offset: 0x00067C70
			// Note: this type is marked as 'beforefieldinit'.
			static TimerQueue()
			{
				Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "TimerQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr);
				TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, "m_Timers");
				TimerThread.TimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, 100665168);
			}

			// Token: 0x0600189D RID: 6301 RVA: 0x00069AC4 File Offset: 0x00067CC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 47699, RefRangeEnd = 47700, XrefRangeStart = 47693, XrefRangeEnd = 47699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimerQueue(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600189E RID: 6302 RVA: 0x0000CE43 File Offset: 0x0000B043
			public TimerQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x0600189F RID: 6303 RVA: 0x00069B0C File Offset: 0x00067D0C
			// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0000CE4C File Offset: 0x0000B04C
			public unsafe TimerThread.TimerNode m_Timers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001374 RID: 4980
			private static readonly IntPtr NativeFieldInfoPtr_m_Timers;

			// Token: 0x04001375 RID: 4981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
		}

		// Token: 0x020001B5 RID: 437
		public class InfiniteTimerQueue : TimerThread.Queue
		{
			// Token: 0x060018A1 RID: 6305 RVA: 0x0000CE6B File Offset: 0x0000B06B
			// Note: this type is marked as 'beforefieldinit'.
			static InfiniteTimerQueue()
			{
				Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "InfiniteTimerQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr);
				TimerThread.InfiniteTimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr, 100665169);
			}

			// Token: 0x060018A2 RID: 6306 RVA: 0x00069B3C File Offset: 0x00067D3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 47701, RefRangeEnd = 47702, XrefRangeStart = 47700, XrefRangeEnd = 47701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InfiniteTimerQueue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.InfiniteTimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018A3 RID: 6307 RVA: 0x0000CE9F File Offset: 0x0000B09F
			public InfiniteTimerQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001376 RID: 4982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
		}

		// Token: 0x020001B6 RID: 438
		public class TimerNode : TimerThread.Timer
		{
			// Token: 0x060018A4 RID: 6308 RVA: 0x00069B78 File Offset: 0x00067D78
			// Note: this type is marked as 'beforefieldinit'.
			static TimerNode()
			{
				Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "TimerNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr);
				TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_TimerState");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_Callback");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_Context");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_QueueLock");
				TimerThread.TimerNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "next");
				TimerThread.TimerNode.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "prev");
				TimerThread.TimerNode.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665170);
				TimerThread.TimerNode.NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665171);
				TimerThread.TimerNode.NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665172);
				TimerThread.TimerNode.NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665173);
				TimerThread.TimerNode.NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665174);
				TimerThread.TimerNode.NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665175);
			}

			// Token: 0x060018A5 RID: 6309 RVA: 0x00069C94 File Offset: 0x00067E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47702, XrefRangeEnd = 47704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimerNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x060018A6 RID: 6310 RVA: 0x00069CD0 File Offset: 0x00067ED0
			// (set) Token: 0x060018A7 RID: 6311 RVA: 0x00069D10 File Offset: 0x00067F10
			public unsafe TimerThread.TimerNode Next
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00069D54 File Offset: 0x00067F54
			// (set) Token: 0x060018A9 RID: 6313 RVA: 0x00069D94 File Offset: 0x00067F94
			public unsafe TimerThread.TimerNode Prev
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060018AA RID: 6314 RVA: 0x00069DD8 File Offset: 0x00067FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47704, XrefRangeEnd = 47708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.TimerNode.NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060018AB RID: 6315 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
			public TimerNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x060018AC RID: 6316 RVA: 0x00069E20 File Offset: 0x00068020
			// (set) Token: 0x060018AD RID: 6317 RVA: 0x0000CEB1 File Offset: 0x0000B0B1
			public unsafe TimerThread.TimerNode.TimerState m_TimerState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState)) = value;
				}
			}

			// Token: 0x170007DE RID: 2014
			// (get) Token: 0x060018AE RID: 6318 RVA: 0x00069E48 File Offset: 0x00068048
			// (set) Token: 0x060018AF RID: 6319 RVA: 0x0000CECC File Offset: 0x0000B0CC
			public unsafe TimerThread.Callback m_Callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00069E78 File Offset: 0x00068078
			// (set) Token: 0x060018B1 RID: 6321 RVA: 0x0000CEEB File Offset: 0x0000B0EB
			public unsafe Object m_Context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00069EA8 File Offset: 0x000680A8
			// (set) Token: 0x060018B3 RID: 6323 RVA: 0x0000CF0A File Offset: 0x0000B10A
			public unsafe Object m_QueueLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00069ED8 File Offset: 0x000680D8
			// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0000CF29 File Offset: 0x0000B129
			public unsafe TimerThread.TimerNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x060018B6 RID: 6326 RVA: 0x00069F08 File Offset: 0x00068108
			// (set) Token: 0x060018B7 RID: 6327 RVA: 0x0000CF48 File Offset: 0x0000B148
			public unsafe TimerThread.TimerNode prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001377 RID: 4983
			private static readonly IntPtr NativeFieldInfoPtr_m_TimerState;

			// Token: 0x04001378 RID: 4984
			private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

			// Token: 0x04001379 RID: 4985
			private static readonly IntPtr NativeFieldInfoPtr_m_Context;

			// Token: 0x0400137A RID: 4986
			private static readonly IntPtr NativeFieldInfoPtr_m_QueueLock;

			// Token: 0x0400137B RID: 4987
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400137C RID: 4988
			private static readonly IntPtr NativeFieldInfoPtr_prev;

			// Token: 0x0400137D RID: 4989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x0400137E RID: 4990
			private static readonly IntPtr NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0;

			// Token: 0x0400137F RID: 4991
			private static readonly IntPtr NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0;

			// Token: 0x04001380 RID: 4992
			private static readonly IntPtr NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0;

			// Token: 0x04001381 RID: 4993
			private static readonly IntPtr NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0;

			// Token: 0x04001382 RID: 4994
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0;

			// Token: 0x0200021E RID: 542
			public enum TimerState
			{
				// Token: 0x040015B3 RID: 5555
				Ready,
				// Token: 0x040015B4 RID: 5556
				Fired,
				// Token: 0x040015B5 RID: 5557
				Cancelled,
				// Token: 0x040015B6 RID: 5558
				Sentinel
			}
		}
	}
}
