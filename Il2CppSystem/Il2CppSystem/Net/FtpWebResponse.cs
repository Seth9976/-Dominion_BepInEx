using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net
{
	// Token: 0x0200010B RID: 267
	public class FtpWebResponse : WebResponse
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x0004CE60 File Offset: 0x0004B060
		// Note: this type is marked as 'beforefieldinit'.
		static FtpWebResponse()
		{
			Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpWebResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr);
			FtpWebResponse.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "stream");
			FtpWebResponse.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "uri");
			FtpWebResponse.NativeFieldInfoPtr_statusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "statusCode");
			FtpWebResponse.NativeFieldInfoPtr_lastModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "lastModified");
			FtpWebResponse.NativeFieldInfoPtr_bannerMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "bannerMessage");
			FtpWebResponse.NativeFieldInfoPtr_welcomeMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "welcomeMessage");
			FtpWebResponse.NativeFieldInfoPtr_exitMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "exitMessage");
			FtpWebResponse.NativeFieldInfoPtr_statusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "statusDescription");
			FtpWebResponse.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "method");
			FtpWebResponse.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "disposed");
			FtpWebResponse.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "request");
			FtpWebResponse.NativeFieldInfoPtr_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "contentLength");
			FtpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665543);
			FtpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_FtpStatusCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665544);
			FtpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665545);
			FtpWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665546);
			FtpWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665547);
			FtpWebResponse.NativeMethodInfoPtr_set_LastModified_Internal_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665548);
			FtpWebResponse.NativeMethodInfoPtr_set_BannerMessage_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665549);
			FtpWebResponse.NativeMethodInfoPtr_set_WelcomeMessage_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665550);
			FtpWebResponse.NativeMethodInfoPtr_set_StatusCode_Internal_set_Void_FtpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665551);
			FtpWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665552);
			FtpWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665553);
			FtpWebResponse.NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665554);
			FtpWebResponse.NativeMethodInfoPtr_UpdateStatus_Internal_Void_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665555);
			FtpWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665556);
			FtpWebResponse.NativeMethodInfoPtr_IsFinal_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100665557);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0004D0AC File Offset: 0x0004B2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51402, XrefRangeEnd = 51411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebResponse(FtpWebRequest request, Uri uri, string method, bool keepAlive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAlive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0004D12C File Offset: 0x0004B32C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 51420, RefRangeEnd = 51423, XrefRangeStart = 51411, XrefRangeEnd = 51420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebResponse(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref statusCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_FtpStatusCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0004D1BC File Offset: 0x0004B3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51423, XrefRangeEnd = 51424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebResponse(FtpWebRequest request, Uri uri, string method, FtpStatus status)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_FtpStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0004D240 File Offset: 0x0004B440
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51424, XrefRangeEnd = 51428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0004D28C File Offset: 0x0004B48C
		public unsafe override Uri ResponseUri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x0004D2D8 File Offset: 0x0004B4D8
		public unsafe DateTime LastModified
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_set_LastModified_Internal_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FE RID: 1278
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x0004D318 File Offset: 0x0004B518
		public unsafe string BannerMessage
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_set_BannerMessage_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FF RID: 1279
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x0004D35C File Offset: 0x0004B55C
		public unsafe string WelcomeMessage
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_set_WelcomeMessage_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000500 RID: 1280
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x0004D3A0 File Offset: 0x0004B5A0
		public unsafe FtpStatusCode StatusCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_set_StatusCode_Internal_set_Void_FtpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0004D3E0 File Offset: 0x0004B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51428, XrefRangeEnd = 51433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0004D41C File Offset: 0x0004B61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51433, XrefRangeEnd = 51440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x17000501 RID: 1281
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x0004D468 File Offset: 0x0004B668
		public unsafe Stream Stream
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0004D4AC File Offset: 0x0004B6AC
		[CallerCount(0)]
		public unsafe void UpdateStatus(FtpStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_UpdateStatus_Internal_Void_FtpStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0004D4F0 File Offset: 0x0004B6F0
		[CallerCount(0)]
		public unsafe void CheckDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0004D524 File Offset: 0x0004B724
		[CallerCount(0)]
		public unsafe bool IsFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_IsFinal_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000085C4 File Offset: 0x000067C4
		public FtpWebResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0004D560 File Offset: 0x0004B760
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x000085CD File Offset: 0x000067CD
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x0004D590 File Offset: 0x0004B790
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x000085EC File Offset: 0x000067EC
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x0004D5C0 File Offset: 0x0004B7C0
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x0000860B File Offset: 0x0000680B
		public unsafe FtpStatusCode statusCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_statusCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_statusCode)) = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0004D5E8 File Offset: 0x0004B7E8
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x00008626 File Offset: 0x00006826
		public unsafe DateTime lastModified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_lastModified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_lastModified)) = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x0004D610 File Offset: 0x0004B810
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00008641 File Offset: 0x00006841
		public unsafe string bannerMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_bannerMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_bannerMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x0004D638 File Offset: 0x0004B838
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00008660 File Offset: 0x00006860
		public unsafe string welcomeMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_welcomeMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_welcomeMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x0004D660 File Offset: 0x0004B860
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x0000867F File Offset: 0x0000687F
		public unsafe string exitMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_exitMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_exitMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0004D688 File Offset: 0x0004B888
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x0000869E File Offset: 0x0000689E
		public unsafe string statusDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_statusDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_statusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0004D6B0 File Offset: 0x0004B8B0
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x000086BD File Offset: 0x000068BD
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0004D6D8 File Offset: 0x0004B8D8
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x000086DC File Offset: 0x000068DC
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0004D700 File Offset: 0x0004B900
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x000086F7 File Offset: 0x000068F7
		public unsafe FtpWebRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0004D730 File Offset: 0x0004B930
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x00008716 File Offset: 0x00006916
		public unsafe long contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr_contentLength)) = value;
			}
		}

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_statusCode;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_lastModified;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeFieldInfoPtr_bannerMessage;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeFieldInfoPtr_welcomeMessage;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeFieldInfoPtr_exitMessage;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr_statusDescription;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeFieldInfoPtr_contentLength;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_Boolean_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_FtpStatusCode_String_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Uri_String_FtpStatus_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_set_LastModified_Internal_set_Void_DateTime_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_set_BannerMessage_Internal_set_Void_String_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_set_WelcomeMessage_Internal_set_Void_String_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Internal_set_Void_FtpStatusCode_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStatus_Internal_Void_FtpStatus_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Private_Void_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_IsFinal_Internal_Boolean_0;
	}
}
