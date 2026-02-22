using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000025 RID: 37
	public class LayoutGroup : UIBehaviour
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x00017E44 File Offset: 0x00016044
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutGroup()
		{
			Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr);
			LayoutGroup.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_Padding");
			LayoutGroup.NativeFieldInfoPtr_m_ChildAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_ChildAlignment");
			LayoutGroup.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_Rect");
			LayoutGroup.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_Tracker");
			LayoutGroup.NativeFieldInfoPtr_m_TotalMinSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_TotalMinSize");
			LayoutGroup.NativeFieldInfoPtr_m_TotalPreferredSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_TotalPreferredSize");
			LayoutGroup.NativeFieldInfoPtr_m_TotalFlexibleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_TotalFlexibleSize");
			LayoutGroup.NativeFieldInfoPtr_m_RectChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_RectChildren");
			LayoutGroup.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663940);
			LayoutGroup.NativeMethodInfoPtr_set_padding_Public_set_Void_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663941);
			LayoutGroup.NativeMethodInfoPtr_get_childAlignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663942);
			LayoutGroup.NativeMethodInfoPtr_set_childAlignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663943);
			LayoutGroup.NativeMethodInfoPtr_get_rectTransform_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663944);
			LayoutGroup.NativeMethodInfoPtr_get_rectChildren_Protected_get_List_1_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663945);
			LayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663946);
			LayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663947);
			LayoutGroup.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663948);
			LayoutGroup.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663949);
			LayoutGroup.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663950);
			LayoutGroup.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663951);
			LayoutGroup.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663952);
			LayoutGroup.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663953);
			LayoutGroup.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663954);
			LayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663955);
			LayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663956);
			LayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663957);
			LayoutGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663958);
			LayoutGroup.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663959);
			LayoutGroup.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663960);
			LayoutGroup.NativeMethodInfoPtr_GetTotalMinSize_Protected_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663961);
			LayoutGroup.NativeMethodInfoPtr_GetTotalPreferredSize_Protected_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663962);
			LayoutGroup.NativeMethodInfoPtr_GetTotalFlexibleSize_Protected_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663963);
			LayoutGroup.NativeMethodInfoPtr_GetStartOffset_Protected_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663964);
			LayoutGroup.NativeMethodInfoPtr_GetAlignmentOnAxis_Protected_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663965);
			LayoutGroup.NativeMethodInfoPtr_SetLayoutInputForAxis_Protected_Void_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663966);
			LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663967);
			LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663968);
			LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663969);
			LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663970);
			LayoutGroup.NativeMethodInfoPtr_get_isRootLayoutGroup_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663971);
			LayoutGroup.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663972);
			LayoutGroup.NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663973);
			LayoutGroup.NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663974);
			LayoutGroup.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663975);
			LayoutGroup.NativeMethodInfoPtr_DelayedSetDirty_Private_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100663976);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x000181F8 File Offset: 0x000163F8
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00018238 File Offset: 0x00016438
		public unsafe RectOffset padding
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114863, XrefRangeEnd = 114866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_set_padding_Public_set_Void_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0001827C File Offset: 0x0001647C
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x000182B8 File Offset: 0x000164B8
		public unsafe TextAnchor childAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_childAlignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 114869, RefRangeEnd = 114873, XrefRangeStart = 114866, XrefRangeEnd = 114869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_set_childAlignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x000182F8 File Offset: 0x000164F8
		public unsafe RectTransform rectTransform
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 114880, RefRangeEnd = 114890, XrefRangeStart = 114873, XrefRangeEnd = 114880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_rectTransform_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00018338 File Offset: 0x00016538
		public unsafe List<RectTransform> rectChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_rectChildren_Protected_get_List_1_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr3) : null;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00018378 File Offset: 0x00016578
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114944, RefRangeEnd = 114947, XrefRangeStart = 114890, XrefRangeEnd = 114944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000183B4 File Offset: 0x000165B4
		[CallerCount(0)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000183F0 File Offset: 0x000165F0
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114947, XrefRangeEnd = 114948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00018438 File Offset: 0x00016638
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114948, XrefRangeEnd = 114949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00018480 File Offset: 0x00016680
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114949, XrefRangeEnd = 114950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000184C8 File Offset: 0x000166C8
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114950, XrefRangeEnd = 114951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00018510 File Offset: 0x00016710
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114951, XrefRangeEnd = 114952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00018558 File Offset: 0x00016758
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114952, XrefRangeEnd = 114953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x000185A0 File Offset: 0x000167A0
		public unsafe virtual int layoutPriority
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000185E8 File Offset: 0x000167E8
		[CallerCount(0)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00018624 File Offset: 0x00016824
		[CallerCount(0)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00018660 File Offset: 0x00016860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114970, RefRangeEnd = 114971, XrefRangeStart = 114953, XrefRangeEnd = 114970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001869C File Offset: 0x0001689C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114971, XrefRangeEnd = 114973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000186D8 File Offset: 0x000168D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114973, XrefRangeEnd = 114980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00018714 File Offset: 0x00016914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114980, XrefRangeEnd = 114981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00018750 File Offset: 0x00016950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114981, XrefRangeEnd = 114982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalMinSize(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetTotalMinSize_Protected_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001879C File Offset: 0x0001699C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114982, XrefRangeEnd = 114983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalPreferredSize(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetTotalPreferredSize_Protected_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000187E8 File Offset: 0x000169E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114983, XrefRangeEnd = 114984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalFlexibleSize(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetTotalFlexibleSize_Protected_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00018834 File Offset: 0x00016A34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114994, RefRangeEnd = 114998, XrefRangeStart = 114984, XrefRangeEnd = 114994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredSpaceWithoutPadding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetStartOffset_Protected_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001888C File Offset: 0x00016A8C
		[CallerCount(0)]
		public unsafe float GetAlignmentOnAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetAlignmentOnAxis_Protected_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x000188D8 File Offset: 0x00016AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115001, RefRangeEnd = 115003, XrefRangeStart = 114998, XrefRangeEnd = 115001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPreferred;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalFlexible;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetLayoutInputForAxis_Protected_Void_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00018940 File Offset: 0x00016B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115003, XrefRangeEnd = 115008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildAlongAxis(RectTransform rect, int axis, float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000189A0 File Offset: 0x00016BA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 115028, RefRangeEnd = 115031, XrefRangeStart = 115008, XrefRangeEnd = 115028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00018A0C File Offset: 0x00016C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115036, RefRangeEnd = 115038, XrefRangeStart = 115031, XrefRangeEnd = 115036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00018A78 File Offset: 0x00016C78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 115057, RefRangeEnd = 115060, XrefRangeStart = 115038, XrefRangeEnd = 115057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00018AF4 File Offset: 0x00016CF4
		public unsafe bool isRootLayoutGroup
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115060, XrefRangeEnd = 115078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_isRootLayoutGroup_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00018B30 File Offset: 0x00016D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115078, XrefRangeEnd = 115098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00018B6C File Offset: 0x00016D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00018BA8 File Offset: 0x00016DA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 115102, RefRangeEnd = 115109, XrefRangeStart = 115098, XrefRangeEnd = 115102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProperty<T>(ref T currentValue, T newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.MethodInfoStoreGeneric_SetProperty_Protected_Void_byref_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00018C4C File Offset: 0x00016E4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 115120, RefRangeEnd = 115125, XrefRangeStart = 115109, XrefRangeEnd = 115120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00018C80 File Offset: 0x00016E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115125, XrefRangeEnd = 115129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_DelayedSetDirty_Private_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000038C0 File Offset: 0x00001AC0
		public LayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00018CD0 File Offset: 0x00016ED0
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x000038C9 File Offset: 0x00001AC9
		public unsafe RectOffset m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00018D00 File Offset: 0x00016F00
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x000038E8 File Offset: 0x00001AE8
		public unsafe TextAnchor m_ChildAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_ChildAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_ChildAlignment)) = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00018D28 File Offset: 0x00016F28
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00003903 File Offset: 0x00001B03
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00018D58 File Offset: 0x00016F58
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00003922 File Offset: 0x00001B22
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00018D80 File Offset: 0x00016F80
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x0000393D File Offset: 0x00001B3D
		public unsafe Vector2 m_TotalMinSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalMinSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalMinSize)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00018DA8 File Offset: 0x00016FA8
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00003958 File Offset: 0x00001B58
		public unsafe Vector2 m_TotalPreferredSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalPreferredSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalPreferredSize)) = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00018DD0 File Offset: 0x00016FD0
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00003973 File Offset: 0x00001B73
		public unsafe Vector2 m_TotalFlexibleSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalFlexibleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalFlexibleSize)) = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00018DF8 File Offset: 0x00016FF8
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0000398E File Offset: 0x00001B8E
		public unsafe List<RectTransform> m_RectChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_RectChildren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_RectChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildAlignment;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalMinSize;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalPreferredSize;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalFlexibleSize;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeFieldInfoPtr_m_RectChildren;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_set_padding_Public_set_Void_RectOffset_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_get_childAlignment_Public_get_TextAnchor_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_set_childAlignment_Public_set_Void_TextAnchor_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Protected_get_RectTransform_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_get_rectChildren_Protected_get_List_1_RectTransform_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalMinSize_Protected_Single_Int32_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalPreferredSize_Protected_Single_Int32_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalFlexibleSize_Protected_Single_Int32_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_GetStartOffset_Protected_Single_Int32_Single_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_GetAlignmentOnAxis_Protected_Single_Int32_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutInputForAxis_Protected_Void_Single_Single_Single_Int32_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_Single_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_Single_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_get_isRootLayoutGroup_Private_get_Boolean_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSetDirty_Private_IEnumerator_RectTransform_0;

		// Token: 0x0200009D RID: 157
		[ObfuscatedName("UnityEngine.UI.LayoutGroup+<DelayedSetDirty>d__56")]
		public sealed class _DelayedSetDirty_d__56 : Object
		{
			// Token: 0x06000C07 RID: 3079 RVA: 0x00034C48 File Offset: 0x00032E48
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetDirty_d__56()
			{
				Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "<DelayedSetDirty>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr);
				LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, "<>1__state");
				LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, "<>2__current");
				LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, "rectTransform");
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100665010);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100665011);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100665012);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100665013);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100665014);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100665015);
			}

			// Token: 0x06000C08 RID: 3080 RVA: 0x00034D28 File Offset: 0x00032F28
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetDirty_d__56(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C09 RID: 3081 RVA: 0x00034D70 File Offset: 0x00032F70
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C0A RID: 3082 RVA: 0x00034DA4 File Offset: 0x00032FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114857, XrefRangeEnd = 114858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00034DE0 File Offset: 0x00032FE0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C0C RID: 3084 RVA: 0x00034E20 File Offset: 0x00033020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114858, XrefRangeEnd = 114863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00034E54 File Offset: 0x00033054
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C0E RID: 3086 RVA: 0x000066F9 File Offset: 0x000048F9
			public _DelayedSetDirty_d__56(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00034E94 File Offset: 0x00033094
			// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00006702 File Offset: 0x00004902
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00034EBC File Offset: 0x000330BC
			// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0000671D File Offset: 0x0000491D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00034EEC File Offset: 0x000330EC
			// (set) Token: 0x06000C14 RID: 3092 RVA: 0x0000673C File Offset: 0x0000493C
			public unsafe RectTransform rectTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr_rectTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000960 RID: 2400
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000961 RID: 2401
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000962 RID: 2402
			private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

			// Token: 0x04000963 RID: 2403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000964 RID: 2404
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000965 RID: 2405
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000966 RID: 2406
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000967 RID: 2407
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000968 RID: 2408
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200009E RID: 158
		private sealed class MethodInfoStoreGeneric_SetProperty_Protected_Void_byref_T_T_0<T>
		{
			// Token: 0x04000969 RID: 2409
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LayoutGroup.NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0, Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
