using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FE RID: 766
	public class RSA : AsymmetricAlgorithm
	{
		// Token: 0x0600320E RID: 12814 RVA: 0x000F7CB0 File Offset: 0x000F5EB0
		// Note: this type is marked as 'beforefieldinit'.
		static RSA()
		{
			Il2CppClassPointerStore<RSA>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSA>.NativeClassPtr);
			RSA.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100671109);
			RSA.NativeMethodInfoPtr_Create_Public_Static_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100671110);
			RSA.NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100671111);
			RSA.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100671112);
			RSA.NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_RSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100671113);
			RSA.NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_RSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100671114);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x000F7D58 File Offset: 0x000F5F58
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSA()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSA>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSA.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x000F7D94 File Offset: 0x000F5F94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340291, RefRangeEnd = 340294, XrefRangeStart = 340286, XrefRangeEnd = 340291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSA.NativeMethodInfoPtr_Create_Public_Static_RSA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000F7DC8 File Offset: 0x000F5FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340294, XrefRangeEnd = 340356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FromXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000F7E18 File Offset: 0x000F6018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340356, XrefRangeEnd = 340428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToXmlString(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000F7E68 File Offset: 0x000F6068
		[CallerCount(0)]
		public unsafe virtual RSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_RSAParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RSAParameters(intPtr);
			}
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000F7EB8 File Offset: 0x000F60B8
		[CallerCount(0)]
		public unsafe virtual void ImportParameters(RSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_RSAParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x00011CD5 File Offset: 0x0000FED5
		public RSA(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002ACC RID: 10956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002ACD RID: 10957
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RSA_0;

		// Token: 0x04002ACE RID: 10958
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0;

		// Token: 0x04002ACF RID: 10959
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0;

		// Token: 0x04002AD0 RID: 10960
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_RSAParameters_Boolean_0;

		// Token: 0x04002AD1 RID: 10961
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_RSAParameters_0;
	}
}
