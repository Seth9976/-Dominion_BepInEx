using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000035 RID: 53
	[Serializable]
	public class KerningPair : Object
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x0001BB50 File Offset: 0x00019D50
		// Note: this type is marked as 'beforefieldinit'.
		static KerningPair()
		{
			Il2CppClassPointerStore<KerningPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningPair>.NativeClassPtr);
			KerningPair.NativeFieldInfoPtr_m_FirstGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_FirstGlyph");
			KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_FirstGlyphAdjustments");
			KerningPair.NativeFieldInfoPtr_m_SecondGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_SecondGlyph");
			KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_SecondGlyphAdjustments");
			KerningPair.NativeFieldInfoPtr_xOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "xOffset");
			KerningPair.NativeFieldInfoPtr_empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "empty");
			KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_IgnoreSpacingAdjustments");
			KerningPair.NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663814);
			KerningPair.NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663815);
			KerningPair.NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663816);
			KerningPair.NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663817);
			KerningPair.NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663818);
			KerningPair.NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663819);
			KerningPair.NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663820);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663821);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663822);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663823);
			KerningPair.NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663824);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001BCE8 File Offset: 0x00019EE8
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0001BD24 File Offset: 0x00019F24
		public unsafe uint firstGlyph
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001BD64 File Offset: 0x00019F64
		public unsafe GlyphValueRecord_Legacy firstGlyphAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001BDA0 File Offset: 0x00019FA0
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0001BDDC File Offset: 0x00019FDC
		public unsafe uint secondGlyph
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001BE1C File Offset: 0x0001A01C
		public unsafe GlyphValueRecord_Legacy secondGlyphAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001BE58 File Offset: 0x0001A058
		public unsafe bool ignoreSpacingAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001BE94 File Offset: 0x0001A094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140477, XrefRangeEnd = 140478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningPair()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140478, XrefRangeEnd = 140479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningPair(uint left, uint right, float offset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001BF34 File Offset: 0x0001A134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140479, XrefRangeEnd = 140480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstGlyph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstGlyphAdjustments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondGlyph;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondGlyphAdjustments;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		[CallerCount(0)]
		public unsafe void ConvertLegacyKerningData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00004D12 File Offset: 0x00002F12
		public KerningPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0001BFDC File Offset: 0x0001A1DC
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00004D1B File Offset: 0x00002F1B
		public unsafe uint m_FirstGlyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyph)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001C004 File Offset: 0x0001A204
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00004D36 File Offset: 0x00002F36
		public unsafe GlyphValueRecord_Legacy m_FirstGlyphAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments)) = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001C02C File Offset: 0x0001A22C
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00004D51 File Offset: 0x00002F51
		public unsafe uint m_SecondGlyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyph)) = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001C054 File Offset: 0x0001A254
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00004D6C File Offset: 0x00002F6C
		public unsafe GlyphValueRecord_Legacy m_SecondGlyphAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001C07C File Offset: 0x0001A27C
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00004D87 File Offset: 0x00002F87
		public unsafe float xOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_xOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_xOffset)) = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00004DA2 File Offset: 0x00002FA2
		public unsafe static KerningPair empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KerningPair.NativeFieldInfoPtr_empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KerningPair>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KerningPair.NativeFieldInfoPtr_empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001C0CC File Offset: 0x0001A2CC
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public unsafe bool m_IgnoreSpacingAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments)) = value;
			}
		}

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstGlyph;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstGlyphAdjustments;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondGlyph;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondGlyphAdjustments;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_xOffset;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_empty;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreSpacingAdjustments;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0;
	}
}
