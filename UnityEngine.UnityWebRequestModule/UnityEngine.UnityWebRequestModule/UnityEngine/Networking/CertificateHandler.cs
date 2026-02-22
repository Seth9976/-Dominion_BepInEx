using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000007 RID: 7
	public class CertificateHandler : Object
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00005C88 File Offset: 0x00003E88
		// Note: this type is marked as 'beforefieldinit'.
		static CertificateHandler()
		{
			Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "CertificateHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr);
			CertificateHandler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, "m_Ptr");
			CertificateHandler.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, 100663382);
			CertificateHandler.NativeMethodInfoPtr_ValidateCertificate_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, 100663383);
			CertificateHandler.NativeMethodInfoPtr_ValidateCertificateNative_Internal_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, 100663384);
			CertificateHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, 100663385);
			CertificateHandler.CreateDelegateField = IL2CPP.ResolveICall<CertificateHandler.CreateDelegate>("UnityEngine.Networking.CertificateHandler::Create");
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005D2C File Offset: 0x00003F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124745, XrefRangeEnd = 124747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHandler.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005D60 File Offset: 0x00003F60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59613, RefRangeEnd = 59618, XrefRangeStart = 59613, XrefRangeEnd = 59618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ValidateCertificate(Il2CppStructArray<byte> certificateData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificateData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CertificateHandler.NativeMethodInfoPtr_ValidateCertificate_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005DB8 File Offset: 0x00003FB8
		[CallerCount(0)]
		public unsafe bool ValidateCertificateNative(Il2CppStructArray<byte> certificateData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificateData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHandler.NativeMethodInfoPtr_ValidateCertificateNative_Internal_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005E08 File Offset: 0x00004008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124747, XrefRangeEnd = 124751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002517 File Offset: 0x00000717
		public CertificateHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005E3C File Offset: 0x0000403C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002520 File Offset: 0x00000720
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateHandler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateHandler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000253B File Offset: 0x0000073B
		public static IntPtr Create(CertificateHandler obj)
		{
			return CertificateHandler.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005E64 File Offset: 0x00004064
		public ~CertificateHandler()
		{
			this.Dispose();
		}

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificateNative_Internal_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000093 RID: 147
		private static readonly CertificateHandler.CreateDelegate CreateDelegateField;

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000185 RID: 389
		private delegate IntPtr CreateDelegate(IntPtr obj);
	}
}
