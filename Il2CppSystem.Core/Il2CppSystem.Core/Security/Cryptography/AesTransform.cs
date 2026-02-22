using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000005 RID: 5
	public class AesTransform : SymmetricTransform
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003C24 File Offset: 0x00001E24
		// Note: this type is marked as 'beforefieldinit'.
		static AesTransform()
		{
			Il2CppClassPointerStore<AesTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Security.Cryptography", "AesTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AesTransform>.NativeClassPtr);
			AesTransform.NativeFieldInfoPtr_expandedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "expandedKey");
			AesTransform.NativeFieldInfoPtr_Nk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Nk");
			AesTransform.NativeFieldInfoPtr_Nr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Nr");
			AesTransform.NativeFieldInfoPtr_Rcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Rcon");
			AesTransform.NativeFieldInfoPtr_SBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "SBox");
			AesTransform.NativeFieldInfoPtr_iSBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iSBox");
			AesTransform.NativeFieldInfoPtr_T0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T0");
			AesTransform.NativeFieldInfoPtr_T1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T1");
			AesTransform.NativeFieldInfoPtr_T2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T2");
			AesTransform.NativeFieldInfoPtr_T3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T3");
			AesTransform.NativeFieldInfoPtr_iT0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT0");
			AesTransform.NativeFieldInfoPtr_iT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT1");
			AesTransform.NativeFieldInfoPtr_iT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT2");
			AesTransform.NativeFieldInfoPtr_iT3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT3");
			AesTransform.NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663336);
			AesTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663337);
			AesTransform.NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663338);
			AesTransform.NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663339);
			AesTransform.NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663340);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003DD0 File Offset: 0x00001FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57838, RefRangeEnd = 57840, XrefRangeStart = 57821, XrefRangeEnd = 57838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AesTransform(Aes algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AesTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(algo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003E50 File Offset: 0x00002050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57840, XrefRangeEnd = 57841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ECB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AesTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003EB0 File Offset: 0x000020B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57845, RefRangeEnd = 57847, XrefRangeStart = 57841, XrefRangeEnd = 57845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint SubByte(uint a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003EFC File Offset: 0x000020FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57847, XrefRangeEnd = 57876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encrypt128(Il2CppStructArray<byte> indata, Il2CppStructArray<byte> outdata, Il2CppStructArray<uint> ekey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indata);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outdata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ekey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003F64 File Offset: 0x00002164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57905, RefRangeEnd = 57906, XrefRangeStart = 57876, XrefRangeEnd = 57905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decrypt128(Il2CppStructArray<byte> indata, Il2CppStructArray<byte> outdata, Il2CppStructArray<uint> ekey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indata);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outdata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ekey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020C3 File Offset: 0x000002C3
		public AesTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003FCC File Offset: 0x000021CC
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000020CC File Offset: 0x000002CC
		public unsafe Il2CppStructArray<uint> expandedKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_expandedKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_expandedKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00003FFC File Offset: 0x000021FC
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000020EB File Offset: 0x000002EB
		public unsafe int Nk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nk)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00004024 File Offset: 0x00002224
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002106 File Offset: 0x00000306
		public unsafe int Nr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nr)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000404C File Offset: 0x0000224C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002121 File Offset: 0x00000321
		public unsafe static Il2CppStructArray<uint> Rcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_Rcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_Rcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00004074 File Offset: 0x00002274
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002133 File Offset: 0x00000333
		public unsafe static Il2CppStructArray<byte> SBox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_SBox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_SBox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000409C File Offset: 0x0000229C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002145 File Offset: 0x00000345
		public unsafe static Il2CppStructArray<byte> iSBox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iSBox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iSBox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000040C4 File Offset: 0x000022C4
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002157 File Offset: 0x00000357
		public unsafe static Il2CppStructArray<uint> T0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000040EC File Offset: 0x000022EC
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002169 File Offset: 0x00000369
		public unsafe static Il2CppStructArray<uint> T1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00004114 File Offset: 0x00002314
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000217B File Offset: 0x0000037B
		public unsafe static Il2CppStructArray<uint> T2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000413C File Offset: 0x0000233C
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000218D File Offset: 0x0000038D
		public unsafe static Il2CppStructArray<uint> T3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00004164 File Offset: 0x00002364
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000219F File Offset: 0x0000039F
		public unsafe static Il2CppStructArray<uint> iT0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000418C File Offset: 0x0000238C
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000021B1 File Offset: 0x000003B1
		public unsafe static Il2CppStructArray<uint> iT1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000041B4 File Offset: 0x000023B4
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000021C3 File Offset: 0x000003C3
		public unsafe static Il2CppStructArray<uint> iT2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000041DC File Offset: 0x000023DC
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000021D5 File Offset: 0x000003D5
		public unsafe static Il2CppStructArray<uint> iT3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_expandedKey;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_Nk;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_Nr;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_Rcon;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_SBox;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_iSBox;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_T0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_T1;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_T2;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_T3;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_iT0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_iT1;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_iT2;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_iT3;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0;
	}
}
