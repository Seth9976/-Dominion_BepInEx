using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x0200005C RID: 92
public class GooglePlayQuests : Singleton<GooglePlayQuests>
{
	// Token: 0x060006E0 RID: 1760 RVA: 0x0002E79C File Offset: 0x0002C99C
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayQuests()
	{
		Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayQuests");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr);
		GooglePlayQuests.NativeFieldInfoPtr_OnQuestsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, "OnQuestsLoaded");
		GooglePlayQuests.NativeFieldInfoPtr_OnQuestsAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, "OnQuestsAccepted");
		GooglePlayQuests.NativeFieldInfoPtr_OnQuestsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, "OnQuestsCompleted");
		GooglePlayQuests.NativeFieldInfoPtr_SELECT_ALL_QUESTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, "SELECT_ALL_QUESTS");
		GooglePlayQuests.NativeFieldInfoPtr__Quests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, "_Quests");
		GooglePlayQuests.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664124);
		GooglePlayQuests.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664125);
		GooglePlayQuests.NativeMethodInfoPtr_LoadQuests_Public_Void_GP_QuestSortOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664126);
		GooglePlayQuests.NativeMethodInfoPtr_LoadQuests_Public_Void_GP_QuestSortOrder_Il2CppStructArray_1_GP_QuestsSelect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664127);
		GooglePlayQuests.NativeMethodInfoPtr_ShowQuests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664128);
		GooglePlayQuests.NativeMethodInfoPtr_ShowQuests_Public_Void_Il2CppStructArray_1_GP_QuestsSelect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664129);
		GooglePlayQuests.NativeMethodInfoPtr_AcceptQuest_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664130);
		GooglePlayQuests.NativeMethodInfoPtr_GetQuestById_Public_GP_Quest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664131);
		GooglePlayQuests.NativeMethodInfoPtr_GetQuests_Public_List_1_GP_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664132);
		GooglePlayQuests.NativeMethodInfoPtr_GetQuestsByState_Public_List_1_GP_Quest_GP_QuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664133);
		GooglePlayQuests.NativeMethodInfoPtr_OnGPQuestAccepted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664134);
		GooglePlayQuests.NativeMethodInfoPtr_OnGPQuestCompleted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664135);
		GooglePlayQuests.NativeMethodInfoPtr_OnGPQuestUpdated_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664136);
		GooglePlayQuests.NativeMethodInfoPtr_OnGPQuestsLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664137);
		GooglePlayQuests.NativeMethodInfoPtr_UpdateQuestInfo_Private_Void_String_String_String_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664138);
		GooglePlayQuests.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, 100664139);
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x0002E970 File Offset: 0x0002CB70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166706, XrefRangeEnd = 166711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x0002E9A4 File Offset: 0x0002CBA4
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x0002E9D8 File Offset: 0x0002CBD8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166732, RefRangeEnd = 166733, XrefRangeStart = 166711, XrefRangeEnd = 166732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadQuests(GP_QuestSortOrder sortOrder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref sortOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_LoadQuests_Public_Void_GP_QuestSortOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x0002EA18 File Offset: 0x0002CC18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166733, XrefRangeEnd = 166750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadQuests(GP_QuestSortOrder sortOrder, [Optional] Il2CppStructArray<GP_QuestsSelect> selectors)
	{
		if (selectors == null)
		{
			selectors = new Il2CppStructArray<GP_QuestsSelect>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref sortOrder;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectors);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_LoadQuests_Public_Void_GP_QuestSortOrder_Il2CppStructArray_1_GP_QuestsSelect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x0002EA78 File Offset: 0x0002CC78
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166771, RefRangeEnd = 166772, XrefRangeStart = 166750, XrefRangeEnd = 166771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowQuests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_ShowQuests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x0002EAAC File Offset: 0x0002CCAC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 166789, RefRangeEnd = 166792, XrefRangeStart = 166772, XrefRangeEnd = 166789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowQuests([Optional] Il2CppStructArray<GP_QuestsSelect> selectors)
	{
		if (selectors == null)
		{
			selectors = new Il2CppStructArray<GP_QuestsSelect>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_ShowQuests_Public_Void_Il2CppStructArray_1_GP_QuestsSelect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x0002EAFC File Offset: 0x0002CCFC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166797, RefRangeEnd = 166798, XrefRangeStart = 166792, XrefRangeEnd = 166797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AcceptQuest(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_AcceptQuest_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x0002EB40 File Offset: 0x0002CD40
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 166806, RefRangeEnd = 166808, XrefRangeStart = 166798, XrefRangeEnd = 166806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Quest GetQuestById(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_GetQuestById_Public_GP_Quest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_Quest>(intPtr3) : null;
		}
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x0002EB90 File Offset: 0x0002CD90
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 166832, RefRangeEnd = 166835, XrefRangeStart = 166808, XrefRangeEnd = 166832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GP_Quest> GetQuests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_GetQuests_Public_List_1_GP_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GP_Quest>>(intPtr3) : null;
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166835, XrefRangeEnd = 166859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GP_Quest> GetQuestsByState(GP_QuestState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_GetQuestsByState_Public_List_1_GP_Quest_GP_QuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GP_Quest>>(intPtr3) : null;
		}
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0002EC1C File Offset: 0x0002CE1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166859, XrefRangeEnd = 166881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGPQuestAccepted(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_OnGPQuestAccepted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x0002EC60 File Offset: 0x0002CE60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166881, XrefRangeEnd = 166903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGPQuestCompleted(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_OnGPQuestCompleted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x0002ECA4 File Offset: 0x0002CEA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166903, XrefRangeEnd = 166911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGPQuestUpdated(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_OnGPQuestUpdated_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x0002ECE8 File Offset: 0x0002CEE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166911, XrefRangeEnd = 166941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGPQuestsLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_OnGPQuestsLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x0002ED2C File Offset: 0x0002CF2C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 166974, RefRangeEnd = 166976, XrefRangeStart = 166941, XrefRangeEnd = 166974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateQuestInfo(string id, string name, string descr, string icon, string banner, string state, string timeUpdated, string timeAccepted, string timeEnded, string rewardData, string currentProgress, string targetProgress)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(descr);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(icon);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(banner);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(state);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeUpdated);
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeAccepted);
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeEnded);
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(rewardData);
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentProgress);
		ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetProgress);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr_UpdateQuestInfo_Private_Void_String_String_String_String_String_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x0002EE44 File Offset: 0x0002D044
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166976, XrefRangeEnd = 167028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayQuests()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00004CD4 File Offset: 0x00002ED4
	public void LoadQuests(GP_QuestSortOrder sortOrder, params GP_QuestsSelect[] selectors)
	{
		this.LoadQuests(sortOrder, new Il2CppStructArray<GP_QuestsSelect>(selectors));
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00004CE3 File Offset: 0x00002EE3
	public void ShowQuests(params GP_QuestsSelect[] selectors)
	{
		this.ShowQuests(new Il2CppStructArray<GP_QuestsSelect>(selectors));
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00004CF1 File Offset: 0x00002EF1
	public GooglePlayQuests(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0002EE80 File Offset: 0x0002D080
	// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00004CFA File Offset: 0x00002EFA
	public unsafe Action<GP_QuestResult> OnQuestsLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayQuests.NativeFieldInfoPtr_OnQuestsLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_QuestResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayQuests.NativeFieldInfoPtr_OnQuestsLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0002EEB0 File Offset: 0x0002D0B0
	// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00004D19 File Offset: 0x00002F19
	public unsafe Action<GP_QuestResult> OnQuestsAccepted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayQuests.NativeFieldInfoPtr_OnQuestsAccepted);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_QuestResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayQuests.NativeFieldInfoPtr_OnQuestsAccepted), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
	// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00004D38 File Offset: 0x00002F38
	public unsafe Action<GP_QuestResult> OnQuestsCompleted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayQuests.NativeFieldInfoPtr_OnQuestsCompleted);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_QuestResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayQuests.NativeFieldInfoPtr_OnQuestsCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x060006FA RID: 1786 RVA: 0x0002EF10 File Offset: 0x0002D110
	// (set) Token: 0x060006FB RID: 1787 RVA: 0x00004D57 File Offset: 0x00002F57
	public unsafe static Il2CppStructArray<GP_QuestsSelect> SELECT_ALL_QUESTS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayQuests.NativeFieldInfoPtr_SELECT_ALL_QUESTS, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GP_QuestsSelect>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayQuests.NativeFieldInfoPtr_SELECT_ALL_QUESTS, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x060006FC RID: 1788 RVA: 0x0002EF38 File Offset: 0x0002D138
	// (set) Token: 0x060006FD RID: 1789 RVA: 0x00004D69 File Offset: 0x00002F69
	public unsafe Dictionary<string, GP_Quest> _Quests
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayQuests.NativeFieldInfoPtr__Quests);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GP_Quest>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayQuests.NativeFieldInfoPtr__Quests), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400059B RID: 1435
	private static readonly IntPtr NativeFieldInfoPtr_OnQuestsLoaded;

	// Token: 0x0400059C RID: 1436
	private static readonly IntPtr NativeFieldInfoPtr_OnQuestsAccepted;

	// Token: 0x0400059D RID: 1437
	private static readonly IntPtr NativeFieldInfoPtr_OnQuestsCompleted;

	// Token: 0x0400059E RID: 1438
	private static readonly IntPtr NativeFieldInfoPtr_SELECT_ALL_QUESTS;

	// Token: 0x0400059F RID: 1439
	private static readonly IntPtr NativeFieldInfoPtr__Quests;

	// Token: 0x040005A0 RID: 1440
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040005A1 RID: 1441
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x040005A2 RID: 1442
	private static readonly IntPtr NativeMethodInfoPtr_LoadQuests_Public_Void_GP_QuestSortOrder_0;

	// Token: 0x040005A3 RID: 1443
	private static readonly IntPtr NativeMethodInfoPtr_LoadQuests_Public_Void_GP_QuestSortOrder_Il2CppStructArray_1_GP_QuestsSelect_0;

	// Token: 0x040005A4 RID: 1444
	private static readonly IntPtr NativeMethodInfoPtr_ShowQuests_Public_Void_0;

	// Token: 0x040005A5 RID: 1445
	private static readonly IntPtr NativeMethodInfoPtr_ShowQuests_Public_Void_Il2CppStructArray_1_GP_QuestsSelect_0;

	// Token: 0x040005A6 RID: 1446
	private static readonly IntPtr NativeMethodInfoPtr_AcceptQuest_Public_Void_String_0;

	// Token: 0x040005A7 RID: 1447
	private static readonly IntPtr NativeMethodInfoPtr_GetQuestById_Public_GP_Quest_String_0;

	// Token: 0x040005A8 RID: 1448
	private static readonly IntPtr NativeMethodInfoPtr_GetQuests_Public_List_1_GP_Quest_0;

	// Token: 0x040005A9 RID: 1449
	private static readonly IntPtr NativeMethodInfoPtr_GetQuestsByState_Public_List_1_GP_Quest_GP_QuestState_0;

	// Token: 0x040005AA RID: 1450
	private static readonly IntPtr NativeMethodInfoPtr_OnGPQuestAccepted_Private_Void_String_0;

	// Token: 0x040005AB RID: 1451
	private static readonly IntPtr NativeMethodInfoPtr_OnGPQuestCompleted_Private_Void_String_0;

	// Token: 0x040005AC RID: 1452
	private static readonly IntPtr NativeMethodInfoPtr_OnGPQuestUpdated_Private_Void_String_0;

	// Token: 0x040005AD RID: 1453
	private static readonly IntPtr NativeMethodInfoPtr_OnGPQuestsLoaded_Private_Void_String_0;

	// Token: 0x040005AE RID: 1454
	private static readonly IntPtr NativeMethodInfoPtr_UpdateQuestInfo_Private_Void_String_String_String_String_String_String_String_String_String_String_String_String_0;

	// Token: 0x040005AF RID: 1455
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000374 RID: 884
	[ObfuscatedName("GooglePlayQuests+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x060034DE RID: 13534 RVA: 0x000DA4A4 File Offset: 0x000D86A4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayQuests>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr);
			GooglePlayQuests.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr, "<>9");
			GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr, "<>9__20_0");
			GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr, "<>9__20_1");
			GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr, "<>9__20_2");
			GooglePlayQuests.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr, 100670026);
			GooglePlayQuests.__c.NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_GP_QuestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr, 100670027);
			GooglePlayQuests.__c.NativeMethodInfoPtr___ctor_b__20_1_Internal_Void_GP_QuestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr, 100670028);
			GooglePlayQuests.__c.NativeMethodInfoPtr___ctor_b__20_2_Internal_Void_GP_QuestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr, 100670029);
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x000DA570 File Offset: 0x000D8770
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayQuests.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000DA5AC File Offset: 0x000D87AC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__20_0(GP_QuestResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.__c.NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_GP_QuestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x000DA5F0 File Offset: 0x000D87F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__20_1(GP_QuestResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.__c.NativeMethodInfoPtr___ctor_b__20_1_Internal_Void_GP_QuestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x000DA634 File Offset: 0x000D8834
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__20_2(GP_QuestResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayQuests.__c.NativeMethodInfoPtr___ctor_b__20_2_Internal_Void_GP_QuestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00014976 File Offset: 0x00012B76
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x000DA678 File Offset: 0x000D8878
		// (set) Token: 0x060034E5 RID: 13541 RVA: 0x0001497F File Offset: 0x00012B7F
		public unsafe static GooglePlayQuests.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayQuests.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayQuests.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayQuests.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x000DA6A0 File Offset: 0x000D88A0
		// (set) Token: 0x060034E7 RID: 13543 RVA: 0x00014991 File Offset: 0x00012B91
		public unsafe static Action<GP_QuestResult> __9__20_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_QuestResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x000DA6C8 File Offset: 0x000D88C8
		// (set) Token: 0x060034E9 RID: 13545 RVA: 0x000149A3 File Offset: 0x00012BA3
		public unsafe static Action<GP_QuestResult> __9__20_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_QuestResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x000DA6F0 File Offset: 0x000D88F0
		// (set) Token: 0x060034EB RID: 13547 RVA: 0x000149B5 File Offset: 0x00012BB5
		public unsafe static Action<GP_QuestResult> __9__20_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_QuestResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayQuests.__c.NativeFieldInfoPtr___9__20_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030CF RID: 12495
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030D0 RID: 12496
		private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

		// Token: 0x040030D1 RID: 12497
		private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

		// Token: 0x040030D2 RID: 12498
		private static readonly IntPtr NativeFieldInfoPtr___9__20_2;

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_GP_QuestResult_0;

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__20_1_Internal_Void_GP_QuestResult_0;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__20_2_Internal_Void_GP_QuestResult_0;
	}
}
