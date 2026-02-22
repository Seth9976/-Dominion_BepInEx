using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002CA RID: 714
	public static class SteamEncryptedAppTicket : Object
	{
		// Token: 0x060028D1 RID: 10449 RVA: 0x000B080C File Offset: 0x000AEA0C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamEncryptedAppTicket()
		{
			Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamEncryptedAppTicket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BDecryptTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_byref_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668501);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BIsTicketForApp_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668502);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketIssueTime_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668503);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketSteamID_Public_Static_Void_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668504);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketAppID_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668505);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BUserOwnsAppInTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668506);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BUserIsVacBanned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668507);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_GetUserVariableData_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668508);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BIsTicketSigned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100668509);
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000B08F0 File Offset: 0x000AEAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209852, XrefRangeEnd = 209854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BDecryptTicket(Il2CppStructArray<byte> rgubTicketEncrypted, uint cubTicketEncrypted, Il2CppStructArray<byte> rgubTicketDecrypted, ref uint pcubTicketDecrypted, Il2CppStructArray<byte> rgubKey, int cubKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketEncrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketEncrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgubKey);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BDecryptTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_byref_UInt32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000B0980 File Offset: 0x000AEB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209854, XrefRangeEnd = 209856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsTicketForApp(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BIsTicketForApp_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000B09E0 File Offset: 0x000AEBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209856, XrefRangeEnd = 209858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTicketIssueTime(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketIssueTime_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000B0A30 File Offset: 0x000AEC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209858, XrefRangeEnd = 209860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetTicketSteamID(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketSteamID_Public_Static_Void_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000B0A84 File Offset: 0x000AEC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209860, XrefRangeEnd = 209862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTicketAppID(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketAppID_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000B0AD4 File Offset: 0x000AECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209862, XrefRangeEnd = 209864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BUserOwnsAppInTicket(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BUserOwnsAppInTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000B0B34 File Offset: 0x000AED34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209864, XrefRangeEnd = 209866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BUserIsVacBanned(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BUserIsVacBanned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000B0B84 File Offset: 0x000AED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209866, XrefRangeEnd = 209875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetUserVariableData(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubUserData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_GetUserVariableData_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000B0BE4 File Offset: 0x000AEDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209875, XrefRangeEnd = 209877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsTicketSigned(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, Il2CppStructArray<byte> pubRSAKey, uint cubRSAKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubRSAKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubRSAKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BIsTicketSigned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00010827 File Offset: 0x0000EA27
		public SteamEncryptedAppTicket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeMethodInfoPtr_BDecryptTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_byref_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeMethodInfoPtr_BIsTicketForApp_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0;

		// Token: 0x04002797 RID: 10135
		private static readonly IntPtr NativeMethodInfoPtr_GetTicketIssueTime_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04002798 RID: 10136
		private static readonly IntPtr NativeMethodInfoPtr_GetTicketSteamID_Public_Static_Void_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0;

		// Token: 0x04002799 RID: 10137
		private static readonly IntPtr NativeMethodInfoPtr_GetTicketAppID_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400279A RID: 10138
		private static readonly IntPtr NativeMethodInfoPtr_BUserOwnsAppInTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0;

		// Token: 0x0400279B RID: 10139
		private static readonly IntPtr NativeMethodInfoPtr_BUserIsVacBanned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400279C RID: 10140
		private static readonly IntPtr NativeMethodInfoPtr_GetUserVariableData_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0;

		// Token: 0x0400279D RID: 10141
		private static readonly IntPtr NativeMethodInfoPtr_BIsTicketSigned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_UInt32_0;
	}
}
