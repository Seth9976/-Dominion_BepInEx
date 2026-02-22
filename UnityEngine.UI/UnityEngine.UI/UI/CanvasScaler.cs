using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200001A RID: 26
	public class CanvasScaler : UIBehaviour
	{
		// Token: 0x0600038B RID: 907 RVA: 0x00014A64 File Offset: 0x00012C64
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScaler()
		{
			Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "CanvasScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr);
			CanvasScaler.NativeFieldInfoPtr_m_UiScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_UiScaleMode");
			CanvasScaler.NativeFieldInfoPtr_m_ReferencePixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_ReferencePixelsPerUnit");
			CanvasScaler.NativeFieldInfoPtr_m_ScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_ScaleFactor");
			CanvasScaler.NativeFieldInfoPtr_m_ReferenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_ReferenceResolution");
			CanvasScaler.NativeFieldInfoPtr_m_ScreenMatchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_ScreenMatchMode");
			CanvasScaler.NativeFieldInfoPtr_m_MatchWidthOrHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_MatchWidthOrHeight");
			CanvasScaler.NativeFieldInfoPtr_kLogBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "kLogBase");
			CanvasScaler.NativeFieldInfoPtr_m_PhysicalUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_PhysicalUnit");
			CanvasScaler.NativeFieldInfoPtr_m_FallbackScreenDPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_FallbackScreenDPI");
			CanvasScaler.NativeFieldInfoPtr_m_DefaultSpriteDPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_DefaultSpriteDPI");
			CanvasScaler.NativeFieldInfoPtr_m_DynamicPixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_DynamicPixelsPerUnit");
			CanvasScaler.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_Canvas");
			CanvasScaler.NativeFieldInfoPtr_m_PrevScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_PrevScaleFactor");
			CanvasScaler.NativeFieldInfoPtr_m_PrevReferencePixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_PrevReferencePixelsPerUnit");
			CanvasScaler.NativeFieldInfoPtr_m_PresetInfoIsWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_PresetInfoIsWorld");
			CanvasScaler.NativeMethodInfoPtr_get_uiScaleMode_Public_get_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663816);
			CanvasScaler.NativeMethodInfoPtr_set_uiScaleMode_Public_set_Void_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663817);
			CanvasScaler.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663818);
			CanvasScaler.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663819);
			CanvasScaler.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663820);
			CanvasScaler.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663821);
			CanvasScaler.NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663822);
			CanvasScaler.NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663823);
			CanvasScaler.NativeMethodInfoPtr_get_screenMatchMode_Public_get_ScreenMatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663824);
			CanvasScaler.NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_ScreenMatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663825);
			CanvasScaler.NativeMethodInfoPtr_get_matchWidthOrHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663826);
			CanvasScaler.NativeMethodInfoPtr_set_matchWidthOrHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663827);
			CanvasScaler.NativeMethodInfoPtr_get_physicalUnit_Public_get_Unit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663828);
			CanvasScaler.NativeMethodInfoPtr_set_physicalUnit_Public_set_Void_Unit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663829);
			CanvasScaler.NativeMethodInfoPtr_get_fallbackScreenDPI_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663830);
			CanvasScaler.NativeMethodInfoPtr_set_fallbackScreenDPI_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663831);
			CanvasScaler.NativeMethodInfoPtr_get_defaultSpriteDPI_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663832);
			CanvasScaler.NativeMethodInfoPtr_set_defaultSpriteDPI_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663833);
			CanvasScaler.NativeMethodInfoPtr_get_dynamicPixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663834);
			CanvasScaler.NativeMethodInfoPtr_set_dynamicPixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663835);
			CanvasScaler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663836);
			CanvasScaler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663837);
			CanvasScaler.NativeMethodInfoPtr_Canvas_preWillRenderCanvases_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663838);
			CanvasScaler.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663839);
			CanvasScaler.NativeMethodInfoPtr_Handle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663840);
			CanvasScaler.NativeMethodInfoPtr_HandleWorldCanvas_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663841);
			CanvasScaler.NativeMethodInfoPtr_HandleConstantPixelSize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663842);
			CanvasScaler.NativeMethodInfoPtr_HandleScaleWithScreenSize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663843);
			CanvasScaler.NativeMethodInfoPtr_HandleConstantPhysicalSize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663844);
			CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663845);
			CanvasScaler.NativeMethodInfoPtr_SetReferencePixelsPerUnit_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663846);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00014E2C File Offset: 0x0001302C
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00014E68 File Offset: 0x00013068
		public unsafe CanvasScaler.ScaleMode uiScaleMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_uiScaleMode_Public_get_ScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_uiScaleMode_Public_set_Void_ScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00014EA8 File Offset: 0x000130A8
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00014EE4 File Offset: 0x000130E4
		public unsafe float referencePixelsPerUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88902, RefRangeEnd = 88904, XrefRangeStart = 88902, XrefRangeEnd = 88904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00014F24 File Offset: 0x00013124
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00014F60 File Offset: 0x00013160
		public unsafe float scaleFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114405, XrefRangeEnd = 114406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00014FA0 File Offset: 0x000131A0
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00014FDC File Offset: 0x000131DC
		public unsafe Vector2 referenceResolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114406, XrefRangeEnd = 114408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0001501C File Offset: 0x0001321C
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00015058 File Offset: 0x00013258
		public unsafe CanvasScaler.ScreenMatchMode screenMatchMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12780, RefRangeEnd = 12781, XrefRangeStart = 12780, XrefRangeEnd = 12781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_screenMatchMode_Public_get_ScreenMatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_ScreenMatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00015098 File Offset: 0x00013298
		// (set) Token: 0x06000397 RID: 919 RVA: 0x000150D4 File Offset: 0x000132D4
		public unsafe float matchWidthOrHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_matchWidthOrHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88924, RefRangeEnd = 88925, XrefRangeStart = 88924, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_matchWidthOrHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00015114 File Offset: 0x00013314
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00015150 File Offset: 0x00013350
		public unsafe CanvasScaler.Unit physicalUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_physicalUnit_Public_get_Unit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_physicalUnit_Public_set_Void_Unit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00015190 File Offset: 0x00013390
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000151CC File Offset: 0x000133CC
		public unsafe float fallbackScreenDPI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_fallbackScreenDPI_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 88926, RefRangeEnd = 88931, XrefRangeStart = 88926, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_fallbackScreenDPI_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0001520C File Offset: 0x0001340C
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00015248 File Offset: 0x00013448
		public unsafe float defaultSpriteDPI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_defaultSpriteDPI_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114408, XrefRangeEnd = 114409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_defaultSpriteDPI_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00015288 File Offset: 0x00013488
		// (set) Token: 0x0600039F RID: 927 RVA: 0x000152C4 File Offset: 0x000134C4
		public unsafe float dynamicPixelsPerUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_dynamicPixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88932, RefRangeEnd = 88933, XrefRangeStart = 88932, XrefRangeEnd = 88933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_dynamicPixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00015304 File Offset: 0x00013504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114409, XrefRangeEnd = 114410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScaler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00015340 File Offset: 0x00013540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114410, XrefRangeEnd = 114421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001537C File Offset: 0x0001357C
		[CallerCount(0)]
		public unsafe void Canvas_preWillRenderCanvases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_Canvas_preWillRenderCanvases_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000153B0 File Offset: 0x000135B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114421, XrefRangeEnd = 114432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000153EC File Offset: 0x000135EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114432, XrefRangeEnd = 114438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Handle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_Handle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00015428 File Offset: 0x00013628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114438, XrefRangeEnd = 114440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleWorldCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_HandleWorldCanvas_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00015464 File Offset: 0x00013664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114440, XrefRangeEnd = 114442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleConstantPixelSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_HandleConstantPixelSize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000154A0 File Offset: 0x000136A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114442, XrefRangeEnd = 114462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleScaleWithScreenSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_HandleScaleWithScreenSize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000154DC File Offset: 0x000136DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114462, XrefRangeEnd = 114468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleConstantPhysicalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_HandleConstantPhysicalSize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00015518 File Offset: 0x00013718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114468, XrefRangeEnd = 114469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScaleFactor(float scaleFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00015558 File Offset: 0x00013758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114469, XrefRangeEnd = 114470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref referencePixelsPerUnit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_SetReferencePixelsPerUnit_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000033AA File Offset: 0x000015AA
		public CanvasScaler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00015598 File Offset: 0x00013798
		// (set) Token: 0x060003AD RID: 941 RVA: 0x000033B3 File Offset: 0x000015B3
		public unsafe CanvasScaler.ScaleMode m_UiScaleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_UiScaleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_UiScaleMode)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003AE RID: 942 RVA: 0x000155C0 File Offset: 0x000137C0
		// (set) Token: 0x060003AF RID: 943 RVA: 0x000033CE File Offset: 0x000015CE
		public unsafe float m_ReferencePixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ReferencePixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ReferencePixelsPerUnit)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000155E8 File Offset: 0x000137E8
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x000033E9 File Offset: 0x000015E9
		public unsafe float m_ScaleFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ScaleFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ScaleFactor)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00015610 File Offset: 0x00013810
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00003404 File Offset: 0x00001604
		public unsafe Vector2 m_ReferenceResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ReferenceResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ReferenceResolution)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00015638 File Offset: 0x00013838
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0000341F File Offset: 0x0000161F
		public unsafe CanvasScaler.ScreenMatchMode m_ScreenMatchMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ScreenMatchMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ScreenMatchMode)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00015660 File Offset: 0x00013860
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0000343A File Offset: 0x0000163A
		public unsafe float m_MatchWidthOrHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_MatchWidthOrHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_MatchWidthOrHeight)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00015688 File Offset: 0x00013888
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00003455 File Offset: 0x00001655
		public unsafe static float kLogBase
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_kLogBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_kLogBase, (void*)(&value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000156A4 File Offset: 0x000138A4
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00003463 File Offset: 0x00001663
		public unsafe CanvasScaler.Unit m_PhysicalUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PhysicalUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PhysicalUnit)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003BC RID: 956 RVA: 0x000156CC File Offset: 0x000138CC
		// (set) Token: 0x060003BD RID: 957 RVA: 0x0000347E File Offset: 0x0000167E
		public unsafe float m_FallbackScreenDPI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_FallbackScreenDPI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_FallbackScreenDPI)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003BE RID: 958 RVA: 0x000156F4 File Offset: 0x000138F4
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00003499 File Offset: 0x00001699
		public unsafe float m_DefaultSpriteDPI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_DefaultSpriteDPI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_DefaultSpriteDPI)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0001571C File Offset: 0x0001391C
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x000034B4 File Offset: 0x000016B4
		public unsafe float m_DynamicPixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_DynamicPixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_DynamicPixelsPerUnit)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00015744 File Offset: 0x00013944
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000034CF File Offset: 0x000016CF
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00015774 File Offset: 0x00013974
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000034EE File Offset: 0x000016EE
		public unsafe float m_PrevScaleFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PrevScaleFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PrevScaleFactor)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0001579C File Offset: 0x0001399C
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003509 File Offset: 0x00001709
		public unsafe float m_PrevReferencePixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PrevReferencePixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PrevReferencePixelsPerUnit)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000157C4 File Offset: 0x000139C4
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00003524 File Offset: 0x00001724
		public unsafe bool m_PresetInfoIsWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PresetInfoIsWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PresetInfoIsWorld)) = value;
			}
		}

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeFieldInfoPtr_m_UiScaleMode;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_m_ReferencePixelsPerUnit;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleFactor;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_m_ReferenceResolution;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenMatchMode;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_m_MatchWidthOrHeight;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_kLogBase;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_m_PhysicalUnit;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackScreenDPI;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultSpriteDPI;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_m_DynamicPixelsPerUnit;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevScaleFactor;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevReferencePixelsPerUnit;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_m_PresetInfoIsWorld;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_get_uiScaleMode_Public_get_ScaleMode_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_set_uiScaleMode_Public_set_Void_ScaleMode_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_get_screenMatchMode_Public_get_ScreenMatchMode_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_ScreenMatchMode_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_matchWidthOrHeight_Public_get_Single_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_set_matchWidthOrHeight_Public_set_Void_Single_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_get_physicalUnit_Public_get_Unit_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_set_physicalUnit_Public_set_Void_Unit_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackScreenDPI_Public_get_Single_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackScreenDPI_Public_set_Void_Single_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteDPI_Public_get_Single_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultSpriteDPI_Public_set_Void_Single_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_get_dynamicPixelsPerUnit_Public_get_Single_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_set_dynamicPixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_Canvas_preWillRenderCanvases_Private_Void_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_Handle_Protected_Virtual_New_Void_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_HandleWorldCanvas_Protected_Virtual_New_Void_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_HandleConstantPixelSize_Protected_Virtual_New_Void_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_HandleScaleWithScreenSize_Protected_Virtual_New_Void_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_HandleConstantPhysicalSize_Protected_Virtual_New_Void_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleFactor_Protected_Void_Single_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_SetReferencePixelsPerUnit_Protected_Void_Single_0;

		// Token: 0x02000096 RID: 150
		public enum ScaleMode
		{
			// Token: 0x04000943 RID: 2371
			ConstantPixelSize,
			// Token: 0x04000944 RID: 2372
			ScaleWithScreenSize,
			// Token: 0x04000945 RID: 2373
			ConstantPhysicalSize
		}

		// Token: 0x02000097 RID: 151
		public enum ScreenMatchMode
		{
			// Token: 0x04000947 RID: 2375
			MatchWidthOrHeight,
			// Token: 0x04000948 RID: 2376
			Expand,
			// Token: 0x04000949 RID: 2377
			Shrink
		}

		// Token: 0x02000098 RID: 152
		public enum Unit
		{
			// Token: 0x0400094B RID: 2379
			Centimeters,
			// Token: 0x0400094C RID: 2380
			Millimeters,
			// Token: 0x0400094D RID: 2381
			Inches,
			// Token: 0x0400094E RID: 2382
			Points,
			// Token: 0x0400094F RID: 2383
			Picas
		}
	}
}
