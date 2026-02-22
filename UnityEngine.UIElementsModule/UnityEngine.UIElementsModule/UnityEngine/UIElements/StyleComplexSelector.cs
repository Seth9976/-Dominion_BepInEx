using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B9 RID: 185
	[Serializable]
	public class StyleComplexSelector : Object
	{
		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002D404 File Offset: 0x0002B604
		// Note: this type is marked as 'beforefieldinit'.
		static StyleComplexSelector()
		{
			Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleComplexSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr);
			StyleComplexSelector.NativeFieldInfoPtr_m_Specificity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "m_Specificity");
			StyleComplexSelector.NativeFieldInfoPtr__rule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "<rule>k__BackingField");
			StyleComplexSelector.NativeFieldInfoPtr_m_Selectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "m_Selectors");
			StyleComplexSelector.NativeFieldInfoPtr_ruleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "ruleIndex");
			StyleComplexSelector.NativeFieldInfoPtr_nextInTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "nextInTable");
			StyleComplexSelector.NativeFieldInfoPtr_orderInStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "orderInStyleSheet");
			StyleComplexSelector.NativeFieldInfoPtr_s_PseudoStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "s_PseudoStates");
			StyleComplexSelector.NativeMethodInfoPtr_set_rule_Internal_set_Void_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100664200);
			StyleComplexSelector.NativeMethodInfoPtr_get_selectors_Public_get_Il2CppReferenceArray_1_StyleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100664201);
			StyleComplexSelector.NativeMethodInfoPtr_CachePseudoStateMasks_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100664202);
			StyleComplexSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100664203);
			StyleComplexSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100664204);
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00006CC2 File Offset: 0x00004EC2
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0002D524 File Offset: 0x0002B724
		public unsafe StyleRule rule
		{
			get
			{
				return this._rule_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_set_rule_Internal_set_Void_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0002D568 File Offset: 0x0002B768
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00006CCA File Offset: 0x00004ECA
		public unsafe Il2CppReferenceArray<StyleSelector> selectors
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80223, RefRangeEnd = 80226, XrefRangeStart = 80223, XrefRangeEnd = 80226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_get_selectors_Public_get_Il2CppReferenceArray_1_StyleSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSelector>>(intPtr3) : null;
			}
			set
			{
				this.m_Selectors = value;
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96890, RefRangeEnd = 96891, XrefRangeStart = 96817, XrefRangeEnd = 96890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CachePseudoStateMasks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_CachePseudoStateMasks_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0002D5DC File Offset: 0x0002B7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96891, XrefRangeEnd = 96918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StyleComplexSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0002D620 File Offset: 0x0002B820
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleComplexSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00006BEF File Offset: 0x00004DEF
		public StyleComplexSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002D65C File Offset: 0x0002B85C
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00006BF8 File Offset: 0x00004DF8
		public unsafe int m_Specificity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_Specificity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_Specificity)) = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0002D684 File Offset: 0x0002B884
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00006C13 File Offset: 0x00004E13
		public unsafe StyleRule _rule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr__rule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr__rule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0002D6B4 File Offset: 0x0002B8B4
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00006C32 File Offset: 0x00004E32
		public unsafe Il2CppReferenceArray<StyleSelector> m_Selectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_Selectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_Selectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002D6E4 File Offset: 0x0002B8E4
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00006C51 File Offset: 0x00004E51
		public unsafe int ruleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_ruleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_ruleIndex)) = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002D70C File Offset: 0x0002B90C
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00006C6C File Offset: 0x00004E6C
		public unsafe StyleComplexSelector nextInTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_nextInTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleComplexSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_nextInTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0002D73C File Offset: 0x0002B93C
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00006C8B File Offset: 0x00004E8B
		public unsafe int orderInStyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_orderInStyleSheet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_orderInStyleSheet)) = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002D764 File Offset: 0x0002B964
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00006CA6 File Offset: 0x00004EA6
		public unsafe static Dictionary<string, StyleComplexSelector.PseudoStateData> s_PseudoStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleComplexSelector.NativeFieldInfoPtr_s_PseudoStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StyleComplexSelector.PseudoStateData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleComplexSelector.NativeFieldInfoPtr_s_PseudoStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0002D78C File Offset: 0x0002B98C
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public int specificity
		{
			get
			{
				return this.m_Specificity;
			}
			set
			{
				this.m_Specificity = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002D7A4 File Offset: 0x0002B9A4
		public bool isSimple
		{
			get
			{
				return this.selectors.Length == 1;
			}
		}

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_m_Specificity;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr__rule_k__BackingField;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_m_Selectors;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_ruleIndex;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeFieldInfoPtr_nextInTable;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr_orderInStyleSheet;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr_s_PseudoStates;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_set_rule_Internal_set_Void_StyleRule_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_get_selectors_Public_get_Il2CppReferenceArray_1_StyleSelector_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_CachePseudoStateMasks_Internal_Void_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000221 RID: 545
		[StructLayout(2)]
		public struct PseudoStateData
		{
			// Token: 0x060013BC RID: 5052 RVA: 0x0003C730 File Offset: 0x0003A930
			// Note: this type is marked as 'beforefieldinit'.
			static PseudoStateData()
			{
				Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "PseudoStateData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr);
				StyleComplexSelector.PseudoStateData.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr, "state");
				StyleComplexSelector.PseudoStateData.NativeFieldInfoPtr_negate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr, "negate");
				StyleComplexSelector.PseudoStateData.NativeMethodInfoPtr__ctor_Public_Void_PseudoStates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr, 100664205);
			}

			// Token: 0x060013BD RID: 5053 RVA: 0x0003C798 File Offset: 0x0003A998
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 96811, RefRangeEnd = 96816, XrefRangeStart = 96811, XrefRangeEnd = 96811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PseudoStateData(PseudoStates state, bool negate)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.PseudoStateData.NativeMethodInfoPtr__ctor_Public_Void_PseudoStates_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060013BE RID: 5054 RVA: 0x0000CA23 File Offset: 0x0000AC23
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr, ref this));
			}

			// Token: 0x040008DC RID: 2268
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x040008DD RID: 2269
			private static readonly IntPtr NativeFieldInfoPtr_negate;

			// Token: 0x040008DE RID: 2270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PseudoStates_Boolean_0;

			// Token: 0x040008DF RID: 2271
			[FieldOffset(0)]
			public readonly PseudoStates state;

			// Token: 0x040008E0 RID: 2272
			[FieldOffset(4)]
			[MarshalAs(4)]
			public readonly bool negate;
		}

		// Token: 0x02000222 RID: 546
		[ObfuscatedName("UnityEngine.UIElements.StyleComplexSelector+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060013BF RID: 5055 RVA: 0x0003C7D8 File Offset: 0x0003A9D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr);
				StyleComplexSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, "<>9");
				StyleComplexSelector.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, "<>9__20_0");
				StyleComplexSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, 100664207);
				StyleComplexSelector.__c.NativeMethodInfoPtr__ToString_b__20_0_Internal_String_StyleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, 100664208);
			}

			// Token: 0x060013C0 RID: 5056 RVA: 0x0003C854 File Offset: 0x0003AA54
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060013C1 RID: 5057 RVA: 0x0003C890 File Offset: 0x0003AA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96816, XrefRangeEnd = 96817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__20_0(StyleSelector x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.__c.NativeMethodInfoPtr__ToString_b__20_0_Internal_String_StyleSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060013C2 RID: 5058 RVA: 0x0000CA35 File Offset: 0x0000AC35
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0003C8D8 File Offset: 0x0003AAD8
			// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0000CA3E File Offset: 0x0000AC3E
			public unsafe static StyleComplexSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleComplexSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0003C900 File Offset: 0x0003AB00
			// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0000CA50 File Offset: 0x0000AC50
			public unsafe static Func<StyleSelector, string> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StyleSelector, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008E1 RID: 2273
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040008E2 RID: 2274
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x040008E3 RID: 2275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008E4 RID: 2276
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__20_0_Internal_String_StyleSelector_0;
		}

		// Token: 0x02000223 RID: 547
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
