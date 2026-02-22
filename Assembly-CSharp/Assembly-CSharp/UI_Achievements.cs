using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000C7 RID: 199
public class UI_Achievements : MonoBehaviour
{
	// Token: 0x060017D6 RID: 6102 RVA: 0x00062018 File Offset: 0x00060218
	// Note: this type is marked as 'beforefieldinit'.
	static UI_Achievements()
	{
		Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_Achievements");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr);
		UI_Achievements.NativeFieldInfoPtr_m_achievementSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_achievementSlotPrefab");
		UI_Achievements.NativeFieldInfoPtr_m_contentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_contentContainer");
		UI_Achievements.NativeFieldInfoPtr_m_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_scrollView");
		UI_Achievements.NativeFieldInfoPtr_m_setToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_setToggles");
		UI_Achievements.NativeFieldInfoPtr_m_setCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_setCounts");
		UI_Achievements.NativeFieldInfoPtr_m_textUnachievedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_textUnachievedColor");
		UI_Achievements.NativeFieldInfoPtr_m_textAchievedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_textAchievedColor");
		UI_Achievements.NativeFieldInfoPtr_m_achievementManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_achievementManager");
		UI_Achievements.NativeFieldInfoPtr_m_achievementSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, "m_achievementSlots");
		UI_Achievements.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, 100665201);
		UI_Achievements.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, 100665202);
		UI_Achievements.NativeMethodInfoPtr_HandleToggles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, 100665203);
		UI_Achievements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr, 100665204);
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x0006214C File Offset: 0x0006034C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248614, XrefRangeEnd = 248696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Achievements.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x00062180 File Offset: 0x00060380
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248696, XrefRangeEnd = 248709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Achievements.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x000621C0 File Offset: 0x000603C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 248728, RefRangeEnd = 248729, XrefRangeStart = 248709, XrefRangeEnd = 248728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleToggles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Achievements.NativeMethodInfoPtr_HandleToggles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x000621F4 File Offset: 0x000603F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248729, XrefRangeEnd = 248732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_Achievements()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Achievements>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Achievements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x0000F56A File Offset: 0x0000D76A
	public UI_Achievements(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000794 RID: 1940
	// (get) Token: 0x060017DC RID: 6108 RVA: 0x00062230 File Offset: 0x00060430
	// (set) Token: 0x060017DD RID: 6109 RVA: 0x0000F573 File Offset: 0x0000D773
	public unsafe GameObject m_achievementSlotPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_achievementSlotPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_achievementSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000795 RID: 1941
	// (get) Token: 0x060017DE RID: 6110 RVA: 0x00062260 File Offset: 0x00060460
	// (set) Token: 0x060017DF RID: 6111 RVA: 0x0000F592 File Offset: 0x0000D792
	public unsafe Transform m_contentContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_contentContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_contentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000796 RID: 1942
	// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00062290 File Offset: 0x00060490
	// (set) Token: 0x060017E1 RID: 6113 RVA: 0x0000F5B1 File Offset: 0x0000D7B1
	public unsafe ScrollRect m_scrollView
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_scrollView);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_scrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000797 RID: 1943
	// (get) Token: 0x060017E2 RID: 6114 RVA: 0x000622C0 File Offset: 0x000604C0
	// (set) Token: 0x060017E3 RID: 6115 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
	public unsafe Il2CppReferenceArray<Toggle> m_setToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_setToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_setToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000798 RID: 1944
	// (get) Token: 0x060017E4 RID: 6116 RVA: 0x000622F0 File Offset: 0x000604F0
	// (set) Token: 0x060017E5 RID: 6117 RVA: 0x0000F5EF File Offset: 0x0000D7EF
	public unsafe Il2CppReferenceArray<TextMeshProUGUI> m_setCounts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_setCounts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_setCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000799 RID: 1945
	// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00062320 File Offset: 0x00060520
	// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000F60E File Offset: 0x0000D80E
	public unsafe Color m_textUnachievedColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_textUnachievedColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_textUnachievedColor)) = value;
		}
	}

	// Token: 0x1700079A RID: 1946
	// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00062348 File Offset: 0x00060548
	// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0000F629 File Offset: 0x0000D829
	public unsafe Color m_textAchievedColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_textAchievedColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_textAchievedColor)) = value;
		}
	}

	// Token: 0x1700079B RID: 1947
	// (get) Token: 0x060017EA RID: 6122 RVA: 0x00062370 File Offset: 0x00060570
	// (set) Token: 0x060017EB RID: 6123 RVA: 0x0000F644 File Offset: 0x0000D844
	public unsafe AchievementManagerWrapper m_achievementManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_achievementManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManagerWrapper>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_achievementManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700079C RID: 1948
	// (get) Token: 0x060017EC RID: 6124 RVA: 0x000623A0 File Offset: 0x000605A0
	// (set) Token: 0x060017ED RID: 6125 RVA: 0x0000F663 File Offset: 0x0000D863
	public unsafe List<UIP_AchievementSlot> m_achievementSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_achievementSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIP_AchievementSlot>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Achievements.NativeFieldInfoPtr_m_achievementSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001057 RID: 4183
	private static readonly IntPtr NativeFieldInfoPtr_m_achievementSlotPrefab;

	// Token: 0x04001058 RID: 4184
	private static readonly IntPtr NativeFieldInfoPtr_m_contentContainer;

	// Token: 0x04001059 RID: 4185
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollView;

	// Token: 0x0400105A RID: 4186
	private static readonly IntPtr NativeFieldInfoPtr_m_setToggles;

	// Token: 0x0400105B RID: 4187
	private static readonly IntPtr NativeFieldInfoPtr_m_setCounts;

	// Token: 0x0400105C RID: 4188
	private static readonly IntPtr NativeFieldInfoPtr_m_textUnachievedColor;

	// Token: 0x0400105D RID: 4189
	private static readonly IntPtr NativeFieldInfoPtr_m_textAchievedColor;

	// Token: 0x0400105E RID: 4190
	private static readonly IntPtr NativeFieldInfoPtr_m_achievementManager;

	// Token: 0x0400105F RID: 4191
	private static readonly IntPtr NativeFieldInfoPtr_m_achievementSlots;

	// Token: 0x04001060 RID: 4192
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x04001061 RID: 4193
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x04001062 RID: 4194
	private static readonly IntPtr NativeMethodInfoPtr_HandleToggles_Public_Void_0;

	// Token: 0x04001063 RID: 4195
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
