using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B1 RID: 177
[Serializable]
public class UIC_OfflineGameList : global::Il2CppSystem.Object
{
	// Token: 0x060014CF RID: 5327 RVA: 0x0005936C File Offset: 0x0005756C
	// Note: this type is marked as 'beforefieldinit'.
	static UIC_OfflineGameList()
	{
		Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIC_OfflineGameList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr);
		UIC_OfflineGameList.NativeFieldInfoPtr_k_MaxOfflineGameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "k_MaxOfflineGameCount");
		UIC_OfflineGameList.NativeFieldInfoPtr_m_gameSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "m_gameSlotPrefab");
		UIC_OfflineGameList.NativeFieldInfoPtr_m_contentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "m_contentContainer");
		UIC_OfflineGameList.NativeFieldInfoPtr_m_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "m_scrollView");
		UIC_OfflineGameList.NativeFieldInfoPtr_m_monoBehaviourInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "m_monoBehaviourInstance");
		UIC_OfflineGameList.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "m_Callback");
		UIC_OfflineGameList.NativeFieldInfoPtr_m_gameSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "m_gameSlots");
		UIC_OfflineGameList.NativeFieldInfoPtr_m_noGamesDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "m_noGamesDisplay");
		UIC_OfflineGameList.NativeMethodInfoPtr_Initialize_Public_Void_String_ClickCallback_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664974);
		UIC_OfflineGameList.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664975);
		UIC_OfflineGameList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664976);
		UIC_OfflineGameList.NativeMethodInfoPtr_GetNumGames_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664977);
		UIC_OfflineGameList.NativeMethodInfoPtr_Update_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664978);
		UIC_OfflineGameList.NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664979);
		UIC_OfflineGameList.NativeMethodInfoPtr_DeleteGame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664980);
		UIC_OfflineGameList.NativeMethodInfoPtr_GetGameFromID_Public_UIP_GameSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664981);
		UIC_OfflineGameList.NativeMethodInfoPtr_GetGameFromIndex_Public_UIP_GameSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664982);
		UIC_OfflineGameList.NativeMethodInfoPtr_ClearGameList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664983);
		UIC_OfflineGameList.NativeMethodInfoPtr_GetFullFileName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664984);
		UIC_OfflineGameList.NativeMethodInfoPtr_GetShortFileName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664985);
		UIC_OfflineGameList.NativeMethodInfoPtr_GetEmptySlot_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664986);
		UIC_OfflineGameList.NativeMethodInfoPtr_GetTutorialSlot_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664987);
		UIC_OfflineGameList.NativeMethodInfoPtr_BuildGameList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664988);
		UIC_OfflineGameList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, 100664989);
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x0005957C File Offset: 0x0005777C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246362, RefRangeEnd = 246363, XrefRangeStart = 246343, XrefRangeEnd = 246362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(string profileName, UIC_OfflineGameList.ClickCallback cb, MonoBehaviour monoBehaviourInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(profileName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(monoBehaviourInstance);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_Initialize_Public_Void_String_ClickCallback_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014D1 RID: 5329 RVA: 0x000595E4 File Offset: 0x000577E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246364, RefRangeEnd = 246365, XrefRangeStart = 246363, XrefRangeEnd = 246364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x00059618 File Offset: 0x00057818
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnSlot(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x00059668 File Offset: 0x00057868
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246365, XrefRangeEnd = 246366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNumGames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_GetNumGames_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x000596A4 File Offset: 0x000578A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246366, XrefRangeEnd = 246370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_Update_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x000596E4 File Offset: 0x000578E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246383, RefRangeEnd = 246384, XrefRangeStart = 246370, XrefRangeEnd = 246383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadGame(int slotIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x00059724 File Offset: 0x00057924
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 246408, RefRangeEnd = 246410, XrefRangeStart = 246384, XrefRangeEnd = 246408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteGame(int slotIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_DeleteGame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x00059764 File Offset: 0x00057964
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 246416, RefRangeEnd = 246418, XrefRangeStart = 246410, XrefRangeEnd = 246416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_GameSlot GetGameFromID(int slotIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_GetGameFromID_Public_UIP_GameSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIP_GameSlot>(intPtr3) : null;
		}
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x000597B0 File Offset: 0x000579B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246418, XrefRangeEnd = 246421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_GameSlot GetGameFromIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_GetGameFromIndex_Public_UIP_GameSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIP_GameSlot>(intPtr3) : null;
		}
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x000597FC File Offset: 0x000579FC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 246437, RefRangeEnd = 246439, XrefRangeStart = 246421, XrefRangeEnd = 246437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearGameList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_ClearGameList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x00059830 File Offset: 0x00057A30
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 246450, RefRangeEnd = 246455, XrefRangeStart = 246439, XrefRangeEnd = 246450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFullFileName(int slot)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_GetFullFileName_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x00059868 File Offset: 0x00057A68
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 246466, RefRangeEnd = 246471, XrefRangeStart = 246455, XrefRangeEnd = 246466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetShortFileName(int slot)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_GetShortFileName_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x000598A0 File Offset: 0x00057AA0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246475, RefRangeEnd = 246476, XrefRangeStart = 246471, XrefRangeEnd = 246475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetEmptySlot()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_GetEmptySlot_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x000598D0 File Offset: 0x00057AD0
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTutorialSlot()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_GetTutorialSlot_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x00059900 File Offset: 0x00057B00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246557, RefRangeEnd = 246558, XrefRangeStart = 246476, XrefRangeEnd = 246557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildGameList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr_BuildGameList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x00059934 File Offset: 0x00057B34
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIC_OfflineGameList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x0000D7BF File Offset: 0x0000B9BF
	public UIC_OfflineGameList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00059970 File Offset: 0x00057B70
	// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
	public unsafe static int k_MaxOfflineGameCount
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(UIC_OfflineGameList.NativeFieldInfoPtr_k_MaxOfflineGameCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIC_OfflineGameList.NativeFieldInfoPtr_k_MaxOfflineGameCount, (void*)(&value));
		}
	}

	// Token: 0x17000694 RID: 1684
	// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0005998C File Offset: 0x00057B8C
	// (set) Token: 0x060014E4 RID: 5348 RVA: 0x0000D7D6 File Offset: 0x0000B9D6
	public unsafe GameObject m_gameSlotPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_gameSlotPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_gameSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x060014E5 RID: 5349 RVA: 0x000599BC File Offset: 0x00057BBC
	// (set) Token: 0x060014E6 RID: 5350 RVA: 0x0000D7F5 File Offset: 0x0000B9F5
	public unsafe Transform m_contentContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_contentContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_contentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000696 RID: 1686
	// (get) Token: 0x060014E7 RID: 5351 RVA: 0x000599EC File Offset: 0x00057BEC
	// (set) Token: 0x060014E8 RID: 5352 RVA: 0x0000D814 File Offset: 0x0000BA14
	public unsafe ScrollRect m_scrollView
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_scrollView);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_scrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000697 RID: 1687
	// (get) Token: 0x060014E9 RID: 5353 RVA: 0x00059A1C File Offset: 0x00057C1C
	// (set) Token: 0x060014EA RID: 5354 RVA: 0x0000D833 File Offset: 0x0000BA33
	public unsafe MonoBehaviour m_monoBehaviourInstance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_monoBehaviourInstance);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_monoBehaviourInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x060014EB RID: 5355 RVA: 0x00059A4C File Offset: 0x00057C4C
	// (set) Token: 0x060014EC RID: 5356 RVA: 0x0000D852 File Offset: 0x0000BA52
	public unsafe UIC_OfflineGameList.ClickCallback m_Callback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_Callback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OfflineGameList.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000699 RID: 1689
	// (get) Token: 0x060014ED RID: 5357 RVA: 0x00059A7C File Offset: 0x00057C7C
	// (set) Token: 0x060014EE RID: 5358 RVA: 0x0000D871 File Offset: 0x0000BA71
	public unsafe List<UIP_GameSlot> m_gameSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_gameSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIP_GameSlot>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_gameSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069A RID: 1690
	// (get) Token: 0x060014EF RID: 5359 RVA: 0x00059AAC File Offset: 0x00057CAC
	// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0000D890 File Offset: 0x0000BA90
	public unsafe GameObject m_noGamesDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_noGamesDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList.NativeFieldInfoPtr_m_noGamesDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000E7A RID: 3706
	private static readonly IntPtr NativeFieldInfoPtr_k_MaxOfflineGameCount;

	// Token: 0x04000E7B RID: 3707
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSlotPrefab;

	// Token: 0x04000E7C RID: 3708
	private static readonly IntPtr NativeFieldInfoPtr_m_contentContainer;

	// Token: 0x04000E7D RID: 3709
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollView;

	// Token: 0x04000E7E RID: 3710
	private static readonly IntPtr NativeFieldInfoPtr_m_monoBehaviourInstance;

	// Token: 0x04000E7F RID: 3711
	private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

	// Token: 0x04000E80 RID: 3712
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSlots;

	// Token: 0x04000E81 RID: 3713
	private static readonly IntPtr NativeFieldInfoPtr_m_noGamesDisplay;

	// Token: 0x04000E82 RID: 3714
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_ClickCallback_MonoBehaviour_0;

	// Token: 0x04000E83 RID: 3715
	private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

	// Token: 0x04000E84 RID: 3716
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0;

	// Token: 0x04000E85 RID: 3717
	private static readonly IntPtr NativeMethodInfoPtr_GetNumGames_Public_Int32_0;

	// Token: 0x04000E86 RID: 3718
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_IEnumerator_0;

	// Token: 0x04000E87 RID: 3719
	private static readonly IntPtr NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0;

	// Token: 0x04000E88 RID: 3720
	private static readonly IntPtr NativeMethodInfoPtr_DeleteGame_Public_Void_Int32_0;

	// Token: 0x04000E89 RID: 3721
	private static readonly IntPtr NativeMethodInfoPtr_GetGameFromID_Public_UIP_GameSlot_Int32_0;

	// Token: 0x04000E8A RID: 3722
	private static readonly IntPtr NativeMethodInfoPtr_GetGameFromIndex_Public_UIP_GameSlot_Int32_0;

	// Token: 0x04000E8B RID: 3723
	private static readonly IntPtr NativeMethodInfoPtr_ClearGameList_Private_Void_0;

	// Token: 0x04000E8C RID: 3724
	private static readonly IntPtr NativeMethodInfoPtr_GetFullFileName_Public_Static_String_Int32_0;

	// Token: 0x04000E8D RID: 3725
	private static readonly IntPtr NativeMethodInfoPtr_GetShortFileName_Public_Static_String_Int32_0;

	// Token: 0x04000E8E RID: 3726
	private static readonly IntPtr NativeMethodInfoPtr_GetEmptySlot_Public_Static_Int32_0;

	// Token: 0x04000E8F RID: 3727
	private static readonly IntPtr NativeMethodInfoPtr_GetTutorialSlot_Public_Static_Int32_0;

	// Token: 0x04000E90 RID: 3728
	private static readonly IntPtr NativeMethodInfoPtr_BuildGameList_Private_Void_0;

	// Token: 0x04000E91 RID: 3729
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001C1 RID: 449
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x06002616 RID: 9750 RVA: 0x0008C0A0 File Offset: 0x0008A2A0
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UIC_OfflineGameList.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "ClickCallback");
			UIC_OfflineGameList.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList.ClickCallback>.NativeClassPtr, 100666308);
			UIC_OfflineGameList.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList.ClickCallback>.NativeClassPtr, 100666309);
			UIC_OfflineGameList.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList.ClickCallback>.NativeClassPtr, 100666310);
			UIC_OfflineGameList.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList.ClickCallback>.NativeClassPtr, 100666311);
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x0008C114 File Offset: 0x0008A314
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OfflineGameList.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0008C170 File Offset: 0x0008A370
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79680, XrefRangeStart = 79669, XrefRangeEnd = 79680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x0008C1C0 File Offset: 0x0008A3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246330, XrefRangeEnd = 246334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0008C244 File Offset: 0x0008A444
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00017973 File Offset: 0x00015B73
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x0001797C File Offset: 0x00015B7C
		public static implicit operator UIC_OfflineGameList.ClickCallback(Action<UIP_GameSlot, UIP_GameSlot.ClickEventType> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIC_OfflineGameList.ClickCallback>(A_0);
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00017984 File Offset: 0x00015B84
		public static UIC_OfflineGameList.ClickCallback operator +(UIC_OfflineGameList.ClickCallback A_0, UIC_OfflineGameList.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIC_OfflineGameList.ClickCallback>();
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00017992 File Offset: 0x00015B92
		public static UIC_OfflineGameList.ClickCallback operator -(UIC_OfflineGameList.ClickCallback A_0, UIC_OfflineGameList.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIC_OfflineGameList.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020001C2 RID: 450
	[ObfuscatedName("UIC_OfflineGameList+<Update>d__13")]
	public sealed class _Update_d__13 : global::Il2CppSystem.Object
	{
		// Token: 0x0600261F RID: 9759 RVA: 0x0008C288 File Offset: 0x0008A488
		// Note: this type is marked as 'beforefieldinit'.
		static _Update_d__13()
		{
			Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_OfflineGameList>.NativeClassPtr, "<Update>d__13");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr);
			UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, "<>1__state");
			UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, "<>2__current");
			UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, "<>4__this");
			UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, 100666312);
			UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, 100666313);
			UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, 100666314);
			UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, 100666315);
			UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, 100666316);
			UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr, 100666317);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x0008C368 File Offset: 0x0008A568
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Update_d__13(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OfflineGameList._Update_d__13>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x0008C3B0 File Offset: 0x0008A5B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x0008C3E4 File Offset: 0x0008A5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246334, XrefRangeEnd = 246338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x0008C420 File Offset: 0x0008A620
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x0008C460 File Offset: 0x0008A660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246338, XrefRangeEnd = 246343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x0008C494 File Offset: 0x0008A694
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OfflineGameList._Update_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000179A3 File Offset: 0x00015BA3
		public _Update_d__13(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x0008C4D4 File Offset: 0x0008A6D4
		// (set) Token: 0x06002628 RID: 9768 RVA: 0x000179AC File Offset: 0x00015BAC
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x0008C4FC File Offset: 0x0008A6FC
		// (set) Token: 0x0600262A RID: 9770 RVA: 0x000179C7 File Offset: 0x00015BC7
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x0008C52C File Offset: 0x0008A72C
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x000179E6 File Offset: 0x00015BE6
		public unsafe UIC_OfflineGameList __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OfflineGameList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OfflineGameList._Update_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
