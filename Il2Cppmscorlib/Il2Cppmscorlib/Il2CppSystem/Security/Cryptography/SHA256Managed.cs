using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000303 RID: 771
	public class SHA256Managed : SHA256
	{
		// Token: 0x0600324F RID: 12879 RVA: 0x000F8BB4 File Offset: 0x000F6DB4
		// Note: this type is marked as 'beforefieldinit'.
		static SHA256Managed()
		{
			Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA256Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr);
			SHA256Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_buffer");
			SHA256Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_count");
			SHA256Managed.NativeFieldInfoPtr__stateSHA256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_stateSHA256");
			SHA256Managed.NativeFieldInfoPtr__W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_W");
			SHA256Managed.NativeFieldInfoPtr__K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_K");
			SHA256Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671142);
			SHA256Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671143);
			SHA256Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671144);
			SHA256Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671145);
			SHA256Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671146);
			SHA256Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671147);
			SHA256Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671148);
			SHA256Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671149);
			SHA256Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671150);
			SHA256Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671151);
			SHA256Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671152);
			SHA256Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671153);
			SHA256Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671154);
			SHA256Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671155);
			SHA256Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671156);
			SHA256Managed.NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671157);
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x000F8D88 File Offset: 0x000F6F88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 340626, RefRangeEnd = 340630, XrefRangeStart = 340608, XrefRangeEnd = 340626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA256Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x000F8DC4 File Offset: 0x000F6FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340630, XrefRangeEnd = 340634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000F8E00 File Offset: 0x000F7000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340634, XrefRangeEnd = 340635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x000F8E6C File Offset: 0x000F706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340635, XrefRangeEnd = 340636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x000F8EB8 File Offset: 0x000F70B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340636, RefRangeEnd = 340639, XrefRangeStart = 340636, XrefRangeEnd = 340636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x000F8EEC File Offset: 0x000F70EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340652, RefRangeEnd = 340654, XrefRangeStart = 340639, XrefRangeEnd = 340652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HashData(Il2CppStructArray<byte> partIn, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partIn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000F8F4C File Offset: 0x000F714C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340661, RefRangeEnd = 340662, XrefRangeStart = 340654, XrefRangeEnd = 340661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000F8F8C File Offset: 0x000F718C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340700, RefRangeEnd = 340702, XrefRangeStart = 340662, XrefRangeEnd = 340700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = expandedBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x000F8FD8 File Offset: 0x000F71D8
		[CallerCount(0)]
		public unsafe static uint RotateRight(uint x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x000F9024 File Offset: 0x000F7224
		[CallerCount(0)]
		public unsafe static uint Ch(uint x, uint y, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x000F9080 File Offset: 0x000F7280
		[CallerCount(0)]
		public unsafe static uint Maj(uint x, uint y, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x000F90DC File Offset: 0x000F72DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340705, RefRangeEnd = 340707, XrefRangeStart = 340702, XrefRangeEnd = 340705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint sigma_0(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x000F911C File Offset: 0x000F731C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340710, RefRangeEnd = 340712, XrefRangeStart = 340707, XrefRangeEnd = 340710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint sigma_1(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x000F915C File Offset: 0x000F735C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 340715, RefRangeEnd = 340723, XrefRangeStart = 340712, XrefRangeEnd = 340715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Sigma_0(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x000F919C File Offset: 0x000F739C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 340726, RefRangeEnd = 340734, XrefRangeStart = 340723, XrefRangeEnd = 340726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Sigma_1(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x000F91DC File Offset: 0x000F73DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340734, XrefRangeEnd = 340739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHA256Expand(uint* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00011E32 File Offset: 0x00010032
		public SHA256Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x000F9210 File Offset: 0x000F7410
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x00011E3B File Offset: 0x0001003B
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x000F9240 File Offset: 0x000F7440
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x00011E5A File Offset: 0x0001005A
		public unsafe long _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x000F9268 File Offset: 0x000F7468
		// (set) Token: 0x06003266 RID: 12902 RVA: 0x00011E75 File Offset: 0x00010075
		public unsafe Il2CppStructArray<uint> _stateSHA256
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__stateSHA256);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__stateSHA256), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x000F9298 File Offset: 0x000F7498
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x00011E94 File Offset: 0x00010094
		public unsafe Il2CppStructArray<uint> _W
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__W);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__W), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x000F92C8 File Offset: 0x000F74C8
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x00011EB3 File Offset: 0x000100B3
		public unsafe static Il2CppStructArray<uint> _K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SHA256Managed.NativeFieldInfoPtr__K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SHA256Managed.NativeFieldInfoPtr__K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AF8 RID: 11000
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA256;

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeFieldInfoPtr__W;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeFieldInfoPtr__K;

		// Token: 0x04002AFD RID: 11005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002AFE RID: 11006
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002AFF RID: 11007
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B00 RID: 11008
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B01 RID: 11009
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x04002B02 RID: 11010
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B03 RID: 11011
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B04 RID: 11012
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0;

		// Token: 0x04002B05 RID: 11013
		private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0;

		// Token: 0x04002B06 RID: 11014
		private static readonly IntPtr NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly IntPtr NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002B08 RID: 11016
		private static readonly IntPtr NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0;

		// Token: 0x04002B09 RID: 11017
		private static readonly IntPtr NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0;

		// Token: 0x04002B0A RID: 11018
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0;

		// Token: 0x04002B0B RID: 11019
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0;

		// Token: 0x04002B0C RID: 11020
		private static readonly IntPtr NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0;
	}
}
