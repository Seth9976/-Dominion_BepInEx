using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x020000F5 RID: 245
	public sealed class PhotoCaptureFrame : Object
	{
		// Token: 0x060014F8 RID: 5368 RVA: 0x0004FE98 File Offset: 0x0004E098
		// Note: this type is marked as 'beforefieldinit'.
		static PhotoCaptureFrame()
		{
			Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "PhotoCaptureFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr);
			PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "m_NativePtr");
			PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<dataLength>k__BackingField");
			PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<hasLocationData>k__BackingField");
			PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<pixelFormat>k__BackingField");
			PhotoCaptureFrame.NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664813);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664814);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664815);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664816);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664817);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664818);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664819);
			PhotoCaptureFrame.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664821);
			PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664822);
			PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664823);
			PhotoCaptureFrame.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100664824);
			PhotoCaptureFrame.UploadImageDataToTexture_InternalDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.UploadImageDataToTexture_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::UploadImageDataToTexture_Internal");
			PhotoCaptureFrame.GetUnsafePointerToBufferDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetUnsafePointerToBufferDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetUnsafePointerToBuffer");
			PhotoCaptureFrame.CopyRawImageDataIntoBuffer_InternalDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.CopyRawImageDataIntoBuffer_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::CopyRawImageDataIntoBuffer_Internal");
			PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetCameraToWorldMatrix_Injected");
			PhotoCaptureFrame.GetProjection_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetProjection_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetProjection_Injected");
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00050040 File Offset: 0x0004E240
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0005007C File Offset: 0x0004E27C
		public unsafe int dataLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x0000C18F File Offset: 0x0000A38F
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x000500BC File Offset: 0x0004E2BC
		public unsafe bool hasLocationData
		{
			get
			{
				return this._hasLocationData_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0000C197 File Offset: 0x0000A397
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x000500FC File Offset: 0x0004E2FC
		public unsafe CapturePixelFormat pixelFormat
		{
			get
			{
				return this._pixelFormat_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0005013C File Offset: 0x0004E33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79788, XrefRangeEnd = 79790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00050178 File Offset: 0x0004E378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79790, XrefRangeEnd = 79803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHasLocationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000501B4 File Offset: 0x0004E3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79803, XrefRangeEnd = 79805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CapturePixelFormat GetCapturePixelFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000501F0 File Offset: 0x0004E3F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79813, RefRangeEnd = 79815, XrefRangeStart = 79805, XrefRangeEnd = 79813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00050224 File Offset: 0x0004E424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79815, XrefRangeEnd = 79817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00050258 File Offset: 0x0004E458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79817, XrefRangeEnd = 79822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0005028C File Offset: 0x0004E48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79822, XrefRangeEnd = 79826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0000C11A File Offset: 0x0000A31A
		public PhotoCaptureFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x000502C0 File Offset: 0x0004E4C0
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x0000C123 File Offset: 0x0000A323
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000502E8 File Offset: 0x0004E4E8
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x0000C13E File Offset: 0x0000A33E
		public unsafe int _dataLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField)) = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x00050310 File Offset: 0x0004E510
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x0000C159 File Offset: 0x0000A359
		public unsafe bool _hasLocationData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField)) = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00050338 File Offset: 0x0004E538
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x0000C174 File Offset: 0x0000A374
		public unsafe CapturePixelFormat _pixelFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField)) = value;
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00050360 File Offset: 0x0004E560
		public bool TryGetCameraToWorldMatrix(out Matrix4x4 cameraToWorldMatrix)
		{
			cameraToWorldMatrix = Matrix4x4.identity;
			bool hasLocationData = this.hasLocationData;
			bool flag;
			if (hasLocationData)
			{
				cameraToWorldMatrix = this.GetCameraToWorldMatrix();
				flag = true;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0005039C File Offset: 0x0004E59C
		public Matrix4x4 GetCameraToWorldMatrix()
		{
			Matrix4x4 matrix4x;
			this.GetCameraToWorldMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000503B4 File Offset: 0x0004E5B4
		public bool TryGetProjectionMatrix(out Matrix4x4 projectionMatrix)
		{
			bool hasLocationData = this.hasLocationData;
			bool flag;
			if (hasLocationData)
			{
				projectionMatrix = this.GetProjection();
				flag = true;
			}
			else
			{
				projectionMatrix = Matrix4x4.identity;
				flag = false;
			}
			return flag;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000503F0 File Offset: 0x0004E5F0
		public bool TryGetProjectionMatrix(float nearClipPlane, float farClipPlane, out Matrix4x4 projectionMatrix)
		{
			bool hasLocationData = this.hasLocationData;
			bool flag3;
			if (hasLocationData)
			{
				float num = 0.01f;
				bool flag = nearClipPlane < num;
				if (flag)
				{
					nearClipPlane = num;
				}
				bool flag2 = farClipPlane < nearClipPlane + num;
				if (flag2)
				{
					farClipPlane = nearClipPlane + num;
				}
				projectionMatrix = this.GetProjection();
				float num2 = 1f / (farClipPlane - nearClipPlane);
				float num3 = -(farClipPlane + nearClipPlane) * num2;
				float num4 = -(2f * farClipPlane * nearClipPlane) * num2;
				projectionMatrix.m22 = num3;
				projectionMatrix.m23 = num4;
				flag3 = true;
			}
			else
			{
				projectionMatrix = Matrix4x4.identity;
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00050484 File Offset: 0x0004E684
		public Matrix4x4 GetProjection()
		{
			Matrix4x4 matrix4x;
			this.GetProjection_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0005049C File Offset: 0x0004E69C
		public void UploadImageDataToTexture(Texture2D targetTexture)
		{
			bool flag = targetTexture == null;
			if (flag)
			{
				throw new ArgumentNullException("targetTexture");
			}
			bool flag2 = this.pixelFormat > CapturePixelFormat.BGRA32;
			if (flag2)
			{
				throw new ArgumentException("Uploading PhotoCaptureFrame to a texture is only supported with BGRA32 CameraFrameFormat!");
			}
			this.UploadImageDataToTexture_Internal(targetTexture);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0000C19F File Offset: 0x0000A39F
		public void UploadImageDataToTexture_Internal(Texture2D targetTexture)
		{
			PhotoCaptureFrame.UploadImageDataToTexture_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetTexture));
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0000C1B7 File Offset: 0x0000A3B7
		public IntPtr GetUnsafePointerToBuffer()
		{
			return PhotoCaptureFrame.GetUnsafePointerToBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0000C1C9 File Offset: 0x0000A3C9
		public void CopyRawImageDataIntoBuffer(List<byte> byteBuffer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
		public void CopyRawImageDataIntoBuffer_Internal([Out] Il2CppStructArray<byte> byteArray)
		{
			PhotoCaptureFrame.CopyRawImageDataIntoBuffer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(byteArray));
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0000C1EE File Offset: 0x0000A3EE
		public void GetCameraToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0000C201 File Offset: 0x0000A401
		public void GetProjection_Injected(out Matrix4x4 ret)
		{
			PhotoCaptureFrame.GetProjection_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeFieldInfoPtr__dataLength_k__BackingField;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeFieldInfoPtr__hasLocationData_k__BackingField;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeFieldInfoPtr__pixelFormat_k__BackingField;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_GetDataLength_Private_Int32_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly PhotoCaptureFrame.UploadImageDataToTexture_InternalDelegate UploadImageDataToTexture_InternalDelegateField;

		// Token: 0x04000FA8 RID: 4008
		private static readonly PhotoCaptureFrame.GetUnsafePointerToBufferDelegate GetUnsafePointerToBufferDelegateField;

		// Token: 0x04000FA9 RID: 4009
		private static readonly PhotoCaptureFrame.CopyRawImageDataIntoBuffer_InternalDelegate CopyRawImageDataIntoBuffer_InternalDelegateField;

		// Token: 0x04000FAA RID: 4010
		private static readonly PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegate GetCameraToWorldMatrix_InjectedDelegateField;

		// Token: 0x04000FAB RID: 4011
		private static readonly PhotoCaptureFrame.GetProjection_InjectedDelegate GetProjection_InjectedDelegateField;

		// Token: 0x020008B0 RID: 2224
		// (Invoke) Token: 0x06002F4D RID: 12109
		private delegate void UploadImageDataToTexture_InternalDelegate(IntPtr @this, IntPtr targetTexture);

		// Token: 0x020008B1 RID: 2225
		// (Invoke) Token: 0x06002F4F RID: 12111
		private delegate IntPtr GetUnsafePointerToBufferDelegate(IntPtr @this);

		// Token: 0x020008B2 RID: 2226
		// (Invoke) Token: 0x06002F51 RID: 12113
		private delegate void CopyRawImageDataIntoBuffer_InternalDelegate(IntPtr @this, [Out] IntPtr byteArray);

		// Token: 0x020008B3 RID: 2227
		// (Invoke) Token: 0x06002F53 RID: 12115
		private delegate void GetCameraToWorldMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020008B4 RID: 2228
		// (Invoke) Token: 0x06002F55 RID: 12117
		private delegate void GetProjection_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
