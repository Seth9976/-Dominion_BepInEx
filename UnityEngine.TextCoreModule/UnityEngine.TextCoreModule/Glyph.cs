using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class Glyph : Object
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00004E80 File Offset: 0x00003080
		// Note: this type is marked as 'beforefieldinit'.
		static Glyph()
		{
			Il2CppClassPointerStore<Glyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore", "Glyph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Glyph>.NativeClassPtr);
			Glyph.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Index");
			Glyph.NativeFieldInfoPtr_m_Metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Metrics");
			Glyph.NativeFieldInfoPtr_m_GlyphRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_GlyphRect");
			Glyph.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Scale");
			Glyph.NativeFieldInfoPtr_m_AtlasIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_AtlasIndex");
			Glyph.NativeMethodInfoPtr_get_index_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663351);
			Glyph.NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663352);
			Glyph.NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663353);
			Glyph.NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663354);
			Glyph.NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663355);
			Glyph.NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663356);
			Glyph.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663357);
			Glyph.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663358);
			Glyph.NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663359);
			Glyph.NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663360);
			Glyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663361);
			Glyph.NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663362);
			Glyph.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663363);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00005018 File Offset: 0x00003218
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00005054 File Offset: 0x00003254
		public unsafe uint index
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 68302, RefRangeEnd = 68317, XrefRangeStart = 68302, XrefRangeEnd = 68317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_index_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005094 File Offset: 0x00003294
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000050D0 File Offset: 0x000032D0
		public unsafe GlyphMetrics metrics
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 89000, RefRangeEnd = 89022, XrefRangeStart = 89000, XrefRangeEnd = 89000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 89022, RefRangeEnd = 89026, XrefRangeStart = 89022, XrefRangeEnd = 89022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00005110 File Offset: 0x00003310
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000514C File Offset: 0x0000334C
		public unsafe GlyphRect glyphRect
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 89026, RefRangeEnd = 89036, XrefRangeStart = 89026, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 89036, RefRangeEnd = 89040, XrefRangeStart = 89036, XrefRangeEnd = 89036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000518C File Offset: 0x0000338C
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000051C8 File Offset: 0x000033C8
		public unsafe float scale
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 83397, RefRangeEnd = 83412, XrefRangeStart = 83397, XrefRangeEnd = 83412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 88926, RefRangeEnd = 88931, XrefRangeStart = 88926, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00005208 File Offset: 0x00003408
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00005244 File Offset: 0x00003444
		public unsafe int atlasIndex
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 89040, RefRangeEnd = 89044, XrefRangeStart = 89040, XrefRangeEnd = 89040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 24219, RefRangeEnd = 24226, XrefRangeStart = 24219, XrefRangeEnd = 24226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005284 File Offset: 0x00003484
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 89045, RefRangeEnd = 89050, XrefRangeStart = 89044, XrefRangeEnd = 89045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Glyph()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000052C0 File Offset: 0x000034C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89051, RefRangeEnd = 89052, XrefRangeStart = 89050, XrefRangeEnd = 89051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Glyph(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphStruct;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005308 File Offset: 0x00003508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89053, RefRangeEnd = 89054, XrefRangeStart = 89052, XrefRangeEnd = 89053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metrics;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002325 File Offset: 0x00000525
		public Glyph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00005388 File Offset: 0x00003588
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000232E File Offset: 0x0000052E
		public unsafe uint m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000053B0 File Offset: 0x000035B0
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002349 File Offset: 0x00000549
		public unsafe GlyphMetrics m_Metrics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Metrics);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Metrics)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000053D8 File Offset: 0x000035D8
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002364 File Offset: 0x00000564
		public unsafe GlyphRect m_GlyphRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_GlyphRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_GlyphRect)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00005400 File Offset: 0x00003600
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000237F File Offset: 0x0000057F
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00005428 File Offset: 0x00003628
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000239A File Offset: 0x0000059A
		public unsafe int m_AtlasIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_AtlasIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_AtlasIndex)) = value;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005450 File Offset: 0x00003650
		public bool Compare(Glyph other)
		{
			return this.index == other.index && this.metrics == other.metrics && this.glyphRect == other.glyphRect && this.scale == other.scale && this.atlasIndex == other.atlasIndex;
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_m_Metrics;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphRect;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasIndex;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_UInt32_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0;
	}
}
