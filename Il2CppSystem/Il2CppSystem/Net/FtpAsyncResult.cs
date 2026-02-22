using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x02000106 RID: 262
	public class FtpAsyncResult : Object
	{
		// Token: 0x06000F4A RID: 3914 RVA: 0x00049DC8 File Offset: 0x00047FC8
		// Note: this type is marked as 'beforefieldinit'.
		static FtpAsyncResult()
		{
			Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr);
			FtpAsyncResult.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "response");
			FtpAsyncResult.NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "waitHandle");
			FtpAsyncResult.NativeFieldInfoPtr_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "exception");
			FtpAsyncResult.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "callback");
			FtpAsyncResult.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "stream");
			FtpAsyncResult.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "state");
			FtpAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "completed");
			FtpAsyncResult.NativeFieldInfoPtr_synch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "synch");
			FtpAsyncResult.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, "locker");
			FtpAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665432);
			FtpAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665433);
			FtpAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665434);
			FtpAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665435);
			FtpAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665436);
			FtpAsyncResult.NativeMethodInfoPtr_get_GotException_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665437);
			FtpAsyncResult.NativeMethodInfoPtr_get_Exception_Internal_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665438);
			FtpAsyncResult.NativeMethodInfoPtr_get_Response_Internal_get_FtpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665439);
			FtpAsyncResult.NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665440);
			FtpAsyncResult.NativeMethodInfoPtr_WaitUntilComplete_Internal_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665441);
			FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_FtpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665442);
			FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_FtpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665443);
			FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665444);
			FtpAsyncResult.NativeMethodInfoPtr_DoCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr, 100665445);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00049FC4 File Offset: 0x000481C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50254, XrefRangeEnd = 50259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpAsyncResult(AsyncCallback callback, Object state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0004A024 File Offset: 0x00048224
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x0004A064 File Offset: 0x00048264
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 50266, RefRangeEnd = 50268, XrefRangeStart = 50259, XrefRangeEnd = 50266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0004A0A4 File Offset: 0x000482A4
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x0004A0E0 File Offset: 0x000482E0
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50271, RefRangeEnd = 50274, XrefRangeStart = 50268, XrefRangeEnd = 50271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0004A11C File Offset: 0x0004831C
		public unsafe bool GotException
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 35304, RefRangeEnd = 35309, XrefRangeStart = 35304, XrefRangeEnd = 35309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_GotException_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x0004A158 File Offset: 0x00048358
		public unsafe Exception Exception
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_Exception_Internal_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0004A198 File Offset: 0x00048398
		public unsafe FtpWebResponse Response
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_get_Response_Internal_get_FtpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpWebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x0004A1D8 File Offset: 0x000483D8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0004A21C File Offset: 0x0004841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50274, XrefRangeEnd = 50276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitUntilComplete(int timeout, bool exitContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_WaitUntilComplete_Internal_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0004A274 File Offset: 0x00048474
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 50281, RefRangeEnd = 50286, XrefRangeStart = 50276, XrefRangeEnd = 50281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleted(bool synch, Exception exc, FtpWebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_FtpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0004A2D8 File Offset: 0x000484D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50286, XrefRangeEnd = 50287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleted(bool synch, FtpWebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_FtpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0004A328 File Offset: 0x00048528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50287, XrefRangeEnd = 50288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleted(bool synch, Exception exc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0004A378 File Offset: 0x00048578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50290, RefRangeEnd = 50291, XrefRangeStart = 50288, XrefRangeEnd = 50290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpAsyncResult.NativeMethodInfoPtr_DoCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0000804A File Offset: 0x0000624A
		public FtpAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0004A3AC File Offset: 0x000485AC
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00008053 File Offset: 0x00006253
		public unsafe FtpWebResponse response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0004A3DC File Offset: 0x000485DC
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00008072 File Offset: 0x00006272
		public unsafe ManualResetEvent waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_waitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0004A40C File Offset: 0x0004860C
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00008091 File Offset: 0x00006291
		public unsafe Exception exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004A43C File Offset: 0x0004863C
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x000080B0 File Offset: 0x000062B0
		public unsafe AsyncCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0004A46C File Offset: 0x0004866C
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x000080CF File Offset: 0x000062CF
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0004A49C File Offset: 0x0004869C
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x000080EE File Offset: 0x000062EE
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0004A4CC File Offset: 0x000486CC
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x0000810D File Offset: 0x0000630D
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004A4F4 File Offset: 0x000486F4
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x00008128 File Offset: 0x00006328
		public unsafe bool synch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_synch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_synch)) = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0004A51C File Offset: 0x0004871C
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00008143 File Offset: 0x00006343
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpAsyncResult.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeFieldInfoPtr_waitHandle;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeFieldInfoPtr_exception;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr_synch;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_get_GotException_Internal_get_Boolean_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Internal_get_Exception_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Internal_get_FtpWebResponse_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_set_Stream_Internal_set_Void_Stream_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilComplete_Internal_Boolean_Int32_Boolean_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_FtpWebResponse_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_FtpWebResponse_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_Boolean_Exception_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_DoCallback_Internal_Void_0;
	}
}
