using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020002C5 RID: 709
	public class ISteamMatchmakingRulesResponse : Object
	{
		// Token: 0x06002898 RID: 10392 RVA: 0x000AFD68 File Offset: 0x000ADF68
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingRulesResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamMatchmakingRulesResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr);
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_VTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_VTable");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_pVTable");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_pGCHandle");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_RulesResponded");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_RulesFailedToRespond");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_RulesRefreshComplete");
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__ctor_Public_Void_RulesResponded_RulesFailedToRespond_RulesRefreshComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100668478);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100668479);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesResponded_Private_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100668480);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesFailedToRespond_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100668481);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesRefreshComplete_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100668482);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingRulesResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100668483);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000AFE88 File Offset: 0x000AE088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209701, XrefRangeEnd = 209742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingRulesResponse(ISteamMatchmakingRulesResponse.RulesResponded onRulesResponded, ISteamMatchmakingRulesResponse.RulesFailedToRespond onRulesFailedToRespond, ISteamMatchmakingRulesResponse.RulesRefreshComplete onRulesRefreshComplete)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onRulesResponded);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRulesFailedToRespond);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRulesRefreshComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__ctor_Public_Void_RulesResponded_RulesFailedToRespond_RulesRefreshComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000AFEF8 File Offset: 0x000AE0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209742, XrefRangeEnd = 209753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000AFF34 File Offset: 0x000AE134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209753, XrefRangeEnd = 209757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchRule;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesResponded_Private_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x000AFF90 File Offset: 0x000AE190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesFailedToRespond_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000AFFD0 File Offset: 0x000AE1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesRefreshComplete_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x000B0010 File Offset: 0x000AE210
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209480, RefRangeEnd = 209489, XrefRangeStart = 209480, XrefRangeEnd = 209489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingRulesResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x000106E8 File Offset: 0x0000E8E8
		public ISteamMatchmakingRulesResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000B0054 File Offset: 0x000AE254
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x000106F1 File Offset: 0x0000E8F1
		public unsafe ISteamMatchmakingRulesResponse.VTable m_VTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_VTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.VTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_VTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000B0084 File Offset: 0x000AE284
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x00010710 File Offset: 0x0000E910
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000B00AC File Offset: 0x000AE2AC
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0001072B File Offset: 0x0000E92B
		public unsafe GCHandle m_pGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pGCHandle)) = value;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000B00D4 File Offset: 0x000AE2D4
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x00010746 File Offset: 0x0000E946
		public unsafe ISteamMatchmakingRulesResponse.RulesResponded m_RulesResponded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesResponded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.RulesResponded>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000B0104 File Offset: 0x000AE304
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x00010765 File Offset: 0x0000E965
		public unsafe ISteamMatchmakingRulesResponse.RulesFailedToRespond m_RulesFailedToRespond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesFailedToRespond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.RulesFailedToRespond>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x000B0134 File Offset: 0x000AE334
		// (set) Token: 0x060028AB RID: 10411 RVA: 0x00010784 File Offset: 0x0000E984
		public unsafe ISteamMatchmakingRulesResponse.RulesRefreshComplete m_RulesRefreshComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesRefreshComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.RulesRefreshComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002772 RID: 10098
		private static readonly IntPtr NativeFieldInfoPtr_m_VTable;

		// Token: 0x04002773 RID: 10099
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x04002774 RID: 10100
		private static readonly IntPtr NativeFieldInfoPtr_m_pGCHandle;

		// Token: 0x04002775 RID: 10101
		private static readonly IntPtr NativeFieldInfoPtr_m_RulesResponded;

		// Token: 0x04002776 RID: 10102
		private static readonly IntPtr NativeFieldInfoPtr_m_RulesFailedToRespond;

		// Token: 0x04002777 RID: 10103
		private static readonly IntPtr NativeFieldInfoPtr_m_RulesRefreshComplete;

		// Token: 0x04002778 RID: 10104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RulesResponded_RulesFailedToRespond_RulesRefreshComplete_0;

		// Token: 0x04002779 RID: 10105
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400277A RID: 10106
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnRulesResponded_Private_Void_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400277B RID: 10107
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnRulesFailedToRespond_Private_Void_IntPtr_0;

		// Token: 0x0400277C RID: 10108
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnRulesRefreshComplete_Private_Void_IntPtr_0;

		// Token: 0x0400277D RID: 10109
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingRulesResponse_0;

		// Token: 0x020003BE RID: 958
		public sealed class RulesResponded : MulticastDelegate
		{
			// Token: 0x060037FC RID: 14332 RVA: 0x000E4504 File Offset: 0x000E2704
			// Note: this type is marked as 'beforefieldinit'.
			static RulesResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "RulesResponded");
				ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr, 100670391);
				ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr, 100670392);
				ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr, 100670393);
				ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr, 100670394);
			}

			// Token: 0x060037FD RID: 14333 RVA: 0x000E4578 File Offset: 0x000E2778
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RulesResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037FE RID: 14334 RVA: 0x000E45D4 File Offset: 0x000E27D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 209684, RefRangeEnd = 209685, XrefRangeStart = 209666, XrefRangeEnd = 209684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string pchRule, string pchValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pchRule);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037FF RID: 14335 RVA: 0x000E4628 File Offset: 0x000E2828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string pchRule, string pchValue, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pchRule);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003800 RID: 14336 RVA: 0x000E46B0 File Offset: 0x000E28B0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003801 RID: 14337 RVA: 0x00015AD9 File Offset: 0x00013CD9
			public RulesResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003802 RID: 14338 RVA: 0x00015AE2 File Offset: 0x00013CE2
			public static implicit operator ISteamMatchmakingRulesResponse.RulesResponded(Action<string, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.RulesResponded>(A_0);
			}

			// Token: 0x06003803 RID: 14339 RVA: 0x00015AEA File Offset: 0x00013CEA
			public static ISteamMatchmakingRulesResponse.RulesResponded operator +(ISteamMatchmakingRulesResponse.RulesResponded A_0, ISteamMatchmakingRulesResponse.RulesResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.RulesResponded>();
			}

			// Token: 0x06003804 RID: 14340 RVA: 0x00015AF8 File Offset: 0x00013CF8
			public static ISteamMatchmakingRulesResponse.RulesResponded operator -(ISteamMatchmakingRulesResponse.RulesResponded A_0, ISteamMatchmakingRulesResponse.RulesResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.RulesResponded>();
				}
				return delegate2;
			}

			// Token: 0x0400329D RID: 12957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400329E RID: 12958
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0;

			// Token: 0x0400329F RID: 12959
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0;

			// Token: 0x040032A0 RID: 12960
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003BF RID: 959
		public sealed class RulesFailedToRespond : MulticastDelegate
		{
			// Token: 0x06003805 RID: 14341 RVA: 0x000E46F4 File Offset: 0x000E28F4
			// Note: this type is marked as 'beforefieldinit'.
			static RulesFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "RulesFailedToRespond");
				ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr, 100670395);
				ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr, 100670396);
				ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr, 100670397);
				ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr, 100670398);
			}

			// Token: 0x06003806 RID: 14342 RVA: 0x000E4768 File Offset: 0x000E2968
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RulesFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003807 RID: 14343 RVA: 0x000E47C4 File Offset: 0x000E29C4
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003808 RID: 14344 RVA: 0x000E47F8 File Offset: 0x000E29F8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003809 RID: 14345 RVA: 0x000E485C File Offset: 0x000E2A5C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600380A RID: 14346 RVA: 0x00015B09 File Offset: 0x00013D09
			public RulesFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600380B RID: 14347 RVA: 0x00015B12 File Offset: 0x00013D12
			public static implicit operator ISteamMatchmakingRulesResponse.RulesFailedToRespond(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.RulesFailedToRespond>(A_0);
			}

			// Token: 0x0600380C RID: 14348 RVA: 0x00015B1A File Offset: 0x00013D1A
			public static ISteamMatchmakingRulesResponse.RulesFailedToRespond operator +(ISteamMatchmakingRulesResponse.RulesFailedToRespond A_0, ISteamMatchmakingRulesResponse.RulesFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.RulesFailedToRespond>();
			}

			// Token: 0x0600380D RID: 14349 RVA: 0x00015B28 File Offset: 0x00013D28
			public static ISteamMatchmakingRulesResponse.RulesFailedToRespond operator -(ISteamMatchmakingRulesResponse.RulesFailedToRespond A_0, ISteamMatchmakingRulesResponse.RulesFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.RulesFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x040032A1 RID: 12961
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040032A2 RID: 12962
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x040032A3 RID: 12963
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x040032A4 RID: 12964
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C0 RID: 960
		public sealed class RulesRefreshComplete : MulticastDelegate
		{
			// Token: 0x0600380E RID: 14350 RVA: 0x000E48A0 File Offset: 0x000E2AA0
			// Note: this type is marked as 'beforefieldinit'.
			static RulesRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "RulesRefreshComplete");
				ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr, 100670399);
				ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr, 100670400);
				ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr, 100670401);
				ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr, 100670402);
			}

			// Token: 0x0600380F RID: 14351 RVA: 0x000E4914 File Offset: 0x000E2B14
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RulesRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003810 RID: 14352 RVA: 0x000E4970 File Offset: 0x000E2B70
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003811 RID: 14353 RVA: 0x000E49A4 File Offset: 0x000E2BA4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003812 RID: 14354 RVA: 0x000E4A08 File Offset: 0x000E2C08
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003813 RID: 14355 RVA: 0x00015B39 File Offset: 0x00013D39
			public RulesRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003814 RID: 14356 RVA: 0x00015B42 File Offset: 0x00013D42
			public static implicit operator ISteamMatchmakingRulesResponse.RulesRefreshComplete(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.RulesRefreshComplete>(A_0);
			}

			// Token: 0x06003815 RID: 14357 RVA: 0x00015B4A File Offset: 0x00013D4A
			public static ISteamMatchmakingRulesResponse.RulesRefreshComplete operator +(ISteamMatchmakingRulesResponse.RulesRefreshComplete A_0, ISteamMatchmakingRulesResponse.RulesRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.RulesRefreshComplete>();
			}

			// Token: 0x06003816 RID: 14358 RVA: 0x00015B58 File Offset: 0x00013D58
			public static ISteamMatchmakingRulesResponse.RulesRefreshComplete operator -(ISteamMatchmakingRulesResponse.RulesRefreshComplete A_0, ISteamMatchmakingRulesResponse.RulesRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.RulesRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x040032A5 RID: 12965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040032A6 RID: 12966
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x040032A7 RID: 12967
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x040032A8 RID: 12968
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C1 RID: 961
		public sealed class InternalRulesResponded : MulticastDelegate
		{
			// Token: 0x06003817 RID: 14359 RVA: 0x000E4A4C File Offset: 0x000E2C4C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalRulesResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "InternalRulesResponded");
				ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr, 100670403);
				ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr, 100670404);
				ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr, 100670405);
				ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr, 100670406);
			}

			// Token: 0x06003818 RID: 14360 RVA: 0x000E4AC0 File Offset: 0x000E2CC0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalRulesResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003819 RID: 14361 RVA: 0x000E4B1C File Offset: 0x000E2D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchRule;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600381A RID: 14362 RVA: 0x000E4B78 File Offset: 0x000E2D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209685, XrefRangeEnd = 209693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchRule;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValue;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600381B RID: 14363 RVA: 0x000E4C08 File Offset: 0x000E2E08
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600381C RID: 14364 RVA: 0x00015B69 File Offset: 0x00013D69
			public InternalRulesResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600381D RID: 14365 RVA: 0x00015B72 File Offset: 0x00013D72
			public static implicit operator ISteamMatchmakingRulesResponse.InternalRulesResponded(Action<IntPtr, IntPtr, IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.InternalRulesResponded>(A_0);
			}

			// Token: 0x0600381E RID: 14366 RVA: 0x00015B7A File Offset: 0x00013D7A
			public static ISteamMatchmakingRulesResponse.InternalRulesResponded operator +(ISteamMatchmakingRulesResponse.InternalRulesResponded A_0, ISteamMatchmakingRulesResponse.InternalRulesResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.InternalRulesResponded>();
			}

			// Token: 0x0600381F RID: 14367 RVA: 0x00015B88 File Offset: 0x00013D88
			public static ISteamMatchmakingRulesResponse.InternalRulesResponded operator -(ISteamMatchmakingRulesResponse.InternalRulesResponded A_0, ISteamMatchmakingRulesResponse.InternalRulesResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.InternalRulesResponded>();
				}
				return delegate2;
			}

			// Token: 0x040032A9 RID: 12969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040032AA RID: 12970
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0;

			// Token: 0x040032AB RID: 12971
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0;

			// Token: 0x040032AC RID: 12972
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C2 RID: 962
		public sealed class InternalRulesFailedToRespond : MulticastDelegate
		{
			// Token: 0x06003820 RID: 14368 RVA: 0x000E4C4C File Offset: 0x000E2E4C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalRulesFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "InternalRulesFailedToRespond");
				ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr, 100670407);
				ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr, 100670408);
				ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr, 100670409);
				ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr, 100670410);
			}

			// Token: 0x06003821 RID: 14369 RVA: 0x000E4CC0 File Offset: 0x000E2EC0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalRulesFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003822 RID: 14370 RVA: 0x000E4D1C File Offset: 0x000E2F1C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003823 RID: 14371 RVA: 0x000E4D5C File Offset: 0x000E2F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209693, XrefRangeEnd = 209697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003824 RID: 14372 RVA: 0x000E4DCC File Offset: 0x000E2FCC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003825 RID: 14373 RVA: 0x00015B99 File Offset: 0x00013D99
			public InternalRulesFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003826 RID: 14374 RVA: 0x00015BA2 File Offset: 0x00013DA2
			public static implicit operator ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>(A_0);
			}

			// Token: 0x06003827 RID: 14375 RVA: 0x00015BAA File Offset: 0x00013DAA
			public static ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond operator +(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond A_0, ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>();
			}

			// Token: 0x06003828 RID: 14376 RVA: 0x00015BB8 File Offset: 0x00013DB8
			public static ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond operator -(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond A_0, ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x040032AD RID: 12973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040032AE RID: 12974
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x040032AF RID: 12975
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x040032B0 RID: 12976
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C3 RID: 963
		public sealed class InternalRulesRefreshComplete : MulticastDelegate
		{
			// Token: 0x06003829 RID: 14377 RVA: 0x000E4E10 File Offset: 0x000E3010
			// Note: this type is marked as 'beforefieldinit'.
			static InternalRulesRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "InternalRulesRefreshComplete");
				ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr, 100670411);
				ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr, 100670412);
				ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr, 100670413);
				ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr, 100670414);
			}

			// Token: 0x0600382A RID: 14378 RVA: 0x000E4E84 File Offset: 0x000E3084
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalRulesRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600382B RID: 14379 RVA: 0x000E4EE0 File Offset: 0x000E30E0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600382C RID: 14380 RVA: 0x000E4F20 File Offset: 0x000E3120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209697, XrefRangeEnd = 209701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600382D RID: 14381 RVA: 0x000E4F90 File Offset: 0x000E3190
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600382E RID: 14382 RVA: 0x00015BC9 File Offset: 0x00013DC9
			public InternalRulesRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600382F RID: 14383 RVA: 0x00015BD2 File Offset: 0x00013DD2
			public static implicit operator ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>(A_0);
			}

			// Token: 0x06003830 RID: 14384 RVA: 0x00015BDA File Offset: 0x00013DDA
			public static ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete operator +(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete A_0, ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>();
			}

			// Token: 0x06003831 RID: 14385 RVA: 0x00015BE8 File Offset: 0x00013DE8
			public static ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete operator -(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete A_0, ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x040032B1 RID: 12977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040032B2 RID: 12978
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x040032B3 RID: 12979
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x040032B4 RID: 12980
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C4 RID: 964
		public class VTable : Object
		{
			// Token: 0x06003832 RID: 14386 RVA: 0x000E4FD4 File Offset: 0x000E31D4
			// Note: this type is marked as 'beforefieldinit'.
			static VTable()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "VTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr);
				ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr, "m_VTRulesResponded");
				ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr, "m_VTRulesFailedToRespond");
				ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr, "m_VTRulesRefreshComplete");
				ISteamMatchmakingRulesResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr, 100670415);
			}

			// Token: 0x06003833 RID: 14387 RVA: 0x000E5050 File Offset: 0x000E3250
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003834 RID: 14388 RVA: 0x00015BF9 File Offset: 0x00013DF9
			public VTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D44 RID: 3396
			// (get) Token: 0x06003835 RID: 14389 RVA: 0x000E508C File Offset: 0x000E328C
			// (set) Token: 0x06003836 RID: 14390 RVA: 0x00015C02 File Offset: 0x00013E02
			public unsafe ISteamMatchmakingRulesResponse.InternalRulesResponded m_VTRulesResponded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesResponded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.InternalRulesResponded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D45 RID: 3397
			// (get) Token: 0x06003837 RID: 14391 RVA: 0x000E50BC File Offset: 0x000E32BC
			// (set) Token: 0x06003838 RID: 14392 RVA: 0x00015C21 File Offset: 0x00013E21
			public unsafe ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond m_VTRulesFailedToRespond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesFailedToRespond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D46 RID: 3398
			// (get) Token: 0x06003839 RID: 14393 RVA: 0x000E50EC File Offset: 0x000E32EC
			// (set) Token: 0x0600383A RID: 14394 RVA: 0x00015C40 File Offset: 0x00013E40
			public unsafe ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete m_VTRulesRefreshComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesRefreshComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032B5 RID: 12981
			private static readonly IntPtr NativeFieldInfoPtr_m_VTRulesResponded;

			// Token: 0x040032B6 RID: 12982
			private static readonly IntPtr NativeFieldInfoPtr_m_VTRulesFailedToRespond;

			// Token: 0x040032B7 RID: 12983
			private static readonly IntPtr NativeFieldInfoPtr_m_VTRulesRefreshComplete;

			// Token: 0x040032B8 RID: 12984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
