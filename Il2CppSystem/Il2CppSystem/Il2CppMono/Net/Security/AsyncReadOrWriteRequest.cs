using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001F RID: 31
	public class AsyncReadOrWriteRequest : AsyncProtocolRequest
	{
		// Token: 0x0600015E RID: 350 RVA: 0x000159CC File Offset: 0x00013BCC
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadOrWriteRequest()
		{
			Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncReadOrWriteRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr);
			AsyncReadOrWriteRequest.NativeFieldInfoPtr__UserBuffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, "<UserBuffer>k__BackingField");
			AsyncReadOrWriteRequest.NativeFieldInfoPtr__CurrentSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, "<CurrentSize>k__BackingField");
			AsyncReadOrWriteRequest.NativeMethodInfoPtr_get_UserBuffer_Protected_get_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663556);
			AsyncReadOrWriteRequest.NativeMethodInfoPtr_get_CurrentSize_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663557);
			AsyncReadOrWriteRequest.NativeMethodInfoPtr_set_CurrentSize_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663558);
			AsyncReadOrWriteRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663559);
			AsyncReadOrWriteRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663560);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00015A88 File Offset: 0x00013C88
		public unsafe BufferOffsetSize UserBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadOrWriteRequest.NativeMethodInfoPtr_get_UserBuffer_Protected_get_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr3) : null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00015AC8 File Offset: 0x00013CC8
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00015B04 File Offset: 0x00013D04
		public unsafe int CurrentSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadOrWriteRequest.NativeMethodInfoPtr_get_CurrentSize_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadOrWriteRequest.NativeMethodInfoPtr_set_CurrentSize_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00015B44 File Offset: 0x00013D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33445, RefRangeEnd = 33447, XrefRangeStart = 33440, XrefRangeEnd = 33445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, Il2CppStructArray<byte> buffer, int offset, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadOrWriteRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00015BCC File Offset: 0x00013DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33447, XrefRangeEnd = 33452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncReadOrWriteRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000027AF File Offset: 0x000009AF
		public AsyncReadOrWriteRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00015C10 File Offset: 0x00013E10
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000027B8 File Offset: 0x000009B8
		public unsafe BufferOffsetSize _UserBuffer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadOrWriteRequest.NativeFieldInfoPtr__UserBuffer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadOrWriteRequest.NativeFieldInfoPtr__UserBuffer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00015C40 File Offset: 0x00013E40
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000027D7 File Offset: 0x000009D7
		public unsafe int _CurrentSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadOrWriteRequest.NativeFieldInfoPtr__CurrentSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadOrWriteRequest.NativeFieldInfoPtr__CurrentSize_k__BackingField)) = value;
			}
		}

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr__UserBuffer_k__BackingField;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSize_k__BackingField;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_get_UserBuffer_Protected_get_BufferOffsetSize_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSize_Protected_get_Int32_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSize_Protected_set_Void_Int32_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
