using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class ImageConversion : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		// Note: this type is marked as 'beforefieldinit'.
		static ImageConversion()
		{
			Il2CppClassPointerStore<ImageConversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ImageConversionModule.dll", "UnityEngine", "ImageConversion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr);
			ImageConversion.NativeMethodInfoPtr_EncodeToPNG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663297);
			ImageConversion.NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663298);
			ImageConversion.NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663299);
			ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField = IL2CPP.ResolveICall<ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate>("UnityEngine.ImageConversion::GetEnableLegacyPngGammaRuntimeLoadBehavior");
			ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField = IL2CPP.ResolveICall<ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate>("UnityEngine.ImageConversion::SetEnableLegacyPngGammaRuntimeLoadBehavior");
			ImageConversion.EncodeToTGADelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeToTGADelegate>("UnityEngine.ImageConversion::EncodeToTGA");
			ImageConversion.EncodeToJPGDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeToJPGDelegate>("UnityEngine.ImageConversion::EncodeToJPG");
			ImageConversion.EncodeToEXRDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeToEXRDelegate>("UnityEngine.ImageConversion::EncodeToEXR");
			ImageConversion.EncodeArrayToTGADelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeArrayToTGADelegate>("UnityEngine.ImageConversion::EncodeArrayToTGA");
			ImageConversion.EncodeArrayToPNGDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeArrayToPNGDelegate>("UnityEngine.ImageConversion::EncodeArrayToPNG");
			ImageConversion.EncodeArrayToJPGDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeArrayToJPGDelegate>("UnityEngine.ImageConversion::EncodeArrayToJPG");
			ImageConversion.EncodeArrayToEXRDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeArrayToEXRDelegate>("UnityEngine.ImageConversion::EncodeArrayToEXR");
			ImageConversion.UnsafeEncodeNativeArrayToTGADelegateField = IL2CPP.ResolveICall<ImageConversion.UnsafeEncodeNativeArrayToTGADelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToTGA");
			ImageConversion.UnsafeEncodeNativeArrayToPNGDelegateField = IL2CPP.ResolveICall<ImageConversion.UnsafeEncodeNativeArrayToPNGDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToPNG");
			ImageConversion.UnsafeEncodeNativeArrayToJPGDelegateField = IL2CPP.ResolveICall<ImageConversion.UnsafeEncodeNativeArrayToJPGDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToJPG");
			ImageConversion.UnsafeEncodeNativeArrayToEXRDelegateField = IL2CPP.ResolveICall<ImageConversion.UnsafeEncodeNativeArrayToEXRDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToEXR");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002200 File Offset: 0x00000400
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 90253, RefRangeEnd = 90274, XrefRangeStart = 90251, XrefRangeEnd = 90253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncodeToPNG(this Texture2D tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageConversion.NativeMethodInfoPtr_EncodeToPNG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002244 File Offset: 0x00000444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90276, RefRangeEnd = 90278, XrefRangeStart = 90274, XrefRangeEnd = 90276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadImage(this Texture2D tex, Il2CppStructArray<byte> data, bool markNonReadable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref markNonReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageConversion.NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000022A8 File Offset: 0x000004A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 90280, RefRangeEnd = 90286, XrefRangeStart = 90278, XrefRangeEnd = 90280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadImage(this Texture2D tex, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageConversion.NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public ImageConversion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000022FC File Offset: 0x000004FC
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public static bool EnableLegacyPngGammaRuntimeLoadBehavior
		{
			get
			{
				return ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehavior();
			}
			set
			{
				ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehavior(value);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002063 File Offset: 0x00000263
		public static bool GetEnableLegacyPngGammaRuntimeLoadBehavior()
		{
			return ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000206F File Offset: 0x0000026F
		public static void SetEnableLegacyPngGammaRuntimeLoadBehavior(bool enable)
		{
			ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField(enable);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002314 File Offset: 0x00000514
		public static Il2CppStructArray<byte> EncodeToTGA(Texture2D tex)
		{
			IntPtr intPtr = ImageConversion.EncodeToTGADelegateField(IL2CPP.Il2CppObjectBaseToPtr(tex));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002340 File Offset: 0x00000540
		public static Il2CppStructArray<byte> EncodeToJPG(Texture2D tex, int quality)
		{
			IntPtr intPtr = ImageConversion.EncodeToJPGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(tex), quality);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002370 File Offset: 0x00000570
		public static Il2CppStructArray<byte> EncodeToJPG(Texture2D tex)
		{
			return ImageConversion.EncodeToJPG(tex, 75);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000238C File Offset: 0x0000058C
		public static Il2CppStructArray<byte> EncodeToEXR(Texture2D tex, Texture2D.EXRFlags flags)
		{
			IntPtr intPtr = ImageConversion.EncodeToEXRDelegateField(IL2CPP.Il2CppObjectBaseToPtr(tex), flags);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000023BC File Offset: 0x000005BC
		public static Il2CppStructArray<byte> EncodeToEXR(Texture2D tex)
		{
			return ImageConversion.EncodeToEXR(tex, Texture2D.EXRFlags.None);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023D8 File Offset: 0x000005D8
		public static Il2CppStructArray<byte> EncodeArrayToTGA(Array input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
		{
			IntPtr intPtr = ImageConversion.EncodeArrayToTGADelegateField(IL2CPP.Il2CppObjectBaseToPtr(input), format, width, height, rowBytes);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000240C File Offset: 0x0000060C
		public static Il2CppStructArray<byte> EncodeArrayToPNG(Array input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
		{
			IntPtr intPtr = ImageConversion.EncodeArrayToPNGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(input), format, width, height, rowBytes);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002440 File Offset: 0x00000640
		public static Il2CppStructArray<byte> EncodeArrayToJPG(Array input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality)
		{
			IntPtr intPtr = ImageConversion.EncodeArrayToJPGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(input), format, width, height, rowBytes, quality);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002474 File Offset: 0x00000674
		public static Il2CppStructArray<byte> EncodeArrayToEXR(Array input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags)
		{
			IntPtr intPtr = ImageConversion.EncodeArrayToEXRDelegateField(IL2CPP.Il2CppObjectBaseToPtr(input), format, width, height, rowBytes, flags);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024A8 File Offset: 0x000006A8
		public unsafe static NativeArray<byte> EncodeNativeArrayToTGA<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes) where T : struct
		{
			int num = input.Length * UnsafeUtility.SizeOf<T>();
			void* ptr = ImageConversion.UnsafeEncodeNativeArrayToTGA(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<T>(input), ref num, format, width, height, rowBytes);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(ptr, num, Allocator.Persistent);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000024E8 File Offset: 0x000006E8
		public unsafe static NativeArray<byte> EncodeNativeArrayToPNG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes) where T : struct
		{
			int num = input.Length * UnsafeUtility.SizeOf<T>();
			void* ptr = ImageConversion.UnsafeEncodeNativeArrayToPNG(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<T>(input), ref num, format, width, height, rowBytes);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(ptr, num, Allocator.Persistent);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002528 File Offset: 0x00000728
		public unsafe static NativeArray<byte> EncodeNativeArrayToJPG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality) where T : struct
		{
			int num = input.Length * UnsafeUtility.SizeOf<T>();
			void* ptr = ImageConversion.UnsafeEncodeNativeArrayToJPG(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<T>(input), ref num, format, width, height, rowBytes, quality);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(ptr, num, Allocator.Persistent);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002568 File Offset: 0x00000768
		public unsafe static NativeArray<byte> EncodeNativeArrayToEXR<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags) where T : struct
		{
			int num = input.Length * UnsafeUtility.SizeOf<T>();
			void* ptr = ImageConversion.UnsafeEncodeNativeArrayToEXR(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<T>(input), ref num, format, width, height, rowBytes, flags);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(ptr, num, Allocator.Persistent);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000207C File Offset: 0x0000027C
		public unsafe static void* UnsafeEncodeNativeArrayToTGA(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
		{
			return ImageConversion.UnsafeEncodeNativeArrayToTGADelegateField(array, ref sizeInBytes, format, width, height, rowBytes);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002090 File Offset: 0x00000290
		public unsafe static void* UnsafeEncodeNativeArrayToPNG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
		{
			return ImageConversion.UnsafeEncodeNativeArrayToPNGDelegateField(array, ref sizeInBytes, format, width, height, rowBytes);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020A4 File Offset: 0x000002A4
		public unsafe static void* UnsafeEncodeNativeArrayToJPG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality)
		{
			return ImageConversion.UnsafeEncodeNativeArrayToJPGDelegateField(array, ref sizeInBytes, format, width, height, rowBytes, quality);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020BA File Offset: 0x000002BA
		public unsafe static void* UnsafeEncodeNativeArrayToEXR(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags)
		{
			return ImageConversion.UnsafeEncodeNativeArrayToEXRDelegateField(array, ref sizeInBytes, format, width, height, rowBytes, flags);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_EncodeToPNG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000004 RID: 4
		private static readonly ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly ImageConversion.EncodeToTGADelegate EncodeToTGADelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly ImageConversion.EncodeToJPGDelegate EncodeToJPGDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly ImageConversion.EncodeToEXRDelegate EncodeToEXRDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly ImageConversion.EncodeArrayToTGADelegate EncodeArrayToTGADelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly ImageConversion.EncodeArrayToPNGDelegate EncodeArrayToPNGDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly ImageConversion.EncodeArrayToJPGDelegate EncodeArrayToJPGDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly ImageConversion.EncodeArrayToEXRDelegate EncodeArrayToEXRDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly ImageConversion.UnsafeEncodeNativeArrayToTGADelegate UnsafeEncodeNativeArrayToTGADelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly ImageConversion.UnsafeEncodeNativeArrayToPNGDelegate UnsafeEncodeNativeArrayToPNGDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly ImageConversion.UnsafeEncodeNativeArrayToJPGDelegate UnsafeEncodeNativeArrayToJPGDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly ImageConversion.UnsafeEncodeNativeArrayToEXRDelegate UnsafeEncodeNativeArrayToEXRDelegateField;

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x0600001C RID: 28
		private delegate bool GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate();

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600001E RID: 30
		private delegate void SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate(bool enable);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate IntPtr EncodeToTGADelegate(IntPtr tex);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate IntPtr EncodeToJPGDelegate(IntPtr tex, int quality);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate IntPtr EncodeToEXRDelegate(IntPtr tex, Texture2D.EXRFlags flags);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate IntPtr EncodeArrayToTGADelegate(IntPtr input, GraphicsFormat format, uint width, uint height, uint rowBytes);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000028 RID: 40
		private delegate IntPtr EncodeArrayToPNGDelegate(IntPtr input, GraphicsFormat format, uint width, uint height, uint rowBytes);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600002A RID: 42
		private delegate IntPtr EncodeArrayToJPGDelegate(IntPtr input, GraphicsFormat format, uint width, uint height, uint rowBytes, int quality);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600002C RID: 44
		private delegate IntPtr EncodeArrayToEXRDelegate(IntPtr input, GraphicsFormat format, uint width, uint height, uint rowBytes, Texture2D.EXRFlags flags);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600002E RID: 46
		private delegate IntPtr UnsafeEncodeNativeArrayToTGADelegate(IntPtr array, IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000030 RID: 48
		private delegate IntPtr UnsafeEncodeNativeArrayToPNGDelegate(IntPtr array, IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000032 RID: 50
		private delegate IntPtr UnsafeEncodeNativeArrayToJPGDelegate(IntPtr array, IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes, int quality);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000034 RID: 52
		private delegate IntPtr UnsafeEncodeNativeArrayToEXRDelegate(IntPtr array, IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes, Texture2D.EXRFlags flags);
	}
}
