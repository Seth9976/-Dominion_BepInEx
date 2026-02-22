using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BC RID: 188
	[Serializable]
	public class StyleSelector : Object
	{
		// Token: 0x06000AD9 RID: 2777 RVA: 0x0002DBC4 File Offset: 0x0002BDC4
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSelector()
		{
			Il2CppClassPointerStore<StyleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr);
			StyleSelector.NativeFieldInfoPtr_m_Parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "m_Parts");
			StyleSelector.NativeFieldInfoPtr_m_PreviousRelationship = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "m_PreviousRelationship");
			StyleSelector.NativeFieldInfoPtr_pseudoStateMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "pseudoStateMask");
			StyleSelector.NativeFieldInfoPtr_negatedPseudoStateMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "negatedPseudoStateMask");
			StyleSelector.NativeMethodInfoPtr_get_parts_Public_get_Il2CppReferenceArray_1_StyleSelectorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100664214);
			StyleSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100664215);
			StyleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100664216);
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002DC80 File Offset: 0x0002BE80
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00006E6B File Offset: 0x0000506B
		public unsafe Il2CppReferenceArray<StyleSelectorPart> parts
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.NativeMethodInfoPtr_get_parts_Public_get_Il2CppReferenceArray_1_StyleSelectorPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSelectorPart>>(intPtr3) : null;
			}
			set
			{
				this.m_Parts = value;
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96919, XrefRangeEnd = 96943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StyleSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0002DD04 File Offset: 0x0002BF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96943, XrefRangeEnd = 96944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00006DF2 File Offset: 0x00004FF2
		public StyleSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0002DD40 File Offset: 0x0002BF40
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00006DFB File Offset: 0x00004FFB
		public unsafe Il2CppReferenceArray<StyleSelectorPart> m_Parts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_m_Parts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSelectorPart>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_m_Parts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0002DD70 File Offset: 0x0002BF70
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00006E1A File Offset: 0x0000501A
		public unsafe StyleSelectorRelationship m_PreviousRelationship
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_m_PreviousRelationship);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_m_PreviousRelationship)) = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0002DD98 File Offset: 0x0002BF98
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00006E35 File Offset: 0x00005035
		public unsafe int pseudoStateMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_pseudoStateMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_pseudoStateMask)) = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x0002DDC0 File Offset: 0x0002BFC0
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00006E50 File Offset: 0x00005050
		public unsafe int negatedPseudoStateMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_negatedPseudoStateMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_negatedPseudoStateMask)) = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0002DDE8 File Offset: 0x0002BFE8
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00006E75 File Offset: 0x00005075
		public StyleSelectorRelationship previousRelationship
		{
			get
			{
				return this.m_PreviousRelationship;
			}
			set
			{
				this.m_PreviousRelationship = value;
			}
		}

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_m_Parts;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousRelationship;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_pseudoStateMask;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_negatedPseudoStateMask;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_get_parts_Public_get_Il2CppReferenceArray_1_StyleSelectorPart_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000224 RID: 548
		[ObfuscatedName("UnityEngine.UIElements.StyleSelector+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060013C7 RID: 5063 RVA: 0x0003C928 File Offset: 0x0003AB28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr);
				StyleSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr, "<>9");
				StyleSelector.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr, "<>9__10_0");
				StyleSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr, 100664218);
				StyleSelector.__c.NativeMethodInfoPtr__ToString_b__10_0_Internal_String_StyleSelectorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr, 100664219);
			}

			// Token: 0x060013C8 RID: 5064 RVA: 0x0003C9A4 File Offset: 0x0003ABA4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060013C9 RID: 5065 RVA: 0x0003C9E0 File Offset: 0x0003ABE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96918, XrefRangeEnd = 96919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__10_0(StyleSelectorPart p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.__c.NativeMethodInfoPtr__ToString_b__10_0_Internal_String_StyleSelectorPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060013CA RID: 5066 RVA: 0x0000CA62 File Offset: 0x0000AC62
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x060013CB RID: 5067 RVA: 0x0003CA30 File Offset: 0x0003AC30
			// (set) Token: 0x060013CC RID: 5068 RVA: 0x0000CA6B File Offset: 0x0000AC6B
			public unsafe static StyleSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x060013CD RID: 5069 RVA: 0x0003CA58 File Offset: 0x0003AC58
			// (set) Token: 0x060013CE RID: 5070 RVA: 0x0000CA7D File Offset: 0x0000AC7D
			public unsafe static Func<StyleSelectorPart, string> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleSelector.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StyleSelectorPart, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleSelector.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008E5 RID: 2277
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040008E6 RID: 2278
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040008E7 RID: 2279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008E8 RID: 2280
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__10_0_Internal_String_StyleSelectorPart_0;
		}

		// Token: 0x02000225 RID: 549
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
