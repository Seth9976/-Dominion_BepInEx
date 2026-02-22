using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000026 RID: 38
	public static class TMP_Compatibility : Object
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00003D5D File Offset: 0x00001F5D
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Compatibility()
		{
			Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Compatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr);
			TMP_Compatibility.NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr, 100663609);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00014FE0 File Offset: 0x000131E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137672, RefRangeEnd = 137673, XrefRangeStart = 137672, XrefRangeEnd = 137672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Compatibility.NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00003D96 File Offset: 0x00001F96
		public TMP_Compatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0;

		// Token: 0x02000079 RID: 121
		public enum AnchorPositions
		{
			// Token: 0x04000B90 RID: 2960
			TopLeft,
			// Token: 0x04000B91 RID: 2961
			Top,
			// Token: 0x04000B92 RID: 2962
			TopRight,
			// Token: 0x04000B93 RID: 2963
			Left,
			// Token: 0x04000B94 RID: 2964
			Center,
			// Token: 0x04000B95 RID: 2965
			Right,
			// Token: 0x04000B96 RID: 2966
			BottomLeft,
			// Token: 0x04000B97 RID: 2967
			Bottom,
			// Token: 0x04000B98 RID: 2968
			BottomRight,
			// Token: 0x04000B99 RID: 2969
			BaseLine,
			// Token: 0x04000B9A RID: 2970
			None
		}
	}
}
