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
	// Token: 0x0200011C RID: 284
	public class WebRequestStream : WebConnectionStream
	{
		// Token: 0x060012C8 RID: 4808 RVA: 0x00056794 File Offset: 0x00054994
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestStream()
		{
			Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequestStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr);
			WebRequestStream.NativeFieldInfoPtr_crlf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "crlf");
			WebRequestStream.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "writeBuffer");
			WebRequestStream.NativeFieldInfoPtr_requestWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "requestWritten");
			WebRequestStream.NativeFieldInfoPtr_allowBuffering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "allowBuffering");
			WebRequestStream.NativeFieldInfoPtr_sendChunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "sendChunked");
			WebRequestStream.NativeFieldInfoPtr_pendingWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "pendingWrite");
			WebRequestStream.NativeFieldInfoPtr_totalWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "totalWritten");
			WebRequestStream.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "headers");
			WebRequestStream.NativeFieldInfoPtr_headersSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "headersSent");
			WebRequestStream.NativeFieldInfoPtr_completeRequestWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "completeRequestWritten");
			WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "chunkTrailerWritten");
			WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<KeepAlive>k__BackingField");
			WebRequestStream.NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665897);
			WebRequestStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665898);
			WebRequestStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665899);
			WebRequestStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665900);
			WebRequestStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665901);
			WebRequestStream.NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665902);
			WebRequestStream.NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665903);
			WebRequestStream.NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665904);
			WebRequestStream.NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665905);
			WebRequestStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665906);
			WebRequestStream.NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665907);
			WebRequestStream.NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665908);
			WebRequestStream.NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665909);
			WebRequestStream.NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665910);
			WebRequestStream.NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665911);
			WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665912);
			WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665913);
			WebRequestStream.NativeMethodInfoPtr_KillBuffer_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665914);
			WebRequestStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665915);
			WebRequestStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100665916);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00056A44 File Offset: 0x00054C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54915, RefRangeEnd = 54916, XrefRangeStart = 54896, XrefRangeEnd = 54915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tunnel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x00056AC8 File Offset: 0x00054CC8
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x00056B04 File Offset: 0x00054D04
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54916, XrefRangeEnd = 54921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x00056B4C File Offset: 0x00054D4C
		public unsafe override bool CanRead
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x00056B94 File Offset: 0x00054D94
		public unsafe override bool CanWrite
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00056BDC File Offset: 0x00054DDC
		public unsafe bool HasWriteBuffer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 54921, RefRangeEnd = 54924, XrefRangeStart = 54921, XrefRangeEnd = 54921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00056C18 File Offset: 0x00054E18
		public unsafe int WriteBufferLength
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 54924, RefRangeEnd = 54926, XrefRangeStart = 54924, XrefRangeEnd = 54924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00056C54 File Offset: 0x00054E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54930, RefRangeEnd = 54931, XrefRangeStart = 54926, XrefRangeEnd = 54930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize GetWriteBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr3) : null;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00056C94 File Offset: 0x00054E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54939, RefRangeEnd = 54941, XrefRangeStart = 54931, XrefRangeEnd = 54939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FinishWriting(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00056CEC File Offset: 0x00054EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54941, XrefRangeEnd = 54949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00056D7C File Offset: 0x00054F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54957, RefRangeEnd = 54958, XrefRangeStart = 54949, XrefRangeEnd = 54957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessWrite(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00056E00 File Offset: 0x00055000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54958, RefRangeEnd = 54959, XrefRangeStart = 54958, XrefRangeEnd = 54958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWriteOverflow(long contentLength, long totalWritten, long size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00056E5C File Offset: 0x0005505C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54967, RefRangeEnd = 54968, XrefRangeStart = 54959, XrefRangeEnd = 54967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Initialize(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00056EB4 File Offset: 0x000550B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54976, RefRangeEnd = 54978, XrefRangeStart = 54968, XrefRangeEnd = 54976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setInternalLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00056F18 File Offset: 0x00055118
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54986, RefRangeEnd = 54988, XrefRangeStart = 54978, XrefRangeEnd = 54986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteRequestAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00056F70 File Offset: 0x00055170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54996, RefRangeEnd = 54997, XrefRangeStart = 54988, XrefRangeEnd = 54996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteChunkTrailer_inner(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00056FC8 File Offset: 0x000551C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54997, XrefRangeEnd = 55005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteChunkTrailer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00057008 File Offset: 0x00055208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55005, RefRangeEnd = 55006, XrefRangeStart = 55005, XrefRangeEnd = 55005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KillBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_KillBuffer_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0005703C File Offset: 0x0005523C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55006, XrefRangeEnd = 55018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x000570CC File Offset: 0x000552CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55018, XrefRangeEnd = 55022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close_internal(ref bool disposed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &disposed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00009AEA File Offset: 0x00007CEA
		public WebRequestStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00057118 File Offset: 0x00055318
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x00009AF3 File Offset: 0x00007CF3
		public unsafe static Il2CppStructArray<byte> crlf
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequestStream.NativeFieldInfoPtr_crlf, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequestStream.NativeFieldInfoPtr_crlf, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x00057140 File Offset: 0x00055340
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x00009B05 File Offset: 0x00007D05
		public unsafe MemoryStream writeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_writeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x00057170 File Offset: 0x00055370
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x00009B24 File Offset: 0x00007D24
		public unsafe bool requestWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_requestWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_requestWritten)) = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00057198 File Offset: 0x00055398
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x00009B3F File Offset: 0x00007D3F
		public unsafe bool allowBuffering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_allowBuffering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_allowBuffering)) = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x000571C0 File Offset: 0x000553C0
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x00009B5A File Offset: 0x00007D5A
		public unsafe bool sendChunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_sendChunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_sendChunked)) = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x000571E8 File Offset: 0x000553E8
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00009B75 File Offset: 0x00007D75
		public unsafe WebCompletionSource pendingWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_pendingWrite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_pendingWrite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x00057218 File Offset: 0x00055418
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x00009B94 File Offset: 0x00007D94
		public unsafe long totalWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_totalWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_totalWritten)) = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00057240 File Offset: 0x00055440
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x00009BAF File Offset: 0x00007DAF
		public unsafe Il2CppStructArray<byte> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x00057270 File Offset: 0x00055470
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x00009BCE File Offset: 0x00007DCE
		public unsafe bool headersSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headersSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headersSent)) = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00057298 File Offset: 0x00055498
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x00009BE9 File Offset: 0x00007DE9
		public unsafe int completeRequestWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_completeRequestWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_completeRequestWritten)) = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000572C0 File Offset: 0x000554C0
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x00009C04 File Offset: 0x00007E04
		public unsafe int chunkTrailerWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten)) = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x000572E8 File Offset: 0x000554E8
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x00009C1F File Offset: 0x00007E1F
		public unsafe bool _KeepAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeFieldInfoPtr_crlf;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeFieldInfoPtr_requestWritten;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeFieldInfoPtr_allowBuffering;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeFieldInfoPtr_sendChunked;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeFieldInfoPtr_pendingWrite;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeFieldInfoPtr_totalWritten;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeFieldInfoPtr_headersSent;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeFieldInfoPtr_completeRequestWritten;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeFieldInfoPtr_chunkTrailerWritten;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeFieldInfoPtr__KeepAlive_k__BackingField;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_KillBuffer_Internal_Void_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0;

		// Token: 0x020001DC RID: 476
		[ObfuscatedName("System.Net.WebRequestStream+<FinishWriting>d__30")]
		public sealed class _FinishWriting_d__30 : ValueType
		{
			// Token: 0x06001A87 RID: 6791 RVA: 0x0006E870 File Offset: 0x0006CA70
			// Note: this type is marked as 'beforefieldinit'.
			static _FinishWriting_d__30()
			{
				Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<FinishWriting>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr);
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "<>1__state");
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "<>t__builder");
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "<>4__this");
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "cancellationToken");
				WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, "<>u__1");
				WebRequestStream._FinishWriting_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, 100665918);
				WebRequestStream._FinishWriting_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr, 100665919);
			}

			// Token: 0x06001A88 RID: 6792 RVA: 0x0006E928 File Offset: 0x0006CB28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54671, XrefRangeEnd = 54686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._FinishWriting_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A89 RID: 6793 RVA: 0x0006E960 File Offset: 0x0006CB60
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._FinishWriting_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A8A RID: 6794 RVA: 0x0000E5F7 File Offset: 0x0000C7F7
			public _FinishWriting_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A8B RID: 6795 RVA: 0x0000E600 File Offset: 0x0000C800
			public _FinishWriting_d__30()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0006E9A8 File Offset: 0x0006CBA8
			// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0000E612 File Offset: 0x0000C812
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0006E9D0 File Offset: 0x0006CBD0
			// (set) Token: 0x06001A8F RID: 6799 RVA: 0x0000E62D File Offset: 0x0000C82D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0006EA00 File Offset: 0x0006CC00
			// (set) Token: 0x06001A91 RID: 6801 RVA: 0x0000E65B File Offset: 0x0000C85B
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0006EA30 File Offset: 0x0006CC30
			// (set) Token: 0x06001A93 RID: 6803 RVA: 0x0000E67A File Offset: 0x0000C87A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0006EA60 File Offset: 0x0006CC60
			// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0000E6A8 File Offset: 0x0000C8A8
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400148D RID: 5261
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400148E RID: 5262
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400148F RID: 5263
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001490 RID: 5264
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001491 RID: 5265
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001492 RID: 5266
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001493 RID: 5267
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001DD RID: 477
		[ObfuscatedName("System.Net.WebRequestStream+<WriteAsync>d__31")]
		public sealed class _WriteAsync_d__31 : ValueType
		{
			// Token: 0x06001A96 RID: 6806 RVA: 0x0006EA90 File Offset: 0x0006CC90
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsync_d__31()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr);
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "buffer");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "offset");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "size");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr__completion_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<completion>5__1");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, 100665920);
				WebRequestStream._WriteAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr, 100665921);
			}

			// Token: 0x06001A97 RID: 6807 RVA: 0x0006EBAC File Offset: 0x0006CDAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54686, XrefRangeEnd = 54710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A98 RID: 6808 RVA: 0x0006EBE4 File Offset: 0x0006CDE4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A99 RID: 6809 RVA: 0x0000E6D6 File Offset: 0x0000C8D6
			public _WriteAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A9A RID: 6810 RVA: 0x0000E6DF File Offset: 0x0000C8DF
			public _WriteAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0006EC2C File Offset: 0x0006CE2C
			// (set) Token: 0x06001A9C RID: 6812 RVA: 0x0000E6F1 File Offset: 0x0000C8F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0006EC54 File Offset: 0x0006CE54
			// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0000E70C File Offset: 0x0000C90C
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06001A9F RID: 6815 RVA: 0x0006EC84 File Offset: 0x0006CE84
			// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x0000E73A File Offset: 0x0000C93A
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x0006ECB4 File Offset: 0x0006CEB4
			// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x0000E759 File Offset: 0x0000C959
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0006ECE4 File Offset: 0x0006CEE4
			// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x0000E787 File Offset: 0x0000C987
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0006ED14 File Offset: 0x0006CF14
			// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x0000E7A6 File Offset: 0x0000C9A6
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0006ED3C File Offset: 0x0006CF3C
			// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x0000E7C1 File Offset: 0x0000C9C1
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x0006ED64 File Offset: 0x0006CF64
			// (set) Token: 0x06001AAA RID: 6826 RVA: 0x0000E7DC File Offset: 0x0000C9DC
			public unsafe WebCompletionSource _completion_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr__completion_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr__completion_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06001AAB RID: 6827 RVA: 0x0006ED94 File Offset: 0x0006CF94
			// (set) Token: 0x06001AAC RID: 6828 RVA: 0x0000E7FB File Offset: 0x0000C9FB
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x06001AAD RID: 6829 RVA: 0x0006EDC4 File Offset: 0x0006CFC4
			// (set) Token: 0x06001AAE RID: 6830 RVA: 0x0000E829 File Offset: 0x0000CA29
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsync_d__31.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001494 RID: 5268
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001495 RID: 5269
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001496 RID: 5270
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001497 RID: 5271
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001498 RID: 5272
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04001499 RID: 5273
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x0400149A RID: 5274
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x0400149B RID: 5275
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__1;

			// Token: 0x0400149C RID: 5276
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400149D RID: 5277
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400149E RID: 5278
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400149F RID: 5279
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001DE RID: 478
		[ObfuscatedName("System.Net.WebRequestStream+<ProcessWrite>d__32")]
		public sealed class _ProcessWrite_d__32 : ValueType
		{
			// Token: 0x06001AAF RID: 6831 RVA: 0x0006EDF4 File Offset: 0x0006CFF4
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessWrite_d__32()
			{
				Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<ProcessWrite>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr);
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "<>1__state");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "<>t__builder");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "<>4__this");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "cancellationToken");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "size");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "buffer");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "offset");
				WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, "<>u__1");
				WebRequestStream._ProcessWrite_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, 100665922);
				WebRequestStream._ProcessWrite_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr, 100665923);
			}

			// Token: 0x06001AB0 RID: 6832 RVA: 0x0006EEE8 File Offset: 0x0006D0E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54710, XrefRangeEnd = 54749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._ProcessWrite_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AB1 RID: 6833 RVA: 0x0006EF20 File Offset: 0x0006D120
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._ProcessWrite_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AB2 RID: 6834 RVA: 0x0000E857 File Offset: 0x0000CA57
			public _ProcessWrite_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AB3 RID: 6835 RVA: 0x0000E860 File Offset: 0x0000CA60
			public _ProcessWrite_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0006EF68 File Offset: 0x0006D168
			// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0000E872 File Offset: 0x0000CA72
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0006EF90 File Offset: 0x0006D190
			// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0000E88D File Offset: 0x0000CA8D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0006EFC0 File Offset: 0x0006D1C0
			// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0000E8BB File Offset: 0x0000CABB
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0006EFF0 File Offset: 0x0006D1F0
			// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0000E8DA File Offset: 0x0000CADA
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0006F020 File Offset: 0x0006D220
			// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0000E908 File Offset: 0x0000CB08
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0006F048 File Offset: 0x0006D248
			// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000E923 File Offset: 0x0000CB23
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0006F078 File Offset: 0x0006D278
			// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0000E942 File Offset: 0x0000CB42
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0006F0A0 File Offset: 0x0006D2A0
			// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0000E95D File Offset: 0x0000CB5D
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014A0 RID: 5280
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014A1 RID: 5281
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014A2 RID: 5282
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014A3 RID: 5283
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014A4 RID: 5284
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040014A5 RID: 5285
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040014A6 RID: 5286
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040014A7 RID: 5287
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014A8 RID: 5288
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014A9 RID: 5289
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001DF RID: 479
		[ObfuscatedName("System.Net.WebRequestStream+<Initialize>d__34")]
		public sealed class _Initialize_d__34 : ValueType
		{
			// Token: 0x06001AC4 RID: 6852 RVA: 0x0006F0D0 File Offset: 0x0006D2D0
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__34()
			{
				Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<Initialize>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr);
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>1__state");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>t__builder");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>4__this");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "cancellationToken");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>u__1");
				WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, "<>u__2");
				WebRequestStream._Initialize_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, 100665924);
				WebRequestStream._Initialize_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr, 100665925);
			}

			// Token: 0x06001AC5 RID: 6853 RVA: 0x0006F19C File Offset: 0x0006D39C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54749, XrefRangeEnd = 54764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._Initialize_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AC6 RID: 6854 RVA: 0x0006F1D4 File Offset: 0x0006D3D4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._Initialize_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AC7 RID: 6855 RVA: 0x0000E98B File Offset: 0x0000CB8B
			public _Initialize_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AC8 RID: 6856 RVA: 0x0000E994 File Offset: 0x0000CB94
			public _Initialize_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._Initialize_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0006F21C File Offset: 0x0006D41C
			// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0000E9A6 File Offset: 0x0000CBA6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0006F244 File Offset: 0x0006D444
			// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0000E9C1 File Offset: 0x0000CBC1
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0006F274 File Offset: 0x0006D474
			// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0000E9EF File Offset: 0x0000CBEF
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0006F2A4 File Offset: 0x0006D4A4
			// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0000EA0E File Offset: 0x0000CC0E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
			// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0000EA3C File Offset: 0x0000CC3C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008A1 RID: 2209
			// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0006F304 File Offset: 0x0006D504
			// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x0000EA6A File Offset: 0x0000CC6A
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__34.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014AA RID: 5290
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014AB RID: 5291
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014AC RID: 5292
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014AD RID: 5293
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014AE RID: 5294
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014AF RID: 5295
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040014B0 RID: 5296
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014B1 RID: 5297
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E0 RID: 480
		[ObfuscatedName("System.Net.WebRequestStream+<SetHeadersAsync>d__35")]
		public sealed class _SetHeadersAsync_d__35 : ValueType
		{
			// Token: 0x06001AD5 RID: 6869 RVA: 0x0006F334 File Offset: 0x0006D534
			// Note: this type is marked as 'beforefieldinit'.
			static _SetHeadersAsync_d__35()
			{
				Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<SetHeadersAsync>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr);
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "<>1__state");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "<>t__builder");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "<>4__this");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "cancellationToken");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_setInternalLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "setInternalLength");
				WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, "<>u__1");
				WebRequestStream._SetHeadersAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, 100665926);
				WebRequestStream._SetHeadersAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr, 100665927);
			}

			// Token: 0x06001AD6 RID: 6870 RVA: 0x0006F400 File Offset: 0x0006D600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54764, XrefRangeEnd = 54813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._SetHeadersAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AD7 RID: 6871 RVA: 0x0006F438 File Offset: 0x0006D638
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._SetHeadersAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AD8 RID: 6872 RVA: 0x0000EA98 File Offset: 0x0000CC98
			public _SetHeadersAsync_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AD9 RID: 6873 RVA: 0x0000EAA1 File Offset: 0x0000CCA1
			public _SetHeadersAsync_d__35()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0006F480 File Offset: 0x0006D680
			// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000EAB3 File Offset: 0x0000CCB3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0006F4A8 File Offset: 0x0006D6A8
			// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0000EACE File Offset: 0x0000CCCE
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0006F4D8 File Offset: 0x0006D6D8
			// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0000EAFC File Offset: 0x0000CCFC
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0006F508 File Offset: 0x0006D708
			// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0000EB1B File Offset: 0x0000CD1B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0006F538 File Offset: 0x0006D738
			// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0000EB49 File Offset: 0x0000CD49
			public unsafe bool setInternalLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_setInternalLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr_setInternalLength)) = value;
				}
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0006F560 File Offset: 0x0006D760
			// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0000EB64 File Offset: 0x0000CD64
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014B2 RID: 5298
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014B3 RID: 5299
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014B4 RID: 5300
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014B5 RID: 5301
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014B6 RID: 5302
			private static readonly IntPtr NativeFieldInfoPtr_setInternalLength;

			// Token: 0x040014B7 RID: 5303
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014B8 RID: 5304
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014B9 RID: 5305
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E1 RID: 481
		[ObfuscatedName("System.Net.WebRequestStream+<WriteRequestAsync>d__36")]
		public sealed class _WriteRequestAsync_d__36 : ValueType
		{
			// Token: 0x06001AE6 RID: 6886 RVA: 0x0006F590 File Offset: 0x0006D790
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteRequestAsync_d__36()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteRequestAsync>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr);
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<buffer>5__1");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteRequestAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, 100665928);
				WebRequestStream._WriteRequestAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr, 100665929);
			}

			// Token: 0x06001AE7 RID: 6887 RVA: 0x0006F670 File Offset: 0x0006D870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54813, XrefRangeEnd = 54839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteRequestAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE8 RID: 6888 RVA: 0x0006F6A8 File Offset: 0x0006D8A8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteRequestAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AE9 RID: 6889 RVA: 0x0000EB92 File Offset: 0x0000CD92
			public _WriteRequestAsync_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AEA RID: 6890 RVA: 0x0000EB9B File Offset: 0x0000CD9B
			public _WriteRequestAsync_d__36()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0006F6F0 File Offset: 0x0006D8F0
			// (set) Token: 0x06001AEC RID: 6892 RVA: 0x0000EBAD File Offset: 0x0000CDAD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06001AED RID: 6893 RVA: 0x0006F718 File Offset: 0x0006D918
			// (set) Token: 0x06001AEE RID: 6894 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0006F748 File Offset: 0x0006D948
			// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x0000EBF6 File Offset: 0x0000CDF6
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0006F778 File Offset: 0x0006D978
			// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x0000EC15 File Offset: 0x0000CE15
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0006F7A8 File Offset: 0x0006D9A8
			// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x0000EC43 File Offset: 0x0000CE43
			public unsafe BufferOffsetSize _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr__buffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr__buffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0006F7D8 File Offset: 0x0006D9D8
			// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0000EC62 File Offset: 0x0000CE62
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0006F808 File Offset: 0x0006DA08
			// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0000EC90 File Offset: 0x0000CE90
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__36.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014BA RID: 5306
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014BB RID: 5307
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014BC RID: 5308
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014BD RID: 5309
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014BE RID: 5310
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x040014BF RID: 5311
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014C0 RID: 5312
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040014C1 RID: 5313
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014C2 RID: 5314
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E2 RID: 482
		[ObfuscatedName("System.Net.WebRequestStream+<WriteChunkTrailer_inner>d__37")]
		public sealed class _WriteChunkTrailer_inner_d__37 : ValueType
		{
			// Token: 0x06001AF9 RID: 6905 RVA: 0x0006F838 File Offset: 0x0006DA38
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteChunkTrailer_inner_d__37()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteChunkTrailer_inner>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr);
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, 100665930);
				WebRequestStream._WriteChunkTrailer_inner_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr, 100665931);
			}

			// Token: 0x06001AFA RID: 6906 RVA: 0x0006F8F0 File Offset: 0x0006DAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54839, XrefRangeEnd = 54854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AFB RID: 6907 RVA: 0x0006F928 File Offset: 0x0006DB28
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AFC RID: 6908 RVA: 0x0000ECBE File Offset: 0x0000CEBE
			public _WriteChunkTrailer_inner_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AFD RID: 6909 RVA: 0x0000ECC7 File Offset: 0x0000CEC7
			public _WriteChunkTrailer_inner_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06001AFE RID: 6910 RVA: 0x0006F970 File Offset: 0x0006DB70
			// (set) Token: 0x06001AFF RID: 6911 RVA: 0x0000ECD9 File Offset: 0x0000CED9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0006F998 File Offset: 0x0006DB98
			// (set) Token: 0x06001B01 RID: 6913 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0006F9C8 File Offset: 0x0006DBC8
			// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0000ED22 File Offset: 0x0000CF22
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0006F9F8 File Offset: 0x0006DBF8
			// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0000ED41 File Offset: 0x0000CF41
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0006FA28 File Offset: 0x0006DC28
			// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0000ED6F File Offset: 0x0000CF6F
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014C3 RID: 5315
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014C4 RID: 5316
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014C5 RID: 5317
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014C6 RID: 5318
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014C7 RID: 5319
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014C8 RID: 5320
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014C9 RID: 5321
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E3 RID: 483
		[ObfuscatedName("System.Net.WebRequestStream+<WriteChunkTrailer>d__38")]
		public sealed class _WriteChunkTrailer_d__38 : ValueType
		{
			// Token: 0x06001B08 RID: 6920 RVA: 0x0006FA58 File Offset: 0x0006DC58
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteChunkTrailer_d__38()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteChunkTrailer>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr);
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__timeoutTask_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<timeoutTask>5__1");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__cts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<cts>5__2");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteChunkTrailer_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, 100665932);
				WebRequestStream._WriteChunkTrailer_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr, 100665933);
			}

			// Token: 0x06001B09 RID: 6921 RVA: 0x0006FB38 File Offset: 0x0006DD38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54854, XrefRangeEnd = 54896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B0A RID: 6922 RVA: 0x0006FB70 File Offset: 0x0006DD70
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B0B RID: 6923 RVA: 0x0000ED9D File Offset: 0x0000CF9D
			public _WriteChunkTrailer_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B0C RID: 6924 RVA: 0x0000EDA6 File Offset: 0x0000CFA6
			public _WriteChunkTrailer_d__38()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__38>.NativeClassPtr))
			{
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0006FBB8 File Offset: 0x0006DDB8
			// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0006FBE0 File Offset: 0x0006DDE0
			// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0000EDD3 File Offset: 0x0000CFD3
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x06001B11 RID: 6929 RVA: 0x0006FC10 File Offset: 0x0006DE10
			// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0000EE01 File Offset: 0x0000D001
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x06001B13 RID: 6931 RVA: 0x0006FC40 File Offset: 0x0006DE40
			// (set) Token: 0x06001B14 RID: 6932 RVA: 0x0000EE20 File Offset: 0x0000D020
			public unsafe Task _timeoutTask_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__timeoutTask_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__timeoutTask_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0006FC70 File Offset: 0x0006DE70
			// (set) Token: 0x06001B16 RID: 6934 RVA: 0x0000EE3F File Offset: 0x0000D03F
			public unsafe CancellationTokenSource _cts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__cts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr__cts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x06001B17 RID: 6935 RVA: 0x0006FCA0 File Offset: 0x0006DEA0
			// (set) Token: 0x06001B18 RID: 6936 RVA: 0x0000EE5E File Offset: 0x0000D05E
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0006FCD0 File Offset: 0x0006DED0
			// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0000EE8C File Offset: 0x0000D08C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__38.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014CA RID: 5322
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014CB RID: 5323
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014CC RID: 5324
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014CD RID: 5325
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__1;

			// Token: 0x040014CE RID: 5326
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__2;

			// Token: 0x040014CF RID: 5327
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014D0 RID: 5328
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040014D1 RID: 5329
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014D2 RID: 5330
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
