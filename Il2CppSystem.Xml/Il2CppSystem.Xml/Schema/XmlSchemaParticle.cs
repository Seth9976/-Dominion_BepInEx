using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F6 RID: 246
	public class XmlSchemaParticle : XmlSchemaAnnotated
	{
		// Token: 0x06000EE3 RID: 3811 RVA: 0x00045E1C File Offset: 0x0004401C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaParticle()
		{
			Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaParticle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr);
			XmlSchemaParticle.NativeFieldInfoPtr_minOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "minOccurs");
			XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "maxOccurs");
			XmlSchemaParticle.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "flags");
			XmlSchemaParticle.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "Empty");
			XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100665462);
			XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100665463);
			XmlSchemaParticle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, 100665464);
		}

		// Token: 0x1700058B RID: 1419
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00045ED8 File Offset: 0x000440D8
		public unsafe Decimal MinOccurs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24798, XrefRangeEnd = 24807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058C RID: 1420
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00045F18 File Offset: 0x00044118
		public unsafe Decimal MaxOccurs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24807, XrefRangeEnd = 24820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00045F58 File Offset: 0x00044158
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24826, RefRangeEnd = 24832, XrefRangeStart = 24820, XrefRangeEnd = 24826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0000706F File Offset: 0x0000526F
		public XmlSchemaParticle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00045F94 File Offset: 0x00044194
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00007078 File Offset: 0x00005278
		public unsafe Decimal minOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_minOccurs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_minOccurs)) = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00045FBC File Offset: 0x000441BC
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00007093 File Offset: 0x00005293
		public unsafe Decimal maxOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_maxOccurs)) = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00045FE4 File Offset: 0x000441E4
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x000070AE File Offset: 0x000052AE
		public unsafe XmlSchemaParticle.Occurs flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaParticle.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0004600C File Offset: 0x0004420C
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x000070C9 File Offset: 0x000052C9
		public unsafe static XmlSchemaParticle Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaParticle.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaParticle.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr_minOccurs;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr_maxOccurs;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_set_MinOccurs_Public_set_Void_Decimal_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxOccurs_Public_set_Void_Decimal_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000136 RID: 310
		[Flags]
		public enum Occurs
		{
			// Token: 0x04000EDA RID: 3802
			None = 0,
			// Token: 0x04000EDB RID: 3803
			Min = 1,
			// Token: 0x04000EDC RID: 3804
			Max = 2
		}

		// Token: 0x02000137 RID: 311
		public class EmptyParticle : XmlSchemaParticle
		{
			// Token: 0x060012D4 RID: 4820 RVA: 0x00008721 File Offset: 0x00006921
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyParticle()
			{
				Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaParticle>.NativeClassPtr, "EmptyParticle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr);
				XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr, 100665466);
			}

			// Token: 0x060012D5 RID: 4821 RVA: 0x00055DE0 File Offset: 0x00053FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24794, XrefRangeEnd = 24798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmptyParticle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaParticle.EmptyParticle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaParticle.EmptyParticle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012D6 RID: 4822 RVA: 0x00008755 File Offset: 0x00006955
			public EmptyParticle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000EDD RID: 3805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
