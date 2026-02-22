using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000124 RID: 292
	public class NetworkStream : Stream
	{
		// Token: 0x06001352 RID: 4946 RVA: 0x000589B4 File Offset: 0x00056BB4
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkStream()
		{
			Il2CppClassPointerStore<NetworkStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "NetworkStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr);
			NetworkStream.NativeFieldInfoPtr_m_StreamSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, "m_StreamSocket");
			NetworkStream.NativeFieldInfoPtr_m_Readable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, "m_Readable");
			NetworkStream.NativeFieldInfoPtr_m_Writeable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, "m_Writeable");
			NetworkStream.NativeFieldInfoPtr_m_OwnsSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, "m_OwnsSocket");
			NetworkStream.NativeFieldInfoPtr_m_CloseTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, "m_CloseTimeout");
			NetworkStream.NativeFieldInfoPtr_m_CleanedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, "m_CleanedUp");
			NetworkStream.NativeFieldInfoPtr_m_CurrentReadTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, "m_CurrentReadTimeout");
			NetworkStream.NativeFieldInfoPtr_m_CurrentWriteTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, "m_CurrentWriteTimeout");
			NetworkStream.NativeMethodInfoPtr__ctor_Public_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100665995);
			NetworkStream.NativeMethodInfoPtr__ctor_Public_Void_Socket_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100665996);
			NetworkStream.NativeMethodInfoPtr_get_InternalSocket_Internal_get_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100665997);
			NetworkStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100665998);
			NetworkStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100665999);
			NetworkStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666000);
			NetworkStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666001);
			NetworkStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666002);
			NetworkStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666003);
			NetworkStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666004);
			NetworkStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666005);
			NetworkStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666006);
			NetworkStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666007);
			NetworkStream.NativeMethodInfoPtr_InitNetworkStream_Internal_Void_Socket_FileAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666008);
			NetworkStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666009);
			NetworkStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666010);
			NetworkStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666011);
			NetworkStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666012);
			NetworkStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666013);
			NetworkStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666014);
			NetworkStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666015);
			NetworkStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666016);
			NetworkStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666017);
			NetworkStream.NativeMethodInfoPtr_SetSocketTimeoutOption_Internal_Void_SocketShutdown_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr, 100666018);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00058C64 File Offset: 0x00056E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55687, RefRangeEnd = 55688, XrefRangeStart = 55676, XrefRangeEnd = 55687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkStream(Socket socket)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkStream.NativeMethodInfoPtr__ctor_Public_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00058CB0 File Offset: 0x00056EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 55693, RefRangeEnd = 55696, XrefRangeStart = 55688, XrefRangeEnd = 55693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkStream(Socket socket, bool ownsSocket)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsSocket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkStream.NativeMethodInfoPtr__ctor_Public_Void_Socket_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00058D0C File Offset: 0x00056F0C
		public unsafe Socket InternalSocket
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55697, RefRangeEnd = 55698, XrefRangeStart = 55696, XrefRangeEnd = 55697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkStream.NativeMethodInfoPtr_get_InternalSocket_Internal_get_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00058D4C File Offset: 0x00056F4C
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00058D94 File Offset: 0x00056F94
		public unsafe override bool CanSeek
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00058DDC File Offset: 0x00056FDC
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00058E24 File Offset: 0x00057024
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x00058E6C File Offset: 0x0005706C
		public unsafe override int ReadTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55698, XrefRangeEnd = 55702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55702, XrefRangeEnd = 55703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00058EB8 File Offset: 0x000570B8
		public unsafe override int WriteTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55703, XrefRangeEnd = 55707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00058F00 File Offset: 0x00057100
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55707, XrefRangeEnd = 55714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00058F48 File Offset: 0x00057148
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x00058F90 File Offset: 0x00057190
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55714, XrefRangeEnd = 55721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55721, XrefRangeEnd = 55728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00058FDC File Offset: 0x000571DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55728, XrefRangeEnd = 55735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00059040 File Offset: 0x00057240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 55735, RefRangeEnd = 55737, XrefRangeStart = 55735, XrefRangeEnd = 55735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNetworkStream(Socket socket, FileAccess Access)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Access;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkStream.NativeMethodInfoPtr_InitNetworkStream_Internal_Void_Socket_FileAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00059090 File Offset: 0x00057290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55737, XrefRangeEnd = 55739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int size)
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00059118 File Offset: 0x00057318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55739, XrefRangeEnd = 55749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00059184 File Offset: 0x00057384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55749, XrefRangeEnd = 55754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000591D0 File Offset: 0x000573D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0005920C File Offset: 0x0005740C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55754, XrefRangeEnd = 55756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback callback, Object state)
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x000592AC File Offset: 0x000574AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55756, XrefRangeEnd = 55758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00059304 File Offset: 0x00057504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55758, XrefRangeEnd = 55760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback callback, Object state)
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x000593A4 File Offset: 0x000575A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55760, XrefRangeEnd = 55770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000593F4 File Offset: 0x000575F4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00059430 File Offset: 0x00057630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55770, XrefRangeEnd = 55772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkStream.NativeMethodInfoPtr_SetSocketTimeoutOption_Internal_Void_SocketShutdown_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00009EC3 File Offset: 0x000080C3
		public NetworkStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0005948C File Offset: 0x0005768C
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x00009ECC File Offset: 0x000080CC
		public unsafe Socket m_StreamSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_StreamSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_StreamSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x000594BC File Offset: 0x000576BC
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00009EEB File Offset: 0x000080EB
		public unsafe bool m_Readable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_Readable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_Readable)) = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x000594E4 File Offset: 0x000576E4
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x00009F06 File Offset: 0x00008106
		public unsafe bool m_Writeable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_Writeable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_Writeable)) = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0005950C File Offset: 0x0005770C
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x00009F21 File Offset: 0x00008121
		public unsafe bool m_OwnsSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_OwnsSocket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_OwnsSocket)) = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00059534 File Offset: 0x00057734
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00009F3C File Offset: 0x0000813C
		public unsafe int m_CloseTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_CloseTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_CloseTimeout)) = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0005955C File Offset: 0x0005775C
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x00009F57 File Offset: 0x00008157
		public unsafe bool m_CleanedUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_CleanedUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_CleanedUp)) = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00059584 File Offset: 0x00057784
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x00009F72 File Offset: 0x00008172
		public unsafe int m_CurrentReadTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_CurrentReadTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_CurrentReadTimeout)) = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x000595AC File Offset: 0x000577AC
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x00009F8D File Offset: 0x0000818D
		public unsafe int m_CurrentWriteTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_CurrentWriteTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkStream.NativeFieldInfoPtr_m_CurrentWriteTimeout)) = value;
			}
		}

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeFieldInfoPtr_m_StreamSocket;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeFieldInfoPtr_m_Readable;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr_m_Writeable;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr_m_OwnsSocket;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr_m_CloseTimeout;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr_m_CleanedUp;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentReadTimeout;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentWriteTimeout;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Socket_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Socket_Boolean_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSocket_Internal_get_Socket_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_InitNetworkStream_Internal_Void_Socket_FileAccess_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketTimeoutOption_Internal_Void_SocketShutdown_Int32_Boolean_0;
	}
}
