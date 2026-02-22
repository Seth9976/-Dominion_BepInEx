using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000109 RID: 265
public class XScaleModifayer : MonoBehaviour
{
	// Token: 0x06001214 RID: 4628 RVA: 0x00055EBC File Offset: 0x000540BC
	// Note: this type is marked as 'beforefieldinit'.
	static XScaleModifayer()
	{
		Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "XScaleModifayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr);
		XScaleModifayer.NativeFieldInfoPtr_XMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr, "XMaxSize");
		XScaleModifayer.NativeFieldInfoPtr_scaleDownOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr, "scaleDownOnly");
		XScaleModifayer.NativeFieldInfoPtr_calulateStartOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr, "calulateStartOnly");
		XScaleModifayer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr, 100665486);
		XScaleModifayer.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr, 100665487);
		XScaleModifayer.NativeMethodInfoPtr_Calculate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr, 100665488);
		XScaleModifayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr, 100665489);
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x00055F78 File Offset: 0x00054178
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182435, XrefRangeEnd = 182436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XScaleModifayer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00055FAC File Offset: 0x000541AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182436, XrefRangeEnd = 182437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XScaleModifayer.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00055FE0 File Offset: 0x000541E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182449, RefRangeEnd = 182451, XrefRangeStart = 182437, XrefRangeEnd = 182449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Calculate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XScaleModifayer.NativeMethodInfoPtr_Calculate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00056014 File Offset: 0x00054214
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182451, XrefRangeEnd = 182452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XScaleModifayer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XScaleModifayer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XScaleModifayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00008FD5 File Offset: 0x000071D5
	public XScaleModifayer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x0600121A RID: 4634 RVA: 0x00056050 File Offset: 0x00054250
	// (set) Token: 0x0600121B RID: 4635 RVA: 0x00008FDE File Offset: 0x000071DE
	public unsafe float XMaxSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XScaleModifayer.NativeFieldInfoPtr_XMaxSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XScaleModifayer.NativeFieldInfoPtr_XMaxSize)) = value;
		}
	}

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x0600121C RID: 4636 RVA: 0x00056078 File Offset: 0x00054278
	// (set) Token: 0x0600121D RID: 4637 RVA: 0x00008FF9 File Offset: 0x000071F9
	public unsafe bool scaleDownOnly
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XScaleModifayer.NativeFieldInfoPtr_scaleDownOnly);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XScaleModifayer.NativeFieldInfoPtr_scaleDownOnly)) = value;
		}
	}

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x0600121E RID: 4638 RVA: 0x000560A0 File Offset: 0x000542A0
	// (set) Token: 0x0600121F RID: 4639 RVA: 0x00009014 File Offset: 0x00007214
	public unsafe bool calulateStartOnly
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XScaleModifayer.NativeFieldInfoPtr_calulateStartOnly);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XScaleModifayer.NativeFieldInfoPtr_calulateStartOnly)) = value;
		}
	}

	// Token: 0x04000DF2 RID: 3570
	private static readonly IntPtr NativeFieldInfoPtr_XMaxSize;

	// Token: 0x04000DF3 RID: 3571
	private static readonly IntPtr NativeFieldInfoPtr_scaleDownOnly;

	// Token: 0x04000DF4 RID: 3572
	private static readonly IntPtr NativeFieldInfoPtr_calulateStartOnly;

	// Token: 0x04000DF5 RID: 3573
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DF6 RID: 3574
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000DF7 RID: 3575
	private static readonly IntPtr NativeMethodInfoPtr_Calculate_Public_Void_0;

	// Token: 0x04000DF8 RID: 3576
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
