using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	[StructLayout(2)]
	public struct GlyphValueRecord
	{
		// Token: 0x06000094 RID: 148 RVA: 0x000054B8 File Offset: 0x000036B8
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphValueRecord()
		{
			Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphValueRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr);
			GlyphValueRecord.NativeFieldInfoPtr_m_XPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, "m_XPlacement");
			GlyphValueRecord.NativeFieldInfoPtr_m_YPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, "m_YPlacement");
			GlyphValueRecord.NativeFieldInfoPtr_m_XAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, "m_XAdvance");
			GlyphValueRecord.NativeFieldInfoPtr_m_YAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, "m_YAdvance");
			GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663364);
			GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663365);
			GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663366);
			GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663367);
			GlyphValueRecord.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663368);
			GlyphValueRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663369);
			GlyphValueRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663370);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000055C4 File Offset: 0x000037C4
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000023C7 File Offset: 0x000005C7
		public unsafe float xPlacement
		{
			[CallerCount(78)]
			[CachedScanResults(RefRangeStart = 61619, RefRangeEnd = 61697, XrefRangeStart = 61619, XrefRangeEnd = 61697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_XPlacement = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000055F4 File Offset: 0x000037F4
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000023D1 File Offset: 0x000005D1
		public unsafe float yPlacement
		{
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 59142, RefRangeEnd = 59224, XrefRangeStart = 59142, XrefRangeEnd = 59224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_YPlacement = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00005624 File Offset: 0x00003824
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000023DB File Offset: 0x000005DB
		public unsafe float xAdvance
		{
			[CallerCount(139)]
			[CachedScanResults(RefRangeStart = 61772, RefRangeEnd = 61911, XrefRangeStart = 61772, XrefRangeEnd = 61911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_XAdvance = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00005654 File Offset: 0x00003854
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000023E5 File Offset: 0x000005E5
		public unsafe float yAdvance
		{
			[CallerCount(153)]
			[CachedScanResults(RefRangeStart = 61923, RefRangeEnd = 62076, XrefRangeStart = 61923, XrefRangeEnd = 62076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_YAdvance = value;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005684 File Offset: 0x00003884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89054, XrefRangeEnd = 89058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000056B4 File Offset: 0x000038B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89058, XrefRangeEnd = 89062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000056F8 File Offset: 0x000038F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89062, XrefRangeEnd = 89068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GlyphValueRecord other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000023B5 File Offset: 0x000005B5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005738 File Offset: 0x00003938
		public static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b)
		{
			GlyphValueRecord glyphValueRecord;
			glyphValueRecord.m_XPlacement = a.xPlacement + b.xPlacement;
			glyphValueRecord.m_YPlacement = a.yPlacement + b.yPlacement;
			glyphValueRecord.m_XAdvance = a.xAdvance + b.xAdvance;
			glyphValueRecord.m_YAdvance = a.yAdvance + b.yAdvance;
			return glyphValueRecord;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000057A4 File Offset: 0x000039A4
		public static bool operator ==(GlyphValueRecord lhs, GlyphValueRecord rhs)
		{
			return lhs.m_XPlacement == rhs.m_XPlacement && lhs.m_YPlacement == rhs.m_YPlacement && lhs.m_XAdvance == rhs.m_XAdvance && lhs.m_YAdvance == rhs.m_YAdvance;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000057F4 File Offset: 0x000039F4
		public static bool operator !=(GlyphValueRecord lhs, GlyphValueRecord rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_m_XPlacement;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_m_YPlacement;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_m_XAdvance;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_YAdvance;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphValueRecord_0;

		// Token: 0x0400007E RID: 126
		[FieldOffset(0)]
		public float m_XPlacement;

		// Token: 0x0400007F RID: 127
		[FieldOffset(4)]
		public float m_YPlacement;

		// Token: 0x04000080 RID: 128
		[FieldOffset(8)]
		public float m_XAdvance;

		// Token: 0x04000081 RID: 129
		[FieldOffset(12)]
		public float m_YAdvance;
	}
}
