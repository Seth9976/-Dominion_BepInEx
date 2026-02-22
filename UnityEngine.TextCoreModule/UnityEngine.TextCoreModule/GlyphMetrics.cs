using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	[StructLayout(2)]
	public struct GlyphMetrics
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00004AA4 File Offset: 0x00002CA4
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphMetrics()
		{
			Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore", "GlyphMetrics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr);
			GlyphMetrics.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_Width");
			GlyphMetrics.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_Height");
			GlyphMetrics.NativeFieldInfoPtr_m_HorizontalBearingX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_HorizontalBearingX");
			GlyphMetrics.NativeFieldInfoPtr_m_HorizontalBearingY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_HorizontalBearingY");
			GlyphMetrics.NativeFieldInfoPtr_m_HorizontalAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_HorizontalAdvance");
			GlyphMetrics.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663342);
			GlyphMetrics.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663343);
			GlyphMetrics.NativeMethodInfoPtr_get_horizontalBearingX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663344);
			GlyphMetrics.NativeMethodInfoPtr_get_horizontalBearingY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663345);
			GlyphMetrics.NativeMethodInfoPtr_get_horizontalAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663346);
			GlyphMetrics.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663347);
			GlyphMetrics.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663348);
			GlyphMetrics.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663349);
			GlyphMetrics.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663350);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004BEC File Offset: 0x00002DEC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022F3 File Offset: 0x000004F3
		public unsafe float width
		{
			[CallerCount(78)]
			[CachedScanResults(RefRangeStart = 61619, RefRangeEnd = 61697, XrefRangeStart = 61619, XrefRangeEnd = 61697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_width_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004C1C File Offset: 0x00002E1C
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000022FD File Offset: 0x000004FD
		public unsafe float height
		{
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 59142, RefRangeEnd = 59224, XrefRangeStart = 59142, XrefRangeEnd = 59224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_height_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004C4C File Offset: 0x00002E4C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002307 File Offset: 0x00000507
		public unsafe float horizontalBearingX
		{
			[CallerCount(139)]
			[CachedScanResults(RefRangeStart = 61772, RefRangeEnd = 61911, XrefRangeStart = 61772, XrefRangeEnd = 61911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_horizontalBearingX_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_HorizontalBearingX = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004C7C File Offset: 0x00002E7C
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002311 File Offset: 0x00000511
		public unsafe float horizontalBearingY
		{
			[CallerCount(153)]
			[CachedScanResults(RefRangeStart = 61923, RefRangeEnd = 62076, XrefRangeStart = 61923, XrefRangeEnd = 62076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_horizontalBearingY_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_HorizontalBearingY = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004CAC File Offset: 0x00002EAC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000231B File Offset: 0x0000051B
		public unsafe float horizontalAdvance
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 88973, RefRangeEnd = 88983, XrefRangeStart = 88973, XrefRangeEnd = 88973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_horizontalAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_HorizontalAdvance = value;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004CDC File Offset: 0x00002EDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88983, RefRangeEnd = 88986, XrefRangeStart = 88983, XrefRangeEnd = 88983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bearingX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bearingY;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref advance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004D48 File Offset: 0x00002F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88986, XrefRangeEnd = 88990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004D78 File Offset: 0x00002F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88990, XrefRangeEnd = 88994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004DBC File Offset: 0x00002FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88994, XrefRangeEnd = 89000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GlyphMetrics other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphMetrics_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000022E1 File Offset: 0x000004E1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, ref this));
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004DFC File Offset: 0x00002FFC
		public static bool operator ==(GlyphMetrics lhs, GlyphMetrics rhs)
		{
			return lhs.width == rhs.width && lhs.height == rhs.height && lhs.horizontalBearingX == rhs.horizontalBearingX && lhs.horizontalBearingY == rhs.horizontalBearingY && lhs.horizontalAdvance == rhs.horizontalAdvance;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004E64 File Offset: 0x00003064
		public static bool operator !=(GlyphMetrics lhs, GlyphMetrics rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalBearingX;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalBearingY;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAdvance;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalBearingX_Public_get_Single_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalBearingY_Public_get_Single_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAdvance_Public_get_Single_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphMetrics_0;

		// Token: 0x04000058 RID: 88
		[FieldOffset(0)]
		public float m_Width;

		// Token: 0x04000059 RID: 89
		[FieldOffset(4)]
		public float m_Height;

		// Token: 0x0400005A RID: 90
		[FieldOffset(8)]
		public float m_HorizontalBearingX;

		// Token: 0x0400005B RID: 91
		[FieldOffset(12)]
		public float m_HorizontalBearingY;

		// Token: 0x0400005C RID: 92
		[FieldOffset(16)]
		public float m_HorizontalAdvance;
	}
}
