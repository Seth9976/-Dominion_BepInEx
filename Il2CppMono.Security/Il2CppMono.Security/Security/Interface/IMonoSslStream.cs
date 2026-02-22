using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000020 RID: 32
	public class IMonoSslStream : Il2CppObjectBase
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00009270 File Offset: 0x00007470
		// Note: this type is marked as 'beforefieldinit'.
		static IMonoSslStream()
		{
			Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "IMonoSslStream");
			IMonoSslStream.NativeMethodInfoPtr_AuthenticateAsClient_Public_Abstract_Virtual_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663503);
			IMonoSslStream.NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Abstract_Virtual_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663504);
			IMonoSslStream.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663505);
			IMonoSslStream.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663506);
			IMonoSslStream.NativeMethodInfoPtr_BeginRead_Public_Abstract_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663507);
			IMonoSslStream.NativeMethodInfoPtr_EndRead_Public_Abstract_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663508);
			IMonoSslStream.NativeMethodInfoPtr_BeginWrite_Public_Abstract_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663509);
			IMonoSslStream.NativeMethodInfoPtr_EndWrite_Public_Abstract_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663510);
			IMonoSslStream.NativeMethodInfoPtr_WriteAsync_Public_Abstract_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663511);
			IMonoSslStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663512);
			IMonoSslStream.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663513);
			IMonoSslStream.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663514);
			IMonoSslStream.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663515);
			IMonoSslStream.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663516);
			IMonoSslStream.NativeMethodInfoPtr_get_AuthenticatedStream_Public_Abstract_Virtual_New_get_AuthenticatedStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663517);
			IMonoSslStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663518);
			IMonoSslStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663519);
			IMonoSslStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663520);
			IMonoSslStream.NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Abstract_Virtual_New_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoSslStream>.NativeClassPtr, 100663521);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00009414 File Offset: 0x00007614
		[CallerCount(0)]
		public unsafe virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_AuthenticateAsClient_Public_Abstract_Virtual_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00009490 File Offset: 0x00007690
		[CallerCount(0)]
		public unsafe virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Abstract_Virtual_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000951C File Offset: 0x0000771C
		[CallerCount(0)]
		public unsafe virtual int Read(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00009590 File Offset: 0x00007790
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000095FC File Offset: 0x000077FC
		[CallerCount(0)]
		public unsafe virtual IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback asyncCallback, Object asyncState)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_BeginRead_Public_Abstract_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000969C File Offset: 0x0000789C
		[CallerCount(0)]
		public unsafe virtual int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_EndRead_Public_Abstract_Virtual_New_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000096F4 File Offset: 0x000078F4
		[CallerCount(0)]
		public unsafe virtual IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback asyncCallback, Object asyncState)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_BeginWrite_Public_Abstract_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009794 File Offset: 0x00007994
		[CallerCount(0)]
		public unsafe virtual void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_EndWrite_Public_Abstract_Virtual_New_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000097E4 File Offset: 0x000079E4
		[CallerCount(0)]
		public unsafe virtual Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_WriteAsync_Public_Abstract_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00009874 File Offset: 0x00007A74
		public unsafe virtual bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000098BC File Offset: 0x00007ABC
		public unsafe virtual bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00009904 File Offset: 0x00007B04
		public unsafe virtual bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000994C File Offset: 0x00007B4C
		public unsafe virtual long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00009994 File Offset: 0x00007B94
		public unsafe virtual long Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000099DC File Offset: 0x00007BDC
		public unsafe virtual AuthenticatedStream AuthenticatedStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_AuthenticatedStream_Public_Abstract_Virtual_New_get_AuthenticatedStream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthenticatedStream>(intPtr3) : null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00009A28 File Offset: 0x00007C28
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00009A70 File Offset: 0x00007C70
		public unsafe virtual int ReadTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00009ABC File Offset: 0x00007CBC
		public unsafe virtual int WriteTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00009B04 File Offset: 0x00007D04
		public unsafe virtual X509Certificate InternalLocalCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoSslStream.NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Abstract_Virtual_New_get_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002B56 File Offset: 0x00000D56
		public IMonoSslStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsClient_Public_Abstract_Virtual_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Abstract_Virtual_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Abstract_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Abstract_Virtual_New_Int32_IAsyncResult_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Abstract_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Abstract_Virtual_New_Void_IAsyncResult_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Abstract_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticatedStream_Public_Abstract_Virtual_New_get_AuthenticatedStream_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Abstract_Virtual_New_get_X509Certificate_0;
	}
}
