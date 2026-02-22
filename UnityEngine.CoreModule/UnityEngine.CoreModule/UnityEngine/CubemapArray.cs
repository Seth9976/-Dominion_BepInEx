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
	// Token: 0x02000074 RID: 116
	public sealed class CubemapArray : Texture
	{
		// Token: 0x06000B4A RID: 2890 RVA: 0x0003153C File Offset: 0x0002F73C
		// Note: this type is marked as 'beforefieldinit'.
		static CubemapArray()
		{
			Il2CppClassPointerStore<CubemapArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CubemapArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr);
			CubemapArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663869);
			CubemapArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663870);
			CubemapArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663871);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663872);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663873);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663874);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663875);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663876);
			CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663877);
			CubemapArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100663878);
			CubemapArray.get_cubemapCountDelegateField = IL2CPP.ResolveICall<CubemapArray.get_cubemapCountDelegate>("UnityEngine.CubemapArray::get_cubemapCount");
			CubemapArray.get_formatDelegateField = IL2CPP.ResolveICall<CubemapArray.get_formatDelegate>("UnityEngine.CubemapArray::get_format");
			CubemapArray.ApplyImplDelegateField = IL2CPP.ResolveICall<CubemapArray.ApplyImplDelegate>("UnityEngine.CubemapArray::ApplyImpl");
			CubemapArray.GetPixelsDelegateField = IL2CPP.ResolveICall<CubemapArray.GetPixelsDelegate>("UnityEngine.CubemapArray::GetPixels");
			CubemapArray.GetPixels32DelegateField = IL2CPP.ResolveICall<CubemapArray.GetPixels32Delegate>("UnityEngine.CubemapArray::GetPixels32");
			CubemapArray.SetPixelsDelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixelsDelegate>("UnityEngine.CubemapArray::SetPixels");
			CubemapArray.SetPixels32DelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixels32Delegate>("UnityEngine.CubemapArray::SetPixels32");
			CubemapArray.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixelDataImplArrayDelegate>("UnityEngine.CubemapArray::SetPixelDataImplArray");
			CubemapArray.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixelDataImplDelegate>("UnityEngine.CubemapArray::SetPixelDataImpl");
			CubemapArray.GetImageDataPointerDelegateField = IL2CPP.ResolveICall<CubemapArray.GetImageDataPointerDelegate>("UnityEngine.CubemapArray::GetImageDataPointer");
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000316CC File Offset: 0x0002F8CC
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64460, XrefRangeEnd = 64462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00031708 File Offset: 0x0002F908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64462, XrefRangeEnd = 64464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00031790 File Offset: 0x0002F990
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 64466, RefRangeEnd = 64470, XrefRangeStart = 64464, XrefRangeEnd = 64466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0003180C File Offset: 0x0002FA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64470, XrefRangeEnd = 64481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00031880 File Offset: 0x0002FA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64481, XrefRangeEnd = 64491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000318F4 File Offset: 0x0002FAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64491, XrefRangeEnd = 64497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00031974 File Offset: 0x0002FB74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64505, RefRangeEnd = 64507, XrefRangeStart = 64497, XrefRangeEnd = 64505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000319F4 File Offset: 0x0002FBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64507, XrefRangeEnd = 64509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00031A74 File Offset: 0x0002FC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64509, XrefRangeEnd = 64510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00031AE8 File Offset: 0x0002FCE8
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00008810 File Offset: 0x00006A10
		public CubemapArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00008819 File Offset: 0x00006A19
		public int cubemapCount
		{
			get
			{
				return CubemapArray.get_cubemapCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0000882B File Offset: 0x00006A2B
		public TextureFormat format
		{
			get
			{
				return CubemapArray.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0000883D File Offset: 0x00006A3D
		public void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			CubemapArray.ApplyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00031B1C File Offset: 0x0002FD1C
		public Il2CppStructArray<Color> GetPixels(CubemapFace face, int arrayElement, int miplevel)
		{
			IntPtr intPtr = CubemapArray.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), face, arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00031B4C File Offset: 0x0002FD4C
		public Il2CppStructArray<Color> GetPixels(CubemapFace face, int arrayElement)
		{
			return this.GetPixels(face, arrayElement, 0);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00031B68 File Offset: 0x0002FD68
		public Il2CppStructArray<Color32> GetPixels32(CubemapFace face, int arrayElement, int miplevel)
		{
			IntPtr intPtr = CubemapArray.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), face, arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00031B98 File Offset: 0x0002FD98
		public Il2CppStructArray<Color32> GetPixels32(CubemapFace face, int arrayElement)
		{
			return this.GetPixels32(face, arrayElement, 0);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00008851 File Offset: 0x00006A51
		public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int arrayElement, int miplevel)
		{
			CubemapArray.SetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), face, arrayElement, miplevel);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0000886D File Offset: 0x00006A6D
		public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int arrayElement)
		{
			this.SetPixels(colors, face, arrayElement, 0);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0000887B File Offset: 0x00006A7B
		public void SetPixels32(Il2CppStructArray<Color32> colors, CubemapFace face, int arrayElement, int miplevel)
		{
			CubemapArray.SetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), face, arrayElement, miplevel);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00008897 File Offset: 0x00006A97
		public void SetPixels32(Il2CppStructArray<Color32> colors, CubemapFace face, int arrayElement)
		{
			this.SetPixels32(colors, face, arrayElement, 0);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00031BB4 File Offset: 0x0002FDB4
		public bool SetPixelDataImplArray(Array data, int mipLevel, int face, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return CubemapArray.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00031BE4 File Offset: 0x0002FDE4
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return CubemapArray.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000088A5 File Offset: 0x00006AA5
		public IntPtr GetImageDataPointer()
		{
			return CubemapArray.GetImageDataPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00031C0C File Offset: 0x0002FE0C
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.ApplyImpl(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000088B7 File Offset: 0x00006AB7
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000088C3 File Offset: 0x00006AC3
		public void Apply()
		{
			this.Apply(true, false);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00031C38 File Offset: 0x0002FE38
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, CubemapFace face, int element, [Optional] int sourceDataStartIndex)
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
			this.SetPixelDataImplArray(data, mipLevel, (int)face, element, Marshal.SizeOf(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, CubemapFace face, int element, [Optional] int sourceDataStartIndex) where T : struct
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
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, (int)face, element, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00031D34 File Offset: 0x0002FF34
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face, int element) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			int num = (int)(element * 6 + face);
			int pixelDataOffset = base.GetPixelDataOffset(base.mipmapCount, num);
			int pixelDataOffset2 = base.GetPixelDataOffset(mipLevel, num);
			int pixelDataSize = base.GetPixelDataSize(mipLevel, num);
			int num2 = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			IntPtr intPtr;
			intPtr..ctor(this.GetImageDataPointer().ToInt64() + (long)(pixelDataOffset * num + pixelDataOffset2));
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, pixelDataSize / num2, Unity.Collections.Allocator.None);
		}

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly CubemapArray.get_cubemapCountDelegate get_cubemapCountDelegateField;

		// Token: 0x040007D7 RID: 2007
		private static readonly CubemapArray.get_formatDelegate get_formatDelegateField;

		// Token: 0x040007D8 RID: 2008
		private static readonly CubemapArray.ApplyImplDelegate ApplyImplDelegateField;

		// Token: 0x040007D9 RID: 2009
		private static readonly CubemapArray.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x040007DA RID: 2010
		private static readonly CubemapArray.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x040007DB RID: 2011
		private static readonly CubemapArray.SetPixelsDelegate SetPixelsDelegateField;

		// Token: 0x040007DC RID: 2012
		private static readonly CubemapArray.SetPixels32Delegate SetPixels32DelegateField;

		// Token: 0x040007DD RID: 2013
		private static readonly CubemapArray.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x040007DE RID: 2014
		private static readonly CubemapArray.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x040007DF RID: 2015
		private static readonly CubemapArray.GetImageDataPointerDelegate GetImageDataPointerDelegateField;

		// Token: 0x020006E4 RID: 1764
		// (Invoke) Token: 0x06002B8B RID: 11147
		private delegate int get_cubemapCountDelegate(IntPtr @this);

		// Token: 0x020006E5 RID: 1765
		// (Invoke) Token: 0x06002B8D RID: 11149
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x020006E6 RID: 1766
		// (Invoke) Token: 0x06002B8F RID: 11151
		private delegate void ApplyImplDelegate(IntPtr @this, bool updateMipmaps, bool makeNoLongerReadable);

		// Token: 0x020006E7 RID: 1767
		// (Invoke) Token: 0x06002B91 RID: 11153
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, CubemapFace face, int arrayElement, int miplevel);

		// Token: 0x020006E8 RID: 1768
		// (Invoke) Token: 0x06002B93 RID: 11155
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, CubemapFace face, int arrayElement, int miplevel);

		// Token: 0x020006E9 RID: 1769
		// (Invoke) Token: 0x06002B95 RID: 11157
		private delegate void SetPixelsDelegate(IntPtr @this, IntPtr colors, CubemapFace face, int arrayElement, int miplevel);

		// Token: 0x020006EA RID: 1770
		// (Invoke) Token: 0x06002B97 RID: 11159
		private delegate void SetPixels32Delegate(IntPtr @this, IntPtr colors, CubemapFace face, int arrayElement, int miplevel);

		// Token: 0x020006EB RID: 1771
		// (Invoke) Token: 0x06002B99 RID: 11161
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006EC RID: 1772
		// (Invoke) Token: 0x06002B9B RID: 11163
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006ED RID: 1773
		// (Invoke) Token: 0x06002B9D RID: 11165
		private delegate IntPtr GetImageDataPointerDelegate(IntPtr @this);
	}
}
