using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002B RID: 43
	public class MD2Managed : MD2
	{
		// Token: 0x0600021C RID: 540 RVA: 0x0000B620 File Offset: 0x00009820
		// Note: this type is marked as 'beforefieldinit'.
		static MD2Managed()
		{
			Il2CppClassPointerStore<MD2Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "MD2Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr);
			MD2Managed.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "state");
			MD2Managed.NativeFieldInfoPtr_checksum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "checksum");
			MD2Managed.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "buffer");
			MD2Managed.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "count");
			MD2Managed.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "x");
			MD2Managed.NativeFieldInfoPtr_PI_SUBST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "PI_SUBST");
			MD2Managed.NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663577);
			MD2Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663578);
			MD2Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663579);
			MD2Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663580);
			MD2Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663581);
			MD2Managed.NativeMethodInfoPtr_MD2Transform_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663582);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000B740 File Offset: 0x00009940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10292, XrefRangeEnd = 10293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600021E RID: 542 RVA: 0x0000B78C File Offset: 0x0000998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10293, XrefRangeEnd = 10303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD2Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000B7C8 File Offset: 0x000099C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10303, XrefRangeEnd = 10307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD2Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B804 File Offset: 0x00009A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10307, XrefRangeEnd = 10312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000221 RID: 545 RVA: 0x0000B870 File Offset: 0x00009A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10312, XrefRangeEnd = 10320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000222 RID: 546 RVA: 0x0000B8BC File Offset: 0x00009ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 10330, RefRangeEnd = 10332, XrefRangeStart = 10320, XrefRangeEnd = 10330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000223 RID: 547 RVA: 0x00002EB9 File Offset: 0x000010B9
		public MD2Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000B930 File Offset: 0x00009B30
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002EC2 File Offset: 0x000010C2
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000B960 File Offset: 0x00009B60
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002EE1 File Offset: 0x000010E1
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000B990 File Offset: 0x00009B90
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002F00 File Offset: 0x00001100
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002F1F File Offset: 0x0000111F
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00002F3A File Offset: 0x0000113A
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000BA18 File Offset: 0x00009C18
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002F59 File Offset: 0x00001159
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

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_checksum;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_PI_SUBST;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_MD2Transform_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;
	}
}
