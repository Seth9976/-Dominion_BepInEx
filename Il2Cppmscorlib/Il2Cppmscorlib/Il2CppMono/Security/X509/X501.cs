using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000024 RID: 36
	public sealed class X501 : Object
	{
		// Token: 0x0600021D RID: 541 RVA: 0x0002AC4C File Offset: 0x00028E4C
		// Note: this type is marked as 'beforefieldinit'.
		static X501()
		{
			Il2CppClassPointerStore<X501>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.X509", "X501");
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
			X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663596);
			X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663597);
			X501.NativeMethodInfoPtr_AppendEntry_Private_Static_Void_StringBuilder_ASN1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663598);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0002ADE4 File Offset: 0x00028FE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261803, RefRangeEnd = 261805, XrefRangeStart = 261787, XrefRangeEnd = 261803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600021F RID: 543 RVA: 0x0002AE20 File Offset: 0x00029020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261917, RefRangeEnd = 261919, XrefRangeStart = 261805, XrefRangeEnd = 261917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000220 RID: 544 RVA: 0x0002AE8C File Offset: 0x0002908C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262071, RefRangeEnd = 262074, XrefRangeStart = 261919, XrefRangeEnd = 262071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000221 RID: 545 RVA: 0x00002D91 File Offset: 0x00000F91
		public X501(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0002AEE4 File Offset: 0x000290E4
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002D9A File Offset: 0x00000F9A
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0002AF0C File Offset: 0x0002910C
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002DAC File Offset: 0x00000FAC
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0002AF34 File Offset: 0x00029134
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002DBE File Offset: 0x00000FBE
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0002AF5C File Offset: 0x0002915C
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002DD0 File Offset: 0x00000FD0
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0002AF84 File Offset: 0x00029184
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002DE2 File Offset: 0x00000FE2
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0002AFAC File Offset: 0x000291AC
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00002DF4 File Offset: 0x00000FF4
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0002AFD4 File Offset: 0x000291D4
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002E06 File Offset: 0x00001006
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0002AFFC File Offset: 0x000291FC
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002E18 File Offset: 0x00001018
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0002B024 File Offset: 0x00029224
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002E2A File Offset: 0x0000102A
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0002B04C File Offset: 0x0002924C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002E3C File Offset: 0x0000103C
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0002B074 File Offset: 0x00029274
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00002E4E File Offset: 0x0000104E
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0002B09C File Offset: 0x0002929C
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002E60 File Offset: 0x00001060
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0002B0C4 File Offset: 0x000292C4
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002E72 File Offset: 0x00001072
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0002B0EC File Offset: 0x000292EC
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002E84 File Offset: 0x00001084
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0002B114 File Offset: 0x00029314
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002E96 File Offset: 0x00001096
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

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_countryName;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_organizationName;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_organizationalUnitName;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_commonName;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_localityName;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_stateOrProvinceName;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_streetAddress;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_domainComponent;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_userid;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_email;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_dnQualifier;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_surname;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_givenName;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_initial;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_Boolean_String_Boolean_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_AppendEntry_Private_Static_Void_StringBuilder_ASN1_Boolean_0;
	}
}
