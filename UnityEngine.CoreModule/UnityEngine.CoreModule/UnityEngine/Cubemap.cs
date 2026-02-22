using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x02000071 RID: 113
	public sealed class Cubemap : Texture
	{
		// Token: 0x06000AC8 RID: 2760 RVA: 0x0002F810 File Offset: 0x0002DA10
		// Note: this type is marked as 'beforefieldinit'.
		static Cubemap()
		{
			Il2CppClassPointerStore<Cubemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cubemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cubemap>.NativeClassPtr);
			Cubemap.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663837);
			Cubemap.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663838);
			Cubemap.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663839);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663840);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663841);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663842);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663843);
			Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663844);
			Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663845);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663846);
			Cubemap.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100663847);
			Cubemap.get_formatDelegateField = IL2CPP.ResolveICall<Cubemap.get_formatDelegate>("UnityEngine.Cubemap::get_format");
			Cubemap.ApplyImplDelegateField = IL2CPP.ResolveICall<Cubemap.ApplyImplDelegate>("UnityEngine.Cubemap::ApplyImpl");
			Cubemap.UpdateExternalTextureDelegateField = IL2CPP.ResolveICall<Cubemap.UpdateExternalTextureDelegate>("UnityEngine.Cubemap::UpdateExternalTexture");
			Cubemap.SmoothEdgesDelegateField = IL2CPP.ResolveICall<Cubemap.SmoothEdgesDelegate>("UnityEngine.Cubemap::SmoothEdges");
			Cubemap.GetPixelsDelegateField = IL2CPP.ResolveICall<Cubemap.GetPixelsDelegate>("UnityEngine.Cubemap::GetPixels");
			Cubemap.SetPixelsDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelsDelegate>("UnityEngine.Cubemap::SetPixels");
			Cubemap.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelDataImplArrayDelegate>("UnityEngine.Cubemap::SetPixelDataImplArray");
			Cubemap.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelDataImplDelegate>("UnityEngine.Cubemap::SetPixelDataImpl");
			Cubemap.GetWritableImageDataDelegateField = IL2CPP.ResolveICall<Cubemap.GetWritableImageDataDelegate>("UnityEngine.Cubemap::GetWritableImageData");
			Cubemap.get_isPreProcessedDelegateField = IL2CPP.ResolveICall<Cubemap.get_isPreProcessedDelegate>("UnityEngine.Cubemap::get_isPreProcessed");
			Cubemap.get_streamingMipmapsDelegateField = IL2CPP.ResolveICall<Cubemap.get_streamingMipmapsDelegate>("UnityEngine.Cubemap::get_streamingMipmaps");
			Cubemap.get_streamingMipmapsPriorityDelegateField = IL2CPP.ResolveICall<Cubemap.get_streamingMipmapsPriorityDelegate>("UnityEngine.Cubemap::get_streamingMipmapsPriority");
			Cubemap.get_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_requestedMipmapLevelDelegate>("UnityEngine.Cubemap::get_requestedMipmapLevel");
			Cubemap.set_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.set_requestedMipmapLevelDelegate>("UnityEngine.Cubemap::set_requestedMipmapLevel");
			Cubemap.get_loadAllMipsDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadAllMipsDelegate>("UnityEngine.Cubemap::get_loadAllMips");
			Cubemap.set_loadAllMipsDelegateField = IL2CPP.ResolveICall<Cubemap.set_loadAllMipsDelegate>("UnityEngine.Cubemap::set_loadAllMips");
			Cubemap.get_desiredMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_desiredMipmapLevelDelegate>("UnityEngine.Cubemap::get_desiredMipmapLevel");
			Cubemap.get_loadingMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadingMipmapLevelDelegate>("UnityEngine.Cubemap::get_loadingMipmapLevel");
			Cubemap.get_loadedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadedMipmapLevelDelegate>("UnityEngine.Cubemap::get_loadedMipmapLevel");
			Cubemap.ClearRequestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.ClearRequestedMipmapLevelDelegate>("UnityEngine.Cubemap::ClearRequestedMipmapLevel");
			Cubemap.IsRequestedMipmapLevelLoadedDelegateField = IL2CPP.ResolveICall<Cubemap.IsRequestedMipmapLevelLoadedDelegate>("UnityEngine.Cubemap::IsRequestedMipmapLevelLoaded");
			Cubemap.SetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelImpl_InjectedDelegate>("UnityEngine.Cubemap::SetPixelImpl_Injected");
			Cubemap.GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.GetPixelImpl_InjectedDelegate>("UnityEngine.Cubemap::GetPixelImpl_Injected");
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0002FA78 File Offset: 0x0002DC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64243, XrefRangeEnd = 64245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0002FB00 File Offset: 0x0002DD00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 64247, RefRangeEnd = 64251, XrefRangeStart = 64245, XrefRangeEnd = 64247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0002FB7C File Offset: 0x0002DD7C
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64251, XrefRangeEnd = 64253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0002FBB8 File Offset: 0x0002DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64253, XrefRangeEnd = 64264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0002FC1C File Offset: 0x0002DE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64264, XrefRangeEnd = 64274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0002FC80 File Offset: 0x0002DE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64274, XrefRangeEnd = 64276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat format, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0002FCE4 File Offset: 0x0002DEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64276, XrefRangeEnd = 64283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0002FD58 File Offset: 0x0002DF58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64291, RefRangeEnd = 64294, XrefRangeStart = 64283, XrefRangeEnd = 64291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0002FDCC File Offset: 0x0002DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64294, XrefRangeEnd = 64296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0002FE40 File Offset: 0x0002E040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64296, XrefRangeEnd = 64298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0002FEA4 File Offset: 0x0002E0A4
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000083B5 File Offset: 0x000065B5
		public Cubemap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000083BE File Offset: 0x000065BE
		public TextureFormat format
		{
			get
			{
				return Cubemap.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000083D0 File Offset: 0x000065D0
		public void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			Cubemap.ApplyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000083E4 File Offset: 0x000065E4
		public void UpdateExternalTexture(IntPtr nativeTexture)
		{
			Cubemap.UpdateExternalTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nativeTexture);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000083F7 File Offset: 0x000065F7
		public void SetPixelImpl(int image, int x, int y, Color color)
		{
			this.SetPixelImpl_Injected(image, x, y, ref color);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0002FED8 File Offset: 0x0002E0D8
		public Color GetPixelImpl(int image, int x, int y)
		{
			Color color;
			this.GetPixelImpl_Injected(image, x, y, out color);
			return color;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00008404 File Offset: 0x00006604
		public void SmoothEdges(int smoothRegionWidthInPixels)
		{
			Cubemap.SmoothEdgesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), smoothRegionWidthInPixels);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00008417 File Offset: 0x00006617
		public void SmoothEdges()
		{
			this.SmoothEdges(1);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		public Il2CppStructArray<Color> GetPixels(CubemapFace face, int miplevel)
		{
			IntPtr intPtr = Cubemap.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), face, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0002FF24 File Offset: 0x0002E124
		public Il2CppStructArray<Color> GetPixels(CubemapFace face)
		{
			return this.GetPixels(face, 0);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00008422 File Offset: 0x00006622
		public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int miplevel)
		{
			Cubemap.SetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), face, miplevel);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0000843C File Offset: 0x0000663C
		public bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Cubemap.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0000845C File Offset: 0x0000665C
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Cubemap.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00008477 File Offset: 0x00006677
		public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face)
		{
			this.SetPixels(colors, face, 0);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00008484 File Offset: 0x00006684
		public IntPtr GetWritableImageData(int frame)
		{
			return Cubemap.GetWritableImageDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), frame);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00008497 File Offset: 0x00006697
		public bool isPreProcessed
		{
			get
			{
				return Cubemap.get_isPreProcessedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000084A9 File Offset: 0x000066A9
		public bool streamingMipmaps
		{
			get
			{
				return Cubemap.get_streamingMipmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x000084BB File Offset: 0x000066BB
		public int streamingMipmapsPriority
		{
			get
			{
				return Cubemap.get_streamingMipmapsPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x000084CD File Offset: 0x000066CD
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x000084DF File Offset: 0x000066DF
		public int requestedMipmapLevel
		{
			get
			{
				return Cubemap.get_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cubemap.set_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x000084F2 File Offset: 0x000066F2
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00008504 File Offset: 0x00006704
		public bool loadAllMips
		{
			get
			{
				return Cubemap.get_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cubemap.set_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00008517 File Offset: 0x00006717
		public int desiredMipmapLevel
		{
			get
			{
				return Cubemap.get_desiredMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00008529 File Offset: 0x00006729
		public int loadingMipmapLevel
		{
			get
			{
				return Cubemap.get_loadingMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0000853B File Offset: 0x0000673B
		public int loadedMipmapLevel
		{
			get
			{
				return Cubemap.get_loadedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0000854D File Offset: 0x0000674D
		public void ClearRequestedMipmapLevel()
		{
			Cubemap.ClearRequestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0000855F File Offset: 0x0000675F
		public bool IsRequestedMipmapLevelLoaded()
		{
			return Cubemap.IsRequestedMipmapLevelLoadedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0002FF40 File Offset: 0x0002E140
		public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex)
		{
			bool flag = nativeTex == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("nativeTex can not be null");
			}
			return new Cubemap(width, format, mipmap, nativeTex);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0002FF78 File Offset: 0x0002E178
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, CubemapFace face, [Optional] int sourceDataStartIndex)
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
			this.SetPixelDataImplArray(data, mipLevel, (int)face, Marshal.SizeOf(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0002FFF4 File Offset: 0x0002E1F4
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, CubemapFace face, [Optional] int sourceDataStartIndex) where T : struct
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
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, (int)face, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00030074 File Offset: 0x0002E274
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			int pixelDataOffset = base.GetPixelDataOffset(base.mipmapCount, (int)face);
			int pixelDataOffset2 = base.GetPixelDataOffset(mipLevel, (int)face);
			int pixelDataSize = base.GetPixelDataSize(mipLevel, (int)face);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			IntPtr intPtr;
			intPtr..ctor(this.GetWritableImageData(0).ToInt64() + (long)(pixelDataOffset * (int)face + pixelDataOffset2));
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, pixelDataSize / num, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x000300F8 File Offset: 0x0002E2F8
		public void SetPixel(CubemapFace face, int x, int y, Color color)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.SetPixelImpl((int)face, x, y, color);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00030128 File Offset: 0x0002E328
		public Color GetPixel(CubemapFace face, int x, int y)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl((int)face, x, y);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00030158 File Offset: 0x0002E358
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.ApplyImpl(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00008571 File Offset: 0x00006771
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0000857D File Offset: 0x0000677D
		public void Apply()
		{
			this.Apply(true, false);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00008589 File Offset: 0x00006789
		public void SetPixelImpl_Injected(int image, int x, int y, ref Color color)
		{
			Cubemap.SetPixelImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), image, x, y, ref color);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000085A0 File Offset: 0x000067A0
		public void GetPixelImpl_Injected(int image, int x, int y, out Color ret)
		{
			Cubemap.GetPixelImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), image, x, y, out ret);
		}

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Boolean_IntPtr_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x04000787 RID: 1927
		private static readonly Cubemap.get_formatDelegate get_formatDelegateField;

		// Token: 0x04000788 RID: 1928
		private static readonly Cubemap.ApplyImplDelegate ApplyImplDelegateField;

		// Token: 0x04000789 RID: 1929
		private static readonly Cubemap.UpdateExternalTextureDelegate UpdateExternalTextureDelegateField;

		// Token: 0x0400078A RID: 1930
		private static readonly Cubemap.SmoothEdgesDelegate SmoothEdgesDelegateField;

		// Token: 0x0400078B RID: 1931
		private static readonly Cubemap.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x0400078C RID: 1932
		private static readonly Cubemap.SetPixelsDelegate SetPixelsDelegateField;

		// Token: 0x0400078D RID: 1933
		private static readonly Cubemap.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x0400078E RID: 1934
		private static readonly Cubemap.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x0400078F RID: 1935
		private static readonly Cubemap.GetWritableImageDataDelegate GetWritableImageDataDelegateField;

		// Token: 0x04000790 RID: 1936
		private static readonly Cubemap.get_isPreProcessedDelegate get_isPreProcessedDelegateField;

		// Token: 0x04000791 RID: 1937
		private static readonly Cubemap.get_streamingMipmapsDelegate get_streamingMipmapsDelegateField;

		// Token: 0x04000792 RID: 1938
		private static readonly Cubemap.get_streamingMipmapsPriorityDelegate get_streamingMipmapsPriorityDelegateField;

		// Token: 0x04000793 RID: 1939
		private static readonly Cubemap.get_requestedMipmapLevelDelegate get_requestedMipmapLevelDelegateField;

		// Token: 0x04000794 RID: 1940
		private static readonly Cubemap.set_requestedMipmapLevelDelegate set_requestedMipmapLevelDelegateField;

		// Token: 0x04000795 RID: 1941
		private static readonly Cubemap.get_loadAllMipsDelegate get_loadAllMipsDelegateField;

		// Token: 0x04000796 RID: 1942
		private static readonly Cubemap.set_loadAllMipsDelegate set_loadAllMipsDelegateField;

		// Token: 0x04000797 RID: 1943
		private static readonly Cubemap.get_desiredMipmapLevelDelegate get_desiredMipmapLevelDelegateField;

		// Token: 0x04000798 RID: 1944
		private static readonly Cubemap.get_loadingMipmapLevelDelegate get_loadingMipmapLevelDelegateField;

		// Token: 0x04000799 RID: 1945
		private static readonly Cubemap.get_loadedMipmapLevelDelegate get_loadedMipmapLevelDelegateField;

		// Token: 0x0400079A RID: 1946
		private static readonly Cubemap.ClearRequestedMipmapLevelDelegate ClearRequestedMipmapLevelDelegateField;

		// Token: 0x0400079B RID: 1947
		private static readonly Cubemap.IsRequestedMipmapLevelLoadedDelegate IsRequestedMipmapLevelLoadedDelegateField;

		// Token: 0x0400079C RID: 1948
		private static readonly Cubemap.SetPixelImpl_InjectedDelegate SetPixelImpl_InjectedDelegateField;

		// Token: 0x0400079D RID: 1949
		private static readonly Cubemap.GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;

		// Token: 0x020006B4 RID: 1716
		// (Invoke) Token: 0x06002B2B RID: 11051
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x020006B5 RID: 1717
		// (Invoke) Token: 0x06002B2D RID: 11053
		private delegate void ApplyImplDelegate(IntPtr @this, bool updateMipmaps, bool makeNoLongerReadable);

		// Token: 0x020006B6 RID: 1718
		// (Invoke) Token: 0x06002B2F RID: 11055
		private delegate void UpdateExternalTextureDelegate(IntPtr @this, IntPtr nativeTexture);

		// Token: 0x020006B7 RID: 1719
		// (Invoke) Token: 0x06002B31 RID: 11057
		private delegate void SmoothEdgesDelegate(IntPtr @this, int smoothRegionWidthInPixels);

		// Token: 0x020006B8 RID: 1720
		// (Invoke) Token: 0x06002B33 RID: 11059
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, CubemapFace face, int miplevel);

		// Token: 0x020006B9 RID: 1721
		// (Invoke) Token: 0x06002B35 RID: 11061
		private delegate void SetPixelsDelegate(IntPtr @this, IntPtr colors, CubemapFace face, int miplevel);

		// Token: 0x020006BA RID: 1722
		// (Invoke) Token: 0x06002B37 RID: 11063
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006BB RID: 1723
		// (Invoke) Token: 0x06002B39 RID: 11065
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006BC RID: 1724
		// (Invoke) Token: 0x06002B3B RID: 11067
		private delegate IntPtr GetWritableImageDataDelegate(IntPtr @this, int frame);

		// Token: 0x020006BD RID: 1725
		// (Invoke) Token: 0x06002B3D RID: 11069
		private delegate bool get_isPreProcessedDelegate(IntPtr @this);

		// Token: 0x020006BE RID: 1726
		// (Invoke) Token: 0x06002B3F RID: 11071
		private delegate bool get_streamingMipmapsDelegate(IntPtr @this);

		// Token: 0x020006BF RID: 1727
		// (Invoke) Token: 0x06002B41 RID: 11073
		private delegate int get_streamingMipmapsPriorityDelegate(IntPtr @this);

		// Token: 0x020006C0 RID: 1728
		// (Invoke) Token: 0x06002B43 RID: 11075
		private delegate int get_requestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006C1 RID: 1729
		// (Invoke) Token: 0x06002B45 RID: 11077
		private delegate void set_requestedMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x020006C2 RID: 1730
		// (Invoke) Token: 0x06002B47 RID: 11079
		private delegate bool get_loadAllMipsDelegate(IntPtr @this);

		// Token: 0x020006C3 RID: 1731
		// (Invoke) Token: 0x06002B49 RID: 11081
		private delegate void set_loadAllMipsDelegate(IntPtr @this, bool value);

		// Token: 0x020006C4 RID: 1732
		// (Invoke) Token: 0x06002B4B RID: 11083
		private delegate int get_desiredMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006C5 RID: 1733
		// (Invoke) Token: 0x06002B4D RID: 11085
		private delegate int get_loadingMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006C6 RID: 1734
		// (Invoke) Token: 0x06002B4F RID: 11087
		private delegate int get_loadedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006C7 RID: 1735
		// (Invoke) Token: 0x06002B51 RID: 11089
		private delegate void ClearRequestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006C8 RID: 1736
		// (Invoke) Token: 0x06002B53 RID: 11091
		private delegate bool IsRequestedMipmapLevelLoadedDelegate(IntPtr @this);

		// Token: 0x020006C9 RID: 1737
		// (Invoke) Token: 0x06002B55 RID: 11093
		private delegate void SetPixelImpl_InjectedDelegate(IntPtr @this, int image, int x, int y, IntPtr color);

		// Token: 0x020006CA RID: 1738
		// (Invoke) Token: 0x06002B57 RID: 11095
		private delegate void GetPixelImpl_InjectedDelegate(IntPtr @this, int image, int x, int y, [Out] IntPtr ret);
	}
}
