using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FC RID: 764
	public class RIPEMD160Managed : RIPEMD160
	{
		// Token: 0x060031E4 RID: 12772 RVA: 0x000F7408 File Offset: 0x000F5608
		// Note: this type is marked as 'beforefieldinit'.
		static RIPEMD160Managed()
		{
			Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RIPEMD160Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr);
			RIPEMD160Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, "_buffer");
			RIPEMD160Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, "_count");
			RIPEMD160Managed.NativeFieldInfoPtr__stateMD160 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, "_stateMD160");
			RIPEMD160Managed.NativeFieldInfoPtr__blockDWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, "_blockDWords");
			RIPEMD160Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671096);
			RIPEMD160Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671097);
			RIPEMD160Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671098);
			RIPEMD160Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671099);
			RIPEMD160Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671100);
			RIPEMD160Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671101);
			RIPEMD160Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671102);
			RIPEMD160Managed.NativeMethodInfoPtr_MDTransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671103);
			RIPEMD160Managed.NativeMethodInfoPtr_F_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671104);
			RIPEMD160Managed.NativeMethodInfoPtr_G_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671105);
			RIPEMD160Managed.NativeMethodInfoPtr_H_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671106);
			RIPEMD160Managed.NativeMethodInfoPtr_I_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671107);
			RIPEMD160Managed.NativeMethodInfoPtr_J_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100671108);
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x000F758C File Offset: 0x000F578C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 340250, RefRangeEnd = 340254, XrefRangeStart = 340232, XrefRangeEnd = 340250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RIPEMD160Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x000F75C8 File Offset: 0x000F57C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340254, XrefRangeEnd = 340258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RIPEMD160Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x000F7604 File Offset: 0x000F5804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340258, XrefRangeEnd = 340259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RIPEMD160Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000F7670 File Offset: 0x000F5870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340259, XrefRangeEnd = 340260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RIPEMD160Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000F76BC File Offset: 0x000F58BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 340260, RefRangeEnd = 340265, XrefRangeStart = 340260, XrefRangeEnd = 340260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000F76F0 File Offset: 0x000F58F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340273, RefRangeEnd = 340275, XrefRangeStart = 340265, XrefRangeEnd = 340273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000F7750 File Offset: 0x000F5950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340282, RefRangeEnd = 340283, XrefRangeStart = 340275, XrefRangeEnd = 340282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x000F7790 File Offset: 0x000F5990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340284, RefRangeEnd = 340286, XrefRangeStart = 340283, XrefRangeEnd = 340284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MDTransform(uint* blockDWords, uint* state, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = blockDWords;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_MDTransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x000F77DC File Offset: 0x000F59DC
		[CallerCount(0)]
		public unsafe static uint F(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_F_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000F7838 File Offset: 0x000F5A38
		[CallerCount(0)]
		public unsafe static uint G(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_G_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x000F7894 File Offset: 0x000F5A94
		[CallerCount(0)]
		public unsafe static uint H(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_H_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x000F78F0 File Offset: 0x000F5AF0
		[CallerCount(0)]
		public unsafe static uint I(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_I_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x000F794C File Offset: 0x000F5B4C
		[CallerCount(0)]
		public unsafe static uint J(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_J_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x00011B41 File Offset: 0x0000FD41
		public RIPEMD160Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x000F79A8 File Offset: 0x000F5BA8
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x00011B4A File Offset: 0x0000FD4A
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000F79D8 File Offset: 0x000F5BD8
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x00011B69 File Offset: 0x0000FD69
		public unsafe long _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060031F7 RID: 12791 RVA: 0x000F7A00 File Offset: 0x000F5C00
		// (set) Token: 0x060031F8 RID: 12792 RVA: 0x00011B84 File Offset: 0x0000FD84
		public unsafe Il2CppStructArray<uint> _stateMD160
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__stateMD160);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__stateMD160), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x000F7A30 File Offset: 0x000F5C30
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x00011BA3 File Offset: 0x0000FDA3
		public unsafe Il2CppStructArray<uint> _blockDWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__blockDWords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__blockDWords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AB3 RID: 10931
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04002AB4 RID: 10932
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04002AB5 RID: 10933
		private static readonly IntPtr NativeFieldInfoPtr__stateMD160;

		// Token: 0x04002AB6 RID: 10934
		private static readonly IntPtr NativeFieldInfoPtr__blockDWords;

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002ABB RID: 10939
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeMethodInfoPtr_MDTransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0;

		// Token: 0x04002ABF RID: 10943
		private static readonly IntPtr NativeMethodInfoPtr_F_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002AC0 RID: 10944
		private static readonly IntPtr NativeMethodInfoPtr_G_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002AC1 RID: 10945
		private static readonly IntPtr NativeMethodInfoPtr_H_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002AC2 RID: 10946
		private static readonly IntPtr NativeMethodInfoPtr_I_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002AC3 RID: 10947
		private static readonly IntPtr NativeMethodInfoPtr_J_Private_Static_UInt32_UInt32_UInt32_UInt32_0;
	}
}
