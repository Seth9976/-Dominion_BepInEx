using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000007 RID: 7
	public class SafeBag : Object
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00004664 File Offset: 0x00002864
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBag()
		{
			Il2CppClassPointerStore<SafeBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "SafeBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBag>.NativeClassPtr);
			SafeBag.NativeFieldInfoPtr__bagOID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, "_bagOID");
			SafeBag.NativeFieldInfoPtr__asn1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, "_asn1");
			SafeBag.NativeMethodInfoPtr__ctor_Public_Void_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, 100663343);
			SafeBag.NativeMethodInfoPtr_get_BagOID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, 100663344);
			SafeBag.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBag>.NativeClassPtr, 100663345);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000046F8 File Offset: 0x000028F8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5355, XrefRangeEnd = 5356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004758 File Offset: 0x00002958
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004790 File Offset: 0x00002990
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

		// Token: 0x06000035 RID: 53 RVA: 0x00002134 File Offset: 0x00000334
		public SafeBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000047D0 File Offset: 0x000029D0
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000213D File Offset: 0x0000033D
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

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000047F8 File Offset: 0x000029F8
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000215C File Offset: 0x0000035C
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

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr__bagOID;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr__asn1;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ASN1_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_BagOID_Public_get_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0;
	}
}
