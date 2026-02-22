using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200006C RID: 108
	[StructLayout(2)]
	public struct TMP_FontStyleStack
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x0003846C File Offset: 0x0003666C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontStyleStack()
		{
			Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontStyleStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr);
			TMP_FontStyleStack.NativeFieldInfoPtr_bold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "bold");
			TMP_FontStyleStack.NativeFieldInfoPtr_italic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "italic");
			TMP_FontStyleStack.NativeFieldInfoPtr_underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "underline");
			TMP_FontStyleStack.NativeFieldInfoPtr_strikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "strikethrough");
			TMP_FontStyleStack.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "highlight");
			TMP_FontStyleStack.NativeFieldInfoPtr_superscript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "superscript");
			TMP_FontStyleStack.NativeFieldInfoPtr_subscript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "subscript");
			TMP_FontStyleStack.NativeFieldInfoPtr_uppercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "uppercase");
			TMP_FontStyleStack.NativeFieldInfoPtr_lowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "lowercase");
			TMP_FontStyleStack.NativeFieldInfoPtr_smallcaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "smallcaps");
			TMP_FontStyleStack.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, 100664709);
			TMP_FontStyleStack.NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, 100664710);
			TMP_FontStyleStack.NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, 100664711);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000385A0 File Offset: 0x000367A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 148958, RefRangeEnd = 148962, XrefRangeStart = 148958, XrefRangeEnd = 148958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontStyleStack.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000385C8 File Offset: 0x000367C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148962, RefRangeEnd = 148963, XrefRangeStart = 148962, XrefRangeEnd = 148962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Add(FontStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontStyleStack.NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00038608 File Offset: 0x00036808
		[CallerCount(0)]
		public unsafe byte Remove(FontStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontStyleStack.NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000089B6 File Offset: 0x00006BB6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, ref this));
		}

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeFieldInfoPtr_bold;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeFieldInfoPtr_italic;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr_underline;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_strikethrough;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr_superscript;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeFieldInfoPtr_subscript;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeFieldInfoPtr_uppercase;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_lowercase;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeFieldInfoPtr_smallcaps;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0;

		// Token: 0x04000B02 RID: 2818
		[FieldOffset(0)]
		public byte bold;

		// Token: 0x04000B03 RID: 2819
		[FieldOffset(1)]
		public byte italic;

		// Token: 0x04000B04 RID: 2820
		[FieldOffset(2)]
		public byte underline;

		// Token: 0x04000B05 RID: 2821
		[FieldOffset(3)]
		public byte strikethrough;

		// Token: 0x04000B06 RID: 2822
		[FieldOffset(4)]
		public byte highlight;

		// Token: 0x04000B07 RID: 2823
		[FieldOffset(5)]
		public byte superscript;

		// Token: 0x04000B08 RID: 2824
		[FieldOffset(6)]
		public byte subscript;

		// Token: 0x04000B09 RID: 2825
		[FieldOffset(7)]
		public byte uppercase;

		// Token: 0x04000B0A RID: 2826
		[FieldOffset(8)]
		public byte lowercase;

		// Token: 0x04000B0B RID: 2827
		[FieldOffset(9)]
		public byte smallcaps;
	}
}
