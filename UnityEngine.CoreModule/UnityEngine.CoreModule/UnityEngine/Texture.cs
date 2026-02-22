using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200006F RID: 111
	public class Texture : Object
	{
		// Token: 0x06000A24 RID: 2596 RVA: 0x0002D678 File Offset: 0x0002B878
		// Note: this type is marked as 'beforefieldinit'.
		static Texture()
		{
			Il2CppClassPointerStore<Texture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture>.NativeClassPtr);
			Texture.NativeFieldInfoPtr_GenerateAllMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture>.NativeClassPtr, "GenerateAllMips");
			Texture.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663787);
			Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663788);
			Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663789);
			Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663790);
			Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663791);
			Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663792);
			Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663793);
			Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663794);
			Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663795);
			Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663796);
			Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663797);
			Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663798);
			Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663799);
			Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663800);
			Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663801);
			Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663802);
			Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100663804);
			Texture.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.get_masterTextureLimitDelegate>("UnityEngine.Texture::get_masterTextureLimit");
			Texture.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.set_masterTextureLimitDelegate>("UnityEngine.Texture::set_masterTextureLimit");
			Texture.get_mipmapCountDelegateField = IL2CPP.ResolveICall<Texture.get_mipmapCountDelegate>("UnityEngine.Texture::get_mipmapCount");
			Texture.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.get_anisotropicFilteringDelegate>("UnityEngine.Texture::get_anisotropicFiltering");
			Texture.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.set_anisotropicFilteringDelegate>("UnityEngine.Texture::set_anisotropicFiltering");
			Texture.SetGlobalAnisotropicFilteringLimitsDelegateField = IL2CPP.ResolveICall<Texture.SetGlobalAnisotropicFilteringLimitsDelegate>("UnityEngine.Texture::SetGlobalAnisotropicFilteringLimits");
			Texture.GetDimensionDelegateField = IL2CPP.ResolveICall<Texture.GetDimensionDelegate>("UnityEngine.Texture::GetDimension");
			Texture.set_wrapModeDelegateField = IL2CPP.ResolveICall<Texture.set_wrapModeDelegate>("UnityEngine.Texture::set_wrapMode");
			Texture.get_wrapModeUDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeUDelegate>("UnityEngine.Texture::get_wrapModeU");
			Texture.set_wrapModeUDelegateField = IL2CPP.ResolveICall<Texture.set_wrapModeUDelegate>("UnityEngine.Texture::set_wrapModeU");
			Texture.get_wrapModeVDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeVDelegate>("UnityEngine.Texture::get_wrapModeV");
			Texture.set_wrapModeVDelegateField = IL2CPP.ResolveICall<Texture.set_wrapModeVDelegate>("UnityEngine.Texture::set_wrapModeV");
			Texture.get_wrapModeWDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeWDelegate>("UnityEngine.Texture::get_wrapModeW");
			Texture.set_wrapModeWDelegateField = IL2CPP.ResolveICall<Texture.set_wrapModeWDelegate>("UnityEngine.Texture::set_wrapModeW");
			Texture.get_filterModeDelegateField = IL2CPP.ResolveICall<Texture.get_filterModeDelegate>("UnityEngine.Texture::get_filterMode");
			Texture.get_anisoLevelDelegateField = IL2CPP.ResolveICall<Texture.get_anisoLevelDelegate>("UnityEngine.Texture::get_anisoLevel");
			Texture.set_anisoLevelDelegateField = IL2CPP.ResolveICall<Texture.set_anisoLevelDelegate>("UnityEngine.Texture::set_anisoLevel");
			Texture.get_mipMapBiasDelegateField = IL2CPP.ResolveICall<Texture.get_mipMapBiasDelegate>("UnityEngine.Texture::get_mipMapBias");
			Texture.set_mipMapBiasDelegateField = IL2CPP.ResolveICall<Texture.set_mipMapBiasDelegate>("UnityEngine.Texture::set_mipMapBias");
			Texture.GetNativeTexturePtrDelegateField = IL2CPP.ResolveICall<Texture.GetNativeTexturePtrDelegate>("UnityEngine.Texture::GetNativeTexturePtr");
			Texture.get_updateCountDelegateField = IL2CPP.ResolveICall<Texture.get_updateCountDelegate>("UnityEngine.Texture::get_updateCount");
			Texture.IncrementUpdateCountDelegateField = IL2CPP.ResolveICall<Texture.IncrementUpdateCountDelegate>("UnityEngine.Texture::IncrementUpdateCount");
			Texture.get_totalTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_totalTextureMemoryDelegate>("UnityEngine.Texture::get_totalTextureMemory");
			Texture.get_desiredTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_desiredTextureMemoryDelegate>("UnityEngine.Texture::get_desiredTextureMemory");
			Texture.get_targetTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_targetTextureMemoryDelegate>("UnityEngine.Texture::get_targetTextureMemory");
			Texture.get_currentTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_currentTextureMemoryDelegate>("UnityEngine.Texture::get_currentTextureMemory");
			Texture.get_nonStreamingTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureMemoryDelegate>("UnityEngine.Texture::get_nonStreamingTextureMemory");
			Texture.get_streamingMipmapUploadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingMipmapUploadCountDelegate>("UnityEngine.Texture::get_streamingMipmapUploadCount");
			Texture.get_streamingRendererCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingRendererCountDelegate>("UnityEngine.Texture::get_streamingRendererCount");
			Texture.get_streamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureCountDelegate>("UnityEngine.Texture::get_streamingTextureCount");
			Texture.get_nonStreamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureCountDelegate>("UnityEngine.Texture::get_nonStreamingTextureCount");
			Texture.get_streamingTexturePendingLoadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTexturePendingLoadCountDelegate>("UnityEngine.Texture::get_streamingTexturePendingLoadCount");
			Texture.get_streamingTextureLoadingCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureLoadingCountDelegate>("UnityEngine.Texture::get_streamingTextureLoadingCount");
			Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField = IL2CPP.ResolveICall<Texture.SetStreamingTextureMaterialDebugPropertiesDelegate>("UnityEngine.Texture::SetStreamingTextureMaterialDebugProperties");
			Texture.get_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::get_streamingTextureForceLoadAll");
			Texture.set_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::set_streamingTextureForceLoadAll");
			Texture.get_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::get_streamingTextureDiscardUnusedMips");
			Texture.set_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::set_streamingTextureDiscardUnusedMips");
			Texture.get_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.get_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::get_allowThreadedTextureCreation");
			Texture.set_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.set_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::set_allowThreadedTextureCreation");
			Texture.GetPixelDataSizeDelegateField = IL2CPP.ResolveICall<Texture.GetPixelDataSizeDelegate>("UnityEngine.Texture::GetPixelDataSize");
			Texture.GetPixelDataOffsetDelegateField = IL2CPP.ResolveICall<Texture.GetPixelDataOffsetDelegate>("UnityEngine.Texture::GetPixelDataOffset");
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0002DA88 File Offset: 0x0002BC88
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 63980, RefRangeEnd = 63988, XrefRangeStart = 63976, XrefRangeEnd = 63980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0002DAC4 File Offset: 0x0002BCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63988, XrefRangeEnd = 63990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0002DB00 File Offset: 0x0002BD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63990, XrefRangeEnd = 63992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0002DB3C File Offset: 0x0002BD3C
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x0002DB84 File Offset: 0x0002BD84
		public unsafe virtual int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63992, XrefRangeEnd = 63997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0002DBD0 File Offset: 0x0002BDD0
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0002DC18 File Offset: 0x0002BE18
		public unsafe virtual int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63997, XrefRangeEnd = 64002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0002DC64 File Offset: 0x0002BE64
		public unsafe virtual bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64002, XrefRangeEnd = 64004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0002DCAC File Offset: 0x0002BEAC
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00007EF2 File Offset: 0x000060F2
		public unsafe TextureWrapMode wrapMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64006, RefRangeEnd = 64007, XrefRangeStart = 64004, XrefRangeEnd = 64006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Texture.set_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00007F74 File Offset: 0x00006174
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0002DCE8 File Offset: 0x0002BEE8
		public unsafe FilterMode filterMode
		{
			get
			{
				return Texture.get_filterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 64009, RefRangeEnd = 64011, XrefRangeStart = 64007, XrefRangeEnd = 64009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0002DD28 File Offset: 0x0002BF28
		public unsafe Vector2 texelSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 64013, RefRangeEnd = 64015, XrefRangeStart = 64011, XrefRangeEnd = 64013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002DD64 File Offset: 0x0002BF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64015, XrefRangeEnd = 64017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_GetActiveTextureColorSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0002DDA0 File Offset: 0x0002BFA0
		public unsafe ColorSpace activeTextureColorSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64017, XrefRangeEnd = 64019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002DDDC File Offset: 0x0002BFDC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 64042, RefRangeEnd = 64050, XrefRangeStart = 64019, XrefRangeEnd = 64042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002DE28 File Offset: 0x0002C028
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 64067, RefRangeEnd = 64081, XrefRangeStart = 64050, XrefRangeEnd = 64067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0002DE80 File Offset: 0x0002C080
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 64092, RefRangeEnd = 64096, XrefRangeStart = 64081, XrefRangeEnd = 64092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException CreateNonReadableException(Texture t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityException>(intPtr3) : null;
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64096, XrefRangeEnd = 64098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_texelSize_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00007E6F File Offset: 0x0000606F
		public Texture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0002DF10 File Offset: 0x0002C110
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00007E78 File Offset: 0x00006078
		public unsafe static int GenerateAllMips
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*)(&value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00007E86 File Offset: 0x00006086
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00007E92 File Offset: 0x00006092
		public static int masterTextureLimit
		{
			get
			{
				return Texture.get_masterTextureLimitDelegateField();
			}
			set
			{
				Texture.set_masterTextureLimitDelegateField(value);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00007E9F File Offset: 0x0000609F
		public int mipmapCount
		{
			get
			{
				return Texture.get_mipmapCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00007EB1 File Offset: 0x000060B1
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00007EBD File Offset: 0x000060BD
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return Texture.get_anisotropicFilteringDelegateField();
			}
			set
			{
				Texture.set_anisotropicFilteringDelegateField(value);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00007ECA File Offset: 0x000060CA
		public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax)
		{
			Texture.SetGlobalAnisotropicFilteringLimitsDelegateField(forcedMin, globalMax);
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0002DF2C File Offset: 0x0002C12C
		public virtual UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			get
			{
				return UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetFormat(this);
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00007ED8 File Offset: 0x000060D8
		public UnityEngine.Rendering.TextureDimension GetDimension()
		{
			return Texture.GetDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0002DF44 File Offset: 0x0002C144
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00007EEA File Offset: 0x000060EA
		public virtual UnityEngine.Rendering.TextureDimension dimension
		{
			get
			{
				return this.GetDimension();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00007F05 File Offset: 0x00006105
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00007F17 File Offset: 0x00006117
		public TextureWrapMode wrapModeU
		{
			get
			{
				return Texture.get_wrapModeUDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_wrapModeUDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00007F2A File Offset: 0x0000612A
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00007F3C File Offset: 0x0000613C
		public TextureWrapMode wrapModeV
		{
			get
			{
				return Texture.get_wrapModeVDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_wrapModeVDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00007F4F File Offset: 0x0000614F
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00007F61 File Offset: 0x00006161
		public TextureWrapMode wrapModeW
		{
			get
			{
				return Texture.get_wrapModeWDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_wrapModeWDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00007F86 File Offset: 0x00006186
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00007F98 File Offset: 0x00006198
		public int anisoLevel
		{
			get
			{
				return Texture.get_anisoLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_anisoLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00007FAB File Offset: 0x000061AB
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00007FBD File Offset: 0x000061BD
		public float mipMapBias
		{
			get
			{
				return Texture.get_mipMapBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_mipMapBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00007FD0 File Offset: 0x000061D0
		public IntPtr GetNativeTexturePtr()
		{
			return Texture.GetNativeTexturePtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002DF5C File Offset: 0x0002C15C
		public int GetNativeTextureID()
		{
			return (int)this.GetNativeTexturePtr();
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00007FE2 File Offset: 0x000061E2
		public uint updateCount
		{
			get
			{
				return Texture.get_updateCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00007FF4 File Offset: 0x000061F4
		public void IncrementUpdateCount()
		{
			Texture.IncrementUpdateCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00008006 File Offset: 0x00006206
		public static ulong totalTextureMemory
		{
			get
			{
				return Texture.get_totalTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00008012 File Offset: 0x00006212
		public static ulong desiredTextureMemory
		{
			get
			{
				return Texture.get_desiredTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0000801E File Offset: 0x0000621E
		public static ulong targetTextureMemory
		{
			get
			{
				return Texture.get_targetTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0000802A File Offset: 0x0000622A
		public static ulong currentTextureMemory
		{
			get
			{
				return Texture.get_currentTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00008036 File Offset: 0x00006236
		public static ulong nonStreamingTextureMemory
		{
			get
			{
				return Texture.get_nonStreamingTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00008042 File Offset: 0x00006242
		public static ulong streamingMipmapUploadCount
		{
			get
			{
				return Texture.get_streamingMipmapUploadCountDelegateField();
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0000804E File Offset: 0x0000624E
		public static ulong streamingRendererCount
		{
			get
			{
				return Texture.get_streamingRendererCountDelegateField();
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0000805A File Offset: 0x0000625A
		public static ulong streamingTextureCount
		{
			get
			{
				return Texture.get_streamingTextureCountDelegateField();
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00008066 File Offset: 0x00006266
		public static ulong nonStreamingTextureCount
		{
			get
			{
				return Texture.get_nonStreamingTextureCountDelegateField();
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00008072 File Offset: 0x00006272
		public static ulong streamingTexturePendingLoadCount
		{
			get
			{
				return Texture.get_streamingTexturePendingLoadCountDelegateField();
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0000807E File Offset: 0x0000627E
		public static ulong streamingTextureLoadingCount
		{
			get
			{
				return Texture.get_streamingTextureLoadingCountDelegateField();
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0000808A File Offset: 0x0000628A
		public static void SetStreamingTextureMaterialDebugProperties()
		{
			Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField();
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00008096 File Offset: 0x00006296
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x000080A2 File Offset: 0x000062A2
		public static bool streamingTextureForceLoadAll
		{
			get
			{
				return Texture.get_streamingTextureForceLoadAllDelegateField();
			}
			set
			{
				Texture.set_streamingTextureForceLoadAllDelegateField(value);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x000080AF File Offset: 0x000062AF
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x000080BB File Offset: 0x000062BB
		public static bool streamingTextureDiscardUnusedMips
		{
			get
			{
				return Texture.get_streamingTextureDiscardUnusedMipsDelegateField();
			}
			set
			{
				Texture.set_streamingTextureDiscardUnusedMipsDelegateField(value);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x000080C8 File Offset: 0x000062C8
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x000080D4 File Offset: 0x000062D4
		public static bool allowThreadedTextureCreation
		{
			get
			{
				return Texture.get_allowThreadedTextureCreationDelegateField();
			}
			set
			{
				Texture.set_allowThreadedTextureCreationDelegateField(value);
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000080E1 File Offset: 0x000062E1
		public int GetPixelDataSize(int mipLevel, [Optional] int element)
		{
			return Texture.GetPixelDataSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mipLevel, element);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000080F5 File Offset: 0x000062F5
		public int GetPixelDataOffset(int mipLevel, [Optional] int element)
		{
			return Texture.GetPixelDataOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mipLevel, element);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002DF7C File Offset: 0x0002C17C
		public bool ValidateFormat(RenderTextureFormat format)
		{
			bool flag = SystemInfo.SupportsRenderTextureFormat(format);
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				Debug.LogError(String.Format("RenderTexture creation failed. '{0}' is not supported on this platform. Use 'SystemInfo.SupportsRenderTextureFormat' C# API to check format support.", format.ToString()), this);
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_GenerateAllMips;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_GetDataWidth_Private_Int32_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_GetDataHeight_Private_Int32_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400070D RID: 1805
		private static readonly Texture.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

		// Token: 0x0400070E RID: 1806
		private static readonly Texture.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

		// Token: 0x0400070F RID: 1807
		private static readonly Texture.get_mipmapCountDelegate get_mipmapCountDelegateField;

		// Token: 0x04000710 RID: 1808
		private static readonly Texture.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

		// Token: 0x04000711 RID: 1809
		private static readonly Texture.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

		// Token: 0x04000712 RID: 1810
		private static readonly Texture.SetGlobalAnisotropicFilteringLimitsDelegate SetGlobalAnisotropicFilteringLimitsDelegateField;

		// Token: 0x04000713 RID: 1811
		private static readonly Texture.GetDimensionDelegate GetDimensionDelegateField;

		// Token: 0x04000714 RID: 1812
		private static readonly Texture.set_wrapModeDelegate set_wrapModeDelegateField;

		// Token: 0x04000715 RID: 1813
		private static readonly Texture.get_wrapModeUDelegate get_wrapModeUDelegateField;

		// Token: 0x04000716 RID: 1814
		private static readonly Texture.set_wrapModeUDelegate set_wrapModeUDelegateField;

		// Token: 0x04000717 RID: 1815
		private static readonly Texture.get_wrapModeVDelegate get_wrapModeVDelegateField;

		// Token: 0x04000718 RID: 1816
		private static readonly Texture.set_wrapModeVDelegate set_wrapModeVDelegateField;

		// Token: 0x04000719 RID: 1817
		private static readonly Texture.get_wrapModeWDelegate get_wrapModeWDelegateField;

		// Token: 0x0400071A RID: 1818
		private static readonly Texture.set_wrapModeWDelegate set_wrapModeWDelegateField;

		// Token: 0x0400071B RID: 1819
		private static readonly Texture.get_filterModeDelegate get_filterModeDelegateField;

		// Token: 0x0400071C RID: 1820
		private static readonly Texture.get_anisoLevelDelegate get_anisoLevelDelegateField;

		// Token: 0x0400071D RID: 1821
		private static readonly Texture.set_anisoLevelDelegate set_anisoLevelDelegateField;

		// Token: 0x0400071E RID: 1822
		private static readonly Texture.get_mipMapBiasDelegate get_mipMapBiasDelegateField;

		// Token: 0x0400071F RID: 1823
		private static readonly Texture.set_mipMapBiasDelegate set_mipMapBiasDelegateField;

		// Token: 0x04000720 RID: 1824
		private static readonly Texture.GetNativeTexturePtrDelegate GetNativeTexturePtrDelegateField;

		// Token: 0x04000721 RID: 1825
		private static readonly Texture.get_updateCountDelegate get_updateCountDelegateField;

		// Token: 0x04000722 RID: 1826
		private static readonly Texture.IncrementUpdateCountDelegate IncrementUpdateCountDelegateField;

		// Token: 0x04000723 RID: 1827
		private static readonly Texture.get_totalTextureMemoryDelegate get_totalTextureMemoryDelegateField;

		// Token: 0x04000724 RID: 1828
		private static readonly Texture.get_desiredTextureMemoryDelegate get_desiredTextureMemoryDelegateField;

		// Token: 0x04000725 RID: 1829
		private static readonly Texture.get_targetTextureMemoryDelegate get_targetTextureMemoryDelegateField;

		// Token: 0x04000726 RID: 1830
		private static readonly Texture.get_currentTextureMemoryDelegate get_currentTextureMemoryDelegateField;

		// Token: 0x04000727 RID: 1831
		private static readonly Texture.get_nonStreamingTextureMemoryDelegate get_nonStreamingTextureMemoryDelegateField;

		// Token: 0x04000728 RID: 1832
		private static readonly Texture.get_streamingMipmapUploadCountDelegate get_streamingMipmapUploadCountDelegateField;

		// Token: 0x04000729 RID: 1833
		private static readonly Texture.get_streamingRendererCountDelegate get_streamingRendererCountDelegateField;

		// Token: 0x0400072A RID: 1834
		private static readonly Texture.get_streamingTextureCountDelegate get_streamingTextureCountDelegateField;

		// Token: 0x0400072B RID: 1835
		private static readonly Texture.get_nonStreamingTextureCountDelegate get_nonStreamingTextureCountDelegateField;

		// Token: 0x0400072C RID: 1836
		private static readonly Texture.get_streamingTexturePendingLoadCountDelegate get_streamingTexturePendingLoadCountDelegateField;

		// Token: 0x0400072D RID: 1837
		private static readonly Texture.get_streamingTextureLoadingCountDelegate get_streamingTextureLoadingCountDelegateField;

		// Token: 0x0400072E RID: 1838
		private static readonly Texture.SetStreamingTextureMaterialDebugPropertiesDelegate SetStreamingTextureMaterialDebugPropertiesDelegateField;

		// Token: 0x0400072F RID: 1839
		private static readonly Texture.get_streamingTextureForceLoadAllDelegate get_streamingTextureForceLoadAllDelegateField;

		// Token: 0x04000730 RID: 1840
		private static readonly Texture.set_streamingTextureForceLoadAllDelegate set_streamingTextureForceLoadAllDelegateField;

		// Token: 0x04000731 RID: 1841
		private static readonly Texture.get_streamingTextureDiscardUnusedMipsDelegate get_streamingTextureDiscardUnusedMipsDelegateField;

		// Token: 0x04000732 RID: 1842
		private static readonly Texture.set_streamingTextureDiscardUnusedMipsDelegate set_streamingTextureDiscardUnusedMipsDelegateField;

		// Token: 0x04000733 RID: 1843
		private static readonly Texture.get_allowThreadedTextureCreationDelegate get_allowThreadedTextureCreationDelegateField;

		// Token: 0x04000734 RID: 1844
		private static readonly Texture.set_allowThreadedTextureCreationDelegate set_allowThreadedTextureCreationDelegateField;

		// Token: 0x04000735 RID: 1845
		private static readonly Texture.GetPixelDataSizeDelegate GetPixelDataSizeDelegateField;

		// Token: 0x04000736 RID: 1846
		private static readonly Texture.GetPixelDataOffsetDelegate GetPixelDataOffsetDelegateField;

		// Token: 0x02000664 RID: 1636
		// (Invoke) Token: 0x06002A8D RID: 10893
		private delegate int get_masterTextureLimitDelegate();

		// Token: 0x02000665 RID: 1637
		// (Invoke) Token: 0x06002A8F RID: 10895
		private delegate void set_masterTextureLimitDelegate(int value);

		// Token: 0x02000666 RID: 1638
		// (Invoke) Token: 0x06002A91 RID: 10897
		private delegate int get_mipmapCountDelegate(IntPtr @this);

		// Token: 0x02000667 RID: 1639
		// (Invoke) Token: 0x06002A93 RID: 10899
		private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

		// Token: 0x02000668 RID: 1640
		// (Invoke) Token: 0x06002A95 RID: 10901
		private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

		// Token: 0x02000669 RID: 1641
		// (Invoke) Token: 0x06002A97 RID: 10903
		private delegate void SetGlobalAnisotropicFilteringLimitsDelegate(int forcedMin, int globalMax);

		// Token: 0x0200066A RID: 1642
		// (Invoke) Token: 0x06002A99 RID: 10905
		private delegate UnityEngine.Rendering.TextureDimension GetDimensionDelegate(IntPtr @this);

		// Token: 0x0200066B RID: 1643
		// (Invoke) Token: 0x06002A9B RID: 10907
		private delegate void set_wrapModeDelegate(IntPtr @this, TextureWrapMode value);

		// Token: 0x0200066C RID: 1644
		// (Invoke) Token: 0x06002A9D RID: 10909
		private delegate TextureWrapMode get_wrapModeUDelegate(IntPtr @this);

		// Token: 0x0200066D RID: 1645
		// (Invoke) Token: 0x06002A9F RID: 10911
		private delegate void set_wrapModeUDelegate(IntPtr @this, TextureWrapMode value);

		// Token: 0x0200066E RID: 1646
		// (Invoke) Token: 0x06002AA1 RID: 10913
		private delegate TextureWrapMode get_wrapModeVDelegate(IntPtr @this);

		// Token: 0x0200066F RID: 1647
		// (Invoke) Token: 0x06002AA3 RID: 10915
		private delegate void set_wrapModeVDelegate(IntPtr @this, TextureWrapMode value);

		// Token: 0x02000670 RID: 1648
		// (Invoke) Token: 0x06002AA5 RID: 10917
		private delegate TextureWrapMode get_wrapModeWDelegate(IntPtr @this);

		// Token: 0x02000671 RID: 1649
		// (Invoke) Token: 0x06002AA7 RID: 10919
		private delegate void set_wrapModeWDelegate(IntPtr @this, TextureWrapMode value);

		// Token: 0x02000672 RID: 1650
		// (Invoke) Token: 0x06002AA9 RID: 10921
		private delegate FilterMode get_filterModeDelegate(IntPtr @this);

		// Token: 0x02000673 RID: 1651
		// (Invoke) Token: 0x06002AAB RID: 10923
		private delegate int get_anisoLevelDelegate(IntPtr @this);

		// Token: 0x02000674 RID: 1652
		// (Invoke) Token: 0x06002AAD RID: 10925
		private delegate void set_anisoLevelDelegate(IntPtr @this, int value);

		// Token: 0x02000675 RID: 1653
		// (Invoke) Token: 0x06002AAF RID: 10927
		private delegate float get_mipMapBiasDelegate(IntPtr @this);

		// Token: 0x02000676 RID: 1654
		// (Invoke) Token: 0x06002AB1 RID: 10929
		private delegate void set_mipMapBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000677 RID: 1655
		// (Invoke) Token: 0x06002AB3 RID: 10931
		private delegate IntPtr GetNativeTexturePtrDelegate(IntPtr @this);

		// Token: 0x02000678 RID: 1656
		// (Invoke) Token: 0x06002AB5 RID: 10933
		private delegate uint get_updateCountDelegate(IntPtr @this);

		// Token: 0x02000679 RID: 1657
		// (Invoke) Token: 0x06002AB7 RID: 10935
		private delegate void IncrementUpdateCountDelegate(IntPtr @this);

		// Token: 0x0200067A RID: 1658
		// (Invoke) Token: 0x06002AB9 RID: 10937
		private delegate ulong get_totalTextureMemoryDelegate();

		// Token: 0x0200067B RID: 1659
		// (Invoke) Token: 0x06002ABB RID: 10939
		private delegate ulong get_desiredTextureMemoryDelegate();

		// Token: 0x0200067C RID: 1660
		// (Invoke) Token: 0x06002ABD RID: 10941
		private delegate ulong get_targetTextureMemoryDelegate();

		// Token: 0x0200067D RID: 1661
		// (Invoke) Token: 0x06002ABF RID: 10943
		private delegate ulong get_currentTextureMemoryDelegate();

		// Token: 0x0200067E RID: 1662
		// (Invoke) Token: 0x06002AC1 RID: 10945
		private delegate ulong get_nonStreamingTextureMemoryDelegate();

		// Token: 0x0200067F RID: 1663
		// (Invoke) Token: 0x06002AC3 RID: 10947
		private delegate ulong get_streamingMipmapUploadCountDelegate();

		// Token: 0x02000680 RID: 1664
		// (Invoke) Token: 0x06002AC5 RID: 10949
		private delegate ulong get_streamingRendererCountDelegate();

		// Token: 0x02000681 RID: 1665
		// (Invoke) Token: 0x06002AC7 RID: 10951
		private delegate ulong get_streamingTextureCountDelegate();

		// Token: 0x02000682 RID: 1666
		// (Invoke) Token: 0x06002AC9 RID: 10953
		private delegate ulong get_nonStreamingTextureCountDelegate();

		// Token: 0x02000683 RID: 1667
		// (Invoke) Token: 0x06002ACB RID: 10955
		private delegate ulong get_streamingTexturePendingLoadCountDelegate();

		// Token: 0x02000684 RID: 1668
		// (Invoke) Token: 0x06002ACD RID: 10957
		private delegate ulong get_streamingTextureLoadingCountDelegate();

		// Token: 0x02000685 RID: 1669
		// (Invoke) Token: 0x06002ACF RID: 10959
		private delegate void SetStreamingTextureMaterialDebugPropertiesDelegate();

		// Token: 0x02000686 RID: 1670
		// (Invoke) Token: 0x06002AD1 RID: 10961
		private delegate bool get_streamingTextureForceLoadAllDelegate();

		// Token: 0x02000687 RID: 1671
		// (Invoke) Token: 0x06002AD3 RID: 10963
		private delegate void set_streamingTextureForceLoadAllDelegate(bool value);

		// Token: 0x02000688 RID: 1672
		// (Invoke) Token: 0x06002AD5 RID: 10965
		private delegate bool get_streamingTextureDiscardUnusedMipsDelegate();

		// Token: 0x02000689 RID: 1673
		// (Invoke) Token: 0x06002AD7 RID: 10967
		private delegate void set_streamingTextureDiscardUnusedMipsDelegate(bool value);

		// Token: 0x0200068A RID: 1674
		// (Invoke) Token: 0x06002AD9 RID: 10969
		private delegate bool get_allowThreadedTextureCreationDelegate();

		// Token: 0x0200068B RID: 1675
		// (Invoke) Token: 0x06002ADB RID: 10971
		private delegate void set_allowThreadedTextureCreationDelegate(bool value);

		// Token: 0x0200068C RID: 1676
		// (Invoke) Token: 0x06002ADD RID: 10973
		private delegate int GetPixelDataSizeDelegate(IntPtr @this, int mipLevel, int element);

		// Token: 0x0200068D RID: 1677
		// (Invoke) Token: 0x06002ADF RID: 10975
		private delegate int GetPixelDataOffsetDelegate(IntPtr @this, int mipLevel, int element);
	}
}
