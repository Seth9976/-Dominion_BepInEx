using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002CD RID: 717
	[Serializable]
	public class gameserveritem_t : Object
	{
		// Token: 0x0600295C RID: 10588 RVA: 0x000B1FD4 File Offset: 0x000B01D4
		// Note: this type is marked as 'beforefieldinit'.
		static gameserveritem_t()
		{
			Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "gameserveritem_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr);
			gameserveritem_t.NativeFieldInfoPtr_m_NetAdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_NetAdr");
			gameserveritem_t.NativeFieldInfoPtr_m_nPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nPing");
			gameserveritem_t.NativeFieldInfoPtr_m_bHadSuccessfulResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_bHadSuccessfulResponse");
			gameserveritem_t.NativeFieldInfoPtr_m_bDoNotRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_bDoNotRefresh");
			gameserveritem_t.NativeFieldInfoPtr_m_szGameDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szGameDir");
			gameserveritem_t.NativeFieldInfoPtr_m_szMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szMap");
			gameserveritem_t.NativeFieldInfoPtr_m_szGameDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szGameDescription");
			gameserveritem_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nAppID");
			gameserveritem_t.NativeFieldInfoPtr_m_nPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nPlayers");
			gameserveritem_t.NativeFieldInfoPtr_m_nMaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nMaxPlayers");
			gameserveritem_t.NativeFieldInfoPtr_m_nBotPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nBotPlayers");
			gameserveritem_t.NativeFieldInfoPtr_m_bPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_bPassword");
			gameserveritem_t.NativeFieldInfoPtr_m_bSecure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_bSecure");
			gameserveritem_t.NativeFieldInfoPtr_m_ulTimeLastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_ulTimeLastPlayed");
			gameserveritem_t.NativeFieldInfoPtr_m_nServerVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nServerVersion");
			gameserveritem_t.NativeFieldInfoPtr_m_szServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szServerName");
			gameserveritem_t.NativeFieldInfoPtr_m_szGameTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szGameTags");
			gameserveritem_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_steamID");
			gameserveritem_t.NativeMethodInfoPtr_GetGameDir_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668554);
			gameserveritem_t.NativeMethodInfoPtr_SetGameDir_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668555);
			gameserveritem_t.NativeMethodInfoPtr_GetMap_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668556);
			gameserveritem_t.NativeMethodInfoPtr_SetMap_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668557);
			gameserveritem_t.NativeMethodInfoPtr_GetGameDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668558);
			gameserveritem_t.NativeMethodInfoPtr_SetGameDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668559);
			gameserveritem_t.NativeMethodInfoPtr_GetServerName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668560);
			gameserveritem_t.NativeMethodInfoPtr_SetServerName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668561);
			gameserveritem_t.NativeMethodInfoPtr_GetGameTags_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668562);
			gameserveritem_t.NativeMethodInfoPtr_SetGameTags_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668563);
			gameserveritem_t.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100668564);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000B2248 File Offset: 0x000B0448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210320, XrefRangeEnd = 210324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGameDir()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetGameDir_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000B2280 File Offset: 0x000B0480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210324, XrefRangeEnd = 210328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameDir(string dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetGameDir_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000B22C4 File Offset: 0x000B04C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210328, XrefRangeEnd = 210332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetMap_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000B22FC File Offset: 0x000B04FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210332, XrefRangeEnd = 210336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMap(string map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetMap_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000B2340 File Offset: 0x000B0540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210336, XrefRangeEnd = 210340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGameDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetGameDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000B2378 File Offset: 0x000B0578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210340, XrefRangeEnd = 210344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameDescription(string desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetGameDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000B23BC File Offset: 0x000B05BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210344, XrefRangeEnd = 210348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetServerName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetServerName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000B23F4 File Offset: 0x000B05F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210348, XrefRangeEnd = 210352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetServerName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetServerName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000B2438 File Offset: 0x000B0638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210352, XrefRangeEnd = 210356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGameTags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetGameTags_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000B2470 File Offset: 0x000B0670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210356, XrefRangeEnd = 210360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameTags(string tags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tags);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetGameTags_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x000B24B4 File Offset: 0x000B06B4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe gameserveritem_t()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00010A72 File Offset: 0x0000EC72
		public gameserveritem_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x000B24F0 File Offset: 0x000B06F0
		// (set) Token: 0x0600296A RID: 10602 RVA: 0x00010A7B File Offset: 0x0000EC7B
		public unsafe servernetadr_t m_NetAdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_NetAdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_NetAdr)) = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x000B2518 File Offset: 0x000B0718
		// (set) Token: 0x0600296C RID: 10604 RVA: 0x00010A96 File Offset: 0x0000EC96
		public unsafe int m_nPing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nPing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nPing)) = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x000B2540 File Offset: 0x000B0740
		// (set) Token: 0x0600296E RID: 10606 RVA: 0x00010AB1 File Offset: 0x0000ECB1
		public unsafe bool m_bHadSuccessfulResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bHadSuccessfulResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bHadSuccessfulResponse)) = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x000B2568 File Offset: 0x000B0768
		// (set) Token: 0x06002970 RID: 10608 RVA: 0x00010ACC File Offset: 0x0000ECCC
		public unsafe bool m_bDoNotRefresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bDoNotRefresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bDoNotRefresh)) = value;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x000B2590 File Offset: 0x000B0790
		// (set) Token: 0x06002972 RID: 10610 RVA: 0x00010AE7 File Offset: 0x0000ECE7
		public unsafe Il2CppStructArray<byte> m_szGameDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameDir);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameDir), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x000B25C0 File Offset: 0x000B07C0
		// (set) Token: 0x06002974 RID: 10612 RVA: 0x00010B06 File Offset: 0x0000ED06
		public unsafe Il2CppStructArray<byte> m_szMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x000B25F0 File Offset: 0x000B07F0
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x00010B25 File Offset: 0x0000ED25
		public unsafe Il2CppStructArray<byte> m_szGameDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x000B2620 File Offset: 0x000B0820
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x00010B44 File Offset: 0x0000ED44
		public unsafe uint m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x000B2648 File Offset: 0x000B0848
		// (set) Token: 0x0600297A RID: 10618 RVA: 0x00010B5F File Offset: 0x0000ED5F
		public unsafe int m_nPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nPlayers)) = value;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x000B2670 File Offset: 0x000B0870
		// (set) Token: 0x0600297C RID: 10620 RVA: 0x00010B7A File Offset: 0x0000ED7A
		public unsafe int m_nMaxPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nMaxPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nMaxPlayers)) = value;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x000B2698 File Offset: 0x000B0898
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x00010B95 File Offset: 0x0000ED95
		public unsafe int m_nBotPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nBotPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nBotPlayers)) = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x000B26C0 File Offset: 0x000B08C0
		// (set) Token: 0x06002980 RID: 10624 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		public unsafe bool m_bPassword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bPassword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bPassword)) = value;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x000B26E8 File Offset: 0x000B08E8
		// (set) Token: 0x06002982 RID: 10626 RVA: 0x00010BCB File Offset: 0x0000EDCB
		public unsafe bool m_bSecure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bSecure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bSecure)) = value;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x000B2710 File Offset: 0x000B0910
		// (set) Token: 0x06002984 RID: 10628 RVA: 0x00010BE6 File Offset: 0x0000EDE6
		public unsafe uint m_ulTimeLastPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_ulTimeLastPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_ulTimeLastPlayed)) = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x000B2738 File Offset: 0x000B0938
		// (set) Token: 0x06002986 RID: 10630 RVA: 0x00010C01 File Offset: 0x0000EE01
		public unsafe int m_nServerVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nServerVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nServerVersion)) = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x000B2760 File Offset: 0x000B0960
		// (set) Token: 0x06002988 RID: 10632 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public unsafe Il2CppStructArray<byte> m_szServerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szServerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szServerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x000B2790 File Offset: 0x000B0990
		// (set) Token: 0x0600298A RID: 10634 RVA: 0x00010C3B File Offset: 0x0000EE3B
		public unsafe Il2CppStructArray<byte> m_szGameTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x000B27C0 File Offset: 0x000B09C0
		// (set) Token: 0x0600298C RID: 10636 RVA: 0x00010C5A File Offset: 0x0000EE5A
		public unsafe CSteamID m_steamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_steamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_steamID)) = value;
			}
		}

		// Token: 0x040027F2 RID: 10226
		private static readonly IntPtr NativeFieldInfoPtr_m_NetAdr;

		// Token: 0x040027F3 RID: 10227
		private static readonly IntPtr NativeFieldInfoPtr_m_nPing;

		// Token: 0x040027F4 RID: 10228
		private static readonly IntPtr NativeFieldInfoPtr_m_bHadSuccessfulResponse;

		// Token: 0x040027F5 RID: 10229
		private static readonly IntPtr NativeFieldInfoPtr_m_bDoNotRefresh;

		// Token: 0x040027F6 RID: 10230
		private static readonly IntPtr NativeFieldInfoPtr_m_szGameDir;

		// Token: 0x040027F7 RID: 10231
		private static readonly IntPtr NativeFieldInfoPtr_m_szMap;

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeFieldInfoPtr_m_szGameDescription;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeFieldInfoPtr_m_nPlayers;

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeFieldInfoPtr_m_nMaxPlayers;

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeFieldInfoPtr_m_nBotPlayers;

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeFieldInfoPtr_m_bPassword;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeFieldInfoPtr_m_bSecure;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeFieldInfoPtr_m_ulTimeLastPlayed;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeFieldInfoPtr_m_nServerVersion;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeFieldInfoPtr_m_szServerName;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeFieldInfoPtr_m_szGameTags;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_GetGameDir_Public_String_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_SetGameDir_Public_Void_String_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_GetMap_Public_String_0;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeMethodInfoPtr_SetMap_Public_Void_String_0;

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeMethodInfoPtr_GetGameDescription_Public_String_0;

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeMethodInfoPtr_SetGameDescription_Public_Void_String_0;

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeMethodInfoPtr_GetServerName_Public_String_0;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeMethodInfoPtr_SetServerName_Public_Void_String_0;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeMethodInfoPtr_GetGameTags_Public_String_0;

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeMethodInfoPtr_SetGameTags_Public_Void_String_0;

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
