using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class TMP_Character : TMP_TextElement
	{
		// Token: 0x060002FC RID: 764 RVA: 0x000136B4 File Offset: 0x000118B4
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Character()
		{
			Il2CppClassPointerStore<TMP_Character>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Character");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663571);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663572);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663573);
			TMP_Character.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663574);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00013734 File Offset: 0x00011934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137602, RefRangeEnd = 137604, XrefRangeStart = 137601, XrefRangeEnd = 137602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00013770 File Offset: 0x00011970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137604, XrefRangeEnd = 137606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character(uint unicode, Glyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000137CC File Offset: 0x000119CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137606, XrefRangeEnd = 137608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00013838 File Offset: 0x00011A38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137609, RefRangeEnd = 137611, XrefRangeStart = 137608, XrefRangeEnd = 137609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character(uint unicode, uint glyphIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000037D8 File Offset: 0x000019D8
		public TMP_Character(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0;
	}
}
