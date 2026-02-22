using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000314 RID: 788
	public class DESTransform : SymmetricTransform
	{
		// Token: 0x0600332D RID: 13101 RVA: 0x000FC17C File Offset: 0x000FA37C
		// Note: this type is marked as 'beforefieldinit'.
		static DESTransform()
		{
			Il2CppClassPointerStore<DESTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DESTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DESTransform>.NativeClassPtr);
			DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "KEY_BIT_SIZE");
			DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "KEY_BYTE_SIZE");
			DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "BLOCK_BIT_SIZE");
			DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "BLOCK_BYTE_SIZE");
			DESTransform.NativeFieldInfoPtr_keySchedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "keySchedule");
			DESTransform.NativeFieldInfoPtr_byteBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "byteBuff");
			DESTransform.NativeFieldInfoPtr_dwordBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "dwordBuff");
			DESTransform.NativeFieldInfoPtr_spBoxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "spBoxes");
			DESTransform.NativeFieldInfoPtr_PC1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "PC1");
			DESTransform.NativeFieldInfoPtr_leftRotTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "leftRotTotal");
			DESTransform.NativeFieldInfoPtr_PC2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "PC2");
			DESTransform.NativeFieldInfoPtr_ipTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "ipTab");
			DESTransform.NativeFieldInfoPtr_fpTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "fpTab");
			DESTransform.NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671269);
			DESTransform.NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671270);
			DESTransform.NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671271);
			DESTransform.NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671272);
			DESTransform.NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671273);
			DESTransform.NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671274);
			DESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671275);
			DESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671276);
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x000FC350 File Offset: 0x000FA550
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 341648, RefRangeEnd = 341653, XrefRangeStart = 341597, XrefRangeEnd = 341648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DESTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symmAlgo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x000FC3D0 File Offset: 0x000FA5D0
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 341657, RefRangeEnd = 341689, XrefRangeStart = 341653, XrefRangeEnd = 341657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint CipherFunct(uint r, int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x000FC428 File Offset: 0x000FA628
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 341705, RefRangeEnd = 341709, XrefRangeStart = 341689, XrefRangeEnd = 341705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Permutation(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, Il2CppStructArray<uint> permTab, bool preSwap)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(permTab);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preSwap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x000FC490 File Offset: 0x000FA690
		[CallerCount(0)]
		public unsafe static void BSwap(Il2CppStructArray<byte> byteBuff)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteBuff);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x000FC4C8 File Offset: 0x000FA6C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341734, RefRangeEnd = 341735, XrefRangeStart = 341709, XrefRangeEnd = 341734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKey(Il2CppStructArray<byte> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x000FC50C File Offset: 0x000FA70C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 341777, RefRangeEnd = 341783, XrefRangeStart = 341735, XrefRangeEnd = 341777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBlock(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x000FC560 File Offset: 0x000FA760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341783, XrefRangeEnd = 341791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x000FC5C0 File Offset: 0x000FA7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341791, XrefRangeEnd = 341803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetStrongKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00012368 File Offset: 0x00010568
		public DESTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x000FC5F4 File Offset: 0x000FA7F4
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x00012371 File Offset: 0x00010571
		public unsafe static int KEY_BIT_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x000FC610 File Offset: 0x000FA810
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x0001237F File Offset: 0x0001057F
		public unsafe static int KEY_BYTE_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x000FC62C File Offset: 0x000FA82C
		// (set) Token: 0x0600333C RID: 13116 RVA: 0x0001238D File Offset: 0x0001058D
		public unsafe static int BLOCK_BIT_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x000FC648 File Offset: 0x000FA848
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x0001239B File Offset: 0x0001059B
		public unsafe static int BLOCK_BYTE_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x000FC664 File Offset: 0x000FA864
		// (set) Token: 0x06003340 RID: 13120 RVA: 0x000123A9 File Offset: 0x000105A9
		public unsafe Il2CppStructArray<byte> keySchedule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_keySchedule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_keySchedule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x000FC694 File Offset: 0x000FA894
		// (set) Token: 0x06003342 RID: 13122 RVA: 0x000123C8 File Offset: 0x000105C8
		public unsafe Il2CppStructArray<byte> byteBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_byteBuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_byteBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x000FC6C4 File Offset: 0x000FA8C4
		// (set) Token: 0x06003344 RID: 13124 RVA: 0x000123E7 File Offset: 0x000105E7
		public unsafe Il2CppStructArray<uint> dwordBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_dwordBuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_dwordBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x000FC6F4 File Offset: 0x000FA8F4
		// (set) Token: 0x06003346 RID: 13126 RVA: 0x00012406 File Offset: 0x00010606
		public unsafe static Il2CppStructArray<uint> spBoxes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_spBoxes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_spBoxes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06003347 RID: 13127 RVA: 0x000FC71C File Offset: 0x000FA91C
		// (set) Token: 0x06003348 RID: 13128 RVA: 0x00012418 File Offset: 0x00010618
		public unsafe static Il2CppStructArray<byte> PC1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_PC1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_PC1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x000FC744 File Offset: 0x000FA944
		// (set) Token: 0x0600334A RID: 13130 RVA: 0x0001242A File Offset: 0x0001062A
		public unsafe static Il2CppStructArray<byte> leftRotTotal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_leftRotTotal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_leftRotTotal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x000FC76C File Offset: 0x000FA96C
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x0001243C File Offset: 0x0001063C
		public unsafe static Il2CppStructArray<byte> PC2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_PC2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_PC2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x0600334D RID: 13133 RVA: 0x000FC794 File Offset: 0x000FA994
		// (set) Token: 0x0600334E RID: 13134 RVA: 0x0001244E File Offset: 0x0001064E
		public unsafe static Il2CppStructArray<uint> ipTab
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_ipTab, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_ipTab, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x0600334F RID: 13135 RVA: 0x000FC7BC File Offset: 0x000FA9BC
		// (set) Token: 0x06003350 RID: 13136 RVA: 0x00012460 File Offset: 0x00010660
		public unsafe static Il2CppStructArray<uint> fpTab
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_fpTab, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_fpTab, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B93 RID: 11155
		private static readonly IntPtr NativeFieldInfoPtr_KEY_BIT_SIZE;

		// Token: 0x04002B94 RID: 11156
		private static readonly IntPtr NativeFieldInfoPtr_KEY_BYTE_SIZE;

		// Token: 0x04002B95 RID: 11157
		private static readonly IntPtr NativeFieldInfoPtr_BLOCK_BIT_SIZE;

		// Token: 0x04002B96 RID: 11158
		private static readonly IntPtr NativeFieldInfoPtr_BLOCK_BYTE_SIZE;

		// Token: 0x04002B97 RID: 11159
		private static readonly IntPtr NativeFieldInfoPtr_keySchedule;

		// Token: 0x04002B98 RID: 11160
		private static readonly IntPtr NativeFieldInfoPtr_byteBuff;

		// Token: 0x04002B99 RID: 11161
		private static readonly IntPtr NativeFieldInfoPtr_dwordBuff;

		// Token: 0x04002B9A RID: 11162
		private static readonly IntPtr NativeFieldInfoPtr_spBoxes;

		// Token: 0x04002B9B RID: 11163
		private static readonly IntPtr NativeFieldInfoPtr_PC1;

		// Token: 0x04002B9C RID: 11164
		private static readonly IntPtr NativeFieldInfoPtr_leftRotTotal;

		// Token: 0x04002B9D RID: 11165
		private static readonly IntPtr NativeFieldInfoPtr_PC2;

		// Token: 0x04002B9E RID: 11166
		private static readonly IntPtr NativeFieldInfoPtr_ipTab;

		// Token: 0x04002B9F RID: 11167
		private static readonly IntPtr NativeFieldInfoPtr_fpTab;

		// Token: 0x04002BA0 RID: 11168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BA1 RID: 11169
		private static readonly IntPtr NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0;

		// Token: 0x04002BA2 RID: 11170
		private static readonly IntPtr NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x04002BA3 RID: 11171
		private static readonly IntPtr NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BA4 RID: 11172
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BA5 RID: 11173
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BA6 RID: 11174
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BA7 RID: 11175
		private static readonly IntPtr NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0;
	}
}
