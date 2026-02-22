using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000009 RID: 9
	public sealed class X501 : Object
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000565C File Offset: 0x0000385C
		// Note: this type is marked as 'beforefieldinit'.
		static X501()
		{
			Il2CppClassPointerStore<X501>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X501");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X501>.NativeClassPtr);
			X501.NativeFieldInfoPtr_countryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "countryName");
			X501.NativeFieldInfoPtr_organizationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "organizationName");
			X501.NativeFieldInfoPtr_organizationalUnitName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "organizationalUnitName");
			X501.NativeFieldInfoPtr_commonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "commonName");
			X501.NativeFieldInfoPtr_localityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "localityName");
			X501.NativeFieldInfoPtr_stateOrProvinceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "stateOrProvinceName");
			X501.NativeFieldInfoPtr_streetAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "streetAddress");
			X501.NativeFieldInfoPtr_domainComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "domainComponent");
			X501.NativeFieldInfoPtr_userid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "userid");
			X501.NativeFieldInfoPtr_email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "email");
			X501.NativeFieldInfoPtr_dnQualifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "dnQualifier");
			X501.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "title");
			X501.NativeFieldInfoPtr_surname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "surname");
			X501.NativeFieldInfoPtr_givenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "givenName");
			X501.NativeFieldInfoPtr_initial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "initial");
			X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663387);
			X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663388);
			X501.NativeMethodInfoPtr_AppendEntry_Private_Static_Void_StringBuilder_ASN1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663389);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000057F4 File Offset: 0x000039F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 7589, RefRangeEnd = 7591, XrefRangeStart = 7573, XrefRangeEnd = 7589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ASN1 seq)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005830 File Offset: 0x00003A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 7702, RefRangeEnd = 7704, XrefRangeStart = 7591, XrefRangeEnd = 7702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ASN1 seq, bool reversed, string separator, bool quotes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seq);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reversed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(separator);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quotes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000589C File Offset: 0x00003A9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 7856, RefRangeEnd = 7859, XrefRangeStart = 7704, XrefRangeEnd = 7856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quotes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_AppendEntry_Private_Static_Void_StringBuilder_ASN1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000022B8 File Offset: 0x000004B8
		public X501(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000058F4 File Offset: 0x00003AF4
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000022C1 File Offset: 0x000004C1
		public unsafe static Il2CppStructArray<byte> countryName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_countryName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_countryName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000591C File Offset: 0x00003B1C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000022D3 File Offset: 0x000004D3
		public unsafe static Il2CppStructArray<byte> organizationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_organizationName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_organizationName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00005944 File Offset: 0x00003B44
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000022E5 File Offset: 0x000004E5
		public unsafe static Il2CppStructArray<byte> organizationalUnitName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_organizationalUnitName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_organizationalUnitName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000596C File Offset: 0x00003B6C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000022F7 File Offset: 0x000004F7
		public unsafe static Il2CppStructArray<byte> commonName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_commonName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_commonName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005994 File Offset: 0x00003B94
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002309 File Offset: 0x00000509
		public unsafe static Il2CppStructArray<byte> localityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_localityName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_localityName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000059BC File Offset: 0x00003BBC
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000231B File Offset: 0x0000051B
		public unsafe static Il2CppStructArray<byte> stateOrProvinceName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_stateOrProvinceName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_stateOrProvinceName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000059E4 File Offset: 0x00003BE4
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000232D File Offset: 0x0000052D
		public unsafe static Il2CppStructArray<byte> streetAddress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_streetAddress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_streetAddress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00005A0C File Offset: 0x00003C0C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000233F File Offset: 0x0000053F
		public unsafe static Il2CppStructArray<byte> domainComponent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_domainComponent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_domainComponent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00005A34 File Offset: 0x00003C34
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002351 File Offset: 0x00000551
		public unsafe static Il2CppStructArray<byte> userid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_userid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_userid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00005A5C File Offset: 0x00003C5C
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002363 File Offset: 0x00000563
		public unsafe static Il2CppStructArray<byte> email
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_email, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_email, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00005A84 File Offset: 0x00003C84
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002375 File Offset: 0x00000575
		public unsafe static Il2CppStructArray<byte> dnQualifier
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_dnQualifier, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_dnQualifier, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00005AAC File Offset: 0x00003CAC
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002387 File Offset: 0x00000587
		public unsafe static Il2CppStructArray<byte> title
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_title, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_title, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00005AD4 File Offset: 0x00003CD4
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002399 File Offset: 0x00000599
		public unsafe static Il2CppStructArray<byte> surname
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_surname, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_surname, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00005AFC File Offset: 0x00003CFC
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000023AB File Offset: 0x000005AB
		public unsafe static Il2CppStructArray<byte> givenName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_givenName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_givenName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00005B24 File Offset: 0x00003D24
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000023BD File Offset: 0x000005BD
		public unsafe static Il2CppStructArray<byte> initial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_initial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_initial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_countryName;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_organizationName;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_organizationalUnitName;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_commonName;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_localityName;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_stateOrProvinceName;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_streetAddress;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_domainComponent;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_userid;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_email;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_dnQualifier;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_surname;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_givenName;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_initial;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_Boolean_String_Boolean_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_AppendEntry_Private_Static_Void_StringBuilder_ASN1_Boolean_0;
	}
}
