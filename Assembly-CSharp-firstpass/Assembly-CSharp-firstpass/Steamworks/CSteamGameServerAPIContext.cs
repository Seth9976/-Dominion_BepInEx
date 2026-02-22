using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002CC RID: 716
	public static class CSteamGameServerAPIContext : Object
	{
		// Token: 0x06002934 RID: 10548 RVA: 0x000B19B4 File Offset: 0x000AFBB4
		// Note: this type is marked as 'beforefieldinit'.
		static CSteamGameServerAPIContext()
		{
			Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CSteamGameServerAPIContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr);
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamClient");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamGameServer");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamUtils");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamNetworking");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServerStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamGameServerStats");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamHTTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamHTTP");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamInventory");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamUGC");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamApps");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamNetworkingUtils");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingSockets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamNetworkingSockets");
			CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, "m_pSteamNetworkingMessages");
			CSteamGameServerAPIContext.NativeMethodInfoPtr_Clear_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668540);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668541);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668542);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamGameServer_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668543);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668544);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668545);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamGameServerStats_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668546);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668547);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668548);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668549);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668550);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworkingUtils_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668551);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworkingSockets_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668552);
			CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworkingMessages_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamGameServerAPIContext>.NativeClassPtr, 100668553);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000B1BEC File Offset: 0x000AFDEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210185, RefRangeEnd = 210186, XrefRangeStart = 210171, XrefRangeEnd = 210185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_Clear_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000B1C14 File Offset: 0x000AFE14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210294, RefRangeEnd = 210296, XrefRangeStart = 210186, XrefRangeEnd = 210294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000B1C44 File Offset: 0x000AFE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210296, XrefRangeEnd = 210298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamClient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000B1C74 File Offset: 0x000AFE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210298, XrefRangeEnd = 210300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamGameServer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamGameServer_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000B1CA4 File Offset: 0x000AFEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210300, XrefRangeEnd = 210302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUtils()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000B1CD4 File Offset: 0x000AFED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210302, XrefRangeEnd = 210304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000B1D04 File Offset: 0x000AFF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210304, XrefRangeEnd = 210306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamGameServerStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamGameServerStats_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000B1D34 File Offset: 0x000AFF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210306, XrefRangeEnd = 210308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamHTTP()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000B1D64 File Offset: 0x000AFF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210308, XrefRangeEnd = 210310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamInventory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000B1D94 File Offset: 0x000AFF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210310, XrefRangeEnd = 210312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUGC()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000B1DC4 File Offset: 0x000AFFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210312, XrefRangeEnd = 210314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamApps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x000B1DF4 File Offset: 0x000AFFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210314, XrefRangeEnd = 210316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworkingUtils()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworkingUtils_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000B1E24 File Offset: 0x000B0024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210316, XrefRangeEnd = 210318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworkingSockets()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworkingSockets_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000B1E54 File Offset: 0x000B0054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210318, XrefRangeEnd = 210320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworkingMessages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamGameServerAPIContext.NativeMethodInfoPtr_GetSteamNetworkingMessages_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x000109C1 File Offset: 0x0000EBC1
		public CSteamGameServerAPIContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000B1E84 File Offset: 0x000B0084
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x000109CA File Offset: 0x0000EBCA
		public unsafe static IntPtr m_pSteamClient
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamClient, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamClient, (void*)(&value));
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x000B1EA0 File Offset: 0x000B00A0
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x000109D8 File Offset: 0x0000EBD8
		public unsafe static IntPtr m_pSteamGameServer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServer, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServer, (void*)(&value));
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x000B1EBC File Offset: 0x000B00BC
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x000109E6 File Offset: 0x0000EBE6
		public unsafe static IntPtr m_pSteamUtils
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUtils, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUtils, (void*)(&value));
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x000B1ED8 File Offset: 0x000B00D8
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x000109F4 File Offset: 0x0000EBF4
		public unsafe static IntPtr m_pSteamNetworking
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&value));
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x000B1EF4 File Offset: 0x000B00F4
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x00010A02 File Offset: 0x0000EC02
		public unsafe static IntPtr m_pSteamGameServerStats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServerStats, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamGameServerStats, (void*)(&value));
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000B1F10 File Offset: 0x000B0110
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x00010A10 File Offset: 0x0000EC10
		public unsafe static IntPtr m_pSteamHTTP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&value));
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000B1F2C File Offset: 0x000B012C
		// (set) Token: 0x06002951 RID: 10577 RVA: 0x00010A1E File Offset: 0x0000EC1E
		public unsafe static IntPtr m_pSteamInventory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamInventory, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamInventory, (void*)(&value));
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x000B1F48 File Offset: 0x000B0148
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x00010A2C File Offset: 0x0000EC2C
		public unsafe static IntPtr m_pSteamUGC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUGC, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamUGC, (void*)(&value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x000B1F64 File Offset: 0x000B0164
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x00010A3A File Offset: 0x0000EC3A
		public unsafe static IntPtr m_pSteamApps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamApps, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamApps, (void*)(&value));
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x000B1F80 File Offset: 0x000B0180
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x00010A48 File Offset: 0x0000EC48
		public unsafe static IntPtr m_pSteamNetworkingUtils
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingUtils, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingUtils, (void*)(&value));
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000B1F9C File Offset: 0x000B019C
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00010A56 File Offset: 0x0000EC56
		public unsafe static IntPtr m_pSteamNetworkingSockets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingSockets, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingSockets, (void*)(&value));
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000B1FB8 File Offset: 0x000B01B8
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x00010A64 File Offset: 0x0000EC64
		public unsafe static IntPtr m_pSteamNetworkingMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingMessages, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamGameServerAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingMessages, (void*)(&value));
			}
		}

		// Token: 0x040027D8 RID: 10200
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamClient;

		// Token: 0x040027D9 RID: 10201
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamGameServer;

		// Token: 0x040027DA RID: 10202
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUtils;

		// Token: 0x040027DB RID: 10203
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworking;

		// Token: 0x040027DC RID: 10204
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamGameServerStats;

		// Token: 0x040027DD RID: 10205
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamHTTP;

		// Token: 0x040027DE RID: 10206
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamInventory;

		// Token: 0x040027DF RID: 10207
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUGC;

		// Token: 0x040027E0 RID: 10208
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamApps;

		// Token: 0x040027E1 RID: 10209
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworkingUtils;

		// Token: 0x040027E2 RID: 10210
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworkingSockets;

		// Token: 0x040027E3 RID: 10211
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworkingMessages;

		// Token: 0x040027E4 RID: 10212
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Static_Void_0;

		// Token: 0x040027E5 RID: 10213
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Static_Boolean_0;

		// Token: 0x040027E6 RID: 10214
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0;

		// Token: 0x040027E7 RID: 10215
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamGameServer_Internal_Static_IntPtr_0;

		// Token: 0x040027E8 RID: 10216
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0;

		// Token: 0x040027E9 RID: 10217
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0;

		// Token: 0x040027EA RID: 10218
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamGameServerStats_Internal_Static_IntPtr_0;

		// Token: 0x040027EB RID: 10219
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0;

		// Token: 0x040027EC RID: 10220
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0;

		// Token: 0x040027ED RID: 10221
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0;

		// Token: 0x040027EE RID: 10222
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0;

		// Token: 0x040027EF RID: 10223
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworkingUtils_Internal_Static_IntPtr_0;

		// Token: 0x040027F0 RID: 10224
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworkingSockets_Internal_Static_IntPtr_0;

		// Token: 0x040027F1 RID: 10225
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworkingMessages_Internal_Static_IntPtr_0;
	}
}
