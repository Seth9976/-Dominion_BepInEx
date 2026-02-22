using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E1 RID: 737
	public class DES : SymmetricAlgorithm
	{
		// Token: 0x060030A1 RID: 12449 RVA: 0x000F2B90 File Offset: 0x000F0D90
		// Note: this type is marked as 'beforefieldinit'.
		static DES()
		{
			Il2CppClassPointerStore<DES>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DES");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DES>.NativeClassPtr);
			DES.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DES>.NativeClassPtr, "s_legalBlockSizes");
			DES.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DES>.NativeClassPtr, "s_legalKeySizes");
			DES.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100670953);
			DES.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100670954);
			DES.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100670955);
			DES.NativeMethodInfoPtr_Create_Public_Static_DES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100670956);
			DES.NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100670957);
			DES.NativeMethodInfoPtr_IsSemiWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100670958);
			DES.NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100670959);
			DES.NativeMethodInfoPtr_QuadWordFromBigEndian_Private_Static_UInt64_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100670960);
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x000F2C88 File Offset: 0x000F0E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339196, XrefRangeEnd = 339202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DES()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DES>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x000F2CC4 File Offset: 0x000F0EC4
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x000F2D10 File Offset: 0x000F0F10
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339202, XrefRangeEnd = 339212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DES.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339212, XrefRangeEnd = 339224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DES.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x000F2D60 File Offset: 0x000F0F60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 339228, RefRangeEnd = 339234, XrefRangeStart = 339224, XrefRangeEnd = 339228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DES Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_Create_Public_Static_DES_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DES>(intPtr3) : null;
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x000F2D94 File Offset: 0x000F0F94
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 339241, RefRangeEnd = 339249, XrefRangeStart = 339234, XrefRangeEnd = 339241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWeakKey(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x000F2DD8 File Offset: 0x000F0FD8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 339256, RefRangeEnd = 339264, XrefRangeStart = 339249, XrefRangeEnd = 339256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSemiWeakKey(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_IsSemiWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x000F2E1C File Offset: 0x000F101C
		[CallerCount(0)]
		public unsafe static bool IsLegalKeySize(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x000F2E60 File Offset: 0x000F1060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339264, RefRangeEnd = 339266, XrefRangeStart = 339264, XrefRangeEnd = 339264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong QuadWordFromBigEndian(Il2CppStructArray<byte> block)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_QuadWordFromBigEndian_Private_Static_UInt64_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x00011350 File Offset: 0x0000F550
		public DES(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x000F2EA4 File Offset: 0x000F10A4
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x00011359 File Offset: 0x0000F559
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DES.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DES.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x000F2ECC File Offset: 0x000F10CC
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x0001136B File Offset: 0x0000F56B
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DES.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DES.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029E4 RID: 10724
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x040029E5 RID: 10725
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x040029E6 RID: 10726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040029E7 RID: 10727
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040029E8 RID: 10728
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040029E9 RID: 10729
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DES_0;

		// Token: 0x040029EA RID: 10730
		private static readonly IntPtr NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x040029EB RID: 10731
		private static readonly IntPtr NativeMethodInfoPtr_IsSemiWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x040029EC RID: 10732
		private static readonly IntPtr NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x040029ED RID: 10733
		private static readonly IntPtr NativeMethodInfoPtr_QuadWordFromBigEndian_Private_Static_UInt64_Il2CppStructArray_1_Byte_0;
	}
}
