using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Steamworks
{
	// Token: 0x020002B8 RID: 696
	public static class CallbackDispatcher : Object
	{
		// Token: 0x060027ED RID: 10221 RVA: 0x000AD7E8 File Offset: 0x000AB9E8
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackDispatcher()
		{
			Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallbackDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr);
			CallbackDispatcher.NativeFieldInfoPtr_m_registeredCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_registeredCallbacks");
			CallbackDispatcher.NativeFieldInfoPtr_m_registeredGameServerCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_registeredGameServerCallbacks");
			CallbackDispatcher.NativeFieldInfoPtr_m_registeredCallResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_registeredCallResults");
			CallbackDispatcher.NativeFieldInfoPtr_m_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_sync");
			CallbackDispatcher.NativeFieldInfoPtr_m_pCallbackMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_pCallbackMsg");
			CallbackDispatcher.NativeFieldInfoPtr_m_initCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_initCount");
			CallbackDispatcher.NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668398);
			CallbackDispatcher.NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668399);
			CallbackDispatcher.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668400);
			CallbackDispatcher.NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668401);
			CallbackDispatcher.NativeMethodInfoPtr_Register_Internal_Static_Void_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668402);
			CallbackDispatcher.NativeMethodInfoPtr_Register_Internal_Static_Void_SteamAPICall_t_CallResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668403);
			CallbackDispatcher.NativeMethodInfoPtr_Unregister_Internal_Static_Void_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668404);
			CallbackDispatcher.NativeMethodInfoPtr_Unregister_Internal_Static_Void_SteamAPICall_t_CallResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668405);
			CallbackDispatcher.NativeMethodInfoPtr_UnregisterAll_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668406);
			CallbackDispatcher.NativeMethodInfoPtr_RunFrame_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100668407);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000AD958 File Offset: 0x000ABB58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 206898, RefRangeEnd = 206905, XrefRangeStart = 206894, XrefRangeEnd = 206898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExceptionHandler(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x000AD990 File Offset: 0x000ABB90
		public unsafe static bool IsInitialized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206905, XrefRangeEnd = 206909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000AD9C0 File Offset: 0x000ABBC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206937, RefRangeEnd = 206939, XrefRangeStart = 206909, XrefRangeEnd = 206937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000AD9E8 File Offset: 0x000ABBE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206959, RefRangeEnd = 206961, XrefRangeStart = 206939, XrefRangeEnd = 206959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000ADA10 File Offset: 0x000ABC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206989, RefRangeEnd = 206990, XrefRangeStart = 206961, XrefRangeEnd = 206989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(Callback cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_Register_Internal_Static_Void_Callback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000ADA48 File Offset: 0x000ABC48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207023, RefRangeEnd = 207024, XrefRangeStart = 206990, XrefRangeEnd = 207023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(SteamAPICall_t asyncCall, CallResult cr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref asyncCall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_Register_Internal_Static_Void_SteamAPICall_t_CallResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000ADA8C File Offset: 0x000ABC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207047, RefRangeEnd = 207048, XrefRangeStart = 207024, XrefRangeEnd = 207047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unregister(Callback cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_Unregister_Internal_Static_Void_Callback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000ADAC4 File Offset: 0x000ABCC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207076, RefRangeEnd = 207078, XrefRangeStart = 207048, XrefRangeEnd = 207076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unregister(SteamAPICall_t asyncCall, CallResult cr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref asyncCall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_Unregister_Internal_Static_Void_SteamAPICall_t_CallResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000ADB08 File Offset: 0x000ABD08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207186, RefRangeEnd = 207187, XrefRangeStart = 207078, XrefRangeEnd = 207186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_UnregisterAll_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x000ADB30 File Offset: 0x000ABD30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207319, RefRangeEnd = 207321, XrefRangeStart = 207187, XrefRangeEnd = 207319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunFrame(bool isGameServer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackDispatcher.NativeMethodInfoPtr_RunFrame_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00010302 File Offset: 0x0000E502
		public CallbackDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x000ADB64 File Offset: 0x000ABD64
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x0001030B File Offset: 0x0000E50B
		public unsafe static Dictionary<int, List<Callback>> m_registeredCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallbackDispatcher.NativeFieldInfoPtr_m_registeredCallbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<Callback>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackDispatcher.NativeFieldInfoPtr_m_registeredCallbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x000ADB8C File Offset: 0x000ABD8C
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x0001031D File Offset: 0x0000E51D
		public unsafe static Dictionary<int, List<Callback>> m_registeredGameServerCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallbackDispatcher.NativeFieldInfoPtr_m_registeredGameServerCallbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<Callback>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackDispatcher.NativeFieldInfoPtr_m_registeredGameServerCallbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x000ADBB4 File Offset: 0x000ABDB4
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x0001032F File Offset: 0x0000E52F
		public unsafe static Dictionary<ulong, List<CallResult>> m_registeredCallResults
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallbackDispatcher.NativeFieldInfoPtr_m_registeredCallResults, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ulong, List<CallResult>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackDispatcher.NativeFieldInfoPtr_m_registeredCallResults, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x000ADBDC File Offset: 0x000ABDDC
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x00010341 File Offset: 0x0000E541
		public unsafe static Object m_sync
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallbackDispatcher.NativeFieldInfoPtr_m_sync, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackDispatcher.NativeFieldInfoPtr_m_sync, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x000ADC04 File Offset: 0x000ABE04
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x00010353 File Offset: 0x0000E553
		public unsafe static IntPtr m_pCallbackMsg
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallbackDispatcher.NativeFieldInfoPtr_m_pCallbackMsg, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackDispatcher.NativeFieldInfoPtr_m_pCallbackMsg, (void*)(&value));
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x000ADC20 File Offset: 0x000ABE20
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x00010361 File Offset: 0x0000E561
		public unsafe static int m_initCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CallbackDispatcher.NativeFieldInfoPtr_m_initCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackDispatcher.NativeFieldInfoPtr_m_initCount, (void*)(&value));
			}
		}

		// Token: 0x04002702 RID: 9986
		private static readonly IntPtr NativeFieldInfoPtr_m_registeredCallbacks;

		// Token: 0x04002703 RID: 9987
		private static readonly IntPtr NativeFieldInfoPtr_m_registeredGameServerCallbacks;

		// Token: 0x04002704 RID: 9988
		private static readonly IntPtr NativeFieldInfoPtr_m_registeredCallResults;

		// Token: 0x04002705 RID: 9989
		private static readonly IntPtr NativeFieldInfoPtr_m_sync;

		// Token: 0x04002706 RID: 9990
		private static readonly IntPtr NativeFieldInfoPtr_m_pCallbackMsg;

		// Token: 0x04002707 RID: 9991
		private static readonly IntPtr NativeFieldInfoPtr_m_initCount;

		// Token: 0x04002708 RID: 9992
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0;

		// Token: 0x04002709 RID: 9993
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0;

		// Token: 0x0400270A RID: 9994
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		// Token: 0x0400270B RID: 9995
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0;

		// Token: 0x0400270C RID: 9996
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_Callback_0;

		// Token: 0x0400270D RID: 9997
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_SteamAPICall_t_CallResult_0;

		// Token: 0x0400270E RID: 9998
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Internal_Static_Void_Callback_0;

		// Token: 0x0400270F RID: 9999
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Internal_Static_Void_SteamAPICall_t_CallResult_0;

		// Token: 0x04002710 RID: 10000
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterAll_Private_Static_Void_0;

		// Token: 0x04002711 RID: 10001
		private static readonly IntPtr NativeMethodInfoPtr_RunFrame_Internal_Static_Void_Boolean_0;
	}
}
