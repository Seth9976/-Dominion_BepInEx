using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000271 RID: 625
	public static class Monitor : Object
	{
		// Token: 0x06002AFA RID: 11002 RVA: 0x000DD3C0 File Offset: 0x000DB5C0
		// Note: this type is marked as 'beforefieldinit'.
		static Monitor()
		{
			Il2CppClassPointerStore<Monitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Monitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Monitor>.NativeClassPtr);
			Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670129);
			Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670130);
			Monitor.NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670131);
			Monitor.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670132);
			Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670133);
			Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670134);
			Monitor.NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670135);
			Monitor.NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670136);
			Monitor.NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670137);
			Monitor.NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670138);
			Monitor.NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670139);
			Monitor.NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670140);
			Monitor.NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670141);
			Monitor.NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670142);
			Monitor.NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670143);
			Monitor.NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670144);
			Monitor.NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670145);
			Monitor.NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100670146);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000DD558 File Offset: 0x000DB758
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 331625, RefRangeEnd = 331629, XrefRangeStart = 331624, XrefRangeEnd = 331625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x000DD590 File Offset: 0x000DB790
		[CallerCount(279)]
		[CachedScanResults(RefRangeStart = 331637, RefRangeEnd = 331916, XrefRangeStart = 331629, XrefRangeEnd = 331637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object obj, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000DD5D4 File Offset: 0x000DB7D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331924, RefRangeEnd = 331925, XrefRangeStart = 331916, XrefRangeEnd = 331924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowLockTakenException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000DD5FC File Offset: 0x000DB7FC
		[CallerCount(285)]
		[CachedScanResults(RefRangeStart = 331926, RefRangeEnd = 332211, XrefRangeStart = 331925, XrefRangeEnd = 331926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000DD634 File Offset: 0x000DB834
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 332231, RefRangeEnd = 332235, XrefRangeStart = 332211, XrefRangeEnd = 332231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(Object obj, int millisecondsTimeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000DD694 File Offset: 0x000DB894
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 332231, RefRangeEnd = 332235, XrefRangeStart = 332231, XrefRangeEnd = 332235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(Object obj, int millisecondsTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000DD6E4 File Offset: 0x000DB8E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 332249, RefRangeEnd = 332251, XrefRangeStart = 332235, XrefRangeEnd = 332249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000DD71C File Offset: 0x000DB91C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 332265, RefRangeEnd = 332269, XrefRangeStart = 332251, XrefRangeEnd = 332265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PulseAll(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000DD754 File Offset: 0x000DB954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332269, XrefRangeEnd = 332270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Monitor_test_synchronised(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000DD798 File Offset: 0x000DB998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332270, XrefRangeEnd = 332271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Monitor_pulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000DD7D0 File Offset: 0x000DB9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332271, XrefRangeEnd = 332279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjPulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000DD808 File Offset: 0x000DBA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332279, XrefRangeEnd = 332280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Monitor_pulse_all(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x000DD840 File Offset: 0x000DBA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332280, XrefRangeEnd = 332288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjPulseAll(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000DD878 File Offset: 0x000DBA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332288, XrefRangeEnd = 332289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Monitor_wait(Object obj, int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000DD8C8 File Offset: 0x000DBAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332289, XrefRangeEnd = 332303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ObjWait(bool exitContext, int millisecondsTimeout, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitContext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000DD928 File Offset: 0x000DBB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332303, XrefRangeEnd = 332304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void try_enter_with_atomic_var(Object obj, int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000DD97C File Offset: 0x000DBB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332304, XrefRangeEnd = 332317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReliableEnterTimeout(Object obj, int timeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x000DD9D0 File Offset: 0x000DBBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332317, XrefRangeEnd = 332324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReliableEnter(Object obj, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0000F026 File Offset: 0x0000D226
		public Monitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0;
	}
}
