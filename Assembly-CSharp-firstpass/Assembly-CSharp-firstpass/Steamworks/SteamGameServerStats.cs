using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000155 RID: 341
	public static class SteamGameServerStats : Object
	{
		// Token: 0x060019EF RID: 6639 RVA: 0x00074684 File Offset: 0x00072884
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerStats()
		{
			Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr);
			SteamGameServerStats.NativeMethodInfoPtr_RequestUserStats_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666657);
			SteamGameServerStats.NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666658);
			SteamGameServerStats.NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666659);
			SteamGameServerStats.NativeMethodInfoPtr_GetUserAchievement_Public_Static_Boolean_CSteamID_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666660);
			SteamGameServerStats.NativeMethodInfoPtr_SetUserStat_Public_Static_Boolean_CSteamID_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666661);
			SteamGameServerStats.NativeMethodInfoPtr_SetUserStat_Public_Static_Boolean_CSteamID_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666662);
			SteamGameServerStats.NativeMethodInfoPtr_UpdateUserAvgRateStat_Public_Static_Boolean_CSteamID_String_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666663);
			SteamGameServerStats.NativeMethodInfoPtr_SetUserAchievement_Public_Static_Boolean_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666664);
			SteamGameServerStats.NativeMethodInfoPtr_ClearUserAchievement_Public_Static_Boolean_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666665);
			SteamGameServerStats.NativeMethodInfoPtr_StoreUserStats_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerStats>.NativeClassPtr, 100666666);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0007477C File Offset: 0x0007297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197895, XrefRangeEnd = 197903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_RequestUserStats_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x000747BC File Offset: 0x000729BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197903, XrefRangeEnd = 197915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0007481C File Offset: 0x00072A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197915, XrefRangeEnd = 197927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0007487C File Offset: 0x00072A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197927, XrefRangeEnd = 197939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_GetUserAchievement_Public_Static_Boolean_CSteamID_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000748DC File Offset: 0x00072ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197939, XrefRangeEnd = 197951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_SetUserStat_Public_Static_Boolean_CSteamID_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0007493C File Offset: 0x00072B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197951, XrefRangeEnd = 197963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_SetUserStat_Public_Static_Boolean_CSteamID_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0007499C File Offset: 0x00072B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197963, XrefRangeEnd = 197975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flCountThisSession;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dSessionLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_UpdateUserAvgRateStat_Public_Static_Boolean_CSteamID_String_Single_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00074A08 File Offset: 0x00072C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197975, XrefRangeEnd = 197987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_SetUserAchievement_Public_Static_Boolean_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00074A58 File Offset: 0x00072C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197987, XrefRangeEnd = 197999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_ClearUserAchievement_Public_Static_Boolean_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00074AA8 File Offset: 0x00072CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197999, XrefRangeEnd = 198007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerStats.NativeMethodInfoPtr_StoreUserStats_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0000BA5D File Offset: 0x00009C5D
		public SteamGameServerStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserStats_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Int32_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Single_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_GetUserAchievement_Public_Static_Boolean_CSteamID_String_byref_Boolean_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_SetUserStat_Public_Static_Boolean_CSteamID_String_Int32_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_SetUserStat_Public_Static_Boolean_CSteamID_String_Single_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUserAvgRateStat_Public_Static_Boolean_CSteamID_String_Single_Double_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_SetUserAchievement_Public_Static_Boolean_CSteamID_String_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_ClearUserAchievement_Public_Static_Boolean_CSteamID_String_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_StoreUserStats_Public_Static_SteamAPICall_t_CSteamID_0;
	}
}
