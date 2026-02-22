using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001D RID: 29
	public class AsyncProtocolRequest : Object
	{
		// Token: 0x0600013D RID: 317 RVA: 0x0001523C File Offset: 0x0001343C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncProtocolRequest()
		{
			Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncProtocolRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr);
			AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<Parent>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<RunSynchronously>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<UserResult>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr_Started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "Started");
			AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "RequestedSize");
			AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "WriteRequested");
			AsyncProtocolRequest.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "locker");
			AsyncProtocolRequest.NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663535);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663536);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663537);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663538);
			AsyncProtocolRequest.NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663539);
			AsyncProtocolRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663540);
			AsyncProtocolRequest.NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663541);
			AsyncProtocolRequest.NativeMethodInfoPtr_RequestWrite_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663542);
			AsyncProtocolRequest.NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663543);
			AsyncProtocolRequest.NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663544);
			AsyncProtocolRequest.NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663545);
			AsyncProtocolRequest.NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663546);
			AsyncProtocolRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663547);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000153FC File Offset: 0x000135FC
		public unsafe MobileAuthenticatedStream Parent
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr3) : null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0001543C File Offset: 0x0001363C
		public unsafe bool RunSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00015478 File Offset: 0x00013678
		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33380, XrefRangeEnd = 33382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000154B0 File Offset: 0x000136B0
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000154EC File Offset: 0x000136EC
		public unsafe int UserResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0001552C File Offset: 0x0001372C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33387, RefRangeEnd = 33389, XrefRangeStart = 33382, XrefRangeEnd = 33387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00015588 File Offset: 0x00013788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33392, RefRangeEnd = 33394, XrefRangeStart = 33389, XrefRangeEnd = 33392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRead(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000155C8 File Offset: 0x000137C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33394, RefRangeEnd = 33395, XrefRangeStart = 33394, XrefRangeEnd = 33394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestWrite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_RequestWrite_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000155FC File Offset: 0x000137FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33407, RefRangeEnd = 33409, XrefRangeStart = 33395, XrefRangeEnd = 33407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AsyncProtocolResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00015654 File Offset: 0x00013854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33417, RefRangeEnd = 33418, XrefRangeStart = 33409, XrefRangeEnd = 33417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessOperation(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000156AC File Offset: 0x000138AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33430, RefRangeEnd = 33431, XrefRangeStart = 33418, XrefRangeEnd = 33430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<int>> InnerRead(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00015704 File Offset: 0x00013904
		[CallerCount(0)]
		public unsafe virtual AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncProtocolRequest.NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00015758 File Offset: 0x00013958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33431, XrefRangeEnd = 33436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncProtocolRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000026D8 File Offset: 0x000008D8
		public AsyncProtocolRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0001579C File Offset: 0x0001399C
		// (set) Token: 0x0600014D RID: 333 RVA: 0x000026E1 File Offset: 0x000008E1
		public unsafe MobileAuthenticatedStream _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000157CC File Offset: 0x000139CC
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002700 File Offset: 0x00000900
		public unsafe bool _RunSynchronously_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000157F4 File Offset: 0x000139F4
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000271B File Offset: 0x0000091B
		public unsafe int _UserResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0001581C File Offset: 0x00013A1C
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002736 File Offset: 0x00000936
		public unsafe int Started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_Started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_Started)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00015844 File Offset: 0x00013A44
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002751 File Offset: 0x00000951
		public unsafe int RequestedSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0001586C File Offset: 0x00013A6C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000276C File Offset: 0x0000096C
		public unsafe int WriteRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00015894 File Offset: 0x00013A94
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002787 File Offset: 0x00000987
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr__RunSynchronously_k__BackingField;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr__UserResult_k__BackingField;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_Started;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_RequestedSize;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_WriteRequested;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_RequestWrite_Internal_Void_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200017C RID: 380
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<StartOperation>d__23")]
		public sealed class _StartOperation_d__23 : ValueType
		{
			// Token: 0x06001663 RID: 5731 RVA: 0x00062C90 File Offset: 0x00060E90
			// Note: this type is marked as 'beforefieldinit'.
			static _StartOperation_d__23()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<StartOperation>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr);
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, 100663548);
				AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, 100663549);
			}

			// Token: 0x06001664 RID: 5732 RVA: 0x00062D48 File Offset: 0x00060F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33281, XrefRangeEnd = 33308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001665 RID: 5733 RVA: 0x00062D80 File Offset: 0x00060F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33308, XrefRangeEnd = 33311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001666 RID: 5734 RVA: 0x0000B943 File Offset: 0x00009B43
			public _StartOperation_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001667 RID: 5735 RVA: 0x0000B94C File Offset: 0x00009B4C
			public _StartOperation_d__23()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x06001668 RID: 5736 RVA: 0x00062DC8 File Offset: 0x00060FC8
			// (set) Token: 0x06001669 RID: 5737 RVA: 0x0000B95E File Offset: 0x00009B5E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x0600166A RID: 5738 RVA: 0x00062DF0 File Offset: 0x00060FF0
			// (set) Token: 0x0600166B RID: 5739 RVA: 0x0000B979 File Offset: 0x00009B79
			public AsyncTaskMethodBuilder<AsyncProtocolResult> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AsyncProtocolResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncProtocolResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncProtocolResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x0600166C RID: 5740 RVA: 0x00062E20 File Offset: 0x00061020
			// (set) Token: 0x0600166D RID: 5741 RVA: 0x0000B9A7 File Offset: 0x00009BA7
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x0600166E RID: 5742 RVA: 0x00062E50 File Offset: 0x00061050
			// (set) Token: 0x0600166F RID: 5743 RVA: 0x0000B9C6 File Offset: 0x00009BC6
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06001670 RID: 5744 RVA: 0x00062E80 File Offset: 0x00061080
			// (set) Token: 0x06001671 RID: 5745 RVA: 0x0000B9F4 File Offset: 0x00009BF4
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040011D6 RID: 4566
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011D7 RID: 4567
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040011D8 RID: 4568
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011D9 RID: 4569
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040011DA RID: 4570
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040011DB RID: 4571
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011DC RID: 4572
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200017D RID: 381
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<ProcessOperation>d__24")]
		public sealed class _ProcessOperation_d__24 : ValueType
		{
			// Token: 0x06001672 RID: 5746 RVA: 0x00062EB0 File Offset: 0x000610B0
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessOperation_d__24()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<ProcessOperation>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr);
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<status>5__1");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<newStatus>5__2");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>u__2");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, 100663550);
				AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, 100663551);
			}

			// Token: 0x06001673 RID: 5747 RVA: 0x00062FA4 File Offset: 0x000611A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33311, XrefRangeEnd = 33344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001674 RID: 5748 RVA: 0x00062FDC File Offset: 0x000611DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33344, XrefRangeEnd = 33345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001675 RID: 5749 RVA: 0x0000BA22 File Offset: 0x00009C22
			public _ProcessOperation_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001676 RID: 5750 RVA: 0x0000BA2B File Offset: 0x00009C2B
			public _ProcessOperation_d__24()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr))
			{
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06001677 RID: 5751 RVA: 0x00063024 File Offset: 0x00061224
			// (set) Token: 0x06001678 RID: 5752 RVA: 0x0000BA3D File Offset: 0x00009C3D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06001679 RID: 5753 RVA: 0x0006304C File Offset: 0x0006124C
			// (set) Token: 0x0600167A RID: 5754 RVA: 0x0000BA58 File Offset: 0x00009C58
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x0600167B RID: 5755 RVA: 0x0006307C File Offset: 0x0006127C
			// (set) Token: 0x0600167C RID: 5756 RVA: 0x0000BA86 File Offset: 0x00009C86
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x0600167D RID: 5757 RVA: 0x000630AC File Offset: 0x000612AC
			// (set) Token: 0x0600167E RID: 5758 RVA: 0x0000BAB4 File Offset: 0x00009CB4
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x0600167F RID: 5759 RVA: 0x000630DC File Offset: 0x000612DC
			// (set) Token: 0x06001680 RID: 5760 RVA: 0x0000BAD3 File Offset: 0x00009CD3
			public unsafe AsyncOperationStatus _status_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__1)) = value;
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06001681 RID: 5761 RVA: 0x00063104 File Offset: 0x00061304
			// (set) Token: 0x06001682 RID: 5762 RVA: 0x0000BAEE File Offset: 0x00009CEE
			public unsafe AsyncOperationStatus _newStatus_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__2)) = value;
				}
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x06001683 RID: 5763 RVA: 0x0006312C File Offset: 0x0006132C
			// (set) Token: 0x06001684 RID: 5764 RVA: 0x0000BB09 File Offset: 0x00009D09
			public ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06001685 RID: 5765 RVA: 0x0006315C File Offset: 0x0006135C
			// (set) Token: 0x06001686 RID: 5766 RVA: 0x0000BB37 File Offset: 0x00009D37
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040011DD RID: 4573
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011DE RID: 4574
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040011DF RID: 4575
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040011E0 RID: 4576
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011E1 RID: 4577
			private static readonly IntPtr NativeFieldInfoPtr__status_5__1;

			// Token: 0x040011E2 RID: 4578
			private static readonly IntPtr NativeFieldInfoPtr__newStatus_5__2;

			// Token: 0x040011E3 RID: 4579
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040011E4 RID: 4580
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040011E5 RID: 4581
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011E6 RID: 4582
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200017E RID: 382
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<InnerRead>d__25")]
		public sealed class _InnerRead_d__25 : ValueType
		{
			// Token: 0x06001687 RID: 5767 RVA: 0x0006318C File Offset: 0x0006138C
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerRead_d__25()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<InnerRead>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr);
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<requestedSize>5__1");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<totalRead>5__2");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, 100663552);
				AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, 100663553);
			}

			// Token: 0x06001688 RID: 5768 RVA: 0x0006326C File Offset: 0x0006146C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33376, RefRangeEnd = 33377, XrefRangeStart = 33345, XrefRangeEnd = 33376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001689 RID: 5769 RVA: 0x000632A4 File Offset: 0x000614A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33377, XrefRangeEnd = 33380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600168A RID: 5770 RVA: 0x0000BB65 File Offset: 0x00009D65
			public _InnerRead_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600168B RID: 5771 RVA: 0x0000BB6E File Offset: 0x00009D6E
			public _InnerRead_d__25()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr))
			{
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x0600168C RID: 5772 RVA: 0x000632EC File Offset: 0x000614EC
			// (set) Token: 0x0600168D RID: 5773 RVA: 0x0000BB80 File Offset: 0x00009D80
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x0600168E RID: 5774 RVA: 0x00063314 File Offset: 0x00061514
			// (set) Token: 0x0600168F RID: 5775 RVA: 0x0000BB9B File Offset: 0x00009D9B
			public AsyncTaskMethodBuilder<Nullable<int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06001690 RID: 5776 RVA: 0x00063344 File Offset: 0x00061544
			// (set) Token: 0x06001691 RID: 5777 RVA: 0x0000BBC9 File Offset: 0x00009DC9
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06001692 RID: 5778 RVA: 0x00063374 File Offset: 0x00061574
			// (set) Token: 0x06001693 RID: 5779 RVA: 0x0000BBE8 File Offset: 0x00009DE8
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x06001694 RID: 5780 RVA: 0x000633A4 File Offset: 0x000615A4
			// (set) Token: 0x06001695 RID: 5781 RVA: 0x0000BC16 File Offset: 0x00009E16
			public unsafe int _requestedSize_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__1)) = value;
				}
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06001696 RID: 5782 RVA: 0x000633CC File Offset: 0x000615CC
			// (set) Token: 0x06001697 RID: 5783 RVA: 0x0000BC31 File Offset: 0x00009E31
			public Nullable<int> _totalRead_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06001698 RID: 5784 RVA: 0x000633FC File Offset: 0x000615FC
			// (set) Token: 0x06001699 RID: 5785 RVA: 0x0000BC5F File Offset: 0x00009E5F
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040011E7 RID: 4583
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011E8 RID: 4584
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040011E9 RID: 4585
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011EA RID: 4586
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040011EB RID: 4587
			private static readonly IntPtr NativeFieldInfoPtr__requestedSize_5__1;

			// Token: 0x040011EC RID: 4588
			private static readonly IntPtr NativeFieldInfoPtr__totalRead_5__2;

			// Token: 0x040011ED RID: 4589
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040011EE RID: 4590
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011EF RID: 4591
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
