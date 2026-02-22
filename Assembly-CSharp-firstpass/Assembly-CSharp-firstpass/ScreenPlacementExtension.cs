using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000107 RID: 263
public static class ScreenPlacementExtension : global::Il2CppSystem.Object
{
	// Token: 0x060011FB RID: 4603 RVA: 0x00055884 File Offset: 0x00053A84
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenPlacementExtension()
	{
		Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ScreenPlacementExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr);
		ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665473);
		ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665474);
		ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665475);
		ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665476);
		ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665477);
		ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665478);
		ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665479);
		ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665480);
		ScreenPlacementExtension.NativeMethodInfoPtr_DoScreenPlacement_Private_Static_Void_Transform_ScreenPosition_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPlacementExtension>.NativeClassPtr, 100665481);
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x00055968 File Offset: 0x00053B68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182337, XrefRangeEnd = 182341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPlacement(this GameObject target, ScreenPosition position)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x000559AC File Offset: 0x00053BAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182341, XrefRangeEnd = 182344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPlacement(this GameObject target, ScreenPosition position, Camera renderingCamera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderingCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x00055A04 File Offset: 0x00053C04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182344, XrefRangeEnd = 182347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPlacement(this GameObject target, ScreenPosition position, Vector2 pixelsFromEdge)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsFromEdge;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Vector2_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x00055A58 File Offset: 0x00053C58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182347, XrefRangeEnd = 182350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPlacement(this GameObject target, ScreenPosition position, Vector2 pixelsFromEdge, Camera renderingCamera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsFromEdge;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderingCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00055ABC File Offset: 0x00053CBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182350, XrefRangeEnd = 182354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPlacement(this Transform target, ScreenPosition position)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00055B00 File Offset: 0x00053D00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182354, XrefRangeEnd = 182357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPlacement(this Transform target, ScreenPosition position, Camera renderingCamera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderingCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00055B58 File Offset: 0x00053D58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182357, XrefRangeEnd = 182360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPlacement(this Transform target, ScreenPosition position, Vector2 pixelsFromEdge)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsFromEdge;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Vector2_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00055BAC File Offset: 0x00053DAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182360, XrefRangeEnd = 182363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPlacement(this Transform target, ScreenPosition position, Vector2 pixelsFromEdge, Camera renderingCamera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsFromEdge;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderingCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00055C10 File Offset: 0x00053E10
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 182389, RefRangeEnd = 182399, XrefRangeStart = 182363, XrefRangeEnd = 182389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoScreenPlacement(this Transform target, ScreenPosition position, Vector2 pixelsFromEdge, Camera renderingCamera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsFromEdge;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderingCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPlacementExtension.NativeMethodInfoPtr_DoScreenPlacement_Private_Static_Void_Transform_ScreenPosition_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00008F57 File Offset: 0x00007157
	public ScreenPlacementExtension(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000DE1 RID: 3553
	private static readonly IntPtr NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_0;

	// Token: 0x04000DE2 RID: 3554
	private static readonly IntPtr NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Camera_0;

	// Token: 0x04000DE3 RID: 3555
	private static readonly IntPtr NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Vector2_0;

	// Token: 0x04000DE4 RID: 3556
	private static readonly IntPtr NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_GameObject_ScreenPosition_Vector2_Camera_0;

	// Token: 0x04000DE5 RID: 3557
	private static readonly IntPtr NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_0;

	// Token: 0x04000DE6 RID: 3558
	private static readonly IntPtr NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Camera_0;

	// Token: 0x04000DE7 RID: 3559
	private static readonly IntPtr NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Vector2_0;

	// Token: 0x04000DE8 RID: 3560
	private static readonly IntPtr NativeMethodInfoPtr_ScreenPlacement_Public_Static_Void_Transform_ScreenPosition_Vector2_Camera_0;

	// Token: 0x04000DE9 RID: 3561
	private static readonly IntPtr NativeMethodInfoPtr_DoScreenPlacement_Private_Static_Void_Transform_ScreenPosition_Vector2_Camera_0;
}
