using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000DC RID: 220
public class UI_Rulebook : UI_FrontEndAndInGameScene
{
	// Token: 0x06001B56 RID: 6998 RVA: 0x0006C0B8 File Offset: 0x0006A2B8
	// Note: this type is marked as 'beforefieldinit'.
	static UI_Rulebook()
	{
		Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_Rulebook");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr);
		UI_Rulebook.NativeFieldInfoPtr_m_setToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "m_setToggles");
		UI_Rulebook.NativeFieldInfoPtr_m_rulebookNodePaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "m_rulebookNodePaths");
		UI_Rulebook.NativeFieldInfoPtr_m_contentHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "m_contentHolder");
		UI_Rulebook.NativeFieldInfoPtr_m_loadingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "m_loadingScreen");
		UI_Rulebook.NativeFieldInfoPtr_m_currentRulebook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "m_currentRulebook");
		UI_Rulebook.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "m_bIgnoreToggles");
		UI_Rulebook.NativeFieldInfoPtr_m_currentSetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "m_currentSetIndex");
		UI_Rulebook.NativeFieldInfoPtr_m_oldSetFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "m_oldSetFlags");
		UI_Rulebook.NativeMethodInfoPtr_OnMenuEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, 100665455);
		UI_Rulebook.NativeMethodInfoPtr_OnMenuExit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, 100665456);
		UI_Rulebook.NativeMethodInfoPtr_ClearRulebookObj_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, 100665457);
		UI_Rulebook.NativeMethodInfoPtr_RebuildRulebookObj_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, 100665458);
		UI_Rulebook.NativeMethodInfoPtr_RebuildRulebookObjAsync_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, 100665459);
		UI_Rulebook.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, 100665460);
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x0006C200 File Offset: 0x0006A400
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252861, XrefRangeEnd = 252910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMenuEnter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook.NativeMethodInfoPtr_OnMenuEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x0006C234 File Offset: 0x0006A434
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252910, XrefRangeEnd = 252918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMenuExit(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook.NativeMethodInfoPtr_OnMenuExit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x0006C274 File Offset: 0x0006A474
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 252925, RefRangeEnd = 252926, XrefRangeStart = 252918, XrefRangeEnd = 252925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearRulebookObj()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook.NativeMethodInfoPtr_ClearRulebookObj_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x0006C2A8 File Offset: 0x0006A4A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252926, XrefRangeEnd = 252931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildRulebookObj()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook.NativeMethodInfoPtr_RebuildRulebookObj_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x0006C2DC File Offset: 0x0006A4DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252931, XrefRangeEnd = 252935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RebuildRulebookObjAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook.NativeMethodInfoPtr_RebuildRulebookObjAsync_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x0006C31C File Offset: 0x0006A51C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252935, XrefRangeEnd = 252936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_Rulebook()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x000118FB File Offset: 0x0000FAFB
	public UI_Rulebook(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170008C0 RID: 2240
	// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0006C358 File Offset: 0x0006A558
	// (set) Token: 0x06001B5F RID: 7007 RVA: 0x00011904 File Offset: 0x0000FB04
	public unsafe Il2CppReferenceArray<Toggle> m_setToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_setToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_setToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C1 RID: 2241
	// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0006C388 File Offset: 0x0006A588
	// (set) Token: 0x06001B61 RID: 7009 RVA: 0x00011923 File Offset: 0x0000FB23
	public unsafe Il2CppStringArray m_rulebookNodePaths
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_rulebookNodePaths);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_rulebookNodePaths), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C2 RID: 2242
	// (get) Token: 0x06001B62 RID: 7010 RVA: 0x0006C3B8 File Offset: 0x0006A5B8
	// (set) Token: 0x06001B63 RID: 7011 RVA: 0x00011942 File Offset: 0x0000FB42
	public unsafe GameObject m_contentHolder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_contentHolder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_contentHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C3 RID: 2243
	// (get) Token: 0x06001B64 RID: 7012 RVA: 0x0006C3E8 File Offset: 0x0006A5E8
	// (set) Token: 0x06001B65 RID: 7013 RVA: 0x00011961 File Offset: 0x0000FB61
	public unsafe GameObject m_loadingScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_loadingScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_loadingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C4 RID: 2244
	// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0006C418 File Offset: 0x0006A618
	// (set) Token: 0x06001B67 RID: 7015 RVA: 0x00011980 File Offset: 0x0000FB80
	public unsafe GameObject m_currentRulebook
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_currentRulebook);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_currentRulebook), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C5 RID: 2245
	// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0006C448 File Offset: 0x0006A648
	// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0001199F File Offset: 0x0000FB9F
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x170008C6 RID: 2246
	// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0006C470 File Offset: 0x0006A670
	// (set) Token: 0x06001B6B RID: 7019 RVA: 0x000119BA File Offset: 0x0000FBBA
	public unsafe int m_currentSetIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_currentSetIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_currentSetIndex)) = value;
		}
	}

	// Token: 0x170008C7 RID: 2247
	// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0006C498 File Offset: 0x0006A698
	// (set) Token: 0x06001B6D RID: 7021 RVA: 0x000119D5 File Offset: 0x0000FBD5
	public unsafe int m_oldSetFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_oldSetFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook.NativeFieldInfoPtr_m_oldSetFlags)) = value;
		}
	}

	// Token: 0x04001281 RID: 4737
	private static readonly IntPtr NativeFieldInfoPtr_m_setToggles;

	// Token: 0x04001282 RID: 4738
	private static readonly IntPtr NativeFieldInfoPtr_m_rulebookNodePaths;

	// Token: 0x04001283 RID: 4739
	private static readonly IntPtr NativeFieldInfoPtr_m_contentHolder;

	// Token: 0x04001284 RID: 4740
	private static readonly IntPtr NativeFieldInfoPtr_m_loadingScreen;

	// Token: 0x04001285 RID: 4741
	private static readonly IntPtr NativeFieldInfoPtr_m_currentRulebook;

	// Token: 0x04001286 RID: 4742
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x04001287 RID: 4743
	private static readonly IntPtr NativeFieldInfoPtr_m_currentSetIndex;

	// Token: 0x04001288 RID: 4744
	private static readonly IntPtr NativeFieldInfoPtr_m_oldSetFlags;

	// Token: 0x04001289 RID: 4745
	private static readonly IntPtr NativeMethodInfoPtr_OnMenuEnter_Public_Void_0;

	// Token: 0x0400128A RID: 4746
	private static readonly IntPtr NativeMethodInfoPtr_OnMenuExit_Public_Void_Boolean_0;

	// Token: 0x0400128B RID: 4747
	private static readonly IntPtr NativeMethodInfoPtr_ClearRulebookObj_Public_Void_0;

	// Token: 0x0400128C RID: 4748
	private static readonly IntPtr NativeMethodInfoPtr_RebuildRulebookObj_Public_Void_0;

	// Token: 0x0400128D RID: 4749
	private static readonly IntPtr NativeMethodInfoPtr_RebuildRulebookObjAsync_Private_IEnumerator_0;

	// Token: 0x0400128E RID: 4750
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000204 RID: 516
	[ObfuscatedName("UI_Rulebook+<RebuildRulebookObjAsync>d__12")]
	public sealed class _RebuildRulebookObjAsync_d__12 : global::Il2CppSystem.Object
	{
		// Token: 0x060028FA RID: 10490 RVA: 0x00093E38 File Offset: 0x00092038
		// Note: this type is marked as 'beforefieldinit'.
		static _RebuildRulebookObjAsync_d__12()
		{
			Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_Rulebook>.NativeClassPtr, "<RebuildRulebookObjAsync>d__12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr);
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, "<>1__state");
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, "<>2__current");
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, "<>4__this");
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr__setFlags_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, "<setFlags>5__2");
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr__request_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, "<request>5__3");
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, 100666516);
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, 100666517);
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, 100666518);
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, 100666519);
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, 100666520);
			UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr, 100666521);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00093F40 File Offset: 0x00092140
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _RebuildRulebookObjAsync_d__12(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Rulebook._RebuildRulebookObjAsync_d__12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00093F88 File Offset: 0x00092188
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x00093FBC File Offset: 0x000921BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252844, XrefRangeEnd = 252856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x00093FF8 File Offset: 0x000921F8
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00094038 File Offset: 0x00092238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252856, XrefRangeEnd = 252861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x0009406C File Offset: 0x0009226C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0001941A File Offset: 0x0001761A
		public _RebuildRulebookObjAsync_d__12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x000940AC File Offset: 0x000922AC
		// (set) Token: 0x06002903 RID: 10499 RVA: 0x00019423 File Offset: 0x00017623
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x000940D4 File Offset: 0x000922D4
		// (set) Token: 0x06002905 RID: 10501 RVA: 0x0001943E File Offset: 0x0001763E
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x00094104 File Offset: 0x00092304
		// (set) Token: 0x06002907 RID: 10503 RVA: 0x0001945D File Offset: 0x0001765D
		public unsafe UI_Rulebook __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_Rulebook>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x00094134 File Offset: 0x00092334
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x0001947C File Offset: 0x0001767C
		public unsafe int _setFlags_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr__setFlags_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr__setFlags_5__2)) = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x0009415C File Offset: 0x0009235C
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x00019497 File Offset: 0x00017697
		public unsafe ResourceRequest _request_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr__request_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Rulebook._RebuildRulebookObjAsync_d__12.NativeFieldInfoPtr__request_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeFieldInfoPtr__setFlags_5__2;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeFieldInfoPtr__request_5__3;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
