using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020000E3 RID: 227
	[Serializable]
	public sealed class ScalableImage : ValueType
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x00032BB4 File Offset: 0x00030DB4
		// Note: this type is marked as 'beforefieldinit'.
		static ScalableImage()
		{
			Il2CppClassPointerStore<ScalableImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "ScalableImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr);
			ScalableImage.NativeFieldInfoPtr_normalImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr, "normalImage");
			ScalableImage.NativeFieldInfoPtr_highResolutionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr, "highResolutionImage");
			ScalableImage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr, 100664278);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00032C20 File Offset: 0x00030E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97270, XrefRangeEnd = 97303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableImage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00007FB3 File Offset: 0x000061B3
		public ScalableImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00007FBC File Offset: 0x000061BC
		public ScalableImage()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr))
		{
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00032C5C File Offset: 0x00030E5C
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00007FCE File Offset: 0x000061CE
		public unsafe Texture2D normalImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableImage.NativeFieldInfoPtr_normalImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableImage.NativeFieldInfoPtr_normalImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00032C8C File Offset: 0x00030E8C
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00007FED File Offset: 0x000061ED
		public unsafe Texture2D highResolutionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableImage.NativeFieldInfoPtr_highResolutionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableImage.NativeFieldInfoPtr_highResolutionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_normalImage;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_highResolutionImage;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
