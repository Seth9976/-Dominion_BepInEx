using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DD RID: 221
	public sealed class RectTransform : Transform
	{
		// Token: 0x06001308 RID: 4872 RVA: 0x00049E0C File Offset: 0x0004800C
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransform()
		{
			Il2CppClassPointerStore<RectTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransform>.NativeClassPtr);
			RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, "reapplyDrivenProperties");
			RectTransform.NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664596);
			RectTransform.NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664597);
			RectTransform.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664598);
			RectTransform.NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664599);
			RectTransform.NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664600);
			RectTransform.NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664601);
			RectTransform.NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664602);
			RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664603);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664604);
			RectTransform.NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664605);
			RectTransform.NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664606);
			RectTransform.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664607);
			RectTransform.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664608);
			RectTransform.NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664609);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664610);
			RectTransform.NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664611);
			RectTransform.NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664612);
			RectTransform.NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664613);
			RectTransform.NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664614);
			RectTransform.NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664615);
			RectTransform.NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664616);
			RectTransform.NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664617);
			RectTransform.NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664618);
			RectTransform.NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664619);
			RectTransform.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664620);
			RectTransform.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664621);
			RectTransform.NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664622);
			RectTransform.NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664623);
			RectTransform.NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664624);
			RectTransform.NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664625);
			RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664626);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664627);
			RectTransform.NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664628);
			RectTransform.NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664629);
			RectTransform.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664630);
			RectTransform.NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100664631);
			RectTransform.get_drivenByObjectDelegateField = IL2CPP.ResolveICall<RectTransform.get_drivenByObjectDelegate>("UnityEngine.RectTransform::get_drivenByObject");
			RectTransform.set_drivenByObjectDelegateField = IL2CPP.ResolveICall<RectTransform.set_drivenByObjectDelegate>("UnityEngine.RectTransform::set_drivenByObject");
			RectTransform.get_drivenPropertiesDelegateField = IL2CPP.ResolveICall<RectTransform.get_drivenPropertiesDelegate>("UnityEngine.RectTransform::get_drivenProperties");
			RectTransform.set_drivenPropertiesDelegateField = IL2CPP.ResolveICall<RectTransform.set_drivenPropertiesDelegate>("UnityEngine.RectTransform::set_drivenProperties");
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0004A15C File Offset: 0x0004835C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77012, XrefRangeEnd = 77019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0004A194 File Offset: 0x00048394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77019, XrefRangeEnd = 77026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x0004A1CC File Offset: 0x000483CC
		public unsafe Rect rect
		{
			[CallerCount(101)]
			[CachedScanResults(RefRangeStart = 77028, RefRangeEnd = 77129, XrefRangeStart = 77026, XrefRangeEnd = 77028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0004A208 File Offset: 0x00048408
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x0004A244 File Offset: 0x00048444
		public unsafe Vector2 anchorMin
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 77131, RefRangeEnd = 77148, XrefRangeStart = 77129, XrefRangeEnd = 77131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 77150, RefRangeEnd = 77216, XrefRangeStart = 77148, XrefRangeEnd = 77150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0004A284 File Offset: 0x00048484
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x0004A2C0 File Offset: 0x000484C0
		public unsafe Vector2 anchorMax
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 77218, RefRangeEnd = 77232, XrefRangeStart = 77216, XrefRangeEnd = 77218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(68)]
			[CachedScanResults(RefRangeStart = 77234, RefRangeEnd = 77302, XrefRangeStart = 77232, XrefRangeEnd = 77234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0004A300 File Offset: 0x00048500
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x0004A33C File Offset: 0x0004853C
		public unsafe Vector2 anchoredPosition
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 77304, RefRangeEnd = 77349, XrefRangeStart = 77302, XrefRangeEnd = 77304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 77351, RefRangeEnd = 77393, XrefRangeStart = 77349, XrefRangeEnd = 77351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x0004A37C File Offset: 0x0004857C
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x0004A3B8 File Offset: 0x000485B8
		public unsafe Vector2 sizeDelta
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 77395, RefRangeEnd = 77436, XrefRangeStart = 77393, XrefRangeEnd = 77395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(71)]
			[CachedScanResults(RefRangeStart = 77438, RefRangeEnd = 77509, XrefRangeStart = 77436, XrefRangeEnd = 77438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0004A3F8 File Offset: 0x000485F8
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x0004A434 File Offset: 0x00048634
		public unsafe Vector2 pivot
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 77511, RefRangeEnd = 77546, XrefRangeStart = 77509, XrefRangeEnd = 77511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 77548, RefRangeEnd = 77576, XrefRangeStart = 77546, XrefRangeEnd = 77548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x0004A474 File Offset: 0x00048674
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x0004A4B0 File Offset: 0x000486B0
		public unsafe Vector3 anchoredPosition3D
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77580, RefRangeEnd = 77581, XrefRangeStart = 77576, XrefRangeEnd = 77580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77587, RefRangeEnd = 77588, XrefRangeStart = 77581, XrefRangeEnd = 77587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x0004A4F0 File Offset: 0x000486F0
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x0004A52C File Offset: 0x0004872C
		public unsafe Vector2 offsetMin
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 77594, RefRangeEnd = 77597, XrefRangeStart = 77588, XrefRangeEnd = 77594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 77615, RefRangeEnd = 77629, XrefRangeStart = 77597, XrefRangeEnd = 77615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x0004A56C File Offset: 0x0004876C
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x0004A5A8 File Offset: 0x000487A8
		public unsafe Vector2 offsetMax
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 77637, RefRangeEnd = 77640, XrefRangeStart = 77629, XrefRangeEnd = 77637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 77658, RefRangeEnd = 77672, XrefRangeStart = 77640, XrefRangeEnd = 77658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0004A5E8 File Offset: 0x000487E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77674, RefRangeEnd = 77675, XrefRangeStart = 77672, XrefRangeEnd = 77674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdateRectTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0004A61C File Offset: 0x0004881C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77679, RefRangeEnd = 77681, XrefRangeStart = 77675, XrefRangeEnd = 77679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLocalCorners(Il2CppStructArray<Vector3> fourCornersArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fourCornersArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0004A660 File Offset: 0x00048860
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 77696, RefRangeEnd = 77710, XrefRangeStart = 77681, XrefRangeEnd = 77696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetWorldCorners(Il2CppStructArray<Vector3> fourCornersArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fourCornersArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0004A6A4 File Offset: 0x000488A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 77734, RefRangeEnd = 77741, XrefRangeStart = 77710, XrefRangeEnd = 77734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0004A6F0 File Offset: 0x000488F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77741, XrefRangeEnd = 77744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendReapplyDrivenProperties(RectTransform driven)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0004A728 File Offset: 0x00048928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77744, XrefRangeEnd = 77754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetParentSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0004A764 File Offset: 0x00048964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77754, XrefRangeEnd = 77756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0004A7A4 File Offset: 0x000489A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77756, XrefRangeEnd = 77758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchorMin_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0004A7E4 File Offset: 0x000489E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77758, XrefRangeEnd = 77760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchorMin_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0004A824 File Offset: 0x00048A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77760, XrefRangeEnd = 77762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchorMax_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0004A864 File Offset: 0x00048A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77762, XrefRangeEnd = 77764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchorMax_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0004A8A4 File Offset: 0x00048AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77764, XrefRangeEnd = 77766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchoredPosition_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0004A8E4 File Offset: 0x00048AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77766, XrefRangeEnd = 77768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchoredPosition_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0004A924 File Offset: 0x00048B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77768, XrefRangeEnd = 77770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_sizeDelta_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0004A964 File Offset: 0x00048B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77770, XrefRangeEnd = 77772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_sizeDelta_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0004A9A4 File Offset: 0x00048BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77772, XrefRangeEnd = 77774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pivot_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0004A9E4 File Offset: 0x00048BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77774, XrefRangeEnd = 77776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_pivot_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0000B3F5 File Offset: 0x000095F5
		public RectTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0004AA24 File Offset: 0x00048C24
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x0000B3FE File Offset: 0x000095FE
		public unsafe static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform.ReapplyDrivenProperties>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0004AA4C File Offset: 0x00048C4C
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x0000B410 File Offset: 0x00009610
		public Object drivenByObject
		{
			get
			{
				IntPtr intPtr = RectTransform.get_drivenByObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				RectTransform.set_drivenByObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0000B428 File Offset: 0x00009628
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x0000B43A File Offset: 0x0000963A
		public DrivenTransformProperties drivenProperties
		{
			get
			{
				return RectTransform.get_drivenPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RectTransform.set_drivenPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0004AA78 File Offset: 0x00048C78
		public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size)
		{
			int num = ((edge == RectTransform.Edge.Top || edge == RectTransform.Edge.Bottom) ? 1 : 0);
			bool flag = edge == RectTransform.Edge.Top || edge == RectTransform.Edge.Right;
			float num2 = (float)(flag ? 1 : 0);
			Vector2 vector = this.anchorMin;
			vector[num] = num2;
			this.anchorMin = vector;
			vector = this.anchorMax;
			vector[num] = num2;
			this.anchorMax = vector;
			Vector2 sizeDelta = this.sizeDelta;
			sizeDelta[num] = size;
			this.sizeDelta = sizeDelta;
			Vector2 anchoredPosition = this.anchoredPosition;
			anchoredPosition[num] = (flag ? (-inset - size * (1f - this.pivot[num])) : (inset + size * this.pivot[num]));
			this.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0004AB44 File Offset: 0x00048D44
		public Rect GetRectInParentSpace()
		{
			Rect rect = this.rect;
			Vector2 vector = this.offsetMin + Vector2.Scale(this.pivot, rect.size);
			bool flag = base.transform.parent;
			if (flag)
			{
				RectTransform component = base.transform.parent.GetComponent<RectTransform>();
				bool flag2 = component;
				if (flag2)
				{
					vector += Vector2.Scale(this.anchorMin, component.rect.size);
				}
			}
			rect.x += vector.x;
			rect.y += vector.y;
			return rect;
		}

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeFieldInfoPtr_reapplyDrivenProperties;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_GetParentSize_Private_Vector2_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly RectTransform.get_drivenByObjectDelegate get_drivenByObjectDelegateField;

		// Token: 0x04000E62 RID: 3682
		private static readonly RectTransform.set_drivenByObjectDelegate set_drivenByObjectDelegateField;

		// Token: 0x04000E63 RID: 3683
		private static readonly RectTransform.get_drivenPropertiesDelegate get_drivenPropertiesDelegateField;

		// Token: 0x04000E64 RID: 3684
		private static readonly RectTransform.set_drivenPropertiesDelegate set_drivenPropertiesDelegateField;

		// Token: 0x02000842 RID: 2114
		public enum Axis
		{
			// Token: 0x04001CB7 RID: 7351
			Horizontal,
			// Token: 0x04001CB8 RID: 7352
			Vertical
		}

		// Token: 0x02000843 RID: 2115
		public sealed class ReapplyDrivenProperties : MulticastDelegate
		{
			// Token: 0x06002E2D RID: 11821 RVA: 0x000154CA File Offset: 0x000136CA
			// Note: this type is marked as 'beforefieldinit'.
			static ReapplyDrivenProperties()
			{
				Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, "ReapplyDrivenProperties");
				RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr, 100664632);
				RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr, 100664633);
			}

			// Token: 0x06002E2E RID: 11822 RVA: 0x0006CBD4 File Offset: 0x0006ADD4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReapplyDrivenProperties(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E2F RID: 11823 RVA: 0x0006CC30 File Offset: 0x0006AE30
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(RectTransform driven)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E30 RID: 11824 RVA: 0x00015508 File Offset: 0x00013708
			public ReapplyDrivenProperties(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002E31 RID: 11825 RVA: 0x00015511 File Offset: 0x00013711
			public static implicit operator RectTransform.ReapplyDrivenProperties(Action<RectTransform> A_0)
			{
				return DelegateSupport.ConvertDelegate<RectTransform.ReapplyDrivenProperties>(A_0);
			}

			// Token: 0x06002E32 RID: 11826 RVA: 0x00015519 File Offset: 0x00013719
			public static RectTransform.ReapplyDrivenProperties operator +(RectTransform.ReapplyDrivenProperties A_0, RectTransform.ReapplyDrivenProperties A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RectTransform.ReapplyDrivenProperties>();
			}

			// Token: 0x06002E33 RID: 11827 RVA: 0x00015527 File Offset: 0x00013727
			public static RectTransform.ReapplyDrivenProperties operator -(RectTransform.ReapplyDrivenProperties A_0, RectTransform.ReapplyDrivenProperties A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RectTransform.ReapplyDrivenProperties>();
				}
				return delegate2;
			}

			// Token: 0x04001CB9 RID: 7353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CBA RID: 7354
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0;
		}

		// Token: 0x02000844 RID: 2116
		public enum Edge
		{
			// Token: 0x04001CBC RID: 7356
			Left,
			// Token: 0x04001CBD RID: 7357
			Right,
			// Token: 0x04001CBE RID: 7358
			Top,
			// Token: 0x04001CBF RID: 7359
			Bottom
		}

		// Token: 0x02000845 RID: 2117
		// (Invoke) Token: 0x06002E35 RID: 11829
		private delegate IntPtr get_drivenByObjectDelegate(IntPtr @this);

		// Token: 0x02000846 RID: 2118
		// (Invoke) Token: 0x06002E37 RID: 11831
		private delegate void set_drivenByObjectDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000847 RID: 2119
		// (Invoke) Token: 0x06002E39 RID: 11833
		private delegate DrivenTransformProperties get_drivenPropertiesDelegate(IntPtr @this);

		// Token: 0x02000848 RID: 2120
		// (Invoke) Token: 0x06002E3B RID: 11835
		private delegate void set_drivenPropertiesDelegate(IntPtr @this, DrivenTransformProperties value);
	}
}
