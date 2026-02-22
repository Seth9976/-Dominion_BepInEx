using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net
{
	// Token: 0x02000107 RID: 263
	public class FtpDataStream : Stream
	{
		// Token: 0x06000F6C RID: 3948 RVA: 0x0004A54C File Offset: 0x0004874C
		// Note: this type is marked as 'beforefieldinit'.
		static FtpDataStream()
		{
			Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpDataStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr);
			FtpDataStream.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, "request");
			FtpDataStream.NativeFieldInfoPtr_networkStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, "networkStream");
			FtpDataStream.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, "disposed");
			FtpDataStream.NativeFieldInfoPtr_isRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, "isRead");
			FtpDataStream.NativeFieldInfoPtr_totalRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, "totalRead");
			FtpDataStream.NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665446);
			FtpDataStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665447);
			FtpDataStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665448);
			FtpDataStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665449);
			FtpDataStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665450);
			FtpDataStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665451);
			FtpDataStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665452);
			FtpDataStream.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665453);
			FtpDataStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665454);
			FtpDataStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665455);
			FtpDataStream.NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665456);
			FtpDataStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665457);
			FtpDataStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665458);
			FtpDataStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665459);
			FtpDataStream.NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665460);
			FtpDataStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665461);
			FtpDataStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665462);
			FtpDataStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665463);
			FtpDataStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665464);
			FtpDataStream.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665465);
			FtpDataStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665466);
			FtpDataStream.NativeMethodInfoPtr_CheckDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, 100665467);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0004A798 File Offset: 0x00048998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50305, XrefRangeEnd = 50309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpDataStream(FtpWebRequest request, Stream stream, bool isRead)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0004A804 File Offset: 0x00048A04
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x0004A84C File Offset: 0x00048A4C
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0004A894 File Offset: 0x00048A94
		public unsafe override bool CanSeek
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x0004A8DC File Offset: 0x00048ADC
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50309, XrefRangeEnd = 50314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0004A924 File Offset: 0x00048B24
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x0004A96C File Offset: 0x00048B6C
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50314, XrefRangeEnd = 50319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50319, XrefRangeEnd = 50324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0004A9B8 File Offset: 0x00048BB8
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0004A9F4 File Offset: 0x00048BF4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0004AA30 File Offset: 0x00048C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50324, XrefRangeEnd = 50329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0004AA94 File Offset: 0x00048C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50329, XrefRangeEnd = 50331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInternal(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0004AB00 File Offset: 0x00048D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50331, XrefRangeEnd = 50363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback cb, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0004ABA0 File Offset: 0x00048DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50363, XrefRangeEnd = 50388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0004ABF8 File Offset: 0x00048DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50388, XrefRangeEnd = 50407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0004AC6C File Offset: 0x00048E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50407, XrefRangeEnd = 50408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInternal(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0004ACCC File Offset: 0x00048ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50408, XrefRangeEnd = 50440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback cb, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0004AD6C File Offset: 0x00048F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50440, XrefRangeEnd = 50465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0004ADBC File Offset: 0x00048FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50465, XrefRangeEnd = 50484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0004AE28 File Offset: 0x00049028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50484, XrefRangeEnd = 50487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0004AE64 File Offset: 0x00049064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50487, XrefRangeEnd = 50491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0004AE98 File Offset: 0x00049098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50491, XrefRangeEnd = 50492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpDataStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0004AEE4 File Offset: 0x000490E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50492, RefRangeEnd = 50494, XrefRangeStart = 50492, XrefRangeEnd = 50492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.NativeMethodInfoPtr_CheckDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00008162 File Offset: 0x00006362
		public FtpDataStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0004AF18 File Offset: 0x00049118
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x0000816B File Offset: 0x0000636B
		public unsafe FtpWebRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0004AF48 File Offset: 0x00049148
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x0000818A File Offset: 0x0000638A
		public unsafe Stream networkStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_networkStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_networkStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0004AF78 File Offset: 0x00049178
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x000081A9 File Offset: 0x000063A9
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0004AFA0 File Offset: 0x000491A0
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x000081C4 File Offset: 0x000063C4
		public unsafe bool isRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_isRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_isRead)) = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0004AFC8 File Offset: 0x000491C8
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x000081DF File Offset: 0x000063DF
		public unsafe int totalRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_totalRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpDataStream.NativeFieldInfoPtr_totalRead)) = value;
			}
		}

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeFieldInfoPtr_networkStream;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeFieldInfoPtr_isRead;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeFieldInfoPtr_totalRead;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FtpWebRequest_Stream_Boolean_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Private_Void_0;

		// Token: 0x020001BE RID: 446
		public sealed class WriteDelegate : MulticastDelegate
		{
			// Token: 0x060018EB RID: 6379 RVA: 0x0006A7AC File Offset: 0x000689AC
			// Note: this type is marked as 'beforefieldinit'.
			static WriteDelegate()
			{
				Il2CppClassPointerStore<FtpDataStream.WriteDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, "WriteDelegate");
				FtpDataStream.WriteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream.WriteDelegate>.NativeClassPtr, 100665468);
				FtpDataStream.WriteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream.WriteDelegate>.NativeClassPtr, 100665469);
				FtpDataStream.WriteDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream.WriteDelegate>.NativeClassPtr, 100665470);
				FtpDataStream.WriteDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream.WriteDelegate>.NativeClassPtr, 100665471);
			}

			// Token: 0x060018EC RID: 6380 RVA: 0x0006A820 File Offset: 0x00068A20
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WriteDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpDataStream.WriteDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.WriteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018ED RID: 6381 RVA: 0x0006A87C File Offset: 0x00068A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Il2CppStructArray<byte> buffer, int offset, int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.WriteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018EE RID: 6382 RVA: 0x0006A8DC File Offset: 0x00068ADC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50297, RefRangeEnd = 50298, XrefRangeStart = 50291, XrefRangeEnd = 50297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.WriteDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060018EF RID: 6383 RVA: 0x0006A970 File Offset: 0x00068B70
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.WriteDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018F0 RID: 6384 RVA: 0x0000D144 File Offset: 0x0000B344
			public WriteDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018F1 RID: 6385 RVA: 0x0000D14D File Offset: 0x0000B34D
			public static implicit operator FtpDataStream.WriteDelegate(Action<Il2CppStructArray<byte>, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<FtpDataStream.WriteDelegate>(A_0);
			}

			// Token: 0x060018F2 RID: 6386 RVA: 0x0000D155 File Offset: 0x0000B355
			public static FtpDataStream.WriteDelegate operator +(FtpDataStream.WriteDelegate A_0, FtpDataStream.WriteDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<FtpDataStream.WriteDelegate>();
			}

			// Token: 0x060018F3 RID: 6387 RVA: 0x0000D163 File Offset: 0x0000B363
			public static FtpDataStream.WriteDelegate operator -(FtpDataStream.WriteDelegate A_0, FtpDataStream.WriteDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<FtpDataStream.WriteDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040013A1 RID: 5025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040013A2 RID: 5026
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x040013A3 RID: 5027
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x040013A4 RID: 5028
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001BF RID: 447
		public sealed class ReadDelegate : MulticastDelegate
		{
			// Token: 0x060018F4 RID: 6388 RVA: 0x0006A9B4 File Offset: 0x00068BB4
			// Note: this type is marked as 'beforefieldinit'.
			static ReadDelegate()
			{
				Il2CppClassPointerStore<FtpDataStream.ReadDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FtpDataStream>.NativeClassPtr, "ReadDelegate");
				FtpDataStream.ReadDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream.ReadDelegate>.NativeClassPtr, 100665472);
				FtpDataStream.ReadDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream.ReadDelegate>.NativeClassPtr, 100665473);
				FtpDataStream.ReadDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream.ReadDelegate>.NativeClassPtr, 100665474);
				FtpDataStream.ReadDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpDataStream.ReadDelegate>.NativeClassPtr, 100665475);
			}

			// Token: 0x060018F5 RID: 6389 RVA: 0x0006AA28 File Offset: 0x00068C28
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpDataStream.ReadDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.ReadDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018F6 RID: 6390 RVA: 0x0006AA84 File Offset: 0x00068C84
			[CallerCount(0)]
			public unsafe int Invoke(Il2CppStructArray<byte> buffer, int offset, int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.ReadDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060018F7 RID: 6391 RVA: 0x0006AAF0 File Offset: 0x00068CF0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50304, RefRangeEnd = 50305, XrefRangeStart = 50298, XrefRangeEnd = 50304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.ReadDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060018F8 RID: 6392 RVA: 0x0006AB84 File Offset: 0x00068D84
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43352, RefRangeEnd = 43355, XrefRangeStart = 43352, XrefRangeEnd = 43355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpDataStream.ReadDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018F9 RID: 6393 RVA: 0x0000D174 File Offset: 0x0000B374
			public ReadDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018FA RID: 6394 RVA: 0x0000D17D File Offset: 0x0000B37D
			public static implicit operator FtpDataStream.ReadDelegate(Func<Il2CppStructArray<byte>, int, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<FtpDataStream.ReadDelegate>(A_0);
			}

			// Token: 0x060018FB RID: 6395 RVA: 0x0000D185 File Offset: 0x0000B385
			public static FtpDataStream.ReadDelegate operator +(FtpDataStream.ReadDelegate A_0, FtpDataStream.ReadDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<FtpDataStream.ReadDelegate>();
			}

			// Token: 0x060018FC RID: 6396 RVA: 0x0000D193 File Offset: 0x0000B393
			public static FtpDataStream.ReadDelegate operator -(FtpDataStream.ReadDelegate A_0, FtpDataStream.ReadDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<FtpDataStream.ReadDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040013A5 RID: 5029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040013A6 RID: 5030
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x040013A7 RID: 5031
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x040013A8 RID: 5032
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}
	}
}
