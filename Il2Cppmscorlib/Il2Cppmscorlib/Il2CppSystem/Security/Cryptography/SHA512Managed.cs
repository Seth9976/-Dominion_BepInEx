using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000307 RID: 775
	public class SHA512Managed : SHA512
	{
		// Token: 0x0600328F RID: 12943 RVA: 0x000F9BBC File Offset: 0x000F7DBC
		// Note: this type is marked as 'beforefieldinit'.
		static SHA512Managed()
		{
			Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA512Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr);
			SHA512Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_buffer");
			SHA512Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_count");
			SHA512Managed.NativeFieldInfoPtr__stateSHA512 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_stateSHA512");
			SHA512Managed.NativeFieldInfoPtr__W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_W");
			SHA512Managed.NativeFieldInfoPtr__K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_K");
			SHA512Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671180);
			SHA512Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671181);
			SHA512Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671182);
			SHA512Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671183);
			SHA512Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671184);
			SHA512Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671185);
			SHA512Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671186);
			SHA512Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671187);
			SHA512Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671188);
			SHA512Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671189);
			SHA512Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671190);
			SHA512Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671191);
			SHA512Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671192);
			SHA512Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671193);
			SHA512Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671194);
			SHA512Managed.NativeMethodInfoPtr_SHA512Expand_Private_Static_Void_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100671195);
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000F9D90 File Offset: 0x000F7F90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 340921, RefRangeEnd = 340925, XrefRangeStart = 340903, XrefRangeEnd = 340921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA512Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000F9DCC File Offset: 0x000F7FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340925, XrefRangeEnd = 340929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA512Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000F9E08 File Offset: 0x000F8008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340929, XrefRangeEnd = 340930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA512Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x000F9E74 File Offset: 0x000F8074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340930, XrefRangeEnd = 340931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA512Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000F9EC0 File Offset: 0x000F80C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340931, RefRangeEnd = 340934, XrefRangeStart = 340931, XrefRangeEnd = 340931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000F9EF4 File Offset: 0x000F80F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340947, RefRangeEnd = 340949, XrefRangeStart = 340934, XrefRangeEnd = 340947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000F9F54 File Offset: 0x000F8154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340956, RefRangeEnd = 340957, XrefRangeStart = 340949, XrefRangeEnd = 340956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x000F9F94 File Offset: 0x000F8194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340995, RefRangeEnd = 340997, XrefRangeStart = 340957, XrefRangeEnd = 340995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000F9FE0 File Offset: 0x000F81E0
		[CallerCount(0)]
		public unsafe static ulong RotateRight(ulong x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000FA02C File Offset: 0x000F822C
		[CallerCount(0)]
		public unsafe static ulong Ch(ulong x, ulong y, ulong z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000FA088 File Offset: 0x000F8288
		[CallerCount(0)]
		public unsafe static ulong Maj(ulong x, ulong y, ulong z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000FA0E4 File Offset: 0x000F82E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 341000, RefRangeEnd = 341008, XrefRangeStart = 340997, XrefRangeEnd = 341000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sigma_0(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000FA124 File Offset: 0x000F8324
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 341011, RefRangeEnd = 341019, XrefRangeStart = 341008, XrefRangeEnd = 341011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sigma_1(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x000FA164 File Offset: 0x000F8364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341022, RefRangeEnd = 341024, XrefRangeStart = 341019, XrefRangeEnd = 341022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong sigma_0(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000FA1A4 File Offset: 0x000F83A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341027, RefRangeEnd = 341029, XrefRangeStart = 341024, XrefRangeEnd = 341027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong sigma_1(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000FA1E4 File Offset: 0x000F83E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341029, XrefRangeEnd = 341034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHA512Expand(ulong* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_SHA512Expand_Private_Static_Void_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00011F6A File Offset: 0x0001016A
		public SHA512Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x000FA218 File Offset: 0x000F8418
		// (set) Token: 0x060032A2 RID: 12962 RVA: 0x00011F73 File Offset: 0x00010173
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060032A3 RID: 12963 RVA: 0x000FA248 File Offset: 0x000F8448
		// (set) Token: 0x060032A4 RID: 12964 RVA: 0x00011F92 File Offset: 0x00010192
		public unsafe ulong _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060032A5 RID: 12965 RVA: 0x000FA270 File Offset: 0x000F8470
		// (set) Token: 0x060032A6 RID: 12966 RVA: 0x00011FAD File Offset: 0x000101AD
		public unsafe Il2CppStructArray<ulong> _stateSHA512
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__stateSHA512);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__stateSHA512), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060032A7 RID: 12967 RVA: 0x000FA2A0 File Offset: 0x000F84A0
		// (set) Token: 0x060032A8 RID: 12968 RVA: 0x00011FCC File Offset: 0x000101CC
		public unsafe Il2CppStructArray<ulong> _W
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__W);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__W), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060032A9 RID: 12969 RVA: 0x000FA2D0 File Offset: 0x000F84D0
		// (set) Token: 0x060032AA RID: 12970 RVA: 0x00011FEB File Offset: 0x000101EB
		public unsafe static Il2CppStructArray<ulong> _K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SHA512Managed.NativeFieldInfoPtr__K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SHA512Managed.NativeFieldInfoPtr__K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B26 RID: 11046
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA512;

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeFieldInfoPtr__W;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeFieldInfoPtr__K;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x04002B30 RID: 11056
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B31 RID: 11057
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B32 RID: 11058
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0;

		// Token: 0x04002B33 RID: 11059
		private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0;

		// Token: 0x04002B34 RID: 11060
		private static readonly IntPtr NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B35 RID: 11061
		private static readonly IntPtr NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B36 RID: 11062
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002B37 RID: 11063
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002B38 RID: 11064
		private static readonly IntPtr NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002B39 RID: 11065
		private static readonly IntPtr NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002B3A RID: 11066
		private static readonly IntPtr NativeMethodInfoPtr_SHA512Expand_Private_Static_Void_ptr_UInt64_0;
	}
}
