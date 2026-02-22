using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200008A RID: 138
	public sealed class X509BasicConstraintsExtension : X509Extension
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x0002E664 File Offset: 0x0002C864
		// Note: this type is marked as 'beforefieldinit'.
		static X509BasicConstraintsExtension()
		{
			Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509BasicConstraintsExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr);
			X509BasicConstraintsExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "oid");
			X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "friendlyName");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_certificateAuthority");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_hasPathLengthConstraint");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_pathLengthConstraint");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_status");
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664353);
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664354);
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664355);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664356);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664357);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664358);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664359);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664360);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664361);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664362);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0002E7D4 File Offset: 0x0002C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41916, XrefRangeEnd = 41925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0002E810 File Offset: 0x0002CA10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41935, RefRangeEnd = 41936, XrefRangeStart = 41925, XrefRangeEnd = 41935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedBasicConstraints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0002E86C File Offset: 0x0002CA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41936, XrefRangeEnd = 41976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref certificateAuthority;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasPathLengthConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathLengthConstraint;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		public unsafe bool CertificateAuthority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x0002E91C File Offset: 0x0002CB1C
		public unsafe bool HasPathLengthConstraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0002E958 File Offset: 0x0002CB58
		public unsafe int PathLengthConstraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0002E994 File Offset: 0x0002CB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41976, XrefRangeEnd = 41990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0002E9D8 File Offset: 0x0002CBD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41991, RefRangeEnd = 41993, XrefRangeStart = 41990, XrefRangeEnd = 41991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0002EA28 File Offset: 0x0002CC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41993, XrefRangeEnd = 42017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0002EA68 File Offset: 0x0002CC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42017, XrefRangeEnd = 42053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00005535 File Offset: 0x00003735
		public X509BasicConstraintsExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0002EAAC File Offset: 0x0002CCAC
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x0000553E File Offset: 0x0000373E
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0002EACC File Offset: 0x0002CCCC
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00005550 File Offset: 0x00003750
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0002EAEC File Offset: 0x0002CCEC
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00005562 File Offset: 0x00003762
		public unsafe bool _certificateAuthority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority)) = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0002EB14 File Offset: 0x0002CD14
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0000557D File Offset: 0x0000377D
		public unsafe bool _hasPathLengthConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint)) = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0002EB3C File Offset: 0x0002CD3C
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00005598 File Offset: 0x00003798
		public unsafe int _pathLengthConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint)) = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0002EB64 File Offset: 0x0002CD64
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x000055B3 File Offset: 0x000037B3
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr__certificateAuthority;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr__hasPathLengthConstraint;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeFieldInfoPtr__pathLengthConstraint;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
