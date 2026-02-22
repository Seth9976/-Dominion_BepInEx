using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000261 RID: 609
	[StructLayout(2)]
	public struct SpinLock
	{
		// Token: 0x06002A5E RID: 10846 RVA: 0x000DAE0C File Offset: 0x000D900C
		// Note: this type is marked as 'beforefieldinit'.
		static SpinLock()
		{
			Il2CppClassPointerStore<SpinLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SpinLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinLock>.NativeClassPtr);
			SpinLock.NativeFieldInfoPtr_m_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "m_owner");
			SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "MAXIMUM_WAITERS");
			SpinLock.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670038);
			SpinLock.NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670039);
			SpinLock.NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670040);
			SpinLock.NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670041);
			SpinLock.NativeMethodInfoPtr_DecrementWaiters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670042);
			SpinLock.NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670043);
			SpinLock.NativeMethodInfoPtr_Exit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670044);
			SpinLock.NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670045);
			SpinLock.NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670046);
			SpinLock.NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100670047);
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000DAF2C File Offset: 0x000D912C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331045, RefRangeEnd = 331046, XrefRangeStart = 331042, XrefRangeEnd = 331045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpinLock(bool enableThreadOwnerTracking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableThreadOwnerTracking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x000DAF60 File Offset: 0x000D9160
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 331051, RefRangeEnd = 331055, XrefRangeStart = 331046, XrefRangeEnd = 331051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enter(ref bool lockTaken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lockTaken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000DAF94 File Offset: 0x000D9194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331060, RefRangeEnd = 331061, XrefRangeStart = 331055, XrefRangeEnd = 331060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000DAFD4 File Offset: 0x000D91D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 331098, RefRangeEnd = 331100, XrefRangeStart = 331061, XrefRangeEnd = 331098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000DB014 File Offset: 0x000D9214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331106, RefRangeEnd = 331107, XrefRangeStart = 331100, XrefRangeEnd = 331106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementWaiters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_DecrementWaiters_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x000DB03C File Offset: 0x000D923C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331107, XrefRangeEnd = 331119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x000DB08C File Offset: 0x000D928C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 331125, RefRangeEnd = 331130, XrefRangeStart = 331119, XrefRangeEnd = 331125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(bool useMemoryBarrier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMemoryBarrier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_Exit_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000DB0C0 File Offset: 0x000D92C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331134, RefRangeEnd = 331135, XrefRangeStart = 331130, XrefRangeEnd = 331134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlowPath(bool useMemoryBarrier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMemoryBarrier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000DB0F4 File Offset: 0x000D92F4
		public unsafe bool IsHeldByCurrentThread
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331139, RefRangeEnd = 331140, XrefRangeStart = 331135, XrefRangeEnd = 331139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002A68 RID: 10856 RVA: 0x000DB124 File Offset: 0x000D9324
		public unsafe bool IsThreadOwnerTrackingEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331140, XrefRangeEnd = 331141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x0000EC95 File Offset: 0x0000CE95
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000DB154 File Offset: 0x000D9354
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x0000ECA7 File Offset: 0x0000CEA7
		public unsafe static int MAXIMUM_WAITERS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS, (void*)(&value));
			}
		}

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeFieldInfoPtr_m_owner;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeFieldInfoPtr_MAXIMUM_WAITERS;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0;

		// Token: 0x0400252B RID: 9515
		private static readonly IntPtr NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0;

		// Token: 0x0400252C RID: 9516
		private static readonly IntPtr NativeMethodInfoPtr_DecrementWaiters_Private_Void_0;

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_Boolean_0;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0;

		// Token: 0x04002532 RID: 9522
		[FieldOffset(0)]
		public int m_owner;

		// Token: 0x020005E9 RID: 1513
		public class SystemThreading_SpinLockDebugView : Object
		{
			// Token: 0x06005255 RID: 21077 RVA: 0x0001F717 File Offset: 0x0001D917
			// Note: this type is marked as 'beforefieldinit'.
			static SystemThreading_SpinLockDebugView()
			{
				Il2CppClassPointerStore<SpinLock.SystemThreading_SpinLockDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "SystemThreading_SpinLockDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinLock.SystemThreading_SpinLockDebugView>.NativeClassPtr);
			}

			// Token: 0x06005256 RID: 21078 RVA: 0x0001F737 File Offset: 0x0001D937
			public SystemThreading_SpinLockDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
