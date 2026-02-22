using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000171 RID: 369
	public class GraphicsFormatUtility : Object
	{
		// Token: 0x06001B09 RID: 6921 RVA: 0x00060420 File Offset: 0x0005E620
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsFormatUtility()
		{
			Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "GraphicsFormatUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100665287);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100665288);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100665289);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100665290);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100665291);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100665292);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedTextureFormat_Internal_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100665293);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100665294);
			GraphicsFormatUtility.GetFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormat");
			GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetTextureFormat_Native_GraphicsFormat");
			GraphicsFormatUtility.IsSwizzleFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSwizzleFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSwizzleFormat");
			GraphicsFormatUtility.GetSRGBFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSRGBFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSRGBFormat");
			GraphicsFormatUtility.GetLinearFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetLinearFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetLinearFormat");
			GraphicsFormatUtility.GetRenderTextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetRenderTextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetRenderTextureFormat");
			GraphicsFormatUtility.GetColorComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetColorComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetColorComponentCount");
			GraphicsFormatUtility.GetAlphaComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetAlphaComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetAlphaComponentCount");
			GraphicsFormatUtility.GetComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetComponentCount");
			GraphicsFormatUtility.GetFormatStringDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetFormatStringDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormatString");
			GraphicsFormatUtility.IsCompressedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsCompressedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsCompressedFormat");
			GraphicsFormatUtility.IsPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsPackedFormat");
			GraphicsFormatUtility.Is16BitPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.Is16BitPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::Is16BitPackedFormat");
			GraphicsFormatUtility.ConvertToAlphaFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ConvertToAlphaFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat");
			GraphicsFormatUtility.IsAlphaOnlyFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaOnlyFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaOnlyFormat");
			GraphicsFormatUtility.IsAlphaTestFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaTestFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaTestFormat");
			GraphicsFormatUtility.HasAlphaChannelDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.HasAlphaChannelDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel");
			GraphicsFormatUtility.IsDepthFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDepthFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDepthFormat");
			GraphicsFormatUtility.IsStencilFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsStencilFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsStencilFormat");
			GraphicsFormatUtility.IsIEEE754FormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIEEE754FormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIEEE754Format");
			GraphicsFormatUtility.IsFloatFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsFloatFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsFloatFormat");
			GraphicsFormatUtility.IsHalfFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHalfFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHalfFormat");
			GraphicsFormatUtility.IsUnsignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUnsignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUnsignedFormat");
			GraphicsFormatUtility.IsSignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSignedFormat");
			GraphicsFormatUtility.IsNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsNormFormat");
			GraphicsFormatUtility.IsUNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUNormFormat");
			GraphicsFormatUtility.IsSNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSNormFormat");
			GraphicsFormatUtility.IsIntegerFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIntegerFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIntegerFormat");
			GraphicsFormatUtility.IsUIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUIntFormat");
			GraphicsFormatUtility.IsSIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSIntFormat");
			GraphicsFormatUtility.IsXRFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsXRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsXRFormat");
			GraphicsFormatUtility.IsDXTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDXTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDXTCFormat");
			GraphicsFormatUtility.IsRGTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsRGTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsRGTCFormat");
			GraphicsFormatUtility.IsBPTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBPTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBPTCFormat");
			GraphicsFormatUtility.IsBCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBCFormat");
			GraphicsFormatUtility.IsPVRTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsPVRTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsPVRTCFormat");
			GraphicsFormatUtility.IsETCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsETCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsETCFormat");
			GraphicsFormatUtility.IsEACFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsEACFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsEACFormat");
			GraphicsFormatUtility.IsASTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsASTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsASTCFormat");
			GraphicsFormatUtility.GetSwizzleRDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSwizzleRDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSwizzleR");
			GraphicsFormatUtility.GetSwizzleGDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSwizzleGDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSwizzleG");
			GraphicsFormatUtility.GetSwizzleBDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSwizzleBDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSwizzleB");
			GraphicsFormatUtility.GetSwizzleADelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSwizzleADelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSwizzleA");
			GraphicsFormatUtility.GetBlockSizeDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockSizeDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockSize");
			GraphicsFormatUtility.GetBlockWidthDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockWidthDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockWidth");
			GraphicsFormatUtility.GetBlockHeightDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockHeightDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockHeight");
			GraphicsFormatUtility.ComputeMipmapSize_Native_2DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipmapSize_Native_2DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipmapSize_Native_2D");
			GraphicsFormatUtility.ComputeMipmapSize_Native_3DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipmapSize_Native_3DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipmapSize_Native_3D");
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000607C0 File Offset: 0x0005E9C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 83182, RefRangeEnd = 83189, XrefRangeStart = 83180, XrefRangeEnd = 83182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0006080C File Offset: 0x0005EA0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 83182, RefRangeEnd = 83189, XrefRangeStart = 83182, XrefRangeEnd = 83189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00060858 File Offset: 0x0005EA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83189, XrefRangeEnd = 83191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000608A4 File Offset: 0x0005EAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000608F0 File Offset: 0x0005EAF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83196, RefRangeEnd = 83197, XrefRangeStart = 83191, XrefRangeEnd = 83196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0006093C File Offset: 0x0005EB3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 83199, RefRangeEnd = 83206, XrefRangeStart = 83197, XrefRangeEnd = 83199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSRGBFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0006097C File Offset: 0x0005EB7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83208, RefRangeEnd = 83209, XrefRangeStart = 83206, XrefRangeEnd = 83208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompressedTextureFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedTextureFormat_Internal_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000609BC File Offset: 0x0005EBBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 83209, RefRangeEnd = 83215, XrefRangeStart = 83209, XrefRangeEnd = 83209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCrunchFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0000EDD2 File Offset: 0x0000CFD2
		public GraphicsFormatUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0000EDDB File Offset: 0x0000CFDB
		public static GraphicsFormat GetFormat(Texture texture)
		{
			return GraphicsFormatUtility.GetFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000609FC File Offset: 0x0005EBFC
		public static TextureFormat GetTextureFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormat(format);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0000EDED File Offset: 0x0000CFED
		public static TextureFormat GetTextureFormat_Native_GraphicsFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField(format);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0000EDFA File Offset: 0x0000CFFA
		public static bool IsSwizzleFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSwizzleFormatDelegateField(format);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0000EE07 File Offset: 0x0000D007
		public static GraphicsFormat GetSRGBFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSRGBFormatDelegateField(format);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0000EE14 File Offset: 0x0000D014
		public static GraphicsFormat GetLinearFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetLinearFormatDelegateField(format);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0000EE21 File Offset: 0x0000D021
		public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetRenderTextureFormatDelegateField(format);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0000EE2E File Offset: 0x0000D02E
		public static uint GetColorComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetColorComponentCountDelegateField(format);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0000EE3B File Offset: 0x0000D03B
		public static uint GetAlphaComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetAlphaComponentCountDelegateField(format);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0000EE48 File Offset: 0x0000D048
		public static uint GetComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetComponentCountDelegateField(format);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00060A14 File Offset: 0x0005EC14
		public static string GetFormatString(GraphicsFormat format)
		{
			IntPtr intPtr = GraphicsFormatUtility.GetFormatStringDelegateField(format);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0000EE55 File Offset: 0x0000D055
		public static bool IsCompressedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsCompressedFormatDelegateField(format);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0000EE62 File Offset: 0x0000D062
		public static bool IsPackedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsPackedFormatDelegateField(format);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0000EE6F File Offset: 0x0000D06F
		public static bool Is16BitPackedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.Is16BitPackedFormatDelegateField(format);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0000EE7C File Offset: 0x0000D07C
		public static GraphicsFormat ConvertToAlphaFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.ConvertToAlphaFormatDelegateField(format);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0000EE89 File Offset: 0x0000D089
		public static bool IsAlphaOnlyFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsAlphaOnlyFormatDelegateField(format);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0000EE96 File Offset: 0x0000D096
		public static bool IsAlphaTestFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsAlphaTestFormatDelegateField(format);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0000EEA3 File Offset: 0x0000D0A3
		public static bool HasAlphaChannel(GraphicsFormat format)
		{
			return GraphicsFormatUtility.HasAlphaChannelDelegateField(format);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		public static bool IsDepthFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsDepthFormatDelegateField(format);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0000EEBD File Offset: 0x0000D0BD
		public static bool IsStencilFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsStencilFormatDelegateField(format);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0000EECA File Offset: 0x0000D0CA
		public static bool IsIEEE754Format(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsIEEE754FormatDelegateField(format);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0000EED7 File Offset: 0x0000D0D7
		public static bool IsFloatFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsFloatFormatDelegateField(format);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		public static bool IsHalfFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsHalfFormatDelegateField(format);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0000EEF1 File Offset: 0x0000D0F1
		public static bool IsUnsignedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUnsignedFormatDelegateField(format);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0000EEFE File Offset: 0x0000D0FE
		public static bool IsSignedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSignedFormatDelegateField(format);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0000EF0B File Offset: 0x0000D10B
		public static bool IsNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsNormFormatDelegateField(format);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0000EF18 File Offset: 0x0000D118
		public static bool IsUNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUNormFormatDelegateField(format);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0000EF25 File Offset: 0x0000D125
		public static bool IsSNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSNormFormatDelegateField(format);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0000EF32 File Offset: 0x0000D132
		public static bool IsIntegerFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsIntegerFormatDelegateField(format);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0000EF3F File Offset: 0x0000D13F
		public static bool IsUIntFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUIntFormatDelegateField(format);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0000EF4C File Offset: 0x0000D14C
		public static bool IsSIntFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSIntFormatDelegateField(format);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0000EF59 File Offset: 0x0000D159
		public static bool IsXRFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsXRFormatDelegateField(format);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0000EF66 File Offset: 0x0000D166
		public static bool IsDXTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsDXTCFormatDelegateField(format);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0000EF73 File Offset: 0x0000D173
		public static bool IsRGTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsRGTCFormatDelegateField(format);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0000EF80 File Offset: 0x0000D180
		public static bool IsBPTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsBPTCFormatDelegateField(format);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0000EF8D File Offset: 0x0000D18D
		public static bool IsBCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsBCFormatDelegateField(format);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0000EF9A File Offset: 0x0000D19A
		public static bool IsPVRTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsPVRTCFormatDelegateField(format);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0000EFA7 File Offset: 0x0000D1A7
		public static bool IsETCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsETCFormatDelegateField(format);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		public static bool IsEACFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsEACFormatDelegateField(format);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0000EFC1 File Offset: 0x0000D1C1
		public static bool IsASTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsASTCFormatDelegateField(format);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0000EFCE File Offset: 0x0000D1CE
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleR(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleRDelegateField(format);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0000EFDB File Offset: 0x0000D1DB
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleG(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleGDelegateField(format);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleB(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleBDelegateField(format);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0000EFF5 File Offset: 0x0000D1F5
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleA(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleADelegateField(format);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0000F002 File Offset: 0x0000D202
		public static uint GetBlockSize(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockSizeDelegateField(format);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0000F00F File Offset: 0x0000D20F
		public static uint GetBlockWidth(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockWidthDelegateField(format);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0000F01C File Offset: 0x0000D21C
		public static uint GetBlockHeight(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockHeightDelegateField(format);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00060A34 File Offset: 0x0005EC34
		public static uint ComputeMipmapSize(int width, int height, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize_Native_2D(width, height, format);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0000F029 File Offset: 0x0000D229
		public static uint ComputeMipmapSize_Native_2D(int width, int height, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize_Native_2DDelegateField(width, height, format);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00060A50 File Offset: 0x0005EC50
		public static uint ComputeMipmapSize(int width, int height, int depth, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize_Native_3D(width, height, depth, format);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0000F038 File Offset: 0x0000D238
		public static uint ComputeMipmapSize_Native_3D(int width, int height, int depth, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize_Native_3DDelegateField(width, height, depth, format);
		}

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr_IsCompressedTextureFormat_Internal_Static_Boolean_TextureFormat_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly GraphicsFormatUtility.GetFormatDelegate GetFormatDelegateField;

		// Token: 0x040014F5 RID: 5365
		private static readonly GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate GetTextureFormat_Native_GraphicsFormatDelegateField;

		// Token: 0x040014F6 RID: 5366
		private static readonly GraphicsFormatUtility.IsSwizzleFormatDelegate IsSwizzleFormatDelegateField;

		// Token: 0x040014F7 RID: 5367
		private static readonly GraphicsFormatUtility.GetSRGBFormatDelegate GetSRGBFormatDelegateField;

		// Token: 0x040014F8 RID: 5368
		private static readonly GraphicsFormatUtility.GetLinearFormatDelegate GetLinearFormatDelegateField;

		// Token: 0x040014F9 RID: 5369
		private static readonly GraphicsFormatUtility.GetRenderTextureFormatDelegate GetRenderTextureFormatDelegateField;

		// Token: 0x040014FA RID: 5370
		private static readonly GraphicsFormatUtility.GetColorComponentCountDelegate GetColorComponentCountDelegateField;

		// Token: 0x040014FB RID: 5371
		private static readonly GraphicsFormatUtility.GetAlphaComponentCountDelegate GetAlphaComponentCountDelegateField;

		// Token: 0x040014FC RID: 5372
		private static readonly GraphicsFormatUtility.GetComponentCountDelegate GetComponentCountDelegateField;

		// Token: 0x040014FD RID: 5373
		private static readonly GraphicsFormatUtility.GetFormatStringDelegate GetFormatStringDelegateField;

		// Token: 0x040014FE RID: 5374
		private static readonly GraphicsFormatUtility.IsCompressedFormatDelegate IsCompressedFormatDelegateField;

		// Token: 0x040014FF RID: 5375
		private static readonly GraphicsFormatUtility.IsPackedFormatDelegate IsPackedFormatDelegateField;

		// Token: 0x04001500 RID: 5376
		private static readonly GraphicsFormatUtility.Is16BitPackedFormatDelegate Is16BitPackedFormatDelegateField;

		// Token: 0x04001501 RID: 5377
		private static readonly GraphicsFormatUtility.ConvertToAlphaFormatDelegate ConvertToAlphaFormatDelegateField;

		// Token: 0x04001502 RID: 5378
		private static readonly GraphicsFormatUtility.IsAlphaOnlyFormatDelegate IsAlphaOnlyFormatDelegateField;

		// Token: 0x04001503 RID: 5379
		private static readonly GraphicsFormatUtility.IsAlphaTestFormatDelegate IsAlphaTestFormatDelegateField;

		// Token: 0x04001504 RID: 5380
		private static readonly GraphicsFormatUtility.HasAlphaChannelDelegate HasAlphaChannelDelegateField;

		// Token: 0x04001505 RID: 5381
		private static readonly GraphicsFormatUtility.IsDepthFormatDelegate IsDepthFormatDelegateField;

		// Token: 0x04001506 RID: 5382
		private static readonly GraphicsFormatUtility.IsStencilFormatDelegate IsStencilFormatDelegateField;

		// Token: 0x04001507 RID: 5383
		private static readonly GraphicsFormatUtility.IsIEEE754FormatDelegate IsIEEE754FormatDelegateField;

		// Token: 0x04001508 RID: 5384
		private static readonly GraphicsFormatUtility.IsFloatFormatDelegate IsFloatFormatDelegateField;

		// Token: 0x04001509 RID: 5385
		private static readonly GraphicsFormatUtility.IsHalfFormatDelegate IsHalfFormatDelegateField;

		// Token: 0x0400150A RID: 5386
		private static readonly GraphicsFormatUtility.IsUnsignedFormatDelegate IsUnsignedFormatDelegateField;

		// Token: 0x0400150B RID: 5387
		private static readonly GraphicsFormatUtility.IsSignedFormatDelegate IsSignedFormatDelegateField;

		// Token: 0x0400150C RID: 5388
		private static readonly GraphicsFormatUtility.IsNormFormatDelegate IsNormFormatDelegateField;

		// Token: 0x0400150D RID: 5389
		private static readonly GraphicsFormatUtility.IsUNormFormatDelegate IsUNormFormatDelegateField;

		// Token: 0x0400150E RID: 5390
		private static readonly GraphicsFormatUtility.IsSNormFormatDelegate IsSNormFormatDelegateField;

		// Token: 0x0400150F RID: 5391
		private static readonly GraphicsFormatUtility.IsIntegerFormatDelegate IsIntegerFormatDelegateField;

		// Token: 0x04001510 RID: 5392
		private static readonly GraphicsFormatUtility.IsUIntFormatDelegate IsUIntFormatDelegateField;

		// Token: 0x04001511 RID: 5393
		private static readonly GraphicsFormatUtility.IsSIntFormatDelegate IsSIntFormatDelegateField;

		// Token: 0x04001512 RID: 5394
		private static readonly GraphicsFormatUtility.IsXRFormatDelegate IsXRFormatDelegateField;

		// Token: 0x04001513 RID: 5395
		private static readonly GraphicsFormatUtility.IsDXTCFormatDelegate IsDXTCFormatDelegateField;

		// Token: 0x04001514 RID: 5396
		private static readonly GraphicsFormatUtility.IsRGTCFormatDelegate IsRGTCFormatDelegateField;

		// Token: 0x04001515 RID: 5397
		private static readonly GraphicsFormatUtility.IsBPTCFormatDelegate IsBPTCFormatDelegateField;

		// Token: 0x04001516 RID: 5398
		private static readonly GraphicsFormatUtility.IsBCFormatDelegate IsBCFormatDelegateField;

		// Token: 0x04001517 RID: 5399
		private static readonly GraphicsFormatUtility.IsPVRTCFormatDelegate IsPVRTCFormatDelegateField;

		// Token: 0x04001518 RID: 5400
		private static readonly GraphicsFormatUtility.IsETCFormatDelegate IsETCFormatDelegateField;

		// Token: 0x04001519 RID: 5401
		private static readonly GraphicsFormatUtility.IsEACFormatDelegate IsEACFormatDelegateField;

		// Token: 0x0400151A RID: 5402
		private static readonly GraphicsFormatUtility.IsASTCFormatDelegate IsASTCFormatDelegateField;

		// Token: 0x0400151B RID: 5403
		private static readonly GraphicsFormatUtility.GetSwizzleRDelegate GetSwizzleRDelegateField;

		// Token: 0x0400151C RID: 5404
		private static readonly GraphicsFormatUtility.GetSwizzleGDelegate GetSwizzleGDelegateField;

		// Token: 0x0400151D RID: 5405
		private static readonly GraphicsFormatUtility.GetSwizzleBDelegate GetSwizzleBDelegateField;

		// Token: 0x0400151E RID: 5406
		private static readonly GraphicsFormatUtility.GetSwizzleADelegate GetSwizzleADelegateField;

		// Token: 0x0400151F RID: 5407
		private static readonly GraphicsFormatUtility.GetBlockSizeDelegate GetBlockSizeDelegateField;

		// Token: 0x04001520 RID: 5408
		private static readonly GraphicsFormatUtility.GetBlockWidthDelegate GetBlockWidthDelegateField;

		// Token: 0x04001521 RID: 5409
		private static readonly GraphicsFormatUtility.GetBlockHeightDelegate GetBlockHeightDelegateField;

		// Token: 0x04001522 RID: 5410
		private static readonly GraphicsFormatUtility.ComputeMipmapSize_Native_2DDelegate ComputeMipmapSize_Native_2DDelegateField;

		// Token: 0x04001523 RID: 5411
		private static readonly GraphicsFormatUtility.ComputeMipmapSize_Native_3DDelegate ComputeMipmapSize_Native_3DDelegateField;

		// Token: 0x02000A15 RID: 2581
		// (Invoke) Token: 0x06003250 RID: 12880
		private delegate GraphicsFormat GetFormatDelegate(IntPtr texture);

		// Token: 0x02000A16 RID: 2582
		// (Invoke) Token: 0x06003252 RID: 12882
		private delegate TextureFormat GetTextureFormat_Native_GraphicsFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A17 RID: 2583
		// (Invoke) Token: 0x06003254 RID: 12884
		private delegate bool IsSwizzleFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A18 RID: 2584
		// (Invoke) Token: 0x06003256 RID: 12886
		private delegate GraphicsFormat GetSRGBFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A19 RID: 2585
		// (Invoke) Token: 0x06003258 RID: 12888
		private delegate GraphicsFormat GetLinearFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A1A RID: 2586
		// (Invoke) Token: 0x0600325A RID: 12890
		private delegate RenderTextureFormat GetRenderTextureFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A1B RID: 2587
		// (Invoke) Token: 0x0600325C RID: 12892
		private delegate uint GetColorComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000A1C RID: 2588
		// (Invoke) Token: 0x0600325E RID: 12894
		private delegate uint GetAlphaComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000A1D RID: 2589
		// (Invoke) Token: 0x06003260 RID: 12896
		private delegate uint GetComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000A1E RID: 2590
		// (Invoke) Token: 0x06003262 RID: 12898
		private delegate IntPtr GetFormatStringDelegate(GraphicsFormat format);

		// Token: 0x02000A1F RID: 2591
		// (Invoke) Token: 0x06003264 RID: 12900
		private delegate bool IsCompressedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A20 RID: 2592
		// (Invoke) Token: 0x06003266 RID: 12902
		private delegate bool IsPackedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A21 RID: 2593
		// (Invoke) Token: 0x06003268 RID: 12904
		private delegate bool Is16BitPackedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A22 RID: 2594
		// (Invoke) Token: 0x0600326A RID: 12906
		private delegate GraphicsFormat ConvertToAlphaFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A23 RID: 2595
		// (Invoke) Token: 0x0600326C RID: 12908
		private delegate bool IsAlphaOnlyFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A24 RID: 2596
		// (Invoke) Token: 0x0600326E RID: 12910
		private delegate bool IsAlphaTestFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A25 RID: 2597
		// (Invoke) Token: 0x06003270 RID: 12912
		private delegate bool HasAlphaChannelDelegate(GraphicsFormat format);

		// Token: 0x02000A26 RID: 2598
		// (Invoke) Token: 0x06003272 RID: 12914
		private delegate bool IsDepthFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A27 RID: 2599
		// (Invoke) Token: 0x06003274 RID: 12916
		private delegate bool IsStencilFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A28 RID: 2600
		// (Invoke) Token: 0x06003276 RID: 12918
		private delegate bool IsIEEE754FormatDelegate(GraphicsFormat format);

		// Token: 0x02000A29 RID: 2601
		// (Invoke) Token: 0x06003278 RID: 12920
		private delegate bool IsFloatFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A2A RID: 2602
		// (Invoke) Token: 0x0600327A RID: 12922
		private delegate bool IsHalfFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A2B RID: 2603
		// (Invoke) Token: 0x0600327C RID: 12924
		private delegate bool IsUnsignedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A2C RID: 2604
		// (Invoke) Token: 0x0600327E RID: 12926
		private delegate bool IsSignedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A2D RID: 2605
		// (Invoke) Token: 0x06003280 RID: 12928
		private delegate bool IsNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A2E RID: 2606
		// (Invoke) Token: 0x06003282 RID: 12930
		private delegate bool IsUNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A2F RID: 2607
		// (Invoke) Token: 0x06003284 RID: 12932
		private delegate bool IsSNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A30 RID: 2608
		// (Invoke) Token: 0x06003286 RID: 12934
		private delegate bool IsIntegerFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A31 RID: 2609
		// (Invoke) Token: 0x06003288 RID: 12936
		private delegate bool IsUIntFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A32 RID: 2610
		// (Invoke) Token: 0x0600328A RID: 12938
		private delegate bool IsSIntFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A33 RID: 2611
		// (Invoke) Token: 0x0600328C RID: 12940
		private delegate bool IsXRFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A34 RID: 2612
		// (Invoke) Token: 0x0600328E RID: 12942
		private delegate bool IsDXTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A35 RID: 2613
		// (Invoke) Token: 0x06003290 RID: 12944
		private delegate bool IsRGTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A36 RID: 2614
		// (Invoke) Token: 0x06003292 RID: 12946
		private delegate bool IsBPTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A37 RID: 2615
		// (Invoke) Token: 0x06003294 RID: 12948
		private delegate bool IsBCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A38 RID: 2616
		// (Invoke) Token: 0x06003296 RID: 12950
		private delegate bool IsPVRTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A39 RID: 2617
		// (Invoke) Token: 0x06003298 RID: 12952
		private delegate bool IsETCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A3A RID: 2618
		// (Invoke) Token: 0x0600329A RID: 12954
		private delegate bool IsEACFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A3B RID: 2619
		// (Invoke) Token: 0x0600329C RID: 12956
		private delegate bool IsASTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A3C RID: 2620
		// (Invoke) Token: 0x0600329E RID: 12958
		private delegate UnityEngine.Rendering.FormatSwizzle GetSwizzleRDelegate(GraphicsFormat format);

		// Token: 0x02000A3D RID: 2621
		// (Invoke) Token: 0x060032A0 RID: 12960
		private delegate UnityEngine.Rendering.FormatSwizzle GetSwizzleGDelegate(GraphicsFormat format);

		// Token: 0x02000A3E RID: 2622
		// (Invoke) Token: 0x060032A2 RID: 12962
		private delegate UnityEngine.Rendering.FormatSwizzle GetSwizzleBDelegate(GraphicsFormat format);

		// Token: 0x02000A3F RID: 2623
		// (Invoke) Token: 0x060032A4 RID: 12964
		private delegate UnityEngine.Rendering.FormatSwizzle GetSwizzleADelegate(GraphicsFormat format);

		// Token: 0x02000A40 RID: 2624
		// (Invoke) Token: 0x060032A6 RID: 12966
		private delegate uint GetBlockSizeDelegate(GraphicsFormat format);

		// Token: 0x02000A41 RID: 2625
		// (Invoke) Token: 0x060032A8 RID: 12968
		private delegate uint GetBlockWidthDelegate(GraphicsFormat format);

		// Token: 0x02000A42 RID: 2626
		// (Invoke) Token: 0x060032AA RID: 12970
		private delegate uint GetBlockHeightDelegate(GraphicsFormat format);

		// Token: 0x02000A43 RID: 2627
		// (Invoke) Token: 0x060032AC RID: 12972
		private delegate uint ComputeMipmapSize_Native_2DDelegate(int width, int height, GraphicsFormat format);

		// Token: 0x02000A44 RID: 2628
		// (Invoke) Token: 0x060032AE RID: 12974
		private delegate uint ComputeMipmapSize_Native_3DDelegate(int width, int height, int depth, GraphicsFormat format);
	}
}
