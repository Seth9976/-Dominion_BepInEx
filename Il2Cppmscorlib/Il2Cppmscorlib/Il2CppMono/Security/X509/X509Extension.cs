using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000027 RID: 39
	public class X509Extension : Object
	{
		// Token: 0x06000286 RID: 646 RVA: 0x0002BF28 File Offset: 0x0002A128
		// Note: this type is marked as 'beforefieldinit'.
		static X509Extension()
		{
			Il2CppClassPointerStore<X509Extension>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.X509", "X509Extension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Extension>.NativeClassPtr);
			X509Extension.NativeFieldInfoPtr_extnOid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnOid");
			X509Extension.NativeFieldInfoPtr_extnCritical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnCritical");
			X509Extension.NativeFieldInfoPtr_extnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnValue");
			X509Extension.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663629);
			X509Extension.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663630);
			X509Extension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663631);
			X509Extension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663632);
			X509Extension.NativeMethodInfoPtr_WriteLine_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663633);
			X509Extension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663634);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0002C00C File Offset: 0x0002A20C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262353, RefRangeEnd = 262354, XrefRangeStart = 262312, XrefRangeEnd = 262353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000288 RID: 648 RVA: 0x0002C058 File Offset: 0x0002A258
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

		// Token: 0x06000289 RID: 649 RVA: 0x0002C094 File Offset: 0x0002A294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262354, XrefRangeEnd = 262364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600028A RID: 650 RVA: 0x0002C0EC File Offset: 0x0002A2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0002C134 File Offset: 0x0002A334
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262398, RefRangeEnd = 262400, XrefRangeStart = 262364, XrefRangeEnd = 262398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600028C RID: 652 RVA: 0x0002C194 File Offset: 0x0002A394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262400, XrefRangeEnd = 262409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000314B File Offset: 0x0000134B
		public X509Extension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00003154 File Offset: 0x00001354
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0002C200 File Offset: 0x0002A400
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003173 File Offset: 0x00001373
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0002C228 File Offset: 0x0002A428
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000318E File Offset: 0x0000138E
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

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_extnOid;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_extnCritical;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_extnValue;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
