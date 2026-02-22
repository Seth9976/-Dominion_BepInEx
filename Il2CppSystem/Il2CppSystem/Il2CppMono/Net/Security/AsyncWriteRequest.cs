using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000021 RID: 33
	public class AsyncWriteRequest : AsyncReadOrWriteRequest
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00015D9C File Offset: 0x00013F9C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncWriteRequest()
		{
			Il2CppClassPointerStore<AsyncWriteRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncWriteRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncWriteRequest>.NativeClassPtr);
			AsyncWriteRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWriteRequest>.NativeClassPtr, 100663563);
			AsyncWriteRequest.NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWriteRequest>.NativeClassPtr, 100663564);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00015DF4 File Offset: 0x00013FF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33453, RefRangeEnd = 33459, XrefRangeStart = 33453, XrefRangeEnd = 33459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncWriteRequest(MobileAuthenticatedStream parent, bool sync, Il2CppStructArray<byte> buffer, int offset, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncWriteRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sync;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWriteRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00015E7C File Offset: 0x0001407C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33460, XrefRangeEnd = 33461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncWriteRequest.NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000027FB File Offset: 0x000009FB
		public AsyncWriteRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0;
	}
}
