using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000045 RID: 69
	[StructLayout(2)]
	public struct RectInt
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x00021068 File Offset: 0x0001F268
		// Note: this type is marked as 'beforefieldinit'.
		static RectInt()
		{
			Il2CppClassPointerStore<RectInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectInt>.NativeClassPtr);
			RectInt.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_XMin");
			RectInt.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_YMin");
			RectInt.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_Width");
			RectInt.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_Height");
			RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663551);
			RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663552);
			RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663553);
			RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663554);
			RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663555);
			RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663556);
			RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663557);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00021174 File Offset: 0x0001F374
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00004A28 File Offset: 0x00002C28
		public unsafe int x
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_XMin = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000211A4 File Offset: 0x0001F3A4
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00004A32 File Offset: 0x00002C32
		public unsafe int y
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62285, RefRangeEnd = 62297, XrefRangeStart = 62285, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_YMin = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x000211D4 File Offset: 0x0001F3D4
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00004A7A File Offset: 0x00002C7A
		public unsafe int width
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62297, RefRangeEnd = 62303, XrefRangeStart = 62297, XrefRangeEnd = 62297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00021204 File Offset: 0x0001F404
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00004A84 File Offset: 0x00002C84
		public unsafe int height
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62303, RefRangeEnd = 62307, XrefRangeStart = 62303, XrefRangeEnd = 62303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00021234 File Offset: 0x0001F434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62307, XrefRangeEnd = 62308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00021260 File Offset: 0x0001F460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62326, RefRangeEnd = 62327, XrefRangeStart = 62308, XrefRangeEnd = 62326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000212B0 File Offset: 0x0001F4B0
		[CallerCount(0)]
		public unsafe bool Equals(RectInt other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00004A16 File Offset: 0x00002C16
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectInt>.NativeClassPtr, ref this));
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000212F0 File Offset: 0x0001F4F0
		public Vector2 center
		{
			get
			{
				return new Vector2((float)this.x + (float)this.m_Width / 2f, (float)this.y + (float)this.m_Height / 2f);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00021334 File Offset: 0x0001F534
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00004A3C File Offset: 0x00002C3C
		public Vector2Int min
		{
			get
			{
				return new Vector2Int(this.xMin, this.yMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00021358 File Offset: 0x0001F558
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00004A5B File Offset: 0x00002C5B
		public Vector2Int max
		{
			get
			{
				return new Vector2Int(this.xMax, this.yMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0002137C File Offset: 0x0001F57C
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x000213A8 File Offset: 0x0001F5A8
		public int xMin
		{
			get
			{
				return Math.Min(this.m_XMin, this.m_XMin + this.m_Width);
			}
			set
			{
				int xMax = this.xMax;
				this.m_XMin = value;
				this.m_Width = xMax - this.m_XMin;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000213D4 File Offset: 0x0001F5D4
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00021400 File Offset: 0x0001F600
		public int yMin
		{
			get
			{
				return Math.Min(this.m_YMin, this.m_YMin + this.m_Height);
			}
			set
			{
				int yMax = this.yMax;
				this.m_YMin = value;
				this.m_Height = yMax - this.m_YMin;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0002142C File Offset: 0x0001F62C
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00004A8E File Offset: 0x00002C8E
		public int xMax
		{
			get
			{
				return Math.Max(this.m_XMin, this.m_XMin + this.m_Width);
			}
			set
			{
				this.m_Width = value - this.m_XMin;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00021458 File Offset: 0x0001F658
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00004A9F File Offset: 0x00002C9F
		public int yMax
		{
			get
			{
				return Math.Max(this.m_YMin, this.m_YMin + this.m_Height);
			}
			set
			{
				this.m_Height = value - this.m_YMin;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00021484 File Offset: 0x0001F684
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public Vector2Int position
		{
			get
			{
				return new Vector2Int(this.m_XMin, this.m_YMin);
			}
			set
			{
				this.m_XMin = value.x;
				this.m_YMin = value.y;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000214A8 File Offset: 0x0001F6A8
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00004ACD File Offset: 0x00002CCD
		public Vector2Int size
		{
			get
			{
				return new Vector2Int(this.m_Width, this.m_Height);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00004AEA File Offset: 0x00002CEA
		public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000214CC File Offset: 0x0001F6CC
		public void ClampToBounds(RectInt bounds)
		{
			this.position = new Vector2Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin));
			this.size = new Vector2Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y));
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00021590 File Offset: 0x0001F790
		public bool Contains(Vector2Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.x < this.xMax && position.y < this.yMax;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000215E4 File Offset: 0x0001F7E4
		public bool Overlaps(RectInt other)
		{
			return other.xMin < this.xMax && other.xMax > this.xMin && other.yMin < this.yMax && other.yMax > this.yMin;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00021638 File Offset: 0x0001F838
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00021654 File Offset: 0x0001F854
		public RectInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new RectInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_m_XMin;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_m_YMin;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0;

		// Token: 0x0400031E RID: 798
		[FieldOffset(0)]
		public int m_XMin;

		// Token: 0x0400031F RID: 799
		[FieldOffset(4)]
		public int m_YMin;

		// Token: 0x04000320 RID: 800
		[FieldOffset(8)]
		public int m_Width;

		// Token: 0x04000321 RID: 801
		[FieldOffset(12)]
		public int m_Height;

		// Token: 0x02000438 RID: 1080
		public struct PositionEnumerator
		{
		}
	}
}
