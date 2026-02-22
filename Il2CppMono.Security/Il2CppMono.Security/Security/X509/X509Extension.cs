using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000C RID: 12
	public class X509Extension : Object
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00006B54 File Offset: 0x00004D54
		// Note: this type is marked as 'beforefieldinit'.
		static X509Extension()
		{
			Il2CppClassPointerStore<X509Extension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Extension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Extension>.NativeClassPtr);
			X509Extension.NativeFieldInfoPtr_extnOid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnOid");
			X509Extension.NativeFieldInfoPtr_extnCritical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnCritical");
			X509Extension.NativeFieldInfoPtr_extnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnValue");
			X509Extension.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663426);
			X509Extension.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663427);
			X509Extension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663428);
			X509Extension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663429);
			X509Extension.NativeMethodInfoPtr_WriteLine_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663430);
			X509Extension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663431);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006C38 File Offset: 0x00004E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8165, RefRangeEnd = 8166, XrefRangeStart = 8128, XrefRangeEnd = 8165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Extension(ASN1 asn1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Extension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006C84 File Offset: 0x00004E84
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Decode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8166, XrefRangeEnd = 8176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006D18 File Offset: 0x00004F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8176, XrefRangeEnd = 8184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006D60 File Offset: 0x00004F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8218, RefRangeEnd = 8220, XrefRangeStart = 8184, XrefRangeEnd = 8218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteLine(StringBuilder sb, int n, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_WriteLine_Private_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006DC0 File Offset: 0x00004FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8220, XrefRangeEnd = 8228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002672 File Offset: 0x00000872
		public X509Extension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00006E04 File Offset: 0x00005004
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000267B File Offset: 0x0000087B
		public unsafe string extnOid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnOid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnOid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00006E2C File Offset: 0x0000502C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000269A File Offset: 0x0000089A
		public unsafe bool extnCritical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnCritical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnCritical)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00006E54 File Offset: 0x00005054
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000026B5 File Offset: 0x000008B5
		public unsafe ASN1 extnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_extnOid;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_extnCritical;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_extnValue;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
