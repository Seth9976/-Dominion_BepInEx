using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002D RID: 45
	public class MD2Managed : MD2
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x0002D944 File Offset: 0x0002BB44
		// Note: this type is marked as 'beforefieldinit'.
		static MD2Managed()
		{
			Il2CppClassPointerStore<MD2Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "MD2Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr);
			MD2Managed.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "state");
			MD2Managed.NativeFieldInfoPtr_checksum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "checksum");
			MD2Managed.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "buffer");
			MD2Managed.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "count");
			MD2Managed.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "x");
			MD2Managed.NativeFieldInfoPtr_PI_SUBST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "PI_SUBST");
			MD2Managed.NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663688);
			MD2Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663689);
			MD2Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663690);
			MD2Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663691);
			MD2Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663692);
			MD2Managed.NativeMethodInfoPtr_MD2Transform_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663693);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0002DA64 File Offset: 0x0002BC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262835, XrefRangeEnd = 262836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Padding(int nLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2Managed.NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0002DAB0 File Offset: 0x0002BCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262836, XrefRangeEnd = 262846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD2Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0002DAEC File Offset: 0x0002BCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD2Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0002DB28 File Offset: 0x0002BD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262846, XrefRangeEnd = 262851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> array, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD2Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0002DB94 File Offset: 0x0002BD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262851, XrefRangeEnd = 262859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD2Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0002DBE0 File Offset: 0x0002BDE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262869, RefRangeEnd = 262871, XrefRangeStart = 262859, XrefRangeEnd = 262869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MD2Transform(Il2CppStructArray<byte> state, Il2CppStructArray<byte> checksum, Il2CppStructArray<byte> block, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checksum);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(block);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2Managed.NativeMethodInfoPtr_MD2Transform_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003364 File Offset: 0x00001564
		public MD2Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0002DC54 File Offset: 0x0002BE54
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000336D File Offset: 0x0000156D
		public unsafe Il2CppStructArray<byte> state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0002DC84 File Offset: 0x0002BE84
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000338C File Offset: 0x0000158C
		public unsafe Il2CppStructArray<byte> checksum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_checksum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_checksum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0002DCB4 File Offset: 0x0002BEB4
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000033AB File Offset: 0x000015AB
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0002DCE4 File Offset: 0x0002BEE4
		// (set) Token: 0x06000301 RID: 769 RVA: 0x000033CA File Offset: 0x000015CA
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0002DD0C File Offset: 0x0002BF0C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x000033E5 File Offset: 0x000015E5
		public unsafe Il2CppStructArray<byte> x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_x);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00003404 File Offset: 0x00001604
		public unsafe static Il2CppStructArray<byte> PI_SUBST
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MD2Managed.NativeFieldInfoPtr_PI_SUBST, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MD2Managed.NativeFieldInfoPtr_PI_SUBST, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_checksum;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_PI_SUBST;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_MD2Transform_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;
	}
}
