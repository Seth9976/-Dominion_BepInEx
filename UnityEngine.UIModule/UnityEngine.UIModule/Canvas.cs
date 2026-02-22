using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public sealed class Canvas : Behaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003EB0 File Offset: 0x000020B0
		// Note: this type is marked as 'beforefieldinit'.
		static Canvas()
		{
			Il2CppClassPointerStore<Canvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "Canvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Canvas>.NativeClassPtr);
			Canvas.NativeFieldInfoPtr_preWillRenderCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "preWillRenderCanvases");
			Canvas.NativeFieldInfoPtr_willRenderCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "willRenderCanvases");
			Canvas.NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externBeginRenderOverlays>k__BackingField");
			Canvas.NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externRenderOverlaysBefore>k__BackingField");
			Canvas.NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externEndRenderOverlays>k__BackingField");
			Canvas.NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663357);
			Canvas.NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663358);
			Canvas.NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663359);
			Canvas.NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663360);
			Canvas.NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663361);
			Canvas.NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663362);
			Canvas.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663363);
			Canvas.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663364);
			Canvas.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663365);
			Canvas.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663366);
			Canvas.NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663367);
			Canvas.NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663368);
			Canvas.NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663369);
			Canvas.NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663370);
			Canvas.NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663371);
			Canvas.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663372);
			Canvas.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663373);
			Canvas.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663374);
			Canvas.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663375);
			Canvas.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663376);
			Canvas.NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663377);
			Canvas.NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663378);
			Canvas.NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663379);
			Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663380);
			Canvas.NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663381);
			Canvas.NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663382);
			Canvas.NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663383);
			Canvas.NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663384);
			Canvas.NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663385);
			Canvas.NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663386);
			Canvas.NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663387);
			Canvas.NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663388);
			Canvas.NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663389);
			Canvas.NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663390);
			Canvas.NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663391);
			Canvas.NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663392);
			Canvas.NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663393);
			Canvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663394);
			Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663395);
			Canvas.set_renderModeDelegateField = IL2CPP.ResolveICall<Canvas.set_renderModeDelegate>("UnityEngine.Canvas::set_renderMode");
			Canvas.get_overridePixelPerfectDelegateField = IL2CPP.ResolveICall<Canvas.get_overridePixelPerfectDelegate>("UnityEngine.Canvas::get_overridePixelPerfect");
			Canvas.set_overridePixelPerfectDelegateField = IL2CPP.ResolveICall<Canvas.set_overridePixelPerfectDelegate>("UnityEngine.Canvas::set_overridePixelPerfect");
			Canvas.set_pixelPerfectDelegateField = IL2CPP.ResolveICall<Canvas.set_pixelPerfectDelegate>("UnityEngine.Canvas::set_pixelPerfect");
			Canvas.set_planeDistanceDelegateField = IL2CPP.ResolveICall<Canvas.set_planeDistanceDelegate>("UnityEngine.Canvas::set_planeDistance");
			Canvas.set_targetDisplayDelegateField = IL2CPP.ResolveICall<Canvas.set_targetDisplayDelegate>("UnityEngine.Canvas::set_targetDisplay");
			Canvas.get_cachedSortingLayerValueDelegateField = IL2CPP.ResolveICall<Canvas.get_cachedSortingLayerValueDelegate>("UnityEngine.Canvas::get_cachedSortingLayerValue");
			Canvas.get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Canvas.get_sortingLayerNameDelegate>("UnityEngine.Canvas::get_sortingLayerName");
			Canvas.set_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Canvas.set_sortingLayerNameDelegate>("UnityEngine.Canvas::set_sortingLayerName");
			Canvas.SetExternalCanvasEnabledDelegateField = IL2CPP.ResolveICall<Canvas.SetExternalCanvasEnabledDelegate>("UnityEngine.Canvas::SetExternalCanvasEnabled");
			Canvas.get_normalizedSortingGridSizeDelegateField = IL2CPP.ResolveICall<Canvas.get_normalizedSortingGridSizeDelegate>("UnityEngine.Canvas::get_normalizedSortingGridSize");
			Canvas.set_normalizedSortingGridSizeDelegateField = IL2CPP.ResolveICall<Canvas.set_normalizedSortingGridSizeDelegate>("UnityEngine.Canvas::set_normalizedSortingGridSize");
			Canvas.get_sortingGridNormalizedSizeDelegateField = IL2CPP.ResolveICall<Canvas.get_sortingGridNormalizedSizeDelegate>("UnityEngine.Canvas::get_sortingGridNormalizedSize");
			Canvas.set_sortingGridNormalizedSizeDelegateField = IL2CPP.ResolveICall<Canvas.set_sortingGridNormalizedSizeDelegate>("UnityEngine.Canvas::set_sortingGridNormalizedSize");
			Canvas.GetDefaultCanvasTextMaterialDelegateField = IL2CPP.ResolveICall<Canvas.GetDefaultCanvasTextMaterialDelegate>("UnityEngine.Canvas::GetDefaultCanvasTextMaterial");
			Canvas.UpdateCanvasRectTransformDelegateField = IL2CPP.ResolveICall<Canvas.UpdateCanvasRectTransformDelegate>("UnityEngine.Canvas::UpdateCanvasRectTransform");
			Canvas.get_pixelRect_InjectedDelegateField = IL2CPP.ResolveICall<Canvas.get_pixelRect_InjectedDelegate>("UnityEngine.Canvas::get_pixelRect_Injected");
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004350 File Offset: 0x00002550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97738, RefRangeEnd = 97739, XrefRangeStart = 97731, XrefRangeEnd = 97738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004388 File Offset: 0x00002588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97746, RefRangeEnd = 97747, XrefRangeStart = 97739, XrefRangeEnd = 97746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000043C0 File Offset: 0x000025C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 97754, RefRangeEnd = 97759, XrefRangeStart = 97747, XrefRangeEnd = 97754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_willRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000043F8 File Offset: 0x000025F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97759, XrefRangeEnd = 97766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_willRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004430 File Offset: 0x00002630
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000021E1 File Offset: 0x000003E1
		public unsafe RenderMode renderMode
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 97768, RefRangeEnd = 97787, XrefRangeStart = 97766, XrefRangeEnd = 97768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Canvas.set_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000446C File Offset: 0x0000266C
		public unsafe bool isRootCanvas
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 97789, RefRangeEnd = 97793, XrefRangeStart = 97787, XrefRangeEnd = 97789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000044A8 File Offset: 0x000026A8
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000044E4 File Offset: 0x000026E4
		public unsafe float scaleFactor
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 97795, RefRangeEnd = 97803, XrefRangeStart = 97793, XrefRangeEnd = 97795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 97805, RefRangeEnd = 97811, XrefRangeStart = 97803, XrefRangeEnd = 97805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004524 File Offset: 0x00002724
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00004560 File Offset: 0x00002760
		public unsafe float referencePixelsPerUnit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 97813, RefRangeEnd = 97816, XrefRangeStart = 97811, XrefRangeEnd = 97813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 97818, RefRangeEnd = 97824, XrefRangeStart = 97816, XrefRangeEnd = 97818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000045A0 File Offset: 0x000027A0
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002219 File Offset: 0x00000419
		public unsafe bool pixelPerfect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 97826, RefRangeEnd = 97828, XrefRangeStart = 97824, XrefRangeEnd = 97826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Canvas.set_pixelPerfectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000045DC File Offset: 0x000027DC
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000222C File Offset: 0x0000042C
		public unsafe float planeDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97830, RefRangeEnd = 97831, XrefRangeStart = 97828, XrefRangeEnd = 97830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Canvas.set_planeDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004618 File Offset: 0x00002818
		public unsafe int renderOrder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97831, XrefRangeEnd = 97833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004654 File Offset: 0x00002854
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00004690 File Offset: 0x00002890
		public unsafe bool overrideSorting
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 97835, RefRangeEnd = 97842, XrefRangeStart = 97833, XrefRangeEnd = 97835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 97844, RefRangeEnd = 97848, XrefRangeStart = 97842, XrefRangeEnd = 97844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000046D0 File Offset: 0x000028D0
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000470C File Offset: 0x0000290C
		public unsafe int sortingOrder
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 97850, RefRangeEnd = 97853, XrefRangeStart = 97848, XrefRangeEnd = 97850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 97855, RefRangeEnd = 97862, XrefRangeStart = 97853, XrefRangeEnd = 97855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000474C File Offset: 0x0000294C
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000223F File Offset: 0x0000043F
		public unsafe int targetDisplay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 97864, RefRangeEnd = 97867, XrefRangeStart = 97862, XrefRangeEnd = 97864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Canvas.set_targetDisplayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00004788 File Offset: 0x00002988
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000047C4 File Offset: 0x000029C4
		public unsafe int sortingLayerID
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 97869, RefRangeEnd = 97874, XrefRangeStart = 97867, XrefRangeEnd = 97869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 97876, RefRangeEnd = 97880, XrefRangeStart = 97874, XrefRangeEnd = 97876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00004804 File Offset: 0x00002A04
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00004840 File Offset: 0x00002A40
		public unsafe AdditionalCanvasShaderChannels additionalShaderChannels
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 97882, RefRangeEnd = 97884, XrefRangeStart = 97880, XrefRangeEnd = 97882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97886, RefRangeEnd = 97887, XrefRangeStart = 97884, XrefRangeEnd = 97886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004880 File Offset: 0x00002A80
		public unsafe Canvas rootCanvas
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 97889, RefRangeEnd = 97895, XrefRangeStart = 97887, XrefRangeEnd = 97889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000048C0 File Offset: 0x00002AC0
		public unsafe Vector2 renderingDisplaySize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97897, RefRangeEnd = 97898, XrefRangeStart = 97895, XrefRangeEnd = 97897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000048FC File Offset: 0x00002AFC
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000227C File Offset: 0x0000047C
		public unsafe static Action<int> externBeginRenderOverlays
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97898, XrefRangeEnd = 97900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			set
			{
				Canvas._externBeginRenderOverlays_k__BackingField = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004930 File Offset: 0x00002B30
		public unsafe static Action<int, int> externRenderOverlaysBefore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97900, XrefRangeEnd = 97902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004964 File Offset: 0x00002B64
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002284 File Offset: 0x00000484
		public unsafe static Action<int> externEndRenderOverlays
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97902, XrefRangeEnd = 97904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			set
			{
				Canvas._externEndRenderOverlays_k__BackingField = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004998 File Offset: 0x00002B98
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000049D8 File Offset: 0x00002BD8
		public unsafe Camera worldCamera
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 97906, RefRangeEnd = 97915, XrefRangeStart = 97904, XrefRangeEnd = 97906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97917, RefRangeEnd = 97918, XrefRangeStart = 97915, XrefRangeEnd = 97917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004A1C File Offset: 0x00002C1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97920, RefRangeEnd = 97922, XrefRangeStart = 97918, XrefRangeEnd = 97920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetDefaultCanvasMaterial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004A50 File Offset: 0x00002C50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97924, RefRangeEnd = 97926, XrefRangeStart = 97922, XrefRangeEnd = 97924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetETC1SupportedCanvasMaterial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004A84 File Offset: 0x00002C84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97932, RefRangeEnd = 97935, XrefRangeStart = 97926, XrefRangeEnd = 97932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceUpdateCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004AAC File Offset: 0x00002CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97935, XrefRangeEnd = 97938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendPreWillRenderCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004AD4 File Offset: 0x00002CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97938, XrefRangeEnd = 97941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendWillRenderCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004AFC File Offset: 0x00002CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97941, XrefRangeEnd = 97946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginRenderExtraOverlays(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004B30 File Offset: 0x00002D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97946, XrefRangeEnd = 97951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004B70 File Offset: 0x00002D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97951, XrefRangeEnd = 97956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndRenderExtraOverlays(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canvas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004BE0 File Offset: 0x00002DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97956, XrefRangeEnd = 97958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_renderingDisplaySize_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000217E File Offset: 0x0000037E
		public Canvas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004C20 File Offset: 0x00002E20
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002187 File Offset: 0x00000387
		public unsafe static Canvas.WillRenderCanvases preWillRenderCanvases
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr_preWillRenderCanvases, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas.WillRenderCanvases>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr_preWillRenderCanvases, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004C48 File Offset: 0x00002E48
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002199 File Offset: 0x00000399
		public unsafe static Canvas.WillRenderCanvases willRenderCanvases
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr_willRenderCanvases, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas.WillRenderCanvases>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr_willRenderCanvases, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004C70 File Offset: 0x00002E70
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000021AB File Offset: 0x000003AB
		public unsafe static Action<int> _externBeginRenderOverlays_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004C98 File Offset: 0x00002E98
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000021BD File Offset: 0x000003BD
		public unsafe static Action<int, int> _externRenderOverlaysBefore_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004CC0 File Offset: 0x00002EC0
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000021CF File Offset: 0x000003CF
		public unsafe static Action<int> _externEndRenderOverlays_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004CE8 File Offset: 0x00002EE8
		public Rect pixelRect
		{
			get
			{
				Rect rect;
				this.get_pixelRect_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000021F4 File Offset: 0x000003F4
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002206 File Offset: 0x00000406
		public bool overridePixelPerfect
		{
			get
			{
				return Canvas.get_overridePixelPerfectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Canvas.set_overridePixelPerfectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002252 File Offset: 0x00000452
		public int cachedSortingLayerValue
		{
			get
			{
				return Canvas.get_cachedSortingLayerValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004D00 File Offset: 0x00002F00
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002264 File Offset: 0x00000464
		public string sortingLayerName
		{
			get
			{
				IntPtr intPtr = Canvas.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Canvas.set_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000228C File Offset: 0x0000048C
		public static void SetExternalCanvasEnabled(bool enabled)
		{
			Canvas.SetExternalCanvasEnabledDelegateField(enabled);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002299 File Offset: 0x00000499
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000022AB File Offset: 0x000004AB
		public float normalizedSortingGridSize
		{
			get
			{
				return Canvas.get_normalizedSortingGridSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Canvas.set_normalizedSortingGridSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000022BE File Offset: 0x000004BE
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000022D0 File Offset: 0x000004D0
		public int sortingGridNormalizedSize
		{
			get
			{
				return Canvas.get_sortingGridNormalizedSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Canvas.set_sortingGridNormalizedSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004D24 File Offset: 0x00002F24
		public static Material GetDefaultCanvasTextMaterial()
		{
			IntPtr intPtr = Canvas.GetDefaultCanvasTextMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000022E3 File Offset: 0x000004E3
		public void UpdateCanvasRectTransform(bool alignWithCamera)
		{
			Canvas.UpdateCanvasRectTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), alignWithCamera);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000022F6 File Offset: 0x000004F6
		public void get_pixelRect_Injected(out Rect ret)
		{
			Canvas.get_pixelRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_preWillRenderCanvases;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_willRenderCanvases;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400007C RID: 124
		private static readonly Canvas.set_renderModeDelegate set_renderModeDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly Canvas.get_overridePixelPerfectDelegate get_overridePixelPerfectDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly Canvas.set_overridePixelPerfectDelegate set_overridePixelPerfectDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly Canvas.set_pixelPerfectDelegate set_pixelPerfectDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly Canvas.set_planeDistanceDelegate set_planeDistanceDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly Canvas.set_targetDisplayDelegate set_targetDisplayDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly Canvas.get_cachedSortingLayerValueDelegate get_cachedSortingLayerValueDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly Canvas.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly Canvas.set_sortingLayerNameDelegate set_sortingLayerNameDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly Canvas.SetExternalCanvasEnabledDelegate SetExternalCanvasEnabledDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly Canvas.get_normalizedSortingGridSizeDelegate get_normalizedSortingGridSizeDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly Canvas.set_normalizedSortingGridSizeDelegate set_normalizedSortingGridSizeDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly Canvas.get_sortingGridNormalizedSizeDelegate get_sortingGridNormalizedSizeDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly Canvas.set_sortingGridNormalizedSizeDelegate set_sortingGridNormalizedSizeDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly Canvas.GetDefaultCanvasTextMaterialDelegate GetDefaultCanvasTextMaterialDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly Canvas.UpdateCanvasRectTransformDelegate UpdateCanvasRectTransformDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly Canvas.get_pixelRect_InjectedDelegate get_pixelRect_InjectedDelegateField;

		// Token: 0x02000011 RID: 17
		public sealed class WillRenderCanvases : MulticastDelegate
		{
			// Token: 0x060000B6 RID: 182 RVA: 0x00002312 File Offset: 0x00000512
			// Note: this type is marked as 'beforefieldinit'.
			static WillRenderCanvases()
			{
				Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "WillRenderCanvases");
				Canvas.WillRenderCanvases.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr, 100663396);
				Canvas.WillRenderCanvases.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr, 100663397);
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00004E68 File Offset: 0x00003068
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WillRenderCanvases(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.WillRenderCanvases.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00004EC4 File Offset: 0x000030C4
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.WillRenderCanvases.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00002350 File Offset: 0x00000550
			public WillRenderCanvases(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00002359 File Offset: 0x00000559
			public static implicit operator Canvas.WillRenderCanvases(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Canvas.WillRenderCanvases>(A_0);
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00002361 File Offset: 0x00000561
			public static Canvas.WillRenderCanvases operator +(Canvas.WillRenderCanvases A_0, Canvas.WillRenderCanvases A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Canvas.WillRenderCanvases>();
			}

			// Token: 0x060000BC RID: 188 RVA: 0x0000236F File Offset: 0x0000056F
			public static Canvas.WillRenderCanvases operator -(Canvas.WillRenderCanvases A_0, Canvas.WillRenderCanvases A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Canvas.WillRenderCanvases>();
				}
				return delegate2;
			}

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000091 RID: 145
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000BE RID: 190
		private delegate void set_renderModeDelegate(IntPtr @this, RenderMode value);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000C0 RID: 192
		private delegate bool get_overridePixelPerfectDelegate(IntPtr @this);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000C2 RID: 194
		private delegate void set_overridePixelPerfectDelegate(IntPtr @this, bool value);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000C4 RID: 196
		private delegate void set_pixelPerfectDelegate(IntPtr @this, bool value);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000C6 RID: 198
		private delegate void set_planeDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000C8 RID: 200
		private delegate void set_targetDisplayDelegate(IntPtr @this, int value);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000CA RID: 202
		private delegate int get_cachedSortingLayerValueDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000CC RID: 204
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000CE RID: 206
		private delegate void set_sortingLayerNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000D0 RID: 208
		private delegate void SetExternalCanvasEnabledDelegate(bool enabled);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000D2 RID: 210
		private delegate float get_normalizedSortingGridSizeDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000D4 RID: 212
		private delegate void set_normalizedSortingGridSizeDelegate(IntPtr @this, float value);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000D6 RID: 214
		private delegate int get_sortingGridNormalizedSizeDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000D8 RID: 216
		private delegate void set_sortingGridNormalizedSizeDelegate(IntPtr @this, int value);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000DA RID: 218
		private delegate IntPtr GetDefaultCanvasTextMaterialDelegate();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000DC RID: 220
		private delegate void UpdateCanvasRectTransformDelegate(IntPtr @this, bool alignWithCamera);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000DE RID: 222
		private delegate void get_pixelRect_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
