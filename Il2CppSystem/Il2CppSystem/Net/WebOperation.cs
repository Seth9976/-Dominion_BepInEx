using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011B RID: 283
	public class WebOperation : Object
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x00055814 File Offset: 0x00053A14
		// Note: this type is marked as 'beforefieldinit'.
		static WebOperation()
		{
			Il2CppClassPointerStore<WebOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation>.NativeClassPtr);
			WebOperation.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Request>k__BackingField");
			WebOperation.NativeFieldInfoPtr__Connection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Connection>k__BackingField");
			WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<ServicePoint>k__BackingField");
			WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<WriteBuffer>k__BackingField");
			WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<IsNtlmChallenge>k__BackingField");
			WebOperation.NativeFieldInfoPtr_cts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "cts");
			WebOperation.NativeFieldInfoPtr_requestTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestTask");
			WebOperation.NativeFieldInfoPtr_requestWrittenTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestWrittenTask");
			WebOperation.NativeFieldInfoPtr_responseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "responseTask");
			WebOperation.NativeFieldInfoPtr_completeResponseReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "completeResponseReadTask");
			WebOperation.NativeFieldInfoPtr_finishedTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "finishedTask");
			WebOperation.NativeFieldInfoPtr_writeStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "writeStream");
			WebOperation.NativeFieldInfoPtr_responseStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "responseStream");
			WebOperation.NativeFieldInfoPtr_disposedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "disposedInfo");
			WebOperation.NativeFieldInfoPtr_closedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "closedInfo");
			WebOperation.NativeFieldInfoPtr_priorityRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "priorityRequest");
			WebOperation.NativeFieldInfoPtr_finishedReading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "finishedReading");
			WebOperation.NativeFieldInfoPtr_requestSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestSent");
			WebOperation.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665860);
			WebOperation.NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665861);
			WebOperation.NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665862);
			WebOperation.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665863);
			WebOperation.NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665864);
			WebOperation.NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665865);
			WebOperation.NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665866);
			WebOperation.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665867);
			WebOperation.NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665868);
			WebOperation.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665869);
			WebOperation.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665870);
			WebOperation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665871);
			WebOperation.NativeMethodInfoPtr_SetCanceled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665872);
			WebOperation.NativeMethodInfoPtr_SetError_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665873);
			WebOperation.NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665874);
			WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665875);
			WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665876);
			WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665877);
			WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665878);
			WebOperation.NativeMethodInfoPtr_ThrowDisposed_Private_Void_byref_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665879);
			WebOperation.NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665880);
			WebOperation.NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665881);
			WebOperation.NativeMethodInfoPtr_GetRequestStream_Public_Task_1_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665882);
			WebOperation.NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665883);
			WebOperation.NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665884);
			WebOperation.NativeMethodInfoPtr_WaitForCompletion_Internal_Task_1_ValueTuple_2_Boolean_WebOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665885);
			WebOperation.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665886);
			WebOperation.NativeMethodInfoPtr_FinishReading_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665887);
			WebOperation.NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665888);
			WebOperation.NativeMethodInfoPtr_CompleteResponseRead_Internal_Void_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665889);
			WebOperation.NativeMethodInfoPtr__RegisterRequest_b__46_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100665890);
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00055C18 File Offset: 0x00053E18
		public unsafe HttpWebRequest Request
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00055C58 File Offset: 0x00053E58
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x00055C98 File Offset: 0x00053E98
		public unsafe WebConnection Connection
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00055CDC File Offset: 0x00053EDC
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x00055D1C File Offset: 0x00053F1C
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00055D60 File Offset: 0x00053F60
		public unsafe BufferOffsetSize WriteBuffer
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr3) : null;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x00055DA0 File Offset: 0x00053FA0
		public unsafe bool IsNtlmChallenge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00055DDC File Offset: 0x00053FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54452, RefRangeEnd = 54454, XrefRangeStart = 54416, XrefRangeEnd = 54452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNtlmChallenge;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x00055E60 File Offset: 0x00054060
		public unsafe bool Aborted
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 54456, RefRangeEnd = 54460, XrefRangeStart = 54454, XrefRangeEnd = 54456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00055E9C File Offset: 0x0005409C
		public unsafe bool Closed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54460, XrefRangeEnd = 54462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00055ED8 File Offset: 0x000540D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54476, RefRangeEnd = 54478, XrefRangeStart = 54462, XrefRangeEnd = 54476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00055F0C File Offset: 0x0005410C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54481, RefRangeEnd = 54482, XrefRangeStart = 54478, XrefRangeEnd = 54481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00055F40 File Offset: 0x00054140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54494, RefRangeEnd = 54495, XrefRangeStart = 54482, XrefRangeEnd = 54494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetCanceled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00055F74 File Offset: 0x00054174
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54507, RefRangeEnd = 54509, XrefRangeStart = 54495, XrefRangeEnd = 54507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetError(Exception error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetError_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00055FB8 File Offset: 0x000541B8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 54521, RefRangeEnd = 54530, XrefRangeStart = 54509, XrefRangeEnd = 54521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(field);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				field = ((intPtr4 == 0) ? null : new ExceptionDispatchInfo(intPtr4));
				return new ValueTuple<ExceptionDispatchInfo, bool>(intPtr2);
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00056018 File Offset: 0x00054218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54530, XrefRangeEnd = 54540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0005604C File Offset: 0x0005424C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 54546, RefRangeEnd = 54549, XrefRangeStart = 54540, XrefRangeEnd = 54546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00056094 File Offset: 0x00054294
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 54559, RefRangeEnd = 54566, XrefRangeStart = 54549, XrefRangeEnd = 54559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfClosedOrDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000560C8 File Offset: 0x000542C8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 54572, RefRangeEnd = 54582, XrefRangeStart = 54566, XrefRangeEnd = 54572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfClosedOrDisposed(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00056110 File Offset: 0x00054310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54582, XrefRangeEnd = 54586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowDisposed(ref ExceptionDispatchInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(field);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowDisposed_Private_Void_byref_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				field = ((intPtr4 == 0) ? null : new ExceptionDispatchInfo(intPtr4));
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00056168 File Offset: 0x00054368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54598, RefRangeEnd = 54600, XrefRangeStart = 54586, XrefRangeEnd = 54598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterRequest(ServicePoint servicePoint, WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000561BC File Offset: 0x000543BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54605, RefRangeEnd = 54606, XrefRangeStart = 54600, XrefRangeEnd = 54605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPriorityRequest(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00056200 File Offset: 0x00054400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54607, RefRangeEnd = 54608, XrefRangeStart = 54606, XrefRangeEnd = 54607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebRequestStream> GetRequestStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_GetRequestStream_Public_Task_1_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebRequestStream>>(intPtr3) : null;
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00056240 File Offset: 0x00054440
		public unsafe WebRequestStream WriteStream
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54618, RefRangeEnd = 54619, XrefRangeStart = 54608, XrefRangeEnd = 54618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr3) : null;
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00056280 File Offset: 0x00054480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54620, RefRangeEnd = 54621, XrefRangeStart = 54619, XrefRangeEnd = 54620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebResponseStream> GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponseStream>>(intPtr3) : null;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000562C0 File Offset: 0x000544C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54633, RefRangeEnd = 54634, XrefRangeStart = 54621, XrefRangeEnd = 54633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<bool, WebOperation>> WaitForCompletion(bool ignoreErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreErrors;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_WaitForCompletion_Internal_Task_1_ValueTuple_2_Boolean_WebOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<bool, WebOperation>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0005630C File Offset: 0x0005450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54634, XrefRangeEnd = 54638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00056340 File Offset: 0x00054540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54642, RefRangeEnd = 54643, XrefRangeStart = 54638, XrefRangeEnd = 54642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_FinishReading_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00056374 File Offset: 0x00054574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54658, RefRangeEnd = 54659, XrefRangeStart = 54643, XrefRangeEnd = 54658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteRequestWritten(WebRequestStream stream, Exception error = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000563C8 File Offset: 0x000545C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 54666, RefRangeEnd = 54670, XrefRangeStart = 54659, XrefRangeEnd = 54666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteResponseRead(bool ok, Exception error = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ok;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_CompleteResponseRead_Internal_Void_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00056418 File Offset: 0x00054618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54670, XrefRangeEnd = 54671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterRequest_b__46_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr__RegisterRequest_b__46_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000098BF File Offset: 0x00007ABF
		public WebOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x0005644C File Offset: 0x0005464C
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x000098C8 File Offset: 0x00007AC8
		public unsafe HttpWebRequest _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0005647C File Offset: 0x0005467C
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x000098E7 File Offset: 0x00007AE7
		public unsafe WebConnection _Connection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Connection_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Connection_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000564AC File Offset: 0x000546AC
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00009906 File Offset: 0x00007B06
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000564DC File Offset: 0x000546DC
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x00009925 File Offset: 0x00007B25
		public unsafe BufferOffsetSize _WriteBuffer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0005650C File Offset: 0x0005470C
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x00009944 File Offset: 0x00007B44
		public unsafe bool _IsNtlmChallenge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField)) = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00056534 File Offset: 0x00054734
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x0000995F File Offset: 0x00007B5F
		public unsafe CancellationTokenSource cts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_cts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_cts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00056564 File Offset: 0x00054764
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0000997E File Offset: 0x00007B7E
		public unsafe TaskCompletionSource<WebRequestStream> requestTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebRequestStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00056594 File Offset: 0x00054794
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0000999D File Offset: 0x00007B9D
		public unsafe TaskCompletionSource<WebRequestStream> requestWrittenTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestWrittenTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebRequestStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestWrittenTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000565C4 File Offset: 0x000547C4
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x000099BC File Offset: 0x00007BBC
		public unsafe TaskCompletionSource<WebResponseStream> responseTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebResponseStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x000565F4 File Offset: 0x000547F4
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x000099DB File Offset: 0x00007BDB
		public unsafe TaskCompletionSource<bool> completeResponseReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_completeResponseReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_completeResponseReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00056624 File Offset: 0x00054824
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x000099FA File Offset: 0x00007BFA
		public unsafe TaskCompletionSource<ValueTuple<bool, WebOperation>> finishedTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<ValueTuple<bool, WebOperation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x00056654 File Offset: 0x00054854
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x00009A19 File Offset: 0x00007C19
		public unsafe WebRequestStream writeStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_writeStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_writeStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00056684 File Offset: 0x00054884
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x00009A38 File Offset: 0x00007C38
		public unsafe WebResponseStream responseStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x000566B4 File Offset: 0x000548B4
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x00009A57 File Offset: 0x00007C57
		public unsafe ExceptionDispatchInfo disposedInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_disposedInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_disposedInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x000566E4 File Offset: 0x000548E4
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x00009A76 File Offset: 0x00007C76
		public unsafe ExceptionDispatchInfo closedInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_closedInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_closedInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x00056714 File Offset: 0x00054914
		// (set) Token: 0x060012C3 RID: 4803 RVA: 0x00009A95 File Offset: 0x00007C95
		public unsafe WebOperation priorityRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_priorityRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_priorityRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x00056744 File Offset: 0x00054944
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x00009AB4 File Offset: 0x00007CB4
		public unsafe bool finishedReading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedReading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedReading)) = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x0005676C File Offset: 0x0005496C
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x00009ACF File Offset: 0x00007CCF
		public unsafe int requestSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestSent)) = value;
			}
		}

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeFieldInfoPtr__Connection_k__BackingField;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeFieldInfoPtr__WriteBuffer_k__BackingField;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeFieldInfoPtr_cts;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeFieldInfoPtr_requestTask;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeFieldInfoPtr_requestWrittenTask;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeFieldInfoPtr_responseTask;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeFieldInfoPtr_completeResponseReadTask;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeFieldInfoPtr_finishedTask;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeFieldInfoPtr_writeStream;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeFieldInfoPtr_responseStream;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeFieldInfoPtr_disposedInfo;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeFieldInfoPtr_closedInfo;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeFieldInfoPtr_priorityRequest;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeFieldInfoPtr_finishedReading;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr_requestSent;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_SetCanceled_Private_Void_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_SetError_Private_Void_Exception_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_ThrowDisposed_Private_Void_byref_ExceptionDispatchInfo_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStream_Public_Task_1_WebRequestStream_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Internal_Task_1_ValueTuple_2_Boolean_WebOperation_Boolean_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_FinishReading_Private_Void_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_CompleteResponseRead_Internal_Void_Boolean_Exception_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr__RegisterRequest_b__46_0_Private_Void_0;

		// Token: 0x020001D9 RID: 473
		[ObfuscatedName("System.Net.WebOperation+<WaitForCompletion>d__53")]
		public sealed class _WaitForCompletion_d__53 : ValueType
		{
			// Token: 0x06001A54 RID: 6740 RVA: 0x0006E154 File Offset: 0x0006C354
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForCompletion_d__53()
			{
				Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<WaitForCompletion>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr);
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "<>1__state");
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "<>t__builder");
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "<>4__this");
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr_ignoreErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "ignoreErrors");
				WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, "<>u__1");
				WebOperation._WaitForCompletion_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, 100665891);
				WebOperation._WaitForCompletion_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr, 100665892);
			}

			// Token: 0x06001A55 RID: 6741 RVA: 0x0006E20C File Offset: 0x0006C40C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54299, XrefRangeEnd = 54321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._WaitForCompletion_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A56 RID: 6742 RVA: 0x0006E244 File Offset: 0x0006C444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54321, XrefRangeEnd = 54324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._WaitForCompletion_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A57 RID: 6743 RVA: 0x0000E323 File Offset: 0x0000C523
			public _WaitForCompletion_d__53(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A58 RID: 6744 RVA: 0x0000E32C File Offset: 0x0000C52C
			public _WaitForCompletion_d__53()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation._WaitForCompletion_d__53>.NativeClassPtr))
			{
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x06001A59 RID: 6745 RVA: 0x0006E28C File Offset: 0x0006C48C
			// (set) Token: 0x06001A5A RID: 6746 RVA: 0x0000E33E File Offset: 0x0000C53E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x06001A5B RID: 6747 RVA: 0x0006E2B4 File Offset: 0x0006C4B4
			// (set) Token: 0x06001A5C RID: 6748 RVA: 0x0000E359 File Offset: 0x0000C559
			public AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x06001A5D RID: 6749 RVA: 0x0006E2E4 File Offset: 0x0006C4E4
			// (set) Token: 0x06001A5E RID: 6750 RVA: 0x0000E387 File Offset: 0x0000C587
			public unsafe WebOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x06001A5F RID: 6751 RVA: 0x0006E314 File Offset: 0x0006C514
			// (set) Token: 0x06001A60 RID: 6752 RVA: 0x0000E3A6 File Offset: 0x0000C5A6
			public unsafe bool ignoreErrors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr_ignoreErrors);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr_ignoreErrors)) = value;
				}
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x06001A61 RID: 6753 RVA: 0x0006E33C File Offset: 0x0006C53C
			// (set) Token: 0x06001A62 RID: 6754 RVA: 0x0000E3C1 File Offset: 0x0000C5C1
			public ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._WaitForCompletion_d__53.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001475 RID: 5237
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001476 RID: 5238
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001477 RID: 5239
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001478 RID: 5240
			private static readonly IntPtr NativeFieldInfoPtr_ignoreErrors;

			// Token: 0x04001479 RID: 5241
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400147A RID: 5242
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400147B RID: 5243
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001DA RID: 474
		[ObfuscatedName("System.Net.WebOperation+<Run>d__54")]
		public sealed class _Run_d__54 : ValueType
		{
			// Token: 0x06001A63 RID: 6755 RVA: 0x0006E36C File Offset: 0x0006C56C
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__54()
			{
				Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Run>d__54");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr);
				WebOperation._Run_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>1__state");
				WebOperation._Run_d__54.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>t__builder");
				WebOperation._Run_d__54.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>4__this");
				WebOperation._Run_d__54.NativeFieldInfoPtr__requestStream_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<requestStream>5__1");
				WebOperation._Run_d__54.NativeFieldInfoPtr__stream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<stream>5__2");
				WebOperation._Run_d__54.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>u__1");
				WebOperation._Run_d__54.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, "<>u__2");
				WebOperation._Run_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, 100665893);
				WebOperation._Run_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr, 100665894);
			}

			// Token: 0x06001A64 RID: 6756 RVA: 0x0006E44C File Offset: 0x0006C64C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54324, XrefRangeEnd = 54378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._Run_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A65 RID: 6757 RVA: 0x0006E484 File Offset: 0x0006C684
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._Run_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A66 RID: 6758 RVA: 0x0000E3EF File Offset: 0x0000C5EF
			public _Run_d__54(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A67 RID: 6759 RVA: 0x0000E3F8 File Offset: 0x0000C5F8
			public _Run_d__54()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation._Run_d__54>.NativeClassPtr))
			{
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0006E4CC File Offset: 0x0006C6CC
			// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0000E40A File Offset: 0x0000C60A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0006E4F4 File Offset: 0x0006C6F4
			// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0000E425 File Offset: 0x0000C625
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0006E524 File Offset: 0x0006C724
			// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0000E453 File Offset: 0x0000C653
			public unsafe WebOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0006E554 File Offset: 0x0006C754
			// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0000E472 File Offset: 0x0000C672
			public unsafe WebRequestStream _requestStream_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr__requestStream_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr__requestStream_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0006E584 File Offset: 0x0006C784
			// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0000E491 File Offset: 0x0000C691
			public unsafe WebResponseStream _stream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr__stream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr__stream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0006E5B4 File Offset: 0x0006C7B4
			// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
			public ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0006E5E4 File Offset: 0x0006C7E4
			// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0000E4DE File Offset: 0x0000C6DE
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__54.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400147C RID: 5244
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400147D RID: 5245
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400147E RID: 5246
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400147F RID: 5247
			private static readonly IntPtr NativeFieldInfoPtr__requestStream_5__1;

			// Token: 0x04001480 RID: 5248
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__2;

			// Token: 0x04001481 RID: 5249
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001482 RID: 5250
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001483 RID: 5251
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001484 RID: 5252
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001DB RID: 475
		[ObfuscatedName("System.Net.WebOperation+<FinishReading>d__55")]
		public sealed class _FinishReading_d__55 : ValueType
		{
			// Token: 0x06001A76 RID: 6774 RVA: 0x0006E614 File Offset: 0x0006C814
			// Note: this type is marked as 'beforefieldinit'.
			static _FinishReading_d__55()
			{
				Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<FinishReading>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr);
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<>1__state");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<>t__builder");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<>4__this");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr__error_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<error>5__1");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr__ok_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<ok>5__2");
				WebOperation._FinishReading_d__55.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, "<>u__1");
				WebOperation._FinishReading_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, 100665895);
				WebOperation._FinishReading_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr, 100665896);
			}

			// Token: 0x06001A77 RID: 6775 RVA: 0x0006E6E0 File Offset: 0x0006C8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54378, XrefRangeEnd = 54416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._FinishReading_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A78 RID: 6776 RVA: 0x0006E718 File Offset: 0x0006C918
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._FinishReading_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A79 RID: 6777 RVA: 0x0000E50C File Offset: 0x0000C70C
			public _FinishReading_d__55(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A7A RID: 6778 RVA: 0x0000E515 File Offset: 0x0000C715
			public _FinishReading_d__55()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation._FinishReading_d__55>.NativeClassPtr))
			{
			}

			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0006E760 File Offset: 0x0006C960
			// (set) Token: 0x06001A7C RID: 6780 RVA: 0x0000E527 File Offset: 0x0000C727
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0006E788 File Offset: 0x0006C988
			// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0000E542 File Offset: 0x0000C742
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0006E7B8 File Offset: 0x0006C9B8
			// (set) Token: 0x06001A80 RID: 6784 RVA: 0x0000E570 File Offset: 0x0000C770
			public unsafe WebOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0006E7E8 File Offset: 0x0006C9E8
			// (set) Token: 0x06001A82 RID: 6786 RVA: 0x0000E58F File Offset: 0x0000C78F
			public unsafe Exception _error_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr__error_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr__error_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x06001A83 RID: 6787 RVA: 0x0006E818 File Offset: 0x0006CA18
			// (set) Token: 0x06001A84 RID: 6788 RVA: 0x0000E5AE File Offset: 0x0000C7AE
			public unsafe bool _ok_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr__ok_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr__ok_5__2)) = value;
				}
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x06001A85 RID: 6789 RVA: 0x0006E840 File Offset: 0x0006CA40
			// (set) Token: 0x06001A86 RID: 6790 RVA: 0x0000E5C9 File Offset: 0x0000C7C9
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._FinishReading_d__55.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001485 RID: 5253
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001486 RID: 5254
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001487 RID: 5255
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001488 RID: 5256
			private static readonly IntPtr NativeFieldInfoPtr__error_5__1;

			// Token: 0x04001489 RID: 5257
			private static readonly IntPtr NativeFieldInfoPtr__ok_5__2;

			// Token: 0x0400148A RID: 5258
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400148B RID: 5259
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400148C RID: 5260
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
