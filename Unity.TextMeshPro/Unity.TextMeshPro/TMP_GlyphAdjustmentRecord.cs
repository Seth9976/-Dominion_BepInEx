using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200003B RID: 59
	[Serializable]
	[StructLayout(2)]
	public struct TMP_GlyphAdjustmentRecord
	{
		// Token: 0x060005DB RID: 1499 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_GlyphAdjustmentRecord()
		{
			Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr);
			TMP_GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphIndex");
			TMP_GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphValueRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphValueRecord");
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663857);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663858);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663859);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663860);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663861);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663862);
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001CFC0 File Offset: 0x0001B1C0
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0001CFF0 File Offset: 0x0001B1F0
		public unsafe uint glyphIndex
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001D024 File Offset: 0x0001B224
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x0001D054 File Offset: 0x0001B254
		public unsafe TMP_GlyphValueRecord glyphValueRecord
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0001D088 File Offset: 0x0001B288
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 137636, RefRangeEnd = 137642, XrefRangeStart = 137636, XrefRangeEnd = 137642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphValueRecord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140868, XrefRangeEnd = 140874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref adjustmentRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00004E5F File Offset: 0x0000305F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndex;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphValueRecord;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0;

		// Token: 0x0400044F RID: 1103
		[FieldOffset(0)]
		public uint m_GlyphIndex;

		// Token: 0x04000450 RID: 1104
		[FieldOffset(4)]
		public TMP_GlyphValueRecord m_GlyphValueRecord;
	}
}
