using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000305 RID: 773
	public class SHA384Managed : SHA384
	{
		// Token: 0x0600326F RID: 12911 RVA: 0x000F93B8 File Offset: 0x000F75B8
		// Note: this type is marked as 'beforefieldinit'.
		static SHA384Managed()
		{
			Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA384Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr);
			SHA384Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_buffer");
			SHA384Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_count");
			SHA384Managed.NativeFieldInfoPtr__stateSHA384 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_stateSHA384");
			SHA384Managed.NativeFieldInfoPtr__W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_W");
			SHA384Managed.NativeFieldInfoPtr__K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_K");
			SHA384Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671161);
			SHA384Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671162);
			SHA384Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671163);
			SHA384Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671164);
			SHA384Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671165);
			SHA384Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671166);
			SHA384Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671167);
			SHA384Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671168);
			SHA384Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671169);
			SHA384Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671170);
			SHA384Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671171);
			SHA384Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671172);
			SHA384Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671173);
			SHA384Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671174);
			SHA384Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671175);
			SHA384Managed.NativeMethodInfoPtr_SHA384Expand_Private_Static_Void_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100671176);
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x000F958C File Offset: 0x000F778C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 340773, RefRangeEnd = 340777, XrefRangeStart = 340755, XrefRangeEnd = 340773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA384Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x000F95C8 File Offset: 0x000F77C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340777, XrefRangeEnd = 340781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA384Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000F9604 File Offset: 0x000F7804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340781, XrefRangeEnd = 340782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA384Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000F9670 File Offset: 0x000F7870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340782, XrefRangeEnd = 340783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA384Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000F96BC File Offset: 0x000F78BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340783, RefRangeEnd = 340786, XrefRangeStart = 340783, XrefRangeEnd = 340783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x000F96F0 File Offset: 0x000F78F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340799, RefRangeEnd = 340801, XrefRangeStart = 340786, XrefRangeEnd = 340799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000F9750 File Offset: 0x000F7950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340808, RefRangeEnd = 340809, XrefRangeStart = 340801, XrefRangeEnd = 340808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x000F9790 File Offset: 0x000F7990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340847, RefRangeEnd = 340849, XrefRangeStart = 340809, XrefRangeEnd = 340847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000F97DC File Offset: 0x000F79DC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x000F9828 File Offset: 0x000F7A28
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x000F9884 File Offset: 0x000F7A84
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000F98E0 File Offset: 0x000F7AE0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 340852, RefRangeEnd = 340860, XrefRangeStart = 340849, XrefRangeEnd = 340852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sigma_0(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x000F9920 File Offset: 0x000F7B20
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 340863, RefRangeEnd = 340871, XrefRangeStart = 340860, XrefRangeEnd = 340863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sigma_1(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000F9960 File Offset: 0x000F7B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340874, RefRangeEnd = 340876, XrefRangeStart = 340871, XrefRangeEnd = 340874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong sigma_0(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000F99A0 File Offset: 0x000F7BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340879, RefRangeEnd = 340881, XrefRangeStart = 340876, XrefRangeEnd = 340879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong sigma_1(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000F99E0 File Offset: 0x000F7BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340881, XrefRangeEnd = 340886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHA384Expand(ulong* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_SHA384Expand_Private_Static_Void_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x00011ECE File Offset: 0x000100CE
		public SHA384Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06003281 RID: 12929 RVA: 0x000F9A14 File Offset: 0x000F7C14
		// (set) Token: 0x06003282 RID: 12930 RVA: 0x00011ED7 File Offset: 0x000100D7
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x000F9A44 File Offset: 0x000F7C44
		// (set) Token: 0x06003284 RID: 12932 RVA: 0x00011EF6 File Offset: 0x000100F6
		public unsafe ulong _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06003285 RID: 12933 RVA: 0x000F9A6C File Offset: 0x000F7C6C
		// (set) Token: 0x06003286 RID: 12934 RVA: 0x00011F11 File Offset: 0x00010111
		public unsafe Il2CppStructArray<ulong> _stateSHA384
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__stateSHA384);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__stateSHA384), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x000F9A9C File Offset: 0x000F7C9C
		// (set) Token: 0x06003288 RID: 12936 RVA: 0x00011F30 File Offset: 0x00010130
		public unsafe Il2CppStructArray<ulong> _W
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__W);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__W), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x000F9ACC File Offset: 0x000F7CCC
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x00011F4F File Offset: 0x0001014F
		public unsafe static Il2CppStructArray<ulong> _K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SHA384Managed.NativeFieldInfoPtr__K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SHA384Managed.NativeFieldInfoPtr__K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B0F RID: 11023
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04002B10 RID: 11024
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04002B11 RID: 11025
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA384;

		// Token: 0x04002B12 RID: 11026
		private static readonly IntPtr NativeFieldInfoPtr__W;

		// Token: 0x04002B13 RID: 11027
		private static readonly IntPtr NativeFieldInfoPtr__K;

		// Token: 0x04002B14 RID: 11028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B15 RID: 11029
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002B16 RID: 11030
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B17 RID: 11031
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B18 RID: 11032
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x04002B19 RID: 11033
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B1A RID: 11034
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B1B RID: 11035
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0;

		// Token: 0x04002B1C RID: 11036
		private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0;

		// Token: 0x04002B1D RID: 11037
		private static readonly IntPtr NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B1E RID: 11038
		private static readonly IntPtr NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B1F RID: 11039
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002B20 RID: 11040
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002B21 RID: 11041
		private static readonly IntPtr NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002B22 RID: 11042
		private static readonly IntPtr NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002B23 RID: 11043
		private static readonly IntPtr NativeMethodInfoPtr_SHA384Expand_Private_Static_Void_ptr_UInt64_0;
	}
}
