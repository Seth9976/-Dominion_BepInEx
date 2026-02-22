using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011D RID: 285
	public class WebResponseStream : WebConnectionStream
	{
		// Token: 0x060012F6 RID: 4854 RVA: 0x00057310 File Offset: 0x00055510
		// Note: this type is marked as 'beforefieldinit'.
		static WebResponseStream()
		{
			Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebResponseStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr);
			WebResponseStream.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "readBuffer");
			WebResponseStream.NativeFieldInfoPtr_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "contentLength");
			WebResponseStream.NativeFieldInfoPtr_totalRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "totalRead");
			WebResponseStream.NativeFieldInfoPtr_nextReadCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "nextReadCalled");
			WebResponseStream.NativeFieldInfoPtr_stream_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "stream_length");
			WebResponseStream.NativeFieldInfoPtr_pendingRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "pendingRead");
			WebResponseStream.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "locker");
			WebResponseStream.NativeFieldInfoPtr_nestedRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "nestedRead");
			WebResponseStream.NativeFieldInfoPtr_read_eof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "read_eof");
			WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<RequestStream>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<Headers>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<StatusCode>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<StatusDescription>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<Version>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<KeepAlive>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ChunkedRead>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__ChunkStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ChunkStream>k__BackingField");
			WebResponseStream.NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665934);
			WebResponseStream.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665935);
			WebResponseStream.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665936);
			WebResponseStream.NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665937);
			WebResponseStream.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665938);
			WebResponseStream.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665939);
			WebResponseStream.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665940);
			WebResponseStream.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665941);
			WebResponseStream.NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665942);
			WebResponseStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665943);
			WebResponseStream.NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665944);
			WebResponseStream.NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665945);
			WebResponseStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665946);
			WebResponseStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665947);
			WebResponseStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665948);
			WebResponseStream.NativeMethodInfoPtr_get_ChunkedRead_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665949);
			WebResponseStream.NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665950);
			WebResponseStream.NativeMethodInfoPtr_get_ChunkStream_Protected_get_MonoChunkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665951);
			WebResponseStream.NativeMethodInfoPtr_set_ChunkStream_Private_set_Void_MonoChunkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665952);
			WebResponseStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665953);
			WebResponseStream.NativeMethodInfoPtr_ProcessRead_Private_Task_1_ValueTuple_2_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665954);
			WebResponseStream.NativeMethodInfoPtr_InnerReadAsync_Internal_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665955);
			WebResponseStream.NativeMethodInfoPtr_EnsureReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665956);
			WebResponseStream.NativeMethodInfoPtr_CheckAuthHeader_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665957);
			WebResponseStream.NativeMethodInfoPtr_IsNtlmAuth_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665958);
			WebResponseStream.NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665959);
			WebResponseStream.NativeMethodInfoPtr_Initialize_Private_Task_BufferOffsetSize_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665960);
			WebResponseStream.NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665961);
			WebResponseStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665962);
			WebResponseStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665963);
			WebResponseStream.NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665964);
			WebResponseStream.NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665965);
			WebResponseStream.NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100665966);
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00057728 File Offset: 0x00055928
		public unsafe WebRequestStream RequestStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr3) : null;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00057768 File Offset: 0x00055968
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x000577A8 File Offset: 0x000559A8
		public unsafe WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x000577EC File Offset: 0x000559EC
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x00057828 File Offset: 0x00055A28
		public unsafe HttpStatusCode StatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00057868 File Offset: 0x00055A68
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x000578A0 File Offset: 0x00055AA0
		public unsafe string StatusDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x000578E4 File Offset: 0x00055AE4
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00057924 File Offset: 0x00055B24
		public unsafe Version Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00057968 File Offset: 0x00055B68
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x000579A4 File Offset: 0x00055BA4
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000579E4 File Offset: 0x00055BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55414, RefRangeEnd = 55415, XrefRangeStart = 55408, XrefRangeEnd = 55414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebResponseStream(WebRequestStream request)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x00057A30 File Offset: 0x00055C30
		public unsafe override long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00057A78 File Offset: 0x00055C78
		public unsafe override bool CanRead
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00057AC0 File Offset: 0x00055CC0
		public unsafe override bool CanWrite
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00057B08 File Offset: 0x00055D08
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x00057B44 File Offset: 0x00055D44
		public unsafe bool ChunkedRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_ChunkedRead_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00057B84 File Offset: 0x00055D84
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x00057BC4 File Offset: 0x00055DC4
		public unsafe MonoChunkStream ChunkStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_ChunkStream_Protected_get_MonoChunkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoChunkStream>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_ChunkStream_Private_set_Void_MonoChunkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00057C08 File Offset: 0x00055E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55415, XrefRangeEnd = 55427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00057C98 File Offset: 0x00055E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55439, RefRangeEnd = 55440, XrefRangeStart = 55427, XrefRangeEnd = 55439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<int, int>> ProcessRead(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_ProcessRead_Private_Task_1_ValueTuple_2_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<int, int>>>(intPtr3) : null;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00057D1C File Offset: 0x00055F1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 55452, RefRangeEnd = 55455, XrefRangeStart = 55440, XrefRangeEnd = 55452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> InnerReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_InnerReadAsync_Internal_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00057DA0 File Offset: 0x00055FA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55467, RefRangeEnd = 55468, XrefRangeStart = 55455, XrefRangeEnd = 55467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> EnsureReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_EnsureReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00057E24 File Offset: 0x00056024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55470, RefRangeEnd = 55471, XrefRangeStart = 55468, XrefRangeEnd = 55470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAuthHeader(string headerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(headerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_CheckAuthHeader_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00057E74 File Offset: 0x00056074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55478, RefRangeEnd = 55479, XrefRangeStart = 55471, XrefRangeEnd = 55478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNtlmAuth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_IsNtlmAuth_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00057EB0 File Offset: 0x000560B0
		public unsafe bool ExpectContent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55482, RefRangeEnd = 55484, XrefRangeStart = 55479, XrefRangeEnd = 55482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00057EEC File Offset: 0x000560EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55492, RefRangeEnd = 55493, XrefRangeStart = 55484, XrefRangeEnd = 55492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Initialize(BufferOffsetSize buffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_Initialize_Private_Task_BufferOffsetSize_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00057F54 File Offset: 0x00056154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55501, RefRangeEnd = 55502, XrefRangeStart = 55493, XrefRangeEnd = 55501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadAllAsync(bool resending, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resending;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00057FB8 File Offset: 0x000561B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55502, XrefRangeEnd = 55512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00058048 File Offset: 0x00056248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55512, XrefRangeEnd = 55516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close_internal(ref bool disposed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &disposed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00058094 File Offset: 0x00056294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55553, RefRangeEnd = 55554, XrefRangeStart = 55516, XrefRangeEnd = 55553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException GetReadException(WebExceptionStatus status, Exception error, string where)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(where);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00058104 File Offset: 0x00056304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55562, RefRangeEnd = 55563, XrefRangeStart = 55554, XrefRangeEnd = 55562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InitReadAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0005815C File Offset: 0x0005635C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55640, RefRangeEnd = 55641, XrefRangeStart = 55563, XrefRangeEnd = 55640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00009C3A File Offset: 0x00007E3A
		public WebResponseStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x000581C8 File Offset: 0x000563C8
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x00009C43 File Offset: 0x00007E43
		public unsafe BufferOffsetSize readBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_readBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_readBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x000581F8 File Offset: 0x000563F8
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x00009C62 File Offset: 0x00007E62
		public unsafe long contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_contentLength)) = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00058220 File Offset: 0x00056420
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x00009C7D File Offset: 0x00007E7D
		public unsafe long totalRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_totalRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_totalRead)) = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x00058248 File Offset: 0x00056448
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x00009C98 File Offset: 0x00007E98
		public unsafe bool nextReadCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nextReadCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nextReadCalled)) = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x00058270 File Offset: 0x00056470
		// (set) Token: 0x06001322 RID: 4898 RVA: 0x00009CB3 File Offset: 0x00007EB3
		public unsafe int stream_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_stream_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_stream_length)) = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x00058298 File Offset: 0x00056498
		// (set) Token: 0x06001324 RID: 4900 RVA: 0x00009CCE File Offset: 0x00007ECE
		public unsafe WebCompletionSource pendingRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_pendingRead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_pendingRead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x000582C8 File Offset: 0x000564C8
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x00009CED File Offset: 0x00007EED
		public new unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x000582F8 File Offset: 0x000564F8
		// (set) Token: 0x06001328 RID: 4904 RVA: 0x00009D0C File Offset: 0x00007F0C
		public unsafe int nestedRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nestedRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nestedRead)) = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x00058320 File Offset: 0x00056520
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x00009D27 File Offset: 0x00007F27
		public unsafe bool read_eof
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_read_eof);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_read_eof)) = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00058348 File Offset: 0x00056548
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x00009D42 File Offset: 0x00007F42
		public unsafe WebRequestStream _RequestStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00058378 File Offset: 0x00056578
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x00009D61 File Offset: 0x00007F61
		public unsafe WebHeaderCollection _Headers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000583A8 File Offset: 0x000565A8
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x00009D80 File Offset: 0x00007F80
		public unsafe HttpStatusCode _StatusCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000583D0 File Offset: 0x000565D0
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x00009D9B File Offset: 0x00007F9B
		public unsafe string _StatusDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x000583F8 File Offset: 0x000565F8
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x00009DBA File Offset: 0x00007FBA
		public unsafe Version _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x00058428 File Offset: 0x00056628
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x00009DD9 File Offset: 0x00007FD9
		public unsafe bool _KeepAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00058450 File Offset: 0x00056650
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x00009DF4 File Offset: 0x00007FF4
		public unsafe bool _ChunkedRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField)) = value;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00058478 File Offset: 0x00056678
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00009E0F File Offset: 0x0000800F
		public unsafe MonoChunkStream _ChunkStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoChunkStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeFieldInfoPtr_contentLength;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeFieldInfoPtr_totalRead;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeFieldInfoPtr_nextReadCalled;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeFieldInfoPtr_stream_length;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeFieldInfoPtr_pendingRead;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeFieldInfoPtr_nestedRead;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeFieldInfoPtr_read_eof;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeFieldInfoPtr__RequestStream_k__BackingField;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeFieldInfoPtr__Headers_k__BackingField;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeFieldInfoPtr__StatusCode_k__BackingField;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeFieldInfoPtr__StatusDescription_k__BackingField;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeFieldInfoPtr__KeepAlive_k__BackingField;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeFieldInfoPtr__ChunkedRead_k__BackingField;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeFieldInfoPtr__ChunkStream_k__BackingField;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkedRead_Protected_get_Boolean_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkStream_Protected_get_MonoChunkStream_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkStream_Private_set_Void_MonoChunkStream_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRead_Private_Task_1_ValueTuple_2_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_InnerReadAsync_Internal_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_EnsureReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthHeader_Private_Boolean_String_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_IsNtlmAuth_Private_Boolean_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Task_BufferOffsetSize_CancellationToken_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0;

		// Token: 0x020001E4 RID: 484
		[ObfuscatedName("System.Net.WebResponseStream+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Object
		{
			// Token: 0x06001B1B RID: 6939 RVA: 0x0006FD00 File Offset: 0x0006DF00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr);
				WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, "<>4__this");
				WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, "buffer");
				WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, "offset");
				WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, "size");
				WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, 100665967);
				WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ReadAsync_b__0_Internal_Task_1_ValueTuple_2_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, 100665968);
				WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ReadAsync_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr, 100665969);
			}

			// Token: 0x06001B1C RID: 6940 RVA: 0x0006FDB8 File Offset: 0x0006DFB8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B1D RID: 6941 RVA: 0x0006FDF4 File Offset: 0x0006DFF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55022, XrefRangeEnd = 55023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<ValueTuple<int, int>> _ReadAsync_b__0(CancellationToken ct)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ReadAsync_b__0_Internal_Task_1_ValueTuple_2_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<int, int>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B1E RID: 6942 RVA: 0x0006FE4C File Offset: 0x0006E04C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55023, XrefRangeEnd = 55026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReadAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass48_0.NativeMethodInfoPtr__ReadAsync_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B1F RID: 6943 RVA: 0x0000EEBA File Offset: 0x0000D0BA
			public __c__DisplayClass48_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0006FE80 File Offset: 0x0006E080
			// (set) Token: 0x06001B21 RID: 6945 RVA: 0x0000EEC3 File Offset: 0x0000D0C3
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0006FEB0 File Offset: 0x0006E0B0
			// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0000EEE2 File Offset: 0x0000D0E2
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BD RID: 2237
			// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0006FEE0 File Offset: 0x0006E0E0
			// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0000EF01 File Offset: 0x0000D101
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170008BE RID: 2238
			// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0006FF08 File Offset: 0x0006E108
			// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0000EF1C File Offset: 0x0000D11C
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass48_0.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x040014D3 RID: 5331
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014D4 RID: 5332
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040014D5 RID: 5333
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040014D6 RID: 5334
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040014D7 RID: 5335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014D8 RID: 5336
			private static readonly IntPtr NativeMethodInfoPtr__ReadAsync_b__0_Internal_Task_1_ValueTuple_2_Int32_Int32_CancellationToken_0;

			// Token: 0x040014D9 RID: 5337
			private static readonly IntPtr NativeMethodInfoPtr__ReadAsync_b__1_Internal_Void_0;
		}

		// Token: 0x020001E5 RID: 485
		[ObfuscatedName("System.Net.WebResponseStream+<ReadAsync>d__48")]
		public sealed class _ReadAsync_d__48 : ValueType
		{
			// Token: 0x06001B28 RID: 6952 RVA: 0x0006FF30 File Offset: 0x0006E130
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsync_d__48()
			{
				Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ReadAsync>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr);
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>1__state");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>4__this");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "buffer");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "offset");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "size");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__completion_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<completion>5__1");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>8__2");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__throwMe_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<throwMe>5__3");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__oldBytes_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<oldBytes>5__4");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__nbytes_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<nbytes>5__5");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>u__1");
				WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, "<>u__2");
				WebResponseStream._ReadAsync_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, 100665970);
				WebResponseStream._ReadAsync_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr, 100665971);
			}

			// Token: 0x06001B29 RID: 6953 RVA: 0x0007009C File Offset: 0x0006E29C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55026, XrefRangeEnd = 55101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAsync_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B2A RID: 6954 RVA: 0x000700D4 File Offset: 0x0006E2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55101, XrefRangeEnd = 55104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAsync_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B2B RID: 6955 RVA: 0x0000EF37 File Offset: 0x0000D137
			public _ReadAsync_d__48(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B2C RID: 6956 RVA: 0x0000EF40 File Offset: 0x0000D140
			public _ReadAsync_d__48()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__48>.NativeClassPtr))
			{
			}

			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0007011C File Offset: 0x0006E31C
			// (set) Token: 0x06001B2E RID: 6958 RVA: 0x0000EF52 File Offset: 0x0000D152
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00070144 File Offset: 0x0006E344
			// (set) Token: 0x06001B30 RID: 6960 RVA: 0x0000EF6D File Offset: 0x0000D16D
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C1 RID: 2241
			// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00070174 File Offset: 0x0006E374
			// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0000EF9B File Offset: 0x0000D19B
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x06001B33 RID: 6963 RVA: 0x000701A4 File Offset: 0x0006E3A4
			// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0000EFBA File Offset: 0x0000D1BA
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x06001B35 RID: 6965 RVA: 0x000701D4 File Offset: 0x0006E3D4
			// (set) Token: 0x06001B36 RID: 6966 RVA: 0x0000EFD9 File Offset: 0x0000D1D9
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x06001B37 RID: 6967 RVA: 0x000701FC File Offset: 0x0006E3FC
			// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00070224 File Offset: 0x0006E424
			// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0000F00F File Offset: 0x0000D20F
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00070254 File Offset: 0x0006E454
			// (set) Token: 0x06001B3C RID: 6972 RVA: 0x0000F03D File Offset: 0x0000D23D
			public unsafe WebCompletionSource _completion_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__completion_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__completion_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00070284 File Offset: 0x0006E484
			// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0000F05C File Offset: 0x0000D25C
			public unsafe WebResponseStream.__c__DisplayClass48_0 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream.__c__DisplayClass48_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06001B3F RID: 6975 RVA: 0x000702B4 File Offset: 0x0006E4B4
			// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0000F07B File Offset: 0x0000D27B
			public unsafe Exception _throwMe_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__throwMe_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__throwMe_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x06001B41 RID: 6977 RVA: 0x000702E4 File Offset: 0x0006E4E4
			// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0000F09A File Offset: 0x0000D29A
			public unsafe int _oldBytes_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__oldBytes_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__oldBytes_5__4)) = value;
				}
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x06001B43 RID: 6979 RVA: 0x0007030C File Offset: 0x0006E50C
			// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0000F0B5 File Offset: 0x0000D2B5
			public unsafe int _nbytes_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__nbytes_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr__nbytes_5__5)) = value;
				}
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00070334 File Offset: 0x0006E534
			// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00070364 File Offset: 0x0006E564
			// (set) Token: 0x06001B48 RID: 6984 RVA: 0x0000F0FE File Offset: 0x0000D2FE
			public ConfiguredTaskAwaitable<ValueTuple<int, int>>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<ValueTuple<int, int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<int, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__48.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<int, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014DA RID: 5338
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014DB RID: 5339
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014DC RID: 5340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014DD RID: 5341
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040014DE RID: 5342
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040014DF RID: 5343
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040014E0 RID: 5344
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014E1 RID: 5345
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__1;

			// Token: 0x040014E2 RID: 5346
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x040014E3 RID: 5347
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__3;

			// Token: 0x040014E4 RID: 5348
			private static readonly IntPtr NativeFieldInfoPtr__oldBytes_5__4;

			// Token: 0x040014E5 RID: 5349
			private static readonly IntPtr NativeFieldInfoPtr__nbytes_5__5;

			// Token: 0x040014E6 RID: 5350
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014E7 RID: 5351
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040014E8 RID: 5352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014E9 RID: 5353
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E6 RID: 486
		[ObfuscatedName("System.Net.WebResponseStream+<ProcessRead>d__49")]
		public sealed class _ProcessRead_d__49 : ValueType
		{
			// Token: 0x06001B49 RID: 6985 RVA: 0x00070394 File Offset: 0x0006E594
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessRead_d__49()
			{
				Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ProcessRead>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr);
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<>1__state");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<>4__this");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "size");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "buffer");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "offset");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr__oldBytes_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<oldBytes>5__1");
				WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, "<>u__1");
				WebResponseStream._ProcessRead_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, 100665972);
				WebResponseStream._ProcessRead_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr, 100665973);
			}

			// Token: 0x06001B4A RID: 6986 RVA: 0x0007049C File Offset: 0x0006E69C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55104, XrefRangeEnd = 55140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ProcessRead_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B4B RID: 6987 RVA: 0x000704D4 File Offset: 0x0006E6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55140, XrefRangeEnd = 55143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ProcessRead_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B4C RID: 6988 RVA: 0x0000F12C File Offset: 0x0000D32C
			public _ProcessRead_d__49(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B4D RID: 6989 RVA: 0x0000F135 File Offset: 0x0000D335
			public _ProcessRead_d__49()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ProcessRead_d__49>.NativeClassPtr))
			{
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0007051C File Offset: 0x0006E71C
			// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0000F147 File Offset: 0x0000D347
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00070544 File Offset: 0x0006E744
			// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0000F162 File Offset: 0x0000D362
			public AsyncTaskMethodBuilder<ValueTuple<int, int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<int, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<int, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<int, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x06001B52 RID: 6994 RVA: 0x00070574 File Offset: 0x0006E774
			// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0000F190 File Offset: 0x0000D390
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x06001B54 RID: 6996 RVA: 0x000705A4 File Offset: 0x0006E7A4
			// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0000F1BE File Offset: 0x0000D3BE
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06001B56 RID: 6998 RVA: 0x000705D4 File Offset: 0x0006E7D4
			// (set) Token: 0x06001B57 RID: 6999 RVA: 0x0000F1DD File Offset: 0x0000D3DD
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x06001B58 RID: 7000 RVA: 0x000705FC File Offset: 0x0006E7FC
			// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0007062C File Offset: 0x0006E82C
			// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0000F217 File Offset: 0x0000D417
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x06001B5C RID: 7004 RVA: 0x00070654 File Offset: 0x0006E854
			// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0000F232 File Offset: 0x0000D432
			public unsafe int _oldBytes_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr__oldBytes_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr__oldBytes_5__1)) = value;
				}
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0007067C File Offset: 0x0006E87C
			// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0000F24D File Offset: 0x0000D44D
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ProcessRead_d__49.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014EA RID: 5354
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014EB RID: 5355
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014EC RID: 5356
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014ED RID: 5357
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014EE RID: 5358
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040014EF RID: 5359
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040014F0 RID: 5360
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040014F1 RID: 5361
			private static readonly IntPtr NativeFieldInfoPtr__oldBytes_5__1;

			// Token: 0x040014F2 RID: 5362
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014F3 RID: 5363
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014F4 RID: 5364
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E7 RID: 487
		[ObfuscatedName("System.Net.WebResponseStream+<InnerReadAsync>d__50")]
		public sealed class _InnerReadAsync_d__50 : ValueType
		{
			// Token: 0x06001B60 RID: 7008 RVA: 0x000706AC File Offset: 0x0006E8AC
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerReadAsync_d__50()
			{
				Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<InnerReadAsync>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr);
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<>1__state");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<>t__builder");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<>4__this");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "cancellationToken");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "buffer");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "offset");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "size");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__done_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<done>5__1");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__nbytes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<nbytes>5__2");
				WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, "<>u__1");
				WebResponseStream._InnerReadAsync_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, 100665974);
				WebResponseStream._InnerReadAsync_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr, 100665975);
			}

			// Token: 0x06001B61 RID: 7009 RVA: 0x000707C8 File Offset: 0x0006E9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55143, XrefRangeEnd = 55176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InnerReadAsync_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B62 RID: 7010 RVA: 0x00070800 File Offset: 0x0006EA00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55176, XrefRangeEnd = 55179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InnerReadAsync_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B63 RID: 7011 RVA: 0x0000F27B File Offset: 0x0000D47B
			public _InnerReadAsync_d__50(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B64 RID: 7012 RVA: 0x0000F284 File Offset: 0x0000D484
			public _InnerReadAsync_d__50()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._InnerReadAsync_d__50>.NativeClassPtr))
			{
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00070848 File Offset: 0x0006EA48
			// (set) Token: 0x06001B66 RID: 7014 RVA: 0x0000F296 File Offset: 0x0000D496
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00070870 File Offset: 0x0006EA70
			// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0000F2B1 File Offset: 0x0000D4B1
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x06001B69 RID: 7017 RVA: 0x000708A0 File Offset: 0x0006EAA0
			// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0000F2DF File Offset: 0x0000D4DF
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x06001B6B RID: 7019 RVA: 0x000708D0 File Offset: 0x0006EAD0
			// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0000F2FE File Offset: 0x0000D4FE
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00070900 File Offset: 0x0006EB00
			// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0000F32C File Offset: 0x0000D52C
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x06001B6F RID: 7023 RVA: 0x00070930 File Offset: 0x0006EB30
			// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0000F34B File Offset: 0x0000D54B
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00070958 File Offset: 0x0006EB58
			// (set) Token: 0x06001B72 RID: 7026 RVA: 0x0000F366 File Offset: 0x0000D566
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06001B73 RID: 7027 RVA: 0x00070980 File Offset: 0x0006EB80
			// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0000F381 File Offset: 0x0000D581
			public unsafe bool _done_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__done_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__done_5__1)) = value;
				}
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000709A8 File Offset: 0x0006EBA8
			// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0000F39C File Offset: 0x0000D59C
			public unsafe int _nbytes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__nbytes_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr__nbytes_5__2)) = value;
				}
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x06001B77 RID: 7031 RVA: 0x000709D0 File Offset: 0x0006EBD0
			// (set) Token: 0x06001B78 RID: 7032 RVA: 0x0000F3B7 File Offset: 0x0000D5B7
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InnerReadAsync_d__50.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014F5 RID: 5365
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014F6 RID: 5366
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014F7 RID: 5367
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014F8 RID: 5368
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014F9 RID: 5369
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040014FA RID: 5370
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040014FB RID: 5371
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040014FC RID: 5372
			private static readonly IntPtr NativeFieldInfoPtr__done_5__1;

			// Token: 0x040014FD RID: 5373
			private static readonly IntPtr NativeFieldInfoPtr__nbytes_5__2;

			// Token: 0x040014FE RID: 5374
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014FF RID: 5375
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001500 RID: 5376
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E8 RID: 488
		[ObfuscatedName("System.Net.WebResponseStream+<EnsureReadAsync>d__51")]
		public sealed class _EnsureReadAsync_d__51 : ValueType
		{
			// Token: 0x06001B79 RID: 7033 RVA: 0x00070A00 File Offset: 0x0006EC00
			// Note: this type is marked as 'beforefieldinit'.
			static _EnsureReadAsync_d__51()
			{
				Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<EnsureReadAsync>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr);
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<>1__state");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<>t__builder");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<>4__this");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__morebytes_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<morebytes>5__1");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "cancellationToken");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__nbytes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<nbytes>5__2");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "buffer");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "offset");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "size");
				WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, "<>u__1");
				WebResponseStream._EnsureReadAsync_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, 100665976);
				WebResponseStream._EnsureReadAsync_d__51.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr, 100665977);
			}

			// Token: 0x06001B7A RID: 7034 RVA: 0x00070B1C File Offset: 0x0006ED1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55179, XrefRangeEnd = 55209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._EnsureReadAsync_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B7B RID: 7035 RVA: 0x00070B54 File Offset: 0x0006ED54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55209, XrefRangeEnd = 55212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._EnsureReadAsync_d__51.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B7C RID: 7036 RVA: 0x0000F3E5 File Offset: 0x0000D5E5
			public _EnsureReadAsync_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B7D RID: 7037 RVA: 0x0000F3EE File Offset: 0x0000D5EE
			public _EnsureReadAsync_d__51()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._EnsureReadAsync_d__51>.NativeClassPtr))
			{
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00070B9C File Offset: 0x0006ED9C
			// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0000F400 File Offset: 0x0000D600
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x06001B80 RID: 7040 RVA: 0x00070BC4 File Offset: 0x0006EDC4
			// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0000F41B File Offset: 0x0000D61B
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x06001B82 RID: 7042 RVA: 0x00070BF4 File Offset: 0x0006EDF4
			// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0000F449 File Offset: 0x0000D649
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00070C24 File Offset: 0x0006EE24
			// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0000F468 File Offset: 0x0000D668
			public unsafe Il2CppStructArray<byte> _morebytes_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__morebytes_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__morebytes_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x06001B86 RID: 7046 RVA: 0x00070C54 File Offset: 0x0006EE54
			// (set) Token: 0x06001B87 RID: 7047 RVA: 0x0000F487 File Offset: 0x0000D687
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00070C84 File Offset: 0x0006EE84
			// (set) Token: 0x06001B89 RID: 7049 RVA: 0x0000F4B5 File Offset: 0x0000D6B5
			public unsafe int _nbytes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__nbytes_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr__nbytes_5__2)) = value;
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00070CAC File Offset: 0x0006EEAC
			// (set) Token: 0x06001B8B RID: 7051 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00070CDC File Offset: 0x0006EEDC
			// (set) Token: 0x06001B8D RID: 7053 RVA: 0x0000F4EF File Offset: 0x0000D6EF
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x06001B8E RID: 7054 RVA: 0x00070D04 File Offset: 0x0006EF04
			// (set) Token: 0x06001B8F RID: 7055 RVA: 0x0000F50A File Offset: 0x0000D70A
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x06001B90 RID: 7056 RVA: 0x00070D2C File Offset: 0x0006EF2C
			// (set) Token: 0x06001B91 RID: 7057 RVA: 0x0000F525 File Offset: 0x0000D725
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._EnsureReadAsync_d__51.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001501 RID: 5377
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001502 RID: 5378
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001503 RID: 5379
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001504 RID: 5380
			private static readonly IntPtr NativeFieldInfoPtr__morebytes_5__1;

			// Token: 0x04001505 RID: 5381
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001506 RID: 5382
			private static readonly IntPtr NativeFieldInfoPtr__nbytes_5__2;

			// Token: 0x04001507 RID: 5383
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04001508 RID: 5384
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04001509 RID: 5385
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x0400150A RID: 5386
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400150B RID: 5387
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400150C RID: 5388
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E9 RID: 489
		[ObfuscatedName("System.Net.WebResponseStream+<Initialize>d__56")]
		public sealed class _Initialize_d__56 : ValueType
		{
			// Token: 0x06001B92 RID: 7058 RVA: 0x00070D5C File Offset: 0x0006EF5C
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__56()
			{
				Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<Initialize>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr);
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<>1__state");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<>t__builder");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<>4__this");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "buffer");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "cancellationToken");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr__me_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<me>5__1");
				WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, "<>u__1");
				WebResponseStream._Initialize_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, 100665978);
				WebResponseStream._Initialize_d__56.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr, 100665979);
			}

			// Token: 0x06001B93 RID: 7059 RVA: 0x00070E3C File Offset: 0x0006F03C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55212, XrefRangeEnd = 55274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._Initialize_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B94 RID: 7060 RVA: 0x00070E74 File Offset: 0x0006F074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._Initialize_d__56.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B95 RID: 7061 RVA: 0x0000F553 File Offset: 0x0000D753
			public _Initialize_d__56(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B96 RID: 7062 RVA: 0x0000F55C File Offset: 0x0000D75C
			public _Initialize_d__56()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._Initialize_d__56>.NativeClassPtr))
			{
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06001B97 RID: 7063 RVA: 0x00070EBC File Offset: 0x0006F0BC
			// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0000F56E File Offset: 0x0000D76E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06001B99 RID: 7065 RVA: 0x00070EE4 File Offset: 0x0006F0E4
			// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0000F589 File Offset: 0x0000D789
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x06001B9B RID: 7067 RVA: 0x00070F14 File Offset: 0x0006F114
			// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x06001B9D RID: 7069 RVA: 0x00070F44 File Offset: 0x0006F144
			// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0000F5D6 File Offset: 0x0000D7D6
			public unsafe BufferOffsetSize buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06001B9F RID: 7071 RVA: 0x00070F74 File Offset: 0x0006F174
			// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0000F5F5 File Offset: 0x0000D7F5
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00070FA4 File Offset: 0x0006F1A4
			// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0000F623 File Offset: 0x0000D823
			public unsafe string _me_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr__me_5__1);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr__me_5__1), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00070FCC File Offset: 0x0006F1CC
			// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0000F642 File Offset: 0x0000D842
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._Initialize_d__56.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400150D RID: 5389
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400150E RID: 5390
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400150F RID: 5391
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001510 RID: 5392
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04001511 RID: 5393
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001512 RID: 5394
			private static readonly IntPtr NativeFieldInfoPtr__me_5__1;

			// Token: 0x04001513 RID: 5395
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001514 RID: 5396
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001515 RID: 5397
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001EA RID: 490
		[ObfuscatedName("System.Net.WebResponseStream+<ReadAllAsync>d__57")]
		public sealed class _ReadAllAsync_d__57 : ValueType
		{
			// Token: 0x06001BA5 RID: 7077 RVA: 0x00070FFC File Offset: 0x0006F1FC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAllAsync_d__57()
			{
				Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ReadAllAsync>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr);
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>1__state");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>4__this");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__completion_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<completion>5__1");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__timeoutTask_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<timeoutTask>5__2");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_resending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "resending");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__ms_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<ms>5__3");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__buffer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<buffer>5__4");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__read_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<read>5__5");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__b_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<b>5__6");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__remaining_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<remaining>5__7");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__readSize_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<readSize>5__8");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__new_size_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<new_size>5__9");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>u__1");
				WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, "<>u__2");
				WebResponseStream._ReadAllAsync_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, 100665980);
				WebResponseStream._ReadAllAsync_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr, 100665981);
			}

			// Token: 0x06001BA6 RID: 7078 RVA: 0x00071190 File Offset: 0x0006F390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55274, XrefRangeEnd = 55369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAllAsync_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA7 RID: 7079 RVA: 0x000711C8 File Offset: 0x0006F3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAllAsync_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BA8 RID: 7080 RVA: 0x0000F670 File Offset: 0x0000D870
			public _ReadAllAsync_d__57(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BA9 RID: 7081 RVA: 0x0000F679 File Offset: 0x0000D879
			public _ReadAllAsync_d__57()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__57>.NativeClassPtr))
			{
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00071210 File Offset: 0x0006F410
			// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0000F68B File Offset: 0x0000D88B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00071238 File Offset: 0x0006F438
			// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0000F6A6 File Offset: 0x0000D8A6
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00071268 File Offset: 0x0006F468
			// (set) Token: 0x06001BAF RID: 7087 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00071298 File Offset: 0x0006F498
			// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x0000F6F3 File Offset: 0x0000D8F3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x000712C8 File Offset: 0x0006F4C8
			// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0000F721 File Offset: 0x0000D921
			public unsafe WebCompletionSource _completion_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__completion_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__completion_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x000712F8 File Offset: 0x0006F4F8
			// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0000F740 File Offset: 0x0000D940
			public unsafe Task _timeoutTask_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__timeoutTask_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__timeoutTask_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00071328 File Offset: 0x0006F528
			// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0000F75F File Offset: 0x0000D95F
			public unsafe bool resending
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_resending);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr_resending)) = value;
				}
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00071350 File Offset: 0x0006F550
			// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0000F77A File Offset: 0x0000D97A
			public unsafe MemoryStream _ms_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__ms_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__ms_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00071380 File Offset: 0x0006F580
			// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0000F799 File Offset: 0x0000D999
			public unsafe BufferOffsetSize _buffer_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__buffer_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__buffer_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x06001BBC RID: 7100 RVA: 0x000713B0 File Offset: 0x0006F5B0
			// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0000F7B8 File Offset: 0x0000D9B8
			public unsafe int _read_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__read_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__read_5__5)) = value;
				}
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x06001BBE RID: 7102 RVA: 0x000713D8 File Offset: 0x0006F5D8
			// (set) Token: 0x06001BBF RID: 7103 RVA: 0x0000F7D3 File Offset: 0x0000D9D3
			public unsafe Il2CppStructArray<byte> _b_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__b_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__b_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00071408 File Offset: 0x0006F608
			// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x0000F7F2 File Offset: 0x0000D9F2
			public unsafe int _remaining_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__remaining_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__remaining_5__7)) = value;
				}
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00071430 File Offset: 0x0006F630
			// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0000F80D File Offset: 0x0000DA0D
			public unsafe int _readSize_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__readSize_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__readSize_5__8)) = value;
				}
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00071458 File Offset: 0x0006F658
			// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x0000F828 File Offset: 0x0000DA28
			public unsafe int _new_size_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__new_size_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr__new_size_5__9)) = value;
				}
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00071480 File Offset: 0x0006F680
			// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0000F843 File Offset: 0x0000DA43
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x000714B0 File Offset: 0x0006F6B0
			// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0000F871 File Offset: 0x0000DA71
			public TaskAwaiter<int> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__57.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001516 RID: 5398
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001517 RID: 5399
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001518 RID: 5400
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001519 RID: 5401
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400151A RID: 5402
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__1;

			// Token: 0x0400151B RID: 5403
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__2;

			// Token: 0x0400151C RID: 5404
			private static readonly IntPtr NativeFieldInfoPtr_resending;

			// Token: 0x0400151D RID: 5405
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__3;

			// Token: 0x0400151E RID: 5406
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__4;

			// Token: 0x0400151F RID: 5407
			private static readonly IntPtr NativeFieldInfoPtr__read_5__5;

			// Token: 0x04001520 RID: 5408
			private static readonly IntPtr NativeFieldInfoPtr__b_5__6;

			// Token: 0x04001521 RID: 5409
			private static readonly IntPtr NativeFieldInfoPtr__remaining_5__7;

			// Token: 0x04001522 RID: 5410
			private static readonly IntPtr NativeFieldInfoPtr__readSize_5__8;

			// Token: 0x04001523 RID: 5411
			private static readonly IntPtr NativeFieldInfoPtr__new_size_5__9;

			// Token: 0x04001524 RID: 5412
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001525 RID: 5413
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001526 RID: 5414
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001527 RID: 5415
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001EB RID: 491
		[ObfuscatedName("System.Net.WebResponseStream+<InitReadAsync>d__61")]
		public sealed class _InitReadAsync_d__61 : ValueType
		{
			// Token: 0x06001BCA RID: 7114 RVA: 0x000714E0 File Offset: 0x0006F6E0
			// Note: this type is marked as 'beforefieldinit'.
			static _InitReadAsync_d__61()
			{
				Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<InitReadAsync>d__61");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr);
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>1__state");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>t__builder");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>4__this");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "cancellationToken");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<buffer>5__1");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__state_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<state>5__2");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__position_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<position>5__3");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>u__1");
				WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, "<>u__2");
				WebResponseStream._InitReadAsync_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, 100665982);
				WebResponseStream._InitReadAsync_d__61.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr, 100665983);
			}

			// Token: 0x06001BCB RID: 7115 RVA: 0x000715E8 File Offset: 0x0006F7E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55369, XrefRangeEnd = 55408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InitReadAsync_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BCC RID: 7116 RVA: 0x00071620 File Offset: 0x0006F820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InitReadAsync_d__61.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BCD RID: 7117 RVA: 0x0000F89F File Offset: 0x0000DA9F
			public _InitReadAsync_d__61(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BCE RID: 7118 RVA: 0x0000F8A8 File Offset: 0x0000DAA8
			public _InitReadAsync_d__61()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__61>.NativeClassPtr))
			{
			}

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00071668 File Offset: 0x0006F868
			// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0000F8BA File Offset: 0x0000DABA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00071690 File Offset: 0x0006F890
			// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x0000F8D5 File Offset: 0x0000DAD5
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x000716C0 File Offset: 0x0006F8C0
			// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x0000F903 File Offset: 0x0000DB03
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x000716F0 File Offset: 0x0006F8F0
			// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0000F922 File Offset: 0x0000DB22
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00071720 File Offset: 0x0006F920
			// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x0000F950 File Offset: 0x0000DB50
			public unsafe BufferOffsetSize _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__buffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__buffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00071750 File Offset: 0x0006F950
			// (set) Token: 0x06001BDA RID: 7130 RVA: 0x0000F96F File Offset: 0x0000DB6F
			public unsafe ReadState _state_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__state_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__state_5__2)) = value;
				}
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x06001BDB RID: 7131 RVA: 0x00071778 File Offset: 0x0006F978
			// (set) Token: 0x06001BDC RID: 7132 RVA: 0x0000F98A File Offset: 0x0000DB8A
			public unsafe int _position_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__position_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr__position_5__3)) = value;
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000717A0 File Offset: 0x0006F9A0
			// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0000F9A5 File Offset: 0x0000DBA5
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x06001BDF RID: 7135 RVA: 0x000717D0 File Offset: 0x0006F9D0
			// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x0000F9D3 File Offset: 0x0000DBD3
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__61.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001528 RID: 5416
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001529 RID: 5417
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400152A RID: 5418
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400152B RID: 5419
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400152C RID: 5420
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x0400152D RID: 5421
			private static readonly IntPtr NativeFieldInfoPtr__state_5__2;

			// Token: 0x0400152E RID: 5422
			private static readonly IntPtr NativeFieldInfoPtr__position_5__3;

			// Token: 0x0400152F RID: 5423
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001530 RID: 5424
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001531 RID: 5425
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001532 RID: 5426
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
