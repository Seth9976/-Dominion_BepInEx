using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	[StructLayout(2)]
	public struct GlyphPairAdjustmentRecord
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000058F0 File Offset: 0x00003AF0
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphPairAdjustmentRecord()
		{
			Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphPairAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr);
			GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FirstAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FirstAdjustmentRecord");
			GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_SecondAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_SecondAdjustmentRecord");
			GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FeatureLookupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FeatureLookupFlags");
			GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663373);
			GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663374);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00005984 File Offset: 0x00003B84
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002427 File Offset: 0x00000627
		public unsafe GlyphAdjustmentRecord firstAdjustmentRecord
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 89071, RefRangeEnd = 89076, XrefRangeStart = 89071, XrefRangeEnd = 89071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FirstAdjustmentRecord = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000059B4 File Offset: 0x00003BB4
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002431 File Offset: 0x00000631
		public unsafe GlyphAdjustmentRecord secondAdjustmentRecord
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 89000, RefRangeEnd = 89022, XrefRangeStart = 89000, XrefRangeEnd = 89022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_SecondAdjustmentRecord = value;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002415 File Offset: 0x00000615
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000059E4 File Offset: 0x00003BE4
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000243B File Offset: 0x0000063B
		public FontFeatureLookupFlags featureLookupFlags
		{
			get
			{
				return this.m_FeatureLookupFlags;
			}
			set
			{
				this.m_FeatureLookupFlags = value;
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAdjustmentRecord;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondAdjustmentRecord;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureLookupFlags;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0;

		// Token: 0x0400008D RID: 141
		[FieldOffset(0)]
		public GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		// Token: 0x0400008E RID: 142
		[FieldOffset(20)]
		public GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		// Token: 0x0400008F RID: 143
		[FieldOffset(40)]
		public FontFeatureLookupFlags m_FeatureLookupFlags;
	}
}
