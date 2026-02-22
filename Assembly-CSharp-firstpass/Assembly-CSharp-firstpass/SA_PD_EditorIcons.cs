using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000002 RID: 2
public static class SA_PD_EditorIcons : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00016B58 File Offset: 0x00014D58
	// Note: this type is marked as 'beforefieldinit'.
	static SA_PD_EditorIcons()
	{
		Il2CppClassPointerStore<SA_PD_EditorIcons>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_PD_EditorIcons");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_EditorIcons>.NativeClassPtr);
		SA_PD_EditorIcons.NativeFieldInfoPtr_m_internalIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_EditorIcons>.NativeClassPtr, "m_internalIcons");
		SA_PD_EditorIcons.NativeMethodInfoPtr_GetInternalStringPathOfEnumValue_Public_Static_String_IconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_EditorIcons>.NativeClassPtr, 100663297);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00016BB0 File Offset: 0x00014DB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158911, XrefRangeEnd = 159074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInternalStringPathOfEnumValue(SA_PD_EditorIcons.IconType type)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_EditorIcons.NativeMethodInfoPtr_GetInternalStringPathOfEnumValue_Public_Static_String_IconType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	public SA_PD_EditorIcons(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00016BE8 File Offset: 0x00014DE8
	// (set) Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
	public unsafe static Dictionary<SA_PD_EditorIcons.IconType, string> m_internalIcons
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_PD_EditorIcons.NativeFieldInfoPtr_m_internalIcons, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SA_PD_EditorIcons.IconType, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_PD_EditorIcons.NativeFieldInfoPtr_m_internalIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr_m_internalIcons;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeMethodInfoPtr_GetInternalStringPathOfEnumValue_Public_Static_String_IconType_0;

	// Token: 0x02000361 RID: 865
	public enum IconType
	{
		// Token: 0x04003013 RID: 12307
		GameObject,
		// Token: 0x04003014 RID: 12308
		Favorite,
		// Token: 0x04003015 RID: 12309
		Prefab,
		// Token: 0x04003016 RID: 12310
		GameManager,
		// Token: 0x04003017 RID: 12311
		Dragdot,
		// Token: 0x04003018 RID: 12312
		DragdotActive,
		// Token: 0x04003019 RID: 12313
		DragdotDimmed,
		// Token: 0x0400301A RID: 12314
		Dropdown,
		// Token: 0x0400301B RID: 12315
		d_winbtn_mac_close,
		// Token: 0x0400301C RID: 12316
		d_winbtn_mac_close_a,
		// Token: 0x0400301D RID: 12317
		d_winbtn_mac_close_h,
		// Token: 0x0400301E RID: 12318
		d_winbtn_mac_inact,
		// Token: 0x0400301F RID: 12319
		d_winbtn_mac_max,
		// Token: 0x04003020 RID: 12320
		d_winbtn_mac_max_h,
		// Token: 0x04003021 RID: 12321
		d_winbtn_mac_min,
		// Token: 0x04003022 RID: 12322
		d_winbtn_mac_min_h,
		// Token: 0x04003023 RID: 12323
		d_winbtn_win_close,
		// Token: 0x04003024 RID: 12324
		DefaultAsset,
		// Token: 0x04003025 RID: 12325
		DllScript,
		// Token: 0x04003026 RID: 12326
		DistanceJoint2D,
		// Token: 0x04003027 RID: 12327
		FilterByLabel,
		// Token: 0x04003028 RID: 12328
		FilterByType,
		// Token: 0x04003029 RID: 12329
		Fixedjoint,
		// Token: 0x0400302A RID: 12330
		FlareLayer,
		// Token: 0x0400302B RID: 12331
		FrictionJoint2D,
		// Token: 0x0400302C RID: 12332
		GUIText,
		// Token: 0x0400302D RID: 12333
		HingeJoint2D,
		// Token: 0x0400302E RID: 12334
		Image,
		// Token: 0x0400302F RID: 12335
		LightProbeProxyVolume,
		// Token: 0x04003030 RID: 12336
		LightProbeGroup,
		// Token: 0x04003031 RID: 12337
		LineRenderer,
		// Token: 0x04003032 RID: 12338
		LayoutElement,
		// Token: 0x04003033 RID: 12339
		Light,
		// Token: 0x04003034 RID: 12340
		LensFlare
	}
}
