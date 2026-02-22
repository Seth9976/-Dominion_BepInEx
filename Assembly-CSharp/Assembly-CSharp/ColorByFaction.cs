using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200009F RID: 159
public class ColorByFaction : MonoBehaviour
{
	// Token: 0x060012D4 RID: 4820 RVA: 0x00052E40 File Offset: 0x00051040
	// Note: this type is marked as 'beforefieldinit'.
	static ColorByFaction()
	{
		Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ColorByFaction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr);
		ColorByFaction.NativeFieldInfoPtr_m_RecolorImageTextEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_RecolorImageTextEntries");
		ColorByFaction.NativeFieldInfoPtr_m_RecolorButtonEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_RecolorButtonEntries");
		ColorByFaction.NativeFieldInfoPtr_m_ImageReplacementEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_ImageReplacementEntries");
		ColorByFaction.NativeFieldInfoPtr_m_AnimatorReplacementEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_AnimatorReplacementEntries");
		ColorByFaction.NativeFieldInfoPtr_m_TimeInSecondsToBlendThemes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_TimeInSecondsToBlendThemes");
		ColorByFaction.NativeFieldInfoPtr_m_startupAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_startupAction");
		ColorByFaction.NativeFieldInfoPtr_m_startupColorizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_startupColorizeValue");
		ColorByFaction.NativeFieldInfoPtr_m_oldTheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_oldTheme");
		ColorByFaction.NativeFieldInfoPtr_m_newTheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_newTheme");
		ColorByFaction.NativeFieldInfoPtr_m_bColorizeThemeLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_bColorizeThemeLerp");
		ColorByFaction.NativeFieldInfoPtr_m_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "m_currentTime");
		ColorByFaction.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, 100664781);
		ColorByFaction.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, 100664782);
		ColorByFaction.NativeMethodInfoPtr_ColorizeOverTime_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, 100664783);
		ColorByFaction.NativeMethodInfoPtr_ColorizeByTheme_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, 100664784);
		ColorByFaction.NativeMethodInfoPtr_Colorize_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, 100664785);
		ColorByFaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, 100664786);
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x00052FC4 File Offset: 0x000511C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243899, XrefRangeEnd = 243904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x00052FF8 File Offset: 0x000511F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243904, XrefRangeEnd = 243945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x0005302C File Offset: 0x0005122C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243954, RefRangeEnd = 243955, XrefRangeStart = 243945, XrefRangeEnd = 243954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ColorizeOverTime(uint newTheme)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref newTheme;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.NativeMethodInfoPtr_ColorizeOverTime_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0005306C File Offset: 0x0005126C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 243959, RefRangeEnd = 243964, XrefRangeStart = 243955, XrefRangeEnd = 243959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ColorizeByTheme()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.NativeMethodInfoPtr_ColorizeByTheme_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x000530A0 File Offset: 0x000512A0
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 243997, RefRangeEnd = 244004, XrefRangeStart = 243964, XrefRangeEnd = 243997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Colorize(uint factionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref factionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.NativeMethodInfoPtr_Colorize_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x000530E0 File Offset: 0x000512E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244004, XrefRangeEnd = 244005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColorByFaction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0000C73B File Offset: 0x0000A93B
	public ColorByFaction(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000603 RID: 1539
	// (get) Token: 0x060012DC RID: 4828 RVA: 0x0005311C File Offset: 0x0005131C
	// (set) Token: 0x060012DD RID: 4829 RVA: 0x0000C744 File Offset: 0x0000A944
	public unsafe Il2CppReferenceArray<ColorByFaction.ColorizeImageTextEntry> m_RecolorImageTextEntries
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_RecolorImageTextEntries);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ColorByFaction.ColorizeImageTextEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_RecolorImageTextEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000604 RID: 1540
	// (get) Token: 0x060012DE RID: 4830 RVA: 0x0005314C File Offset: 0x0005134C
	// (set) Token: 0x060012DF RID: 4831 RVA: 0x0000C763 File Offset: 0x0000A963
	public unsafe Il2CppReferenceArray<ColorByFaction.ColorizeButtonEntry> m_RecolorButtonEntries
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_RecolorButtonEntries);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ColorByFaction.ColorizeButtonEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_RecolorButtonEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000605 RID: 1541
	// (get) Token: 0x060012E0 RID: 4832 RVA: 0x0005317C File Offset: 0x0005137C
	// (set) Token: 0x060012E1 RID: 4833 RVA: 0x0000C782 File Offset: 0x0000A982
	public unsafe Il2CppReferenceArray<ColorByFaction.ImageReplacementEntry> m_ImageReplacementEntries
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_ImageReplacementEntries);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ColorByFaction.ImageReplacementEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_ImageReplacementEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000606 RID: 1542
	// (get) Token: 0x060012E2 RID: 4834 RVA: 0x000531AC File Offset: 0x000513AC
	// (set) Token: 0x060012E3 RID: 4835 RVA: 0x0000C7A1 File Offset: 0x0000A9A1
	public unsafe Il2CppReferenceArray<ColorByFaction.AnimatorReplacementEntry> m_AnimatorReplacementEntries
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_AnimatorReplacementEntries);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ColorByFaction.AnimatorReplacementEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_AnimatorReplacementEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000607 RID: 1543
	// (get) Token: 0x060012E4 RID: 4836 RVA: 0x000531DC File Offset: 0x000513DC
	// (set) Token: 0x060012E5 RID: 4837 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
	public unsafe float m_TimeInSecondsToBlendThemes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_TimeInSecondsToBlendThemes);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_TimeInSecondsToBlendThemes)) = value;
		}
	}

	// Token: 0x17000608 RID: 1544
	// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00053204 File Offset: 0x00051404
	// (set) Token: 0x060012E7 RID: 4839 RVA: 0x0000C7DB File Offset: 0x0000A9DB
	public unsafe ColorByFaction.StartupFunction m_startupAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_startupAction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_startupAction)) = value;
		}
	}

	// Token: 0x17000609 RID: 1545
	// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0005322C File Offset: 0x0005142C
	// (set) Token: 0x060012E9 RID: 4841 RVA: 0x0000C7F6 File Offset: 0x0000A9F6
	public unsafe uint m_startupColorizeValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_startupColorizeValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_startupColorizeValue)) = value;
		}
	}

	// Token: 0x1700060A RID: 1546
	// (get) Token: 0x060012EA RID: 4842 RVA: 0x00053254 File Offset: 0x00051454
	// (set) Token: 0x060012EB RID: 4843 RVA: 0x0000C811 File Offset: 0x0000AA11
	public unsafe uint m_oldTheme
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_oldTheme);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_oldTheme)) = value;
		}
	}

	// Token: 0x1700060B RID: 1547
	// (get) Token: 0x060012EC RID: 4844 RVA: 0x0005327C File Offset: 0x0005147C
	// (set) Token: 0x060012ED RID: 4845 RVA: 0x0000C82C File Offset: 0x0000AA2C
	public unsafe uint m_newTheme
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_newTheme);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_newTheme)) = value;
		}
	}

	// Token: 0x1700060C RID: 1548
	// (get) Token: 0x060012EE RID: 4846 RVA: 0x000532A4 File Offset: 0x000514A4
	// (set) Token: 0x060012EF RID: 4847 RVA: 0x0000C847 File Offset: 0x0000AA47
	public unsafe bool m_bColorizeThemeLerp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_bColorizeThemeLerp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_bColorizeThemeLerp)) = value;
		}
	}

	// Token: 0x1700060D RID: 1549
	// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000532CC File Offset: 0x000514CC
	// (set) Token: 0x060012F1 RID: 4849 RVA: 0x0000C862 File Offset: 0x0000AA62
	public unsafe float m_currentTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_currentTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.NativeFieldInfoPtr_m_currentTime)) = value;
		}
	}

	// Token: 0x04000D2A RID: 3370
	private static readonly IntPtr NativeFieldInfoPtr_m_RecolorImageTextEntries;

	// Token: 0x04000D2B RID: 3371
	private static readonly IntPtr NativeFieldInfoPtr_m_RecolorButtonEntries;

	// Token: 0x04000D2C RID: 3372
	private static readonly IntPtr NativeFieldInfoPtr_m_ImageReplacementEntries;

	// Token: 0x04000D2D RID: 3373
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimatorReplacementEntries;

	// Token: 0x04000D2E RID: 3374
	private static readonly IntPtr NativeFieldInfoPtr_m_TimeInSecondsToBlendThemes;

	// Token: 0x04000D2F RID: 3375
	private static readonly IntPtr NativeFieldInfoPtr_m_startupAction;

	// Token: 0x04000D30 RID: 3376
	private static readonly IntPtr NativeFieldInfoPtr_m_startupColorizeValue;

	// Token: 0x04000D31 RID: 3377
	private static readonly IntPtr NativeFieldInfoPtr_m_oldTheme;

	// Token: 0x04000D32 RID: 3378
	private static readonly IntPtr NativeFieldInfoPtr_m_newTheme;

	// Token: 0x04000D33 RID: 3379
	private static readonly IntPtr NativeFieldInfoPtr_m_bColorizeThemeLerp;

	// Token: 0x04000D34 RID: 3380
	private static readonly IntPtr NativeFieldInfoPtr_m_currentTime;

	// Token: 0x04000D35 RID: 3381
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000D36 RID: 3382
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000D37 RID: 3383
	private static readonly IntPtr NativeMethodInfoPtr_ColorizeOverTime_Public_Void_UInt32_0;

	// Token: 0x04000D38 RID: 3384
	private static readonly IntPtr NativeMethodInfoPtr_ColorizeByTheme_Public_Void_0;

	// Token: 0x04000D39 RID: 3385
	private static readonly IntPtr NativeMethodInfoPtr_Colorize_Public_Void_UInt32_0;

	// Token: 0x04000D3A RID: 3386
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001A4 RID: 420
	[Serializable]
	public class ColorizeImageTextEntry : global::Il2CppSystem.Object
	{
		// Token: 0x060024FC RID: 9468 RVA: 0x0008923C File Offset: 0x0008743C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorizeImageTextEntry()
		{
			Il2CppClassPointerStore<ColorByFaction.ColorizeImageTextEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "ColorizeImageTextEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorByFaction.ColorizeImageTextEntry>.NativeClassPtr);
			ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_Faction_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.ColorizeImageTextEntry>.NativeClassPtr, "Faction_colors");
			ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_images = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.ColorizeImageTextEntry>.NativeClassPtr, "images");
			ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_textFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.ColorizeImageTextEntry>.NativeClassPtr, "textFields");
			ColorByFaction.ColorizeImageTextEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction.ColorizeImageTextEntry>.NativeClassPtr, 100666236);
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000892B8 File Offset: 0x000874B8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorizeImageTextEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorByFaction.ColorizeImageTextEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.ColorizeImageTextEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00016F04 File Offset: 0x00015104
		public ColorizeImageTextEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000892F4 File Offset: 0x000874F4
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x00016F0D File Offset: 0x0001510D
		public unsafe Il2CppStructArray<Color> Faction_colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_Faction_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_Faction_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x00089324 File Offset: 0x00087524
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x00016F2C File Offset: 0x0001512C
		public unsafe Il2CppReferenceArray<Image> images
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_images);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_images), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x00089354 File Offset: 0x00087554
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x00016F4B File Offset: 0x0001514B
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> textFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_textFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeImageTextEntry.NativeFieldInfoPtr_textFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeFieldInfoPtr_Faction_colors;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeFieldInfoPtr_images;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeFieldInfoPtr_textFields;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001A5 RID: 421
	[Serializable]
	public class ColorizeButtonEntry : global::Il2CppSystem.Object
	{
		// Token: 0x06002505 RID: 9477 RVA: 0x00089384 File Offset: 0x00087584
		// Note: this type is marked as 'beforefieldinit'.
		static ColorizeButtonEntry()
		{
			Il2CppClassPointerStore<ColorByFaction.ColorizeButtonEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "ColorizeButtonEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorByFaction.ColorizeButtonEntry>.NativeClassPtr);
			ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_Faction_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.ColorizeButtonEntry>.NativeClassPtr, "Faction_colors");
			ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.ColorizeButtonEntry>.NativeClassPtr, "buttons");
			ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.ColorizeButtonEntry>.NativeClassPtr, "toggles");
			ColorByFaction.ColorizeButtonEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction.ColorizeButtonEntry>.NativeClassPtr, 100666237);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00089400 File Offset: 0x00087600
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorizeButtonEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorByFaction.ColorizeButtonEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.ColorizeButtonEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00016F6A File Offset: 0x0001516A
		public ColorizeButtonEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x0008943C File Offset: 0x0008763C
		// (set) Token: 0x06002509 RID: 9481 RVA: 0x00016F73 File Offset: 0x00015173
		public unsafe Il2CppStructArray<ColorBlock> Faction_colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_Faction_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ColorBlock>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_Faction_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x0008946C File Offset: 0x0008766C
		// (set) Token: 0x0600250B RID: 9483 RVA: 0x00016F92 File Offset: 0x00015192
		public unsafe Il2CppReferenceArray<Button> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x0008949C File Offset: 0x0008769C
		// (set) Token: 0x0600250D RID: 9485 RVA: 0x00016FB1 File Offset: 0x000151B1
		public unsafe Il2CppReferenceArray<Toggle> toggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_toggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ColorizeButtonEntry.NativeFieldInfoPtr_toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeFieldInfoPtr_Faction_colors;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr_toggles;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001A6 RID: 422
	[Serializable]
	public class ImageReplacementEntry : global::Il2CppSystem.Object
	{
		// Token: 0x0600250E RID: 9486 RVA: 0x000894CC File Offset: 0x000876CC
		// Note: this type is marked as 'beforefieldinit'.
		static ImageReplacementEntry()
		{
			Il2CppClassPointerStore<ColorByFaction.ImageReplacementEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "ImageReplacementEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorByFaction.ImageReplacementEntry>.NativeClassPtr);
			ColorByFaction.ImageReplacementEntry.NativeFieldInfoPtr_Faction_images = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.ImageReplacementEntry>.NativeClassPtr, "Faction_images");
			ColorByFaction.ImageReplacementEntry.NativeFieldInfoPtr_images = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.ImageReplacementEntry>.NativeClassPtr, "images");
			ColorByFaction.ImageReplacementEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction.ImageReplacementEntry>.NativeClassPtr, 100666238);
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00089534 File Offset: 0x00087734
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageReplacementEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorByFaction.ImageReplacementEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.ImageReplacementEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00016FD0 File Offset: 0x000151D0
		public ImageReplacementEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x00089570 File Offset: 0x00087770
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x00016FD9 File Offset: 0x000151D9
		public unsafe Il2CppReferenceArray<Sprite> Faction_images
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ImageReplacementEntry.NativeFieldInfoPtr_Faction_images);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ImageReplacementEntry.NativeFieldInfoPtr_Faction_images), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x000895A0 File Offset: 0x000877A0
		// (set) Token: 0x06002514 RID: 9492 RVA: 0x00016FF8 File Offset: 0x000151F8
		public unsafe Il2CppReferenceArray<Image> images
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ImageReplacementEntry.NativeFieldInfoPtr_images);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.ImageReplacementEntry.NativeFieldInfoPtr_images), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeFieldInfoPtr_Faction_images;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr_images;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001A7 RID: 423
	[Serializable]
	public class AnimatorReplacementEntry : global::Il2CppSystem.Object
	{
		// Token: 0x06002515 RID: 9493 RVA: 0x000895D0 File Offset: 0x000877D0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorReplacementEntry()
		{
			Il2CppClassPointerStore<ColorByFaction.AnimatorReplacementEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorByFaction>.NativeClassPtr, "AnimatorReplacementEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorByFaction.AnimatorReplacementEntry>.NativeClassPtr);
			ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_Faction_controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.AnimatorReplacementEntry>.NativeClassPtr, "Faction_controllers");
			ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.AnimatorReplacementEntry>.NativeClassPtr, "animators");
			ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_maskingObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorByFaction.AnimatorReplacementEntry>.NativeClassPtr, "maskingObjects");
			ColorByFaction.AnimatorReplacementEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorByFaction.AnimatorReplacementEntry>.NativeClassPtr, 100666239);
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x0008964C File Offset: 0x0008784C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorReplacementEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorByFaction.AnimatorReplacementEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorByFaction.AnimatorReplacementEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x00017017 File Offset: 0x00015217
		public AnimatorReplacementEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x00089688 File Offset: 0x00087888
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x00017020 File Offset: 0x00015220
		public unsafe Il2CppReferenceArray<RuntimeAnimatorController> Faction_controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_Faction_controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeAnimatorController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_Faction_controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000896B8 File Offset: 0x000878B8
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x0001703F File Offset: 0x0001523F
		public unsafe Il2CppReferenceArray<Animator> animators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_animators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_animators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000896E8 File Offset: 0x000878E8
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x0001705E File Offset: 0x0001525E
		public unsafe Il2CppReferenceArray<GameObject> maskingObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_maskingObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorByFaction.AnimatorReplacementEntry.NativeFieldInfoPtr_maskingObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeFieldInfoPtr_Faction_controllers;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeFieldInfoPtr_animators;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeFieldInfoPtr_maskingObjects;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001A8 RID: 424
	public enum StartupFunction
	{
		// Token: 0x040019B8 RID: 6584
		DoNothing,
		// Token: 0x040019B9 RID: 6585
		ColorizeWithValue,
		// Token: 0x040019BA RID: 6586
		ColorizeByTheme
	}
}
