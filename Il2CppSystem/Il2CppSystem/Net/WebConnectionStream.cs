using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net
{
	// Token: 0x02000119 RID: 281
	public class WebConnectionStream : Stream
	{
		// Token: 0x06001226 RID: 4646 RVA: 0x00054104 File Offset: 0x00052304
		// Note: this type is marked as 'beforefieldinit'.
		static WebConnectionStream()
		{
			Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebConnectionStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr);
			WebConnectionStream.NativeFieldInfoPtr_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "closed");
			WebConnectionStream.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "disposed");
			WebConnectionStream.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "locker");
			WebConnectionStream.NativeFieldInfoPtr_read_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "read_timeout");
			WebConnectionStream.NativeFieldInfoPtr_write_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "write_timeout");
			WebConnectionStream.NativeFieldInfoPtr_IgnoreIOErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "IgnoreIOErrors");
			WebConnectionStream.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "<Request>k__BackingField");
			WebConnectionStream.NativeFieldInfoPtr__Connection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "<Connection>k__BackingField");
			WebConnectionStream.NativeFieldInfoPtr__Operation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "<Operation>k__BackingField");
			WebConnectionStream.NativeFieldInfoPtr__InnerStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, "<InnerStream>k__BackingField");
			WebConnectionStream.NativeMethodInfoPtr__ctor_Protected_Void_WebConnection_WebOperation_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665811);
			WebConnectionStream.NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665812);
			WebConnectionStream.NativeMethodInfoPtr_get_Connection_Internal_get_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665813);
			WebConnectionStream.NativeMethodInfoPtr_get_Operation_Internal_get_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665814);
			WebConnectionStream.NativeMethodInfoPtr_get_ServicePoint_Internal_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665815);
			WebConnectionStream.NativeMethodInfoPtr_get_InnerStream_Internal_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665816);
			WebConnectionStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665817);
			WebConnectionStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665818);
			WebConnectionStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665819);
			WebConnectionStream.NativeMethodInfoPtr_GetException_Protected_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665820);
			WebConnectionStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665821);
			WebConnectionStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665822);
			WebConnectionStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665823);
			WebConnectionStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665824);
			WebConnectionStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665825);
			WebConnectionStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665826);
			WebConnectionStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665827);
			WebConnectionStream.NativeMethodInfoPtr_InternalClose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665828);
			WebConnectionStream.NativeMethodInfoPtr_Close_internal_Protected_Abstract_Virtual_New_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665829);
			WebConnectionStream.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665830);
			WebConnectionStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665831);
			WebConnectionStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665832);
			WebConnectionStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665833);
			WebConnectionStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr, 100665834);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000543DC File Offset: 0x000525DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53959, RefRangeEnd = 53961, XrefRangeStart = 53951, XrefRangeEnd = 53959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebConnectionStream(WebConnection cnc, WebOperation operation, Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cnc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionStream.NativeMethodInfoPtr__ctor_Protected_Void_WebConnection_WebOperation_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x0005444C File Offset: 0x0005264C
		public unsafe HttpWebRequest Request
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionStream.NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0005448C File Offset: 0x0005268C
		public unsafe WebConnection Connection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionStream.NativeMethodInfoPtr_get_Connection_Internal_get_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr3) : null;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000544CC File Offset: 0x000526CC
		public unsafe WebOperation Operation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionStream.NativeMethodInfoPtr_get_Operation_Internal_get_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr3) : null;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0005450C File Offset: 0x0005270C
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53961, RefRangeEnd = 53962, XrefRangeStart = 53961, XrefRangeEnd = 53961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionStream.NativeMethodInfoPtr_get_ServicePoint_Internal_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0005454C File Offset: 0x0005274C
		public unsafe Stream InnerStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionStream.NativeMethodInfoPtr_get_InnerStream_Internal_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0005458C File Offset: 0x0005278C
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x000545D4 File Offset: 0x000527D4
		public unsafe override int ReadTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00054620 File Offset: 0x00052820
		public unsafe override int WriteTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00054668 File Offset: 0x00052868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53974, RefRangeEnd = 53975, XrefRangeStart = 53962, XrefRangeEnd = 53974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GetException(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionStream.NativeMethodInfoPtr_GetException_Protected_Exception_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000546B8 File Offset: 0x000528B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53975, XrefRangeEnd = 53984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0005472C File Offset: 0x0005292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53984, XrefRangeEnd = 54016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback cb, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000547CC File Offset: 0x000529CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54016, XrefRangeEnd = 54019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00054824 File Offset: 0x00052A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54019, XrefRangeEnd = 54050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback cb, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000548C4 File Offset: 0x00052AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54050, XrefRangeEnd = 54051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00054914 File Offset: 0x00052B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54051, XrefRangeEnd = 54054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00054980 File Offset: 0x00052B80
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000549BC File Offset: 0x00052BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54054, RefRangeEnd = 54055, XrefRangeStart = 54054, XrefRangeEnd = 54054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionStream.NativeMethodInfoPtr_InternalClose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000549F0 File Offset: 0x00052BF0
		[CallerCount(0)]
		public unsafe virtual void Close_internal(ref bool disposed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &disposed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_Close_internal_Protected_Abstract_Virtual_New_Void_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00054A3C File Offset: 0x00052C3C
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00054A78 File Offset: 0x00052C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54055, XrefRangeEnd = 54060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long a, SeekOrigin b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00054ADC File Offset: 0x00052CDC
		public unsafe override bool CanSeek
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x00054B24 File Offset: 0x00052D24
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x00054B6C File Offset: 0x00052D6C
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54060, XrefRangeEnd = 54065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54065, XrefRangeEnd = 54070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebConnectionStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00009627 File Offset: 0x00007827
		public WebConnectionStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00054BB8 File Offset: 0x00052DB8
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00009630 File Offset: 0x00007830
		public unsafe bool closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_closed)) = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00054BE0 File Offset: 0x00052DE0
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x0000964B File Offset: 0x0000784B
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00054C08 File Offset: 0x00052E08
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00009666 File Offset: 0x00007866
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00054C38 File Offset: 0x00052E38
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x00009685 File Offset: 0x00007885
		public unsafe int read_timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_read_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_read_timeout)) = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00054C60 File Offset: 0x00052E60
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x000096A0 File Offset: 0x000078A0
		public unsafe int write_timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_write_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_write_timeout)) = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00054C88 File Offset: 0x00052E88
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x000096BB File Offset: 0x000078BB
		public unsafe bool IgnoreIOErrors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_IgnoreIOErrors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr_IgnoreIOErrors)) = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00054CB0 File Offset: 0x00052EB0
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x000096D6 File Offset: 0x000078D6
		public unsafe HttpWebRequest _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00054CE0 File Offset: 0x00052EE0
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x000096F5 File Offset: 0x000078F5
		public unsafe WebConnection _Connection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr__Connection_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr__Connection_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00054D10 File Offset: 0x00052F10
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x00009714 File Offset: 0x00007914
		public unsafe WebOperation _Operation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr__Operation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr__Operation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00054D40 File Offset: 0x00052F40
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x00009733 File Offset: 0x00007933
		public unsafe Stream _InnerStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr__InnerStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionStream.NativeFieldInfoPtr__InnerStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeFieldInfoPtr_closed;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeFieldInfoPtr_read_timeout;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeFieldInfoPtr_write_timeout;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreIOErrors;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeFieldInfoPtr__Connection_k__BackingField;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeFieldInfoPtr__Operation_k__BackingField;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeFieldInfoPtr__InnerStream_k__BackingField;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_WebConnection_WebOperation_Stream_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_get_Connection_Internal_get_WebConnection_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_get_Operation_Internal_get_WebOperation_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Internal_get_ServicePoint_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerStream_Internal_get_Stream_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Protected_Exception_Exception_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_InternalClose_Internal_Void_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Protected_Abstract_Virtual_New_Void_byref_Boolean_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;
	}
}
