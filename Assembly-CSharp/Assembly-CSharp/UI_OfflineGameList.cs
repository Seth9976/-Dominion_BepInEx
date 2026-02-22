using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x020000D5 RID: 213
public class UI_OfflineGameList : MonoBehaviour
{
	// Token: 0x060019CC RID: 6604 RVA: 0x00067714 File Offset: 0x00065914
	// Note: this type is marked as 'beforefieldinit'.
	static UI_OfflineGameList()
	{
		Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_OfflineGameList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr);
		UI_OfflineGameList.NativeFieldInfoPtr_m_gameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, "m_gameList");
		UI_OfflineGameList.NativeFieldInfoPtr_m_startGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, "m_startGame");
		UI_OfflineGameList.NativeFieldInfoPtr_m_DeleteGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, "m_DeleteGame");
		UI_OfflineGameList.NativeFieldInfoPtr_m_confirmSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, "m_confirmSlot");
		UI_OfflineGameList.NativeFieldInfoPtr_m_bIgnoreNextEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, "m_bIgnoreNextEnter");
		UI_OfflineGameList.NativeFieldInfoPtr_m_lastGameSlotSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, "m_lastGameSlotSelected");
		UI_OfflineGameList.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, 100665331);
		UI_OfflineGameList.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, 100665332);
		UI_OfflineGameList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, 100665333);
		UI_OfflineGameList.NativeMethodInfoPtr_OnConfirmPopupPressed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, 100665334);
		UI_OfflineGameList.NativeMethodInfoPtr_StartTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, 100665335);
		UI_OfflineGameList.NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, 100665336);
		UI_OfflineGameList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, 100665337);
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x00067848 File Offset: 0x00065A48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250949, XrefRangeEnd = 250966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x0006787C File Offset: 0x00065A7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250966, XrefRangeEnd = 250967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x000678BC File Offset: 0x00065ABC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250967, XrefRangeEnd = 251033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x0006790C File Offset: 0x00065B0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251033, XrefRangeEnd = 251036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConfirmPopupPressed(bool bConfirm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList.NativeMethodInfoPtr_OnConfirmPopupPressed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x0006794C File Offset: 0x00065B4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251036, XrefRangeEnd = 251081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList.NativeMethodInfoPtr_StartTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019D2 RID: 6610 RVA: 0x00067980 File Offset: 0x00065B80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251081, XrefRangeEnd = 251085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator HandleSoakTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList.NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x000679C0 File Offset: 0x00065BC0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_OfflineGameList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x000109C6 File Offset: 0x0000EBC6
	public UI_OfflineGameList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000840 RID: 2112
	// (get) Token: 0x060019D5 RID: 6613 RVA: 0x000679FC File Offset: 0x00065BFC
	// (set) Token: 0x060019D6 RID: 6614 RVA: 0x000109CF File Offset: 0x0000EBCF
	public unsafe UIC_OfflineGameList m_gameList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_gameList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OfflineGameList>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_gameList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000841 RID: 2113
	// (get) Token: 0x060019D7 RID: 6615 RVA: 0x00067A2C File Offset: 0x00065C2C
	// (set) Token: 0x060019D8 RID: 6616 RVA: 0x000109EE File Offset: 0x0000EBEE
	public unsafe AudioSource m_startGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_startGame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_startGame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000842 RID: 2114
	// (get) Token: 0x060019D9 RID: 6617 RVA: 0x00067A5C File Offset: 0x00065C5C
	// (set) Token: 0x060019DA RID: 6618 RVA: 0x00010A0D File Offset: 0x0000EC0D
	public unsafe AudioSource m_DeleteGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_DeleteGame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_DeleteGame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000843 RID: 2115
	// (get) Token: 0x060019DB RID: 6619 RVA: 0x00067A8C File Offset: 0x00065C8C
	// (set) Token: 0x060019DC RID: 6620 RVA: 0x00010A2C File Offset: 0x0000EC2C
	public unsafe int m_confirmSlot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_confirmSlot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_confirmSlot)) = value;
		}
	}

	// Token: 0x17000844 RID: 2116
	// (get) Token: 0x060019DD RID: 6621 RVA: 0x00067AB4 File Offset: 0x00065CB4
	// (set) Token: 0x060019DE RID: 6622 RVA: 0x00010A47 File Offset: 0x0000EC47
	public unsafe bool m_bIgnoreNextEnter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_bIgnoreNextEnter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_bIgnoreNextEnter)) = value;
		}
	}

	// Token: 0x17000845 RID: 2117
	// (get) Token: 0x060019DF RID: 6623 RVA: 0x00067ADC File Offset: 0x00065CDC
	// (set) Token: 0x060019E0 RID: 6624 RVA: 0x00010A62 File Offset: 0x0000EC62
	public unsafe UIP_GameSlot m_lastGameSlotSelected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_lastGameSlotSelected);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_GameSlot>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList.NativeFieldInfoPtr_m_lastGameSlotSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001185 RID: 4485
	private static readonly IntPtr NativeFieldInfoPtr_m_gameList;

	// Token: 0x04001186 RID: 4486
	private static readonly IntPtr NativeFieldInfoPtr_m_startGame;

	// Token: 0x04001187 RID: 4487
	private static readonly IntPtr NativeFieldInfoPtr_m_DeleteGame;

	// Token: 0x04001188 RID: 4488
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmSlot;

	// Token: 0x04001189 RID: 4489
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreNextEnter;

	// Token: 0x0400118A RID: 4490
	private static readonly IntPtr NativeFieldInfoPtr_m_lastGameSlotSelected;

	// Token: 0x0400118B RID: 4491
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x0400118C RID: 4492
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x0400118D RID: 4493
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0;

	// Token: 0x0400118E RID: 4494
	private static readonly IntPtr NativeMethodInfoPtr_OnConfirmPopupPressed_Public_Void_Boolean_0;

	// Token: 0x0400118F RID: 4495
	private static readonly IntPtr NativeMethodInfoPtr_StartTutorial_Public_Void_0;

	// Token: 0x04001190 RID: 4496
	private static readonly IntPtr NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0;

	// Token: 0x04001191 RID: 4497
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001F8 RID: 504
	[ObfuscatedName("UI_OfflineGameList+<HandleSoakTest>d__11")]
	public sealed class _HandleSoakTest_d__11 : global::Il2CppSystem.Object
	{
		// Token: 0x06002845 RID: 10309 RVA: 0x00091E9C File Offset: 0x0009009C
		// Note: this type is marked as 'beforefieldinit'.
		static _HandleSoakTest_d__11()
		{
			Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OfflineGameList>.NativeClassPtr, "<HandleSoakTest>d__11");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr);
			UI_OfflineGameList._HandleSoakTest_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr, "<>1__state");
			UI_OfflineGameList._HandleSoakTest_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr, "<>2__current");
			UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr, 100666462);
			UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr, 100666463);
			UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr, 100666464);
			UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr, 100666465);
			UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr, 100666466);
			UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr, 100666467);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00091F68 File Offset: 0x00090168
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _HandleSoakTest_d__11(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OfflineGameList._HandleSoakTest_d__11>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00091FB0 File Offset: 0x000901B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00091FE4 File Offset: 0x000901E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250937, XrefRangeEnd = 250944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x00092020 File Offset: 0x00090220
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00092060 File Offset: 0x00090260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250944, XrefRangeEnd = 250949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x00092094 File Offset: 0x00090294
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineGameList._HandleSoakTest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00018DC6 File Offset: 0x00016FC6
		public _HandleSoakTest_d__11(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600284D RID: 10317 RVA: 0x000920D4 File Offset: 0x000902D4
		// (set) Token: 0x0600284E RID: 10318 RVA: 0x00018DCF File Offset: 0x00016FCF
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList._HandleSoakTest_d__11.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList._HandleSoakTest_d__11.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x000920FC File Offset: 0x000902FC
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x00018DEA File Offset: 0x00016FEA
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList._HandleSoakTest_d__11.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineGameList._HandleSoakTest_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
