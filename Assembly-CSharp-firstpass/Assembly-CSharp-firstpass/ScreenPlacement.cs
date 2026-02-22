using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000105 RID: 261
public class ScreenPlacement : MonoBehaviour
{
	// Token: 0x060011E7 RID: 4583 RVA: 0x00055580 File Offset: 0x00053780
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenPlacement()
	{
		Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ScreenPlacement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr);
		ScreenPlacement.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, "position");
		ScreenPlacement.NativeFieldInfoPtr_pixelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, "pixelOffset");
		ScreenPlacement.NativeFieldInfoPtr_persents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, "persents");
		ScreenPlacement.NativeFieldInfoPtr_calulateStartOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, "calulateStartOnly");
		ScreenPlacement.NativeFieldInfoPtr_boundsTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, "boundsTransform");
		ScreenPlacement.NativeFieldInfoPtr_actualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, "actualOffset");
		ScreenPlacement.NativeFieldInfoPtr_orinetation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, "orinetation");
		ScreenPlacement.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, 100665469);
		ScreenPlacement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, 100665470);
		ScreenPlacement.NativeMethodInfoPtr_placementCalculation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, 100665471);
		ScreenPlacement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr, 100665472);
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x0005568C File Offset: 0x0005388C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182288, XrefRangeEnd = 182289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacement.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x000556C0 File Offset: 0x000538C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182289, XrefRangeEnd = 182290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x000556F4 File Offset: 0x000538F4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182334, RefRangeEnd = 182336, XrefRangeStart = 182290, XrefRangeEnd = 182334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placementCalculation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacement.NativeMethodInfoPtr_placementCalculation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00055728 File Offset: 0x00053928
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182336, XrefRangeEnd = 182337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenPlacement()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenPlacement>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00008E8D File Offset: 0x0000708D
	public ScreenPlacement(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x060011ED RID: 4589 RVA: 0x00055764 File Offset: 0x00053964
	// (set) Token: 0x060011EE RID: 4590 RVA: 0x00008E96 File Offset: 0x00007096
	public unsafe ScreenPosition position
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_position);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_position)) = value;
		}
	}

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x060011EF RID: 4591 RVA: 0x0005578C File Offset: 0x0005398C
	// (set) Token: 0x060011F0 RID: 4592 RVA: 0x00008EB1 File Offset: 0x000070B1
	public unsafe Vector2 pixelOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_pixelOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_pixelOffset)) = value;
		}
	}

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x060011F1 RID: 4593 RVA: 0x000557B4 File Offset: 0x000539B4
	// (set) Token: 0x060011F2 RID: 4594 RVA: 0x00008ECC File Offset: 0x000070CC
	public unsafe bool persents
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_persents);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_persents)) = value;
		}
	}

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x060011F3 RID: 4595 RVA: 0x000557DC File Offset: 0x000539DC
	// (set) Token: 0x060011F4 RID: 4596 RVA: 0x00008EE7 File Offset: 0x000070E7
	public unsafe bool calulateStartOnly
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_calulateStartOnly);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_calulateStartOnly)) = value;
		}
	}

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00055804 File Offset: 0x00053A04
	// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00008F02 File Offset: 0x00007102
	public unsafe Transform boundsTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_boundsTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_boundsTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00055834 File Offset: 0x00053A34
	// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00008F21 File Offset: 0x00007121
	public unsafe Vector2 actualOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_actualOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_actualOffset)) = value;
		}
	}

	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0005585C File Offset: 0x00053A5C
	// (set) Token: 0x060011FA RID: 4602 RVA: 0x00008F3C File Offset: 0x0000713C
	public unsafe ScreenOrientation orinetation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_orinetation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenPlacement.NativeFieldInfoPtr_orinetation)) = value;
		}
	}

	// Token: 0x04000DCC RID: 3532
	private static readonly IntPtr NativeFieldInfoPtr_position;

	// Token: 0x04000DCD RID: 3533
	private static readonly IntPtr NativeFieldInfoPtr_pixelOffset;

	// Token: 0x04000DCE RID: 3534
	private static readonly IntPtr NativeFieldInfoPtr_persents;

	// Token: 0x04000DCF RID: 3535
	private static readonly IntPtr NativeFieldInfoPtr_calulateStartOnly;

	// Token: 0x04000DD0 RID: 3536
	private static readonly IntPtr NativeFieldInfoPtr_boundsTransform;

	// Token: 0x04000DD1 RID: 3537
	private static readonly IntPtr NativeFieldInfoPtr_actualOffset;

	// Token: 0x04000DD2 RID: 3538
	private static readonly IntPtr NativeFieldInfoPtr_orinetation;

	// Token: 0x04000DD3 RID: 3539
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000DD4 RID: 3540
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000DD5 RID: 3541
	private static readonly IntPtr NativeMethodInfoPtr_placementCalculation_Public_Void_0;

	// Token: 0x04000DD6 RID: 3542
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
