using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200001D RID: 29
	public class ICertificateValidator2 : Il2CppObjectBase
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00002AF9 File Offset: 0x00000CF9
		// Note: this type is marked as 'beforefieldinit'.
		static ICertificateValidator2()
		{
			Il2CppClassPointerStore<ICertificateValidator2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "ICertificateValidator2");
			ICertificateValidator2.NativeMethodInfoPtr_ValidateCertificate_Public_Abstract_Virtual_New_ValidationResult_String_Boolean_X509Certificate_X509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICertificateValidator2>.NativeClassPtr, 100663500);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000090EC File Offset: 0x000072EC
		[CallerCount(0)]
		public unsafe virtual ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509Certificate leaf, X509Chain chain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICertificateValidator2.NativeMethodInfoPtr_ValidateCertificate_Public_Abstract_Virtual_New_ValidationResult_String_Boolean_X509Certificate_X509Chain_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationResult>(intPtr3) : null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002B28 File Offset: 0x00000D28
		public ICertificateValidator2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Public_Abstract_Virtual_New_ValidationResult_String_Boolean_X509Certificate_X509Chain_0;
	}
}
