using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Math;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000030 RID: 48
	public class RSAManaged : RSA
	{
		// Token: 0x0600025C RID: 604 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		// Note: this type is marked as 'beforefieldinit'.
		static RSAManaged()
		{
			Il2CppClassPointerStore<RSAManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "RSAManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr);
			RSAManaged.NativeFieldInfoPtr_isCRTpossible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "isCRTpossible");
			RSAManaged.NativeFieldInfoPtr_keypairGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "keypairGenerated");
			RSAManaged.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "m_disposed");
			RSAManaged.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "d");
			RSAManaged.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "p");
			RSAManaged.NativeFieldInfoPtr_q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "q");
			RSAManaged.NativeFieldInfoPtr_dp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "dp");
			RSAManaged.NativeFieldInfoPtr_dq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "dq");
			RSAManaged.NativeFieldInfoPtr_qInv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "qInv");
			RSAManaged.NativeFieldInfoPtr_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "n");
			RSAManaged.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "e");
			RSAManaged.NativeFieldInfoPtr_KeyGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "KeyGenerated");
			RSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663621);
			RSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663622);
			RSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663623);
			RSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663624);
			RSAManaged.NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663625);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000C668 File Offset: 0x0000A868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 10711, RefRangeEnd = 10712, XrefRangeStart = 10662, XrefRangeEnd = 10711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000C69C File Offset: 0x0000A89C
		public unsafe bool PublicOnly
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 10713, RefRangeEnd = 10715, XrefRangeStart = 10712, XrefRangeEnd = 10713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10715, XrefRangeEnd = 10747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RSAParameters(intPtr);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000C728 File Offset: 0x0000A928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10747, XrefRangeEnd = 10820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ImportParameters(RSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000C77C File Offset: 0x0000A97C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 10826, RefRangeEnd = 10831, XrefRangeStart = 10820, XrefRangeEnd = 10826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPaddedValue(Il2CppMono.Math.BigInteger value, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00003097 File Offset: 0x00001297
		public RSAManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000030A0 File Offset: 0x000012A0
		public unsafe bool isCRTpossible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_isCRTpossible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_isCRTpossible)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000C804 File Offset: 0x0000AA04
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000030BB File Offset: 0x000012BB
		public unsafe bool keypairGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_keypairGenerated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_keypairGenerated)) = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000C82C File Offset: 0x0000AA2C
		// (set) Token: 0x06000268 RID: 616 RVA: 0x000030D6 File Offset: 0x000012D6
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000C854 File Offset: 0x0000AA54
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000030F1 File Offset: 0x000012F1
		public unsafe Il2CppMono.Math.BigInteger d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000C884 File Offset: 0x0000AA84
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00003110 File Offset: 0x00001310
		public unsafe Il2CppMono.Math.BigInteger p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_p);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000312F File Offset: 0x0000132F
		public unsafe Il2CppMono.Math.BigInteger q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000314E File Offset: 0x0000134E
		public unsafe Il2CppMono.Math.BigInteger dp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000C914 File Offset: 0x0000AB14
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000316D File Offset: 0x0000136D
		public unsafe Il2CppMono.Math.BigInteger dq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000C944 File Offset: 0x0000AB44
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0000318C File Offset: 0x0000138C
		public unsafe Il2CppMono.Math.BigInteger qInv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_qInv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_qInv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000C974 File Offset: 0x0000AB74
		// (set) Token: 0x06000276 RID: 630 RVA: 0x000031AB File Offset: 0x000013AB
		public unsafe Il2CppMono.Math.BigInteger n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_n);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_n), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		// (set) Token: 0x06000278 RID: 632 RVA: 0x000031CA File Offset: 0x000013CA
		public unsafe Il2CppMono.Math.BigInteger e
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_e);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		// (set) Token: 0x0600027A RID: 634 RVA: 0x000031E9 File Offset: 0x000013E9
		public unsafe RSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_KeyGenerated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSAManaged.KeyGeneratedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_KeyGenerated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_isCRTpossible;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_keypairGenerated;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_p;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_q;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_dp;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_dq;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_qInv;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_n;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_e;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_KeyGenerated;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0;

		// Token: 0x0200003E RID: 62
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x06000369 RID: 873 RVA: 0x000036F4 File Offset: 0x000018F4
			// Note: this type is marked as 'beforefieldinit'.
			static KeyGeneratedEventHandler()
			{
				Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "KeyGeneratedEventHandler");
				RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663626);
				RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663627);
			}

			// Token: 0x0600036A RID: 874 RVA: 0x0000FD80 File Offset: 0x0000DF80
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyGeneratedEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600036B RID: 875 RVA: 0x0000FDDC File Offset: 0x0000DFDC
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10609, XrefRangeEnd = 10628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Object sender, EventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600036C RID: 876 RVA: 0x00003732 File Offset: 0x00001932
			public KeyGeneratedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600036D RID: 877 RVA: 0x0000373B File Offset: 0x0000193B
			public static implicit operator RSAManaged.KeyGeneratedEventHandler(Action<Object, EventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<RSAManaged.KeyGeneratedEventHandler>(A_0);
			}

			// Token: 0x0600036E RID: 878 RVA: 0x00003743 File Offset: 0x00001943
			public static RSAManaged.KeyGeneratedEventHandler operator +(RSAManaged.KeyGeneratedEventHandler A_0, RSAManaged.KeyGeneratedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RSAManaged.KeyGeneratedEventHandler>();
			}

			// Token: 0x0600036F RID: 879 RVA: 0x00003751 File Offset: 0x00001951
			public static RSAManaged.KeyGeneratedEventHandler operator -(RSAManaged.KeyGeneratedEventHandler A_0, RSAManaged.KeyGeneratedEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RSAManaged.KeyGeneratedEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x04000388 RID: 904
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000389 RID: 905
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;
		}
	}
}
