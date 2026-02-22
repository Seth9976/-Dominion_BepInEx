using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	[StructLayout(2)]
	public struct GlyphRect
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000046CC File Offset: 0x000028CC
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphRect()
		{
			Il2CppClassPointerStore<GlyphRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore", "GlyphRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr);
			GlyphRect.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "m_X");
			GlyphRect.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "m_Y");
			GlyphRect.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "m_Width");
			GlyphRect.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "m_Height");
			GlyphRect.NativeFieldInfoPtr_s_ZeroGlyphRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "s_ZeroGlyphRect");
			GlyphRect.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663332);
			GlyphRect.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663333);
			GlyphRect.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663334);
			GlyphRect.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663335);
			GlyphRect.NativeMethodInfoPtr_get_zero_Public_Static_get_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663336);
			GlyphRect.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663337);
			GlyphRect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663338);
			GlyphRect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663339);
			GlyphRect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663340);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00004814 File Offset: 0x00002A14
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000022B9 File Offset: 0x000004B9
		public unsafe int x
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_X = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00004844 File Offset: 0x00002A44
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000022C3 File Offset: 0x000004C3
		public unsafe int y
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62285, RefRangeEnd = 62297, XrefRangeStart = 62285, XrefRangeEnd = 62297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Y = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00004874 File Offset: 0x00002A74
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000022CD File Offset: 0x000004CD
		public unsafe int width
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62297, RefRangeEnd = 62303, XrefRangeStart = 62297, XrefRangeEnd = 62303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000048A4 File Offset: 0x00002AA4
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000022D7 File Offset: 0x000004D7
		public unsafe int height
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62303, RefRangeEnd = 62307, XrefRangeStart = 62303, XrefRangeEnd = 62307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000048D4 File Offset: 0x00002AD4
		public unsafe static GlyphRect zero
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88953, RefRangeEnd = 88954, XrefRangeStart = 88949, XrefRangeEnd = 88953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_zero_Public_Static_get_GlyphRect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004904 File Offset: 0x00002B04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 88954, RefRangeEnd = 88959, XrefRangeStart = 88954, XrefRangeEnd = 88954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlyphRect(int x, int y, int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004960 File Offset: 0x00002B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88959, XrefRangeEnd = 88963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004990 File Offset: 0x00002B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88963, XrefRangeEnd = 88967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000049D4 File Offset: 0x00002BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88967, XrefRangeEnd = 88973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GlyphRect other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphRect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002299 File Offset: 0x00000499
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, ref this));
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004A14 File Offset: 0x00002C14
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000022AB File Offset: 0x000004AB
		public unsafe static GlyphRect s_ZeroGlyphRect
		{
			get
			{
				GlyphRect glyphRect;
				IL2CPP.il2cpp_field_static_get_value(GlyphRect.NativeFieldInfoPtr_s_ZeroGlyphRect, (void*)(&glyphRect));
				return glyphRect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlyphRect.NativeFieldInfoPtr_s_ZeroGlyphRect, (void*)(&value));
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004A30 File Offset: 0x00002C30
		public static bool operator ==(GlyphRect lhs, GlyphRect rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y && lhs.width == rhs.width && lhs.height == rhs.height;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004A88 File Offset: 0x00002C88
		public static bool operator !=(GlyphRect lhs, GlyphRect rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_s_ZeroGlyphRect;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_GlyphRect_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphRect_0;

		// Token: 0x04000046 RID: 70
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x04000047 RID: 71
		[FieldOffset(4)]
		public int m_Y;

		// Token: 0x04000048 RID: 72
		[FieldOffset(8)]
		public int m_Width;

		// Token: 0x04000049 RID: 73
		[FieldOffset(12)]
		public int m_Height;
	}
}
