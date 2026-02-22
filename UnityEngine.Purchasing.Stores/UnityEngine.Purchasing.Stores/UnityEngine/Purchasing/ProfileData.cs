using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006E RID: 110
	public class ProfileData : Object
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x000128A8 File Offset: 0x00010AA8
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileData()
		{
			Il2CppClassPointerStore<ProfileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ProfileData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileData>.NativeClassPtr);
			ProfileData.NativeFieldInfoPtr_m_Util = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "m_Util");
			ProfileData.NativeFieldInfoPtr_ProfileInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "ProfileInstance");
			ProfileData.NativeFieldInfoPtr__AppId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<AppId>k__BackingField");
			ProfileData.NativeFieldInfoPtr__UserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<UserId>k__BackingField");
			ProfileData.NativeFieldInfoPtr__SessionId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<SessionId>k__BackingField");
			ProfileData.NativeFieldInfoPtr__Platform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<Platform>k__BackingField");
			ProfileData.NativeFieldInfoPtr__PlatformId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<PlatformId>k__BackingField");
			ProfileData.NativeFieldInfoPtr__SdkVer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<SdkVer>k__BackingField");
			ProfileData.NativeFieldInfoPtr__OsVer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<OsVer>k__BackingField");
			ProfileData.NativeFieldInfoPtr__ScreenWidth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<ScreenWidth>k__BackingField");
			ProfileData.NativeFieldInfoPtr__ScreenHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<ScreenHeight>k__BackingField");
			ProfileData.NativeFieldInfoPtr__ScreenDpi_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<ScreenDpi>k__BackingField");
			ProfileData.NativeFieldInfoPtr__ScreenOrientation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<ScreenOrientation>k__BackingField");
			ProfileData.NativeFieldInfoPtr__DeviceId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<DeviceId>k__BackingField");
			ProfileData.NativeFieldInfoPtr__BuildGUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<BuildGUID>k__BackingField");
			ProfileData.NativeFieldInfoPtr__IapVer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<IapVer>k__BackingField");
			ProfileData.NativeFieldInfoPtr__AdsGamerToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<AdsGamerToken>k__BackingField");
			ProfileData.NativeFieldInfoPtr__TrackingOptOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<TrackingOptOut>k__BackingField");
			ProfileData.NativeFieldInfoPtr__AdsABGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<AdsABGroup>k__BackingField");
			ProfileData.NativeFieldInfoPtr__AdsGameId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<AdsGameId>k__BackingField");
			ProfileData.NativeFieldInfoPtr__StoreABGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<StoreABGroup>k__BackingField");
			ProfileData.NativeFieldInfoPtr__CatalogId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<CatalogId>k__BackingField");
			ProfileData.NativeFieldInfoPtr__StoreName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<StoreName>k__BackingField");
			ProfileData.NativeFieldInfoPtr__GameVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<GameVersion>k__BackingField");
			ProfileData.NativeFieldInfoPtr__StoreTestEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "<StoreTestEnabled>k__BackingField");
			ProfileData.NativeMethodInfoPtr_get_AppId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663770);
			ProfileData.NativeMethodInfoPtr_set_AppId_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663771);
			ProfileData.NativeMethodInfoPtr_get_UserId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663772);
			ProfileData.NativeMethodInfoPtr_set_UserId_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663773);
			ProfileData.NativeMethodInfoPtr_get_SessionId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663774);
			ProfileData.NativeMethodInfoPtr_set_SessionId_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663775);
			ProfileData.NativeMethodInfoPtr_get_Platform_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663776);
			ProfileData.NativeMethodInfoPtr_set_Platform_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663777);
			ProfileData.NativeMethodInfoPtr_get_PlatformId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663778);
			ProfileData.NativeMethodInfoPtr_set_PlatformId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663779);
			ProfileData.NativeMethodInfoPtr_get_SdkVer_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663780);
			ProfileData.NativeMethodInfoPtr_set_SdkVer_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663781);
			ProfileData.NativeMethodInfoPtr_get_OsVer_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663782);
			ProfileData.NativeMethodInfoPtr_set_OsVer_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663783);
			ProfileData.NativeMethodInfoPtr_get_ScreenWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663784);
			ProfileData.NativeMethodInfoPtr_set_ScreenWidth_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663785);
			ProfileData.NativeMethodInfoPtr_get_ScreenHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663786);
			ProfileData.NativeMethodInfoPtr_set_ScreenHeight_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663787);
			ProfileData.NativeMethodInfoPtr_get_ScreenDpi_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663788);
			ProfileData.NativeMethodInfoPtr_set_ScreenDpi_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663789);
			ProfileData.NativeMethodInfoPtr_get_ScreenOrientation_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663790);
			ProfileData.NativeMethodInfoPtr_set_ScreenOrientation_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663791);
			ProfileData.NativeMethodInfoPtr_get_DeviceId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663792);
			ProfileData.NativeMethodInfoPtr_set_DeviceId_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663793);
			ProfileData.NativeMethodInfoPtr_get_BuildGUID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663794);
			ProfileData.NativeMethodInfoPtr_get_IapVer_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663795);
			ProfileData.NativeMethodInfoPtr_set_IapVer_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663796);
			ProfileData.NativeMethodInfoPtr_get_AdsGamerToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663797);
			ProfileData.NativeMethodInfoPtr_set_AdsGamerToken_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663798);
			ProfileData.NativeMethodInfoPtr_get_TrackingOptOut_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663799);
			ProfileData.NativeMethodInfoPtr_set_TrackingOptOut_Internal_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663800);
			ProfileData.NativeMethodInfoPtr_get_AdsABGroup_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663801);
			ProfileData.NativeMethodInfoPtr_set_AdsABGroup_Internal_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663802);
			ProfileData.NativeMethodInfoPtr_get_AdsGameId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663803);
			ProfileData.NativeMethodInfoPtr_set_AdsGameId_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663804);
			ProfileData.NativeMethodInfoPtr_get_StoreABGroup_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663805);
			ProfileData.NativeMethodInfoPtr_get_CatalogId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663806);
			ProfileData.NativeMethodInfoPtr_get_StoreName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663807);
			ProfileData.NativeMethodInfoPtr_set_StoreName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663808);
			ProfileData.NativeMethodInfoPtr_get_GameVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663809);
			ProfileData.NativeMethodInfoPtr_set_GameVersion_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663810);
			ProfileData.NativeMethodInfoPtr_get_StoreTestEnabled_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663811);
			ProfileData.NativeMethodInfoPtr__ctor_Private_Void_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663812);
			ProfileData.NativeMethodInfoPtr_GetProfileDict_Internal_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663813);
			ProfileData.NativeMethodInfoPtr_GetProfileIds_Internal_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663814);
			ProfileData.NativeMethodInfoPtr_Instance_Internal_Static_ProfileData_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663815);
			ProfileData.NativeMethodInfoPtr_SetGamerToken_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663816);
			ProfileData.NativeMethodInfoPtr_SetTrackingOptOut_Internal_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663817);
			ProfileData.NativeMethodInfoPtr_SetGameId_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663818);
			ProfileData.NativeMethodInfoPtr_SetABGroup_Internal_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663819);
			ProfileData.NativeMethodInfoPtr_SetStoreName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100663820);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00012EC8 File Offset: 0x000110C8
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00012F00 File Offset: 0x00011100
		public unsafe string AppId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_AppId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_AppId_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00012F44 File Offset: 0x00011144
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00012F7C File Offset: 0x0001117C
		public unsafe string UserId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_UserId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_UserId_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00012FC0 File Offset: 0x000111C0
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00012FFC File Offset: 0x000111FC
		public unsafe ulong SessionId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_SessionId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_SessionId_Internal_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001303C File Offset: 0x0001123C
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00013074 File Offset: 0x00011274
		public unsafe string Platform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_Platform_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_Platform_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x000130B8 File Offset: 0x000112B8
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x000130F4 File Offset: 0x000112F4
		public unsafe int PlatformId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_PlatformId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_PlatformId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00013134 File Offset: 0x00011334
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0001316C File Offset: 0x0001136C
		public unsafe string SdkVer
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_SdkVer_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_SdkVer_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x000131B0 File Offset: 0x000113B0
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x000131E8 File Offset: 0x000113E8
		public unsafe string OsVer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_OsVer_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_OsVer_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0001322C File Offset: 0x0001142C
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00013268 File Offset: 0x00011468
		public unsafe int ScreenWidth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 11932, RefRangeEnd = 11934, XrefRangeStart = 11932, XrefRangeEnd = 11934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_ScreenWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_ScreenWidth_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000132A8 File Offset: 0x000114A8
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000132E4 File Offset: 0x000114E4
		public unsafe int ScreenHeight
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 12351, RefRangeEnd = 12355, XrefRangeStart = 12351, XrefRangeEnd = 12355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_ScreenHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_ScreenHeight_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00013324 File Offset: 0x00011524
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00013360 File Offset: 0x00011560
		public unsafe float ScreenDpi
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_ScreenDpi_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88948, RefRangeEnd = 88949, XrefRangeStart = 88948, XrefRangeEnd = 88949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_ScreenDpi_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000133A0 File Offset: 0x000115A0
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000133D8 File Offset: 0x000115D8
		public unsafe string ScreenOrientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_ScreenOrientation_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_ScreenOrientation_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001341C File Offset: 0x0001161C
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00013454 File Offset: 0x00011654
		public unsafe string DeviceId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_DeviceId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_DeviceId_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00013498 File Offset: 0x00011698
		public unsafe string BuildGUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_BuildGUID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000134D0 File Offset: 0x000116D0
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00013508 File Offset: 0x00011708
		public unsafe string IapVer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_IapVer_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_IapVer_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0001354C File Offset: 0x0001174C
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00013584 File Offset: 0x00011784
		public unsafe string AdsGamerToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_AdsGamerToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_AdsGamerToken_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x000135C8 File Offset: 0x000117C8
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00013600 File Offset: 0x00011800
		public unsafe Nullable<bool> TrackingOptOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_TrackingOptOut_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_TrackingOptOut_Internal_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00013648 File Offset: 0x00011848
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00013680 File Offset: 0x00011880
		public unsafe Nullable<int> AdsABGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_AdsABGroup_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_AdsABGroup_Internal_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000136C8 File Offset: 0x000118C8
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00013700 File Offset: 0x00011900
		public unsafe string AdsGameId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_AdsGameId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_AdsGameId_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00013744 File Offset: 0x00011944
		public unsafe Nullable<int> StoreABGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_StoreABGroup_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001377C File Offset: 0x0001197C
		public unsafe string CatalogId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_CatalogId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000137B4 File Offset: 0x000119B4
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x000137EC File Offset: 0x000119EC
		public unsafe string StoreName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_StoreName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_StoreName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00013830 File Offset: 0x00011A30
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00013868 File Offset: 0x00011A68
		public unsafe string GameVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_GameVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_set_GameVersion_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x000138AC File Offset: 0x00011AAC
		public unsafe Nullable<bool> StoreTestEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_get_StoreTestEnabled_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000138E4 File Offset: 0x00011AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155133, RefRangeEnd = 155134, XrefRangeStart = 155097, XrefRangeEnd = 155133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileData(IUtil util)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr__ctor_Private_Void_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00013930 File Offset: 0x00011B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155274, RefRangeEnd = 155275, XrefRangeStart = 155134, XrefRangeEnd = 155274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, Object> GetProfileDict()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_GetProfileDict_Internal_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00013970 File Offset: 0x00011B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155275, XrefRangeEnd = 155298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, Object> GetProfileIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_GetProfileIds_Internal_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000139B0 File Offset: 0x00011BB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 155304, RefRangeEnd = 155309, XrefRangeStart = 155298, XrefRangeEnd = 155304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfileData Instance(IUtil util)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_Instance_Internal_Static_ProfileData_IUtil_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileData>(intPtr3) : null;
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000139F4 File Offset: 0x00011BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155309, XrefRangeEnd = 155310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGamerToken(string gamerToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(gamerToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_SetGamerToken_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00013A38 File Offset: 0x00011C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155310, XrefRangeEnd = 155311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrackingOptOut(Nullable<bool> trackingOptOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(trackingOptOut));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_SetTrackingOptOut_Internal_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00013A80 File Offset: 0x00011C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155311, XrefRangeEnd = 155312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameId(string gameid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(gameid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_SetGameId_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00013AC4 File Offset: 0x00011CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155312, XrefRangeEnd = 155314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetABGroup(Nullable<int> abgroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(abgroup));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_SetABGroup_Internal_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00013B0C File Offset: 0x00011D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155314, XrefRangeEnd = 155315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoreName(string storename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileData.NativeMethodInfoPtr_SetStoreName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00003FB9 File Offset: 0x000021B9
		public ProfileData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00013B50 File Offset: 0x00011D50
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00003FC2 File Offset: 0x000021C2
		public unsafe IUtil m_Util
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr_m_Util);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr_m_Util), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00013B80 File Offset: 0x00011D80
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003FE1 File Offset: 0x000021E1
		public unsafe static ProfileData ProfileInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileData.NativeFieldInfoPtr_ProfileInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileData.NativeFieldInfoPtr_ProfileInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00013BA8 File Offset: 0x00011DA8
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003FF3 File Offset: 0x000021F3
		public unsafe string _AppId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__AppId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__AppId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00013BD0 File Offset: 0x00011DD0
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00004012 File Offset: 0x00002212
		public unsafe string _UserId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__UserId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__UserId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00013BF8 File Offset: 0x00011DF8
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00004031 File Offset: 0x00002231
		public unsafe ulong _SessionId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__SessionId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__SessionId_k__BackingField)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00013C20 File Offset: 0x00011E20
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x0000404C File Offset: 0x0000224C
		public unsafe string _Platform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__Platform_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__Platform_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00013C48 File Offset: 0x00011E48
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x0000406B File Offset: 0x0000226B
		public unsafe int _PlatformId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__PlatformId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__PlatformId_k__BackingField)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00013C70 File Offset: 0x00011E70
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00004086 File Offset: 0x00002286
		public unsafe string _SdkVer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__SdkVer_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__SdkVer_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00013C98 File Offset: 0x00011E98
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000040A5 File Offset: 0x000022A5
		public unsafe string _OsVer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__OsVer_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__OsVer_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00013CC0 File Offset: 0x00011EC0
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x000040C4 File Offset: 0x000022C4
		public unsafe int _ScreenWidth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__ScreenWidth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__ScreenWidth_k__BackingField)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00013CE8 File Offset: 0x00011EE8
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x000040DF File Offset: 0x000022DF
		public unsafe int _ScreenHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__ScreenHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__ScreenHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00013D10 File Offset: 0x00011F10
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x000040FA File Offset: 0x000022FA
		public unsafe float _ScreenDpi_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__ScreenDpi_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__ScreenDpi_k__BackingField)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00013D38 File Offset: 0x00011F38
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00004115 File Offset: 0x00002315
		public unsafe string _ScreenOrientation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__ScreenOrientation_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__ScreenOrientation_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00013D60 File Offset: 0x00011F60
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00004134 File Offset: 0x00002334
		public unsafe string _DeviceId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__DeviceId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__DeviceId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00013D88 File Offset: 0x00011F88
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00004153 File Offset: 0x00002353
		public unsafe string _BuildGUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__BuildGUID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__BuildGUID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00013DB0 File Offset: 0x00011FB0
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00004172 File Offset: 0x00002372
		public unsafe string _IapVer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__IapVer_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__IapVer_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00013DD8 File Offset: 0x00011FD8
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00004191 File Offset: 0x00002391
		public unsafe string _AdsGamerToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__AdsGamerToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__AdsGamerToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00013E00 File Offset: 0x00012000
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x000041B0 File Offset: 0x000023B0
		public Nullable<bool> _TrackingOptOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__TrackingOptOut_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__TrackingOptOut_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00013E30 File Offset: 0x00012030
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x000041DE File Offset: 0x000023DE
		public Nullable<int> _AdsABGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__AdsABGroup_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__AdsABGroup_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00013E60 File Offset: 0x00012060
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0000420C File Offset: 0x0000240C
		public unsafe string _AdsGameId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__AdsGameId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__AdsGameId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00013E88 File Offset: 0x00012088
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0000422B File Offset: 0x0000242B
		public Nullable<int> _StoreABGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__StoreABGroup_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__StoreABGroup_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00013EB8 File Offset: 0x000120B8
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00004259 File Offset: 0x00002459
		public unsafe string _CatalogId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__CatalogId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__CatalogId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00013EE0 File Offset: 0x000120E0
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00004278 File Offset: 0x00002478
		public unsafe string _StoreName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__StoreName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__StoreName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00013F08 File Offset: 0x00012108
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00004297 File Offset: 0x00002497
		public unsafe string _GameVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__GameVersion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__GameVersion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00013F30 File Offset: 0x00012130
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x000042B6 File Offset: 0x000024B6
		public Nullable<bool> _StoreTestEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__StoreTestEnabled_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileData.NativeFieldInfoPtr__StoreTestEnabled_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_m_Util;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_ProfileInstance;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr__AppId_k__BackingField;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr__UserId_k__BackingField;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr__SessionId_k__BackingField;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr__Platform_k__BackingField;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr__PlatformId_k__BackingField;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr__SdkVer_k__BackingField;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr__OsVer_k__BackingField;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr__ScreenWidth_k__BackingField;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr__ScreenHeight_k__BackingField;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr__ScreenDpi_k__BackingField;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr__ScreenOrientation_k__BackingField;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr__DeviceId_k__BackingField;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr__BuildGUID_k__BackingField;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr__IapVer_k__BackingField;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr__AdsGamerToken_k__BackingField;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr__TrackingOptOut_k__BackingField;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr__AdsABGroup_k__BackingField;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr__AdsGameId_k__BackingField;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr__StoreABGroup_k__BackingField;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr__CatalogId_k__BackingField;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr__StoreName_k__BackingField;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr__GameVersion_k__BackingField;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr__StoreTestEnabled_k__BackingField;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_get_String_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_set_AppId_Internal_set_Void_String_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_get_UserId_Public_get_String_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_set_UserId_Internal_set_Void_String_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionId_Public_get_UInt64_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_set_SessionId_Internal_set_Void_UInt64_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Public_get_String_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_set_Platform_Internal_set_Void_String_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformId_Public_get_Int32_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_set_PlatformId_Internal_set_Void_Int32_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_get_SdkVer_Public_get_String_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_set_SdkVer_Internal_set_Void_String_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_get_OsVer_Public_get_String_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_set_OsVer_Internal_set_Void_String_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenWidth_Public_get_Int32_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreenWidth_Internal_set_Void_Int32_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenHeight_Public_get_Int32_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreenHeight_Internal_set_Void_Int32_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenDpi_Public_get_Single_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreenDpi_Internal_set_Void_Single_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenOrientation_Public_get_String_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreenOrientation_Internal_set_Void_String_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceId_Public_get_String_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceId_Internal_set_Void_String_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildGUID_Public_get_String_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_get_IapVer_Public_get_String_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_set_IapVer_Internal_set_Void_String_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_get_AdsGamerToken_Public_get_String_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_set_AdsGamerToken_Internal_set_Void_String_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackingOptOut_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_set_TrackingOptOut_Internal_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_AdsABGroup_Public_get_Nullable_1_Int32_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_set_AdsABGroup_Internal_set_Void_Nullable_1_Int32_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_AdsGameId_Public_get_String_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_set_AdsGameId_Internal_set_Void_String_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_StoreABGroup_Public_get_Nullable_1_Int32_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_CatalogId_Public_get_String_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_StoreName_Public_get_String_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_set_StoreName_Internal_set_Void_String_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_get_GameVersion_Public_get_String_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_set_GameVersion_Internal_set_Void_String_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_get_StoreTestEnabled_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IUtil_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_GetProfileDict_Internal_Dictionary_2_String_Object_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_GetProfileIds_Internal_Dictionary_2_String_Object_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Internal_Static_ProfileData_IUtil_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_SetGamerToken_Internal_Void_String_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_SetTrackingOptOut_Internal_Void_Nullable_1_Boolean_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_SetGameId_Internal_Void_String_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_SetABGroup_Internal_Void_Nullable_1_Int32_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreName_Internal_Void_String_0;
	}
}
