using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020002C4 RID: 708
	public class ISteamMatchmakingPlayersResponse : Object
	{
		// Token: 0x06002884 RID: 10372 RVA: 0x000AF960 File Offset: 0x000ADB60
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingPlayersResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamMatchmakingPlayersResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr);
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_VTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_VTable");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_pVTable");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_pGCHandle");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_AddPlayerToList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_AddPlayerToList");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_PlayersFailedToRespond");
			ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "m_PlayersRefreshComplete");
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__ctor_Public_Void_AddPlayerToList_PlayersFailedToRespond_PlayersRefreshComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100668472);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100668473);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnAddPlayerToList_Private_Void_IntPtr_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100668474);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnPlayersFailedToRespond_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100668475);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnPlayersRefreshComplete_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100668476);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPlayersResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100668477);
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000AFA80 File Offset: 0x000ADC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209609, XrefRangeEnd = 209650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingPlayersResponse(ISteamMatchmakingPlayersResponse.AddPlayerToList onAddPlayerToList, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond onPlayersFailedToRespond, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete onPlayersRefreshComplete)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onAddPlayerToList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPlayersFailedToRespond);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPlayersRefreshComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__ctor_Public_Void_AddPlayerToList_PlayersFailedToRespond_PlayersRefreshComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000AFAF0 File Offset: 0x000ADCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209650, XrefRangeEnd = 209661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000AFB2C File Offset: 0x000ADD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209661, XrefRangeEnd = 209664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnAddPlayerToList_Private_Void_IntPtr_IntPtr_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000AFB94 File Offset: 0x000ADD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnPlayersFailedToRespond_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000AFBD4 File Offset: 0x000ADDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209664, XrefRangeEnd = 209666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_InternalOnPlayersRefreshComplete_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000AFC14 File Offset: 0x000ADE14
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209480, RefRangeEnd = 209489, XrefRangeStart = 209480, XrefRangeEnd = 209489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPlayersResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0001062D File Offset: 0x0000E82D
		public ISteamMatchmakingPlayersResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x000AFC58 File Offset: 0x000ADE58
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x00010636 File Offset: 0x0000E836
		public unsafe ISteamMatchmakingPlayersResponse.VTable m_VTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_VTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.VTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_VTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x000AFC88 File Offset: 0x000ADE88
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x00010655 File Offset: 0x0000E855
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000AFCB0 File Offset: 0x000ADEB0
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x00010670 File Offset: 0x0000E870
		public unsafe GCHandle m_pGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_pGCHandle)) = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x000AFCD8 File Offset: 0x000ADED8
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x0001068B File Offset: 0x0000E88B
		public unsafe ISteamMatchmakingPlayersResponse.AddPlayerToList m_AddPlayerToList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_AddPlayerToList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.AddPlayerToList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_AddPlayerToList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000AFD08 File Offset: 0x000ADF08
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x000106AA File Offset: 0x0000E8AA
		public unsafe ISteamMatchmakingPlayersResponse.PlayersFailedToRespond m_PlayersFailedToRespond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersFailedToRespond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000AFD38 File Offset: 0x000ADF38
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x000106C9 File Offset: 0x0000E8C9
		public unsafe ISteamMatchmakingPlayersResponse.PlayersRefreshComplete m_PlayersRefreshComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersRefreshComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.NativeFieldInfoPtr_m_PlayersRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002766 RID: 10086
		private static readonly IntPtr NativeFieldInfoPtr_m_VTable;

		// Token: 0x04002767 RID: 10087
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x04002768 RID: 10088
		private static readonly IntPtr NativeFieldInfoPtr_m_pGCHandle;

		// Token: 0x04002769 RID: 10089
		private static readonly IntPtr NativeFieldInfoPtr_m_AddPlayerToList;

		// Token: 0x0400276A RID: 10090
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayersFailedToRespond;

		// Token: 0x0400276B RID: 10091
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayersRefreshComplete;

		// Token: 0x0400276C RID: 10092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddPlayerToList_PlayersFailedToRespond_PlayersRefreshComplete_0;

		// Token: 0x0400276D RID: 10093
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnAddPlayerToList_Private_Void_IntPtr_IntPtr_Int32_Single_0;

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnPlayersFailedToRespond_Private_Void_IntPtr_0;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnPlayersRefreshComplete_Private_Void_IntPtr_0;

		// Token: 0x04002771 RID: 10097
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPlayersResponse_0;

		// Token: 0x020003B7 RID: 951
		public sealed class AddPlayerToList : MulticastDelegate
		{
			// Token: 0x060037BD RID: 14269 RVA: 0x000E38BC File Offset: 0x000E1ABC
			// Note: this type is marked as 'beforefieldinit'.
			static AddPlayerToList()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "AddPlayerToList");
				ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr, 100670366);
				ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr, 100670367);
				ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr, 100670368);
				ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr, 100670369);
			}

			// Token: 0x060037BE RID: 14270 RVA: 0x000E3930 File Offset: 0x000E1B30
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddPlayerToList(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.AddPlayerToList>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037BF RID: 14271 RVA: 0x000E398C File Offset: 0x000E1B8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 209577, RefRangeEnd = 209578, XrefRangeStart = 209558, XrefRangeEnd = 209577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string pchName, int nScore, float flTimePlayed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037C0 RID: 14272 RVA: 0x000E39EC File Offset: 0x000E1BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209578, XrefRangeEnd = 209585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string pchName, int nScore, float flTimePlayed, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060037C1 RID: 14273 RVA: 0x000E3A80 File Offset: 0x000E1C80
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.AddPlayerToList.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037C2 RID: 14274 RVA: 0x00015953 File Offset: 0x00013B53
			public AddPlayerToList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037C3 RID: 14275 RVA: 0x0001595C File Offset: 0x00013B5C
			public static implicit operator ISteamMatchmakingPlayersResponse.AddPlayerToList(Action<string, int, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.AddPlayerToList>(A_0);
			}

			// Token: 0x060037C4 RID: 14276 RVA: 0x00015964 File Offset: 0x00013B64
			public static ISteamMatchmakingPlayersResponse.AddPlayerToList operator +(ISteamMatchmakingPlayersResponse.AddPlayerToList A_0, ISteamMatchmakingPlayersResponse.AddPlayerToList A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.AddPlayerToList>();
			}

			// Token: 0x060037C5 RID: 14277 RVA: 0x00015972 File Offset: 0x00013B72
			public static ISteamMatchmakingPlayersResponse.AddPlayerToList operator -(ISteamMatchmakingPlayersResponse.AddPlayerToList A_0, ISteamMatchmakingPlayersResponse.AddPlayerToList A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.AddPlayerToList>();
				}
				return delegate2;
			}

			// Token: 0x04003281 RID: 12929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003282 RID: 12930
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_Single_0;

			// Token: 0x04003283 RID: 12931
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Single_AsyncCallback_Object_0;

			// Token: 0x04003284 RID: 12932
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B8 RID: 952
		public sealed class PlayersFailedToRespond : MulticastDelegate
		{
			// Token: 0x060037C6 RID: 14278 RVA: 0x000E3AC4 File Offset: 0x000E1CC4
			// Note: this type is marked as 'beforefieldinit'.
			static PlayersFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "PlayersFailedToRespond");
				ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr, 100670370);
				ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr, 100670371);
				ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr, 100670372);
				ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr, 100670373);
			}

			// Token: 0x060037C7 RID: 14279 RVA: 0x000E3B38 File Offset: 0x000E1D38
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayersFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037C8 RID: 14280 RVA: 0x000E3B94 File Offset: 0x000E1D94
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037C9 RID: 14281 RVA: 0x000E3BC8 File Offset: 0x000E1DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060037CA RID: 14282 RVA: 0x000E3C2C File Offset: 0x000E1E2C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037CB RID: 14283 RVA: 0x00015983 File Offset: 0x00013B83
			public PlayersFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037CC RID: 14284 RVA: 0x0001598C File Offset: 0x00013B8C
			public static implicit operator ISteamMatchmakingPlayersResponse.PlayersFailedToRespond(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>(A_0);
			}

			// Token: 0x060037CD RID: 14285 RVA: 0x00015994 File Offset: 0x00013B94
			public static ISteamMatchmakingPlayersResponse.PlayersFailedToRespond operator +(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond A_0, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>();
			}

			// Token: 0x060037CE RID: 14286 RVA: 0x000159A2 File Offset: 0x00013BA2
			public static ISteamMatchmakingPlayersResponse.PlayersFailedToRespond operator -(ISteamMatchmakingPlayersResponse.PlayersFailedToRespond A_0, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.PlayersFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04003285 RID: 12933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003286 RID: 12934
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04003287 RID: 12935
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04003288 RID: 12936
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B9 RID: 953
		public sealed class PlayersRefreshComplete : MulticastDelegate
		{
			// Token: 0x060037CF RID: 14287 RVA: 0x000E3C70 File Offset: 0x000E1E70
			// Note: this type is marked as 'beforefieldinit'.
			static PlayersRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "PlayersRefreshComplete");
				ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr, 100670374);
				ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr, 100670375);
				ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr, 100670376);
				ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr, 100670377);
			}

			// Token: 0x060037D0 RID: 14288 RVA: 0x000E3CE4 File Offset: 0x000E1EE4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayersRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037D1 RID: 14289 RVA: 0x000E3D40 File Offset: 0x000E1F40
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037D2 RID: 14290 RVA: 0x000E3D74 File Offset: 0x000E1F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060037D3 RID: 14291 RVA: 0x000E3DD8 File Offset: 0x000E1FD8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037D4 RID: 14292 RVA: 0x000159B3 File Offset: 0x00013BB3
			public PlayersRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037D5 RID: 14293 RVA: 0x000159BC File Offset: 0x00013BBC
			public static implicit operator ISteamMatchmakingPlayersResponse.PlayersRefreshComplete(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>(A_0);
			}

			// Token: 0x060037D6 RID: 14294 RVA: 0x000159C4 File Offset: 0x00013BC4
			public static ISteamMatchmakingPlayersResponse.PlayersRefreshComplete operator +(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete A_0, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>();
			}

			// Token: 0x060037D7 RID: 14295 RVA: 0x000159D2 File Offset: 0x00013BD2
			public static ISteamMatchmakingPlayersResponse.PlayersRefreshComplete operator -(ISteamMatchmakingPlayersResponse.PlayersRefreshComplete A_0, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.PlayersRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04003289 RID: 12937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400328A RID: 12938
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x0400328B RID: 12939
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400328C RID: 12940
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003BA RID: 954
		public sealed class InternalAddPlayerToList : MulticastDelegate
		{
			// Token: 0x060037D8 RID: 14296 RVA: 0x000E3E1C File Offset: 0x000E201C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalAddPlayerToList()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "InternalAddPlayerToList");
				ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr, 100670378);
				ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr, 100670379);
				ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Int32_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr, 100670380);
				ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr, 100670381);
			}

			// Token: 0x060037D9 RID: 14297 RVA: 0x000E3E90 File Offset: 0x000E2090
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalAddPlayerToList(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037DA RID: 14298 RVA: 0x000E3EEC File Offset: 0x000E20EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209585, XrefRangeEnd = 209589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037DB RID: 14299 RVA: 0x000E3F54 File Offset: 0x000E2154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209589, XrefRangeEnd = 209601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Int32_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060037DC RID: 14300 RVA: 0x000E3FF0 File Offset: 0x000E21F0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037DD RID: 14301 RVA: 0x000159E3 File Offset: 0x00013BE3
			public InternalAddPlayerToList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037DE RID: 14302 RVA: 0x000159EC File Offset: 0x00013BEC
			public static implicit operator ISteamMatchmakingPlayersResponse.InternalAddPlayerToList(Action<IntPtr, IntPtr, int, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>(A_0);
			}

			// Token: 0x060037DF RID: 14303 RVA: 0x000159F4 File Offset: 0x00013BF4
			public static ISteamMatchmakingPlayersResponse.InternalAddPlayerToList operator +(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList A_0, ISteamMatchmakingPlayersResponse.InternalAddPlayerToList A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>();
			}

			// Token: 0x060037E0 RID: 14304 RVA: 0x00015A02 File Offset: 0x00013C02
			public static ISteamMatchmakingPlayersResponse.InternalAddPlayerToList operator -(ISteamMatchmakingPlayersResponse.InternalAddPlayerToList A_0, ISteamMatchmakingPlayersResponse.InternalAddPlayerToList A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>();
				}
				return delegate2;
			}

			// Token: 0x0400328D RID: 12941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400328E RID: 12942
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Int32_Single_0;

			// Token: 0x0400328F RID: 12943
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Int32_Single_AsyncCallback_Object_0;

			// Token: 0x04003290 RID: 12944
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003BB RID: 955
		public sealed class InternalPlayersFailedToRespond : MulticastDelegate
		{
			// Token: 0x060037E1 RID: 14305 RVA: 0x000E4034 File Offset: 0x000E2234
			// Note: this type is marked as 'beforefieldinit'.
			static InternalPlayersFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "InternalPlayersFailedToRespond");
				ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr, 100670382);
				ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr, 100670383);
				ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr, 100670384);
				ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr, 100670385);
			}

			// Token: 0x060037E2 RID: 14306 RVA: 0x000E40A8 File Offset: 0x000E22A8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalPlayersFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037E3 RID: 14307 RVA: 0x000E4104 File Offset: 0x000E2304
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 209501, RefRangeEnd = 209504, XrefRangeStart = 209501, XrefRangeEnd = 209504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037E4 RID: 14308 RVA: 0x000E4144 File Offset: 0x000E2344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209601, XrefRangeEnd = 209605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060037E5 RID: 14309 RVA: 0x000E41B4 File Offset: 0x000E23B4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037E6 RID: 14310 RVA: 0x00015A13 File Offset: 0x00013C13
			public InternalPlayersFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037E7 RID: 14311 RVA: 0x00015A1C File Offset: 0x00013C1C
			public static implicit operator ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>(A_0);
			}

			// Token: 0x060037E8 RID: 14312 RVA: 0x00015A24 File Offset: 0x00013C24
			public static ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond operator +(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond A_0, ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>();
			}

			// Token: 0x060037E9 RID: 14313 RVA: 0x00015A32 File Offset: 0x00013C32
			public static ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond operator -(ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond A_0, ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04003291 RID: 12945
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003292 RID: 12946
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x04003293 RID: 12947
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04003294 RID: 12948
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003BC RID: 956
		public sealed class InternalPlayersRefreshComplete : MulticastDelegate
		{
			// Token: 0x060037EA RID: 14314 RVA: 0x000E41F8 File Offset: 0x000E23F8
			// Note: this type is marked as 'beforefieldinit'.
			static InternalPlayersRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "InternalPlayersRefreshComplete");
				ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr, 100670386);
				ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr, 100670387);
				ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr, 100670388);
				ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr, 100670389);
			}

			// Token: 0x060037EB RID: 14315 RVA: 0x000E426C File Offset: 0x000E246C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalPlayersRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037EC RID: 14316 RVA: 0x000E42C8 File Offset: 0x000E24C8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 209501, RefRangeEnd = 209504, XrefRangeStart = 209501, XrefRangeEnd = 209504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037ED RID: 14317 RVA: 0x000E4308 File Offset: 0x000E2508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209605, XrefRangeEnd = 209609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060037EE RID: 14318 RVA: 0x000E4378 File Offset: 0x000E2578
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037EF RID: 14319 RVA: 0x00015A43 File Offset: 0x00013C43
			public InternalPlayersRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037F0 RID: 14320 RVA: 0x00015A4C File Offset: 0x00013C4C
			public static implicit operator ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>(A_0);
			}

			// Token: 0x060037F1 RID: 14321 RVA: 0x00015A54 File Offset: 0x00013C54
			public static ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete operator +(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete A_0, ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>();
			}

			// Token: 0x060037F2 RID: 14322 RVA: 0x00015A62 File Offset: 0x00013C62
			public static ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete operator -(ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete A_0, ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04003295 RID: 12949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003296 RID: 12950
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x04003297 RID: 12951
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04003298 RID: 12952
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003BD RID: 957
		public class VTable : Object
		{
			// Token: 0x060037F3 RID: 14323 RVA: 0x000E43BC File Offset: 0x000E25BC
			// Note: this type is marked as 'beforefieldinit'.
			static VTable()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, "VTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr);
				ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTAddPlayerToList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr, "m_VTAddPlayerToList");
				ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr, "m_VTPlayersFailedToRespond");
				ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr, "m_VTPlayersRefreshComplete");
				ISteamMatchmakingPlayersResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr, 100670390);
			}

			// Token: 0x060037F4 RID: 14324 RVA: 0x000E4438 File Offset: 0x000E2638
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse.VTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037F5 RID: 14325 RVA: 0x00015A73 File Offset: 0x00013C73
			public VTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D41 RID: 3393
			// (get) Token: 0x060037F6 RID: 14326 RVA: 0x000E4474 File Offset: 0x000E2674
			// (set) Token: 0x060037F7 RID: 14327 RVA: 0x00015A7C File Offset: 0x00013C7C
			public unsafe ISteamMatchmakingPlayersResponse.InternalAddPlayerToList m_VTAddPlayerToList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTAddPlayerToList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.InternalAddPlayerToList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTAddPlayerToList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D42 RID: 3394
			// (get) Token: 0x060037F8 RID: 14328 RVA: 0x000E44A4 File Offset: 0x000E26A4
			// (set) Token: 0x060037F9 RID: 14329 RVA: 0x00015A9B File Offset: 0x00013C9B
			public unsafe ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond m_VTPlayersFailedToRespond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersFailedToRespond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D43 RID: 3395
			// (get) Token: 0x060037FA RID: 14330 RVA: 0x000E44D4 File Offset: 0x000E26D4
			// (set) Token: 0x060037FB RID: 14331 RVA: 0x00015ABA File Offset: 0x00013CBA
			public unsafe ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete m_VTPlayersRefreshComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersRefreshComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPlayersResponse.VTable.NativeFieldInfoPtr_m_VTPlayersRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003299 RID: 12953
			private static readonly IntPtr NativeFieldInfoPtr_m_VTAddPlayerToList;

			// Token: 0x0400329A RID: 12954
			private static readonly IntPtr NativeFieldInfoPtr_m_VTPlayersFailedToRespond;

			// Token: 0x0400329B RID: 12955
			private static readonly IntPtr NativeFieldInfoPtr_m_VTPlayersRefreshComplete;

			// Token: 0x0400329C RID: 12956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
