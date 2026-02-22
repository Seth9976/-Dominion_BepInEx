using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000301 RID: 769
	public class SHA1Managed : SHA1
	{
		// Token: 0x06003238 RID: 12856 RVA: 0x000F867C File Offset: 0x000F687C
		// Note: this type is marked as 'beforefieldinit'.
		static SHA1Managed()
		{
			Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA1Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr);
			SHA1Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, "_buffer");
			SHA1Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, "_count");
			SHA1Managed.NativeFieldInfoPtr__stateSHA1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, "_stateSHA1");
			SHA1Managed.NativeFieldInfoPtr__expandedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, "_expandedBuffer");
			SHA1Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671131);
			SHA1Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671132);
			SHA1Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671133);
			SHA1Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671134);
			SHA1Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671135);
			SHA1Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671136);
			SHA1Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671137);
			SHA1Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671138);
			SHA1Managed.NativeMethodInfoPtr_SHAExpand_Private_Static_Void_ptr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100671139);
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x000F87B0 File Offset: 0x000F69B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 340559, RefRangeEnd = 340565, XrefRangeStart = 340541, XrefRangeEnd = 340559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA1Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x000F87EC File Offset: 0x000F69EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340565, XrefRangeEnd = 340569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA1Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x000F8828 File Offset: 0x000F6A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340569, XrefRangeEnd = 340570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA1Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x000F8894 File Offset: 0x000F6A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340570, XrefRangeEnd = 340571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA1Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000F88E0 File Offset: 0x000F6AE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 340260, RefRangeEnd = 340265, XrefRangeStart = 340260, XrefRangeEnd = 340265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x000F8914 File Offset: 0x000F6B14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340579, RefRangeEnd = 340581, XrefRangeStart = 340571, XrefRangeEnd = 340579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x000F8974 File Offset: 0x000F6B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340588, RefRangeEnd = 340589, XrefRangeStart = 340581, XrefRangeEnd = 340588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000F89B4 File Offset: 0x000F6BB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340590, RefRangeEnd = 340592, XrefRangeStart = 340589, XrefRangeEnd = 340590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000F8A00 File Offset: 0x000F6C00
		[CallerCount(0)]
		public unsafe static void SHAExpand(uint* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr_SHAExpand_Private_Static_Void_ptr_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		public SHA1Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06003243 RID: 12867 RVA: 0x000F8A34 File Offset: 0x000F6C34
		// (set) Token: 0x06003244 RID: 12868 RVA: 0x00011DB1 File Offset: 0x0000FFB1
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06003245 RID: 12869 RVA: 0x000F8A64 File Offset: 0x000F6C64
		// (set) Token: 0x06003246 RID: 12870 RVA: 0x00011DD0 File Offset: 0x0000FFD0
		public unsafe long _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06003247 RID: 12871 RVA: 0x000F8A8C File Offset: 0x000F6C8C
		// (set) Token: 0x06003248 RID: 12872 RVA: 0x00011DEB File Offset: 0x0000FFEB
		public unsafe Il2CppStructArray<uint> _stateSHA1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__stateSHA1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__stateSHA1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06003249 RID: 12873 RVA: 0x000F8ABC File Offset: 0x000F6CBC
		// (set) Token: 0x0600324A RID: 12874 RVA: 0x00011E0A File Offset: 0x0001000A
		public unsafe Il2CppStructArray<uint> _expandedBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__expandedBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__expandedBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA1;

		// Token: 0x04002AEC RID: 10988
		private static readonly IntPtr NativeFieldInfoPtr__expandedBuffer;

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AF4 RID: 10996
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0;

		// Token: 0x04002AF5 RID: 10997
		private static readonly IntPtr NativeMethodInfoPtr_SHAExpand_Private_Static_Void_ptr_UInt32_0;
	}
}
