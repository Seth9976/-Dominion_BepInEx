using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D1 RID: 721
	[Serializable]
	[StructLayout(2)]
	public struct CGameID
	{
		// Token: 0x060029B3 RID: 10675 RVA: 0x000B31B0 File Offset: 0x000B13B0
		// Note: this type is marked as 'beforefieldinit'.
		static CGameID()
		{
			Il2CppClassPointerStore<CGameID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CGameID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CGameID>.NativeClassPtr);
			CGameID.NativeFieldInfoPtr_m_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CGameID>.NativeClassPtr, "m_GameID");
			CGameID.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668591);
			CGameID.NativeMethodInfoPtr__ctor_Public_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668592);
			CGameID.NativeMethodInfoPtr__ctor_Public_Void_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668593);
			CGameID.NativeMethodInfoPtr_IsSteamApp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668594);
			CGameID.NativeMethodInfoPtr_IsMod_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668595);
			CGameID.NativeMethodInfoPtr_IsShortcut_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668596);
			CGameID.NativeMethodInfoPtr_IsP2PFile_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668597);
			CGameID.NativeMethodInfoPtr_AppID_Public_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668598);
			CGameID.NativeMethodInfoPtr_Type_Public_EGameIDType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668599);
			CGameID.NativeMethodInfoPtr_ModID_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668600);
			CGameID.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668601);
			CGameID.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668602);
			CGameID.NativeMethodInfoPtr_Set_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668603);
			CGameID.NativeMethodInfoPtr_SetAppID_Private_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668604);
			CGameID.NativeMethodInfoPtr_SetType_Private_Void_EGameIDType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668605);
			CGameID.NativeMethodInfoPtr_SetModID_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668606);
			CGameID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668607);
			CGameID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668608);
			CGameID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668609);
			CGameID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CGameID_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668610);
			CGameID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CGameID_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668611);
			CGameID.NativeMethodInfoPtr_op_Explicit_Public_Static_CGameID_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668612);
			CGameID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668613);
			CGameID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668614);
			CGameID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CGameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGameID>.NativeClassPtr, 100668615);
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000B33E8 File Offset: 0x000B15E8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CGameID(ulong GameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref GameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000B341C File Offset: 0x000B161C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210407, RefRangeEnd = 210408, XrefRangeStart = 210406, XrefRangeEnd = 210407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CGameID(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr__ctor_Public_Void_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000B3450 File Offset: 0x000B1650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210408, XrefRangeEnd = 210409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CGameID(AppId_t nAppID, uint nModID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nModID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr__ctor_Public_Void_AppId_t_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000B3490 File Offset: 0x000B1690
		[CallerCount(0)]
		public unsafe bool IsSteamApp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsSteamApp_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000B34C0 File Offset: 0x000B16C0
		[CallerCount(0)]
		public unsafe bool IsMod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsMod_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000B34F0 File Offset: 0x000B16F0
		[CallerCount(0)]
		public unsafe bool IsShortcut()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsShortcut_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000B3520 File Offset: 0x000B1720
		[CallerCount(0)]
		public unsafe bool IsP2PFile()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsP2PFile_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000B3550 File Offset: 0x000B1750
		[CallerCount(0)]
		public unsafe AppId_t AppID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_AppID_Public_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000B3580 File Offset: 0x000B1780
		[CallerCount(0)]
		public unsafe CGameID.EGameIDType Type()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Type_Public_EGameIDType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000B35B0 File Offset: 0x000B17B0
		[CallerCount(0)]
		public unsafe uint ModID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_ModID_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000B35E0 File Offset: 0x000B17E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210409, XrefRangeEnd = 210413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000B3610 File Offset: 0x000B1810
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Reset_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000B3638 File Offset: 0x000B1838
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(ulong GameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref GameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Set_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000B366C File Offset: 0x000B186C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210416, RefRangeEnd = 210418, XrefRangeStart = 210413, XrefRangeEnd = 210416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppID(AppId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_SetAppID_Private_Void_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000B36A0 File Offset: 0x000B18A0
		[CallerCount(0)]
		public unsafe void SetType(CGameID.EGameIDType other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_SetType_Private_Void_EGameIDType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000B36D4 File Offset: 0x000B18D4
		[CallerCount(0)]
		public unsafe void SetModID(uint other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_SetModID_Private_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000B3708 File Offset: 0x000B1908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210418, XrefRangeEnd = 210421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000B3734 File Offset: 0x000B1934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210421, XrefRangeEnd = 210424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000B3778 File Offset: 0x000B1978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210424, XrefRangeEnd = 210425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000B37A8 File Offset: 0x000B19A8
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CGameID x, CGameID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CGameID_CGameID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000B37F4 File Offset: 0x000B19F4
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CGameID x, CGameID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CGameID_CGameID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000B3840 File Offset: 0x000B1A40
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator CGameID(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_op_Explicit_Public_Static_CGameID_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000B3880 File Offset: 0x000B1A80
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(CGameID that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CGameID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000B38C0 File Offset: 0x000B1AC0
		[CallerCount(0)]
		public unsafe bool Equals(CGameID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CGameID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000B3900 File Offset: 0x000B1B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210634, XrefRangeEnd = 210635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(CGameID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGameID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CGameID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00010CE7 File Offset: 0x0000EEE7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CGameID>.NativeClassPtr, ref this));
		}

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeFieldInfoPtr_m_GameID;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AppId_t_0;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AppId_t_UInt32_0;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamApp_Public_Boolean_0;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeMethodInfoPtr_IsMod_Public_Boolean_0;

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeMethodInfoPtr_IsShortcut_Public_Boolean_0;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeMethodInfoPtr_IsP2PFile_Public_Boolean_0;

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeMethodInfoPtr_AppID_Public_AppId_t_0;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeMethodInfoPtr_Type_Public_EGameIDType_0;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeMethodInfoPtr_ModID_Public_UInt32_0;

		// Token: 0x0400283A RID: 10298
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400283B RID: 10299
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400283C RID: 10300
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_UInt64_0;

		// Token: 0x0400283D RID: 10301
		private static readonly IntPtr NativeMethodInfoPtr_SetAppID_Private_Void_AppId_t_0;

		// Token: 0x0400283E RID: 10302
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Private_Void_EGameIDType_0;

		// Token: 0x0400283F RID: 10303
		private static readonly IntPtr NativeMethodInfoPtr_SetModID_Private_Void_UInt32_0;

		// Token: 0x04002840 RID: 10304
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002841 RID: 10305
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002842 RID: 10306
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002843 RID: 10307
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CGameID_CGameID_0;

		// Token: 0x04002844 RID: 10308
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CGameID_CGameID_0;

		// Token: 0x04002845 RID: 10309
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_CGameID_UInt64_0;

		// Token: 0x04002846 RID: 10310
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CGameID_0;

		// Token: 0x04002847 RID: 10311
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CGameID_0;

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CGameID_0;

		// Token: 0x04002849 RID: 10313
		[FieldOffset(0)]
		public ulong m_GameID;

		// Token: 0x020003C6 RID: 966
		public enum EGameIDType
		{
			// Token: 0x040032C2 RID: 12994
			k_EGameIDTypeApp,
			// Token: 0x040032C3 RID: 12995
			k_EGameIDTypeGameMod,
			// Token: 0x040032C4 RID: 12996
			k_EGameIDTypeShortcut,
			// Token: 0x040032C5 RID: 12997
			k_EGameIDTypeP2P
		}
	}
}
