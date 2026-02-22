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
	// Token: 0x020000F6 RID: 246
	public class VideoCapture : Object
	{
		// Token: 0x0600151B RID: 5403 RVA: 0x000504E4 File Offset: 0x0004E6E4
		// Note: this type is marked as 'beforefieldinit'.
		static VideoCapture()
		{
			Il2CppClassPointerStore<VideoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "VideoCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr);
			VideoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "m_NativePtr");
			VideoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "HR_SUCCESS");
			VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664825);
			VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664826);
			VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664828);
			VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664829);
			VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664830);
			VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664831);
			VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664832);
			VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664833);
			VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664834);
			VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100664835);
			VideoCapture.GetSupportedResolutions_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.GetSupportedResolutions_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetSupportedResolutions_Internal");
			VideoCapture.GetSupportedFrameRatesForResolution_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.GetSupportedFrameRatesForResolution_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetSupportedFrameRatesForResolution_Internal");
			VideoCapture.get_IsRecordingDelegateField = IL2CPP.ResolveICall<VideoCapture.get_IsRecordingDelegate>("UnityEngine.Windows.WebCam.VideoCapture::get_IsRecording");
			VideoCapture.Instantiate_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.Instantiate_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::Instantiate_Internal");
			VideoCapture.StopVideoModeAsyncDelegateField = IL2CPP.ResolveICall<VideoCapture.StopVideoModeAsyncDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StopVideoModeAsync");
			VideoCapture.StartRecordingVideoToDisk_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.StartRecordingVideoToDisk_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StartRecordingVideoToDisk_Internal");
			VideoCapture.StopRecordingAsyncDelegateField = IL2CPP.ResolveICall<VideoCapture.StopRecordingAsyncDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StopRecordingAsync");
			VideoCapture.GetUnsafePointerToVideoDeviceControllerDelegateField = IL2CPP.ResolveICall<VideoCapture.GetUnsafePointerToVideoDeviceControllerDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetUnsafePointerToVideoDeviceController");
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0005067C File Offset: 0x0004E87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79826, XrefRangeEnd = 79830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000506BC File Offset: 0x0004E8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79830, XrefRangeEnd = 79837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00050700 File Offset: 0x0004E900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79837, XrefRangeEnd = 79845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00050744 File Offset: 0x0004E944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79845, XrefRangeEnd = 79853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00050788 File Offset: 0x0004E988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79853, XrefRangeEnd = 79861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000507CC File Offset: 0x0004E9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79861, XrefRangeEnd = 79869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00050810 File Offset: 0x0004EA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79869, XrefRangeEnd = 79877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00050844 File Offset: 0x0004EA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79877, XrefRangeEnd = 79879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00050878 File Offset: 0x0004EA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79879, XrefRangeEnd = 79886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000508B4 File Offset: 0x0004EAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79886, XrefRangeEnd = 79888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeThreaded_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0000C214 File Offset: 0x0000A414
		public VideoCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x000508E8 File Offset: 0x0004EAE8
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x0000C21D File Offset: 0x0000A41D
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x00050910 File Offset: 0x0004EB10
		// (set) Token: 0x0600152A RID: 5418 RVA: 0x0000C238 File Offset: 0x0000A438
		public unsafe static long HR_SUCCESS
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0005092C File Offset: 0x0004EB2C
		public static VideoCapture.VideoCaptureResult MakeCaptureResult(VideoCapture.CaptureResultType resultType, long hResult)
		{
			return new VideoCapture.VideoCaptureResult
			{
				resultType = resultType,
				hResult = hResult
			};
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0000C246 File Offset: 0x0000A446
		public static IEnumerable<Resolution> SupportedResolutions
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00050958 File Offset: 0x0004EB58
		public static Il2CppStructArray<Resolution> GetSupportedResolutions_Internal()
		{
			IntPtr intPtr = VideoCapture.GetSupportedResolutions_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00050980 File Offset: 0x0004EB80
		public static IEnumerable<float> GetSupportedFrameRatesForResolution(Resolution resolution)
		{
			return VideoCapture.GetSupportedFrameRatesForResolution_Internal(resolution.width, resolution.height);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000509AC File Offset: 0x0004EBAC
		public static Il2CppStructArray<float> GetSupportedFrameRatesForResolution_Internal(int resolutionWidth, int resolutionHeight)
		{
			IntPtr intPtr = VideoCapture.GetSupportedFrameRatesForResolution_InternalDelegateField(resolutionWidth, resolutionHeight);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0000C253 File Offset: 0x0000A453
		public bool IsRecording
		{
			get
			{
				return VideoCapture.get_IsRecordingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000509D4 File Offset: 0x0004EBD4
		public static void CreateAsync(bool showHolograms, VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
		{
			bool flag = onCreatedCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCreatedCallback");
			}
			showHolograms = false;
			VideoCapture.Instantiate_Internal(showHolograms, onCreatedCallback);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00050A04 File Offset: 0x0004EC04
		public static void CreateAsync(VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
		{
			bool flag = onCreatedCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCreatedCallback");
			}
			VideoCapture.Instantiate_Internal(false, onCreatedCallback);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0000C265 File Offset: 0x0000A465
		public static void Instantiate_Internal(bool showHolograms, VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
		{
			VideoCapture.Instantiate_InternalDelegateField(showHolograms, IL2CPP.Il2CppObjectBaseToPtr(onCreatedCallback));
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0000C278 File Offset: 0x0000A478
		public void StopVideoModeAsync(VideoCapture.OnVideoModeStoppedCallback onVideoModeStoppedCallback)
		{
			VideoCapture.StopVideoModeAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(onVideoModeStoppedCallback));
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00050A30 File Offset: 0x0004EC30
		public void StartRecordingAsync(string filename, VideoCapture.OnStartedRecordingVideoCallback onStartedRecordingVideoCallback)
		{
			bool flag = onStartedRecordingVideoCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onStartedRecordingVideoCallback");
			}
			bool flag2 = String.IsNullOrEmpty(filename);
			if (flag2)
			{
				throw new ArgumentNullException("filename");
			}
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
			this.StartRecordingVideoToDisk_Internal(fileInfo.FullName, onStartedRecordingVideoCallback);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0000C290 File Offset: 0x0000A490
		public void StartRecordingVideoToDisk_Internal(string filename, VideoCapture.OnStartedRecordingVideoCallback onStartedRecordingVideoCallback)
		{
			VideoCapture.StartRecordingVideoToDisk_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(filename), IL2CPP.Il2CppObjectBaseToPtr(onStartedRecordingVideoCallback));
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0000C2AE File Offset: 0x0000A4AE
		public void StopRecordingAsync(VideoCapture.OnStoppedRecordingVideoCallback onStoppedRecordingVideoCallback)
		{
			VideoCapture.StopRecordingAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(onStoppedRecordingVideoCallback));
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0000C2C6 File Offset: 0x0000A4C6
		public IntPtr GetUnsafePointerToVideoDeviceController()
		{
			return VideoCapture.GetUnsafePointerToVideoDeviceControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeFieldInfoPtr_HR_SUCCESS;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly VideoCapture.GetSupportedResolutions_InternalDelegate GetSupportedResolutions_InternalDelegateField;

		// Token: 0x04000FB9 RID: 4025
		private static readonly VideoCapture.GetSupportedFrameRatesForResolution_InternalDelegate GetSupportedFrameRatesForResolution_InternalDelegateField;

		// Token: 0x04000FBA RID: 4026
		private static readonly VideoCapture.get_IsRecordingDelegate get_IsRecordingDelegateField;

		// Token: 0x04000FBB RID: 4027
		private static readonly VideoCapture.Instantiate_InternalDelegate Instantiate_InternalDelegateField;

		// Token: 0x04000FBC RID: 4028
		private static readonly VideoCapture.StopVideoModeAsyncDelegate StopVideoModeAsyncDelegateField;

		// Token: 0x04000FBD RID: 4029
		private static readonly VideoCapture.StartRecordingVideoToDisk_InternalDelegate StartRecordingVideoToDisk_InternalDelegateField;

		// Token: 0x04000FBE RID: 4030
		private static readonly VideoCapture.StopRecordingAsyncDelegate StopRecordingAsyncDelegateField;

		// Token: 0x04000FBF RID: 4031
		private static readonly VideoCapture.GetUnsafePointerToVideoDeviceControllerDelegate GetUnsafePointerToVideoDeviceControllerDelegateField;

		// Token: 0x020008B5 RID: 2229
		public enum CaptureResultType
		{
			// Token: 0x04001CE6 RID: 7398
			Success,
			// Token: 0x04001CE7 RID: 7399
			UnknownError
		}

		// Token: 0x020008B6 RID: 2230
		[StructLayout(2)]
		public struct VideoCaptureResult
		{
			// Token: 0x06002F56 RID: 12118 RVA: 0x0006D650 File Offset: 0x0006B850
			// Note: this type is marked as 'beforefieldinit'.
			static VideoCaptureResult()
			{
				Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "VideoCaptureResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr);
				VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, "resultType");
				VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, "hResult");
			}

			// Token: 0x06002F57 RID: 12119 RVA: 0x00015AB5 File Offset: 0x00013CB5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04001CE8 RID: 7400
			private static readonly IntPtr NativeFieldInfoPtr_resultType;

			// Token: 0x04001CE9 RID: 7401
			private static readonly IntPtr NativeFieldInfoPtr_hResult;

			// Token: 0x04001CEA RID: 7402
			[FieldOffset(0)]
			public VideoCapture.CaptureResultType resultType;

			// Token: 0x04001CEB RID: 7403
			[FieldOffset(8)]
			public long hResult;
		}

		// Token: 0x020008B7 RID: 2231
		public sealed class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
		{
			// Token: 0x06002F58 RID: 12120 RVA: 0x00015AC7 File Offset: 0x00013CC7
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoCaptureResourceCreatedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoCaptureResourceCreatedCallback");
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100664837);
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100664838);
			}

			// Token: 0x06002F59 RID: 12121 RVA: 0x0006D6A4 File Offset: 0x0006B8A4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoCaptureResourceCreatedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F5A RID: 12122 RVA: 0x0006D700 File Offset: 0x0006B900
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture captureObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F5B RID: 12123 RVA: 0x00015B05 File Offset: 0x00013D05
			public OnVideoCaptureResourceCreatedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F5C RID: 12124 RVA: 0x00015B0E File Offset: 0x00013D0E
			public static implicit operator VideoCapture.OnVideoCaptureResourceCreatedCallback(Action<VideoCapture> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoCaptureResourceCreatedCallback>(A_0);
			}

			// Token: 0x06002F5D RID: 12125 RVA: 0x00015B16 File Offset: 0x00013D16
			public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator +(VideoCapture.OnVideoCaptureResourceCreatedCallback A_0, VideoCapture.OnVideoCaptureResourceCreatedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
			}

			// Token: 0x06002F5E RID: 12126 RVA: 0x00015B24 File Offset: 0x00013D24
			public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator -(VideoCapture.OnVideoCaptureResourceCreatedCallback A_0, VideoCapture.OnVideoCaptureResourceCreatedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CEC RID: 7404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CED RID: 7405
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0;
		}

		// Token: 0x020008B8 RID: 2232
		public sealed class OnVideoModeStartedCallback : MulticastDelegate
		{
			// Token: 0x06002F5F RID: 12127 RVA: 0x00015B35 File Offset: 0x00013D35
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoModeStartedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStartedCallback");
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100664839);
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100664840);
			}

			// Token: 0x06002F60 RID: 12128 RVA: 0x0006D744 File Offset: 0x0006B944
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoModeStartedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F61 RID: 12129 RVA: 0x0006D7A0 File Offset: 0x0006B9A0
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79700, XrefRangeStart = 79689, XrefRangeEnd = 79700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F62 RID: 12130 RVA: 0x00015B73 File Offset: 0x00013D73
			public OnVideoModeStartedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F63 RID: 12131 RVA: 0x00015B7C File Offset: 0x00013D7C
			public static implicit operator VideoCapture.OnVideoModeStartedCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStartedCallback>(A_0);
			}

			// Token: 0x06002F64 RID: 12132 RVA: 0x00015B84 File Offset: 0x00013D84
			public static VideoCapture.OnVideoModeStartedCallback operator +(VideoCapture.OnVideoModeStartedCallback A_0, VideoCapture.OnVideoModeStartedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoModeStartedCallback>();
			}

			// Token: 0x06002F65 RID: 12133 RVA: 0x00015B92 File Offset: 0x00013D92
			public static VideoCapture.OnVideoModeStartedCallback operator -(VideoCapture.OnVideoModeStartedCallback A_0, VideoCapture.OnVideoModeStartedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoModeStartedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CEE RID: 7406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CEF RID: 7407
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x020008B9 RID: 2233
		public sealed class OnVideoModeStoppedCallback : MulticastDelegate
		{
			// Token: 0x06002F66 RID: 12134 RVA: 0x00015BA3 File Offset: 0x00013DA3
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoModeStoppedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStoppedCallback");
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100664841);
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100664842);
			}

			// Token: 0x06002F67 RID: 12135 RVA: 0x0006D7E0 File Offset: 0x0006B9E0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoModeStoppedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F68 RID: 12136 RVA: 0x0006D83C File Offset: 0x0006BA3C
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79700, XrefRangeStart = 79689, XrefRangeEnd = 79700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F69 RID: 12137 RVA: 0x00015BE1 File Offset: 0x00013DE1
			public OnVideoModeStoppedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F6A RID: 12138 RVA: 0x00015BEA File Offset: 0x00013DEA
			public static implicit operator VideoCapture.OnVideoModeStoppedCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStoppedCallback>(A_0);
			}

			// Token: 0x06002F6B RID: 12139 RVA: 0x00015BF2 File Offset: 0x00013DF2
			public static VideoCapture.OnVideoModeStoppedCallback operator +(VideoCapture.OnVideoModeStoppedCallback A_0, VideoCapture.OnVideoModeStoppedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoModeStoppedCallback>();
			}

			// Token: 0x06002F6C RID: 12140 RVA: 0x00015C00 File Offset: 0x00013E00
			public static VideoCapture.OnVideoModeStoppedCallback operator -(VideoCapture.OnVideoModeStoppedCallback A_0, VideoCapture.OnVideoModeStoppedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoModeStoppedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CF0 RID: 7408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CF1 RID: 7409
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x020008BA RID: 2234
		public sealed class OnStartedRecordingVideoCallback : MulticastDelegate
		{
			// Token: 0x06002F6D RID: 12141 RVA: 0x00015C11 File Offset: 0x00013E11
			// Note: this type is marked as 'beforefieldinit'.
			static OnStartedRecordingVideoCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStartedRecordingVideoCallback");
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100664843);
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100664844);
			}

			// Token: 0x06002F6E RID: 12142 RVA: 0x0006D87C File Offset: 0x0006BA7C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStartedRecordingVideoCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F6F RID: 12143 RVA: 0x0006D8D8 File Offset: 0x0006BAD8
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79700, XrefRangeStart = 79689, XrefRangeEnd = 79700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F70 RID: 12144 RVA: 0x00015C4F File Offset: 0x00013E4F
			public OnStartedRecordingVideoCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F71 RID: 12145 RVA: 0x00015C58 File Offset: 0x00013E58
			public static implicit operator VideoCapture.OnStartedRecordingVideoCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnStartedRecordingVideoCallback>(A_0);
			}

			// Token: 0x06002F72 RID: 12146 RVA: 0x00015C60 File Offset: 0x00013E60
			public static VideoCapture.OnStartedRecordingVideoCallback operator +(VideoCapture.OnStartedRecordingVideoCallback A_0, VideoCapture.OnStartedRecordingVideoCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnStartedRecordingVideoCallback>();
			}

			// Token: 0x06002F73 RID: 12147 RVA: 0x00015C6E File Offset: 0x00013E6E
			public static VideoCapture.OnStartedRecordingVideoCallback operator -(VideoCapture.OnStartedRecordingVideoCallback A_0, VideoCapture.OnStartedRecordingVideoCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnStartedRecordingVideoCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CF2 RID: 7410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CF3 RID: 7411
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x020008BB RID: 2235
		public sealed class OnStoppedRecordingVideoCallback : MulticastDelegate
		{
			// Token: 0x06002F74 RID: 12148 RVA: 0x00015C7F File Offset: 0x00013E7F
			// Note: this type is marked as 'beforefieldinit'.
			static OnStoppedRecordingVideoCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStoppedRecordingVideoCallback");
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100664845);
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100664846);
			}

			// Token: 0x06002F75 RID: 12149 RVA: 0x0006D918 File Offset: 0x0006BB18
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStoppedRecordingVideoCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F76 RID: 12150 RVA: 0x0006D974 File Offset: 0x0006BB74
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79700, XrefRangeStart = 79689, XrefRangeEnd = 79700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F77 RID: 12151 RVA: 0x00015CBD File Offset: 0x00013EBD
			public OnStoppedRecordingVideoCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F78 RID: 12152 RVA: 0x00015CC6 File Offset: 0x00013EC6
			public static implicit operator VideoCapture.OnStoppedRecordingVideoCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnStoppedRecordingVideoCallback>(A_0);
			}

			// Token: 0x06002F79 RID: 12153 RVA: 0x00015CCE File Offset: 0x00013ECE
			public static VideoCapture.OnStoppedRecordingVideoCallback operator +(VideoCapture.OnStoppedRecordingVideoCallback A_0, VideoCapture.OnStoppedRecordingVideoCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
			}

			// Token: 0x06002F7A RID: 12154 RVA: 0x00015CDC File Offset: 0x00013EDC
			public static VideoCapture.OnStoppedRecordingVideoCallback operator -(VideoCapture.OnStoppedRecordingVideoCallback A_0, VideoCapture.OnStoppedRecordingVideoCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001CF4 RID: 7412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CF5 RID: 7413
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x020008BC RID: 2236
		public enum AudioState
		{
			// Token: 0x04001CF7 RID: 7415
			MicAudio,
			// Token: 0x04001CF8 RID: 7416
			ApplicationAudio,
			// Token: 0x04001CF9 RID: 7417
			ApplicationAndMicAudio,
			// Token: 0x04001CFA RID: 7418
			None
		}

		// Token: 0x020008BD RID: 2237
		// (Invoke) Token: 0x06002F7C RID: 12156
		private delegate IntPtr GetSupportedResolutions_InternalDelegate();

		// Token: 0x020008BE RID: 2238
		// (Invoke) Token: 0x06002F7E RID: 12158
		private delegate IntPtr GetSupportedFrameRatesForResolution_InternalDelegate(int resolutionWidth, int resolutionHeight);

		// Token: 0x020008BF RID: 2239
		// (Invoke) Token: 0x06002F80 RID: 12160
		private delegate bool get_IsRecordingDelegate(IntPtr @this);

		// Token: 0x020008C0 RID: 2240
		// (Invoke) Token: 0x06002F82 RID: 12162
		private delegate void Instantiate_InternalDelegate(bool showHolograms, IntPtr onCreatedCallback);

		// Token: 0x020008C1 RID: 2241
		// (Invoke) Token: 0x06002F84 RID: 12164
		private delegate void StopVideoModeAsyncDelegate(IntPtr @this, IntPtr onVideoModeStoppedCallback);

		// Token: 0x020008C2 RID: 2242
		// (Invoke) Token: 0x06002F86 RID: 12166
		private delegate void StartRecordingVideoToDisk_InternalDelegate(IntPtr @this, IntPtr filename, IntPtr onStartedRecordingVideoCallback);

		// Token: 0x020008C3 RID: 2243
		// (Invoke) Token: 0x06002F88 RID: 12168
		private delegate void StopRecordingAsyncDelegate(IntPtr @this, IntPtr onStoppedRecordingVideoCallback);

		// Token: 0x020008C4 RID: 2244
		// (Invoke) Token: 0x06002F8A RID: 12170
		private delegate IntPtr GetUnsafePointerToVideoDeviceControllerDelegate(IntPtr @this);
	}
}
