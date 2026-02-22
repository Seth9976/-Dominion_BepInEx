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
	// Token: 0x02000072 RID: 114
	public sealed class Texture3D : Texture
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x00030184 File Offset: 0x0002E384
		// Note: this type is marked as 'beforefieldinit'.
		static Texture3D()
		{
			Il2CppClassPointerStore<Texture3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture3D>.NativeClassPtr);
			Texture3D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663848);
			Texture3D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663849);
			Texture3D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663850);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663851);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663852);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663853);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663854);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663855);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663856);
			Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663857);
			Texture3D.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100663858);
			Texture3D.get_depthDelegateField = IL2CPP.ResolveICall<Texture3D.get_depthDelegate>("UnityEngine.Texture3D::get_depth");
			Texture3D.get_formatDelegateField = IL2CPP.ResolveICall<Texture3D.get_formatDelegate>("UnityEngine.Texture3D::get_format");
			Texture3D.UpdateExternalTextureDelegateField = IL2CPP.ResolveICall<Texture3D.UpdateExternalTextureDelegate>("UnityEngine.Texture3D::UpdateExternalTexture");
			Texture3D.ApplyImplDelegateField = IL2CPP.ResolveICall<Texture3D.ApplyImplDelegate>("UnityEngine.Texture3D::ApplyImpl");
			Texture3D.GetPixelsDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixelsDelegate>("UnityEngine.Texture3D::GetPixels");
			Texture3D.GetPixels32DelegateField = IL2CPP.ResolveICall<Texture3D.GetPixels32Delegate>("UnityEngine.Texture3D::GetPixels32");
			Texture3D.SetPixelsDelegateField = IL2CPP.ResolveICall<Texture3D.SetPixelsDelegate>("UnityEngine.Texture3D::SetPixels");
			Texture3D.SetPixels32DelegateField = IL2CPP.ResolveICall<Texture3D.SetPixels32Delegate>("UnityEngine.Texture3D::SetPixels32");
			Texture3D.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture3D.SetPixelDataImplArrayDelegate>("UnityEngine.Texture3D::SetPixelDataImplArray");
			Texture3D.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Texture3D.SetPixelDataImplDelegate>("UnityEngine.Texture3D::SetPixelDataImpl");
			Texture3D.GetImageDataPointerDelegateField = IL2CPP.ResolveICall<Texture3D.GetImageDataPointerDelegate>("UnityEngine.Texture3D::GetImageDataPointer");
			Texture3D.SetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.SetPixelImpl_InjectedDelegate>("UnityEngine.Texture3D::SetPixelImpl_Injected");
			Texture3D.GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixelImpl_InjectedDelegate>("UnityEngine.Texture3D::GetPixelImpl_Injected");
			Texture3D.GetPixelBilinearImpl_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixelBilinearImpl_InjectedDelegate>("UnityEngine.Texture3D::GetPixelBilinearImpl_Injected");
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00030364 File Offset: 0x0002E564
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64298, XrefRangeEnd = 64300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000303A0 File Offset: 0x0002E5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64300, XrefRangeEnd = 64302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00030444 File Offset: 0x0002E644
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 64304, RefRangeEnd = 64311, XrefRangeStart = 64302, XrefRangeEnd = 64304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000304DC File Offset: 0x0002E6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64311, XrefRangeEnd = 64327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0003055C File Offset: 0x0002E75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64327, XrefRangeEnd = 64341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000305DC File Offset: 0x0002E7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64341, XrefRangeEnd = 64351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0003066C File Offset: 0x0002E86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64351, XrefRangeEnd = 64363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000306EC File Offset: 0x0002E8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64363, XrefRangeEnd = 64374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003077C File Offset: 0x0002E97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64374, XrefRangeEnd = 64386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000307FC File Offset: 0x0002E9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64386, XrefRangeEnd = 64397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0003088C File Offset: 0x0002EA8C
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000085B7 File Offset: 0x000067B7
		public Texture3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000085C0 File Offset: 0x000067C0
		public int depth
		{
			get
			{
				return Texture3D.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x000085D2 File Offset: 0x000067D2
		public TextureFormat format
		{
			get
			{
				return Texture3D.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000085E4 File Offset: 0x000067E4
		public void SetPixelImpl(int image, int x, int y, int z, Color color)
		{
			this.SetPixelImpl_Injected(image, x, y, z, ref color);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000308C0 File Offset: 0x0002EAC0
		public Color GetPixelImpl(int image, int x, int y, int z)
		{
			Color color;
			this.GetPixelImpl_Injected(image, x, y, z, out color);
			return color;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000308DC File Offset: 0x0002EADC
		public Color GetPixelBilinearImpl(int image, float u, float v, float w)
		{
			Color color;
			this.GetPixelBilinearImpl_Injected(image, u, v, w, out color);
			return color;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000085F3 File Offset: 0x000067F3
		public void UpdateExternalTexture(IntPtr nativeTex)
		{
			Texture3D.UpdateExternalTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nativeTex);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00008606 File Offset: 0x00006806
		public void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			Texture3D.ApplyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000308F8 File Offset: 0x0002EAF8
		public Il2CppStructArray<Color> GetPixels(int miplevel)
		{
			IntPtr intPtr = Texture3D.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00030928 File Offset: 0x0002EB28
		public Il2CppStructArray<Color> GetPixels()
		{
			return this.GetPixels(0);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00030944 File Offset: 0x0002EB44
		public Il2CppStructArray<Color32> GetPixels32(int miplevel)
		{
			IntPtr intPtr = Texture3D.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00030974 File Offset: 0x0002EB74
		public Il2CppStructArray<Color32> GetPixels32()
		{
			return this.GetPixels32(0);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0000861A File Offset: 0x0000681A
		public void SetPixels(Il2CppStructArray<Color> colors, int miplevel)
		{
			Texture3D.SetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), miplevel);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00008633 File Offset: 0x00006833
		public void SetPixels(Il2CppStructArray<Color> colors)
		{
			this.SetPixels(colors, 0);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0000863F File Offset: 0x0000683F
		public void SetPixels32(Il2CppStructArray<Color32> colors, int miplevel)
		{
			Texture3D.SetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), miplevel);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00008658 File Offset: 0x00006858
		public void SetPixels32(Il2CppStructArray<Color32> colors)
		{
			this.SetPixels32(colors, 0);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00008664 File Offset: 0x00006864
		public bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture3D.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00008682 File Offset: 0x00006882
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture3D.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0000869B File Offset: 0x0000689B
		public IntPtr GetImageDataPointer()
		{
			return Texture3D.GetImageDataPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00030990 File Offset: 0x0002EB90
		public static Texture3D CreateExternalTexture(int width, int height, int depth, TextureFormat format, bool mipChain, IntPtr nativeTex)
		{
			bool flag = nativeTex == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("nativeTex may not be zero");
			}
			return new Texture3D(width, height, depth, format, mipChain ? (-1) : 1, nativeTex);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000309D0 File Offset: 0x0002EBD0
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.ApplyImpl(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000086AD File Offset: 0x000068AD
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000086B9 File Offset: 0x000068B9
		public void Apply()
		{
			this.Apply(true, false);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000309FC File Offset: 0x0002EBFC
		public void SetPixel(int x, int y, int z, Color color)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.SetPixelImpl(0, x, y, z, color);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00030A2C File Offset: 0x0002EC2C
		public void SetPixel(int x, int y, int z, Color color, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.SetPixelImpl(mipLevel, x, y, z, color);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00030A60 File Offset: 0x0002EC60
		public Color GetPixel(int x, int y, int z)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl(0, x, y, z);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00030A94 File Offset: 0x0002EC94
		public Color GetPixel(int x, int y, int z, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl(mipLevel, x, y, z);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00030AC8 File Offset: 0x0002ECC8
		public Color GetPixelBilinear(float u, float v, float w)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelBilinearImpl(0, u, v, w);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00030AFC File Offset: 0x0002ECFC
		public Color GetPixelBilinear(float u, float v, float w, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelBilinearImpl(mipLevel, u, v, w);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00030B30 File Offset: 0x0002ED30
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

		// Token: 0x06000B24 RID: 2852 RVA: 0x00030BA8 File Offset: 0x0002EDA8
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

		// Token: 0x06000B25 RID: 2853 RVA: 0x00030C24 File Offset: 0x0002EE24
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
			intPtr..ctor(this.GetImageDataPointer().ToInt64() + (long)pixelDataOffset);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, pixelDataSize / num, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000086C5 File Offset: 0x000068C5
		public void SetPixelImpl_Injected(int image, int x, int y, int z, ref Color color)
		{
			Texture3D.SetPixelImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), image, x, y, z, ref color);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x000086DE File Offset: 0x000068DE
		public void GetPixelImpl_Injected(int image, int x, int y, int z, out Color ret)
		{
			Texture3D.GetPixelImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), image, x, y, z, out ret);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000086F7 File Offset: 0x000068F7
		public void GetPixelBilinearImpl_Injected(int image, float u, float v, float w, out Color ret)
		{
			Texture3D.GetPixelBilinearImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), image, u, v, w, out ret);
		}

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly Texture3D.get_depthDelegate get_depthDelegateField;

		// Token: 0x040007AA RID: 1962
		private static readonly Texture3D.get_formatDelegate get_formatDelegateField;

		// Token: 0x040007AB RID: 1963
		private static readonly Texture3D.UpdateExternalTextureDelegate UpdateExternalTextureDelegateField;

		// Token: 0x040007AC RID: 1964
		private static readonly Texture3D.ApplyImplDelegate ApplyImplDelegateField;

		// Token: 0x040007AD RID: 1965
		private static readonly Texture3D.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x040007AE RID: 1966
		private static readonly Texture3D.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x040007AF RID: 1967
		private static readonly Texture3D.SetPixelsDelegate SetPixelsDelegateField;

		// Token: 0x040007B0 RID: 1968
		private static readonly Texture3D.SetPixels32Delegate SetPixels32DelegateField;

		// Token: 0x040007B1 RID: 1969
		private static readonly Texture3D.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x040007B2 RID: 1970
		private static readonly Texture3D.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x040007B3 RID: 1971
		private static readonly Texture3D.GetImageDataPointerDelegate GetImageDataPointerDelegateField;

		// Token: 0x040007B4 RID: 1972
		private static readonly Texture3D.SetPixelImpl_InjectedDelegate SetPixelImpl_InjectedDelegateField;

		// Token: 0x040007B5 RID: 1973
		private static readonly Texture3D.GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;

		// Token: 0x040007B6 RID: 1974
		private static readonly Texture3D.GetPixelBilinearImpl_InjectedDelegate GetPixelBilinearImpl_InjectedDelegateField;

		// Token: 0x020006CB RID: 1739
		// (Invoke) Token: 0x06002B59 RID: 11097
		private delegate int get_depthDelegate(IntPtr @this);

		// Token: 0x020006CC RID: 1740
		// (Invoke) Token: 0x06002B5B RID: 11099
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x020006CD RID: 1741
		// (Invoke) Token: 0x06002B5D RID: 11101
		private delegate void UpdateExternalTextureDelegate(IntPtr @this, IntPtr nativeTex);

		// Token: 0x020006CE RID: 1742
		// (Invoke) Token: 0x06002B5F RID: 11103
		private delegate void ApplyImplDelegate(IntPtr @this, bool updateMipmaps, bool makeNoLongerReadable);

		// Token: 0x020006CF RID: 1743
		// (Invoke) Token: 0x06002B61 RID: 11105
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, int miplevel);

		// Token: 0x020006D0 RID: 1744
		// (Invoke) Token: 0x06002B63 RID: 11107
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, int miplevel);

		// Token: 0x020006D1 RID: 1745
		// (Invoke) Token: 0x06002B65 RID: 11109
		private delegate void SetPixelsDelegate(IntPtr @this, IntPtr colors, int miplevel);

		// Token: 0x020006D2 RID: 1746
		// (Invoke) Token: 0x06002B67 RID: 11111
		private delegate void SetPixels32Delegate(IntPtr @this, IntPtr colors, int miplevel);

		// Token: 0x020006D3 RID: 1747
		// (Invoke) Token: 0x06002B69 RID: 11113
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006D4 RID: 1748
		// (Invoke) Token: 0x06002B6B RID: 11115
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006D5 RID: 1749
		// (Invoke) Token: 0x06002B6D RID: 11117
		private delegate IntPtr GetImageDataPointerDelegate(IntPtr @this);

		// Token: 0x020006D6 RID: 1750
		// (Invoke) Token: 0x06002B6F RID: 11119
		private delegate void SetPixelImpl_InjectedDelegate(IntPtr @this, int image, int x, int y, int z, IntPtr color);

		// Token: 0x020006D7 RID: 1751
		// (Invoke) Token: 0x06002B71 RID: 11121
		private delegate void GetPixelImpl_InjectedDelegate(IntPtr @this, int image, int x, int y, int z, [Out] IntPtr ret);

		// Token: 0x020006D8 RID: 1752
		// (Invoke) Token: 0x06002B73 RID: 11123
		private delegate void GetPixelBilinearImpl_InjectedDelegate(IntPtr @this, int image, float u, float v, float w, [Out] IntPtr ret);
	}
}
