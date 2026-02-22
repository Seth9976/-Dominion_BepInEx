using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000053 RID: 83
	public class XmlRegisteredNonCachedStream : Stream
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x000282D4 File Offset: 0x000264D4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlRegisteredNonCachedStream()
		{
			Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlRegisteredNonCachedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr);
			XmlRegisteredNonCachedStream.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, "stream");
			XmlRegisteredNonCachedStream.NativeFieldInfoPtr_downloadManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, "downloadManager");
			XmlRegisteredNonCachedStream.NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, "host");
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr__ctor_Internal_Void_Stream_XmlDownloadManager_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664505);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664506);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664507);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664508);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664509);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664510);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664511);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664512);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664513);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664514);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664515);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664516);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664517);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664518);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664519);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664520);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664521);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664522);
			XmlRegisteredNonCachedStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr, 100664523);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000284BC File Offset: 0x000266BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20455, RefRangeEnd = 20457, XrefRangeStart = 20451, XrefRangeEnd = 20455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlRegisteredNonCachedStream(Stream stream, XmlDownloadManager downloadManager, string host)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlRegisteredNonCachedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(host);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRegisteredNonCachedStream.NativeMethodInfoPtr__ctor_Internal_Void_Stream_XmlDownloadManager_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0002852C File Offset: 0x0002672C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20457, XrefRangeEnd = 20461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00028568 File Offset: 0x00026768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20461, XrefRangeEnd = 20469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000285B4 File Offset: 0x000267B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20469, XrefRangeEnd = 20470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00028654 File Offset: 0x00026854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20470, XrefRangeEnd = 20471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000286F4 File Offset: 0x000268F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20471, XrefRangeEnd = 20472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0002874C File Offset: 0x0002694C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20472, XrefRangeEnd = 20473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0002879C File Offset: 0x0002699C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20473, XrefRangeEnd = 20474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000287D8 File Offset: 0x000269D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20474, XrefRangeEnd = 20475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0002884C File Offset: 0x00026A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20475, XrefRangeEnd = 20476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00028894 File Offset: 0x00026A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20476, XrefRangeEnd = 20477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000288F8 File Offset: 0x00026AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20477, XrefRangeEnd = 20478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00028964 File Offset: 0x00026B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20478, XrefRangeEnd = 20479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x000289B0 File Offset: 0x00026BB0
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20479, XrefRangeEnd = 20480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x000289F8 File Offset: 0x00026BF8
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20480, XrefRangeEnd = 20481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00028A40 File Offset: 0x00026C40
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20481, XrefRangeEnd = 20482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00028A88 File Offset: 0x00026C88
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20482, XrefRangeEnd = 20483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00028AD0 File Offset: 0x00026CD0
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00028B18 File Offset: 0x00026D18
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20483, XrefRangeEnd = 20484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20484, XrefRangeEnd = 20485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRegisteredNonCachedStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000459D File Offset: 0x0000279D
		public XmlRegisteredNonCachedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00028B64 File Offset: 0x00026D64
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x000045A6 File Offset: 0x000027A6
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRegisteredNonCachedStream.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRegisteredNonCachedStream.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00028B94 File Offset: 0x00026D94
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x000045C5 File Offset: 0x000027C5
		public unsafe XmlDownloadManager downloadManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRegisteredNonCachedStream.NativeFieldInfoPtr_downloadManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDownloadManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRegisteredNonCachedStream.NativeFieldInfoPtr_downloadManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00028BC4 File Offset: 0x00026DC4
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000045E4 File Offset: 0x000027E4
		public unsafe string host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRegisteredNonCachedStream.NativeFieldInfoPtr_host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRegisteredNonCachedStream.NativeFieldInfoPtr_host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_downloadManager;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_host;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_XmlDownloadManager_String_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;
	}
}
