using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000075 RID: 117
	public class RenderTexture : Texture
	{
		// Token: 0x06000B6A RID: 2922 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTexture()
		{
			Il2CppClassPointerStore<RenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr);
			RenderTexture.NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663879);
			RenderTexture.NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663880);
			RenderTexture.NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663881);
			RenderTexture.NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663882);
			RenderTexture.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663883);
			RenderTexture.NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663884);
			RenderTexture.NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663885);
			RenderTexture.NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663886);
			RenderTexture.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663887);
			RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663888);
			RenderTexture.NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663889);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663890);
			RenderTexture.NativeMethodInfoPtr_set_depth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663891);
			RenderTexture.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663892);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663893);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663894);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663895);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663896);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663897);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663898);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663899);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663900);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663901);
			RenderTexture.NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663902);
			RenderTexture.NativeMethodInfoPtr_set_descriptor_Public_set_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663903);
			RenderTexture.NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663904);
			RenderTexture.NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663905);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663906);
			RenderTexture.NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663907);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663908);
			RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663909);
			RenderTexture.NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663910);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100663911);
			RenderTexture.get_dimensionDelegateField = IL2CPP.ResolveICall<RenderTexture.get_dimensionDelegate>("UnityEngine.RenderTexture::get_dimension");
			RenderTexture.set_dimensionDelegateField = IL2CPP.ResolveICall<RenderTexture.set_dimensionDelegate>("UnityEngine.RenderTexture::set_dimension");
			RenderTexture.get_graphicsFormatDelegateField = IL2CPP.ResolveICall<RenderTexture.get_graphicsFormatDelegate>("UnityEngine.RenderTexture::get_graphicsFormat");
			RenderTexture.get_useMipMapDelegateField = IL2CPP.ResolveICall<RenderTexture.get_useMipMapDelegate>("UnityEngine.RenderTexture::get_useMipMap");
			RenderTexture.set_useMipMapDelegateField = IL2CPP.ResolveICall<RenderTexture.set_useMipMapDelegate>("UnityEngine.RenderTexture::set_useMipMap");
			RenderTexture.get_sRGBDelegateField = IL2CPP.ResolveICall<RenderTexture.get_sRGBDelegate>("UnityEngine.RenderTexture::get_sRGB");
			RenderTexture.get_vrUsageDelegateField = IL2CPP.ResolveICall<RenderTexture.get_vrUsageDelegate>("UnityEngine.RenderTexture::get_vrUsage");
			RenderTexture.set_vrUsageDelegateField = IL2CPP.ResolveICall<RenderTexture.set_vrUsageDelegate>("UnityEngine.RenderTexture::set_vrUsage");
			RenderTexture.get_memorylessModeDelegateField = IL2CPP.ResolveICall<RenderTexture.get_memorylessModeDelegate>("UnityEngine.RenderTexture::get_memorylessMode");
			RenderTexture.set_memorylessModeDelegateField = IL2CPP.ResolveICall<RenderTexture.set_memorylessModeDelegate>("UnityEngine.RenderTexture::set_memorylessMode");
			RenderTexture.get_stencilFormatDelegateField = IL2CPP.ResolveICall<RenderTexture.get_stencilFormatDelegate>("UnityEngine.RenderTexture::get_stencilFormat");
			RenderTexture.set_stencilFormatDelegateField = IL2CPP.ResolveICall<RenderTexture.set_stencilFormatDelegate>("UnityEngine.RenderTexture::set_stencilFormat");
			RenderTexture.get_autoGenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.get_autoGenerateMipsDelegate>("UnityEngine.RenderTexture::get_autoGenerateMips");
			RenderTexture.set_autoGenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.set_autoGenerateMipsDelegate>("UnityEngine.RenderTexture::set_autoGenerateMips");
			RenderTexture.get_volumeDepthDelegateField = IL2CPP.ResolveICall<RenderTexture.get_volumeDepthDelegate>("UnityEngine.RenderTexture::get_volumeDepth");
			RenderTexture.set_volumeDepthDelegateField = IL2CPP.ResolveICall<RenderTexture.set_volumeDepthDelegate>("UnityEngine.RenderTexture::set_volumeDepth");
			RenderTexture.get_antiAliasingDelegateField = IL2CPP.ResolveICall<RenderTexture.get_antiAliasingDelegate>("UnityEngine.RenderTexture::get_antiAliasing");
			RenderTexture.set_antiAliasingDelegateField = IL2CPP.ResolveICall<RenderTexture.set_antiAliasingDelegate>("UnityEngine.RenderTexture::set_antiAliasing");
			RenderTexture.get_bindTextureMSDelegateField = IL2CPP.ResolveICall<RenderTexture.get_bindTextureMSDelegate>("UnityEngine.RenderTexture::get_bindTextureMS");
			RenderTexture.set_bindTextureMSDelegateField = IL2CPP.ResolveICall<RenderTexture.set_bindTextureMSDelegate>("UnityEngine.RenderTexture::set_bindTextureMS");
			RenderTexture.get_enableRandomWriteDelegateField = IL2CPP.ResolveICall<RenderTexture.get_enableRandomWriteDelegate>("UnityEngine.RenderTexture::get_enableRandomWrite");
			RenderTexture.set_enableRandomWriteDelegateField = IL2CPP.ResolveICall<RenderTexture.set_enableRandomWriteDelegate>("UnityEngine.RenderTexture::set_enableRandomWrite");
			RenderTexture.get_useDynamicScaleDelegateField = IL2CPP.ResolveICall<RenderTexture.get_useDynamicScaleDelegate>("UnityEngine.RenderTexture::get_useDynamicScale");
			RenderTexture.set_useDynamicScaleDelegateField = IL2CPP.ResolveICall<RenderTexture.set_useDynamicScaleDelegate>("UnityEngine.RenderTexture::set_useDynamicScale");
			RenderTexture.GetIsPowerOfTwoDelegateField = IL2CPP.ResolveICall<RenderTexture.GetIsPowerOfTwoDelegate>("UnityEngine.RenderTexture::GetIsPowerOfTwo");
			RenderTexture.GetActiveDelegateField = IL2CPP.ResolveICall<RenderTexture.GetActiveDelegate>("UnityEngine.RenderTexture::GetActive");
			RenderTexture.GetNativeDepthBufferPtrDelegateField = IL2CPP.ResolveICall<RenderTexture.GetNativeDepthBufferPtrDelegate>("UnityEngine.RenderTexture::GetNativeDepthBufferPtr");
			RenderTexture.DiscardContentsDelegateField = IL2CPP.ResolveICall<RenderTexture.DiscardContentsDelegate>("UnityEngine.RenderTexture::DiscardContents");
			RenderTexture.MarkRestoreExpectedDelegateField = IL2CPP.ResolveICall<RenderTexture.MarkRestoreExpectedDelegate>("UnityEngine.RenderTexture::MarkRestoreExpected");
			RenderTexture.ResolveAADelegateField = IL2CPP.ResolveICall<RenderTexture.ResolveAADelegate>("UnityEngine.RenderTexture::ResolveAA");
			RenderTexture.ResolveAAToDelegateField = IL2CPP.ResolveICall<RenderTexture.ResolveAAToDelegate>("UnityEngine.RenderTexture::ResolveAATo");
			RenderTexture.SetGlobalShaderPropertyDelegateField = IL2CPP.ResolveICall<RenderTexture.SetGlobalShaderPropertyDelegate>("UnityEngine.RenderTexture::SetGlobalShaderProperty");
			RenderTexture.CreateDelegateField = IL2CPP.ResolveICall<RenderTexture.CreateDelegate>("UnityEngine.RenderTexture::Create");
			RenderTexture.ReleaseDelegateField = IL2CPP.ResolveICall<RenderTexture.ReleaseDelegate>("UnityEngine.RenderTexture::Release");
			RenderTexture.IsCreatedDelegateField = IL2CPP.ResolveICall<RenderTexture.IsCreatedDelegate>("UnityEngine.RenderTexture::IsCreated");
			RenderTexture.GenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.GenerateMipsDelegate>("UnityEngine.RenderTexture::GenerateMips");
			RenderTexture.ConvertToEquirectDelegateField = IL2CPP.ResolveICall<RenderTexture.ConvertToEquirectDelegate>("UnityEngine.RenderTexture::ConvertToEquirect");
			RenderTexture.SupportsStencilDelegateField = IL2CPP.ResolveICall<RenderTexture.SupportsStencilDelegate>("UnityEngine.RenderTexture::SupportsStencil");
			RenderTexture.ReleaseTemporaryDelegateField = IL2CPP.ResolveICall<RenderTexture.ReleaseTemporaryDelegate>("UnityEngine.RenderTexture::ReleaseTemporary");
			RenderTexture.get_depthDelegateField = IL2CPP.ResolveICall<RenderTexture.get_depthDelegate>("UnityEngine.RenderTexture::get_depth");
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x000322DC File Offset: 0x000304DC
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00032324 File Offset: 0x00030524
		public unsafe override int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64510, XrefRangeEnd = 64512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64512, XrefRangeEnd = 64514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00032370 File Offset: 0x00030570
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x000323B8 File Offset: 0x000305B8
		public unsafe override int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64514, XrefRangeEnd = 64516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64516, XrefRangeEnd = 64518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x000088FD File Offset: 0x00006AFD
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00032404 File Offset: 0x00030604
		public new unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			get
			{
				return RenderTexture.get_graphicsFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64518, XrefRangeEnd = 64520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00032444 File Offset: 0x00030644
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 64522, RefRangeEnd = 64526, XrefRangeStart = 64520, XrefRangeEnd = 64522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetActive(RenderTexture rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00032D88 File Offset: 0x00030F88
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0003247C File Offset: 0x0003067C
		public unsafe static RenderTexture active
		{
			get
			{
				return RenderTexture.GetActive();
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 64522, RefRangeEnd = 64526, XrefRangeStart = 64522, XrefRangeEnd = 64526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000324B4 File Offset: 0x000306B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64526, XrefRangeEnd = 64528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSRGBReadWrite(bool srgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srgb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000324F4 File Offset: 0x000306F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64528, XrefRangeEnd = 64530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(RenderTexture rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0003252C File Offset: 0x0003072C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64530, XrefRangeEnd = 64532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0003256C File Offset: 0x0003076C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64532, XrefRangeEnd = 64534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor GetDescriptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000325A8 File Offset: 0x000307A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64534, XrefRangeEnd = 64536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00008BDE File Offset: 0x00006DDE
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x000325E8 File Offset: 0x000307E8
		public unsafe int depth
		{
			get
			{
				return RenderTexture.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64536, XrefRangeEnd = 64538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_depth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00032628 File Offset: 0x00030828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64538, XrefRangeEnd = 64545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00032664 File Offset: 0x00030864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64545, XrefRangeEnd = 64557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(RenderTextureDescriptor desc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000326AC File Offset: 0x000308AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64557, XrefRangeEnd = 64577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(RenderTexture textureToCopy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureToCopy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000326F8 File Offset: 0x000308F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64577, XrefRangeEnd = 64580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0003276C File Offset: 0x0003096C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 64599, RefRangeEnd = 64603, XrefRangeStart = 64580, XrefRangeEnd = 64599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000327E0 File Offset: 0x000309E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64627, RefRangeEnd = 64628, XrefRangeStart = 64603, XrefRangeEnd = 64627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00032860 File Offset: 0x00030A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64628, XrefRangeEnd = 64630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000328E0 File Offset: 0x00030AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64630, XrefRangeEnd = 64632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00032954 File Offset: 0x00030B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64634, RefRangeEnd = 64635, XrefRangeStart = 64632, XrefRangeEnd = 64634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000329B8 File Offset: 0x00030BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64635, XrefRangeEnd = 64637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00032A38 File Offset: 0x00030C38
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00032A74 File Offset: 0x00030C74
		public unsafe RenderTextureDescriptor descriptor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64637, XrefRangeEnd = 64639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64639, XrefRangeEnd = 64642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_descriptor_Public_set_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00032AB4 File Offset: 0x00030CB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 64647, RefRangeEnd = 64654, XrefRangeStart = 64642, XrefRangeEnd = 64647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00032AE8 File Offset: 0x00030CE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 64671, RefRangeEnd = 64676, XrefRangeStart = 64654, XrefRangeEnd = 64671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTextureFormat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00032B34 File Offset: 0x00030D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64676, XrefRangeEnd = 64679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00032B74 File Offset: 0x00030D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64679, XrefRangeEnd = 64688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00032C18 File Offset: 0x00030E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64697, RefRangeEnd = 64698, XrefRangeStart = 64688, XrefRangeEnd = 64697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00032C68 File Offset: 0x00030E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64698, XrefRangeEnd = 64700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00032CA8 File Offset: 0x00030EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64700, XrefRangeEnd = 64702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDescriptor_Injected(out RenderTextureDescriptor ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00032CE8 File Offset: 0x00030EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64702, XrefRangeEnd = 64704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000088CF File Offset: 0x00006ACF
		public RenderTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x000088D8 File Offset: 0x00006AD8
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x000088EA File Offset: 0x00006AEA
		public override UnityEngine.Rendering.TextureDimension dimension
		{
			get
			{
				return RenderTexture.get_dimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_dimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0000890F File Offset: 0x00006B0F
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x00008921 File Offset: 0x00006B21
		public bool useMipMap
		{
			get
			{
				return RenderTexture.get_useMipMapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_useMipMapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00008934 File Offset: 0x00006B34
		public bool sRGB
		{
			get
			{
				return RenderTexture.get_sRGBDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00008946 File Offset: 0x00006B46
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00008958 File Offset: 0x00006B58
		public VRTextureUsage vrUsage
		{
			get
			{
				return RenderTexture.get_vrUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_vrUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0000896B File Offset: 0x00006B6B
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0000897D File Offset: 0x00006B7D
		public RenderTextureMemoryless memorylessMode
		{
			get
			{
				return RenderTexture.get_memorylessModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_memorylessModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00032D28 File Offset: 0x00030F28
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x00008990 File Offset: 0x00006B90
		public RenderTextureFormat format
		{
			get
			{
				return UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetRenderTextureFormat(this.graphicsFormat);
			}
			set
			{
				this.graphicsFormat = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(value, this.sRGB);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x000089A6 File Offset: 0x00006BA6
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x000089B8 File Offset: 0x00006BB8
		public UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		{
			get
			{
				return RenderTexture.get_stencilFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_stencilFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x000089CB File Offset: 0x00006BCB
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x000089DD File Offset: 0x00006BDD
		public bool autoGenerateMips
		{
			get
			{
				return RenderTexture.get_autoGenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_autoGenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x000089F0 File Offset: 0x00006BF0
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00008A02 File Offset: 0x00006C02
		public int volumeDepth
		{
			get
			{
				return RenderTexture.get_volumeDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_volumeDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00008A15 File Offset: 0x00006C15
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00008A27 File Offset: 0x00006C27
		public int antiAliasing
		{
			get
			{
				return RenderTexture.get_antiAliasingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_antiAliasingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00008A3A File Offset: 0x00006C3A
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00008A4C File Offset: 0x00006C4C
		public bool bindTextureMS
		{
			get
			{
				return RenderTexture.get_bindTextureMSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_bindTextureMSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00008A5F File Offset: 0x00006C5F
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00008A71 File Offset: 0x00006C71
		public bool enableRandomWrite
		{
			get
			{
				return RenderTexture.get_enableRandomWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_enableRandomWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00008A84 File Offset: 0x00006C84
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00008A96 File Offset: 0x00006C96
		public bool useDynamicScale
		{
			get
			{
				return RenderTexture.get_useDynamicScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_useDynamicScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00008AA9 File Offset: 0x00006CA9
		public bool GetIsPowerOfTwo()
		{
			return RenderTexture.GetIsPowerOfTwoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00032D48 File Offset: 0x00030F48
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00008ABB File Offset: 0x00006CBB
		public bool isPowerOfTwo
		{
			get
			{
				return this.GetIsPowerOfTwo();
			}
			set
			{
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00032D60 File Offset: 0x00030F60
		public static RenderTexture GetActive()
		{
			IntPtr intPtr = RenderTexture.GetActiveDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00008ABE File Offset: 0x00006CBE
		public IntPtr GetNativeDepthBufferPtr()
		{
			return RenderTexture.GetNativeDepthBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00008AD0 File Offset: 0x00006CD0
		public void DiscardContents(bool discardColor, bool discardDepth)
		{
			RenderTexture.DiscardContentsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), discardColor, discardDepth);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00008AE4 File Offset: 0x00006CE4
		public void MarkRestoreExpected()
		{
			RenderTexture.MarkRestoreExpectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00008AF6 File Offset: 0x00006CF6
		public void DiscardContents()
		{
			this.DiscardContents(true, true);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00008B02 File Offset: 0x00006D02
		public void ResolveAA()
		{
			RenderTexture.ResolveAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00008B14 File Offset: 0x00006D14
		public void ResolveAATo(RenderTexture rt)
		{
			RenderTexture.ResolveAAToDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00008B2C File Offset: 0x00006D2C
		public void ResolveAntiAliasedSurface()
		{
			this.ResolveAA();
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00008B36 File Offset: 0x00006D36
		public void ResolveAntiAliasedSurface(RenderTexture target)
		{
			this.ResolveAATo(target);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00008B41 File Offset: 0x00006D41
		public void SetGlobalShaderProperty(string propertyName)
		{
			RenderTexture.SetGlobalShaderPropertyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(propertyName));
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00008B59 File Offset: 0x00006D59
		public bool Create()
		{
			return RenderTexture.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00008B6B File Offset: 0x00006D6B
		public void Release()
		{
			RenderTexture.ReleaseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00008B7D File Offset: 0x00006D7D
		public bool IsCreated()
		{
			return RenderTexture.IsCreatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00008B8F File Offset: 0x00006D8F
		public void GenerateMips()
		{
			RenderTexture.GenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00008BA1 File Offset: 0x00006DA1
		public void ConvertToEquirect(RenderTexture equirect, [Optional] Camera.MonoOrStereoscopicEye eye)
		{
			RenderTexture.ConvertToEquirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(equirect), eye);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00008BBA File Offset: 0x00006DBA
		public static bool SupportsStencil(RenderTexture rt)
		{
			return RenderTexture.SupportsStencilDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00008BCC File Offset: 0x00006DCC
		public static void ReleaseTemporary(RenderTexture temp)
		{
			RenderTexture.ReleaseTemporaryDelegateField(IL2CPP.Il2CppObjectBaseToPtr(temp));
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00032DA0 File Offset: 0x00030FA0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00032DC4 File Offset: 0x00030FC4
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, false);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00032DE8 File Offset: 0x00030FE8
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, antiAliasing, memorylessMode, VRTextureUsage.None, false);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00032E0C File Offset: 0x0003100C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, antiAliasing, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00032E2C File Offset: 0x0003102C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, 1, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00032E4C File Offset: 0x0003104C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), antiAliasing, memorylessMode, vrUsage, useDynamicScale);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00032E78 File Offset: 0x00031078
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, readWrite), antiAliasing, memorylessMode, vrUsage, false);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00032EA4 File Offset: 0x000310A4
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, readWrite), antiAliasing, memorylessMode, VRTextureUsage.None, false);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00032ECC File Offset: 0x000310CC
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, readWrite), antiAliasing, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00032EF4 File Offset: 0x000310F4
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, readWrite), 1, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00032F1C File Offset: 0x0003111C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, RenderTextureReadWrite.Default), 1, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00032F44 File Offset: 0x00031144
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(RenderTextureFormat.Default, RenderTextureReadWrite.Default), 1, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00032F6C File Offset: 0x0003116C
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00008BF0 File Offset: 0x00006DF0
		public bool isCubemap
		{
			get
			{
				return this.dimension == UnityEngine.Rendering.TextureDimension.Cube;
			}
			set
			{
				this.dimension = (value ? UnityEngine.Rendering.TextureDimension.Cube : UnityEngine.Rendering.TextureDimension.Tex2D);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00032F88 File Offset: 0x00031188
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00008C01 File Offset: 0x00006E01
		public bool isVolume
		{
			get
			{
				return this.dimension == UnityEngine.Rendering.TextureDimension.Tex3D;
			}
			set
			{
				this.dimension = (value ? UnityEngine.Rendering.TextureDimension.Tex3D : UnityEngine.Rendering.TextureDimension.Tex2D);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00032FA4 File Offset: 0x000311A4
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00008C12 File Offset: 0x00006E12
		public static bool enabled
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00032FB8 File Offset: 0x000311B8
		public Vector2 GetTexelOffset()
		{
			return Vector2.zero;
		}

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_set_depth_Public_set_Void_Int32_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_set_descriptor_Public_set_Void_RenderTextureDescriptor_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0;

		// Token: 0x04000801 RID: 2049
		private static readonly RenderTexture.get_dimensionDelegate get_dimensionDelegateField;

		// Token: 0x04000802 RID: 2050
		private static readonly RenderTexture.set_dimensionDelegate set_dimensionDelegateField;

		// Token: 0x04000803 RID: 2051
		private static readonly RenderTexture.get_graphicsFormatDelegate get_graphicsFormatDelegateField;

		// Token: 0x04000804 RID: 2052
		private static readonly RenderTexture.get_useMipMapDelegate get_useMipMapDelegateField;

		// Token: 0x04000805 RID: 2053
		private static readonly RenderTexture.set_useMipMapDelegate set_useMipMapDelegateField;

		// Token: 0x04000806 RID: 2054
		private static readonly RenderTexture.get_sRGBDelegate get_sRGBDelegateField;

		// Token: 0x04000807 RID: 2055
		private static readonly RenderTexture.get_vrUsageDelegate get_vrUsageDelegateField;

		// Token: 0x04000808 RID: 2056
		private static readonly RenderTexture.set_vrUsageDelegate set_vrUsageDelegateField;

		// Token: 0x04000809 RID: 2057
		private static readonly RenderTexture.get_memorylessModeDelegate get_memorylessModeDelegateField;

		// Token: 0x0400080A RID: 2058
		private static readonly RenderTexture.set_memorylessModeDelegate set_memorylessModeDelegateField;

		// Token: 0x0400080B RID: 2059
		private static readonly RenderTexture.get_stencilFormatDelegate get_stencilFormatDelegateField;

		// Token: 0x0400080C RID: 2060
		private static readonly RenderTexture.set_stencilFormatDelegate set_stencilFormatDelegateField;

		// Token: 0x0400080D RID: 2061
		private static readonly RenderTexture.get_autoGenerateMipsDelegate get_autoGenerateMipsDelegateField;

		// Token: 0x0400080E RID: 2062
		private static readonly RenderTexture.set_autoGenerateMipsDelegate set_autoGenerateMipsDelegateField;

		// Token: 0x0400080F RID: 2063
		private static readonly RenderTexture.get_volumeDepthDelegate get_volumeDepthDelegateField;

		// Token: 0x04000810 RID: 2064
		private static readonly RenderTexture.set_volumeDepthDelegate set_volumeDepthDelegateField;

		// Token: 0x04000811 RID: 2065
		private static readonly RenderTexture.get_antiAliasingDelegate get_antiAliasingDelegateField;

		// Token: 0x04000812 RID: 2066
		private static readonly RenderTexture.set_antiAliasingDelegate set_antiAliasingDelegateField;

		// Token: 0x04000813 RID: 2067
		private static readonly RenderTexture.get_bindTextureMSDelegate get_bindTextureMSDelegateField;

		// Token: 0x04000814 RID: 2068
		private static readonly RenderTexture.set_bindTextureMSDelegate set_bindTextureMSDelegateField;

		// Token: 0x04000815 RID: 2069
		private static readonly RenderTexture.get_enableRandomWriteDelegate get_enableRandomWriteDelegateField;

		// Token: 0x04000816 RID: 2070
		private static readonly RenderTexture.set_enableRandomWriteDelegate set_enableRandomWriteDelegateField;

		// Token: 0x04000817 RID: 2071
		private static readonly RenderTexture.get_useDynamicScaleDelegate get_useDynamicScaleDelegateField;

		// Token: 0x04000818 RID: 2072
		private static readonly RenderTexture.set_useDynamicScaleDelegate set_useDynamicScaleDelegateField;

		// Token: 0x04000819 RID: 2073
		private static readonly RenderTexture.GetIsPowerOfTwoDelegate GetIsPowerOfTwoDelegateField;

		// Token: 0x0400081A RID: 2074
		private static readonly RenderTexture.GetActiveDelegate GetActiveDelegateField;

		// Token: 0x0400081B RID: 2075
		private static readonly RenderTexture.GetNativeDepthBufferPtrDelegate GetNativeDepthBufferPtrDelegateField;

		// Token: 0x0400081C RID: 2076
		private static readonly RenderTexture.DiscardContentsDelegate DiscardContentsDelegateField;

		// Token: 0x0400081D RID: 2077
		private static readonly RenderTexture.MarkRestoreExpectedDelegate MarkRestoreExpectedDelegateField;

		// Token: 0x0400081E RID: 2078
		private static readonly RenderTexture.ResolveAADelegate ResolveAADelegateField;

		// Token: 0x0400081F RID: 2079
		private static readonly RenderTexture.ResolveAAToDelegate ResolveAAToDelegateField;

		// Token: 0x04000820 RID: 2080
		private static readonly RenderTexture.SetGlobalShaderPropertyDelegate SetGlobalShaderPropertyDelegateField;

		// Token: 0x04000821 RID: 2081
		private static readonly RenderTexture.CreateDelegate CreateDelegateField;

		// Token: 0x04000822 RID: 2082
		private static readonly RenderTexture.ReleaseDelegate ReleaseDelegateField;

		// Token: 0x04000823 RID: 2083
		private static readonly RenderTexture.IsCreatedDelegate IsCreatedDelegateField;

		// Token: 0x04000824 RID: 2084
		private static readonly RenderTexture.GenerateMipsDelegate GenerateMipsDelegateField;

		// Token: 0x04000825 RID: 2085
		private static readonly RenderTexture.ConvertToEquirectDelegate ConvertToEquirectDelegateField;

		// Token: 0x04000826 RID: 2086
		private static readonly RenderTexture.SupportsStencilDelegate SupportsStencilDelegateField;

		// Token: 0x04000827 RID: 2087
		private static readonly RenderTexture.ReleaseTemporaryDelegate ReleaseTemporaryDelegateField;

		// Token: 0x04000828 RID: 2088
		private static readonly RenderTexture.get_depthDelegate get_depthDelegateField;

		// Token: 0x020006EE RID: 1774
		// (Invoke) Token: 0x06002B9F RID: 11167
		private delegate UnityEngine.Rendering.TextureDimension get_dimensionDelegate(IntPtr @this);

		// Token: 0x020006EF RID: 1775
		// (Invoke) Token: 0x06002BA1 RID: 11169
		private delegate void set_dimensionDelegate(IntPtr @this, UnityEngine.Rendering.TextureDimension value);

		// Token: 0x020006F0 RID: 1776
		// (Invoke) Token: 0x06002BA3 RID: 11171
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormatDelegate(IntPtr @this);

		// Token: 0x020006F1 RID: 1777
		// (Invoke) Token: 0x06002BA5 RID: 11173
		private delegate bool get_useMipMapDelegate(IntPtr @this);

		// Token: 0x020006F2 RID: 1778
		// (Invoke) Token: 0x06002BA7 RID: 11175
		private delegate void set_useMipMapDelegate(IntPtr @this, bool value);

		// Token: 0x020006F3 RID: 1779
		// (Invoke) Token: 0x06002BA9 RID: 11177
		private delegate bool get_sRGBDelegate(IntPtr @this);

		// Token: 0x020006F4 RID: 1780
		// (Invoke) Token: 0x06002BAB RID: 11179
		private delegate VRTextureUsage get_vrUsageDelegate(IntPtr @this);

		// Token: 0x020006F5 RID: 1781
		// (Invoke) Token: 0x06002BAD RID: 11181
		private delegate void set_vrUsageDelegate(IntPtr @this, VRTextureUsage value);

		// Token: 0x020006F6 RID: 1782
		// (Invoke) Token: 0x06002BAF RID: 11183
		private delegate RenderTextureMemoryless get_memorylessModeDelegate(IntPtr @this);

		// Token: 0x020006F7 RID: 1783
		// (Invoke) Token: 0x06002BB1 RID: 11185
		private delegate void set_memorylessModeDelegate(IntPtr @this, RenderTextureMemoryless value);

		// Token: 0x020006F8 RID: 1784
		// (Invoke) Token: 0x06002BB3 RID: 11187
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat get_stencilFormatDelegate(IntPtr @this);

		// Token: 0x020006F9 RID: 1785
		// (Invoke) Token: 0x06002BB5 RID: 11189
		private delegate void set_stencilFormatDelegate(IntPtr @this, UnityEngine.Experimental.Rendering.GraphicsFormat value);

		// Token: 0x020006FA RID: 1786
		// (Invoke) Token: 0x06002BB7 RID: 11191
		private delegate bool get_autoGenerateMipsDelegate(IntPtr @this);

		// Token: 0x020006FB RID: 1787
		// (Invoke) Token: 0x06002BB9 RID: 11193
		private delegate void set_autoGenerateMipsDelegate(IntPtr @this, bool value);

		// Token: 0x020006FC RID: 1788
		// (Invoke) Token: 0x06002BBB RID: 11195
		private delegate int get_volumeDepthDelegate(IntPtr @this);

		// Token: 0x020006FD RID: 1789
		// (Invoke) Token: 0x06002BBD RID: 11197
		private delegate void set_volumeDepthDelegate(IntPtr @this, int value);

		// Token: 0x020006FE RID: 1790
		// (Invoke) Token: 0x06002BBF RID: 11199
		private delegate int get_antiAliasingDelegate(IntPtr @this);

		// Token: 0x020006FF RID: 1791
		// (Invoke) Token: 0x06002BC1 RID: 11201
		private delegate void set_antiAliasingDelegate(IntPtr @this, int value);

		// Token: 0x02000700 RID: 1792
		// (Invoke) Token: 0x06002BC3 RID: 11203
		private delegate bool get_bindTextureMSDelegate(IntPtr @this);

		// Token: 0x02000701 RID: 1793
		// (Invoke) Token: 0x06002BC5 RID: 11205
		private delegate void set_bindTextureMSDelegate(IntPtr @this, bool value);

		// Token: 0x02000702 RID: 1794
		// (Invoke) Token: 0x06002BC7 RID: 11207
		private delegate bool get_enableRandomWriteDelegate(IntPtr @this);

		// Token: 0x02000703 RID: 1795
		// (Invoke) Token: 0x06002BC9 RID: 11209
		private delegate void set_enableRandomWriteDelegate(IntPtr @this, bool value);

		// Token: 0x02000704 RID: 1796
		// (Invoke) Token: 0x06002BCB RID: 11211
		private delegate bool get_useDynamicScaleDelegate(IntPtr @this);

		// Token: 0x02000705 RID: 1797
		// (Invoke) Token: 0x06002BCD RID: 11213
		private delegate void set_useDynamicScaleDelegate(IntPtr @this, bool value);

		// Token: 0x02000706 RID: 1798
		// (Invoke) Token: 0x06002BCF RID: 11215
		private delegate bool GetIsPowerOfTwoDelegate(IntPtr @this);

		// Token: 0x02000707 RID: 1799
		// (Invoke) Token: 0x06002BD1 RID: 11217
		private delegate IntPtr GetActiveDelegate();

		// Token: 0x02000708 RID: 1800
		// (Invoke) Token: 0x06002BD3 RID: 11219
		private delegate IntPtr GetNativeDepthBufferPtrDelegate(IntPtr @this);

		// Token: 0x02000709 RID: 1801
		// (Invoke) Token: 0x06002BD5 RID: 11221
		private delegate void DiscardContentsDelegate(IntPtr @this, bool discardColor, bool discardDepth);

		// Token: 0x0200070A RID: 1802
		// (Invoke) Token: 0x06002BD7 RID: 11223
		private delegate void MarkRestoreExpectedDelegate(IntPtr @this);

		// Token: 0x0200070B RID: 1803
		// (Invoke) Token: 0x06002BD9 RID: 11225
		private delegate void ResolveAADelegate(IntPtr @this);

		// Token: 0x0200070C RID: 1804
		// (Invoke) Token: 0x06002BDB RID: 11227
		private delegate void ResolveAAToDelegate(IntPtr @this, IntPtr rt);

		// Token: 0x0200070D RID: 1805
		// (Invoke) Token: 0x06002BDD RID: 11229
		private delegate void SetGlobalShaderPropertyDelegate(IntPtr @this, IntPtr propertyName);

		// Token: 0x0200070E RID: 1806
		// (Invoke) Token: 0x06002BDF RID: 11231
		private delegate bool CreateDelegate(IntPtr @this);

		// Token: 0x0200070F RID: 1807
		// (Invoke) Token: 0x06002BE1 RID: 11233
		private delegate void ReleaseDelegate(IntPtr @this);

		// Token: 0x02000710 RID: 1808
		// (Invoke) Token: 0x06002BE3 RID: 11235
		private delegate bool IsCreatedDelegate(IntPtr @this);

		// Token: 0x02000711 RID: 1809
		// (Invoke) Token: 0x06002BE5 RID: 11237
		private delegate void GenerateMipsDelegate(IntPtr @this);

		// Token: 0x02000712 RID: 1810
		// (Invoke) Token: 0x06002BE7 RID: 11239
		private delegate void ConvertToEquirectDelegate(IntPtr @this, IntPtr equirect, Camera.MonoOrStereoscopicEye eye);

		// Token: 0x02000713 RID: 1811
		// (Invoke) Token: 0x06002BE9 RID: 11241
		private delegate bool SupportsStencilDelegate(IntPtr rt);

		// Token: 0x02000714 RID: 1812
		// (Invoke) Token: 0x06002BEB RID: 11243
		private delegate void ReleaseTemporaryDelegate(IntPtr temp);

		// Token: 0x02000715 RID: 1813
		// (Invoke) Token: 0x06002BED RID: 11245
		private delegate int get_depthDelegate(IntPtr @this);
	}
}
