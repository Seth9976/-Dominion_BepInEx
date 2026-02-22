using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x0200002A RID: 42
	public class MaskableGraphic : Graphic
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x0001A0E4 File Offset: 0x000182E4
		// Note: this type is marked as 'beforefieldinit'.
		static MaskableGraphic()
		{
			Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MaskableGraphic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr);
			MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ShouldRecalculateStencil");
			MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_MaskMaterial");
			MaskableGraphic.NativeFieldInfoPtr_m_ParentMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ParentMask");
			MaskableGraphic.NativeFieldInfoPtr_m_Maskable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_Maskable");
			MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_IsMaskingGraphic");
			MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_IncludeForMasking");
			MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_OnCullStateChanged");
			MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ShouldRecalculate");
			MaskableGraphic.NativeFieldInfoPtr_m_StencilValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_StencilValue");
			MaskableGraphic.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_Corners");
			MaskableGraphic.NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664024);
			MaskableGraphic.NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664025);
			MaskableGraphic.NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664026);
			MaskableGraphic.NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664027);
			MaskableGraphic.NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664028);
			MaskableGraphic.NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664029);
			MaskableGraphic.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664030);
			MaskableGraphic.NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664031);
			MaskableGraphic.NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664032);
			MaskableGraphic.NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664033);
			MaskableGraphic.NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664034);
			MaskableGraphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664035);
			MaskableGraphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664036);
			MaskableGraphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664037);
			MaskableGraphic.NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664038);
			MaskableGraphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664039);
			MaskableGraphic.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664040);
			MaskableGraphic.NativeMethodInfoPtr_UpdateClipParent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664041);
			MaskableGraphic.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664042);
			MaskableGraphic.NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664043);
			MaskableGraphic.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664044);
			MaskableGraphic.NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664045);
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0001A394 File Offset: 0x00018594
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0001A3D4 File Offset: 0x000185D4
		public unsafe MaskableGraphic.CullStateChangedEvent onCullStateChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaskableGraphic.CullStateChangedEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0001A418 File Offset: 0x00018618
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0001A454 File Offset: 0x00018654
		public unsafe bool maskable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0001A494 File Offset: 0x00018694
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0001A4D0 File Offset: 0x000186D0
		public unsafe bool isMaskingGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001A510 File Offset: 0x00018710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115975, XrefRangeEnd = 115985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001A56C File Offset: 0x0001876C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115989, RefRangeEnd = 115990, XrefRangeStart = 115985, XrefRangeEnd = 115989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001A5C4 File Offset: 0x000187C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116000, RefRangeEnd = 116002, XrefRangeStart = 115990, XrefRangeEnd = 116000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCull(bool cull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001A604 File Offset: 0x00018804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116002, XrefRangeEnd = 116006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetClipRect(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001A65C File Offset: 0x0001885C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116006, XrefRangeEnd = 116009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetClipSoftness(Vector2 clipSoftness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipSoftness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001A6A8 File Offset: 0x000188A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116012, RefRangeEnd = 116014, XrefRangeStart = 116009, XrefRangeEnd = 116012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001A6E4 File Offset: 0x000188E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 116021, RefRangeEnd = 116024, XrefRangeStart = 116014, XrefRangeEnd = 116021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001A720 File Offset: 0x00018920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116027, RefRangeEnd = 116028, XrefRangeStart = 116024, XrefRangeEnd = 116027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001A75C File Offset: 0x0001895C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ParentMaskStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001A798 File Offset: 0x00018998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116031, RefRangeEnd = 116033, XrefRangeStart = 116028, XrefRangeEnd = 116031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0001A7D4 File Offset: 0x000189D4
		public unsafe Rect rootCanvasRect
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116050, RefRangeEnd = 116051, XrefRangeStart = 116033, XrefRangeEnd = 116050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001A810 File Offset: 0x00018A10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 116078, RefRangeEnd = 116083, XrefRangeStart = 116051, XrefRangeEnd = 116078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClipParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UpdateClipParent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001A844 File Offset: 0x00018A44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116084, RefRangeEnd = 116086, XrefRangeStart = 116083, XrefRangeEnd = 116084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecalculateClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001A880 File Offset: 0x00018A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116086, XrefRangeEnd = 116090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecalculateMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001A8BC File Offset: 0x00018ABC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 116101, RefRangeEnd = 116107, XrefRangeStart = 116090, XrefRangeEnd = 116101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskableGraphic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116107, XrefRangeEnd = 116108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject UnityEngine_UI_IClippable_get_gameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00003AB4 File Offset: 0x00001CB4
		public MaskableGraphic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0001A938 File Offset: 0x00018B38
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00003ABD File Offset: 0x00001CBD
		public unsafe bool m_ShouldRecalculateStencil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil)) = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0001A960 File Offset: 0x00018B60
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public unsafe Material m_MaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0001A990 File Offset: 0x00018B90
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00003AF7 File Offset: 0x00001CF7
		public unsafe RectMask2D m_ParentMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ParentMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ParentMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0001A9C0 File Offset: 0x00018BC0
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00003B16 File Offset: 0x00001D16
		public unsafe bool m_Maskable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Maskable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Maskable)) = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00003B31 File Offset: 0x00001D31
		public unsafe bool m_IsMaskingGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic)) = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001AA10 File Offset: 0x00018C10
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00003B4C File Offset: 0x00001D4C
		public unsafe bool m_IncludeForMasking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001AA38 File Offset: 0x00018C38
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00003B67 File Offset: 0x00001D67
		public unsafe MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic.CullStateChangedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0001AA68 File Offset: 0x00018C68
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00003B86 File Offset: 0x00001D86
		public unsafe bool m_ShouldRecalculate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate)) = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001AA90 File Offset: 0x00018C90
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00003BA1 File Offset: 0x00001DA1
		public unsafe int m_StencilValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_StencilValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_StencilValue)) = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00003BBC File Offset: 0x00001DBC
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculateStencil;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskMaterial;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentMask;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_m_Maskable;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMaskingGraphic;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_m_IncludeForMasking;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_m_OnCullStateChanged;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculate;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilValue;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClipParent_Private_Void_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_GameObject_0;

		// Token: 0x020000A1 RID: 161
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
			// Token: 0x06000C49 RID: 3145 RVA: 0x0000687B File Offset: 0x00004A7B
			// Note: this type is marked as 'beforefieldinit'.
			static CullStateChangedEvent()
			{
				Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "CullStateChangedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr);
				MaskableGraphic.CullStateChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr, 100665035);
			}

			// Token: 0x06000C4A RID: 3146 RVA: 0x0003597C File Offset: 0x00033B7C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 115973, RefRangeEnd = 115975, XrefRangeStart = 115970, XrefRangeEnd = 115973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CullStateChangedEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.CullStateChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C4B RID: 3147 RVA: 0x000068AF File Offset: 0x00004AAF
			public CullStateChangedEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400098A RID: 2442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
