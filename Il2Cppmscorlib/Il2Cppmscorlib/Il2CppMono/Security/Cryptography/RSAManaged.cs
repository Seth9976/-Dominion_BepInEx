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
	// Token: 0x02000033 RID: 51
	public class RSAManaged : RSA
	{
		// Token: 0x0600033C RID: 828 RVA: 0x0002EA0C File Offset: 0x0002CC0C
		// Note: this type is marked as 'beforefieldinit'.
		static RSAManaged()
		{
			Il2CppClassPointerStore<RSAManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "RSAManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr);
			RSAManaged.NativeFieldInfoPtr_isCRTpossible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "isCRTpossible");
			RSAManaged.NativeFieldInfoPtr_keyBlinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "keyBlinding");
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
			RSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663734);
			RSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663735);
			RSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663736);
			RSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663737);
			RSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663738);
			RSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663739);
			RSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663740);
			RSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663741);
			RSAManaged.NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663742);
			RSAManaged.NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663743);
			RSAManaged.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663744);
			RSAManaged.NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663745);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0002EC30 File Offset: 0x0002CE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263109, XrefRangeEnd = 263124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAManaged(int keySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0002EC78 File Offset: 0x0002CE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0002ECB4 File Offset: 0x0002CEB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263158, RefRangeEnd = 263159, XrefRangeStart = 263124, XrefRangeEnd = 263158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0002ECE8 File Offset: 0x0002CEE8
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0002ED30 File Offset: 0x0002CF30
		public unsafe bool PublicOnly
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 263160, RefRangeEnd = 263162, XrefRangeStart = 263159, XrefRangeEnd = 263160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000342 RID: 834 RVA: 0x0002ED6C File Offset: 0x0002CF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263162, XrefRangeEnd = 263194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000343 RID: 835 RVA: 0x0002EDBC File Offset: 0x0002CFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263194, XrefRangeEnd = 263260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000344 RID: 836 RVA: 0x0002EE10 File Offset: 0x0002D010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263260, XrefRangeEnd = 263293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0002EE5C File Offset: 0x0002D05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263293, XrefRangeEnd = 263297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0002EEA0 File Offset: 0x0002D0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263297, XrefRangeEnd = 263301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263301, XrefRangeEnd = 263424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToXmlString(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0002EF34 File Offset: 0x0002D134
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 263430, RefRangeEnd = 263435, XrefRangeStart = 263424, XrefRangeEnd = 263430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPaddedValue(BigInteger value, int length)
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

		// Token: 0x06000349 RID: 841 RVA: 0x0000356F File Offset: 0x0000176F
		public RSAManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0002EF94 File Offset: 0x0002D194
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003578 File Offset: 0x00001778
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0002EFBC File Offset: 0x0002D1BC
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00003593 File Offset: 0x00001793
		public unsafe bool keyBlinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_keyBlinding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_keyBlinding)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0002EFE4 File Offset: 0x0002D1E4
		// (set) Token: 0x0600034F RID: 847 RVA: 0x000035AE File Offset: 0x000017AE
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0002F00C File Offset: 0x0002D20C
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000035C9 File Offset: 0x000017C9
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0002F034 File Offset: 0x0002D234
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000035E4 File Offset: 0x000017E4
		public unsafe BigInteger d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0002F064 File Offset: 0x0002D264
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00003603 File Offset: 0x00001803
		public unsafe BigInteger p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_p);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0002F094 File Offset: 0x0002D294
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00003622 File Offset: 0x00001822
		public unsafe BigInteger q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0002F0C4 File Offset: 0x0002D2C4
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00003641 File Offset: 0x00001841
		public unsafe BigInteger dp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0002F0F4 File Offset: 0x0002D2F4
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00003660 File Offset: 0x00001860
		public unsafe BigInteger dq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0002F124 File Offset: 0x0002D324
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0000367F File Offset: 0x0000187F
		public unsafe BigInteger qInv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_qInv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_qInv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0002F154 File Offset: 0x0002D354
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0000369E File Offset: 0x0000189E
		public unsafe BigInteger n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_n);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_n), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0002F184 File Offset: 0x0002D384
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000036BD File Offset: 0x000018BD
		public unsafe BigInteger e
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_e);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0002F1B4 File Offset: 0x0002D3B4
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000036DC File Offset: 0x000018DC
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

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_isCRTpossible;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_keyBlinding;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_keypairGenerated;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_p;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_q;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_dp;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_dq;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_qInv;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_n;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_e;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_KeyGenerated;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0;

		// Token: 0x02000545 RID: 1349
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x06004E0B RID: 19979 RVA: 0x0001D907 File Offset: 0x0001BB07
			// Note: this type is marked as 'beforefieldinit'.
			static KeyGeneratedEventHandler()
			{
				Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "KeyGeneratedEventHandler");
				RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663746);
				RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663747);
			}

			// Token: 0x06004E0C RID: 19980 RVA: 0x0015FC14 File Offset: 0x0015DE14
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

			// Token: 0x06004E0D RID: 19981 RVA: 0x0015FC70 File Offset: 0x0015DE70
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 226438, RefRangeEnd = 226449, XrefRangeStart = 226438, XrefRangeEnd = 226449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E0E RID: 19982 RVA: 0x0001D945 File Offset: 0x0001BB45
			public KeyGeneratedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004E0F RID: 19983 RVA: 0x0001D94E File Offset: 0x0001BB4E
			public static implicit operator RSAManaged.KeyGeneratedEventHandler(Action<Object, EventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<RSAManaged.KeyGeneratedEventHandler>(A_0);
			}

			// Token: 0x06004E10 RID: 19984 RVA: 0x0001D956 File Offset: 0x0001BB56
			public static RSAManaged.KeyGeneratedEventHandler operator +(RSAManaged.KeyGeneratedEventHandler A_0, RSAManaged.KeyGeneratedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RSAManaged.KeyGeneratedEventHandler>();
			}

			// Token: 0x06004E11 RID: 19985 RVA: 0x0001D964 File Offset: 0x0001BB64
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

			// Token: 0x04003F03 RID: 16131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003F04 RID: 16132
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;
		}
	}
}
