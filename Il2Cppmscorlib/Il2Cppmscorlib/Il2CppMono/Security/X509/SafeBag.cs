using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000022 RID: 34
	public class SafeBag : Object
	{
		// Token: 0x060001DF RID: 479 RVA: 0x00029C54 File Offset: 0x00027E54
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBag()
		{
			Il2CppClassPointerStore<SafeBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.X509", "SafeBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBag>.NativeClassPtr);
			SafeBag.NativeFieldInfoPtr__bagOID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, "_bagOID");
			SafeBag.NativeFieldInfoPtr__asn1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, "_asn1");
			SafeBag.NativeMethodInfoPtr__ctor_Public_Void_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, 100663552);
			SafeBag.NativeMethodInfoPtr_get_BagOID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, 100663553);
			SafeBag.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, 100663554);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00029CE8 File Offset: 0x00027EE8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeBag(string bagOID, ASN1 asn1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeBag>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bagOID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asn1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBag.NativeMethodInfoPtr__ctor_Public_Void_String_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00029D48 File Offset: 0x00027F48
		public unsafe string BagOID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBag.NativeMethodInfoPtr_get_BagOID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00029D80 File Offset: 0x00027F80
		public unsafe ASN1 ASN1
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBag.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002C0D File Offset: 0x00000E0D
		public SafeBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00029DC0 File Offset: 0x00027FC0
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002C16 File Offset: 0x00000E16
		public unsafe string _bagOID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBag.NativeFieldInfoPtr__bagOID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBag.NativeFieldInfoPtr__bagOID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00029DE8 File Offset: 0x00027FE8
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002C35 File Offset: 0x00000E35
		public unsafe ASN1 _asn1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBag.NativeFieldInfoPtr__asn1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBag.NativeFieldInfoPtr__asn1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr__bagOID;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr__asn1;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ASN1_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_get_BagOID_Public_get_String_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0;
	}
}
