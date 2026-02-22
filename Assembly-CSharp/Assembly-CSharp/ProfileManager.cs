using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000A7 RID: 167
public class ProfileManager : MonoBehaviour
{
	// Token: 0x06001378 RID: 4984 RVA: 0x0005490C File Offset: 0x00052B0C
	// Note: this type is marked as 'beforefieldinit'.
	static ProfileManager()
	{
		Il2CppClassPointerStore<ProfileManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ProfileManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr);
		ProfileManager.NativeFieldInfoPtr_OFFLINEPROFILE_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "OFFLINEPROFILE_VERSION");
		ProfileManager.NativeFieldInfoPtr_OfflineProfileFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "OfflineProfileFilename");
		ProfileManager.NativeFieldInfoPtr_OFFLINEPROFILE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "OFFLINEPROFILE_ID");
		ProfileManager.NativeFieldInfoPtr_m_profileEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "m_profileEntries");
		ProfileManager.NativeFieldInfoPtr_m_CurrentProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "m_CurrentProfile");
		ProfileManager.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "_instance");
		ProfileManager.NativeMethodInfoPtr_get_instance_Public_Static_get_ProfileManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664822);
		ProfileManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664823);
		ProfileManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664824);
		ProfileManager.NativeMethodInfoPtr_HashString_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664825);
		ProfileManager.NativeMethodInfoPtr_GetProfileListHash_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664826);
		ProfileManager.NativeMethodInfoPtr_Initialize_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664827);
		ProfileManager.NativeMethodInfoPtr_CreateDefaultProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664828);
		ProfileManager.NativeMethodInfoPtr_InitializeHeader_Private_Void_byref_OfflineProfileHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664829);
		ProfileManager.NativeMethodInfoPtr_CheckFileVersion_Private_Boolean_OfflineProfileHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664830);
		ProfileManager.NativeMethodInfoPtr_CheckValidProfileHeader_Private_Boolean_OfflineProfileHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664831);
		ProfileManager.NativeMethodInfoPtr_InitializeNewEntry_Public_Void_byref_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664832);
		ProfileManager.NativeMethodInfoPtr_ResetStats_Public_Void_byref_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664833);
		ProfileManager.NativeMethodInfoPtr_Save_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664834);
		ProfileManager.NativeMethodInfoPtr_Load_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664835);
		ProfileManager.NativeMethodInfoPtr_Count_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664836);
		ProfileManager.NativeMethodInfoPtr_GetIndex_Public_Int32_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664837);
		ProfileManager.NativeMethodInfoPtr_Get_Public_OfflineProfileEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664838);
		ProfileManager.NativeMethodInfoPtr_GetProfile_Public_OfflineProfileEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664839);
		ProfileManager.NativeMethodInfoPtr_StringifyID_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664840);
		ProfileManager.NativeMethodInfoPtr_CheckIfProfileExistWithDisplayName_Public_OfflineProfileEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664841);
		ProfileManager.NativeMethodInfoPtr_GetProfilesWithDisplayNameH_Public_Int32_Int32_byref_List_1_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664842);
		ProfileManager.NativeMethodInfoPtr_GetName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664843);
		ProfileManager.NativeMethodInfoPtr_GetDisplayName_Public_String_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664844);
		ProfileManager.NativeMethodInfoPtr_UpdateProfileName_Public_Void_byref_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664845);
		ProfileManager.NativeMethodInfoPtr_Delete_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664846);
		ProfileManager.NativeMethodInfoPtr_Delete_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664847);
		ProfileManager.NativeMethodInfoPtr_Delete_Public_Boolean_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664848);
		ProfileManager.NativeMethodInfoPtr_Create_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664849);
		ProfileManager.NativeMethodInfoPtr_Add_Public_Int32_OfflineProfileEntry_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664850);
		ProfileManager.NativeMethodInfoPtr_GenerateNameHash_Private_Void_byref_MyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664851);
		ProfileManager.NativeMethodInfoPtr_GetCurrentProfile_Public_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664852);
		ProfileManager.NativeMethodInfoPtr_GetCurrentProfileRef_Public_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664853);
		ProfileManager.NativeMethodInfoPtr_SetCurrentProfile_Public_Void_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664854);
		ProfileManager.NativeMethodInfoPtr_CheckDeleteProfile_Public_Boolean_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664855);
		ProfileManager.NativeMethodInfoPtr_GetGamePlayerNameHash_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664856);
		ProfileManager.NativeMethodInfoPtr_GetProfileSaveDirectory_Public_String_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664857);
		ProfileManager.NativeMethodInfoPtr_PrintProfileEntry_Private_Void_OfflineProfileEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664858);
		ProfileManager.NativeMethodInfoPtr_PrintProfile_Private_Void_MyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664859);
		ProfileManager.NativeMethodInfoPtr_PrintAllProfiles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664860);
		ProfileManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100664861);
	}

	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x06001379 RID: 4985 RVA: 0x00054CD4 File Offset: 0x00052ED4
	public unsafe static ProfileManager instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244358, XrefRangeEnd = 244392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_get_instance_Public_Static_get_ProfileManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileManager>(intPtr3) : null;
		}
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x00054D08 File Offset: 0x00052F08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244392, XrefRangeEnd = 244397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00054D3C File Offset: 0x00052F3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244397, XrefRangeEnd = 244411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x00054D70 File Offset: 0x00052F70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21072, RefRangeEnd = 21073, XrefRangeStart = 21072, XrefRangeEnd = 21073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int HashString(string s)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_HashString_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x00054DB4 File Offset: 0x00052FB4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 244416, RefRangeEnd = 244419, XrefRangeStart = 244411, XrefRangeEnd = 244416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetProfileListHash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetProfileListHash_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x00054DF0 File Offset: 0x00052FF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244419, XrefRangeEnd = 244433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Initialize_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x00054E2C File Offset: 0x0005302C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 244442, RefRangeEnd = 244446, XrefRangeStart = 244433, XrefRangeEnd = 244442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateDefaultProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_CreateDefaultProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00054E60 File Offset: 0x00053060
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244446, XrefRangeEnd = 244453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeHeader(ref ProfileManager.OfflineProfileHeader header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(header);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_InitializeHeader_Private_Void_byref_OfflineProfileHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			header = ((intPtr4 == 0) ? null : new ProfileManager.OfflineProfileHeader(intPtr4));
		}
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x00054EB8 File Offset: 0x000530B8
	[CallerCount(0)]
	public unsafe bool CheckFileVersion(ProfileManager.OfflineProfileHeader header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(header);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_CheckFileVersion_Private_Boolean_OfflineProfileHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x00054F08 File Offset: 0x00053108
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244528, RefRangeEnd = 244529, XrefRangeStart = 244453, XrefRangeEnd = 244528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckValidProfileHeader(ProfileManager.OfflineProfileHeader fileHeader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(fileHeader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_CheckValidProfileHeader_Private_Boolean_OfflineProfileHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x00054F58 File Offset: 0x00053158
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244531, RefRangeEnd = 244533, XrefRangeStart = 244529, XrefRangeEnd = 244531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeNewEntry(ref ProfileManager.OfflineProfileEntry profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_InitializeNewEntry_Public_Void_byref_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			profile = ((intPtr4 == 0) ? null : new ProfileManager.OfflineProfileEntry(intPtr4));
		}
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x00054FB0 File Offset: 0x000531B0
	[CallerCount(0)]
	public unsafe void ResetStats(ref ProfileManager.OfflineProfileEntry profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_ResetStats_Public_Void_byref_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			profile = ((intPtr4 == 0) ? null : new ProfileManager.OfflineProfileEntry(intPtr4));
		}
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x00055008 File Offset: 0x00053208
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 244562, RefRangeEnd = 244568, XrefRangeStart = 244533, XrefRangeEnd = 244562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Save_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x00055044 File Offset: 0x00053244
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244602, RefRangeEnd = 244604, XrefRangeStart = 244568, XrefRangeEnd = 244602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Load_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x00055080 File Offset: 0x00053280
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 244605, RefRangeEnd = 244608, XrefRangeStart = 244604, XrefRangeEnd = 244605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Count()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Count_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x000550BC File Offset: 0x000532BC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 244612, RefRangeEnd = 244616, XrefRangeStart = 244608, XrefRangeEnd = 244612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetIndex(ProfileManager.OfflineProfileEntry profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetIndex_Public_Int32_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x0005510C File Offset: 0x0005330C
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 244619, RefRangeEnd = 244628, XrefRangeStart = 244616, XrefRangeEnd = 244619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfileManager.OfflineProfileEntry Get(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Get_Public_OfflineProfileEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr3) : null;
		}
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x00055158 File Offset: 0x00053358
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244635, RefRangeEnd = 244636, XrefRangeStart = 244628, XrefRangeEnd = 244635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfileManager.OfflineProfileEntry GetProfile(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetProfile_Public_OfflineProfileEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr3) : null;
		}
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x000551A8 File Offset: 0x000533A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244636, XrefRangeEnd = 244640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string StringifyID(uint myID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref myID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_StringifyID_Public_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x000551EC File Offset: 0x000533EC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 244658, RefRangeEnd = 244661, XrefRangeStart = 244640, XrefRangeEnd = 244658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfileManager.OfflineProfileEntry CheckIfProfileExistWithDisplayName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_CheckIfProfileExistWithDisplayName_Public_OfflineProfileEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr3) : null;
		}
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x0005523C File Offset: 0x0005343C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244661, XrefRangeEnd = 244671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetProfilesWithDisplayNameH(int hash, ref List<ProfileManager.OfflineProfileEntry> names)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hash;
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(names);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetProfilesWithDisplayNameH_Public_Int32_Int32_byref_List_1_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		names = ((intPtr4 == 0) ? null : new List<ProfileManager.OfflineProfileEntry>(intPtr4));
		return *IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x000552B0 File Offset: 0x000534B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244671, XrefRangeEnd = 244675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetName(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x000552F4 File Offset: 0x000534F4
	[CallerCount(0)]
	public unsafe string GetDisplayName(ProfileManager.OfflineProfileEntry profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetDisplayName_Public_String_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x0005533C File Offset: 0x0005353C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244679, RefRangeEnd = 244680, XrefRangeStart = 244675, XrefRangeEnd = 244679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateProfileName(ref ProfileManager.OfflineProfileEntry profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_UpdateProfileName_Public_Void_byref_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			profile = ((intPtr4 == 0) ? null : new ProfileManager.OfflineProfileEntry(intPtr4));
		}
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x00055394 File Offset: 0x00053594
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244680, XrefRangeEnd = 244688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Delete(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Delete_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x000553E4 File Offset: 0x000535E4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 244697, RefRangeEnd = 244700, XrefRangeStart = 244688, XrefRangeEnd = 244697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Delete(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Delete_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x00055430 File Offset: 0x00053630
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244700, XrefRangeEnd = 244705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Delete(ProfileManager.OfflineProfileEntry profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Delete_Public_Boolean_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x00055480 File Offset: 0x00053680
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244711, RefRangeEnd = 244713, XrefRangeStart = 244705, XrefRangeEnd = 244711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Create(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Create_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x000554D0 File Offset: 0x000536D0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244734, RefRangeEnd = 244736, XrefRangeStart = 244713, XrefRangeEnd = 244734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Add(ProfileManager.OfflineProfileEntry newProfile, bool bSave = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newProfile);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSave;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_Add_Public_Int32_OfflineProfileEntry_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x0005552C File Offset: 0x0005372C
	[CallerCount(0)]
	public unsafe void GenerateNameHash(ref ProfileManager.MyProfile profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GenerateNameHash_Private_Void_byref_MyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			profile = ((intPtr4 == 0) ? null : new ProfileManager.MyProfile(intPtr4));
		}
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x00055584 File Offset: 0x00053784
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfileManager.OfflineProfileEntry GetCurrentProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetCurrentProfile_Public_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr3) : null;
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x000555C4 File Offset: 0x000537C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfileManager.OfflineProfileEntry GetCurrentProfileRef()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetCurrentProfileRef_Public_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr3) : null;
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x00055604 File Offset: 0x00053804
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244740, RefRangeEnd = 244742, XrefRangeStart = 244736, XrefRangeEnd = 244740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCurrentProfile(ProfileManager.OfflineProfileEntry current)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_SetCurrentProfile_Public_Void_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x00055648 File Offset: 0x00053848
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244742, XrefRangeEnd = 244743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckDeleteProfile(ProfileManager.OfflineProfileEntry profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_CheckDeleteProfile_Public_Boolean_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00055698 File Offset: 0x00053898
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244743, XrefRangeEnd = 244744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGamePlayerNameHash(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetGamePlayerNameHash_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x000556E8 File Offset: 0x000538E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244744, XrefRangeEnd = 244750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetProfileSaveDirectory(ProfileManager.OfflineProfileEntry profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_GetProfileSaveDirectory_Public_String_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x00055730 File Offset: 0x00053930
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintProfileEntry(ProfileManager.OfflineProfileEntry profileEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profileEntry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_PrintProfileEntry_Private_Void_OfflineProfileEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x00055774 File Offset: 0x00053974
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244750, XrefRangeEnd = 244763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintProfile(ProfileManager.MyProfile profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_PrintProfile_Private_Void_MyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x000557B8 File Offset: 0x000539B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244763, XrefRangeEnd = 244790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintAllProfiles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr_PrintAllProfiles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x000557EC File Offset: 0x000539EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244790, XrefRangeEnd = 244797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfileManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x0000CDB5 File Offset: 0x0000AFB5
	public ProfileManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700063A RID: 1594
	// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00055828 File Offset: 0x00053A28
	// (set) Token: 0x060013A3 RID: 5027 RVA: 0x0000CDBE File Offset: 0x0000AFBE
	public unsafe static byte OFFLINEPROFILE_VERSION
	{
		get
		{
			byte b;
			IL2CPP.il2cpp_field_static_get_value(ProfileManager.NativeFieldInfoPtr_OFFLINEPROFILE_VERSION, (void*)(&b));
			return b;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ProfileManager.NativeFieldInfoPtr_OFFLINEPROFILE_VERSION, (void*)(&value));
		}
	}

	// Token: 0x1700063B RID: 1595
	// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00055844 File Offset: 0x00053A44
	// (set) Token: 0x060013A5 RID: 5029 RVA: 0x0000CDCC File Offset: 0x0000AFCC
	public unsafe static string OfflineProfileFilename
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ProfileManager.NativeFieldInfoPtr_OfflineProfileFilename, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ProfileManager.NativeFieldInfoPtr_OfflineProfileFilename, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00055864 File Offset: 0x00053A64
	// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0000CDDE File Offset: 0x0000AFDE
	public unsafe static uint OFFLINEPROFILE_ID
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(ProfileManager.NativeFieldInfoPtr_OFFLINEPROFILE_ID, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ProfileManager.NativeFieldInfoPtr_OFFLINEPROFILE_ID, (void*)(&value));
		}
	}

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00055880 File Offset: 0x00053A80
	// (set) Token: 0x060013A9 RID: 5033 RVA: 0x0000CDEC File Offset: 0x0000AFEC
	public unsafe List<ProfileManager.MyProfile> m_profileEntries
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.NativeFieldInfoPtr_m_profileEntries);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProfileManager.MyProfile>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.NativeFieldInfoPtr_m_profileEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x060013AA RID: 5034 RVA: 0x000558B0 File Offset: 0x00053AB0
	// (set) Token: 0x060013AB RID: 5035 RVA: 0x0000CE0B File Offset: 0x0000B00B
	public unsafe ProfileManager.OfflineProfileEntry m_CurrentProfile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.NativeFieldInfoPtr_m_CurrentProfile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.NativeFieldInfoPtr_m_CurrentProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x060013AC RID: 5036 RVA: 0x000558E0 File Offset: 0x00053AE0
	// (set) Token: 0x060013AD RID: 5037 RVA: 0x0000CE2A File Offset: 0x0000B02A
	public unsafe static ProfileManager _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ProfileManager.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ProfileManager.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D8E RID: 3470
	private static readonly IntPtr NativeFieldInfoPtr_OFFLINEPROFILE_VERSION;

	// Token: 0x04000D8F RID: 3471
	private static readonly IntPtr NativeFieldInfoPtr_OfflineProfileFilename;

	// Token: 0x04000D90 RID: 3472
	private static readonly IntPtr NativeFieldInfoPtr_OFFLINEPROFILE_ID;

	// Token: 0x04000D91 RID: 3473
	private static readonly IntPtr NativeFieldInfoPtr_m_profileEntries;

	// Token: 0x04000D92 RID: 3474
	private static readonly IntPtr NativeFieldInfoPtr_m_CurrentProfile;

	// Token: 0x04000D93 RID: 3475
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x04000D94 RID: 3476
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ProfileManager_0;

	// Token: 0x04000D95 RID: 3477
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D96 RID: 3478
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000D97 RID: 3479
	private static readonly IntPtr NativeMethodInfoPtr_HashString_Private_Static_Int32_String_0;

	// Token: 0x04000D98 RID: 3480
	private static readonly IntPtr NativeMethodInfoPtr_GetProfileListHash_Private_Int32_0;

	// Token: 0x04000D99 RID: 3481
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Boolean_0;

	// Token: 0x04000D9A RID: 3482
	private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultProfile_Private_Void_0;

	// Token: 0x04000D9B RID: 3483
	private static readonly IntPtr NativeMethodInfoPtr_InitializeHeader_Private_Void_byref_OfflineProfileHeader_0;

	// Token: 0x04000D9C RID: 3484
	private static readonly IntPtr NativeMethodInfoPtr_CheckFileVersion_Private_Boolean_OfflineProfileHeader_0;

	// Token: 0x04000D9D RID: 3485
	private static readonly IntPtr NativeMethodInfoPtr_CheckValidProfileHeader_Private_Boolean_OfflineProfileHeader_0;

	// Token: 0x04000D9E RID: 3486
	private static readonly IntPtr NativeMethodInfoPtr_InitializeNewEntry_Public_Void_byref_OfflineProfileEntry_0;

	// Token: 0x04000D9F RID: 3487
	private static readonly IntPtr NativeMethodInfoPtr_ResetStats_Public_Void_byref_OfflineProfileEntry_0;

	// Token: 0x04000DA0 RID: 3488
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Boolean_0;

	// Token: 0x04000DA1 RID: 3489
	private static readonly IntPtr NativeMethodInfoPtr_Load_Private_Boolean_0;

	// Token: 0x04000DA2 RID: 3490
	private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Int32_0;

	// Token: 0x04000DA3 RID: 3491
	private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Public_Int32_OfflineProfileEntry_0;

	// Token: 0x04000DA4 RID: 3492
	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_OfflineProfileEntry_Int32_0;

	// Token: 0x04000DA5 RID: 3493
	private static readonly IntPtr NativeMethodInfoPtr_GetProfile_Public_OfflineProfileEntry_String_0;

	// Token: 0x04000DA6 RID: 3494
	private static readonly IntPtr NativeMethodInfoPtr_StringifyID_Public_String_UInt32_0;

	// Token: 0x04000DA7 RID: 3495
	private static readonly IntPtr NativeMethodInfoPtr_CheckIfProfileExistWithDisplayName_Public_OfflineProfileEntry_String_0;

	// Token: 0x04000DA8 RID: 3496
	private static readonly IntPtr NativeMethodInfoPtr_GetProfilesWithDisplayNameH_Public_Int32_Int32_byref_List_1_OfflineProfileEntry_0;

	// Token: 0x04000DA9 RID: 3497
	private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_String_Int32_0;

	// Token: 0x04000DAA RID: 3498
	private static readonly IntPtr NativeMethodInfoPtr_GetDisplayName_Public_String_OfflineProfileEntry_0;

	// Token: 0x04000DAB RID: 3499
	private static readonly IntPtr NativeMethodInfoPtr_UpdateProfileName_Public_Void_byref_OfflineProfileEntry_0;

	// Token: 0x04000DAC RID: 3500
	private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Boolean_String_0;

	// Token: 0x04000DAD RID: 3501
	private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Boolean_Int32_0;

	// Token: 0x04000DAE RID: 3502
	private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Boolean_OfflineProfileEntry_0;

	// Token: 0x04000DAF RID: 3503
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Boolean_String_0;

	// Token: 0x04000DB0 RID: 3504
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_OfflineProfileEntry_Boolean_0;

	// Token: 0x04000DB1 RID: 3505
	private static readonly IntPtr NativeMethodInfoPtr_GenerateNameHash_Private_Void_byref_MyProfile_0;

	// Token: 0x04000DB2 RID: 3506
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProfile_Public_OfflineProfileEntry_0;

	// Token: 0x04000DB3 RID: 3507
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProfileRef_Public_OfflineProfileEntry_0;

	// Token: 0x04000DB4 RID: 3508
	private static readonly IntPtr NativeMethodInfoPtr_SetCurrentProfile_Public_Void_OfflineProfileEntry_0;

	// Token: 0x04000DB5 RID: 3509
	private static readonly IntPtr NativeMethodInfoPtr_CheckDeleteProfile_Public_Boolean_OfflineProfileEntry_0;

	// Token: 0x04000DB6 RID: 3510
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerNameHash_Private_Int32_String_0;

	// Token: 0x04000DB7 RID: 3511
	private static readonly IntPtr NativeMethodInfoPtr_GetProfileSaveDirectory_Public_String_OfflineProfileEntry_0;

	// Token: 0x04000DB8 RID: 3512
	private static readonly IntPtr NativeMethodInfoPtr_PrintProfileEntry_Private_Void_OfflineProfileEntry_0;

	// Token: 0x04000DB9 RID: 3513
	private static readonly IntPtr NativeMethodInfoPtr_PrintProfile_Private_Void_MyProfile_0;

	// Token: 0x04000DBA RID: 3514
	private static readonly IntPtr NativeMethodInfoPtr_PrintAllProfiles_Private_Void_0;

	// Token: 0x04000DBB RID: 3515
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001A9 RID: 425
	[Serializable]
	public class OfflineProfileHeader : global::Il2CppSystem.Object
	{
		// Token: 0x0600251E RID: 9502 RVA: 0x00089718 File Offset: 0x00087918
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineProfileHeader()
		{
			Il2CppClassPointerStore<ProfileManager.OfflineProfileHeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "OfflineProfileHeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileManager.OfflineProfileHeader>.NativeClassPtr);
			ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileHeader>.NativeClassPtr, "id");
			ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_numEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileHeader>.NativeClassPtr, "numEntries");
			ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_sizePerEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileHeader>.NativeClassPtr, "sizePerEntry");
			ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_lastUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileHeader>.NativeClassPtr, "lastUpdated");
			ProfileManager.OfflineProfileHeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager.OfflineProfileHeader>.NativeClassPtr, 100666240);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000897A8 File Offset: 0x000879A8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineProfileHeader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileManager.OfflineProfileHeader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.OfflineProfileHeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x0001707D File Offset: 0x0001527D
		public OfflineProfileHeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x000897E4 File Offset: 0x000879E4
		// (set) Token: 0x06002522 RID: 9506 RVA: 0x00017086 File Offset: 0x00015286
		public unsafe uint id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x0008980C File Offset: 0x00087A0C
		// (set) Token: 0x06002524 RID: 9508 RVA: 0x000170A1 File Offset: 0x000152A1
		public unsafe int numEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_numEntries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_numEntries)) = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x00089834 File Offset: 0x00087A34
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x000170BC File Offset: 0x000152BC
		public unsafe int sizePerEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_sizePerEntry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_sizePerEntry)) = value;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x0008985C File Offset: 0x00087A5C
		// (set) Token: 0x06002528 RID: 9512 RVA: 0x000170D7 File Offset: 0x000152D7
		public unsafe int lastUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_lastUpdated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileHeader.NativeFieldInfoPtr_lastUpdated)) = value;
			}
		}

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeFieldInfoPtr_numEntries;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeFieldInfoPtr_sizePerEntry;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeFieldInfoPtr_lastUpdated;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001AA RID: 426
	[Serializable]
	public class OfflineProfileEntry : global::Il2CppSystem.Object
	{
		// Token: 0x06002529 RID: 9513 RVA: 0x00089884 File Offset: 0x00087A84
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineProfileEntry()
		{
			Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "OfflineProfileEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr);
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "name");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "flags");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_avatarIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "avatarIndex");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_gameAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "gameAvatar");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "completed");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_forfeits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "forfeits");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_2p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "wins_2p");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_3p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "wins_3p");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_4p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "wins_4p");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_2p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "losses_2p");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_3p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "losses_3p");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_4p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "losses_4p");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_tutorialDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "tutorialDone");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "rating");
			ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_idNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, "idNumber");
			ProfileManager.OfflineProfileEntry.NativeMethodInfoPtr_GetHash_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, 100666241);
			ProfileManager.OfflineProfileEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr, 100666242);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00089A04 File Offset: 0x00087C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244357, RefRangeEnd = 244358, XrefRangeStart = 244353, XrefRangeEnd = 244357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.OfflineProfileEntry.NativeMethodInfoPtr_GetHash_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00089A40 File Offset: 0x00087C40
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineProfileEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileManager.OfflineProfileEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.OfflineProfileEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x000170F2 File Offset: 0x000152F2
		public OfflineProfileEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x00089A7C File Offset: 0x00087C7C
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x000170FB File Offset: 0x000152FB
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00089AA4 File Offset: 0x00087CA4
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x0001711A File Offset: 0x0001531A
		public unsafe uint flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x00089ACC File Offset: 0x00087CCC
		// (set) Token: 0x06002532 RID: 9522 RVA: 0x00017135 File Offset: 0x00015335
		public unsafe byte avatarIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_avatarIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_avatarIndex)) = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x00089AF4 File Offset: 0x00087CF4
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x00017150 File Offset: 0x00015350
		public unsafe byte gameAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_gameAvatar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_gameAvatar)) = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x00089B1C File Offset: 0x00087D1C
		// (set) Token: 0x06002536 RID: 9526 RVA: 0x0001716B File Offset: 0x0001536B
		public unsafe uint completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x00089B44 File Offset: 0x00087D44
		// (set) Token: 0x06002538 RID: 9528 RVA: 0x00017186 File Offset: 0x00015386
		public unsafe uint forfeits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_forfeits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_forfeits)) = value;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x00089B6C File Offset: 0x00087D6C
		// (set) Token: 0x0600253A RID: 9530 RVA: 0x000171A1 File Offset: 0x000153A1
		public unsafe uint wins_2p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_2p);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_2p)) = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x00089B94 File Offset: 0x00087D94
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x000171BC File Offset: 0x000153BC
		public unsafe uint wins_3p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_3p);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_3p)) = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x00089BBC File Offset: 0x00087DBC
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x000171D7 File Offset: 0x000153D7
		public unsafe uint wins_4p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_4p);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_wins_4p)) = value;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x00089BE4 File Offset: 0x00087DE4
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x000171F2 File Offset: 0x000153F2
		public unsafe uint losses_2p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_2p);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_2p)) = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x00089C0C File Offset: 0x00087E0C
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x0001720D File Offset: 0x0001540D
		public unsafe uint losses_3p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_3p);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_3p)) = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x00089C34 File Offset: 0x00087E34
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x00017228 File Offset: 0x00015428
		public unsafe uint losses_4p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_4p);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_losses_4p)) = value;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x00089C5C File Offset: 0x00087E5C
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x00017243 File Offset: 0x00015443
		public unsafe uint tutorialDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_tutorialDone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_tutorialDone)) = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x00089C84 File Offset: 0x00087E84
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x0001725E File Offset: 0x0001545E
		public unsafe uint rating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_rating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_rating)) = value;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00089CAC File Offset: 0x00087EAC
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x00017279 File Offset: 0x00015479
		public unsafe long idNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_idNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.OfflineProfileEntry.NativeFieldInfoPtr_idNumber)) = value;
			}
		}

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeFieldInfoPtr_avatarIndex;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeFieldInfoPtr_gameAvatar;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeFieldInfoPtr_forfeits;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeFieldInfoPtr_wins_2p;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeFieldInfoPtr_wins_3p;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeFieldInfoPtr_wins_4p;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeFieldInfoPtr_losses_2p;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeFieldInfoPtr_losses_3p;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeFieldInfoPtr_losses_4p;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeFieldInfoPtr_tutorialDone;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeFieldInfoPtr_rating;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeFieldInfoPtr_idNumber;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Public_Int32_0;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001AB RID: 427
	[Serializable]
	public class MyProfile : global::Il2CppSystem.Object
	{
		// Token: 0x0600254B RID: 9547 RVA: 0x00089CD4 File Offset: 0x00087ED4
		// Note: this type is marked as 'beforefieldinit'.
		static MyProfile()
		{
			Il2CppClassPointerStore<ProfileManager.MyProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "MyProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileManager.MyProfile>.NativeClassPtr);
			ProfileManager.MyProfile.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.MyProfile>.NativeClassPtr, "data");
			ProfileManager.MyProfile.NativeFieldInfoPtr_nameHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager.MyProfile>.NativeClassPtr, "nameHash");
			ProfileManager.MyProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager.MyProfile>.NativeClassPtr, 100666243);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00089D3C File Offset: 0x00087F3C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MyProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileManager.MyProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileManager.MyProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00017294 File Offset: 0x00015494
		public MyProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x00089D78 File Offset: 0x00087F78
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x0001729D File Offset: 0x0001549D
		public unsafe ProfileManager.OfflineProfileEntry data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.MyProfile.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileManager.OfflineProfileEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.MyProfile.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x00089DA8 File Offset: 0x00087FA8
		// (set) Token: 0x06002551 RID: 9553 RVA: 0x000172BC File Offset: 0x000154BC
		public unsafe int nameHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.MyProfile.NativeFieldInfoPtr_nameHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileManager.MyProfile.NativeFieldInfoPtr_nameHash)) = value;
			}
		}

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeFieldInfoPtr_nameHash;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
