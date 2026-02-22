using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x020000AE RID: 174
public class ThemeManager : MonoBehaviour
{
	// Token: 0x06001458 RID: 5208 RVA: 0x00057C9C File Offset: 0x00055E9C
	// Note: this type is marked as 'beforefieldinit'.
	static ThemeManager()
	{
		Il2CppClassPointerStore<ThemeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ThemeManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr);
		ThemeManager.NativeFieldInfoPtr_m_bLoadThemesFromResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_bLoadThemesFromResources");
		ThemeManager.NativeFieldInfoPtr_m_themeObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_themeObjects");
		ThemeManager.NativeFieldInfoPtr_m_animatorBooleanVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_animatorBooleanVariableName");
		ThemeManager.NativeFieldInfoPtr_m_animatorTriggerFadeOutVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_animatorTriggerFadeOutVariableName");
		ThemeManager.NativeFieldInfoPtr_m_waitTimeUntilDeletionOfOldObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_waitTimeUntilDeletionOfOldObj");
		ThemeManager.NativeFieldInfoPtr_m_ActiveThemeObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_ActiveThemeObj");
		ThemeManager.NativeFieldInfoPtr_m_OldThemeObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_OldThemeObj");
		ThemeManager.NativeFieldInfoPtr_m_ActiveThemeAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_ActiveThemeAnimator");
		ThemeManager.NativeFieldInfoPtr_m_currentTheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_currentTheme");
		ThemeManager.NativeFieldInfoPtr_m_bOnStartScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "m_bOnStartScreen");
		ThemeManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100664934);
		ThemeManager.NativeMethodInfoPtr_SetThemeObjectsActive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100664935);
		ThemeManager.NativeMethodInfoPtr_SetOnStartScreen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100664936);
		ThemeManager.NativeMethodInfoPtr_Startup_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100664937);
		ThemeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100664938);
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x00057DF8 File Offset: 0x00055FF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245808, XrefRangeEnd = 245815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x00057E2C File Offset: 0x0005602C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 245869, RefRangeEnd = 245871, XrefRangeStart = 245815, XrefRangeEnd = 245869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetThemeObjectsActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager.NativeMethodInfoPtr_SetThemeObjectsActive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x00057E60 File Offset: 0x00056060
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 245881, RefRangeEnd = 245884, XrefRangeStart = 245871, XrefRangeEnd = 245881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOnStartScreen(bool bOnStartScreen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bOnStartScreen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager.NativeMethodInfoPtr_SetOnStartScreen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x00057EA0 File Offset: 0x000560A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245888, RefRangeEnd = 245889, XrefRangeStart = 245884, XrefRangeEnd = 245888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Startup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager.NativeMethodInfoPtr_Startup_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x00057EE0 File Offset: 0x000560E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245889, XrefRangeEnd = 245892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThemeManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x0000D36E File Offset: 0x0000B56E
	public ThemeManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700066E RID: 1646
	// (get) Token: 0x0600145F RID: 5215 RVA: 0x00057F1C File Offset: 0x0005611C
	// (set) Token: 0x06001460 RID: 5216 RVA: 0x0000D377 File Offset: 0x0000B577
	public unsafe bool m_bLoadThemesFromResources
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_bLoadThemesFromResources);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_bLoadThemesFromResources)) = value;
		}
	}

	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x06001461 RID: 5217 RVA: 0x00057F44 File Offset: 0x00056144
	// (set) Token: 0x06001462 RID: 5218 RVA: 0x0000D392 File Offset: 0x0000B592
	public unsafe Il2CppReferenceArray<ThemeManager.Theme> m_themeObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_themeObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ThemeManager.Theme>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_themeObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000670 RID: 1648
	// (get) Token: 0x06001463 RID: 5219 RVA: 0x00057F74 File Offset: 0x00056174
	// (set) Token: 0x06001464 RID: 5220 RVA: 0x0000D3B1 File Offset: 0x0000B5B1
	public unsafe string m_animatorBooleanVariableName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_animatorBooleanVariableName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_animatorBooleanVariableName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000671 RID: 1649
	// (get) Token: 0x06001465 RID: 5221 RVA: 0x00057F9C File Offset: 0x0005619C
	// (set) Token: 0x06001466 RID: 5222 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
	public unsafe string m_animatorTriggerFadeOutVariableName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_animatorTriggerFadeOutVariableName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_animatorTriggerFadeOutVariableName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x06001467 RID: 5223 RVA: 0x00057FC4 File Offset: 0x000561C4
	// (set) Token: 0x06001468 RID: 5224 RVA: 0x0000D3EF File Offset: 0x0000B5EF
	public unsafe float m_waitTimeUntilDeletionOfOldObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_waitTimeUntilDeletionOfOldObj);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_waitTimeUntilDeletionOfOldObj)) = value;
		}
	}

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x06001469 RID: 5225 RVA: 0x00057FEC File Offset: 0x000561EC
	// (set) Token: 0x0600146A RID: 5226 RVA: 0x0000D40A File Offset: 0x0000B60A
	public unsafe GameObject m_ActiveThemeObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_ActiveThemeObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_ActiveThemeObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000674 RID: 1652
	// (get) Token: 0x0600146B RID: 5227 RVA: 0x0005801C File Offset: 0x0005621C
	// (set) Token: 0x0600146C RID: 5228 RVA: 0x0000D429 File Offset: 0x0000B629
	public unsafe GameObject m_OldThemeObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_OldThemeObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_OldThemeObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000675 RID: 1653
	// (get) Token: 0x0600146D RID: 5229 RVA: 0x0005804C File Offset: 0x0005624C
	// (set) Token: 0x0600146E RID: 5230 RVA: 0x0000D448 File Offset: 0x0000B648
	public unsafe Animator m_ActiveThemeAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_ActiveThemeAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_ActiveThemeAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000676 RID: 1654
	// (get) Token: 0x0600146F RID: 5231 RVA: 0x0005807C File Offset: 0x0005627C
	// (set) Token: 0x06001470 RID: 5232 RVA: 0x0000D467 File Offset: 0x0000B667
	public unsafe int m_currentTheme
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_currentTheme);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_currentTheme)) = value;
		}
	}

	// Token: 0x17000677 RID: 1655
	// (get) Token: 0x06001471 RID: 5233 RVA: 0x000580A4 File Offset: 0x000562A4
	// (set) Token: 0x06001472 RID: 5234 RVA: 0x0000D482 File Offset: 0x0000B682
	public unsafe bool m_bOnStartScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_bOnStartScreen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.NativeFieldInfoPtr_m_bOnStartScreen)) = value;
		}
	}

	// Token: 0x04000E2E RID: 3630
	private static readonly IntPtr NativeFieldInfoPtr_m_bLoadThemesFromResources;

	// Token: 0x04000E2F RID: 3631
	private static readonly IntPtr NativeFieldInfoPtr_m_themeObjects;

	// Token: 0x04000E30 RID: 3632
	private static readonly IntPtr NativeFieldInfoPtr_m_animatorBooleanVariableName;

	// Token: 0x04000E31 RID: 3633
	private static readonly IntPtr NativeFieldInfoPtr_m_animatorTriggerFadeOutVariableName;

	// Token: 0x04000E32 RID: 3634
	private static readonly IntPtr NativeFieldInfoPtr_m_waitTimeUntilDeletionOfOldObj;

	// Token: 0x04000E33 RID: 3635
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveThemeObj;

	// Token: 0x04000E34 RID: 3636
	private static readonly IntPtr NativeFieldInfoPtr_m_OldThemeObj;

	// Token: 0x04000E35 RID: 3637
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveThemeAnimator;

	// Token: 0x04000E36 RID: 3638
	private static readonly IntPtr NativeFieldInfoPtr_m_currentTheme;

	// Token: 0x04000E37 RID: 3639
	private static readonly IntPtr NativeFieldInfoPtr_m_bOnStartScreen;

	// Token: 0x04000E38 RID: 3640
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000E39 RID: 3641
	private static readonly IntPtr NativeMethodInfoPtr_SetThemeObjectsActive_Public_Void_0;

	// Token: 0x04000E3A RID: 3642
	private static readonly IntPtr NativeMethodInfoPtr_SetOnStartScreen_Public_Void_Boolean_0;

	// Token: 0x04000E3B RID: 3643
	private static readonly IntPtr NativeMethodInfoPtr_Startup_Private_IEnumerator_0;

	// Token: 0x04000E3C RID: 3644
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001BA RID: 442
	[Serializable]
	public sealed class Theme : ValueType
	{
		// Token: 0x060025D0 RID: 9680 RVA: 0x0008B410 File Offset: 0x00089610
		// Note: this type is marked as 'beforefieldinit'.
		static Theme()
		{
			Il2CppClassPointerStore<ThemeManager.Theme>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "Theme");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeManager.Theme>.NativeClassPtr);
			ThemeManager.Theme.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager.Theme>.NativeClassPtr, "root");
			ThemeManager.Theme.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager.Theme>.NativeClassPtr, "animator");
			ThemeManager.Theme.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager.Theme>.NativeClassPtr, "path");
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00017737 File Offset: 0x00015937
		public Theme(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00017740 File Offset: 0x00015940
		public Theme()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeManager.Theme>.NativeClassPtr))
		{
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x0008B478 File Offset: 0x00089678
		// (set) Token: 0x060025D4 RID: 9684 RVA: 0x00017752 File Offset: 0x00015952
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.Theme.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.Theme.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x0008B4A8 File Offset: 0x000896A8
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x00017771 File Offset: 0x00015971
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.Theme.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.Theme.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x0008B4D8 File Offset: 0x000896D8
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00017790 File Offset: 0x00015990
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.Theme.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager.Theme.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeFieldInfoPtr_path;
	}

	// Token: 0x020001BB RID: 443
	[ObfuscatedName("ThemeManager+<Startup>d__14")]
	public sealed class _Startup_d__14 : global::Il2CppSystem.Object
	{
		// Token: 0x060025D9 RID: 9689 RVA: 0x0008B500 File Offset: 0x00089700
		// Note: this type is marked as 'beforefieldinit'.
		static _Startup_d__14()
		{
			Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "<Startup>d__14");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr);
			ThemeManager._Startup_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, "<>1__state");
			ThemeManager._Startup_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, "<>2__current");
			ThemeManager._Startup_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, "<>4__this");
			ThemeManager._Startup_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, 100666284);
			ThemeManager._Startup_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, 100666285);
			ThemeManager._Startup_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, 100666286);
			ThemeManager._Startup_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, 100666287);
			ThemeManager._Startup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, 100666288);
			ThemeManager._Startup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr, 100666289);
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x0008B5E0 File Offset: 0x000897E0
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Startup_d__14(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeManager._Startup_d__14>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager._Startup_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x0008B628 File Offset: 0x00089828
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager._Startup_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x0008B65C File Offset: 0x0008985C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245800, XrefRangeEnd = 245803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager._Startup_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x0008B698 File Offset: 0x00089898
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager._Startup_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x0008B6D8 File Offset: 0x000898D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245803, XrefRangeEnd = 245808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager._Startup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x0008B70C File Offset: 0x0008990C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeManager._Startup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x000177AF File Offset: 0x000159AF
		public _Startup_d__14(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x0008B74C File Offset: 0x0008994C
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x000177B8 File Offset: 0x000159B8
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager._Startup_d__14.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager._Startup_d__14.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x0008B774 File Offset: 0x00089974
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x000177D3 File Offset: 0x000159D3
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager._Startup_d__14.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager._Startup_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x0008B7A4 File Offset: 0x000899A4
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x000177F2 File Offset: 0x000159F2
		public unsafe ThemeManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager._Startup_d__14.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeManager._Startup_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
