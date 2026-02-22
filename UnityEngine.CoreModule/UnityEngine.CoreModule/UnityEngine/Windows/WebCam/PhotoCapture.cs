using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x020000F4 RID: 244
	public class PhotoCapture : Object
	{
		// Token: 0x060014DC RID: 5340 RVA: 0x0004F8CC File Offset: 0x0004DACC
		// Note: this type is marked as 'beforefieldinit'.
		static PhotoCapture()
		{
			Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "PhotoCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr);
			PhotoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "m_NativePtr");
			PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "HR_SUCCESS");
			PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664791);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664792);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664794);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664795);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664796);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664797);
			PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664798);
			PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664799);
			PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664800);
			PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100664801);
			PhotoCapture.GetSupportedResolutions_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.GetSupportedResolutions_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::GetSupportedResolutions_Internal");
			PhotoCapture.Instantiate_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.Instantiate_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::Instantiate_Internal");
			PhotoCapture.StopPhotoModeAsyncDelegateField = IL2CPP.ResolveICall<PhotoCapture.StopPhotoModeAsyncDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::StopPhotoModeAsync");
			PhotoCapture.CapturePhotoToDisk_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.CapturePhotoToDisk_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::CapturePhotoToDisk_Internal");
			PhotoCapture.CapturePhotoToMemory_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.CapturePhotoToMemory_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::CapturePhotoToMemory_Internal");
			PhotoCapture.GetUnsafePointerToVideoDeviceControllerDelegateField = IL2CPP.ResolveICall<PhotoCapture.GetUnsafePointerToVideoDeviceControllerDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::GetUnsafePointerToVideoDeviceController");
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0004FA48 File Offset: 0x0004DC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79706, XrefRangeEnd = 79710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0004FA88 File Offset: 0x0004DC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79710, XrefRangeEnd = 79717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0004FACC File Offset: 0x0004DCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79717, XrefRangeEnd = 79726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0004FB10 File Offset: 0x0004DD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79726, XrefRangeEnd = 79735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0004FB54 File Offset: 0x0004DD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79735, XrefRangeEnd = 79744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0004FB98 File Offset: 0x0004DD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79744, XrefRangeEnd = 79769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref photoCaptureFramePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0004FBEC File Offset: 0x0004DDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79769, XrefRangeEnd = 79777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0004FC20 File Offset: 0x0004DE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79777, XrefRangeEnd = 79779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0004FC54 File Offset: 0x0004DE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79779, XrefRangeEnd = 79786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0004FC90 File Offset: 0x0004DE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79786, XrefRangeEnd = 79788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeThreaded_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0000C067 File Offset: 0x0000A267
		public PhotoCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0004FCC4 File Offset: 0x0004DEC4
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x0000C070 File Offset: 0x0000A270
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x0004FCEC File Offset: 0x0004DEEC
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x0000C08B File Offset: 0x0000A28B
		public unsafe static long HR_SUCCESS
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0004FD08 File Offset: 0x0004DF08
		public static PhotoCapture.PhotoCaptureResult MakeCaptureResult(PhotoCapture.CaptureResultType resultType, long hResult)
		{
			return new PhotoCapture.PhotoCaptureResult
			{
				resultType = resultType,
				hResult = hResult
			};
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0000C099 File Offset: 0x0000A299
		public static IEnumerable<Resolution> SupportedResolutions
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0004FD34 File Offset: 0x0004DF34
		public static Il2CppStructArray<Resolution> GetSupportedResolutions_Internal()
		{
			IntPtr intPtr = PhotoCapture.GetSupportedResolutions_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0004FD5C File Offset: 0x0004DF5C
		public static void CreateAsync(bool showHolograms, PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
		{
			bool flag = onCreatedCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCreatedCallback");
			}
			PhotoCapture.Instantiate_Internal(showHolograms, onCreatedCallback);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0004FD88 File Offset: 0x0004DF88
		public static void CreateAsync(PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
		{
			bool flag = onCreatedCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCreatedCallback");
			}
			PhotoCapture.Instantiate_Internal(false, onCreatedCallback);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0000C0A6 File Offset: 0x0000A2A6
		public static IntPtr Instantiate_Internal(bool showHolograms, PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
		{
			return PhotoCapture.Instantiate_InternalDelegateField(showHolograms, IL2CPP.Il2CppObjectBaseToPtr(onCreatedCallback));
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0000C0B9 File Offset: 0x0000A2B9
		public void StopPhotoModeAsync(PhotoCapture.OnPhotoModeStoppedCallback onPhotoModeStoppedCallback)
		{
			PhotoCapture.StopPhotoModeAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(onPhotoModeStoppedCallback));
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0004FDB4 File Offset: 0x0004DFB4
		public void TakePhotoAsync(string filename, PhotoCaptureFileOutputFormat fileOutputFormat, PhotoCapture.OnCapturedToDiskCallback onCapturedPhotoToDiskCallback)
		{
			bool flag = onCapturedPhotoToDiskCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCapturedPhotoToDiskCallback");
			}
			bool flag2 = String.IsNullOrEmpty(filename);
			if (flag2)
			{
				throw new ArgumentNullException("filename");
			}
			filename = filename.Replace("/", "\\");
			string directoryName = Path.GetDirectoryName(filename);
			bool flag3 = !String.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName);
			if (flag3)
			{
				throw new ArgumentException("The specified directory does not exist.", "filename");
			}
			FileInfo fileInfo = new FileInfo(filename);
			bool flag4 = fileInfo.Exists && fileInfo.IsReadOnly;
			if (flag4)
			{
				throw new ArgumentException("Cannot write to the file because it is read-only.", "filename");
			}
			this.CapturePhotoToDisk_Internal(filename, fileOutputFormat, onCapturedPhotoToDiskCallback);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0000C0D1 File Offset: 0x0000A2D1
		public void CapturePhotoToDisk_Internal(string filename, PhotoCaptureFileOutputFormat fileOutputFormat, PhotoCapture.OnCapturedToDiskCallback onCapturedPhotoToDiskCallback)
		{
			PhotoCapture.CapturePhotoToDisk_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(filename), fileOutputFormat, IL2CPP.Il2CppObjectBaseToPtr(onCapturedPhotoToDiskCallback));
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0004FE6C File Offset: 0x0004E06C
		public void TakePhotoAsync(PhotoCapture.OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback)
		{
			bool flag = onCapturedPhotoToMemoryCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCapturedPhotoToMemoryCallback");
			}
			this.CapturePhotoToMemory_Internal(onCapturedPhotoToMemoryCallback);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public void CapturePhotoToMemory_Internal(PhotoCapture.OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback)
		{
			PhotoCapture.CapturePhotoToMemory_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(onCapturedPhotoToMemoryCallback));
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0000C108 File Offset: 0x0000A308
		public IntPtr GetUnsafePointerToVideoDeviceController()
		{
			return PhotoCapture.GetUnsafePointerToVideoDeviceControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeFieldInfoPtr_HR_SUCCESS;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly PhotoCapture.GetSupportedResolutions_InternalDelegate GetSupportedResolutions_InternalDelegateField;

		// Token: 0x04000F93 RID: 3987
		private static readonly PhotoCapture.Instantiate_InternalDelegate Instantiate_InternalDelegateField;

		// Token: 0x04000F94 RID: 3988
		private static readonly PhotoCapture.StopPhotoModeAsyncDelegate StopPhotoModeAsyncDelegateField;

		// Token: 0x04000F95 RID: 3989
		private static readonly PhotoCapture.CapturePhotoToDisk_InternalDelegate CapturePhotoToDisk_InternalDelegateField;

		// Token: 0x04000F96 RID: 3990
		private static readonly PhotoCapture.CapturePhotoToMemory_InternalDelegate CapturePhotoToMemory_InternalDelegateField;

		// Token: 0x04000F97 RID: 3991
		private static readonly PhotoCapture.GetUnsafePointerToVideoDeviceControllerDelegate GetUnsafePointerToVideoDeviceControllerDelegateField;

		// Token: 0x020008A3 RID: 2211
		public enum CaptureResultType
		{
			// Token: 0x04001CD5 RID: 7381
			Success,
			// Token: 0x04001CD6 RID: 7382
			UnknownError
		}

		// Token: 0x020008A4 RID: 2212
		[StructLayout(2)]
		public struct PhotoCaptureResult
		{
			// Token: 0x06002F1B RID: 12059 RVA: 0x0006D2DC File Offset: 0x0006B4DC
			// Note: this type is marked as 'beforefieldinit'.
			static PhotoCaptureResult()
			{
				Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "PhotoCaptureResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr);
				PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, "resultType");
				PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, "hResult");
			}

			// Token: 0x06002F1C RID: 12060 RVA: 0x0001587D File Offset: 0x00013A7D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04001CD7 RID: 7383
			private static readonly IntPtr NativeFieldInfoPtr_resultType;

			// Token: 0x04001CD8 RID: 7384
			private static readonly IntPtr NativeFieldInfoPtr_hResult;

			// Token: 0x04001CD9 RID: 7385
			[FieldOffset(0)]
			public PhotoCapture.CaptureResultType resultType;

			// Token: 0x04001CDA RID: 7386
			[FieldOffset(8)]
			public long hResult;
		}

		// Token: 0x020008A5 RID: 2213
		public sealed class OnCaptureResourceCreatedCallback : MulticastDelegate
		{
			// Token: 0x06002F1D RID: 12061 RVA: 0x0001588F File Offset: 0x00013A8F
			// Note: this type is marked as 'beforefieldinit'.
			static OnCaptureResourceCreatedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCaptureResourceCreatedCallback");
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100664803);
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100664804);
			}

			// Token: 0x06002F1E RID: 12062 RVA: 0x0006D330 File Offset: 0x0006B530
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCaptureResourceCreatedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F1F RID: 12063 RVA: 0x0006D38C File Offset: 0x0006B58C
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture captureObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F20 RID: 12064 RVA: 0x000158CD File Offset: 0x00013ACD
			public OnCaptureResourceCreatedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F21 RID: 12065 RVA: 0x000158D6 File Offset: 0x00013AD6
			public static implicit operator PhotoCapture.OnCaptureResourceCreatedCallback(Action<PhotoCapture> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCaptureResourceCreatedCallback>(A_0);
			}

			// Token: 0x06002F22 RID: 12066 RVA: 0x000158DE File Offset: 0x00013ADE
			public static PhotoCapture.OnCaptureResourceCreatedCallback operator +(PhotoCapture.OnCaptureResourceCreatedCallback A_0, PhotoCapture.OnCaptureResourceCreatedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
			}

			// Token: 0x06002F23 RID: 12067 RVA: 0x000158EC File Offset: 0x00013AEC
			public static PhotoCapture.OnCaptureResourceCreatedCallback operator -(PhotoCapture.OnCaptureResourceCreatedCallback A_0, PhotoCapture.OnCaptureResourceCreatedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CDB RID: 7387
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CDC RID: 7388
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0;
		}

		// Token: 0x020008A6 RID: 2214
		public sealed class OnPhotoModeStartedCallback : MulticastDelegate
		{
			// Token: 0x06002F24 RID: 12068 RVA: 0x000158FD File Offset: 0x00013AFD
			// Note: this type is marked as 'beforefieldinit'.
			static OnPhotoModeStartedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStartedCallback");
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100664805);
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100664806);
			}

			// Token: 0x06002F25 RID: 12069 RVA: 0x0006D3D0 File Offset: 0x0006B5D0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPhotoModeStartedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F26 RID: 12070 RVA: 0x0006D42C File Offset: 0x0006B62C
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79700, XrefRangeStart = 79684, XrefRangeEnd = 79689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F27 RID: 12071 RVA: 0x0001593B File Offset: 0x00013B3B
			public OnPhotoModeStartedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F28 RID: 12072 RVA: 0x00015944 File Offset: 0x00013B44
			public static implicit operator PhotoCapture.OnPhotoModeStartedCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStartedCallback>(A_0);
			}

			// Token: 0x06002F29 RID: 12073 RVA: 0x0001594C File Offset: 0x00013B4C
			public static PhotoCapture.OnPhotoModeStartedCallback operator +(PhotoCapture.OnPhotoModeStartedCallback A_0, PhotoCapture.OnPhotoModeStartedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnPhotoModeStartedCallback>();
			}

			// Token: 0x06002F2A RID: 12074 RVA: 0x0001595A File Offset: 0x00013B5A
			public static PhotoCapture.OnPhotoModeStartedCallback operator -(PhotoCapture.OnPhotoModeStartedCallback A_0, PhotoCapture.OnPhotoModeStartedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnPhotoModeStartedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CDD RID: 7389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CDE RID: 7390
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x020008A7 RID: 2215
		public sealed class OnPhotoModeStoppedCallback : MulticastDelegate
		{
			// Token: 0x06002F2B RID: 12075 RVA: 0x0001596B File Offset: 0x00013B6B
			// Note: this type is marked as 'beforefieldinit'.
			static OnPhotoModeStoppedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStoppedCallback");
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100664807);
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100664808);
			}

			// Token: 0x06002F2C RID: 12076 RVA: 0x0006D46C File Offset: 0x0006B66C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPhotoModeStoppedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F2D RID: 12077 RVA: 0x0006D4C8 File Offset: 0x0006B6C8
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79700, XrefRangeStart = 79689, XrefRangeEnd = 79700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F2E RID: 12078 RVA: 0x000159A9 File Offset: 0x00013BA9
			public OnPhotoModeStoppedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F2F RID: 12079 RVA: 0x000159B2 File Offset: 0x00013BB2
			public static implicit operator PhotoCapture.OnPhotoModeStoppedCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStoppedCallback>(A_0);
			}

			// Token: 0x06002F30 RID: 12080 RVA: 0x000159BA File Offset: 0x00013BBA
			public static PhotoCapture.OnPhotoModeStoppedCallback operator +(PhotoCapture.OnPhotoModeStoppedCallback A_0, PhotoCapture.OnPhotoModeStoppedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
			}

			// Token: 0x06002F31 RID: 12081 RVA: 0x000159C8 File Offset: 0x00013BC8
			public static PhotoCapture.OnPhotoModeStoppedCallback operator -(PhotoCapture.OnPhotoModeStoppedCallback A_0, PhotoCapture.OnPhotoModeStoppedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CDF RID: 7391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CE0 RID: 7392
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x020008A8 RID: 2216
		public sealed class OnCapturedToDiskCallback : MulticastDelegate
		{
			// Token: 0x06002F32 RID: 12082 RVA: 0x000159D9 File Offset: 0x00013BD9
			// Note: this type is marked as 'beforefieldinit'.
			static OnCapturedToDiskCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToDiskCallback");
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100664809);
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100664810);
			}

			// Token: 0x06002F33 RID: 12083 RVA: 0x0006D508 File Offset: 0x0006B708
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCapturedToDiskCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F34 RID: 12084 RVA: 0x0006D564 File Offset: 0x0006B764
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79700, XrefRangeStart = 79689, XrefRangeEnd = 79700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F35 RID: 12085 RVA: 0x00015A17 File Offset: 0x00013C17
			public OnCapturedToDiskCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F36 RID: 12086 RVA: 0x00015A20 File Offset: 0x00013C20
			public static implicit operator PhotoCapture.OnCapturedToDiskCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToDiskCallback>(A_0);
			}

			// Token: 0x06002F37 RID: 12087 RVA: 0x00015A28 File Offset: 0x00013C28
			public static PhotoCapture.OnCapturedToDiskCallback operator +(PhotoCapture.OnCapturedToDiskCallback A_0, PhotoCapture.OnCapturedToDiskCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCapturedToDiskCallback>();
			}

			// Token: 0x06002F38 RID: 12088 RVA: 0x00015A36 File Offset: 0x00013C36
			public static PhotoCapture.OnCapturedToDiskCallback operator -(PhotoCapture.OnCapturedToDiskCallback A_0, PhotoCapture.OnCapturedToDiskCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCapturedToDiskCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CE1 RID: 7393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CE2 RID: 7394
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x020008A9 RID: 2217
		public sealed class OnCapturedToMemoryCallback : MulticastDelegate
		{
			// Token: 0x06002F39 RID: 12089 RVA: 0x00015A47 File Offset: 0x00013C47
			// Note: this type is marked as 'beforefieldinit'.
			static OnCapturedToMemoryCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToMemoryCallback");
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100664811);
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100664812);
			}

			// Token: 0x06002F3A RID: 12090 RVA: 0x0006D5A4 File Offset: 0x0006B7A4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCapturedToMemoryCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F3B RID: 12091 RVA: 0x0006D600 File Offset: 0x0006B800
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79705, RefRangeEnd = 79706, XrefRangeStart = 79700, XrefRangeEnd = 79705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(photoCaptureFrame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F3C RID: 12092 RVA: 0x00015A85 File Offset: 0x00013C85
			public OnCapturedToMemoryCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F3D RID: 12093 RVA: 0x00015A8E File Offset: 0x00013C8E
			public static implicit operator PhotoCapture.OnCapturedToMemoryCallback(Action<PhotoCapture.PhotoCaptureResult, PhotoCaptureFrame> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToMemoryCallback>(A_0);
			}

			// Token: 0x06002F3E RID: 12094 RVA: 0x00015A96 File Offset: 0x00013C96
			public static PhotoCapture.OnCapturedToMemoryCallback operator +(PhotoCapture.OnCapturedToMemoryCallback A_0, PhotoCapture.OnCapturedToMemoryCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCapturedToMemoryCallback>();
			}

			// Token: 0x06002F3F RID: 12095 RVA: 0x00015AA4 File Offset: 0x00013CA4
			public static PhotoCapture.OnCapturedToMemoryCallback operator -(PhotoCapture.OnCapturedToMemoryCallback A_0, PhotoCapture.OnCapturedToMemoryCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCapturedToMemoryCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CE3 RID: 7395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CE4 RID: 7396
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0;
		}

		// Token: 0x020008AA RID: 2218
		// (Invoke) Token: 0x06002F41 RID: 12097
		private delegate IntPtr GetSupportedResolutions_InternalDelegate();

		// Token: 0x020008AB RID: 2219
		// (Invoke) Token: 0x06002F43 RID: 12099
		private delegate IntPtr Instantiate_InternalDelegate(bool showHolograms, IntPtr onCreatedCallback);

		// Token: 0x020008AC RID: 2220
		// (Invoke) Token: 0x06002F45 RID: 12101
		private delegate void StopPhotoModeAsyncDelegate(IntPtr @this, IntPtr onPhotoModeStoppedCallback);

		// Token: 0x020008AD RID: 2221
		// (Invoke) Token: 0x06002F47 RID: 12103
		private delegate void CapturePhotoToDisk_InternalDelegate(IntPtr @this, IntPtr filename, PhotoCaptureFileOutputFormat fileOutputFormat, IntPtr onCapturedPhotoToDiskCallback);

		// Token: 0x020008AE RID: 2222
		// (Invoke) Token: 0x06002F49 RID: 12105
		private delegate void CapturePhotoToMemory_InternalDelegate(IntPtr @this, IntPtr onCapturedPhotoToMemoryCallback);

		// Token: 0x020008AF RID: 2223
		// (Invoke) Token: 0x06002F4B RID: 12107
		private delegate IntPtr GetUnsafePointerToVideoDeviceControllerDelegate(IntPtr @this);
	}
}
