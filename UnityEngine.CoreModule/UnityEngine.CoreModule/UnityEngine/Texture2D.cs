using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x02000070 RID: 112
	public sealed class Texture2D : Texture
	{
		// Token: 0x06000A68 RID: 2664 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2D()
		{
			Il2CppClassPointerStore<Texture2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2D>.NativeClassPtr);
			Texture2D.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663805);
			Texture2D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663806);
			Texture2D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663807);
			Texture2D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663808);
			Texture2D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663809);
			Texture2D.NativeMethodInfoPtr_ResizeImpl_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663810);
			Texture2D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663811);
			Texture2D.NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663812);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663813);
			Texture2D.NativeMethodInfoPtr_ResizeWithFormatImpl_Private_Boolean_Int32_Int32_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663814);
			Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663815);
			Texture2D.NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663816);
			Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663817);
			Texture2D.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663818);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663819);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663820);
			Texture2D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663821);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663822);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663823);
			Texture2D.NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663824);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663825);
			Texture2D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663826);
			Texture2D.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663827);
			Texture2D.NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663828);
			Texture2D.NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663829);
			Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663830);
			Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663831);
			Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663832);
			Texture2D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663833);
			Texture2D.NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663834);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Single_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663835);
			Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100663836);
			Texture2D.get_formatDelegateField = IL2CPP.ResolveICall<Texture2D.get_formatDelegate>("UnityEngine.Texture2D::get_format");
			Texture2D.get_blackTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_blackTextureDelegate>("UnityEngine.Texture2D::get_blackTexture");
			Texture2D.get_redTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_redTextureDelegate>("UnityEngine.Texture2D::get_redTexture");
			Texture2D.get_grayTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_grayTextureDelegate>("UnityEngine.Texture2D::get_grayTexture");
			Texture2D.get_linearGrayTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_linearGrayTextureDelegate>("UnityEngine.Texture2D::get_linearGrayTexture");
			Texture2D.get_normalTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_normalTextureDelegate>("UnityEngine.Texture2D::get_normalTexture");
			Texture2D.CompressDelegateField = IL2CPP.ResolveICall<Texture2D.CompressDelegate>("UnityEngine.Texture2D::Compress");
			Texture2D.get_vtOnlyDelegateField = IL2CPP.ResolveICall<Texture2D.get_vtOnlyDelegate>("UnityEngine.Texture2D::get_vtOnly");
			Texture2D.LoadRawTextureDataImplDelegateField = IL2CPP.ResolveICall<Texture2D.LoadRawTextureDataImplDelegate>("UnityEngine.Texture2D::LoadRawTextureDataImpl");
			Texture2D.LoadRawTextureDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture2D.LoadRawTextureDataImplArrayDelegate>("UnityEngine.Texture2D::LoadRawTextureDataImplArray");
			Texture2D.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture2D.SetPixelDataImplArrayDelegate>("UnityEngine.Texture2D::SetPixelDataImplArray");
			Texture2D.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Texture2D.SetPixelDataImplDelegate>("UnityEngine.Texture2D::SetPixelDataImpl");
			Texture2D.GetWritableImageDataDelegateField = IL2CPP.ResolveICall<Texture2D.GetWritableImageDataDelegate>("UnityEngine.Texture2D::GetWritableImageData");
			Texture2D.GetRawImageDataSizeDelegateField = IL2CPP.ResolveICall<Texture2D.GetRawImageDataSizeDelegate>("UnityEngine.Texture2D::GetRawImageDataSize");
			Texture2D.GenerateAtlasImplDelegateField = IL2CPP.ResolveICall<Texture2D.GenerateAtlasImplDelegate>("UnityEngine.Texture2D::GenerateAtlasImpl");
			Texture2D.get_isPreProcessedDelegateField = IL2CPP.ResolveICall<Texture2D.get_isPreProcessedDelegate>("UnityEngine.Texture2D::get_isPreProcessed");
			Texture2D.get_streamingMipmapsDelegateField = IL2CPP.ResolveICall<Texture2D.get_streamingMipmapsDelegate>("UnityEngine.Texture2D::get_streamingMipmaps");
			Texture2D.get_streamingMipmapsPriorityDelegateField = IL2CPP.ResolveICall<Texture2D.get_streamingMipmapsPriorityDelegate>("UnityEngine.Texture2D::get_streamingMipmapsPriority");
			Texture2D.get_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_requestedMipmapLevelDelegate>("UnityEngine.Texture2D::get_requestedMipmapLevel");
			Texture2D.set_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.set_requestedMipmapLevelDelegate>("UnityEngine.Texture2D::set_requestedMipmapLevel");
			Texture2D.get_minimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_minimumMipmapLevelDelegate>("UnityEngine.Texture2D::get_minimumMipmapLevel");
			Texture2D.set_minimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.set_minimumMipmapLevelDelegate>("UnityEngine.Texture2D::set_minimumMipmapLevel");
			Texture2D.get_loadAllMipsDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadAllMipsDelegate>("UnityEngine.Texture2D::get_loadAllMips");
			Texture2D.set_loadAllMipsDelegateField = IL2CPP.ResolveICall<Texture2D.set_loadAllMipsDelegate>("UnityEngine.Texture2D::set_loadAllMips");
			Texture2D.get_calculatedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_calculatedMipmapLevelDelegate>("UnityEngine.Texture2D::get_calculatedMipmapLevel");
			Texture2D.get_desiredMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_desiredMipmapLevelDelegate>("UnityEngine.Texture2D::get_desiredMipmapLevel");
			Texture2D.get_loadingMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadingMipmapLevelDelegate>("UnityEngine.Texture2D::get_loadingMipmapLevel");
			Texture2D.get_loadedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadedMipmapLevelDelegate>("UnityEngine.Texture2D::get_loadedMipmapLevel");
			Texture2D.ClearRequestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.ClearRequestedMipmapLevelDelegate>("UnityEngine.Texture2D::ClearRequestedMipmapLevel");
			Texture2D.IsRequestedMipmapLevelLoadedDelegateField = IL2CPP.ResolveICall<Texture2D.IsRequestedMipmapLevelLoadedDelegate>("UnityEngine.Texture2D::IsRequestedMipmapLevelLoaded");
			Texture2D.ClearMinimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.ClearMinimumMipmapLevelDelegate>("UnityEngine.Texture2D::ClearMinimumMipmapLevel");
			Texture2D.UpdateExternalTextureDelegateField = IL2CPP.ResolveICall<Texture2D.UpdateExternalTextureDelegate>("UnityEngine.Texture2D::UpdateExternalTexture");
			Texture2D.SetAllPixels32DelegateField = IL2CPP.ResolveICall<Texture2D.SetAllPixels32Delegate>("UnityEngine.Texture2D::SetAllPixels32");
			Texture2D.SetBlockOfPixels32DelegateField = IL2CPP.ResolveICall<Texture2D.SetBlockOfPixels32Delegate>("UnityEngine.Texture2D::SetBlockOfPixels32");
			Texture2D.GetRawTextureDataDelegateField = IL2CPP.ResolveICall<Texture2D.GetRawTextureDataDelegate>("UnityEngine.Texture2D::GetRawTextureData");
			Texture2D.GetPixels32DelegateField = IL2CPP.ResolveICall<Texture2D.GetPixels32Delegate>("UnityEngine.Texture2D::GetPixels32");
			Texture2D.PackTexturesDelegateField = IL2CPP.ResolveICall<Texture2D.PackTexturesDelegate>("UnityEngine.Texture2D::PackTextures");
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0002E49C File Offset: 0x0002C69C
		public unsafe static Texture2D whiteTexture
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 64100, RefRangeEnd = 64107, XrefRangeStart = 64098, XrefRangeEnd = 64100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0002E4D0 File Offset: 0x0002C6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64107, XrefRangeEnd = 64109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0002E568 File Offset: 0x0002C768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64109, XrefRangeEnd = 64111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64111, XrefRangeEnd = 64113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0002E630 File Offset: 0x0002C830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64113, XrefRangeEnd = 64115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMipmaps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0002E67C File Offset: 0x0002C87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64115, XrefRangeEnd = 64117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResizeImpl(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ResizeImpl_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0002E6D4 File Offset: 0x0002C8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64117, XrefRangeEnd = 64119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelImpl(int image, int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0002E73C File Offset: 0x0002C93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64119, XrefRangeEnd = 64121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelImpl(int image, int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0002E7A4 File Offset: 0x0002C9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64121, XrefRangeEnd = 64123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelBilinearImpl(int image, float u, float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0002E80C File Offset: 0x0002CA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64123, XrefRangeEnd = 64125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResizeWithFormatImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasMipMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ResizeWithFormatImpl_Private_Boolean_Int32_Int32_GraphicsFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0002E880 File Offset: 0x0002CA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64125, XrefRangeEnd = 64127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0002E8E8 File Offset: 0x0002CAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64127, XrefRangeEnd = 64129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelsImpl(int x, int y, int w, int h, Il2CppStructArray<Color> pixel, int miplevel, int frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pixel);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002E980 File Offset: 0x0002CB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64129, XrefRangeEnd = 64131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0002EA04 File Offset: 0x0002CC04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64143, RefRangeEnd = 64145, XrefRangeStart = 64131, XrefRangeEnd = 64143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0002EA94 File Offset: 0x0002CC94
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 64147, RefRangeEnd = 64156, XrefRangeStart = 64145, XrefRangeEnd = 64147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002EB08 File Offset: 0x0002CD08
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 64162, RefRangeEnd = 64171, XrefRangeStart = 64156, XrefRangeEnd = 64162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002EB60 File Offset: 0x0002CD60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64173, RefRangeEnd = 64175, XrefRangeStart = 64171, XrefRangeEnd = 64173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixel(int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002EBBC File Offset: 0x0002CDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64175, XrefRangeEnd = 64180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color> colors, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0002EC48 File Offset: 0x0002CE48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64182, RefRangeEnd = 64185, XrefRangeStart = 64180, XrefRangeEnd = 64182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002EC8C File Offset: 0x0002CE8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64187, RefRangeEnd = 64190, XrefRangeStart = 64185, XrefRangeEnd = 64187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixel(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002ECE4 File Offset: 0x0002CEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64192, RefRangeEnd = 64193, XrefRangeStart = 64190, XrefRangeEnd = 64192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelBilinear(float u, float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0002ED3C File Offset: 0x0002CF3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64198, RefRangeEnd = 64199, XrefRangeStart = 64193, XrefRangeEnd = 64198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMipmaps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002ED88 File Offset: 0x0002CF88
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 64204, RefRangeEnd = 64212, XrefRangeStart = 64199, XrefRangeEnd = 64204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0002EDBC File Offset: 0x0002CFBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64217, RefRangeEnd = 64220, XrefRangeStart = 64212, XrefRangeEnd = 64217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Resize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0002EE14 File Offset: 0x0002D014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64225, RefRangeEnd = 64226, XrefRangeStart = 64220, XrefRangeEnd = 64225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Resize(int width, int height, TextureFormat format, bool hasMipMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasMipMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0002EE88 File Offset: 0x0002D088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64226, XrefRangeEnd = 64228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64230, RefRangeEnd = 64232, XrefRangeStart = 64228, XrefRangeEnd = 64230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixels(Rect source, int destX, int destY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0002EF4C File Offset: 0x0002D14C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64234, RefRangeEnd = 64235, XrefRangeStart = 64232, XrefRangeEnd = 64234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color> GetPixels(int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref miplevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0002EF98 File Offset: 0x0002D198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64235, XrefRangeEnd = 64237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelImpl_Injected(int image, int x, int y, ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0002F004 File Offset: 0x0002D204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64237, XrefRangeEnd = 64239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPixelImpl_Injected(int image, int x, int y, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0002F070 File Offset: 0x0002D270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64239, XrefRangeEnd = 64241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Single_Single_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0002F0DC File Offset: 0x0002D2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64241, XrefRangeEnd = 64243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00008109 File Offset: 0x00006309
		public Texture2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00008112 File Offset: 0x00006312
		public TextureFormat format
		{
			get
			{
				return Texture2D.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0002F144 File Offset: 0x0002D344
		public static Texture2D blackTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_blackTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002F16C File Offset: 0x0002D36C
		public static Texture2D redTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_redTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0002F194 File Offset: 0x0002D394
		public static Texture2D grayTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_grayTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0002F1BC File Offset: 0x0002D3BC
		public static Texture2D linearGrayTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_linearGrayTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0002F1E4 File Offset: 0x0002D3E4
		public static Texture2D normalTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_normalTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00008124 File Offset: 0x00006324
		public void Compress(bool highQuality)
		{
			Texture2D.CompressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), highQuality);
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00008137 File Offset: 0x00006337
		public bool vtOnly
		{
			get
			{
				return Texture2D.get_vtOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00008149 File Offset: 0x00006349
		public bool LoadRawTextureDataImpl(IntPtr data, int size)
		{
			return Texture2D.LoadRawTextureDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, size);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0000815D File Offset: 0x0000635D
		public bool LoadRawTextureDataImplArray(Il2CppStructArray<byte> data)
		{
			return Texture2D.LoadRawTextureDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00008175 File Offset: 0x00006375
		public bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2D.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00008193 File Offset: 0x00006393
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2D.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000081AC File Offset: 0x000063AC
		public IntPtr GetWritableImageData(int frame)
		{
			return Texture2D.GetWritableImageDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), frame);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000081BF File Offset: 0x000063BF
		public long GetRawImageDataSize()
		{
			return Texture2D.GetRawImageDataSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000081D1 File Offset: 0x000063D1
		public static void GenerateAtlasImpl(Il2CppStructArray<Vector2> sizes, int padding, int atlasSize, [Out] Il2CppStructArray<Rect> rect)
		{
			Texture2D.GenerateAtlasImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sizes), padding, atlasSize, IL2CPP.Il2CppObjectBaseToPtr(rect));
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000081EB File Offset: 0x000063EB
		public bool isPreProcessed
		{
			get
			{
				return Texture2D.get_isPreProcessedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x000081FD File Offset: 0x000063FD
		public bool streamingMipmaps
		{
			get
			{
				return Texture2D.get_streamingMipmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0000820F File Offset: 0x0000640F
		public int streamingMipmapsPriority
		{
			get
			{
				return Texture2D.get_streamingMipmapsPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00008221 File Offset: 0x00006421
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00008233 File Offset: 0x00006433
		public int requestedMipmapLevel
		{
			get
			{
				return Texture2D.get_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00008246 File Offset: 0x00006446
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00008258 File Offset: 0x00006458
		public int minimumMipmapLevel
		{
			get
			{
				return Texture2D.get_minimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_minimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0000826B File Offset: 0x0000646B
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0000827D File Offset: 0x0000647D
		public bool loadAllMips
		{
			get
			{
				return Texture2D.get_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00008290 File Offset: 0x00006490
		public int calculatedMipmapLevel
		{
			get
			{
				return Texture2D.get_calculatedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000082A2 File Offset: 0x000064A2
		public int desiredMipmapLevel
		{
			get
			{
				return Texture2D.get_desiredMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x000082B4 File Offset: 0x000064B4
		public int loadingMipmapLevel
		{
			get
			{
				return Texture2D.get_loadingMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000082C6 File Offset: 0x000064C6
		public int loadedMipmapLevel
		{
			get
			{
				return Texture2D.get_loadedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000082D8 File Offset: 0x000064D8
		public void ClearRequestedMipmapLevel()
		{
			Texture2D.ClearRequestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000082EA File Offset: 0x000064EA
		public bool IsRequestedMipmapLevelLoaded()
		{
			return Texture2D.IsRequestedMipmapLevelLoadedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000082FC File Offset: 0x000064FC
		public void ClearMinimumMipmapLevel()
		{
			Texture2D.ClearMinimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0000830E File Offset: 0x0000650E
		public void UpdateExternalTexture(IntPtr nativeTex)
		{
			Texture2D.UpdateExternalTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nativeTex);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00008321 File Offset: 0x00006521
		public void SetAllPixels32(Il2CppStructArray<Color32> colors, int miplevel)
		{
			Texture2D.SetAllPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), miplevel);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0000833A File Offset: 0x0000653A
		public void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors, int miplevel)
		{
			Texture2D.SetBlockOfPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, blockWidth, blockHeight, IL2CPP.Il2CppObjectBaseToPtr(colors), miplevel);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0002F20C File Offset: 0x0002D40C
		public Il2CppStructArray<byte> GetRawTextureData()
		{
			IntPtr intPtr = Texture2D.GetRawTextureDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0002F238 File Offset: 0x0002D438
		public Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			return this.GetPixels(x, y, blockWidth, blockHeight, 0);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0002F258 File Offset: 0x0002D458
		public Il2CppStructArray<Color32> GetPixels32(int miplevel)
		{
			IntPtr intPtr = Texture2D.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0002F288 File Offset: 0x0002D488
		public Il2CppStructArray<Color32> GetPixels32()
		{
			return this.GetPixels32(0);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0002F2A4 File Offset: 0x0002D4A4
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable)
		{
			IntPtr intPtr = Texture2D.PackTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(textures), padding, maximumAtlasSize, makeNoLongerReadable);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0002F2DC File Offset: 0x0002D4DC
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize)
		{
			return this.PackTextures(textures, padding, maximumAtlasSize, false);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding)
		{
			return this.PackTextures(textures, padding, 2048);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0002F318 File Offset: 0x0002D518
		public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex)
		{
			bool flag = nativeTex == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("nativeTex can not be null");
			}
			return new Texture2D(width, height, format, mipChain ? (-1) : 1, linear, nativeTex);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0002F358 File Offset: 0x0002D558
		public void SetPixel(int x, int y, Color color, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.SetPixelImpl(mipLevel, x, y, color);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000835A File Offset: 0x0000655A
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color> colors)
		{
			this.SetPixels(x, y, blockWidth, blockHeight, colors, 0);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002F388 File Offset: 0x0002D588
		public void SetPixels(Il2CppStructArray<Color> colors, int miplevel)
		{
			int num = this.width >> miplevel;
			bool flag = num < 1;
			if (flag)
			{
				num = 1;
			}
			int num2 = this.height >> miplevel;
			bool flag2 = num2 < 1;
			if (flag2)
			{
				num2 = 1;
			}
			this.SetPixels(0, 0, num, num2, colors, miplevel);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0002F3D0 File Offset: 0x0002D5D0
		public Color GetPixel(int x, int y, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl(mipLevel, x, y);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002F400 File Offset: 0x0002D600
		public Color GetPixelBilinear(float u, float v, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelBilinearImpl(mipLevel, u, v);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0002F430 File Offset: 0x0002D630
		public void LoadRawTextureData(IntPtr data, int size)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = data == IntPtr.Zero || size == 0;
			if (flag2)
			{
				Debug.LogError("No texture data provided to LoadRawTextureData", this);
			}
			else
			{
				bool flag3 = !this.LoadRawTextureDataImpl(data, size);
				if (flag3)
				{
					throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
				}
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0002F494 File Offset: 0x0002D694
		public void LoadRawTextureData(Il2CppStructArray<byte> data)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = data == null || data.Length == 0;
			if (flag2)
			{
				Debug.LogError("No texture data provided to LoadRawTextureData", this);
			}
			else
			{
				bool flag3 = !this.LoadRawTextureDataImplArray(data);
				if (flag3)
				{
					throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
				}
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0002F4F4 File Offset: 0x0002D6F4
		public void LoadRawTextureData<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = !data.IsCreated || data.Length == 0;
			if (flag2)
			{
				throw new UnityException("No texture data provided to LoadRawTextureData");
			}
			bool flag3 = !this.LoadRawTextureDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), data.Length * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
			if (flag3)
			{
				throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0002F56C File Offset: 0x0002D76C
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, [Optional] int sourceDataStartIndex)
		{
			bool flag = sourceDataStartIndex < 0;
			if (flag)
			{
				throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
			}
			bool flag2 = !this.isReadable;
			if (flag2)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag3 = data == null || data.Length == 0;
			if (flag3)
			{
				throw new UnityException("No texture data provided to SetPixelData.");
			}
			this.SetPixelDataImplArray(data, mipLevel, Marshal.SizeOf(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0002F5E4 File Offset: 0x0002D7E4
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, [Optional] int sourceDataStartIndex) where T : struct
		{
			bool flag = sourceDataStartIndex < 0;
			if (flag)
			{
				throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
			}
			bool flag2 = !this.isReadable;
			if (flag2)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag3 = !data.IsCreated || data.Length == 0;
			if (flag3)
			{
				throw new UnityException("No texture data provided to SetPixelData.");
			}
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0002F660 File Offset: 0x0002D860
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			int pixelDataOffset = base.GetPixelDataOffset(mipLevel, 0);
			int pixelDataSize = base.GetPixelDataSize(mipLevel, 0);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			IntPtr intPtr;
			intPtr..ctor(this.GetWritableImageData(0).ToInt64() + (long)pixelDataOffset);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, pixelDataSize / num, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
		public unsafe Unity.Collections.NativeArray<T> GetRawTextureData<T>() where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)this.GetWritableImageData(0), (int)(this.GetRawImageDataSize() / (long)num), Unity.Collections.Allocator.None);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0000836C File Offset: 0x0000656C
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002F71C File Offset: 0x0002D91C
		public bool Resize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.ResizeWithFormatImpl(width, height, format, hasMipMap);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0002F750 File Offset: 0x0002D950
		public static bool GenerateAtlas(Il2CppStructArray<Vector2> sizes, int padding, int atlasSize, List<Rect> results)
		{
			bool flag = sizes == null;
			if (flag)
			{
				throw new ArgumentException("sizes array can not be null");
			}
			bool flag2 = results == null;
			if (flag2)
			{
				throw new ArgumentException("results list cannot be null");
			}
			bool flag3 = padding < 0;
			if (flag3)
			{
				throw new ArgumentException("padding can not be negative");
			}
			bool flag4 = atlasSize <= 0;
			if (flag4)
			{
				throw new ArgumentException("atlas size must be positive");
			}
			results.Clear();
			bool flag5 = sizes.Length == 0;
			bool flag6;
			if (flag5)
			{
				flag6 = true;
			}
			else
			{
				NoAllocHelpers.EnsureListElemCount<Rect>(results, sizes.Length);
				Texture2D.GenerateAtlasImpl(sizes, padding, atlasSize, NoAllocHelpers.ExtractArrayFromListT<Rect>(results));
				flag6 = results.Count != 0;
			}
			return flag6;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00008378 File Offset: 0x00006578
		public void SetPixels32(Il2CppStructArray<Color32> colors, int miplevel)
		{
			this.SetAllPixels32(colors, miplevel);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00008384 File Offset: 0x00006584
		public void SetPixels32(Il2CppStructArray<Color32> colors)
		{
			this.SetPixels32(colors, 0);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00008390 File Offset: 0x00006590
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors, int miplevel)
		{
			this.SetBlockOfPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000083A3 File Offset: 0x000065A3
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors)
		{
			this.SetPixels32(x, y, blockWidth, blockHeight, colors, 0);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0002F7F4 File Offset: 0x0002D9F4
		public Il2CppStructArray<Color> GetPixels()
		{
			return this.GetPixels(0);
		}

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_ResizeImpl_Private_Boolean_Int32_Int32_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Color_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Single_Single_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_ResizeWithFormatImpl_Private_Boolean_Int32_Int32_GraphicsFormat_Boolean_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_byref_Color_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_byref_Color_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Single_Single_byref_Color_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0;

		// Token: 0x04000757 RID: 1879
		private static readonly Texture2D.get_formatDelegate get_formatDelegateField;

		// Token: 0x04000758 RID: 1880
		private static readonly Texture2D.get_blackTextureDelegate get_blackTextureDelegateField;

		// Token: 0x04000759 RID: 1881
		private static readonly Texture2D.get_redTextureDelegate get_redTextureDelegateField;

		// Token: 0x0400075A RID: 1882
		private static readonly Texture2D.get_grayTextureDelegate get_grayTextureDelegateField;

		// Token: 0x0400075B RID: 1883
		private static readonly Texture2D.get_linearGrayTextureDelegate get_linearGrayTextureDelegateField;

		// Token: 0x0400075C RID: 1884
		private static readonly Texture2D.get_normalTextureDelegate get_normalTextureDelegateField;

		// Token: 0x0400075D RID: 1885
		private static readonly Texture2D.CompressDelegate CompressDelegateField;

		// Token: 0x0400075E RID: 1886
		private static readonly Texture2D.get_vtOnlyDelegate get_vtOnlyDelegateField;

		// Token: 0x0400075F RID: 1887
		private static readonly Texture2D.LoadRawTextureDataImplDelegate LoadRawTextureDataImplDelegateField;

		// Token: 0x04000760 RID: 1888
		private static readonly Texture2D.LoadRawTextureDataImplArrayDelegate LoadRawTextureDataImplArrayDelegateField;

		// Token: 0x04000761 RID: 1889
		private static readonly Texture2D.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x04000762 RID: 1890
		private static readonly Texture2D.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x04000763 RID: 1891
		private static readonly Texture2D.GetWritableImageDataDelegate GetWritableImageDataDelegateField;

		// Token: 0x04000764 RID: 1892
		private static readonly Texture2D.GetRawImageDataSizeDelegate GetRawImageDataSizeDelegateField;

		// Token: 0x04000765 RID: 1893
		private static readonly Texture2D.GenerateAtlasImplDelegate GenerateAtlasImplDelegateField;

		// Token: 0x04000766 RID: 1894
		private static readonly Texture2D.get_isPreProcessedDelegate get_isPreProcessedDelegateField;

		// Token: 0x04000767 RID: 1895
		private static readonly Texture2D.get_streamingMipmapsDelegate get_streamingMipmapsDelegateField;

		// Token: 0x04000768 RID: 1896
		private static readonly Texture2D.get_streamingMipmapsPriorityDelegate get_streamingMipmapsPriorityDelegateField;

		// Token: 0x04000769 RID: 1897
		private static readonly Texture2D.get_requestedMipmapLevelDelegate get_requestedMipmapLevelDelegateField;

		// Token: 0x0400076A RID: 1898
		private static readonly Texture2D.set_requestedMipmapLevelDelegate set_requestedMipmapLevelDelegateField;

		// Token: 0x0400076B RID: 1899
		private static readonly Texture2D.get_minimumMipmapLevelDelegate get_minimumMipmapLevelDelegateField;

		// Token: 0x0400076C RID: 1900
		private static readonly Texture2D.set_minimumMipmapLevelDelegate set_minimumMipmapLevelDelegateField;

		// Token: 0x0400076D RID: 1901
		private static readonly Texture2D.get_loadAllMipsDelegate get_loadAllMipsDelegateField;

		// Token: 0x0400076E RID: 1902
		private static readonly Texture2D.set_loadAllMipsDelegate set_loadAllMipsDelegateField;

		// Token: 0x0400076F RID: 1903
		private static readonly Texture2D.get_calculatedMipmapLevelDelegate get_calculatedMipmapLevelDelegateField;

		// Token: 0x04000770 RID: 1904
		private static readonly Texture2D.get_desiredMipmapLevelDelegate get_desiredMipmapLevelDelegateField;

		// Token: 0x04000771 RID: 1905
		private static readonly Texture2D.get_loadingMipmapLevelDelegate get_loadingMipmapLevelDelegateField;

		// Token: 0x04000772 RID: 1906
		private static readonly Texture2D.get_loadedMipmapLevelDelegate get_loadedMipmapLevelDelegateField;

		// Token: 0x04000773 RID: 1907
		private static readonly Texture2D.ClearRequestedMipmapLevelDelegate ClearRequestedMipmapLevelDelegateField;

		// Token: 0x04000774 RID: 1908
		private static readonly Texture2D.IsRequestedMipmapLevelLoadedDelegate IsRequestedMipmapLevelLoadedDelegateField;

		// Token: 0x04000775 RID: 1909
		private static readonly Texture2D.ClearMinimumMipmapLevelDelegate ClearMinimumMipmapLevelDelegateField;

		// Token: 0x04000776 RID: 1910
		private static readonly Texture2D.UpdateExternalTextureDelegate UpdateExternalTextureDelegateField;

		// Token: 0x04000777 RID: 1911
		private static readonly Texture2D.SetAllPixels32Delegate SetAllPixels32DelegateField;

		// Token: 0x04000778 RID: 1912
		private static readonly Texture2D.SetBlockOfPixels32Delegate SetBlockOfPixels32DelegateField;

		// Token: 0x04000779 RID: 1913
		private static readonly Texture2D.GetRawTextureDataDelegate GetRawTextureDataDelegateField;

		// Token: 0x0400077A RID: 1914
		private static readonly Texture2D.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x0400077B RID: 1915
		private static readonly Texture2D.PackTexturesDelegate PackTexturesDelegateField;

		// Token: 0x0200068E RID: 1678
		public enum EXRFlags
		{
			// Token: 0x04001C73 RID: 7283
			None,
			// Token: 0x04001C74 RID: 7284
			OutputAsFloat,
			// Token: 0x04001C75 RID: 7285
			CompressZIP,
			// Token: 0x04001C76 RID: 7286
			CompressRLE = 4,
			// Token: 0x04001C77 RID: 7287
			CompressPIZ = 8
		}

		// Token: 0x0200068F RID: 1679
		// (Invoke) Token: 0x06002AE1 RID: 10977
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x02000690 RID: 1680
		// (Invoke) Token: 0x06002AE3 RID: 10979
		private delegate IntPtr get_blackTextureDelegate();

		// Token: 0x02000691 RID: 1681
		// (Invoke) Token: 0x06002AE5 RID: 10981
		private delegate IntPtr get_redTextureDelegate();

		// Token: 0x02000692 RID: 1682
		// (Invoke) Token: 0x06002AE7 RID: 10983
		private delegate IntPtr get_grayTextureDelegate();

		// Token: 0x02000693 RID: 1683
		// (Invoke) Token: 0x06002AE9 RID: 10985
		private delegate IntPtr get_linearGrayTextureDelegate();

		// Token: 0x02000694 RID: 1684
		// (Invoke) Token: 0x06002AEB RID: 10987
		private delegate IntPtr get_normalTextureDelegate();

		// Token: 0x02000695 RID: 1685
		// (Invoke) Token: 0x06002AED RID: 10989
		private delegate void CompressDelegate(IntPtr @this, bool highQuality);

		// Token: 0x02000696 RID: 1686
		// (Invoke) Token: 0x06002AEF RID: 10991
		private delegate bool get_vtOnlyDelegate(IntPtr @this);

		// Token: 0x02000697 RID: 1687
		// (Invoke) Token: 0x06002AF1 RID: 10993
		private delegate bool LoadRawTextureDataImplDelegate(IntPtr @this, IntPtr data, int size);

		// Token: 0x02000698 RID: 1688
		// (Invoke) Token: 0x06002AF3 RID: 10995
		private delegate bool LoadRawTextureDataImplArrayDelegate(IntPtr @this, IntPtr data);

		// Token: 0x02000699 RID: 1689
		// (Invoke) Token: 0x06002AF5 RID: 10997
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x0200069A RID: 1690
		// (Invoke) Token: 0x06002AF7 RID: 10999
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x0200069B RID: 1691
		// (Invoke) Token: 0x06002AF9 RID: 11001
		private delegate IntPtr GetWritableImageDataDelegate(IntPtr @this, int frame);

		// Token: 0x0200069C RID: 1692
		// (Invoke) Token: 0x06002AFB RID: 11003
		private delegate long GetRawImageDataSizeDelegate(IntPtr @this);

		// Token: 0x0200069D RID: 1693
		// (Invoke) Token: 0x06002AFD RID: 11005
		private delegate void GenerateAtlasImplDelegate(IntPtr sizes, int padding, int atlasSize, [Out] IntPtr rect);

		// Token: 0x0200069E RID: 1694
		// (Invoke) Token: 0x06002AFF RID: 11007
		private delegate bool get_isPreProcessedDelegate(IntPtr @this);

		// Token: 0x0200069F RID: 1695
		// (Invoke) Token: 0x06002B01 RID: 11009
		private delegate bool get_streamingMipmapsDelegate(IntPtr @this);

		// Token: 0x020006A0 RID: 1696
		// (Invoke) Token: 0x06002B03 RID: 11011
		private delegate int get_streamingMipmapsPriorityDelegate(IntPtr @this);

		// Token: 0x020006A1 RID: 1697
		// (Invoke) Token: 0x06002B05 RID: 11013
		private delegate int get_requestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006A2 RID: 1698
		// (Invoke) Token: 0x06002B07 RID: 11015
		private delegate void set_requestedMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x020006A3 RID: 1699
		// (Invoke) Token: 0x06002B09 RID: 11017
		private delegate int get_minimumMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006A4 RID: 1700
		// (Invoke) Token: 0x06002B0B RID: 11019
		private delegate void set_minimumMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x020006A5 RID: 1701
		// (Invoke) Token: 0x06002B0D RID: 11021
		private delegate bool get_loadAllMipsDelegate(IntPtr @this);

		// Token: 0x020006A6 RID: 1702
		// (Invoke) Token: 0x06002B0F RID: 11023
		private delegate void set_loadAllMipsDelegate(IntPtr @this, bool value);

		// Token: 0x020006A7 RID: 1703
		// (Invoke) Token: 0x06002B11 RID: 11025
		private delegate int get_calculatedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006A8 RID: 1704
		// (Invoke) Token: 0x06002B13 RID: 11027
		private delegate int get_desiredMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006A9 RID: 1705
		// (Invoke) Token: 0x06002B15 RID: 11029
		private delegate int get_loadingMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006AA RID: 1706
		// (Invoke) Token: 0x06002B17 RID: 11031
		private delegate int get_loadedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006AB RID: 1707
		// (Invoke) Token: 0x06002B19 RID: 11033
		private delegate void ClearRequestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006AC RID: 1708
		// (Invoke) Token: 0x06002B1B RID: 11035
		private delegate bool IsRequestedMipmapLevelLoadedDelegate(IntPtr @this);

		// Token: 0x020006AD RID: 1709
		// (Invoke) Token: 0x06002B1D RID: 11037
		private delegate void ClearMinimumMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006AE RID: 1710
		// (Invoke) Token: 0x06002B1F RID: 11039
		private delegate void UpdateExternalTextureDelegate(IntPtr @this, IntPtr nativeTex);

		// Token: 0x020006AF RID: 1711
		// (Invoke) Token: 0x06002B21 RID: 11041
		private delegate void SetAllPixels32Delegate(IntPtr @this, IntPtr colors, int miplevel);

		// Token: 0x020006B0 RID: 1712
		// (Invoke) Token: 0x06002B23 RID: 11043
		private delegate void SetBlockOfPixels32Delegate(IntPtr @this, int x, int y, int blockWidth, int blockHeight, IntPtr colors, int miplevel);

		// Token: 0x020006B1 RID: 1713
		// (Invoke) Token: 0x06002B25 RID: 11045
		private delegate IntPtr GetRawTextureDataDelegate(IntPtr @this);

		// Token: 0x020006B2 RID: 1714
		// (Invoke) Token: 0x06002B27 RID: 11047
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, int miplevel);

		// Token: 0x020006B3 RID: 1715
		// (Invoke) Token: 0x06002B29 RID: 11049
		private delegate IntPtr PackTexturesDelegate(IntPtr @this, IntPtr textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
	}
}
