using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002F RID: 47
	public class MD4Managed : MD4
	{
		// Token: 0x0600030A RID: 778 RVA: 0x0002DE2C File Offset: 0x0002C02C
		// Note: this type is marked as 'beforefieldinit'.
		static MD4Managed()
		{
			Il2CppClassPointerStore<MD4Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "MD4Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr);
			MD4Managed.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, "state");
			MD4Managed.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, "buffer");
			MD4Managed.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, "count");
			MD4Managed.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, "x");
			MD4Managed.NativeFieldInfoPtr_digest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, "digest");
			MD4Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663697);
			MD4Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663698);
			MD4Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663699);
			MD4Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663700);
			MD4Managed.NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663701);
			MD4Managed.NativeMethodInfoPtr_F_Private_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663702);
			MD4Managed.NativeMethodInfoPtr_G_Private_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663703);
			MD4Managed.NativeMethodInfoPtr_H_Private_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663704);
			MD4Managed.NativeMethodInfoPtr_ROL_Private_UInt32_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663705);
			MD4Managed.NativeMethodInfoPtr_FF_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663706);
			MD4Managed.NativeMethodInfoPtr_GG_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663707);
			MD4Managed.NativeMethodInfoPtr_HH_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663708);
			MD4Managed.NativeMethodInfoPtr_Encode_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663709);
			MD4Managed.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663710);
			MD4Managed.NativeMethodInfoPtr_MD4Transform_Private_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr, 100663711);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0002DFEC File Offset: 0x0002C1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262888, XrefRangeEnd = 262901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD4Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD4Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0002E028 File Offset: 0x0002C228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD4Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0002E064 File Offset: 0x0002C264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD4Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262901, XrefRangeEnd = 262910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD4Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0002E11C File Offset: 0x0002C31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262910, XrefRangeEnd = 262911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Padding(int nLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0002E168 File Offset: 0x0002C368
		[CallerCount(0)]
		public unsafe uint F(uint x, uint y, uint z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_F_Private_UInt32_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		[CallerCount(0)]
		public unsafe uint G(uint x, uint y, uint z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_G_Private_UInt32_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0002E238 File Offset: 0x0002C438
		[CallerCount(0)]
		public unsafe uint H(uint x, uint y, uint z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_H_Private_UInt32_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0002E2A0 File Offset: 0x0002C4A0
		[CallerCount(0)]
		public unsafe uint ROL(uint x, byte n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_ROL_Private_UInt32_UInt32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0002E2F8 File Offset: 0x0002C4F8
		[CallerCount(0)]
		public unsafe void FF(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_FF_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0002E37C File Offset: 0x0002C57C
		[CallerCount(0)]
		public unsafe void GG(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_GG_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0002E400 File Offset: 0x0002C600
		[CallerCount(0)]
		public unsafe void HH(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_HH_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0002E484 File Offset: 0x0002C684
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 10394, RefRangeEnd = 10398, XrefRangeStart = 10394, XrefRangeEnd = 10398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encode(Il2CppStructArray<byte> output, Il2CppStructArray<uint> input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_Encode_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0002E4D8 File Offset: 0x0002C6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decode(Il2CppStructArray<uint> output, Il2CppStructArray<byte> input, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0002E53C File Offset: 0x0002C73C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 10400, RefRangeEnd = 10404, XrefRangeStart = 10400, XrefRangeEnd = 10404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MD4Transform(Il2CppStructArray<uint> state, Il2CppStructArray<byte> block, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(block);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4Managed.NativeMethodInfoPtr_MD4Transform_Private_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000341F File Offset: 0x0000161F
		public MD4Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003428 File Offset: 0x00001628
		public unsafe Il2CppStructArray<uint> state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0002E5D0 File Offset: 0x0002C7D0
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003447 File Offset: 0x00001647
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0002E600 File Offset: 0x0002C800
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003466 File Offset: 0x00001666
		public unsafe Il2CppStructArray<uint> count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_count);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_count), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0002E630 File Offset: 0x0002C830
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003485 File Offset: 0x00001685
		public unsafe Il2CppStructArray<uint> x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_x);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0002E660 File Offset: 0x0002C860
		// (set) Token: 0x06000324 RID: 804 RVA: 0x000034A4 File Offset: 0x000016A4
		public unsafe Il2CppStructArray<byte> digest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_digest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD4Managed.NativeFieldInfoPtr_digest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_digest;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_F_Private_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_G_Private_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_H_Private_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_ROL_Private_UInt32_UInt32_Byte_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_FF_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_GG_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_HH_Private_Void_byref_UInt32_UInt32_UInt32_UInt32_UInt32_Byte_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_MD4Transform_Private_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_Int32_0;
	}
}
