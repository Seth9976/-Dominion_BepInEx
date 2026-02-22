using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net
{
	// Token: 0x020000C6 RID: 198
	public class ICertificatePolicy : Il2CppObjectBase
	{
		// Token: 0x06000B84 RID: 2948 RVA: 0x000067FA File Offset: 0x000049FA
		// Note: this type is marked as 'beforefieldinit'.
		static ICertificatePolicy()
		{
			Il2CppClassPointerStore<ICertificatePolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICertificatePolicy");
			ICertificatePolicy.NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICertificatePolicy>.NativeClassPtr, 100664940);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0003BFF8 File Offset: 0x0003A1F8
		[CallerCount(0)]
		public unsafe virtual bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(srvPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref certificateProblem;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICertificatePolicy.NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00006829 File Offset: 0x00004A29
		public ICertificatePolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0;
	}
}
