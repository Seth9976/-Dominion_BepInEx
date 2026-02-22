using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200005E RID: 94
public class GP_Quest : global::Il2CppSystem.Object
{
	// Token: 0x06000710 RID: 1808 RVA: 0x0002F24C File Offset: 0x0002D44C
	// Note: this type is marked as 'beforefieldinit'.
	static GP_Quest()
	{
		Il2CppClassPointerStore<GP_Quest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_Quest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr);
		GP_Quest.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "Id");
		GP_Quest.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "Name");
		GP_Quest.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "Description");
		GP_Quest.NativeFieldInfoPtr_IconImageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "IconImageUrl");
		GP_Quest.NativeFieldInfoPtr_BannerImageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "BannerImageUrl");
		GP_Quest.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "state");
		GP_Quest.NativeFieldInfoPtr_LastUpdatedTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "LastUpdatedTimestamp");
		GP_Quest.NativeFieldInfoPtr_AcceptedTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "AcceptedTimestamp");
		GP_Quest.NativeFieldInfoPtr_EndTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "EndTimestamp");
		GP_Quest.NativeFieldInfoPtr_RewardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "RewardData");
		GP_Quest.NativeFieldInfoPtr_CurrentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "CurrentProgress");
		GP_Quest.NativeFieldInfoPtr_TargetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "TargetProgress");
		GP_Quest.NativeFieldInfoPtr__icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "_icon");
		GP_Quest.NativeFieldInfoPtr__banner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, "_banner");
		GP_Quest.NativeMethodInfoPtr_LoadIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, 100664145);
		GP_Quest.NativeMethodInfoPtr_LoadBanner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, 100664146);
		GP_Quest.NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, 100664147);
		GP_Quest.NativeMethodInfoPtr_get_banner_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, 100664148);
		GP_Quest.NativeMethodInfoPtr_OnBannerLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, 100664149);
		GP_Quest.NativeMethodInfoPtr_OnIconLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, 100664150);
		GP_Quest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr, 100664151);
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x0002F420 File Offset: 0x0002D620
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 167055, RefRangeEnd = 167056, XrefRangeStart = 167042, XrefRangeEnd = 167055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Quest.NativeMethodInfoPtr_LoadIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x0002F454 File Offset: 0x0002D654
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 167069, RefRangeEnd = 167070, XrefRangeStart = 167056, XrefRangeEnd = 167069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadBanner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Quest.NativeMethodInfoPtr_LoadBanner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06000713 RID: 1811 RVA: 0x0002F488 File Offset: 0x0002D688
	public unsafe Texture2D icon
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Quest.NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x06000714 RID: 1812 RVA: 0x0002F4C8 File Offset: 0x0002D6C8
	public unsafe Texture2D banner
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Quest.NativeMethodInfoPtr_get_banner_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x0002F508 File Offset: 0x0002D708
	[CallerCount(0)]
	public unsafe void OnBannerLoaded(Texture2D tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Quest.NativeMethodInfoPtr_OnBannerLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x0002F54C File Offset: 0x0002D74C
	[CallerCount(0)]
	public unsafe void OnIconLoaded(Texture2D tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Quest.NativeMethodInfoPtr_OnIconLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x0002F590 File Offset: 0x0002D790
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Quest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_Quest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Quest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00004E47 File Offset: 0x00003047
	public GP_Quest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000267 RID: 615
	// (get) Token: 0x06000719 RID: 1817 RVA: 0x0002F5CC File Offset: 0x0002D7CC
	// (set) Token: 0x0600071A RID: 1818 RVA: 0x00004E50 File Offset: 0x00003050
	public unsafe string Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_Id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x0600071B RID: 1819 RVA: 0x0002F5F4 File Offset: 0x0002D7F4
	// (set) Token: 0x0600071C RID: 1820 RVA: 0x00004E6F File Offset: 0x0000306F
	public unsafe string Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x0600071D RID: 1821 RVA: 0x0002F61C File Offset: 0x0002D81C
	// (set) Token: 0x0600071E RID: 1822 RVA: 0x00004E8E File Offset: 0x0000308E
	public unsafe string Description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_Description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x0600071F RID: 1823 RVA: 0x0002F644 File Offset: 0x0002D844
	// (set) Token: 0x06000720 RID: 1824 RVA: 0x00004EAD File Offset: 0x000030AD
	public unsafe string IconImageUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_IconImageUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_IconImageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x06000721 RID: 1825 RVA: 0x0002F66C File Offset: 0x0002D86C
	// (set) Token: 0x06000722 RID: 1826 RVA: 0x00004ECC File Offset: 0x000030CC
	public unsafe string BannerImageUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_BannerImageUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_BannerImageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x06000723 RID: 1827 RVA: 0x0002F694 File Offset: 0x0002D894
	// (set) Token: 0x06000724 RID: 1828 RVA: 0x00004EEB File Offset: 0x000030EB
	public unsafe GP_QuestState state
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_state);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_state)) = value;
		}
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x06000725 RID: 1829 RVA: 0x0002F6BC File Offset: 0x0002D8BC
	// (set) Token: 0x06000726 RID: 1830 RVA: 0x00004F06 File Offset: 0x00003106
	public unsafe long LastUpdatedTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_LastUpdatedTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_LastUpdatedTimestamp)) = value;
		}
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x06000727 RID: 1831 RVA: 0x0002F6E4 File Offset: 0x0002D8E4
	// (set) Token: 0x06000728 RID: 1832 RVA: 0x00004F21 File Offset: 0x00003121
	public unsafe long AcceptedTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_AcceptedTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_AcceptedTimestamp)) = value;
		}
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x06000729 RID: 1833 RVA: 0x0002F70C File Offset: 0x0002D90C
	// (set) Token: 0x0600072A RID: 1834 RVA: 0x00004F3C File Offset: 0x0000313C
	public unsafe long EndTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_EndTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_EndTimestamp)) = value;
		}
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x0600072B RID: 1835 RVA: 0x0002F734 File Offset: 0x0002D934
	// (set) Token: 0x0600072C RID: 1836 RVA: 0x00004F57 File Offset: 0x00003157
	public unsafe Il2CppStructArray<byte> RewardData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_RewardData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_RewardData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x0600072D RID: 1837 RVA: 0x0002F764 File Offset: 0x0002D964
	// (set) Token: 0x0600072E RID: 1838 RVA: 0x00004F76 File Offset: 0x00003176
	public unsafe long CurrentProgress
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_CurrentProgress);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_CurrentProgress)) = value;
		}
	}

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x0600072F RID: 1839 RVA: 0x0002F78C File Offset: 0x0002D98C
	// (set) Token: 0x06000730 RID: 1840 RVA: 0x00004F91 File Offset: 0x00003191
	public unsafe long TargetProgress
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_TargetProgress);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr_TargetProgress)) = value;
		}
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x06000731 RID: 1841 RVA: 0x0002F7B4 File Offset: 0x0002D9B4
	// (set) Token: 0x06000732 RID: 1842 RVA: 0x00004FAC File Offset: 0x000031AC
	public unsafe Texture2D _icon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr__icon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr__icon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06000733 RID: 1843 RVA: 0x0002F7E4 File Offset: 0x0002D9E4
	// (set) Token: 0x06000734 RID: 1844 RVA: 0x00004FCB File Offset: 0x000031CB
	public unsafe Texture2D _banner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr__banner);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Quest.NativeFieldInfoPtr__banner), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040005BA RID: 1466
	private static readonly IntPtr NativeFieldInfoPtr_Id;

	// Token: 0x040005BB RID: 1467
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x040005BC RID: 1468
	private static readonly IntPtr NativeFieldInfoPtr_Description;

	// Token: 0x040005BD RID: 1469
	private static readonly IntPtr NativeFieldInfoPtr_IconImageUrl;

	// Token: 0x040005BE RID: 1470
	private static readonly IntPtr NativeFieldInfoPtr_BannerImageUrl;

	// Token: 0x040005BF RID: 1471
	private static readonly IntPtr NativeFieldInfoPtr_state;

	// Token: 0x040005C0 RID: 1472
	private static readonly IntPtr NativeFieldInfoPtr_LastUpdatedTimestamp;

	// Token: 0x040005C1 RID: 1473
	private static readonly IntPtr NativeFieldInfoPtr_AcceptedTimestamp;

	// Token: 0x040005C2 RID: 1474
	private static readonly IntPtr NativeFieldInfoPtr_EndTimestamp;

	// Token: 0x040005C3 RID: 1475
	private static readonly IntPtr NativeFieldInfoPtr_RewardData;

	// Token: 0x040005C4 RID: 1476
	private static readonly IntPtr NativeFieldInfoPtr_CurrentProgress;

	// Token: 0x040005C5 RID: 1477
	private static readonly IntPtr NativeFieldInfoPtr_TargetProgress;

	// Token: 0x040005C6 RID: 1478
	private static readonly IntPtr NativeFieldInfoPtr__icon;

	// Token: 0x040005C7 RID: 1479
	private static readonly IntPtr NativeFieldInfoPtr__banner;

	// Token: 0x040005C8 RID: 1480
	private static readonly IntPtr NativeMethodInfoPtr_LoadIcon_Public_Void_0;

	// Token: 0x040005C9 RID: 1481
	private static readonly IntPtr NativeMethodInfoPtr_LoadBanner_Public_Void_0;

	// Token: 0x040005CA RID: 1482
	private static readonly IntPtr NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0;

	// Token: 0x040005CB RID: 1483
	private static readonly IntPtr NativeMethodInfoPtr_get_banner_Public_get_Texture2D_0;

	// Token: 0x040005CC RID: 1484
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerLoaded_Private_Void_Texture2D_0;

	// Token: 0x040005CD RID: 1485
	private static readonly IntPtr NativeMethodInfoPtr_OnIconLoaded_Private_Void_Texture2D_0;

	// Token: 0x040005CE RID: 1486
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
