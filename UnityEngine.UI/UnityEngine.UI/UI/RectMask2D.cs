using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000031 RID: 49
	public class RectMask2D : UIBehaviour
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x0001BA20 File Offset: 0x00019C20
		// Note: this type is marked as 'beforefieldinit'.
		static RectMask2D()
		{
			Il2CppClassPointerStore<RectMask2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "RectMask2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr);
			RectMask2D.NativeFieldInfoPtr_m_VertexClipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_VertexClipper");
			RectMask2D.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_RectTransform");
			RectMask2D.NativeFieldInfoPtr_m_MaskableTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_MaskableTargets");
			RectMask2D.NativeFieldInfoPtr_m_ClipTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ClipTargets");
			RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ShouldRecalculateClipRects");
			RectMask2D.NativeFieldInfoPtr_m_Clippers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Clippers");
			RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_LastClipRectCanvasSpace");
			RectMask2D.NativeFieldInfoPtr_m_ForceClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ForceClip");
			RectMask2D.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Padding");
			RectMask2D.NativeFieldInfoPtr_m_Softness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Softness");
			RectMask2D.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Canvas");
			RectMask2D.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Corners");
			RectMask2D.NativeMethodInfoPtr_get_padding_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664082);
			RectMask2D.NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664083);
			RectMask2D.NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664084);
			RectMask2D.NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664085);
			RectMask2D.NativeMethodInfoPtr_get_Canvas_Private_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664086);
			RectMask2D.NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664087);
			RectMask2D.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664088);
			RectMask2D.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664089);
			RectMask2D.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664090);
			RectMask2D.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664091);
			RectMask2D.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664092);
			RectMask2D.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664093);
			RectMask2D.NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664094);
			RectMask2D.NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664095);
			RectMask2D.NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664096);
			RectMask2D.NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664097);
			RectMask2D.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664098);
			RectMask2D.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664099);
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0001BCA8 File Offset: 0x00019EA8
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0001BCE4 File Offset: 0x00019EE4
		public unsafe Vector4 padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_padding_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116542, RefRangeEnd = 116543, XrefRangeStart = 116541, XrefRangeEnd = 116542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0001BD24 File Offset: 0x00019F24
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x0001BD60 File Offset: 0x00019F60
		public unsafe Vector2Int softness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116543, XrefRangeEnd = 116546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0001BDA0 File Offset: 0x00019FA0
		public unsafe Canvas Canvas
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 116569, RefRangeEnd = 116575, XrefRangeStart = 116546, XrefRangeEnd = 116569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_Canvas_Private_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		public unsafe Rect canvasRect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 116580, RefRangeEnd = 116582, XrefRangeStart = 116575, XrefRangeEnd = 116580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0001BE1C File Offset: 0x0001A01C
		public unsafe RectTransform rectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116582, XrefRangeEnd = 116585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001BE5C File Offset: 0x0001A05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116585, XrefRangeEnd = 116616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectMask2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001BE98 File Offset: 0x0001A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116616, XrefRangeEnd = 116619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0001BED4 File Offset: 0x0001A0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116619, XrefRangeEnd = 116632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001BF10 File Offset: 0x0001A110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116632, XrefRangeEnd = 116640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0001BF78 File Offset: 0x0001A178
		public unsafe Rect rootCanvasRect
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116650, RefRangeEnd = 116651, XrefRangeStart = 116640, XrefRangeEnd = 116650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001BFB4 File Offset: 0x0001A1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116651, XrefRangeEnd = 116725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PerformClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116725, XrefRangeEnd = 116760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateClipSoftness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001C02C File Offset: 0x0001A22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116760, XrefRangeEnd = 116773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClippable(IClippable clippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0001C070 File Offset: 0x0001A270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116790, RefRangeEnd = 116791, XrefRangeStart = 116773, XrefRangeEnd = 116790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveClippable(IClippable clippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116791, XrefRangeEnd = 116792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001C0F0 File Offset: 0x0001A2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116792, XrefRangeEnd = 116793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00003D3E File Offset: 0x00001F3E
		public RectMask2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0001C12C File Offset: 0x0001A32C
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00003D47 File Offset: 0x00001F47
		public unsafe RectangularVertexClipper m_VertexClipper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_VertexClipper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectangularVertexClipper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_VertexClipper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0001C15C File Offset: 0x0001A35C
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00003D66 File Offset: 0x00001F66
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0001C18C File Offset: 0x0001A38C
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00003D85 File Offset: 0x00001F85
		public unsafe HashSet<MaskableGraphic> m_MaskableTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_MaskableTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<MaskableGraphic>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_MaskableTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001C1BC File Offset: 0x0001A3BC
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public unsafe HashSet<IClippable> m_ClipTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ClipTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IClippable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ClipTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00003DC3 File Offset: 0x00001FC3
		public unsafe bool m_ShouldRecalculateClipRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001C214 File Offset: 0x0001A414
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00003DDE File Offset: 0x00001FDE
		public unsafe List<RectMask2D> m_Clippers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Clippers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectMask2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Clippers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001C244 File Offset: 0x0001A444
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00003DFD File Offset: 0x00001FFD
		public unsafe Rect m_LastClipRectCanvasSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0001C26C File Offset: 0x0001A46C
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00003E18 File Offset: 0x00002018
		public unsafe bool m_ForceClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ForceClip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ForceClip)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0001C294 File Offset: 0x0001A494
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00003E33 File Offset: 0x00002033
		public unsafe Vector4 m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Padding)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001C2BC File Offset: 0x0001A4BC
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00003E4E File Offset: 0x0000204E
		public unsafe Vector2Int m_Softness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Softness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Softness)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0001C2E4 File Offset: 0x0001A4E4
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00003E69 File Offset: 0x00002069
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001C314 File Offset: 0x0001A514
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00003E88 File Offset: 0x00002088
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexClipper;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskableTargets;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipTargets;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculateClipRects;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_m_Clippers;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_m_LastClipRectCanvasSpace;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceClip;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_m_Softness;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_Vector4_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_get_Canvas_Private_get_Canvas_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;
	}
}
