using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200003F RID: 63
public class ThemeColorizerList : MonoBehaviour
{
	// Token: 0x06000B32 RID: 2866 RVA: 0x0003B004 File Offset: 0x00039204
	// Note: this type is marked as 'beforefieldinit'.
	static ThemeColorizerList()
	{
		Il2CppClassPointerStore<ThemeColorizerList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ThemeColorizerList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeColorizerList>.NativeClassPtr);
		ThemeColorizerList.NativeFieldInfoPtr_m_colorizerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeColorizerList>.NativeClassPtr, "m_colorizerList");
		ThemeColorizerList.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeColorizerList>.NativeClassPtr, 100664082);
		ThemeColorizerList.NativeMethodInfoPtr_UpdateColorizers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeColorizerList>.NativeClassPtr, 100664083);
		ThemeColorizerList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeColorizerList>.NativeClassPtr, 100664084);
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x0003B084 File Offset: 0x00039284
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237499, XrefRangeEnd = 237505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeColorizerList.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x0003B0B8 File Offset: 0x000392B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateColorizers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeColorizerList.NativeMethodInfoPtr_UpdateColorizers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x0003B0EC File Offset: 0x000392EC
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThemeColorizerList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeColorizerList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeColorizerList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x00008DB6 File Offset: 0x00006FB6
	public ThemeColorizerList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0003B128 File Offset: 0x00039328
	// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00008DBF File Offset: 0x00006FBF
	public unsafe Il2CppReferenceArray<ColorByFaction> m_colorizerList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeColorizerList.NativeFieldInfoPtr_m_colorizerList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ColorByFaction>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeColorizerList.NativeFieldInfoPtr_m_colorizerList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040006F9 RID: 1785
	private static readonly IntPtr NativeFieldInfoPtr_m_colorizerList;

	// Token: 0x040006FA RID: 1786
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040006FB RID: 1787
	private static readonly IntPtr NativeMethodInfoPtr_UpdateColorizers_Public_Void_0;

	// Token: 0x040006FC RID: 1788
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
