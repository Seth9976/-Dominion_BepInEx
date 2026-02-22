using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	[StructLayout(2)]
	public struct GlyphAdjustmentRecord
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00005810 File Offset: 0x00003A10
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphAdjustmentRecord()
		{
			Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr);
			GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphIndex");
			GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphValueRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphValueRecord");
			GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663371);
			GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663372);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005890 File Offset: 0x00003A90
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002401 File Offset: 0x00000601
		public unsafe uint glyphIndex
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_GlyphIndex = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000058C0 File Offset: 0x00003AC0
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000240B File Offset: 0x0000060B
		public unsafe GlyphValueRecord glyphValueRecord
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89068, RefRangeEnd = 89071, XrefRangeStart = 89068, XrefRangeEnd = 89068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_GlyphValueRecord = value;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000023EF File Offset: 0x000005EF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndex;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphValueRecord;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0;

		// Token: 0x04000086 RID: 134
		[FieldOffset(0)]
		public uint m_GlyphIndex;

		// Token: 0x04000087 RID: 135
		[FieldOffset(4)]
		public GlyphValueRecord m_GlyphValueRecord;
	}
}
