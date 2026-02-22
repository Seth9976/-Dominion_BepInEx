using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200001E RID: 30
	public class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00016640 File Offset: 0x00014840
		// Note: this type is marked as 'beforefieldinit'.
		static HorizontalOrVerticalLayoutGroup()
		{
			Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "HorizontalOrVerticalLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr);
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_Spacing");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildForceExpandWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildForceExpandHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildControlWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildControlHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildScaleWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildScaleHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ReverseArrangement");
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663883);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663884);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663885);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663886);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663887);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663888);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663889);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663890);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663891);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663892);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663893);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663894);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663895);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663896);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663897);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663898);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663899);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663900);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663901);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663902);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x000168A0 File Offset: 0x00014AA0
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x000168DC File Offset: 0x00014ADC
		public unsafe float spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114668, XrefRangeEnd = 114671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0001691C File Offset: 0x00014B1C
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00016958 File Offset: 0x00014B58
		public unsafe bool childForceExpandWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114671, XrefRangeEnd = 114674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00016998 File Offset: 0x00014B98
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x000169D4 File Offset: 0x00014BD4
		public unsafe bool childForceExpandHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114674, XrefRangeEnd = 114677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00016A14 File Offset: 0x00014C14
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x00016A50 File Offset: 0x00014C50
		public unsafe bool childControlWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114677, XrefRangeEnd = 114680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00016A90 File Offset: 0x00014C90
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00016ACC File Offset: 0x00014CCC
		public unsafe bool childControlHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114680, XrefRangeEnd = 114683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00016B0C File Offset: 0x00014D0C
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00016B48 File Offset: 0x00014D48
		public unsafe bool childScaleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114683, XrefRangeEnd = 114686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00016B88 File Offset: 0x00014D88
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00016BC4 File Offset: 0x00014DC4
		public unsafe bool childScaleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114686, XrefRangeEnd = 114689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00016C04 File Offset: 0x00014E04
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00016C40 File Offset: 0x00014E40
		public unsafe bool reverseArrangement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114689, XrefRangeEnd = 114692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00016C80 File Offset: 0x00014E80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114715, RefRangeEnd = 114719, XrefRangeStart = 114692, XrefRangeEnd = 114715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalcAlongAxis(int axis, bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00016CCC File Offset: 0x00014ECC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114788, RefRangeEnd = 114792, XrefRangeStart = 114719, XrefRangeEnd = 114788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildrenAlongAxis(int axis, bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00016D18 File Offset: 0x00014F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114792, XrefRangeEnd = 114799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childForceExpand;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &preferred;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flexible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00016DB4 File Offset: 0x00014FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114662, RefRangeEnd = 114663, XrefRangeStart = 114662, XrefRangeEnd = 114663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HorizontalOrVerticalLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000366C File Offset: 0x0000186C
		public HorizontalOrVerticalLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00016DF0 File Offset: 0x00014FF0
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00003675 File Offset: 0x00001875
		public unsafe float m_Spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00016E18 File Offset: 0x00015018
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00003690 File Offset: 0x00001890
		public unsafe bool m_ChildForceExpandWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00016E40 File Offset: 0x00015040
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000036AB File Offset: 0x000018AB
		public unsafe bool m_ChildForceExpandHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00016E68 File Offset: 0x00015068
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x000036C6 File Offset: 0x000018C6
		public unsafe bool m_ChildControlWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00016E90 File Offset: 0x00015090
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000036E1 File Offset: 0x000018E1
		public unsafe bool m_ChildControlHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight)) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00016EB8 File Offset: 0x000150B8
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x000036FC File Offset: 0x000018FC
		public unsafe bool m_ChildScaleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00016EE0 File Offset: 0x000150E0
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003717 File Offset: 0x00001917
		public unsafe bool m_ChildScaleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00016F08 File Offset: 0x00015108
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003732 File Offset: 0x00001932
		public unsafe bool m_ReverseArrangement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement)) = value;
			}
		}

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildForceExpandWidth;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildForceExpandHeight;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlWidth;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlHeight;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleWidth;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleHeight;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_m_ReverseArrangement;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Single_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
