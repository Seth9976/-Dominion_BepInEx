using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001E RID: 30
	public class AsyncHandshakeRequest : AsyncProtocolRequest
	{
		// Token: 0x0600015A RID: 346 RVA: 0x000158C4 File Offset: 0x00013AC4
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncHandshakeRequest()
		{
			Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncHandshakeRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr);
			AsyncHandshakeRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr, 100663554);
			AsyncHandshakeRequest.NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr, 100663555);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0001591C File Offset: 0x00013B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33437, RefRangeEnd = 33438, XrefRangeStart = 33436, XrefRangeEnd = 33437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncHandshakeRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00015978 File Offset: 0x00013B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33438, XrefRangeEnd = 33440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncHandshakeRequest.NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000027A6 File Offset: 0x000009A6
		public AsyncHandshakeRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0;
	}
}
