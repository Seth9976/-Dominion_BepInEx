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
	// Token: 0x02000073 RID: 115
	public sealed class Texture2DArray : Texture
	{
		// Token: 0x06000B29 RID: 2857 RVA: 0x00030C94 File Offset: 0x0002EE94
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2DArray()
		{
			Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture2DArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr);
			Texture2DArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663859);
			Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663860);
			Texture2DArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663861);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663862);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663863);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663864);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663865);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663866);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663867);
			Texture2DArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100663868);
			Texture2DArray.get_allSlicesDelegateField = IL2CPP.ResolveICall<Texture2DArray.get_allSlicesDelegate>("UnityEngine.Texture2DArray::get_allSlices");
			Texture2DArray.get_depthDelegateField = IL2CPP.ResolveICall<Texture2DArray.get_depthDelegate>("UnityEngine.Texture2DArray::get_depth");
			Texture2DArray.get_formatDelegateField = IL2CPP.ResolveICall<Texture2DArray.get_formatDelegate>("UnityEngine.Texture2DArray::get_format");
			Texture2DArray.ApplyImplDelegateField = IL2CPP.ResolveICall<Texture2DArray.ApplyImplDelegate>("UnityEngine.Texture2DArray::ApplyImpl");
			Texture2DArray.GetPixelsDelegateField = IL2CPP.ResolveICall<Texture2DArray.GetPixelsDelegate>("UnityEngine.Texture2DArray::GetPixels");
			Texture2DArray.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixelDataImplArrayDelegate>("UnityEngine.Texture2DArray::SetPixelDataImplArray");
			Texture2DArray.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixelDataImplDelegate>("UnityEngine.Texture2DArray::SetPixelDataImpl");
			Texture2DArray.GetPixels32DelegateField = IL2CPP.ResolveICall<Texture2DArray.GetPixels32Delegate>("UnityEngine.Texture2DArray::GetPixels32");
			Texture2DArray.SetPixelsDelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixelsDelegate>("UnityEngine.Texture2DArray::SetPixels");
			Texture2DArray.SetPixels32DelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixels32Delegate>("UnityEngine.Texture2DArray::SetPixels32");
			Texture2DArray.GetImageDataPointerDelegateField = IL2CPP.ResolveICall<Texture2DArray.GetImageDataPointerDelegate>("UnityEngine.Texture2DArray::GetImageDataPointer");
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00030E34 File Offset: 0x0002F034
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64397, XrefRangeEnd = 64399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00030E70 File Offset: 0x0002F070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64399, XrefRangeEnd = 64401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00030F08 File Offset: 0x0002F108
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 64403, RefRangeEnd = 64407, XrefRangeStart = 64401, XrefRangeEnd = 64403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00030F94 File Offset: 0x0002F194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64407, XrefRangeEnd = 64422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00031014 File Offset: 0x0002F214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64422, XrefRangeEnd = 64435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00031094 File Offset: 0x0002F294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64435, XrefRangeEnd = 64444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00031124 File Offset: 0x0002F324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64455, RefRangeEnd = 64457, XrefRangeStart = 64444, XrefRangeEnd = 64455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x000311B4 File Offset: 0x0002F3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64457, XrefRangeEnd = 64459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00031244 File Offset: 0x0002F444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64459, XrefRangeEnd = 64460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000312C4 File Offset: 0x0002F4C4
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00008710 File Offset: 0x00006910
		public Texture2DArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00008719 File Offset: 0x00006919
		public static int allSlices
		{
			get
			{
				return Texture2DArray.get_allSlicesDelegateField();
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00008725 File Offset: 0x00006925
		public int depth
		{
			get
			{
				return Texture2DArray.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00008737 File Offset: 0x00006937
		public TextureFormat format
		{
			get
			{
				return Texture2DArray.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00008749 File Offset: 0x00006949
		public void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			Texture2DArray.ApplyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000312F8 File Offset: 0x0002F4F8
		public Il2CppStructArray<Color> GetPixels(int arrayElement, int miplevel)
		{
			IntPtr intPtr = Texture2DArray.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00031328 File Offset: 0x0002F528
		public Il2CppStructArray<Color> GetPixels(int arrayElement)
		{
			return this.GetPixels(arrayElement, 0);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0000875D File Offset: 0x0000695D
		public bool SetPixelDataImplArray(Array data, int mipLevel, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2DArray.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0000877D File Offset: 0x0000697D
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2DArray.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00031344 File Offset: 0x0002F544
		public Il2CppStructArray<Color32> GetPixels32(int arrayElement, int miplevel)
		{
			IntPtr intPtr = Texture2DArray.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00031374 File Offset: 0x0002F574
		public Il2CppStructArray<Color32> GetPixels32(int arrayElement)
		{
			return this.GetPixels32(arrayElement, 0);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00008798 File Offset: 0x00006998
		public void SetPixels(Il2CppStructArray<Color> colors, int arrayElement, int miplevel)
		{
			Texture2DArray.SetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), arrayElement, miplevel);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000087B2 File Offset: 0x000069B2
		public void SetPixels(Il2CppStructArray<Color> colors, int arrayElement)
		{
			this.SetPixels(colors, arrayElement, 0);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000087BF File Offset: 0x000069BF
		public void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement, int miplevel)
		{
			Texture2DArray.SetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), arrayElement, miplevel);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000087D9 File Offset: 0x000069D9
		public void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement)
		{
			this.SetPixels32(colors, arrayElement, 0);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000087E6 File Offset: 0x000069E6
		public IntPtr GetImageDataPointer()
		{
			return Texture2DArray.GetImageDataPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00031390 File Offset: 0x0002F590
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.ApplyImpl(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x000313BC File Offset: 0x0002F5BC
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, int element, [Optional] int sourceDataStartIndex)
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
			this.SetPixelDataImplArray(data, mipLevel, element, Marshal.SizeOf(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00031438 File Offset: 0x0002F638
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int element, [Optional] int sourceDataStartIndex) where T : struct
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
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, element, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000314B8 File Offset: 0x0002F6B8
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, int element) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			int pixelDataOffset = base.GetPixelDataOffset(base.mipmapCount, element);
			int pixelDataOffset2 = base.GetPixelDataOffset(mipLevel, element);
			int pixelDataSize = base.GetPixelDataSize(mipLevel, element);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			IntPtr intPtr;
			intPtr..ctor(this.GetImageDataPointer().ToInt64() + (long)(pixelDataOffset * element + pixelDataOffset2));
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, pixelDataSize / num, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000087F8 File Offset: 0x000069F8
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00008804 File Offset: 0x00006A04
		public void Apply()
		{
			this.Apply(true, false);
		}

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly Texture2DArray.get_allSlicesDelegate get_allSlicesDelegateField;

		// Token: 0x040007C2 RID: 1986
		private static readonly Texture2DArray.get_depthDelegate get_depthDelegateField;

		// Token: 0x040007C3 RID: 1987
		private static readonly Texture2DArray.get_formatDelegate get_formatDelegateField;

		// Token: 0x040007C4 RID: 1988
		private static readonly Texture2DArray.ApplyImplDelegate ApplyImplDelegateField;

		// Token: 0x040007C5 RID: 1989
		private static readonly Texture2DArray.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x040007C6 RID: 1990
		private static readonly Texture2DArray.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x040007C7 RID: 1991
		private static readonly Texture2DArray.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x040007C8 RID: 1992
		private static readonly Texture2DArray.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x040007C9 RID: 1993
		private static readonly Texture2DArray.SetPixelsDelegate SetPixelsDelegateField;

		// Token: 0x040007CA RID: 1994
		private static readonly Texture2DArray.SetPixels32Delegate SetPixels32DelegateField;

		// Token: 0x040007CB RID: 1995
		private static readonly Texture2DArray.GetImageDataPointerDelegate GetImageDataPointerDelegateField;

		// Token: 0x020006D9 RID: 1753
		// (Invoke) Token: 0x06002B75 RID: 11125
		private delegate int get_allSlicesDelegate();

		// Token: 0x020006DA RID: 1754
		// (Invoke) Token: 0x06002B77 RID: 11127
		private delegate int get_depthDelegate(IntPtr @this);

		// Token: 0x020006DB RID: 1755
		// (Invoke) Token: 0x06002B79 RID: 11129
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x020006DC RID: 1756
		// (Invoke) Token: 0x06002B7B RID: 11131
		private delegate void ApplyImplDelegate(IntPtr @this, bool updateMipmaps, bool makeNoLongerReadable);

		// Token: 0x020006DD RID: 1757
		// (Invoke) Token: 0x06002B7D RID: 11133
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, int arrayElement, int miplevel);

		// Token: 0x020006DE RID: 1758
		// (Invoke) Token: 0x06002B7F RID: 11135
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006DF RID: 1759
		// (Invoke) Token: 0x06002B81 RID: 11137
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006E0 RID: 1760
		// (Invoke) Token: 0x06002B83 RID: 11139
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, int arrayElement, int miplevel);

		// Token: 0x020006E1 RID: 1761
		// (Invoke) Token: 0x06002B85 RID: 11141
		private delegate void SetPixelsDelegate(IntPtr @this, IntPtr colors, int arrayElement, int miplevel);

		// Token: 0x020006E2 RID: 1762
		// (Invoke) Token: 0x06002B87 RID: 11143
		private delegate void SetPixels32Delegate(IntPtr @this, IntPtr colors, int arrayElement, int miplevel);

		// Token: 0x020006E3 RID: 1763
		// (Invoke) Token: 0x06002B89 RID: 11145
		private delegate IntPtr GetImageDataPointerDelegate(IntPtr @this);
	}
}
