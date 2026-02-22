using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x02000034 RID: 52
	[Serializable]
	[StructLayout(2)]
	public struct GlyphValueRecord_Legacy
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x0001BA28 File Offset: 0x00019C28
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphValueRecord_Legacy()
		{
			Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "GlyphValueRecord_Legacy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr);
			GlyphValueRecord_Legacy.NativeFieldInfoPtr_xPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "xPlacement");
			GlyphValueRecord_Legacy.NativeFieldInfoPtr_yPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "yPlacement");
			GlyphValueRecord_Legacy.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "xAdvance");
			GlyphValueRecord_Legacy.NativeFieldInfoPtr_yAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "yAdvance");
			GlyphValueRecord_Legacy.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, 100663812);
			GlyphValueRecord_Legacy.NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, 100663813);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001BAD0 File Offset: 0x00019CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140473, XrefRangeEnd = 140477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlyphValueRecord_Legacy(GlyphValueRecord valueRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord_Legacy.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001BB04 File Offset: 0x00019D04
		[CallerCount(0)]
		public unsafe static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord_Legacy.NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00004D00 File Offset: 0x00002F00
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, ref this));
		}

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_xPlacement;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_yPlacement;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_yAdvance;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0;

		// Token: 0x04000402 RID: 1026
		[FieldOffset(0)]
		public float xPlacement;

		// Token: 0x04000403 RID: 1027
		[FieldOffset(4)]
		public float yPlacement;

		// Token: 0x04000404 RID: 1028
		[FieldOffset(8)]
		public float xAdvance;

		// Token: 0x04000405 RID: 1029
		[FieldOffset(12)]
		public float yAdvance;
	}
}
