using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E8 RID: 744
	public class HMAC : KeyedHashAlgorithm
	{
		// Token: 0x060030F5 RID: 12533 RVA: 0x000F3E7C File Offset: 0x000F207C
		// Note: this type is marked as 'beforefieldinit'.
		static HMAC()
		{
			Il2CppClassPointerStore<HMAC>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMAC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMAC>.NativeClassPtr);
			HMAC.NativeFieldInfoPtr_blockSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "blockSizeValue");
			HMAC.NativeFieldInfoPtr_m_hashName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hashName");
			HMAC.NativeFieldInfoPtr_m_hash1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hash1");
			HMAC.NativeFieldInfoPtr_m_hash2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hash2");
			HMAC.NativeFieldInfoPtr_m_inner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_inner");
			HMAC.NativeFieldInfoPtr_m_outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_outer");
			HMAC.NativeFieldInfoPtr_m_hashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hashing");
			HMAC.NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670991);
			HMAC.NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670992);
			HMAC.NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670993);
			HMAC.NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670994);
			HMAC.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670995);
			HMAC.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670996);
			HMAC.NativeMethodInfoPtr_Create_Public_Static_HMAC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670997);
			HMAC.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670998);
			HMAC.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100670999);
			HMAC.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671000);
			HMAC.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671001);
			HMAC.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671002);
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000F4028 File Offset: 0x000F2228
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x000F4064 File Offset: 0x000F2264
		public unsafe int BlockSizeValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x000F40A4 File Offset: 0x000F22A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339549, RefRangeEnd = 339551, XrefRangeStart = 339543, XrefRangeEnd = 339549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIOPadBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x000F40D8 File Offset: 0x000F22D8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 339560, RefRangeEnd = 339573, XrefRangeStart = 339551, XrefRangeEnd = 339560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeKey(Il2CppStructArray<byte> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x000F411C File Offset: 0x000F231C
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x000F4168 File Offset: 0x000F2368
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339573, XrefRangeEnd = 339576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339576, XrefRangeEnd = 339592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000F41B8 File Offset: 0x000F23B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339596, RefRangeEnd = 339598, XrefRangeStart = 339592, XrefRangeEnd = 339596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HMAC Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_Create_Public_Static_HMAC_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HMAC>(intPtr3) : null;
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000F41EC File Offset: 0x000F23EC
		[CallerCount(0)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x000F4228 File Offset: 0x000F2428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339598, XrefRangeEnd = 339600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ib, int cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ib;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000F4294 File Offset: 0x000F2494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339600, XrefRangeEnd = 339610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000F42E0 File Offset: 0x000F24E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339610, XrefRangeEnd = 339618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000F432C File Offset: 0x000F252C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 339619, RefRangeEnd = 339632, XrefRangeStart = 339618, XrefRangeEnd = 339619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMAC()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMAC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x00011567 File Offset: 0x0000F767
		public HMAC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x000F4368 File Offset: 0x000F2568
		// (set) Token: 0x06003104 RID: 12548 RVA: 0x00011570 File Offset: 0x0000F770
		public unsafe int blockSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_blockSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_blockSizeValue)) = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x000F4390 File Offset: 0x000F2590
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x0001158B File Offset: 0x0000F78B
		public unsafe string m_hashName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x000F43B8 File Offset: 0x000F25B8
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x000115AA File Offset: 0x0000F7AA
		public unsafe HashAlgorithm m_hash1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000F43E8 File Offset: 0x000F25E8
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x000115C9 File Offset: 0x0000F7C9
		public unsafe HashAlgorithm m_hash2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x000F4418 File Offset: 0x000F2618
		// (set) Token: 0x0600310C RID: 12556 RVA: 0x000115E8 File Offset: 0x0000F7E8
		public unsafe Il2CppStructArray<byte> m_inner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_inner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_inner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x000F4448 File Offset: 0x000F2648
		// (set) Token: 0x0600310E RID: 12558 RVA: 0x00011607 File Offset: 0x0000F807
		public unsafe Il2CppStructArray<byte> m_outer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_outer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_outer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x000F4478 File Offset: 0x000F2678
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x00011626 File Offset: 0x0000F826
		public unsafe bool m_hashing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashing)) = value;
			}
		}

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeFieldInfoPtr_blockSizeValue;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeFieldInfoPtr_m_hashName;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeFieldInfoPtr_m_hash1;

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeFieldInfoPtr_m_hash2;

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeFieldInfoPtr_m_inner;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeFieldInfoPtr_m_outer;

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeFieldInfoPtr_m_hashing;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0;

		// Token: 0x04002A21 RID: 10785
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0;

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_HMAC_0;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
