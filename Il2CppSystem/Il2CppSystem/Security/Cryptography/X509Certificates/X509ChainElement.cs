using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000092 RID: 146
	public class X509ChainElement : Object
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x00030B20 File Offset: 0x0002ED20
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainElement()
		{
			Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr);
			X509ChainElement.NativeFieldInfoPtr_certificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, "certificate");
			X509ChainElement.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, "info");
			X509ChainElement.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100664445);
			X509ChainElement.NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100664446);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00030BA0 File Offset: 0x0002EDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42649, XrefRangeEnd = 42652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainElement(X509Certificate2 certificate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00030BEC File Offset: 0x0002EDEC
		public unsafe X509Certificate2 Certificate
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00005803 File Offset: 0x00003A03
		public X509ChainElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00030C2C File Offset: 0x0002EE2C
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x0000580C File Offset: 0x00003A0C
		public unsafe X509Certificate2 certificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_certificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_certificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00030C5C File Offset: 0x0002EE5C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x0000582B File Offset: 0x00003A2B
		public unsafe string info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_info);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_info), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr_certificate;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0;
	}
}
