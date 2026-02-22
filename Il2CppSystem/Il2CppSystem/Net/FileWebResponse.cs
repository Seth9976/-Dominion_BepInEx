using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public class FileWebResponse : WebResponse
	{
		// Token: 0x06000E8A RID: 3722 RVA: 0x00046F60 File Offset: 0x00045160
		// Note: this type is marked as 'beforefieldinit'.
		static FileWebResponse()
		{
			Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FileWebResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr);
			FileWebResponse.NativeFieldInfoPtr_m_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_closed");
			FileWebResponse.NativeFieldInfoPtr_m_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_contentLength");
			FileWebResponse.NativeFieldInfoPtr_m_fileAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_fileAccess");
			FileWebResponse.NativeFieldInfoPtr_m_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_headers");
			FileWebResponse.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_stream");
			FileWebResponse.NativeFieldInfoPtr_m_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_uri");
			FileWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FileWebRequest_Uri_FileAccess_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665329);
			FileWebResponse.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665330);
			FileWebResponse.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665331);
			FileWebResponse.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665332);
			FileWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665333);
			FileWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665334);
			FileWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665335);
			FileWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665336);
			FileWebResponse.NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665337);
			FileWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100665338);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000470D0 File Offset: 0x000452D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49189, RefRangeEnd = 49190, XrefRangeStart = 49161, XrefRangeEnd = 49189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asyncHint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FileWebRequest_Uri_FileAccess_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0004714C File Offset: 0x0004534C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49190, XrefRangeEnd = 49217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000471B0 File Offset: 0x000453B0
		[CallerCount(0)]
		public new unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0004720C File Offset: 0x0004540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49217, XrefRangeEnd = 49242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00047270 File Offset: 0x00045470
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49242, XrefRangeEnd = 49243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x000472BC File Offset: 0x000454BC
		public unsafe override Uri ResponseUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49243, XrefRangeEnd = 49244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00047308 File Offset: 0x00045508
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 49244, RefRangeEnd = 49247, XrefRangeStart = 49244, XrefRangeEnd = 49244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0004733C File Offset: 0x0004553C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49247, XrefRangeEnd = 49250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00047378 File Offset: 0x00045578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49250, XrefRangeEnd = 49262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Net_ICloseEx_CloseEx(CloseExState closeState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000473B8 File Offset: 0x000455B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49262, XrefRangeEnd = 49264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00007BA1 File Offset: 0x00005DA1
		public FileWebResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00047404 File Offset: 0x00045604
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x00007BAA File Offset: 0x00005DAA
		public unsafe bool m_closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_closed)) = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0004742C File Offset: 0x0004562C
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x00007BC5 File Offset: 0x00005DC5
		public unsafe long m_contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_contentLength)) = value;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00047454 File Offset: 0x00045654
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00007BE0 File Offset: 0x00005DE0
		public unsafe FileAccess m_fileAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_fileAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_fileAccess)) = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0004747C File Offset: 0x0004567C
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x00007BFB File Offset: 0x00005DFB
		public unsafe WebHeaderCollection m_headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x000474AC File Offset: 0x000456AC
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00007C1A File Offset: 0x00005E1A
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x000474DC File Offset: 0x000456DC
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00007C39 File Offset: 0x00005E39
		public unsafe Uri m_uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeFieldInfoPtr_m_closed;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeFieldInfoPtr_m_contentLength;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeFieldInfoPtr_m_fileAccess;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeFieldInfoPtr_m_headers;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeFieldInfoPtr_m_uri;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FileWebRequest_Uri_FileAccess_Boolean_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Private_Void_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0;
	}
}
