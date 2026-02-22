using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D2 RID: 722
	[Serializable]
	[StructLayout(2)]
	public struct CSteamID
	{
		// Token: 0x060029CE RID: 10702 RVA: 0x000B3940 File Offset: 0x000B1B40
		// Note: this type is marked as 'beforefieldinit'.
		static CSteamID()
		{
			Il2CppClassPointerStore<CSteamID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CSteamID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSteamID>.NativeClassPtr);
			CSteamID.NativeFieldInfoPtr_Nil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "Nil");
			CSteamID.NativeFieldInfoPtr_OutofDateGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "OutofDateGS");
			CSteamID.NativeFieldInfoPtr_LanModeGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "LanModeGS");
			CSteamID.NativeFieldInfoPtr_NotInitYetGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "NotInitYetGS");
			CSteamID.NativeFieldInfoPtr_NonSteamGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "NonSteamGS");
			CSteamID.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "m_SteamID");
			CSteamID.NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668616);
			CSteamID.NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668617);
			CSteamID.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668618);
			CSteamID.NativeMethodInfoPtr_Set_Public_Void_AccountID_t_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668619);
			CSteamID.NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668620);
			CSteamID.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668621);
			CSteamID.NativeMethodInfoPtr_CreateBlankAnonLogon_Public_Void_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668622);
			CSteamID.NativeMethodInfoPtr_CreateBlankAnonUserLogon_Public_Void_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668623);
			CSteamID.NativeMethodInfoPtr_BBlankAnonAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668624);
			CSteamID.NativeMethodInfoPtr_BGameServerAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668625);
			CSteamID.NativeMethodInfoPtr_BPersistentGameServerAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668626);
			CSteamID.NativeMethodInfoPtr_BAnonGameServerAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668627);
			CSteamID.NativeMethodInfoPtr_BContentServerAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668628);
			CSteamID.NativeMethodInfoPtr_BClanAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668629);
			CSteamID.NativeMethodInfoPtr_BChatAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668630);
			CSteamID.NativeMethodInfoPtr_IsLobby_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668631);
			CSteamID.NativeMethodInfoPtr_BIndividualAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668632);
			CSteamID.NativeMethodInfoPtr_BAnonAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668633);
			CSteamID.NativeMethodInfoPtr_BAnonUserAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668634);
			CSteamID.NativeMethodInfoPtr_BConsoleUserAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668635);
			CSteamID.NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668636);
			CSteamID.NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668637);
			CSteamID.NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668638);
			CSteamID.NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668639);
			CSteamID.NativeMethodInfoPtr_GetAccountID_Public_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668640);
			CSteamID.NativeMethodInfoPtr_GetUnAccountInstance_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668641);
			CSteamID.NativeMethodInfoPtr_GetEAccountType_Public_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668642);
			CSteamID.NativeMethodInfoPtr_GetEUniverse_Public_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668643);
			CSteamID.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668644);
			CSteamID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668645);
			CSteamID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668646);
			CSteamID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668647);
			CSteamID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668648);
			CSteamID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668649);
			CSteamID.NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668650);
			CSteamID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668651);
			CSteamID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668652);
			CSteamID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100668653);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000B3CE0 File Offset: 0x000B1EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210635, XrefRangeEnd = 210636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eUniverse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_EUniverse_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000B3D30 File Offset: 0x000B1F30
		[CallerCount(0)]
		public unsafe CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unAccountInstance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eUniverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000B3D8C File Offset: 0x000B1F8C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CSteamID(ulong ulSteamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulSteamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000B3DC0 File Offset: 0x000B1FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210636, RefRangeEnd = 210637, XrefRangeStart = 210636, XrefRangeEnd = 210636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eUniverse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_Set_Public_Void_AccountID_t_EUniverse_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000B3E10 File Offset: 0x000B2010
		[CallerCount(0)]
		public unsafe void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unInstance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eUniverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000B3E6C File Offset: 0x000B206C
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000B3E94 File Offset: 0x000B2094
		[CallerCount(0)]
		public unsafe void CreateBlankAnonLogon(EUniverse eUniverse)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eUniverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_CreateBlankAnonLogon_Public_Void_EUniverse_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x000B3EC8 File Offset: 0x000B20C8
		[CallerCount(0)]
		public unsafe void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eUniverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_CreateBlankAnonUserLogon_Public_Void_EUniverse_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000B3EFC File Offset: 0x000B20FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210637, XrefRangeEnd = 210638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BBlankAnonAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BBlankAnonAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x000B3F2C File Offset: 0x000B212C
		[CallerCount(0)]
		public unsafe bool BGameServerAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BGameServerAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000B3F5C File Offset: 0x000B215C
		[CallerCount(0)]
		public unsafe bool BPersistentGameServerAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BPersistentGameServerAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000B3F8C File Offset: 0x000B218C
		[CallerCount(0)]
		public unsafe bool BAnonGameServerAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BAnonGameServerAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x000B3FBC File Offset: 0x000B21BC
		[CallerCount(0)]
		public unsafe bool BContentServerAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BContentServerAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000B3FEC File Offset: 0x000B21EC
		[CallerCount(0)]
		public unsafe bool BClanAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BClanAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000B401C File Offset: 0x000B221C
		[CallerCount(0)]
		public unsafe bool BChatAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BChatAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000B404C File Offset: 0x000B224C
		[CallerCount(0)]
		public unsafe bool IsLobby()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_IsLobby_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000B407C File Offset: 0x000B227C
		[CallerCount(0)]
		public unsafe bool BIndividualAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BIndividualAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000B40AC File Offset: 0x000B22AC
		[CallerCount(0)]
		public unsafe bool BAnonAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BAnonAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000B40DC File Offset: 0x000B22DC
		[CallerCount(0)]
		public unsafe bool BAnonUserAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BAnonUserAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000B410C File Offset: 0x000B230C
		[CallerCount(0)]
		public unsafe bool BConsoleUserAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BConsoleUserAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000B413C File Offset: 0x000B233C
		[CallerCount(0)]
		public unsafe void SetAccountID(AccountID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000B4170 File Offset: 0x000B2370
		[CallerCount(0)]
		public unsafe void SetAccountInstance(uint other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000B41A4 File Offset: 0x000B23A4
		[CallerCount(0)]
		public unsafe void SetEAccountType(EAccountType other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000B41D8 File Offset: 0x000B23D8
		[CallerCount(0)]
		public unsafe void SetEUniverse(EUniverse other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x000B420C File Offset: 0x000B240C
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountID_t GetAccountID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetAccountID_Public_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000B423C File Offset: 0x000B243C
		[CallerCount(0)]
		public unsafe uint GetUnAccountInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetUnAccountInstance_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x000B426C File Offset: 0x000B246C
		[CallerCount(0)]
		public unsafe EAccountType GetEAccountType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetEAccountType_Public_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x000B429C File Offset: 0x000B249C
		[CallerCount(0)]
		public unsafe EUniverse GetEUniverse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetEUniverse_Public_EUniverse_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x000B42CC File Offset: 0x000B24CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210638, XrefRangeEnd = 210641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x000B42FC File Offset: 0x000B24FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000B4328 File Offset: 0x000B2528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210641, XrefRangeEnd = 210646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000B436C File Offset: 0x000B256C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000B439C File Offset: 0x000B259C
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CSteamID x, CSteamID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x000B43E8 File Offset: 0x000B25E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210646, XrefRangeEnd = 210649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CSteamID x, CSteamID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000B4434 File Offset: 0x000B2634
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator CSteamID(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000B4474 File Offset: 0x000B2674
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(CSteamID that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000B44B4 File Offset: 0x000B26B4
		[CallerCount(0)]
		public unsafe bool Equals(CSteamID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000B44F4 File Offset: 0x000B26F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(CSteamID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00010CF9 File Offset: 0x0000EEF9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, ref this));
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x000B4534 File Offset: 0x000B2734
		// (set) Token: 0x060029F7 RID: 10743 RVA: 0x00010D0B File Offset: 0x0000EF0B
		public unsafe static CSteamID Nil
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_Nil, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_Nil, (void*)(&value));
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x000B4550 File Offset: 0x000B2750
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x00010D19 File Offset: 0x0000EF19
		public unsafe static CSteamID OutofDateGS
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_OutofDateGS, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_OutofDateGS, (void*)(&value));
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x000B456C File Offset: 0x000B276C
		// (set) Token: 0x060029FB RID: 10747 RVA: 0x00010D27 File Offset: 0x0000EF27
		public unsafe static CSteamID LanModeGS
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_LanModeGS, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_LanModeGS, (void*)(&value));
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x000B4588 File Offset: 0x000B2788
		// (set) Token: 0x060029FD RID: 10749 RVA: 0x00010D35 File Offset: 0x0000EF35
		public unsafe static CSteamID NotInitYetGS
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_NotInitYetGS, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_NotInitYetGS, (void*)(&value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x000B45A4 File Offset: 0x000B27A4
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x00010D43 File Offset: 0x0000EF43
		public unsafe static CSteamID NonSteamGS
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_NonSteamGS, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_NonSteamGS, (void*)(&value));
			}
		}

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeFieldInfoPtr_Nil;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeFieldInfoPtr_OutofDateGS;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeFieldInfoPtr_LanModeGS;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeFieldInfoPtr_NotInitYetGS;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeFieldInfoPtr_NonSteamGS;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_EUniverse_EAccountType_0;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0;

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_AccountID_t_EUniverse_EAccountType_0;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlankAnonLogon_Public_Void_EUniverse_0;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlankAnonUserLogon_Public_Void_EUniverse_0;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeMethodInfoPtr_BBlankAnonAccount_Public_Boolean_0;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeMethodInfoPtr_BGameServerAccount_Public_Boolean_0;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeMethodInfoPtr_BPersistentGameServerAccount_Public_Boolean_0;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeMethodInfoPtr_BAnonGameServerAccount_Public_Boolean_0;

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeMethodInfoPtr_BContentServerAccount_Public_Boolean_0;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeMethodInfoPtr_BClanAccount_Public_Boolean_0;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeMethodInfoPtr_BChatAccount_Public_Boolean_0;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeMethodInfoPtr_IsLobby_Public_Boolean_0;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeMethodInfoPtr_BIndividualAccount_Public_Boolean_0;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeMethodInfoPtr_BAnonAccount_Public_Boolean_0;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeMethodInfoPtr_BAnonUserAccount_Public_Boolean_0;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeMethodInfoPtr_BConsoleUserAccount_Public_Boolean_0;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0;

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0;

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountID_Public_AccountID_t_0;

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeMethodInfoPtr_GetUnAccountInstance_Public_UInt32_0;

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeMethodInfoPtr_GetEAccountType_Public_EAccountType_0;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeMethodInfoPtr_GetEUniverse_Public_EUniverse_0;

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CSteamID_0;

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0;

		// Token: 0x04002876 RID: 10358
		[FieldOffset(0)]
		public ulong m_SteamID;
	}
}
