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
	// Token: 0x02000035 RID: 53
	public class DSAManaged : DSA
	{
		// Token: 0x06000394 RID: 916 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
		// Note: this type is marked as 'beforefieldinit'.
		static DSAManaged()
		{
			Il2CppClassPointerStore<DSAManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "DSAManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr);
			DSAManaged.NativeFieldInfoPtr_keypairGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "keypairGenerated");
			DSAManaged.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "m_disposed");
			DSAManaged.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "p");
			DSAManaged.NativeFieldInfoPtr_q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "q");
			DSAManaged.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "g");
			DSAManaged.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "x");
			DSAManaged.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "y");
			DSAManaged.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "j");
			DSAManaged.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "seed");
			DSAManaged.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "counter");
			DSAManaged.NativeFieldInfoPtr_j_missing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "j_missing");
			DSAManaged.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "rng");
			DSAManaged.NativeFieldInfoPtr_KeyGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "KeyGenerated");
			DSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663770);
			DSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663771);
			DSAManaged.NativeMethodInfoPtr_Generate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663772);
			DSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663773);
			DSAManaged.NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663774);
			DSAManaged.NativeMethodInfoPtr_GenerateParams_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663775);
			DSAManaged.NativeMethodInfoPtr_get_Random_Private_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663776);
			DSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663777);
			DSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663778);
			DSAManaged.NativeMethodInfoPtr_NormalizeArray_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663779);
			DSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663780);
			DSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663781);
			DSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663782);
			DSAManaged.NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663783);
			DSAManaged.NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663784);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00030150 File Offset: 0x0002E350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263586, XrefRangeEnd = 263595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSAManaged(int dwKeySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00030198 File Offset: 0x0002E398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000301D4 File Offset: 0x0002E3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263595, XrefRangeEnd = 263610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_Generate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00030208 File Offset: 0x0002E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263610, XrefRangeEnd = 263623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0003023C File Offset: 0x0002E43C
		[CallerCount(0)]
		public unsafe void add(Il2CppStructArray<byte> a, Il2CppStructArray<byte> b, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000302A0 File Offset: 0x0002E4A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263690, RefRangeEnd = 263692, XrefRangeStart = 263623, XrefRangeEnd = 263690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateParams(int keyLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_GenerateParams_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600039B RID: 923 RVA: 0x000302E0 File Offset: 0x0002E4E0
		public unsafe RandomNumberGenerator Random
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263692, XrefRangeEnd = 263693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_get_Random_Private_get_RandomNumberGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00030320 File Offset: 0x0002E520
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00030368 File Offset: 0x0002E568
		public unsafe bool PublicOnly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263694, RefRangeEnd = 263695, XrefRangeStart = 263693, XrefRangeEnd = 263694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000303A4 File Offset: 0x0002E5A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 263696, RefRangeEnd = 263703, XrefRangeStart = 263695, XrefRangeEnd = 263696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> NormalizeArray(Il2CppStructArray<byte> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_NormalizeArray_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000303F4 File Offset: 0x0002E5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263703, XrefRangeEnd = 263739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00030444 File Offset: 0x0002E644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263739, XrefRangeEnd = 263772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ImportParameters(DSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00030498 File Offset: 0x0002E698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263772, XrefRangeEnd = 263801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000304E4 File Offset: 0x0002E6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263801, XrefRangeEnd = 263805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00030528 File Offset: 0x0002E728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263805, XrefRangeEnd = 263809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00003860 File Offset: 0x00001A60
		public DSAManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0003056C File Offset: 0x0002E76C
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00003869 File Offset: 0x00001A69
		public unsafe bool keypairGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_keypairGenerated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_keypairGenerated)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00030594 File Offset: 0x0002E794
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003884 File Offset: 0x00001A84
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x000305BC File Offset: 0x0002E7BC
		// (set) Token: 0x060003AA RID: 938 RVA: 0x0000389F File Offset: 0x00001A9F
		public unsafe BigInteger p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_p);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003AB RID: 939 RVA: 0x000305EC File Offset: 0x0002E7EC
		// (set) Token: 0x060003AC RID: 940 RVA: 0x000038BE File Offset: 0x00001ABE
		public unsafe BigInteger q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0003061C File Offset: 0x0002E81C
		// (set) Token: 0x060003AE RID: 942 RVA: 0x000038DD File Offset: 0x00001ADD
		public unsafe BigInteger g
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_g);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_g), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0003064C File Offset: 0x0002E84C
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x000038FC File Offset: 0x00001AFC
		public unsafe BigInteger x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_x);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0003067C File Offset: 0x0002E87C
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x0000391B File Offset: 0x00001B1B
		public unsafe BigInteger y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_y);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_y), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x000306AC File Offset: 0x0002E8AC
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0000393A File Offset: 0x00001B3A
		public unsafe BigInteger j
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_j);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_j), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000306DC File Offset: 0x0002E8DC
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00003959 File Offset: 0x00001B59
		public unsafe BigInteger seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0003070C File Offset: 0x0002E90C
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00003978 File Offset: 0x00001B78
		public unsafe int counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_counter)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00030734 File Offset: 0x0002E934
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00003993 File Offset: 0x00001B93
		public unsafe bool j_missing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_j_missing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_j_missing)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0003075C File Offset: 0x0002E95C
		// (set) Token: 0x060003BC RID: 956 RVA: 0x000039AE File Offset: 0x00001BAE
		public unsafe RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_rng);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_rng), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0003078C File Offset: 0x0002E98C
		// (set) Token: 0x060003BE RID: 958 RVA: 0x000039CD File Offset: 0x00001BCD
		public unsafe DSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_KeyGenerated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DSAManaged.KeyGeneratedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_KeyGenerated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_keypairGenerated;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_p;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr_q;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_g;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_j;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_seed;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_counter;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_j_missing;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_KeyGenerated;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Private_Void_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_GenerateParams_Private_Void_Int32_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_get_Random_Private_get_RandomNumberGenerator_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeArray_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0;

		// Token: 0x02000546 RID: 1350
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x06004E12 RID: 19986 RVA: 0x0001D975 File Offset: 0x0001BB75
			// Note: this type is marked as 'beforefieldinit'.
			static KeyGeneratedEventHandler()
			{
				Il2CppClassPointerStore<DSAManaged.KeyGeneratedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "KeyGeneratedEventHandler");
				DSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663785);
				DSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663786);
			}

			// Token: 0x06004E13 RID: 19987 RVA: 0x0015FCC4 File Offset: 0x0015DEC4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyGeneratedEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSAManaged.KeyGeneratedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E14 RID: 19988 RVA: 0x0015FD20 File Offset: 0x0015DF20
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E15 RID: 19989 RVA: 0x0001D9B3 File Offset: 0x0001BBB3
			public KeyGeneratedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004E16 RID: 19990 RVA: 0x0001D9BC File Offset: 0x0001BBBC
			public static implicit operator DSAManaged.KeyGeneratedEventHandler(Action<Object, EventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<DSAManaged.KeyGeneratedEventHandler>(A_0);
			}

			// Token: 0x06004E17 RID: 19991 RVA: 0x0001D9C4 File Offset: 0x0001BBC4
			public static DSAManaged.KeyGeneratedEventHandler operator +(DSAManaged.KeyGeneratedEventHandler A_0, DSAManaged.KeyGeneratedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DSAManaged.KeyGeneratedEventHandler>();
			}

			// Token: 0x06004E18 RID: 19992 RVA: 0x0001D9D2 File Offset: 0x0001BBD2
			public static DSAManaged.KeyGeneratedEventHandler operator -(DSAManaged.KeyGeneratedEventHandler A_0, DSAManaged.KeyGeneratedEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DSAManaged.KeyGeneratedEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003F05 RID: 16133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003F06 RID: 16134
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;
		}
	}
}
