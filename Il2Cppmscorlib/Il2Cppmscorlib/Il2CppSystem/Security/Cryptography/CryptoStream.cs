using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E0 RID: 736
	public class CryptoStream : Stream
	{
		// Token: 0x06003073 RID: 12403 RVA: 0x000F1FE0 File Offset: 0x000F01E0
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoStream()
		{
			Il2CppClassPointerStore<CryptoStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptoStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr);
			CryptoStream.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_stream");
			CryptoStream.NativeFieldInfoPtr__Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_Transform");
			CryptoStream.NativeFieldInfoPtr__InputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_InputBuffer");
			CryptoStream.NativeFieldInfoPtr__InputBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_InputBufferIndex");
			CryptoStream.NativeFieldInfoPtr__InputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_InputBlockSize");
			CryptoStream.NativeFieldInfoPtr__OutputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_OutputBuffer");
			CryptoStream.NativeFieldInfoPtr__OutputBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_OutputBufferIndex");
			CryptoStream.NativeFieldInfoPtr__OutputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_OutputBlockSize");
			CryptoStream.NativeFieldInfoPtr__transformMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_transformMode");
			CryptoStream.NativeFieldInfoPtr__canRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_canRead");
			CryptoStream.NativeFieldInfoPtr__canWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_canWrite");
			CryptoStream.NativeFieldInfoPtr__finalBlockTransformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_finalBlockTransformed");
			CryptoStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670925);
			CryptoStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670926);
			CryptoStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670927);
			CryptoStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670928);
			CryptoStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670929);
			CryptoStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670930);
			CryptoStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670931);
			CryptoStream.NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670932);
			CryptoStream.NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670933);
			CryptoStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670934);
			CryptoStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670935);
			CryptoStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670936);
			CryptoStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670937);
			CryptoStream.NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670938);
			CryptoStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670939);
			CryptoStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670940);
			CryptoStream.NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670941);
			CryptoStream.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670942);
			CryptoStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670943);
			CryptoStream.NativeMethodInfoPtr_InitializeBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100670944);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000F2290 File Offset: 0x000F0490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339070, RefRangeEnd = 339072, XrefRangeStart = 339051, XrefRangeEnd = 339070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x000F22FC File Offset: 0x000F04FC
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x000F2344 File Offset: 0x000F0544
		public unsafe override bool CanSeek
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x000F238C File Offset: 0x000F058C
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x000F23D4 File Offset: 0x000F05D4
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339072, XrefRangeEnd = 339079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x000F241C File Offset: 0x000F061C
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x000F2464 File Offset: 0x000F0664
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339079, XrefRangeEnd = 339086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339086, XrefRangeEnd = 339093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x000F24B0 File Offset: 0x000F06B0
		public unsafe bool HasFlushedFinalBlock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x000F24EC File Offset: 0x000F06EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339102, RefRangeEnd = 339105, XrefRangeStart = 339093, XrefRangeEnd = 339102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushFinalBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x000F2520 File Offset: 0x000F0720
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x000F255C File Offset: 0x000F075C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339105, XrefRangeEnd = 339112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x000F25C0 File Offset: 0x000F07C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339112, XrefRangeEnd = 339116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x000F2648 File Offset: 0x000F0848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339116, XrefRangeEnd = 339139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x000F26D8 File Offset: 0x000F08D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339139, XrefRangeEnd = 339151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReadAsyncInternal(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x000F275C File Offset: 0x000F095C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339151, XrefRangeEnd = 339154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x000F27C8 File Offset: 0x000F09C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339154, XrefRangeEnd = 339172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x000F2858 File Offset: 0x000F0A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339172, XrefRangeEnd = 339180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteAsyncInternal(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x000F28DC File Offset: 0x000F0ADC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 321373, RefRangeEnd = 321379, XrefRangeStart = 321373, XrefRangeEnd = 321379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x000F2910 File Offset: 0x000F0B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339180, XrefRangeEnd = 339186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x000F295C File Offset: 0x000F0B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339186, XrefRangeEnd = 339196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_InitializeBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x000111F3 File Offset: 0x0000F3F3
		public CryptoStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x000F2990 File Offset: 0x000F0B90
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x000111FC File Offset: 0x0000F3FC
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x000F29C0 File Offset: 0x000F0BC0
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x0001121B File Offset: 0x0000F41B
		public unsafe ICryptoTransform _Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__Transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x000F29F0 File Offset: 0x000F0BF0
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x0001123A File Offset: 0x0000F43A
		public unsafe Il2CppStructArray<byte> _InputBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x000F2A20 File Offset: 0x000F0C20
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x00011259 File Offset: 0x0000F459
		public unsafe int _InputBufferIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBufferIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBufferIndex)) = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x000F2A48 File Offset: 0x000F0C48
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x00011274 File Offset: 0x0000F474
		public unsafe int _InputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__InputBlockSize)) = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x000F2A70 File Offset: 0x000F0C70
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x0001128F File Offset: 0x0000F48F
		public unsafe Il2CppStructArray<byte> _OutputBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x000F2AA0 File Offset: 0x000F0CA0
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x000112AE File Offset: 0x0000F4AE
		public unsafe int _OutputBufferIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBufferIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBufferIndex)) = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x000F2AC8 File Offset: 0x000F0CC8
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x000112C9 File Offset: 0x0000F4C9
		public unsafe int _OutputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__OutputBlockSize)) = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x000F2AF0 File Offset: 0x000F0CF0
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x000112E4 File Offset: 0x0000F4E4
		public unsafe CryptoStreamMode _transformMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__transformMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__transformMode)) = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000F2B18 File Offset: 0x000F0D18
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x000112FF File Offset: 0x0000F4FF
		public unsafe bool _canRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canRead)) = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x000F2B40 File Offset: 0x000F0D40
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x0001131A File Offset: 0x0000F51A
		public unsafe bool _canWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canWrite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canWrite)) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x000F2B68 File Offset: 0x000F0D68
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00011335 File Offset: 0x0000F535
		public unsafe bool _finalBlockTransformed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__finalBlockTransformed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__finalBlockTransformed)) = value;
			}
		}

		// Token: 0x040029C4 RID: 10692
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x040029C5 RID: 10693
		private static readonly IntPtr NativeFieldInfoPtr__Transform;

		// Token: 0x040029C6 RID: 10694
		private static readonly IntPtr NativeFieldInfoPtr__InputBuffer;

		// Token: 0x040029C7 RID: 10695
		private static readonly IntPtr NativeFieldInfoPtr__InputBufferIndex;

		// Token: 0x040029C8 RID: 10696
		private static readonly IntPtr NativeFieldInfoPtr__InputBlockSize;

		// Token: 0x040029C9 RID: 10697
		private static readonly IntPtr NativeFieldInfoPtr__OutputBuffer;

		// Token: 0x040029CA RID: 10698
		private static readonly IntPtr NativeFieldInfoPtr__OutputBufferIndex;

		// Token: 0x040029CB RID: 10699
		private static readonly IntPtr NativeFieldInfoPtr__OutputBlockSize;

		// Token: 0x040029CC RID: 10700
		private static readonly IntPtr NativeFieldInfoPtr__transformMode;

		// Token: 0x040029CD RID: 10701
		private static readonly IntPtr NativeFieldInfoPtr__canRead;

		// Token: 0x040029CE RID: 10702
		private static readonly IntPtr NativeFieldInfoPtr__canWrite;

		// Token: 0x040029CF RID: 10703
		private static readonly IntPtr NativeFieldInfoPtr__finalBlockTransformed;

		// Token: 0x040029D0 RID: 10704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0;

		// Token: 0x040029D1 RID: 10705
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x040029D2 RID: 10706
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x040029D3 RID: 10707
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x040029D4 RID: 10708
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x040029D5 RID: 10709
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x040029D6 RID: 10710
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x040029D7 RID: 10711
		private static readonly IntPtr NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0;

		// Token: 0x040029D8 RID: 10712
		private static readonly IntPtr NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0;

		// Token: 0x040029D9 RID: 10713
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x040029DA RID: 10714
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x040029DB RID: 10715
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040029DC RID: 10716
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x040029DD RID: 10717
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x040029DE RID: 10718
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040029DF RID: 10719
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x040029E0 RID: 10720
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x040029E1 RID: 10721
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040029E2 RID: 10722
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040029E3 RID: 10723
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBuffer_Private_Void_0;

		// Token: 0x02000623 RID: 1571
		[StructLayout(2)]
		public struct HopToThreadPoolAwaitable : INotifyCompletion
		{
			// Token: 0x060053CF RID: 21455 RVA: 0x00173FD4 File Offset: 0x001721D4
			// Note: this type is marked as 'beforefieldinit'.
			static HopToThreadPoolAwaitable()
			{
				Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "HopToThreadPoolAwaitable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr);
				CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_HopToThreadPoolAwaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, 100670945);
				CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, 100670946);
				CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, 100670947);
				CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, 100670948);
			}

			// Token: 0x060053D0 RID: 21456 RVA: 0x00174050 File Offset: 0x00172250
			[CallerCount(0)]
			public unsafe CryptoStream.HopToThreadPoolAwaitable GetAwaiter()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_HopToThreadPoolAwaitable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700156E RID: 5486
			// (get) Token: 0x060053D1 RID: 21457 RVA: 0x00174080 File Offset: 0x00172280
			public unsafe bool IsCompleted
			{
				[CallerCount(48)]
				[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053D2 RID: 21458 RVA: 0x001740B0 File Offset: 0x001722B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338931, RefRangeEnd = 338932, XrefRangeStart = 338927, XrefRangeEnd = 338931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053D3 RID: 21459 RVA: 0x001740E8 File Offset: 0x001722E8
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetResult()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.HopToThreadPoolAwaitable.NativeMethodInfoPtr_GetResult_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053D4 RID: 21460 RVA: 0x00020297 File Offset: 0x0001E497
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CryptoStream.HopToThreadPoolAwaitable>.NativeClassPtr, ref this));
			}

			// Token: 0x060053D5 RID: 21461 RVA: 0x000202A9 File Offset: 0x0001E4A9
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x040043A9 RID: 17321
			private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_HopToThreadPoolAwaitable_0;

			// Token: 0x040043AA RID: 17322
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x040043AB RID: 17323
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x040043AC RID: 17324
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;
		}

		// Token: 0x02000624 RID: 1572
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<ReadAsyncInternal>d__34")]
		public sealed class _ReadAsyncInternal_d__34 : ValueType
		{
			// Token: 0x060053D6 RID: 21462 RVA: 0x00174110 File Offset: 0x00172310
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsyncInternal_d__34()
			{
				Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<ReadAsyncInternal>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr);
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>1__state");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>t__builder");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>4__this");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "count");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "offset");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "buffer");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "cancellationToken");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__tempInputBuffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<tempInputBuffer>5__1");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__currentOutputIndex_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<currentOutputIndex>5__2");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__bytesToDeliver_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<bytesToDeliver>5__3");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__sem_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<sem>5__4");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>u__1");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>u__2");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>7__wrap1");
				CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, "<>u__3");
				CryptoStream._ReadAsyncInternal_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, 100670949);
				CryptoStream._ReadAsyncInternal_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr, 100670950);
			}

			// Token: 0x060053D7 RID: 21463 RVA: 0x00174290 File Offset: 0x00172490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338932, XrefRangeEnd = 339000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._ReadAsyncInternal_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053D8 RID: 21464 RVA: 0x001742C8 File Offset: 0x001724C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339000, XrefRangeEnd = 339003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._ReadAsyncInternal_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053D9 RID: 21465 RVA: 0x000202B7 File Offset: 0x0001E4B7
			public _ReadAsyncInternal_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060053DA RID: 21466 RVA: 0x000202C0 File Offset: 0x0001E4C0
			public _ReadAsyncInternal_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x1700156F RID: 5487
			// (get) Token: 0x060053DB RID: 21467 RVA: 0x00174310 File Offset: 0x00172510
			// (set) Token: 0x060053DC RID: 21468 RVA: 0x000202D2 File Offset: 0x0001E4D2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001570 RID: 5488
			// (get) Token: 0x060053DD RID: 21469 RVA: 0x00174338 File Offset: 0x00172538
			// (set) Token: 0x060053DE RID: 21470 RVA: 0x000202ED File Offset: 0x0001E4ED
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001571 RID: 5489
			// (get) Token: 0x060053DF RID: 21471 RVA: 0x00174368 File Offset: 0x00172568
			// (set) Token: 0x060053E0 RID: 21472 RVA: 0x0002031B File Offset: 0x0001E51B
			public unsafe CryptoStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001572 RID: 5490
			// (get) Token: 0x060053E1 RID: 21473 RVA: 0x00174398 File Offset: 0x00172598
			// (set) Token: 0x060053E2 RID: 21474 RVA: 0x0002033A File Offset: 0x0001E53A
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17001573 RID: 5491
			// (get) Token: 0x060053E3 RID: 21475 RVA: 0x001743C0 File Offset: 0x001725C0
			// (set) Token: 0x060053E4 RID: 21476 RVA: 0x00020355 File Offset: 0x0001E555
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17001574 RID: 5492
			// (get) Token: 0x060053E5 RID: 21477 RVA: 0x001743E8 File Offset: 0x001725E8
			// (set) Token: 0x060053E6 RID: 21478 RVA: 0x00020370 File Offset: 0x0001E570
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001575 RID: 5493
			// (get) Token: 0x060053E7 RID: 21479 RVA: 0x00174418 File Offset: 0x00172618
			// (set) Token: 0x060053E8 RID: 21480 RVA: 0x0002038F File Offset: 0x0001E58F
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001576 RID: 5494
			// (get) Token: 0x060053E9 RID: 21481 RVA: 0x00174448 File Offset: 0x00172648
			// (set) Token: 0x060053EA RID: 21482 RVA: 0x000203BD File Offset: 0x0001E5BD
			public unsafe Il2CppStructArray<byte> _tempInputBuffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__tempInputBuffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__tempInputBuffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001577 RID: 5495
			// (get) Token: 0x060053EB RID: 21483 RVA: 0x00174478 File Offset: 0x00172678
			// (set) Token: 0x060053EC RID: 21484 RVA: 0x000203DC File Offset: 0x0001E5DC
			public unsafe int _currentOutputIndex_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__currentOutputIndex_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__currentOutputIndex_5__2)) = value;
				}
			}

			// Token: 0x17001578 RID: 5496
			// (get) Token: 0x060053ED RID: 21485 RVA: 0x001744A0 File Offset: 0x001726A0
			// (set) Token: 0x060053EE RID: 21486 RVA: 0x000203F7 File Offset: 0x0001E5F7
			public unsafe int _bytesToDeliver_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__bytesToDeliver_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__bytesToDeliver_5__3)) = value;
				}
			}

			// Token: 0x17001579 RID: 5497
			// (get) Token: 0x060053EF RID: 21487 RVA: 0x001744C8 File Offset: 0x001726C8
			// (set) Token: 0x060053F0 RID: 21488 RVA: 0x00020412 File Offset: 0x0001E612
			public unsafe SemaphoreSlim _sem_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__sem_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr__sem_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700157A RID: 5498
			// (get) Token: 0x060053F1 RID: 21489 RVA: 0x001744F8 File Offset: 0x001726F8
			// (set) Token: 0x060053F2 RID: 21490 RVA: 0x00020431 File Offset: 0x0001E631
			public unsafe CryptoStream.HopToThreadPoolAwaitable __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__1)) = value;
				}
			}

			// Token: 0x1700157B RID: 5499
			// (get) Token: 0x060053F3 RID: 21491 RVA: 0x00174520 File Offset: 0x00172720
			// (set) Token: 0x060053F4 RID: 21492 RVA: 0x0002044C File Offset: 0x0001E64C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700157C RID: 5500
			// (get) Token: 0x060053F5 RID: 21493 RVA: 0x00174550 File Offset: 0x00172750
			// (set) Token: 0x060053F6 RID: 21494 RVA: 0x0002047A File Offset: 0x0001E67A
			public unsafe int __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___7__wrap1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___7__wrap1)) = value;
				}
			}

			// Token: 0x1700157D RID: 5501
			// (get) Token: 0x060053F7 RID: 21495 RVA: 0x00174578 File Offset: 0x00172778
			// (set) Token: 0x060053F8 RID: 21496 RVA: 0x00020495 File Offset: 0x0001E695
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__34.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040043AD RID: 17325
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040043AE RID: 17326
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040043AF RID: 17327
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040043B0 RID: 17328
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x040043B1 RID: 17329
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040043B2 RID: 17330
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040043B3 RID: 17331
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040043B4 RID: 17332
			private static readonly IntPtr NativeFieldInfoPtr__tempInputBuffer_5__1;

			// Token: 0x040043B5 RID: 17333
			private static readonly IntPtr NativeFieldInfoPtr__currentOutputIndex_5__2;

			// Token: 0x040043B6 RID: 17334
			private static readonly IntPtr NativeFieldInfoPtr__bytesToDeliver_5__3;

			// Token: 0x040043B7 RID: 17335
			private static readonly IntPtr NativeFieldInfoPtr__sem_5__4;

			// Token: 0x040043B8 RID: 17336
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040043B9 RID: 17337
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040043BA RID: 17338
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040043BB RID: 17339
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040043BC RID: 17340
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040043BD RID: 17341
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000625 RID: 1573
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<WriteAsyncInternal>d__37")]
		public sealed class _WriteAsyncInternal_d__37 : ValueType
		{
			// Token: 0x060053F9 RID: 21497 RVA: 0x001745A8 File Offset: 0x001727A8
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsyncInternal_d__37()
			{
				Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<WriteAsyncInternal>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr);
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>1__state");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>t__builder");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>4__this");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "count");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "offset");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "buffer");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "cancellationToken");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__bytesToWrite_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<bytesToWrite>5__1");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__currentInputIndex_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<currentInputIndex>5__2");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__numWholeBlocksInBytes_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<numWholeBlocksInBytes>5__3");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__sem_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<sem>5__4");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>u__1");
				CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, "<>u__2");
				CryptoStream._WriteAsyncInternal_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, 100670951);
				CryptoStream._WriteAsyncInternal_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr, 100670952);
			}

			// Token: 0x060053FA RID: 21498 RVA: 0x00174700 File Offset: 0x00172900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339003, XrefRangeEnd = 339051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._WriteAsyncInternal_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053FB RID: 21499 RVA: 0x00174738 File Offset: 0x00172938
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._WriteAsyncInternal_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053FC RID: 21500 RVA: 0x000204C3 File Offset: 0x0001E6C3
			public _WriteAsyncInternal_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060053FD RID: 21501 RVA: 0x000204CC File Offset: 0x0001E6CC
			public _WriteAsyncInternal_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x1700157E RID: 5502
			// (get) Token: 0x060053FE RID: 21502 RVA: 0x00174780 File Offset: 0x00172980
			// (set) Token: 0x060053FF RID: 21503 RVA: 0x000204DE File Offset: 0x0001E6DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700157F RID: 5503
			// (get) Token: 0x06005400 RID: 21504 RVA: 0x001747A8 File Offset: 0x001729A8
			// (set) Token: 0x06005401 RID: 21505 RVA: 0x000204F9 File Offset: 0x0001E6F9
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001580 RID: 5504
			// (get) Token: 0x06005402 RID: 21506 RVA: 0x001747D8 File Offset: 0x001729D8
			// (set) Token: 0x06005403 RID: 21507 RVA: 0x00020527 File Offset: 0x0001E727
			public unsafe CryptoStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001581 RID: 5505
			// (get) Token: 0x06005404 RID: 21508 RVA: 0x00174808 File Offset: 0x00172A08
			// (set) Token: 0x06005405 RID: 21509 RVA: 0x00020546 File Offset: 0x0001E746
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17001582 RID: 5506
			// (get) Token: 0x06005406 RID: 21510 RVA: 0x00174830 File Offset: 0x00172A30
			// (set) Token: 0x06005407 RID: 21511 RVA: 0x00020561 File Offset: 0x0001E761
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17001583 RID: 5507
			// (get) Token: 0x06005408 RID: 21512 RVA: 0x00174858 File Offset: 0x00172A58
			// (set) Token: 0x06005409 RID: 21513 RVA: 0x0002057C File Offset: 0x0001E77C
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001584 RID: 5508
			// (get) Token: 0x0600540A RID: 21514 RVA: 0x00174888 File Offset: 0x00172A88
			// (set) Token: 0x0600540B RID: 21515 RVA: 0x0002059B File Offset: 0x0001E79B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001585 RID: 5509
			// (get) Token: 0x0600540C RID: 21516 RVA: 0x001748B8 File Offset: 0x00172AB8
			// (set) Token: 0x0600540D RID: 21517 RVA: 0x000205C9 File Offset: 0x0001E7C9
			public unsafe int _bytesToWrite_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__bytesToWrite_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__bytesToWrite_5__1)) = value;
				}
			}

			// Token: 0x17001586 RID: 5510
			// (get) Token: 0x0600540E RID: 21518 RVA: 0x001748E0 File Offset: 0x00172AE0
			// (set) Token: 0x0600540F RID: 21519 RVA: 0x000205E4 File Offset: 0x0001E7E4
			public unsafe int _currentInputIndex_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__currentInputIndex_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__currentInputIndex_5__2)) = value;
				}
			}

			// Token: 0x17001587 RID: 5511
			// (get) Token: 0x06005410 RID: 21520 RVA: 0x00174908 File Offset: 0x00172B08
			// (set) Token: 0x06005411 RID: 21521 RVA: 0x000205FF File Offset: 0x0001E7FF
			public unsafe int _numWholeBlocksInBytes_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__numWholeBlocksInBytes_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__numWholeBlocksInBytes_5__3)) = value;
				}
			}

			// Token: 0x17001588 RID: 5512
			// (get) Token: 0x06005412 RID: 21522 RVA: 0x00174930 File Offset: 0x00172B30
			// (set) Token: 0x06005413 RID: 21523 RVA: 0x0002061A File Offset: 0x0001E81A
			public unsafe SemaphoreSlim _sem_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__sem_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr__sem_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001589 RID: 5513
			// (get) Token: 0x06005414 RID: 21524 RVA: 0x00174960 File Offset: 0x00172B60
			// (set) Token: 0x06005415 RID: 21525 RVA: 0x00020639 File Offset: 0x0001E839
			public unsafe CryptoStream.HopToThreadPoolAwaitable __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__1)) = value;
				}
			}

			// Token: 0x1700158A RID: 5514
			// (get) Token: 0x06005416 RID: 21526 RVA: 0x00174988 File Offset: 0x00172B88
			// (set) Token: 0x06005417 RID: 21527 RVA: 0x00020654 File Offset: 0x0001E854
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__37.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040043BE RID: 17342
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040043BF RID: 17343
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040043C0 RID: 17344
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040043C1 RID: 17345
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x040043C2 RID: 17346
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040043C3 RID: 17347
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040043C4 RID: 17348
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040043C5 RID: 17349
			private static readonly IntPtr NativeFieldInfoPtr__bytesToWrite_5__1;

			// Token: 0x040043C6 RID: 17350
			private static readonly IntPtr NativeFieldInfoPtr__currentInputIndex_5__2;

			// Token: 0x040043C7 RID: 17351
			private static readonly IntPtr NativeFieldInfoPtr__numWholeBlocksInBytes_5__3;

			// Token: 0x040043C8 RID: 17352
			private static readonly IntPtr NativeFieldInfoPtr__sem_5__4;

			// Token: 0x040043C9 RID: 17353
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040043CA RID: 17354
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040043CB RID: 17355
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040043CC RID: 17356
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
