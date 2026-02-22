using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200002B RID: 43
	public class MaskUtilities : Object
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x0001AAE8 File Offset: 0x00018CE8
		// Note: this type is marked as 'beforefieldinit'.
		static MaskUtilities()
		{
			Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MaskUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr);
			MaskUtilities.NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664046);
			MaskUtilities.NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664047);
			MaskUtilities.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664048);
			MaskUtilities.NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664049);
			MaskUtilities.NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664050);
			MaskUtilities.NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664051);
			MaskUtilities.NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664052);
			MaskUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664053);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116145, RefRangeEnd = 116149, XrefRangeStart = 116108, XrefRangeEnd = 116145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Notify2DMaskStateChanged(Component mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001ABF0 File Offset: 0x00018DF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116186, RefRangeEnd = 116190, XrefRangeStart = 116149, XrefRangeEnd = 116186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyStencilStateChanged(Component mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001AC28 File Offset: 0x00018E28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116214, RefRangeEnd = 116218, XrefRangeStart = 116190, XrefRangeEnd = 116214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRootSortOverrideCanvas(Transform start)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001AC6C File Offset: 0x00018E6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116258, RefRangeEnd = 116262, XrefRangeStart = 116218, XrefRangeEnd = 116258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stopAfter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116282, RefRangeEnd = 116284, XrefRangeStart = 116262, XrefRangeEnd = 116282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDescendantOrSelf(Transform father, Transform child)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(father);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001AD14 File Offset: 0x00018F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116340, RefRangeEnd = 116341, XrefRangeStart = 116284, XrefRangeEnd = 116340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectMask2D GetRectMaskForClippable(IClippable clippable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr3) : null;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001AD58 File Offset: 0x00018F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116395, RefRangeEnd = 116396, XrefRangeStart = 116341, XrefRangeEnd = 116395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clipper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(masks);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00003BDB File Offset: 0x00001DDB
		public MaskUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
