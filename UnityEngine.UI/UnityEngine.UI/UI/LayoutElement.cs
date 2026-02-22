using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000024 RID: 36
	public class LayoutElement : UIBehaviour
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0001738C File Offset: 0x0001558C
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutElement()
		{
			Il2CppClassPointerStore<LayoutElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr);
			LayoutElement.NativeFieldInfoPtr_m_IgnoreLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, "m_IgnoreLayout");
			LayoutElement.NativeFieldInfoPtr_m_MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, "m_MinWidth");
			LayoutElement.NativeFieldInfoPtr_m_MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, "m_MinHeight");
			LayoutElement.NativeFieldInfoPtr_m_PreferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, "m_PreferredWidth");
			LayoutElement.NativeFieldInfoPtr_m_PreferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, "m_PreferredHeight");
			LayoutElement.NativeFieldInfoPtr_m_FlexibleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, "m_FlexibleWidth");
			LayoutElement.NativeFieldInfoPtr_m_FlexibleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, "m_FlexibleHeight");
			LayoutElement.NativeFieldInfoPtr_m_LayoutPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, "m_LayoutPriority");
			LayoutElement.NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663915);
			LayoutElement.NativeMethodInfoPtr_set_ignoreLayout_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663916);
			LayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663917);
			LayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663918);
			LayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663919);
			LayoutElement.NativeMethodInfoPtr_set_minWidth_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663920);
			LayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663921);
			LayoutElement.NativeMethodInfoPtr_set_minHeight_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663922);
			LayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663923);
			LayoutElement.NativeMethodInfoPtr_set_preferredWidth_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663924);
			LayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663925);
			LayoutElement.NativeMethodInfoPtr_set_preferredHeight_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663926);
			LayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663927);
			LayoutElement.NativeMethodInfoPtr_set_flexibleWidth_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663928);
			LayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663929);
			LayoutElement.NativeMethodInfoPtr_set_flexibleHeight_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663930);
			LayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663931);
			LayoutElement.NativeMethodInfoPtr_set_layoutPriority_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663932);
			LayoutElement.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663933);
			LayoutElement.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663934);
			LayoutElement.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663935);
			LayoutElement.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663936);
			LayoutElement.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663937);
			LayoutElement.NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663938);
			LayoutElement.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr, 100663939);
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00017650 File Offset: 0x00015850
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00017698 File Offset: 0x00015898
		public unsafe virtual bool ignoreLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114799, XrefRangeEnd = 114803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_set_ignoreLayout_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000176E4 File Offset: 0x000158E4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00017720 File Offset: 0x00015920
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0001775C File Offset: 0x0001595C
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000177A4 File Offset: 0x000159A4
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114803, XrefRangeEnd = 114807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_set_minWidth_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000177F0 File Offset: 0x000159F0
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00017838 File Offset: 0x00015A38
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114807, XrefRangeEnd = 114811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_set_minHeight_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00017884 File Offset: 0x00015A84
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x000178CC File Offset: 0x00015ACC
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114811, XrefRangeEnd = 114815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_set_preferredWidth_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00017918 File Offset: 0x00015B18
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00017960 File Offset: 0x00015B60
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114815, XrefRangeEnd = 114819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_set_preferredHeight_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x000179AC File Offset: 0x00015BAC
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000179F4 File Offset: 0x00015BF4
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114819, XrefRangeEnd = 114823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_set_flexibleWidth_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00017A40 File Offset: 0x00015C40
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00017A88 File Offset: 0x00015C88
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114823, XrefRangeEnd = 114827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_set_flexibleHeight_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00017AD4 File Offset: 0x00015CD4
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00017B1C File Offset: 0x00015D1C
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114827, XrefRangeEnd = 114831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_set_layoutPriority_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00017B68 File Offset: 0x00015D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114831, XrefRangeEnd = 114832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutElement.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00017BA4 File Offset: 0x00015DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114832, XrefRangeEnd = 114834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00017BE0 File Offset: 0x00015DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114834, XrefRangeEnd = 114835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00017C1C File Offset: 0x00015E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114835, XrefRangeEnd = 114837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00017C58 File Offset: 0x00015E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00017C94 File Offset: 0x00015E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutElement.NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00017CD0 File Offset: 0x00015ED0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 114844, RefRangeEnd = 114857, XrefRangeStart = 114837, XrefRangeEnd = 114844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutElement.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000037DF File Offset: 0x000019DF
		public LayoutElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00017D04 File Offset: 0x00015F04
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x000037E8 File Offset: 0x000019E8
		public unsafe bool m_IgnoreLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_IgnoreLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_IgnoreLayout)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00017D2C File Offset: 0x00015F2C
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00003803 File Offset: 0x00001A03
		public unsafe float m_MinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_MinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_MinWidth)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00017D54 File Offset: 0x00015F54
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x0000381E File Offset: 0x00001A1E
		public unsafe float m_MinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_MinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_MinHeight)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00017D7C File Offset: 0x00015F7C
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00003839 File Offset: 0x00001A39
		public unsafe float m_PreferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_PreferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_PreferredWidth)) = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00017DA4 File Offset: 0x00015FA4
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00003854 File Offset: 0x00001A54
		public unsafe float m_PreferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_PreferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_PreferredHeight)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00017DCC File Offset: 0x00015FCC
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x0000386F File Offset: 0x00001A6F
		public unsafe float m_FlexibleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_FlexibleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_FlexibleWidth)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00017DF4 File Offset: 0x00015FF4
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0000388A File Offset: 0x00001A8A
		public unsafe float m_FlexibleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_FlexibleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_FlexibleHeight)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00017E1C File Offset: 0x0001601C
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x000038A5 File Offset: 0x00001AA5
		public unsafe int m_LayoutPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_LayoutPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutElement.NativeFieldInfoPtr_m_LayoutPriority)) = value;
			}
		}

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreLayout;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr_m_MinWidth;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_m_MinHeight;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_m_PreferredWidth;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_m_PreferredHeight;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_m_FlexibleWidth;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_m_FlexibleHeight;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutPriority;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreLayout_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_set_minWidth_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_set_minHeight_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_set_preferredWidth_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_set_preferredHeight_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_set_flexibleWidth_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_set_flexibleHeight_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_set_layoutPriority_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;
	}
}
