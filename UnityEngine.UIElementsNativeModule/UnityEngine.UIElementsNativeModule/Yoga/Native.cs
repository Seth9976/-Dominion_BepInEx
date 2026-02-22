using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000008 RID: 8
	public static class Native : Object
	{
		// Token: 0x0600002A RID: 42 RVA: 0x0000327C File Offset: 0x0000147C
		// Note: this type is marked as 'beforefieldinit'.
		static Native()
		{
			Il2CppClassPointerStore<Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "Native");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Native>.NativeClassPtr);
			Native.NativeMethodInfoPtr_YGConfigGetDefault_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663308);
			Native.NativeMethodInfoPtr_YGConfigFree_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663309);
			Native.NativeMethodInfoPtr_YGConfigFreeInternal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663310);
			Native.NativeMethodInfoPtr_YGConfigSetPointScaleFactor_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663311);
			Native.NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663312);
			Native.NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663313);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetLeft_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663314);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetTop_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663315);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetWidth_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663316);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetHeight_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663317);
			Native.YGNodeNewDelegateField = IL2CPP.ResolveICall<Native.YGNodeNewDelegate>("UnityEngine.Yoga.Native::YGNodeNew");
			Native.YGNodeNewWithConfigDelegateField = IL2CPP.ResolveICall<Native.YGNodeNewWithConfigDelegate>("UnityEngine.Yoga.Native::YGNodeNewWithConfig");
			Native.YGNodeFreeInternalDelegateField = IL2CPP.ResolveICall<Native.YGNodeFreeInternalDelegate>("UnityEngine.Yoga.Native::YGNodeFreeInternal");
			Native.YGNodeResetDelegateField = IL2CPP.ResolveICall<Native.YGNodeResetDelegate>("UnityEngine.Yoga.Native::YGNodeReset");
			Native.YGSetManagedObjectDelegateField = IL2CPP.ResolveICall<Native.YGSetManagedObjectDelegate>("UnityEngine.Yoga.Native::YGSetManagedObject");
			Native.YGNodeSetConfigDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetConfigDelegate>("UnityEngine.Yoga.Native::YGNodeSetConfig");
			Native.YGConfigNewDelegateField = IL2CPP.ResolveICall<Native.YGConfigNewDelegate>("UnityEngine.Yoga.Native::YGConfigNew");
			Native.YGNodeGetInstanceCountDelegateField = IL2CPP.ResolveICall<Native.YGNodeGetInstanceCountDelegate>("UnityEngine.Yoga.Native::YGNodeGetInstanceCount");
			Native.YGConfigGetInstanceCountDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetInstanceCountDelegate>("UnityEngine.Yoga.Native::YGConfigGetInstanceCount");
			Native.YGConfigSetExperimentalFeatureEnabledDelegateField = IL2CPP.ResolveICall<Native.YGConfigSetExperimentalFeatureEnabledDelegate>("UnityEngine.Yoga.Native::YGConfigSetExperimentalFeatureEnabled");
			Native.YGConfigIsExperimentalFeatureEnabledDelegateField = IL2CPP.ResolveICall<Native.YGConfigIsExperimentalFeatureEnabledDelegate>("UnityEngine.Yoga.Native::YGConfigIsExperimentalFeatureEnabled");
			Native.YGConfigSetUseWebDefaultsDelegateField = IL2CPP.ResolveICall<Native.YGConfigSetUseWebDefaultsDelegate>("UnityEngine.Yoga.Native::YGConfigSetUseWebDefaults");
			Native.YGConfigGetUseWebDefaultsDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetUseWebDefaultsDelegate>("UnityEngine.Yoga.Native::YGConfigGetUseWebDefaults");
			Native.YGConfigGetPointScaleFactorDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetPointScaleFactorDelegate>("UnityEngine.Yoga.Native::YGConfigGetPointScaleFactor");
			Native.YGNodeInsertChildDelegateField = IL2CPP.ResolveICall<Native.YGNodeInsertChildDelegate>("UnityEngine.Yoga.Native::YGNodeInsertChild");
			Native.YGNodeRemoveChildDelegateField = IL2CPP.ResolveICall<Native.YGNodeRemoveChildDelegate>("UnityEngine.Yoga.Native::YGNodeRemoveChild");
			Native.YGNodeCalculateLayoutDelegateField = IL2CPP.ResolveICall<Native.YGNodeCalculateLayoutDelegate>("UnityEngine.Yoga.Native::YGNodeCalculateLayout");
			Native.YGNodeMarkDirtyDelegateField = IL2CPP.ResolveICall<Native.YGNodeMarkDirtyDelegate>("UnityEngine.Yoga.Native::YGNodeMarkDirty");
			Native.YGNodeIsDirtyDelegateField = IL2CPP.ResolveICall<Native.YGNodeIsDirtyDelegate>("UnityEngine.Yoga.Native::YGNodeIsDirty");
			Native.YGNodePrintDelegateField = IL2CPP.ResolveICall<Native.YGNodePrintDelegate>("UnityEngine.Yoga.Native::YGNodePrint");
			Native.YGNodeCopyStyleDelegateField = IL2CPP.ResolveICall<Native.YGNodeCopyStyleDelegate>("UnityEngine.Yoga.Native::YGNodeCopyStyle");
			Native.YGNodeSetMeasureFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetMeasureFuncDelegate>("UnityEngine.Yoga.Native::YGNodeSetMeasureFunc");
			Native.YGNodeRemoveMeasureFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeRemoveMeasureFuncDelegate>("UnityEngine.Yoga.Native::YGNodeRemoveMeasureFunc");
			Native.YGNodeSetBaselineFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetBaselineFuncDelegate>("UnityEngine.Yoga.Native::YGNodeSetBaselineFunc");
			Native.YGNodeRemoveBaselineFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeRemoveBaselineFuncDelegate>("UnityEngine.Yoga.Native::YGNodeRemoveBaselineFunc");
			Native.YGNodeSetHasNewLayoutDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetHasNewLayoutDelegate>("UnityEngine.Yoga.Native::YGNodeSetHasNewLayout");
			Native.YGNodeGetHasNewLayoutDelegateField = IL2CPP.ResolveICall<Native.YGNodeGetHasNewLayoutDelegate>("UnityEngine.Yoga.Native::YGNodeGetHasNewLayout");
			Native.YGNodeStyleSetDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetDirection");
			Native.YGNodeStyleGetDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetDirection");
			Native.YGNodeStyleSetFlexDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexDirection");
			Native.YGNodeStyleGetFlexDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexDirection");
			Native.YGNodeStyleSetJustifyContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetJustifyContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetJustifyContent");
			Native.YGNodeStyleGetJustifyContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetJustifyContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetJustifyContent");
			Native.YGNodeStyleSetAlignContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAlignContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAlignContent");
			Native.YGNodeStyleGetAlignContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignContent");
			Native.YGNodeStyleSetAlignItemsDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAlignItemsDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAlignItems");
			Native.YGNodeStyleGetAlignItemsDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignItemsDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignItems");
			Native.YGNodeStyleSetAlignSelfDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAlignSelfDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAlignSelf");
			Native.YGNodeStyleGetAlignSelfDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignSelfDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignSelf");
			Native.YGNodeStyleSetPositionTypeDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPositionTypeDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPositionType");
			Native.YGNodeStyleGetPositionTypeDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetPositionTypeDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetPositionType");
			Native.YGNodeStyleSetFlexWrapDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexWrapDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexWrap");
			Native.YGNodeStyleGetFlexWrapDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexWrapDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexWrap");
			Native.YGNodeStyleSetOverflowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetOverflowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetOverflow");
			Native.YGNodeStyleGetOverflowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetOverflowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetOverflow");
			Native.YGNodeStyleSetDisplayDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetDisplayDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetDisplay");
			Native.YGNodeStyleGetDisplayDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetDisplayDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetDisplay");
			Native.YGNodeStyleSetFlexDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlex");
			Native.YGNodeStyleSetFlexGrowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexGrowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexGrow");
			Native.YGNodeStyleGetFlexGrowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexGrowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexGrow");
			Native.YGNodeStyleSetFlexShrinkDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexShrinkDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexShrink");
			Native.YGNodeStyleGetFlexShrinkDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexShrinkDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexShrink");
			Native.YGNodeStyleSetFlexBasisDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexBasisDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexBasis");
			Native.YGNodeStyleSetFlexBasisPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexBasisPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexBasisPercent");
			Native.YGNodeStyleSetFlexBasisAutoDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexBasisAutoDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexBasisAuto");
			Native.YGNodeGetComputedFlexBasisDelegateField = IL2CPP.ResolveICall<Native.YGNodeGetComputedFlexBasisDelegate>("UnityEngine.Yoga.Native::YGNodeGetComputedFlexBasis");
			Native.YGNodeStyleSetWidthDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetWidthDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetWidth");
			Native.YGNodeStyleSetWidthPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetWidthPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetWidthPercent");
			Native.YGNodeStyleSetWidthAutoDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetWidthAutoDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetWidthAuto");
			Native.YGNodeStyleSetHeightDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetHeightDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetHeight");
			Native.YGNodeStyleSetHeightPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetHeightPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetHeightPercent");
			Native.YGNodeStyleSetHeightAutoDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetHeightAutoDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetHeightAuto");
			Native.YGNodeStyleSetMinWidthDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMinWidthDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMinWidth");
			Native.YGNodeStyleSetMinWidthPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMinWidthPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMinWidthPercent");
			Native.YGNodeStyleSetMinHeightDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMinHeightDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMinHeight");
			Native.YGNodeStyleSetMinHeightPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMinHeightPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMinHeightPercent");
			Native.YGNodeStyleSetMaxWidthDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMaxWidthDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMaxWidth");
			Native.YGNodeStyleSetMaxWidthPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMaxWidthPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMaxWidthPercent");
			Native.YGNodeStyleSetMaxHeightDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMaxHeightDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMaxHeight");
			Native.YGNodeStyleSetMaxHeightPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMaxHeightPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMaxHeightPercent");
			Native.YGNodeStyleSetAspectRatioDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAspectRatioDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAspectRatio");
			Native.YGNodeStyleGetAspectRatioDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAspectRatioDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAspectRatio");
			Native.YGNodeStyleSetPositionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPositionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPosition");
			Native.YGNodeStyleSetPositionPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPositionPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPositionPercent");
			Native.YGNodeStyleSetMarginDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMarginDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMargin");
			Native.YGNodeStyleSetMarginPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMarginPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMarginPercent");
			Native.YGNodeStyleSetMarginAutoDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMarginAutoDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMarginAuto");
			Native.YGNodeStyleSetPaddingDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPaddingDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPadding");
			Native.YGNodeStyleSetPaddingPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPaddingPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPaddingPercent");
			Native.YGNodeStyleSetBorderDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetBorderDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetBorder");
			Native.YGNodeStyleGetBorderDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetBorderDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetBorder");
			Native.YGNodeLayoutGetRightDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetRightDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetRight");
			Native.YGNodeLayoutGetBottomDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetBottomDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetBottom");
			Native.YGNodeLayoutGetMarginDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetMarginDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetMargin");
			Native.YGNodeLayoutGetPaddingDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetPaddingDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetPadding");
			Native.YGNodeLayoutGetDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetDirection");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003880 File Offset: 0x00001A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89401, XrefRangeEnd = 89403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr YGConfigGetDefault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigGetDefault_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000038B0 File Offset: 0x00001AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89403, XrefRangeEnd = 89407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGConfigFree(IntPtr config)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigFree_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000038E4 File Offset: 0x00001AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89407, XrefRangeEnd = 89409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGConfigFreeInternal(IntPtr config)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigFreeInternal_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003918 File Offset: 0x00001B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89409, XrefRangeEnd = 89411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsInPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigSetPointScaleFactor_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003958 File Offset: 0x00001B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89411, XrefRangeEnd = 89413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000039D4 File Offset: 0x00001BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89413, XrefRangeEnd = 89415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003A34 File Offset: 0x00001C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89415, XrefRangeEnd = 89417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetLeft(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetLeft_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003A74 File Offset: 0x00001C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89417, XrefRangeEnd = 89419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetTop(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetTop_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003AB4 File Offset: 0x00001CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89419, XrefRangeEnd = 89421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetWidth(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetWidth_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89421, XrefRangeEnd = 89423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetHeight(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetHeight_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000216F File Offset: 0x0000036F
		public Native(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002178 File Offset: 0x00000378
		public static IntPtr YGNodeNew()
		{
			return Native.YGNodeNewDelegateField();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002184 File Offset: 0x00000384
		public static IntPtr YGNodeNewWithConfig(IntPtr config)
		{
			return Native.YGNodeNewWithConfigDelegateField(config);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003B34 File Offset: 0x00001D34
		public static void YGNodeFree(IntPtr ygNode)
		{
			bool flag = ygNode == IntPtr.Zero;
			if (!flag)
			{
				Native.YGNodeFreeInternal(ygNode);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002191 File Offset: 0x00000391
		public static void YGNodeFreeInternal(IntPtr ygNode)
		{
			Native.YGNodeFreeInternalDelegateField(ygNode);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000219E File Offset: 0x0000039E
		public static void YGNodeReset(IntPtr node)
		{
			Native.YGNodeResetDelegateField(node);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000021AB File Offset: 0x000003AB
		public static void YGSetManagedObject(IntPtr ygNode, YogaNode node)
		{
			Native.YGSetManagedObjectDelegateField(ygNode, IL2CPP.Il2CppObjectBaseToPtr(node));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000021BE File Offset: 0x000003BE
		public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config)
		{
			Native.YGNodeSetConfigDelegateField(ygNode, config);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021CC File Offset: 0x000003CC
		public static IntPtr YGConfigNew()
		{
			return Native.YGConfigNewDelegateField();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000021D8 File Offset: 0x000003D8
		public static int YGNodeGetInstanceCount()
		{
			return Native.YGNodeGetInstanceCountDelegateField();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021E4 File Offset: 0x000003E4
		public static int YGConfigGetInstanceCount()
		{
			return Native.YGConfigGetInstanceCountDelegateField();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021F0 File Offset: 0x000003F0
		public static void YGConfigSetExperimentalFeatureEnabled(IntPtr config, YogaExperimentalFeature feature, bool enabled)
		{
			Native.YGConfigSetExperimentalFeatureEnabledDelegateField(config, feature, enabled);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000021FF File Offset: 0x000003FF
		public static bool YGConfigIsExperimentalFeatureEnabled(IntPtr config, YogaExperimentalFeature feature)
		{
			return Native.YGConfigIsExperimentalFeatureEnabledDelegateField(config, feature);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000220D File Offset: 0x0000040D
		public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults)
		{
			Native.YGConfigSetUseWebDefaultsDelegateField(config, useWebDefaults);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000221B File Offset: 0x0000041B
		public static bool YGConfigGetUseWebDefaults(IntPtr config)
		{
			return Native.YGConfigGetUseWebDefaultsDelegateField(config);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002228 File Offset: 0x00000428
		public static float YGConfigGetPointScaleFactor(IntPtr config)
		{
			return Native.YGConfigGetPointScaleFactorDelegateField(config);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002235 File Offset: 0x00000435
		public static void YGNodeInsertChild(IntPtr node, IntPtr child, uint index)
		{
			Native.YGNodeInsertChildDelegateField(node, child, index);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002244 File Offset: 0x00000444
		public static void YGNodeRemoveChild(IntPtr node, IntPtr child)
		{
			Native.YGNodeRemoveChildDelegateField(node, child);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002252 File Offset: 0x00000452
		public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection)
		{
			Native.YGNodeCalculateLayoutDelegateField(node, availableWidth, availableHeight, parentDirection);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002262 File Offset: 0x00000462
		public static void YGNodeMarkDirty(IntPtr node)
		{
			Native.YGNodeMarkDirtyDelegateField(node);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000226F File Offset: 0x0000046F
		public static bool YGNodeIsDirty(IntPtr node)
		{
			return Native.YGNodeIsDirtyDelegateField(node);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000227C File Offset: 0x0000047C
		public static void YGNodePrint(IntPtr node, YogaPrintOptions options)
		{
			Native.YGNodePrintDelegateField(node, options);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000228A File Offset: 0x0000048A
		public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode)
		{
			Native.YGNodeCopyStyleDelegateField(dstNode, srcNode);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002298 File Offset: 0x00000498
		public static void YGNodeSetMeasureFunc(IntPtr node)
		{
			Native.YGNodeSetMeasureFuncDelegateField(node);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000022A5 File Offset: 0x000004A5
		public static void YGNodeRemoveMeasureFunc(IntPtr node)
		{
			Native.YGNodeRemoveMeasureFuncDelegateField(node);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000022B2 File Offset: 0x000004B2
		public static void YGNodeSetBaselineFunc(IntPtr node)
		{
			Native.YGNodeSetBaselineFuncDelegateField(node);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000022BF File Offset: 0x000004BF
		public static void YGNodeRemoveBaselineFunc(IntPtr node)
		{
			Native.YGNodeRemoveBaselineFuncDelegateField(node);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000022CC File Offset: 0x000004CC
		public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout)
		{
			Native.YGNodeSetHasNewLayoutDelegateField(node, hasNewLayout);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000022DA File Offset: 0x000004DA
		public static bool YGNodeGetHasNewLayout(IntPtr node)
		{
			return Native.YGNodeGetHasNewLayoutDelegateField(node);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000022E7 File Offset: 0x000004E7
		public static void YGNodeStyleSetDirection(IntPtr node, YogaDirection direction)
		{
			Native.YGNodeStyleSetDirectionDelegateField(node, direction);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000022F5 File Offset: 0x000004F5
		public static YogaDirection YGNodeStyleGetDirection(IntPtr node)
		{
			return Native.YGNodeStyleGetDirectionDelegateField(node);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002302 File Offset: 0x00000502
		public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection)
		{
			Native.YGNodeStyleSetFlexDirectionDelegateField(node, flexDirection);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002310 File Offset: 0x00000510
		public static YogaFlexDirection YGNodeStyleGetFlexDirection(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexDirectionDelegateField(node);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000231D File Offset: 0x0000051D
		public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent)
		{
			Native.YGNodeStyleSetJustifyContentDelegateField(node, justifyContent);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000232B File Offset: 0x0000052B
		public static YogaJustify YGNodeStyleGetJustifyContent(IntPtr node)
		{
			return Native.YGNodeStyleGetJustifyContentDelegateField(node);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002338 File Offset: 0x00000538
		public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent)
		{
			Native.YGNodeStyleSetAlignContentDelegateField(node, alignContent);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002346 File Offset: 0x00000546
		public static YogaAlign YGNodeStyleGetAlignContent(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignContentDelegateField(node);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002353 File Offset: 0x00000553
		public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems)
		{
			Native.YGNodeStyleSetAlignItemsDelegateField(node, alignItems);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002361 File Offset: 0x00000561
		public static YogaAlign YGNodeStyleGetAlignItems(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignItemsDelegateField(node);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000236E File Offset: 0x0000056E
		public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf)
		{
			Native.YGNodeStyleSetAlignSelfDelegateField(node, alignSelf);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000237C File Offset: 0x0000057C
		public static YogaAlign YGNodeStyleGetAlignSelf(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignSelfDelegateField(node);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002389 File Offset: 0x00000589
		public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType)
		{
			Native.YGNodeStyleSetPositionTypeDelegateField(node, positionType);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002397 File Offset: 0x00000597
		public static YogaPositionType YGNodeStyleGetPositionType(IntPtr node)
		{
			return Native.YGNodeStyleGetPositionTypeDelegateField(node);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000023A4 File Offset: 0x000005A4
		public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap)
		{
			Native.YGNodeStyleSetFlexWrapDelegateField(node, flexWrap);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000023B2 File Offset: 0x000005B2
		public static YogaWrap YGNodeStyleGetFlexWrap(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexWrapDelegateField(node);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000023BF File Offset: 0x000005BF
		public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap)
		{
			Native.YGNodeStyleSetOverflowDelegateField(node, flexWrap);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000023CD File Offset: 0x000005CD
		public static YogaOverflow YGNodeStyleGetOverflow(IntPtr node)
		{
			return Native.YGNodeStyleGetOverflowDelegateField(node);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000023DA File Offset: 0x000005DA
		public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display)
		{
			Native.YGNodeStyleSetDisplayDelegateField(node, display);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000023E8 File Offset: 0x000005E8
		public static YogaDisplay YGNodeStyleGetDisplay(IntPtr node)
		{
			return Native.YGNodeStyleGetDisplayDelegateField(node);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000023F5 File Offset: 0x000005F5
		public static void YGNodeStyleSetFlex(IntPtr node, float flex)
		{
			Native.YGNodeStyleSetFlexDelegateField(node, flex);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002403 File Offset: 0x00000603
		public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow)
		{
			Native.YGNodeStyleSetFlexGrowDelegateField(node, flexGrow);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002411 File Offset: 0x00000611
		public static float YGNodeStyleGetFlexGrow(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexGrowDelegateField(node);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000241E File Offset: 0x0000061E
		public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink)
		{
			Native.YGNodeStyleSetFlexShrinkDelegateField(node, flexShrink);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000242C File Offset: 0x0000062C
		public static float YGNodeStyleGetFlexShrink(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexShrinkDelegateField(node);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002439 File Offset: 0x00000639
		public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis)
		{
			Native.YGNodeStyleSetFlexBasisDelegateField(node, flexBasis);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002447 File Offset: 0x00000647
		public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis)
		{
			Native.YGNodeStyleSetFlexBasisPercentDelegateField(node, flexBasis);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002455 File Offset: 0x00000655
		public static void YGNodeStyleSetFlexBasisAuto(IntPtr node)
		{
			Native.YGNodeStyleSetFlexBasisAutoDelegateField(node);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002462 File Offset: 0x00000662
		public static float YGNodeGetComputedFlexBasis(IntPtr node)
		{
			return Native.YGNodeGetComputedFlexBasisDelegateField(node);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000246F File Offset: 0x0000066F
		public static void YGNodeStyleSetWidth(IntPtr node, float width)
		{
			Native.YGNodeStyleSetWidthDelegateField(node, width);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000247D File Offset: 0x0000067D
		public static void YGNodeStyleSetWidthPercent(IntPtr node, float width)
		{
			Native.YGNodeStyleSetWidthPercentDelegateField(node, width);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000248B File Offset: 0x0000068B
		public static void YGNodeStyleSetWidthAuto(IntPtr node)
		{
			Native.YGNodeStyleSetWidthAutoDelegateField(node);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002498 File Offset: 0x00000698
		public static void YGNodeStyleSetHeight(IntPtr node, float height)
		{
			Native.YGNodeStyleSetHeightDelegateField(node, height);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000024A6 File Offset: 0x000006A6
		public static void YGNodeStyleSetHeightPercent(IntPtr node, float height)
		{
			Native.YGNodeStyleSetHeightPercentDelegateField(node, height);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000024B4 File Offset: 0x000006B4
		public static void YGNodeStyleSetHeightAuto(IntPtr node)
		{
			Native.YGNodeStyleSetHeightAutoDelegateField(node);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000024C1 File Offset: 0x000006C1
		public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth)
		{
			Native.YGNodeStyleSetMinWidthDelegateField(node, minWidth);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000024CF File Offset: 0x000006CF
		public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth)
		{
			Native.YGNodeStyleSetMinWidthPercentDelegateField(node, minWidth);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000024DD File Offset: 0x000006DD
		public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight)
		{
			Native.YGNodeStyleSetMinHeightDelegateField(node, minHeight);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000024EB File Offset: 0x000006EB
		public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight)
		{
			Native.YGNodeStyleSetMinHeightPercentDelegateField(node, minHeight);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000024F9 File Offset: 0x000006F9
		public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth)
		{
			Native.YGNodeStyleSetMaxWidthDelegateField(node, maxWidth);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002507 File Offset: 0x00000707
		public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth)
		{
			Native.YGNodeStyleSetMaxWidthPercentDelegateField(node, maxWidth);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002515 File Offset: 0x00000715
		public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight)
		{
			Native.YGNodeStyleSetMaxHeightDelegateField(node, maxHeight);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002523 File Offset: 0x00000723
		public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight)
		{
			Native.YGNodeStyleSetMaxHeightPercentDelegateField(node, maxHeight);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002531 File Offset: 0x00000731
		public static void YGNodeStyleSetAspectRatio(IntPtr node, float aspectRatio)
		{
			Native.YGNodeStyleSetAspectRatioDelegateField(node, aspectRatio);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000253F File Offset: 0x0000073F
		public static float YGNodeStyleGetAspectRatio(IntPtr node)
		{
			return Native.YGNodeStyleGetAspectRatioDelegateField(node);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000254C File Offset: 0x0000074C
		public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position)
		{
			Native.YGNodeStyleSetPositionDelegateField(node, edge, position);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000255B File Offset: 0x0000075B
		public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position)
		{
			Native.YGNodeStyleSetPositionPercentDelegateField(node, edge, position);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000256A File Offset: 0x0000076A
		public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin)
		{
			Native.YGNodeStyleSetMarginDelegateField(node, edge, margin);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002579 File Offset: 0x00000779
		public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin)
		{
			Native.YGNodeStyleSetMarginPercentDelegateField(node, edge, margin);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002588 File Offset: 0x00000788
		public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge)
		{
			Native.YGNodeStyleSetMarginAutoDelegateField(node, edge);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002596 File Offset: 0x00000796
		public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding)
		{
			Native.YGNodeStyleSetPaddingDelegateField(node, edge, padding);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000025A5 File Offset: 0x000007A5
		public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding)
		{
			Native.YGNodeStyleSetPaddingPercentDelegateField(node, edge, padding);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000025B4 File Offset: 0x000007B4
		public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border)
		{
			Native.YGNodeStyleSetBorderDelegateField(node, edge, border);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000025C3 File Offset: 0x000007C3
		public static float YGNodeStyleGetBorder(IntPtr node, YogaEdge edge)
		{
			return Native.YGNodeStyleGetBorderDelegateField(node, edge);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000025D1 File Offset: 0x000007D1
		public static float YGNodeLayoutGetRight(IntPtr node)
		{
			return Native.YGNodeLayoutGetRightDelegateField(node);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000025DE File Offset: 0x000007DE
		public static float YGNodeLayoutGetBottom(IntPtr node)
		{
			return Native.YGNodeLayoutGetBottomDelegateField(node);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000025EB File Offset: 0x000007EB
		public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge)
		{
			return Native.YGNodeLayoutGetMarginDelegateField(node, edge);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000025F9 File Offset: 0x000007F9
		public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge)
		{
			return Native.YGNodeLayoutGetPaddingDelegateField(node, edge);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002607 File Offset: 0x00000807
		public static YogaDirection YGNodeLayoutGetDirection(IntPtr node)
		{
			return Native.YGNodeLayoutGetDirectionDelegateField(node);
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigGetDefault_Public_Static_IntPtr_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigFree_Public_Static_Void_IntPtr_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigFreeInternal_Private_Static_Void_IntPtr_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigSetPointScaleFactor_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetLeft_Public_Static_Single_IntPtr_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetTop_Public_Static_Single_IntPtr_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetWidth_Public_Static_Single_IntPtr_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetHeight_Public_Static_Single_IntPtr_0;

		// Token: 0x04000022 RID: 34
		private static readonly Native.YGNodeNewDelegate YGNodeNewDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly Native.YGNodeNewWithConfigDelegate YGNodeNewWithConfigDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly Native.YGNodeFreeInternalDelegate YGNodeFreeInternalDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly Native.YGNodeResetDelegate YGNodeResetDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly Native.YGSetManagedObjectDelegate YGSetManagedObjectDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly Native.YGNodeSetConfigDelegate YGNodeSetConfigDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly Native.YGConfigNewDelegate YGConfigNewDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly Native.YGNodeGetInstanceCountDelegate YGNodeGetInstanceCountDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly Native.YGConfigGetInstanceCountDelegate YGConfigGetInstanceCountDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly Native.YGConfigSetExperimentalFeatureEnabledDelegate YGConfigSetExperimentalFeatureEnabledDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly Native.YGConfigIsExperimentalFeatureEnabledDelegate YGConfigIsExperimentalFeatureEnabledDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly Native.YGConfigSetUseWebDefaultsDelegate YGConfigSetUseWebDefaultsDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly Native.YGConfigGetUseWebDefaultsDelegate YGConfigGetUseWebDefaultsDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly Native.YGConfigGetPointScaleFactorDelegate YGConfigGetPointScaleFactorDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly Native.YGNodeInsertChildDelegate YGNodeInsertChildDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly Native.YGNodeRemoveChildDelegate YGNodeRemoveChildDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly Native.YGNodeCalculateLayoutDelegate YGNodeCalculateLayoutDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly Native.YGNodeMarkDirtyDelegate YGNodeMarkDirtyDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly Native.YGNodeIsDirtyDelegate YGNodeIsDirtyDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly Native.YGNodePrintDelegate YGNodePrintDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly Native.YGNodeCopyStyleDelegate YGNodeCopyStyleDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly Native.YGNodeSetMeasureFuncDelegate YGNodeSetMeasureFuncDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly Native.YGNodeRemoveMeasureFuncDelegate YGNodeRemoveMeasureFuncDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly Native.YGNodeSetBaselineFuncDelegate YGNodeSetBaselineFuncDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly Native.YGNodeRemoveBaselineFuncDelegate YGNodeRemoveBaselineFuncDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly Native.YGNodeSetHasNewLayoutDelegate YGNodeSetHasNewLayoutDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly Native.YGNodeGetHasNewLayoutDelegate YGNodeGetHasNewLayoutDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly Native.YGNodeStyleSetDirectionDelegate YGNodeStyleSetDirectionDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly Native.YGNodeStyleGetDirectionDelegate YGNodeStyleGetDirectionDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly Native.YGNodeStyleSetFlexDirectionDelegate YGNodeStyleSetFlexDirectionDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly Native.YGNodeStyleGetFlexDirectionDelegate YGNodeStyleGetFlexDirectionDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly Native.YGNodeStyleSetJustifyContentDelegate YGNodeStyleSetJustifyContentDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly Native.YGNodeStyleGetJustifyContentDelegate YGNodeStyleGetJustifyContentDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly Native.YGNodeStyleSetAlignContentDelegate YGNodeStyleSetAlignContentDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly Native.YGNodeStyleGetAlignContentDelegate YGNodeStyleGetAlignContentDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly Native.YGNodeStyleSetAlignItemsDelegate YGNodeStyleSetAlignItemsDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly Native.YGNodeStyleGetAlignItemsDelegate YGNodeStyleGetAlignItemsDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly Native.YGNodeStyleSetAlignSelfDelegate YGNodeStyleSetAlignSelfDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly Native.YGNodeStyleGetAlignSelfDelegate YGNodeStyleGetAlignSelfDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly Native.YGNodeStyleSetPositionTypeDelegate YGNodeStyleSetPositionTypeDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly Native.YGNodeStyleGetPositionTypeDelegate YGNodeStyleGetPositionTypeDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly Native.YGNodeStyleSetFlexWrapDelegate YGNodeStyleSetFlexWrapDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly Native.YGNodeStyleGetFlexWrapDelegate YGNodeStyleGetFlexWrapDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly Native.YGNodeStyleSetOverflowDelegate YGNodeStyleSetOverflowDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly Native.YGNodeStyleGetOverflowDelegate YGNodeStyleGetOverflowDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly Native.YGNodeStyleSetDisplayDelegate YGNodeStyleSetDisplayDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly Native.YGNodeStyleGetDisplayDelegate YGNodeStyleGetDisplayDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly Native.YGNodeStyleSetFlexDelegate YGNodeStyleSetFlexDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly Native.YGNodeStyleSetFlexGrowDelegate YGNodeStyleSetFlexGrowDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly Native.YGNodeStyleGetFlexGrowDelegate YGNodeStyleGetFlexGrowDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly Native.YGNodeStyleSetFlexShrinkDelegate YGNodeStyleSetFlexShrinkDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly Native.YGNodeStyleGetFlexShrinkDelegate YGNodeStyleGetFlexShrinkDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly Native.YGNodeStyleSetFlexBasisDelegate YGNodeStyleSetFlexBasisDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly Native.YGNodeStyleSetFlexBasisPercentDelegate YGNodeStyleSetFlexBasisPercentDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly Native.YGNodeStyleSetFlexBasisAutoDelegate YGNodeStyleSetFlexBasisAutoDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly Native.YGNodeGetComputedFlexBasisDelegate YGNodeGetComputedFlexBasisDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly Native.YGNodeStyleSetWidthDelegate YGNodeStyleSetWidthDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Native.YGNodeStyleSetWidthPercentDelegate YGNodeStyleSetWidthPercentDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Native.YGNodeStyleSetWidthAutoDelegate YGNodeStyleSetWidthAutoDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Native.YGNodeStyleSetHeightDelegate YGNodeStyleSetHeightDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Native.YGNodeStyleSetHeightPercentDelegate YGNodeStyleSetHeightPercentDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Native.YGNodeStyleSetHeightAutoDelegate YGNodeStyleSetHeightAutoDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Native.YGNodeStyleSetMinWidthDelegate YGNodeStyleSetMinWidthDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Native.YGNodeStyleSetMinWidthPercentDelegate YGNodeStyleSetMinWidthPercentDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Native.YGNodeStyleSetMinHeightDelegate YGNodeStyleSetMinHeightDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Native.YGNodeStyleSetMinHeightPercentDelegate YGNodeStyleSetMinHeightPercentDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Native.YGNodeStyleSetMaxWidthDelegate YGNodeStyleSetMaxWidthDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Native.YGNodeStyleSetMaxWidthPercentDelegate YGNodeStyleSetMaxWidthPercentDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Native.YGNodeStyleSetMaxHeightDelegate YGNodeStyleSetMaxHeightDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Native.YGNodeStyleSetMaxHeightPercentDelegate YGNodeStyleSetMaxHeightPercentDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Native.YGNodeStyleSetAspectRatioDelegate YGNodeStyleSetAspectRatioDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Native.YGNodeStyleGetAspectRatioDelegate YGNodeStyleGetAspectRatioDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Native.YGNodeStyleSetPositionDelegate YGNodeStyleSetPositionDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Native.YGNodeStyleSetPositionPercentDelegate YGNodeStyleSetPositionPercentDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Native.YGNodeStyleSetMarginDelegate YGNodeStyleSetMarginDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Native.YGNodeStyleSetMarginPercentDelegate YGNodeStyleSetMarginPercentDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Native.YGNodeStyleSetMarginAutoDelegate YGNodeStyleSetMarginAutoDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Native.YGNodeStyleSetPaddingDelegate YGNodeStyleSetPaddingDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Native.YGNodeStyleSetPaddingPercentDelegate YGNodeStyleSetPaddingPercentDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Native.YGNodeStyleSetBorderDelegate YGNodeStyleSetBorderDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly Native.YGNodeStyleGetBorderDelegate YGNodeStyleGetBorderDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly Native.YGNodeLayoutGetRightDelegate YGNodeLayoutGetRightDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly Native.YGNodeLayoutGetBottomDelegate YGNodeLayoutGetBottomDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly Native.YGNodeLayoutGetMarginDelegate YGNodeLayoutGetMarginDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly Native.YGNodeLayoutGetPaddingDelegate YGNodeLayoutGetPaddingDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly Native.YGNodeLayoutGetDirectionDelegate YGNodeLayoutGetDirectionDelegateField;

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000154 RID: 340
		private delegate IntPtr YGNodeNewDelegate();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000156 RID: 342
		private delegate IntPtr YGNodeNewWithConfigDelegate(IntPtr config);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000158 RID: 344
		private delegate void YGNodeFreeInternalDelegate(IntPtr ygNode);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x0600015A RID: 346
		private delegate void YGNodeResetDelegate(IntPtr node);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x0600015C RID: 348
		private delegate void YGSetManagedObjectDelegate(IntPtr ygNode, IntPtr node);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600015E RID: 350
		private delegate void YGNodeSetConfigDelegate(IntPtr ygNode, IntPtr config);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000160 RID: 352
		private delegate IntPtr YGConfigNewDelegate();

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000162 RID: 354
		private delegate int YGNodeGetInstanceCountDelegate();

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000164 RID: 356
		private delegate int YGConfigGetInstanceCountDelegate();

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000166 RID: 358
		private delegate void YGConfigSetExperimentalFeatureEnabledDelegate(IntPtr config, YogaExperimentalFeature feature, bool enabled);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000168 RID: 360
		private delegate bool YGConfigIsExperimentalFeatureEnabledDelegate(IntPtr config, YogaExperimentalFeature feature);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600016A RID: 362
		private delegate void YGConfigSetUseWebDefaultsDelegate(IntPtr config, bool useWebDefaults);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate bool YGConfigGetUseWebDefaultsDelegate(IntPtr config);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate float YGConfigGetPointScaleFactorDelegate(IntPtr config);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate void YGNodeInsertChildDelegate(IntPtr node, IntPtr child, uint index);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate void YGNodeRemoveChildDelegate(IntPtr node, IntPtr child);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate void YGNodeCalculateLayoutDelegate(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate void YGNodeMarkDirtyDelegate(IntPtr node);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate bool YGNodeIsDirtyDelegate(IntPtr node);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate void YGNodePrintDelegate(IntPtr node, YogaPrintOptions options);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate void YGNodeCopyStyleDelegate(IntPtr dstNode, IntPtr srcNode);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate void YGNodeSetMeasureFuncDelegate(IntPtr node);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate void YGNodeRemoveMeasureFuncDelegate(IntPtr node);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate void YGNodeSetBaselineFuncDelegate(IntPtr node);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate void YGNodeRemoveBaselineFuncDelegate(IntPtr node);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate void YGNodeSetHasNewLayoutDelegate(IntPtr node, bool hasNewLayout);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate bool YGNodeGetHasNewLayoutDelegate(IntPtr node);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate void YGNodeStyleSetDirectionDelegate(IntPtr node, YogaDirection direction);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate YogaDirection YGNodeStyleGetDirectionDelegate(IntPtr node);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate void YGNodeStyleSetFlexDirectionDelegate(IntPtr node, YogaFlexDirection flexDirection);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000190 RID: 400
		private delegate YogaFlexDirection YGNodeStyleGetFlexDirectionDelegate(IntPtr node);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000192 RID: 402
		private delegate void YGNodeStyleSetJustifyContentDelegate(IntPtr node, YogaJustify justifyContent);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000194 RID: 404
		private delegate YogaJustify YGNodeStyleGetJustifyContentDelegate(IntPtr node);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000196 RID: 406
		private delegate void YGNodeStyleSetAlignContentDelegate(IntPtr node, YogaAlign alignContent);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate YogaAlign YGNodeStyleGetAlignContentDelegate(IntPtr node);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate void YGNodeStyleSetAlignItemsDelegate(IntPtr node, YogaAlign alignItems);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x0600019C RID: 412
		private delegate YogaAlign YGNodeStyleGetAlignItemsDelegate(IntPtr node);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600019E RID: 414
		private delegate void YGNodeStyleSetAlignSelfDelegate(IntPtr node, YogaAlign alignSelf);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060001A0 RID: 416
		private delegate YogaAlign YGNodeStyleGetAlignSelfDelegate(IntPtr node);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate void YGNodeStyleSetPositionTypeDelegate(IntPtr node, YogaPositionType positionType);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate YogaPositionType YGNodeStyleGetPositionTypeDelegate(IntPtr node);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate void YGNodeStyleSetFlexWrapDelegate(IntPtr node, YogaWrap flexWrap);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate YogaWrap YGNodeStyleGetFlexWrapDelegate(IntPtr node);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate void YGNodeStyleSetOverflowDelegate(IntPtr node, YogaOverflow flexWrap);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate YogaOverflow YGNodeStyleGetOverflowDelegate(IntPtr node);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate void YGNodeStyleSetDisplayDelegate(IntPtr node, YogaDisplay display);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate YogaDisplay YGNodeStyleGetDisplayDelegate(IntPtr node);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate void YGNodeStyleSetFlexDelegate(IntPtr node, float flex);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate void YGNodeStyleSetFlexGrowDelegate(IntPtr node, float flexGrow);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate float YGNodeStyleGetFlexGrowDelegate(IntPtr node);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate void YGNodeStyleSetFlexShrinkDelegate(IntPtr node, float flexShrink);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate float YGNodeStyleGetFlexShrinkDelegate(IntPtr node);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate void YGNodeStyleSetFlexBasisDelegate(IntPtr node, float flexBasis);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate void YGNodeStyleSetFlexBasisPercentDelegate(IntPtr node, float flexBasis);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate void YGNodeStyleSetFlexBasisAutoDelegate(IntPtr node);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate float YGNodeGetComputedFlexBasisDelegate(IntPtr node);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate void YGNodeStyleSetWidthDelegate(IntPtr node, float width);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate void YGNodeStyleSetWidthPercentDelegate(IntPtr node, float width);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate void YGNodeStyleSetWidthAutoDelegate(IntPtr node);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate void YGNodeStyleSetHeightDelegate(IntPtr node, float height);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate void YGNodeStyleSetHeightPercentDelegate(IntPtr node, float height);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate void YGNodeStyleSetHeightAutoDelegate(IntPtr node);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate void YGNodeStyleSetMinWidthDelegate(IntPtr node, float minWidth);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate void YGNodeStyleSetMinWidthPercentDelegate(IntPtr node, float minWidth);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate void YGNodeStyleSetMinHeightDelegate(IntPtr node, float minHeight);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate void YGNodeStyleSetMinHeightPercentDelegate(IntPtr node, float minHeight);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate void YGNodeStyleSetMaxWidthDelegate(IntPtr node, float maxWidth);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate void YGNodeStyleSetMaxWidthPercentDelegate(IntPtr node, float maxWidth);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate void YGNodeStyleSetMaxHeightDelegate(IntPtr node, float maxHeight);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate void YGNodeStyleSetMaxHeightPercentDelegate(IntPtr node, float maxHeight);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate void YGNodeStyleSetAspectRatioDelegate(IntPtr node, float aspectRatio);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate float YGNodeStyleGetAspectRatioDelegate(IntPtr node);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate void YGNodeStyleSetPositionDelegate(IntPtr node, YogaEdge edge, float position);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate void YGNodeStyleSetPositionPercentDelegate(IntPtr node, YogaEdge edge, float position);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate void YGNodeStyleSetMarginDelegate(IntPtr node, YogaEdge edge, float margin);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate void YGNodeStyleSetMarginPercentDelegate(IntPtr node, YogaEdge edge, float margin);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate void YGNodeStyleSetMarginAutoDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate void YGNodeStyleSetPaddingDelegate(IntPtr node, YogaEdge edge, float padding);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate void YGNodeStyleSetPaddingPercentDelegate(IntPtr node, YogaEdge edge, float padding);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate void YGNodeStyleSetBorderDelegate(IntPtr node, YogaEdge edge, float border);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060001F4 RID: 500
		private delegate float YGNodeStyleGetBorderDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060001F6 RID: 502
		private delegate float YGNodeLayoutGetRightDelegate(IntPtr node);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060001F8 RID: 504
		private delegate float YGNodeLayoutGetBottomDelegate(IntPtr node);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060001FA RID: 506
		private delegate float YGNodeLayoutGetMarginDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060001FC RID: 508
		private delegate float YGNodeLayoutGetPaddingDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060001FE RID: 510
		private delegate YogaDirection YGNodeLayoutGetDirectionDelegate(IntPtr node);
	}
}
