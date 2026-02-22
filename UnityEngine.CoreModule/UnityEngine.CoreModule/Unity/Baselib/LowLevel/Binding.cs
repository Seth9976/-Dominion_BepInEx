using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.Baselib.LowLevel
{
	// Token: 0x02000181 RID: 385
	public static class Binding
	{
		// Token: 0x06001BB0 RID: 7088 RVA: 0x0000F28D File Offset: 0x0000D48D
		public static IntPtr Baselib_Memory_Allocate(UIntPtr size)
		{
			return Binding.Baselib_Memory_AllocateDelegateField(size);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0000F29A File Offset: 0x0000D49A
		public static IntPtr Baselib_Memory_Reallocate(IntPtr ptr, UIntPtr newSize)
		{
			return Binding.Baselib_Memory_ReallocateDelegateField(ptr, newSize);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
		public static void Baselib_Memory_Free(IntPtr ptr)
		{
			Binding.Baselib_Memory_FreeDelegateField(ptr);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0000F2B5 File Offset: 0x0000D4B5
		public static IntPtr Baselib_Memory_AlignedAllocate(UIntPtr size, UIntPtr alignment)
		{
			return Binding.Baselib_Memory_AlignedAllocateDelegateField(size, alignment);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0000F2C3 File Offset: 0x0000D4C3
		public static IntPtr Baselib_Memory_AlignedReallocate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment)
		{
			return Binding.Baselib_Memory_AlignedReallocateDelegateField(ptr, newSize, alignment);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0000F2D2 File Offset: 0x0000D4D2
		public static void Baselib_Memory_AlignedFree(IntPtr ptr)
		{
			Binding.Baselib_Memory_AlignedFreeDelegateField(ptr);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00061764 File Offset: 0x0005F964
		public static Binding.Baselib_RegisteredNetwork_Endpoint Baselib_RegisteredNetwork_Endpoint_Empty()
		{
			Binding.Baselib_RegisteredNetwork_Endpoint baselib_RegisteredNetwork_Endpoint;
			Binding.Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out baselib_RegisteredNetwork_Endpoint);
			return baselib_RegisteredNetwork_Endpoint;
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0000F2DF File Offset: 0x0000D4DF
		public static void Baselib_Thread_YieldExecution()
		{
			Binding.Baselib_Thread_YieldExecutionDelegateField();
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0000F2EB File Offset: 0x0000D4EB
		public static IntPtr Baselib_Thread_GetCurrentThreadId()
		{
			return Binding.Baselib_Thread_GetCurrentThreadIdDelegateField();
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0000F2F7 File Offset: 0x0000D4F7
		public static UIntPtr Baselib_TLS_Alloc()
		{
			return Binding.Baselib_TLS_AllocDelegateField();
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0000F303 File Offset: 0x0000D503
		public static void Baselib_TLS_Free(UIntPtr handle)
		{
			Binding.Baselib_TLS_FreeDelegateField(handle);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0000F310 File Offset: 0x0000D510
		public static void Baselib_TLS_Set(UIntPtr handle, UIntPtr value)
		{
			Binding.Baselib_TLS_SetDelegateField(handle, value);
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0000F31E File Offset: 0x0000D51E
		public static UIntPtr Baselib_TLS_Get(UIntPtr handle)
		{
			return Binding.Baselib_TLS_GetDelegateField(handle);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0000F32B File Offset: 0x0000D52B
		public static ulong Baselib_Timer_GetHighPrecisionTimerTicks()
		{
			return Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegateField();
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0000F337 File Offset: 0x0000D537
		public static void Baselib_Timer_WaitForAtLeast(uint timeInMilliseconds)
		{
			Binding.Baselib_Timer_WaitForAtLeastDelegateField(timeInMilliseconds);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0000F344 File Offset: 0x0000D544
		public static double Baselib_Timer_GetTimeSinceStartupInSeconds()
		{
			return Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField();
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0000F350 File Offset: 0x0000D550
		public static void Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out Binding.Baselib_RegisteredNetwork_Endpoint ret)
		{
			Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField(out ret);
		}

		// Token: 0x04001555 RID: 5461
		public const uint Baselib_NetworkAddress_IpMaxStringLength = 46U;

		// Token: 0x04001556 RID: 5462
		public const uint Baselib_RegisteredNetwork_Endpoint_MaxSize = 28U;

		// Token: 0x04001557 RID: 5463
		public const uint Baselib_TLS_MinimumGuaranteedSlots = 100U;

		// Token: 0x04001558 RID: 5464
		public const ulong Baselib_SecondsPerMinute = 60UL;

		// Token: 0x04001559 RID: 5465
		public const ulong Baselib_MillisecondsPerSecond = 1000UL;

		// Token: 0x0400155A RID: 5466
		public const ulong Baselib_MillisecondsPerMinute = 60000UL;

		// Token: 0x0400155B RID: 5467
		public const ulong Baselib_MicrosecondsPerMillisecond = 1000UL;

		// Token: 0x0400155C RID: 5468
		public const ulong Baselib_MicrosecondsPerSecond = 1000000UL;

		// Token: 0x0400155D RID: 5469
		public const ulong Baselib_MicrosecondsPerMinute = 60000000UL;

		// Token: 0x0400155E RID: 5470
		public const ulong Baselib_NanosecondsPerMicrosecond = 1000UL;

		// Token: 0x0400155F RID: 5471
		public const ulong Baselib_NanosecondsPerMillisecond = 1000000UL;

		// Token: 0x04001560 RID: 5472
		public const ulong Baselib_NanosecondsPerSecond = 1000000000UL;

		// Token: 0x04001561 RID: 5473
		public const ulong Baselib_NanosecondsPerMinute = 60000000000UL;

		// Token: 0x04001562 RID: 5474
		public const ulong Baselib_Timer_MaxNumberOfNanosecondsPerTick = 1000UL;

		// Token: 0x04001563 RID: 5475
		public const double Baselib_Timer_MinNumberOfNanosecondsPerTick = 0.01;

		// Token: 0x04001564 RID: 5476
		private static readonly Binding.Baselib_Memory_AllocateDelegate Baselib_Memory_AllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Allocate");

		// Token: 0x04001565 RID: 5477
		private static readonly Binding.Baselib_Memory_ReallocateDelegate Baselib_Memory_ReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_ReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Reallocate");

		// Token: 0x04001566 RID: 5478
		private static readonly Binding.Baselib_Memory_FreeDelegate Baselib_Memory_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Free");

		// Token: 0x04001567 RID: 5479
		private static readonly Binding.Baselib_Memory_AlignedAllocateDelegate Baselib_Memory_AlignedAllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedAllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedAllocate");

		// Token: 0x04001568 RID: 5480
		private static readonly Binding.Baselib_Memory_AlignedReallocateDelegate Baselib_Memory_AlignedReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedReallocate");

		// Token: 0x04001569 RID: 5481
		private static readonly Binding.Baselib_Memory_AlignedFreeDelegate Baselib_Memory_AlignedFreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedFreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedFree");

		// Token: 0x0400156A RID: 5482
		private static readonly Binding.Baselib_Thread_YieldExecutionDelegate Baselib_Thread_YieldExecutionDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_YieldExecutionDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_YieldExecution");

		// Token: 0x0400156B RID: 5483
		private static readonly Binding.Baselib_Thread_GetCurrentThreadIdDelegate Baselib_Thread_GetCurrentThreadIdDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_GetCurrentThreadIdDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_GetCurrentThreadId");

		// Token: 0x0400156C RID: 5484
		private static readonly Binding.Baselib_TLS_AllocDelegate Baselib_TLS_AllocDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_AllocDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Alloc");

		// Token: 0x0400156D RID: 5485
		private static readonly Binding.Baselib_TLS_FreeDelegate Baselib_TLS_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Free");

		// Token: 0x0400156E RID: 5486
		private static readonly Binding.Baselib_TLS_SetDelegate Baselib_TLS_SetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_SetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Set");

		// Token: 0x0400156F RID: 5487
		private static readonly Binding.Baselib_TLS_GetDelegate Baselib_TLS_GetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_GetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Get");

		// Token: 0x04001570 RID: 5488
		private static readonly Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate Baselib_Timer_GetHighPrecisionTimerTicksDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetHighPrecisionTimerTicks");

		// Token: 0x04001571 RID: 5489
		private static readonly Binding.Baselib_Timer_WaitForAtLeastDelegate Baselib_Timer_WaitForAtLeastDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_WaitForAtLeastDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_WaitForAtLeast");

		// Token: 0x04001572 RID: 5490
		private static readonly Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetTimeSinceStartupInSeconds");

		// Token: 0x04001573 RID: 5491
		private static readonly Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField = IL2CPP.ResolveICall<Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_RegisteredNetwork_Endpoint_Empty_Injected");

		// Token: 0x02000A51 RID: 2641
		public enum Baselib_ErrorCode
		{
			// Token: 0x04001D3E RID: 7486
			Success,
			// Token: 0x04001D3F RID: 7487
			OutOfMemory = 16777216,
			// Token: 0x04001D40 RID: 7488
			OutOfSystemResources,
			// Token: 0x04001D41 RID: 7489
			InvalidAddressRange,
			// Token: 0x04001D42 RID: 7490
			InvalidArgument,
			// Token: 0x04001D43 RID: 7491
			InvalidBufferSize,
			// Token: 0x04001D44 RID: 7492
			InvalidState,
			// Token: 0x04001D45 RID: 7493
			NotSupported,
			// Token: 0x04001D46 RID: 7494
			Timeout,
			// Token: 0x04001D47 RID: 7495
			UnsupportedAlignment = 33554432,
			// Token: 0x04001D48 RID: 7496
			InvalidPageSize,
			// Token: 0x04001D49 RID: 7497
			InvalidPageCount,
			// Token: 0x04001D4A RID: 7498
			UnsupportedPageState,
			// Token: 0x04001D4B RID: 7499
			ThreadCannotJoinSelf = 50331648,
			// Token: 0x04001D4C RID: 7500
			NetworkInitializationError = 67108864,
			// Token: 0x04001D4D RID: 7501
			AddressInUse,
			// Token: 0x04001D4E RID: 7502
			AddressUnreachable,
			// Token: 0x04001D4F RID: 7503
			AddressFamilyNotSupported,
			// Token: 0x04001D50 RID: 7504
			Disconnected,
			// Token: 0x04001D51 RID: 7505
			InvalidPathname = 83886080,
			// Token: 0x04001D52 RID: 7506
			RequestedAccessIsNotAllowed,
			// Token: 0x04001D53 RID: 7507
			IOError,
			// Token: 0x04001D54 RID: 7508
			FailedToOpenDynamicLibrary = 100663296,
			// Token: 0x04001D55 RID: 7509
			FunctionNotFound,
			// Token: 0x04001D56 RID: 7510
			UnexpectedError = -1
		}

		// Token: 0x02000A52 RID: 2642
		public enum Baselib_ErrorState_NativeErrorCodeType : byte
		{
			// Token: 0x04001D58 RID: 7512
			None,
			// Token: 0x04001D59 RID: 7513
			PlatformDefined
		}

		// Token: 0x02000A53 RID: 2643
		public enum Baselib_ErrorState_ExtraInformationType : byte
		{
			// Token: 0x04001D5B RID: 7515
			None,
			// Token: 0x04001D5C RID: 7516
			StaticString,
			// Token: 0x04001D5D RID: 7517
			GenerationCounter
		}

		// Token: 0x02000A54 RID: 2644
		public enum Baselib_ErrorState_ExplainVerbosity
		{
			// Token: 0x04001D5F RID: 7519
			ErrorType,
			// Token: 0x04001D60 RID: 7520
			ErrorType_SourceLocation_Explanation
		}

		// Token: 0x02000A55 RID: 2645
		public enum Baselib_FileIO_OpenFlags : uint
		{
			// Token: 0x04001D62 RID: 7522
			Read = 1U,
			// Token: 0x04001D63 RID: 7523
			Write,
			// Token: 0x04001D64 RID: 7524
			OpenAlways = 4U,
			// Token: 0x04001D65 RID: 7525
			CreateAlways = 8U
		}

		// Token: 0x02000A56 RID: 2646
		public enum Baselib_FileIO_Priority
		{
			// Token: 0x04001D67 RID: 7527
			Normal,
			// Token: 0x04001D68 RID: 7528
			High
		}

		// Token: 0x02000A57 RID: 2647
		public enum Baselib_FileIO_EventQueue_ResultType
		{
			// Token: 0x04001D6A RID: 7530
			Baselib_FileIO_EventQueue_Callback = 1,
			// Token: 0x04001D6B RID: 7531
			Baselib_FileIO_EventQueue_OpenFile,
			// Token: 0x04001D6C RID: 7532
			Baselib_FileIO_EventQueue_ReadFile,
			// Token: 0x04001D6D RID: 7533
			Baselib_FileIO_EventQueue_CloseFile
		}

		// Token: 0x02000A58 RID: 2648
		public enum Baselib_Memory_PageState
		{
			// Token: 0x04001D6F RID: 7535
			Reserved,
			// Token: 0x04001D70 RID: 7536
			NoAccess,
			// Token: 0x04001D71 RID: 7537
			ReadOnly,
			// Token: 0x04001D72 RID: 7538
			ReadWrite = 4,
			// Token: 0x04001D73 RID: 7539
			ReadOnly_Executable = 18,
			// Token: 0x04001D74 RID: 7540
			ReadWrite_Executable = 20
		}

		// Token: 0x02000A59 RID: 2649
		public enum Baselib_NetworkAddress_Family
		{
			// Token: 0x04001D76 RID: 7542
			Invalid,
			// Token: 0x04001D77 RID: 7543
			IPv4,
			// Token: 0x04001D78 RID: 7544
			IPv6
		}

		// Token: 0x02000A5A RID: 2650
		public enum Baselib_NetworkAddress_AddressReuse
		{
			// Token: 0x04001D7A RID: 7546
			DoNotAllow,
			// Token: 0x04001D7B RID: 7547
			Allow
		}

		// Token: 0x02000A5B RID: 2651
		public struct Baselib_RegisteredNetwork_Endpoint
		{
		}

		// Token: 0x02000A5C RID: 2652
		public enum Baselib_RegisteredNetwork_CompletionStatus
		{
			// Token: 0x04001D7D RID: 7549
			Failed,
			// Token: 0x04001D7E RID: 7550
			Success
		}

		// Token: 0x02000A5D RID: 2653
		public enum Baselib_RegisteredNetwork_ProcessStatus
		{
			// Token: 0x04001D80 RID: 7552
			NonePendingImmediately,
			// Token: 0x04001D81 RID: 7553
			Done = 0,
			// Token: 0x04001D82 RID: 7554
			Pending
		}

		// Token: 0x02000A5E RID: 2654
		public enum Baselib_RegisteredNetwork_CompletionQueueStatus
		{
			// Token: 0x04001D84 RID: 7556
			NoResultsAvailable,
			// Token: 0x04001D85 RID: 7557
			ResultsAvailable
		}

		// Token: 0x02000A5F RID: 2655
		public enum Baselib_Socket_Protocol
		{
			// Token: 0x04001D87 RID: 7559
			UDP = 1,
			// Token: 0x04001D88 RID: 7560
			TCP
		}

		// Token: 0x02000A60 RID: 2656
		public enum Baselib_Socket_PollEvents
		{
			// Token: 0x04001D8A RID: 7562
			Readable = 1,
			// Token: 0x04001D8B RID: 7563
			Writable,
			// Token: 0x04001D8C RID: 7564
			Connected = 4
		}

		// Token: 0x02000A61 RID: 2657
		// (Invoke) Token: 0x060032C8 RID: 13000
		private delegate IntPtr Baselib_Memory_AllocateDelegate(UIntPtr size);

		// Token: 0x02000A62 RID: 2658
		// (Invoke) Token: 0x060032CA RID: 13002
		private delegate IntPtr Baselib_Memory_ReallocateDelegate(IntPtr ptr, UIntPtr newSize);

		// Token: 0x02000A63 RID: 2659
		// (Invoke) Token: 0x060032CC RID: 13004
		private delegate void Baselib_Memory_FreeDelegate(IntPtr ptr);

		// Token: 0x02000A64 RID: 2660
		// (Invoke) Token: 0x060032CE RID: 13006
		private delegate IntPtr Baselib_Memory_AlignedAllocateDelegate(UIntPtr size, UIntPtr alignment);

		// Token: 0x02000A65 RID: 2661
		// (Invoke) Token: 0x060032D0 RID: 13008
		private delegate IntPtr Baselib_Memory_AlignedReallocateDelegate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment);

		// Token: 0x02000A66 RID: 2662
		// (Invoke) Token: 0x060032D2 RID: 13010
		private delegate void Baselib_Memory_AlignedFreeDelegate(IntPtr ptr);

		// Token: 0x02000A67 RID: 2663
		// (Invoke) Token: 0x060032D4 RID: 13012
		private delegate void Baselib_Thread_YieldExecutionDelegate();

		// Token: 0x02000A68 RID: 2664
		// (Invoke) Token: 0x060032D6 RID: 13014
		private delegate IntPtr Baselib_Thread_GetCurrentThreadIdDelegate();

		// Token: 0x02000A69 RID: 2665
		// (Invoke) Token: 0x060032D8 RID: 13016
		private delegate UIntPtr Baselib_TLS_AllocDelegate();

		// Token: 0x02000A6A RID: 2666
		// (Invoke) Token: 0x060032DA RID: 13018
		private delegate void Baselib_TLS_FreeDelegate(UIntPtr handle);

		// Token: 0x02000A6B RID: 2667
		// (Invoke) Token: 0x060032DC RID: 13020
		private delegate void Baselib_TLS_SetDelegate(UIntPtr handle, UIntPtr value);

		// Token: 0x02000A6C RID: 2668
		// (Invoke) Token: 0x060032DE RID: 13022
		private delegate UIntPtr Baselib_TLS_GetDelegate(UIntPtr handle);

		// Token: 0x02000A6D RID: 2669
		// (Invoke) Token: 0x060032E0 RID: 13024
		private delegate ulong Baselib_Timer_GetHighPrecisionTimerTicksDelegate();

		// Token: 0x02000A6E RID: 2670
		// (Invoke) Token: 0x060032E2 RID: 13026
		private delegate void Baselib_Timer_WaitForAtLeastDelegate(uint timeInMilliseconds);

		// Token: 0x02000A6F RID: 2671
		// (Invoke) Token: 0x060032E4 RID: 13028
		private delegate double Baselib_Timer_GetTimeSinceStartupInSecondsDelegate();

		// Token: 0x02000A70 RID: 2672
		// (Invoke) Token: 0x060032E6 RID: 13030
		private delegate void Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate([Out] IntPtr ret);
	}
}
