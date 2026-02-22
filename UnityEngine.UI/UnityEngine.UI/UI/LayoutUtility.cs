using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000027 RID: 39
	public static class LayoutUtility : Object
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x00019558 File Offset: 0x00017758
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutUtility()
		{
			Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr);
			LayoutUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100663997);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100663998);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100663999);
			LayoutUtility.NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664000);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664001);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664002);
			LayoutUtility.NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664003);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664004);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664005);
			LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664006);
			LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664007);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00019664 File Offset: 0x00017864
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 115605, RefRangeEnd = 115612, XrefRangeStart = 115573, XrefRangeEnd = 115605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000196B4 File Offset: 0x000178B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 115614, RefRangeEnd = 115621, XrefRangeStart = 115612, XrefRangeEnd = 115614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00019704 File Offset: 0x00017904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 115653, RefRangeEnd = 115657, XrefRangeStart = 115621, XrefRangeEnd = 115653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00019754 File Offset: 0x00017954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115657, XrefRangeEnd = 115673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00019798 File Offset: 0x00017998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115703, RefRangeEnd = 115704, XrefRangeStart = 115673, XrefRangeEnd = 115703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000197DC File Offset: 0x000179DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115704, XrefRangeEnd = 115720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00019820 File Offset: 0x00017A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115720, XrefRangeEnd = 115736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00019864 File Offset: 0x00017A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115766, RefRangeEnd = 115767, XrefRangeStart = 115736, XrefRangeEnd = 115766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000198A8 File Offset: 0x00017AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115767, XrefRangeEnd = 115783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000198EC File Offset: 0x00017AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115783, XrefRangeEnd = 115784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00019950 File Offset: 0x00017B50
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115821, RefRangeEnd = 115832, XrefRangeStart = 115784, XrefRangeEnd = 115821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : new ILayoutElement(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00003A02 File Offset: 0x00001C02
		public LayoutUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0;

		// Token: 0x020000A0 RID: 160
		[ObfuscatedName("UnityEngine.UI.LayoutUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000C2C RID: 3116 RVA: 0x000353C4 File Offset: 0x000335C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr);
				LayoutUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9");
				LayoutUtility.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__3_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__4_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__4_1");
				LayoutUtility.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__5_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__6_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__7_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__7_1");
				LayoutUtility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__8_0");
				LayoutUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665026);
				LayoutUtility.__c.NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665027);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665028);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665029);
				LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665030);
				LayoutUtility.__c.NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665031);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665032);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665033);
				LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100665034);
			}

			// Token: 0x06000C2D RID: 3117 RVA: 0x00035558 File Offset: 0x00033758
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C2E RID: 3118 RVA: 0x00035594 File Offset: 0x00033794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115541, XrefRangeEnd = 115545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetMinWidth_b__3_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C2F RID: 3119 RVA: 0x000355E4 File Offset: 0x000337E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115545, XrefRangeEnd = 115549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredWidth_b__4_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C30 RID: 3120 RVA: 0x00035634 File Offset: 0x00033834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115549, XrefRangeEnd = 115553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredWidth_b__4_1(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C31 RID: 3121 RVA: 0x00035684 File Offset: 0x00033884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115553, XrefRangeEnd = 115557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetFlexibleWidth_b__5_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C32 RID: 3122 RVA: 0x000356D4 File Offset: 0x000338D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115557, XrefRangeEnd = 115561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetMinHeight_b__6_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C33 RID: 3123 RVA: 0x00035724 File Offset: 0x00033924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115561, XrefRangeEnd = 115565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredHeight_b__7_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C34 RID: 3124 RVA: 0x00035774 File Offset: 0x00033974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115565, XrefRangeEnd = 115569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredHeight_b__7_1(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C35 RID: 3125 RVA: 0x000357C4 File Offset: 0x000339C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115569, XrefRangeEnd = 115573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetFlexibleHeight_b__8_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C36 RID: 3126 RVA: 0x000067D0 File Offset: 0x000049D0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00035814 File Offset: 0x00033A14
			// (set) Token: 0x06000C38 RID: 3128 RVA: 0x000067D9 File Offset: 0x000049D9
			public unsafe static LayoutUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0003583C File Offset: 0x00033A3C
			// (set) Token: 0x06000C3A RID: 3130 RVA: 0x000067EB File Offset: 0x000049EB
			public unsafe static Func<ILayoutElement, float> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00035864 File Offset: 0x00033A64
			// (set) Token: 0x06000C3C RID: 3132 RVA: 0x000067FD File Offset: 0x000049FD
			public unsafe static Func<ILayoutElement, float> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0003588C File Offset: 0x00033A8C
			// (set) Token: 0x06000C3E RID: 3134 RVA: 0x0000680F File Offset: 0x00004A0F
			public unsafe static Func<ILayoutElement, float> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06000C3F RID: 3135 RVA: 0x000358B4 File Offset: 0x00033AB4
			// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00006821 File Offset: 0x00004A21
			public unsafe static Func<ILayoutElement, float> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06000C41 RID: 3137 RVA: 0x000358DC File Offset: 0x00033ADC
			// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00006833 File Offset: 0x00004A33
			public unsafe static Func<ILayoutElement, float> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00035904 File Offset: 0x00033B04
			// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00006845 File Offset: 0x00004A45
			public unsafe static Func<ILayoutElement, float> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0003592C File Offset: 0x00033B2C
			// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00006857 File Offset: 0x00004A57
			public unsafe static Func<ILayoutElement, float> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00035954 File Offset: 0x00033B54
			// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00006869 File Offset: 0x00004A69
			public unsafe static Func<ILayoutElement, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000978 RID: 2424
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000979 RID: 2425
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400097A RID: 2426
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400097B RID: 2427
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400097C RID: 2428
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400097D RID: 2429
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400097E RID: 2430
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400097F RID: 2431
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04000980 RID: 2432
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04000981 RID: 2433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000982 RID: 2434
			private static readonly IntPtr NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000983 RID: 2435
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000984 RID: 2436
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0;

			// Token: 0x04000985 RID: 2437
			private static readonly IntPtr NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000986 RID: 2438
			private static readonly IntPtr NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000987 RID: 2439
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000988 RID: 2440
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0;

			// Token: 0x04000989 RID: 2441
			private static readonly IntPtr NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0;
		}
	}
}
