using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000108 RID: 264
public class ScreenScaler : MonoBehaviour
{
	// Token: 0x06001206 RID: 4614 RVA: 0x00055C74 File Offset: 0x00053E74
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenScaler()
	{
		Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ScreenScaler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr);
		ScreenScaler.NativeFieldInfoPtr_calulateStartOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr, "calulateStartOnly");
		ScreenScaler.NativeFieldInfoPtr_persentsY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr, "persentsY");
		ScreenScaler.NativeFieldInfoPtr__scaleFactorY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr, "_scaleFactorY");
		ScreenScaler.NativeFieldInfoPtr__xScaleDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr, "_xScaleDiff");
		ScreenScaler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr, 100665482);
		ScreenScaler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr, 100665483);
		ScreenScaler.NativeMethodInfoPtr_placementCalculation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr, 100665484);
		ScreenScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr, 100665485);
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x00055D44 File Offset: 0x00053F44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182399, XrefRangeEnd = 182406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenScaler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x00055D78 File Offset: 0x00053F78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182406, XrefRangeEnd = 182407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenScaler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00055DAC File Offset: 0x00053FAC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182432, RefRangeEnd = 182434, XrefRangeStart = 182407, XrefRangeEnd = 182432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placementCalculation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenScaler.NativeMethodInfoPtr_placementCalculation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x00055DE0 File Offset: 0x00053FE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182434, XrefRangeEnd = 182435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenScaler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenScaler>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x00008F60 File Offset: 0x00007160
	public ScreenScaler(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x0600120C RID: 4620 RVA: 0x00055E1C File Offset: 0x0005401C
	// (set) Token: 0x0600120D RID: 4621 RVA: 0x00008F69 File Offset: 0x00007169
	public unsafe bool calulateStartOnly
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenScaler.NativeFieldInfoPtr_calulateStartOnly);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenScaler.NativeFieldInfoPtr_calulateStartOnly)) = value;
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x0600120E RID: 4622 RVA: 0x00055E44 File Offset: 0x00054044
	// (set) Token: 0x0600120F RID: 4623 RVA: 0x00008F84 File Offset: 0x00007184
	public unsafe float persentsY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenScaler.NativeFieldInfoPtr_persentsY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenScaler.NativeFieldInfoPtr_persentsY)) = value;
		}
	}

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x06001210 RID: 4624 RVA: 0x00055E6C File Offset: 0x0005406C
	// (set) Token: 0x06001211 RID: 4625 RVA: 0x00008F9F File Offset: 0x0000719F
	public unsafe float _scaleFactorY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenScaler.NativeFieldInfoPtr__scaleFactorY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenScaler.NativeFieldInfoPtr__scaleFactorY)) = value;
		}
	}

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06001212 RID: 4626 RVA: 0x00055E94 File Offset: 0x00054094
	// (set) Token: 0x06001213 RID: 4627 RVA: 0x00008FBA File Offset: 0x000071BA
	public unsafe float _xScaleDiff
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenScaler.NativeFieldInfoPtr__xScaleDiff);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenScaler.NativeFieldInfoPtr__xScaleDiff)) = value;
		}
	}

	// Token: 0x04000DEA RID: 3562
	private static readonly IntPtr NativeFieldInfoPtr_calulateStartOnly;

	// Token: 0x04000DEB RID: 3563
	private static readonly IntPtr NativeFieldInfoPtr_persentsY;

	// Token: 0x04000DEC RID: 3564
	private static readonly IntPtr NativeFieldInfoPtr__scaleFactorY;

	// Token: 0x04000DED RID: 3565
	private static readonly IntPtr NativeFieldInfoPtr__xScaleDiff;

	// Token: 0x04000DEE RID: 3566
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DEF RID: 3567
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000DF0 RID: 3568
	private static readonly IntPtr NativeMethodInfoPtr_placementCalculation_Public_Void_0;

	// Token: 0x04000DF1 RID: 3569
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
