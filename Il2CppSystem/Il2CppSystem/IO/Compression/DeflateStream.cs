using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO.Compression
{
	// Token: 0x020000A2 RID: 162
	public class DeflateStream : Stream
	{
		// Token: 0x06000995 RID: 2453 RVA: 0x00033BD8 File Offset: 0x00031DD8
		// Note: this type is marked as 'beforefieldinit'.
		static DeflateStream()
		{
			Il2CppClassPointerStore<DeflateStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO.Compression", "DeflateStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr);
			DeflateStream.NativeFieldInfoPtr_base_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, "base_stream");
			DeflateStream.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, "mode");
			DeflateStream.NativeFieldInfoPtr_leaveOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, "leaveOpen");
			DeflateStream.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, "disposed");
			DeflateStream.NativeFieldInfoPtr_native = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, "native");
			DeflateStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_CompressionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664542);
			DeflateStream.NativeMethodInfoPtr__ctor_Internal_Void_Stream_CompressionMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664543);
			DeflateStream.NativeMethodInfoPtr__ctor_Internal_Void_Stream_CompressionMode_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664544);
			DeflateStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664545);
			DeflateStream.NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664546);
			DeflateStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664547);
			DeflateStream.NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664548);
			DeflateStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664549);
			DeflateStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664550);
			DeflateStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664551);
			DeflateStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664552);
			DeflateStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664553);
			DeflateStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664554);
			DeflateStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664555);
			DeflateStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664556);
			DeflateStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664557);
			DeflateStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664558);
			DeflateStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664559);
			DeflateStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664560);
			DeflateStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, 100664561);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00033DFC File Offset: 0x00031FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43388, XrefRangeEnd = 43389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflateStream(Stream stream, CompressionMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_CompressionMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00033E58 File Offset: 0x00032058
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43390, RefRangeEnd = 43393, XrefRangeStart = 43389, XrefRangeEnd = 43390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref windowsBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.NativeMethodInfoPtr__ctor_Internal_Void_Stream_CompressionMode_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00033ED0 File Offset: 0x000320D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43419, XrefRangeStart = 43393, XrefRangeEnd = 43417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(compressedStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gzip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.NativeMethodInfoPtr__ctor_Internal_Void_Stream_CompressionMode_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00033F48 File Offset: 0x00032148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43419, XrefRangeEnd = 43422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00033F94 File Offset: 0x00032194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43422, XrefRangeEnd = 43429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInternal(Il2CppStructArray<byte> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00034000 File Offset: 0x00032200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43429, XrefRangeEnd = 43437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00034074 File Offset: 0x00032274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43437, XrefRangeEnd = 43444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInternal(Il2CppStructArray<byte> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000340D4 File Offset: 0x000322D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43444, XrefRangeEnd = 43451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00034140 File Offset: 0x00032340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43451, XrefRangeEnd = 43457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0003417C File Offset: 0x0003237C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43457, XrefRangeEnd = 43505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> array, int offset, int count, AsyncCallback asyncCallback, Object asyncState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0003421C File Offset: 0x0003241C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43505, XrefRangeEnd = 43553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> array, int offset, int count, AsyncCallback asyncCallback, Object asyncState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000342BC File Offset: 0x000324BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43553, XrefRangeEnd = 43578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00034314 File Offset: 0x00032514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43578, XrefRangeEnd = 43603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00034364 File Offset: 0x00032564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43603, XrefRangeEnd = 43608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x000343C8 File Offset: 0x000325C8
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00034410 File Offset: 0x00032610
		public unsafe override bool CanSeek
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00034458 File Offset: 0x00032658
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000344A0 File Offset: 0x000326A0
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43608, XrefRangeEnd = 43613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x000344E8 File Offset: 0x000326E8
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00034530 File Offset: 0x00032730
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43613, XrefRangeEnd = 43618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43618, XrefRangeEnd = 43623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public DeflateStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0003457C File Offset: 0x0003277C
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00005DE1 File Offset: 0x00003FE1
		public unsafe Stream base_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_base_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_base_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x000345AC File Offset: 0x000327AC
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00005E00 File Offset: 0x00004000
		public unsafe CompressionMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x000345D4 File Offset: 0x000327D4
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00005E1B File Offset: 0x0000401B
		public unsafe bool leaveOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_leaveOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_leaveOpen)) = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000345FC File Offset: 0x000327FC
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00005E36 File Offset: 0x00004036
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00034624 File Offset: 0x00032824
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00005E51 File Offset: 0x00004051
		public unsafe DeflateStreamNative native
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_native);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStream.NativeFieldInfoPtr_native), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_base_stream;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_leaveOpen;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_native;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_CompressionMode_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_CompressionMode_Boolean_Int32_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_CompressionMode_Boolean_Boolean_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x02000196 RID: 406
		public sealed class ReadMethod : MulticastDelegate
		{
			// Token: 0x0600175B RID: 5979 RVA: 0x000651D8 File Offset: 0x000633D8
			// Note: this type is marked as 'beforefieldinit'.
			static ReadMethod()
			{
				Il2CppClassPointerStore<DeflateStream.ReadMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, "ReadMethod");
				DeflateStream.ReadMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream.ReadMethod>.NativeClassPtr, 100664562);
				DeflateStream.ReadMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream.ReadMethod>.NativeClassPtr, 100664563);
				DeflateStream.ReadMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream.ReadMethod>.NativeClassPtr, 100664564);
				DeflateStream.ReadMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream.ReadMethod>.NativeClassPtr, 100664565);
			}

			// Token: 0x0600175C RID: 5980 RVA: 0x0006524C File Offset: 0x0006344C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadMethod(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStream.ReadMethod>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.ReadMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600175D RID: 5981 RVA: 0x000652A8 File Offset: 0x000634A8
			[CallerCount(0)]
			public unsafe int Invoke(Il2CppStructArray<byte> array, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.ReadMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600175E RID: 5982 RVA: 0x00065314 File Offset: 0x00063514
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43349, RefRangeEnd = 43350, XrefRangeStart = 43343, XrefRangeEnd = 43349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<byte> array, int offset, int count, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.ReadMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600175F RID: 5983 RVA: 0x000653A8 File Offset: 0x000635A8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43352, RefRangeEnd = 43355, XrefRangeStart = 43350, XrefRangeEnd = 43352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.ReadMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001760 RID: 5984 RVA: 0x0000C5C1 File Offset: 0x0000A7C1
			public ReadMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001761 RID: 5985 RVA: 0x0000C5CA File Offset: 0x0000A7CA
			public static implicit operator DeflateStream.ReadMethod(Func<Il2CppStructArray<byte>, int, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DeflateStream.ReadMethod>(A_0);
			}

			// Token: 0x06001762 RID: 5986 RVA: 0x0000C5D2 File Offset: 0x0000A7D2
			public static DeflateStream.ReadMethod operator +(DeflateStream.ReadMethod A_0, DeflateStream.ReadMethod A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DeflateStream.ReadMethod>();
			}

			// Token: 0x06001763 RID: 5987 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
			public static DeflateStream.ReadMethod operator -(DeflateStream.ReadMethod A_0, DeflateStream.ReadMethod A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DeflateStream.ReadMethod>();
				}
				return delegate2;
			}

			// Token: 0x040012AC RID: 4780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012AD RID: 4781
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x040012AE RID: 4782
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x040012AF RID: 4783
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x02000197 RID: 407
		public sealed class WriteMethod : MulticastDelegate
		{
			// Token: 0x06001764 RID: 5988 RVA: 0x000653F8 File Offset: 0x000635F8
			// Note: this type is marked as 'beforefieldinit'.
			static WriteMethod()
			{
				Il2CppClassPointerStore<DeflateStream.WriteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateStream>.NativeClassPtr, "WriteMethod");
				DeflateStream.WriteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream.WriteMethod>.NativeClassPtr, 100664566);
				DeflateStream.WriteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream.WriteMethod>.NativeClassPtr, 100664567);
				DeflateStream.WriteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream.WriteMethod>.NativeClassPtr, 100664568);
				DeflateStream.WriteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStream.WriteMethod>.NativeClassPtr, 100664569);
			}

			// Token: 0x06001765 RID: 5989 RVA: 0x0006546C File Offset: 0x0006366C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WriteMethod(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStream.WriteMethod>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.WriteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001766 RID: 5990 RVA: 0x000654C8 File Offset: 0x000636C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43355, XrefRangeEnd = 43371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Il2CppStructArray<byte> array, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.WriteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001767 RID: 5991 RVA: 0x00065528 File Offset: 0x00063728
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43377, RefRangeEnd = 43378, XrefRangeStart = 43371, XrefRangeEnd = 43377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<byte> array, int offset, int count, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.WriteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001768 RID: 5992 RVA: 0x000655BC File Offset: 0x000637BC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43378, XrefRangeEnd = 43385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStream.WriteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001769 RID: 5993 RVA: 0x0000C5F1 File Offset: 0x0000A7F1
			public WriteMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600176A RID: 5994 RVA: 0x0000C5FA File Offset: 0x0000A7FA
			public static implicit operator DeflateStream.WriteMethod(Action<Il2CppStructArray<byte>, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DeflateStream.WriteMethod>(A_0);
			}

			// Token: 0x0600176B RID: 5995 RVA: 0x0000C602 File Offset: 0x0000A802
			public static DeflateStream.WriteMethod operator +(DeflateStream.WriteMethod A_0, DeflateStream.WriteMethod A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DeflateStream.WriteMethod>();
			}

			// Token: 0x0600176C RID: 5996 RVA: 0x0000C610 File Offset: 0x0000A810
			public static DeflateStream.WriteMethod operator -(DeflateStream.WriteMethod A_0, DeflateStream.WriteMethod A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DeflateStream.WriteMethod>();
				}
				return delegate2;
			}

			// Token: 0x040012B0 RID: 4784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012B1 RID: 4785
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x040012B2 RID: 4786
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x040012B3 RID: 4787
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
