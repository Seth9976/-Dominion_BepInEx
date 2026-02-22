using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x0200010E RID: 270
	[Serializable]
	public class HttpWebResponse : WebResponse
	{
		// Token: 0x060010F5 RID: 4341 RVA: 0x0004FEA0 File Offset: 0x0004E0A0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpWebResponse()
		{
			Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpWebResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr);
			HttpWebResponse.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "uri");
			HttpWebResponse.NativeFieldInfoPtr_webHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "webHeaders");
			HttpWebResponse.NativeFieldInfoPtr_cookieCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "cookieCollection");
			HttpWebResponse.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "method");
			HttpWebResponse.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "version");
			HttpWebResponse.NativeFieldInfoPtr_statusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "statusCode");
			HttpWebResponse.NativeFieldInfoPtr_statusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "statusDescription");
			HttpWebResponse.NativeFieldInfoPtr_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "contentLength");
			HttpWebResponse.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "contentType");
			HttpWebResponse.NativeFieldInfoPtr_cookie_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "cookie_container");
			HttpWebResponse.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "disposed");
			HttpWebResponse.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "stream");
			HttpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_HttpStatusCode_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665649);
			HttpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_WebResponseStream_CookieContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665650);
			HttpWebResponse.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665651);
			HttpWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665652);
			HttpWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665653);
			HttpWebResponse.NativeMethodInfoPtr_get_StatusCode_Public_Virtual_New_get_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665654);
			HttpWebResponse.NativeMethodInfoPtr_get_StatusDescription_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665655);
			HttpWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665656);
			HttpWebResponse.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665657);
			HttpWebResponse.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665658);
			HttpWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665659);
			HttpWebResponse.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665660);
			HttpWebResponse.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665661);
			HttpWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665662);
			HttpWebResponse.NativeMethodInfoPtr_FillCookies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665663);
			HttpWebResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100665664);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00050100 File Offset: 0x0004E300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52465, XrefRangeEnd = 52471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_HttpStatusCode_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00050180 File Offset: 0x0004E380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52504, RefRangeEnd = 52505, XrefRangeStart = 52471, XrefRangeEnd = 52504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_WebResponseStream_CookieContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00050204 File Offset: 0x0004E404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52505, XrefRangeEnd = 52556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x00050268 File Offset: 0x0004E468
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x000502B4 File Offset: 0x0004E4B4
		public unsafe override Uri ResponseUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52556, XrefRangeEnd = 52557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x00050300 File Offset: 0x0004E500
		public unsafe virtual HttpStatusCode StatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_get_StatusCode_Public_Virtual_New_get_HttpStatusCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00050348 File Offset: 0x0004E548
		public unsafe virtual string StatusDescription
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52557, XrefRangeEnd = 52558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_get_StatusDescription_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0005038C File Offset: 0x0004E58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52558, XrefRangeEnd = 52563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x000503D8 File Offset: 0x0004E5D8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00050434 File Offset: 0x0004E634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52563, XrefRangeEnd = 52590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00050498 File Offset: 0x0004E698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52590, XrefRangeEnd = 52591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000504D4 File Offset: 0x0004E6D4
		[CallerCount(0)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00050508 File Offset: 0x0004E708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52591, XrefRangeEnd = 52592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00050554 File Offset: 0x0004E754
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52592, RefRangeEnd = 52595, XrefRangeStart = 52592, XrefRangeEnd = 52592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00050588 File Offset: 0x0004E788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52608, RefRangeEnd = 52609, XrefRangeStart = 52595, XrefRangeEnd = 52608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillCookies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr_FillCookies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x000505BC File Offset: 0x0004E7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52609, XrefRangeEnd = 52612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00008D57 File Offset: 0x00006F57
		public HttpWebResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x000505F8 File Offset: 0x0004E7F8
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x00008D60 File Offset: 0x00006F60
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00050628 File Offset: 0x0004E828
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00008D7F File Offset: 0x00006F7F
		public unsafe WebHeaderCollection webHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_webHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_webHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00050658 File Offset: 0x0004E858
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00008D9E File Offset: 0x00006F9E
		public unsafe CookieCollection cookieCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_cookieCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_cookieCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x00050688 File Offset: 0x0004E888
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x00008DBD File Offset: 0x00006FBD
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000506B0 File Offset: 0x0004E8B0
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00008DDC File Offset: 0x00006FDC
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000506E0 File Offset: 0x0004E8E0
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x00008DFB File Offset: 0x00006FFB
		public unsafe HttpStatusCode statusCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_statusCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_statusCode)) = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x00050708 File Offset: 0x0004E908
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x00008E16 File Offset: 0x00007016
		public unsafe string statusDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_statusDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_statusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x00050730 File Offset: 0x0004E930
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x00008E35 File Offset: 0x00007035
		public unsafe long contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_contentLength)) = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x00050758 File Offset: 0x0004E958
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x00008E50 File Offset: 0x00007050
		public unsafe string contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_contentType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_contentType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x00050780 File Offset: 0x0004E980
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x00008E6F File Offset: 0x0000706F
		public unsafe CookieContainer cookie_container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_cookie_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_cookie_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x000507B0 File Offset: 0x0004E9B0
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x00008E8E File Offset: 0x0000708E
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x000507D8 File Offset: 0x0004E9D8
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x00008EA9 File Offset: 0x000070A9
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr_webHeaders;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr_cookieCollection;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeFieldInfoPtr_statusCode;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeFieldInfoPtr_statusDescription;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeFieldInfoPtr_contentLength;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeFieldInfoPtr_cookie_container;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_HttpStatusCode_WebHeaderCollection_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_WebResponseStream_CookieContainer_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_Virtual_New_get_HttpStatusCode_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusDescription_Public_Virtual_New_get_String_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Private_Void_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_FillCookies_Private_Void_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
