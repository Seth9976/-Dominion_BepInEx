using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x020002BC RID: 700
	public sealed class SecureString : Object
	{
		// Token: 0x06002EE9 RID: 12009 RVA: 0x000ECC30 File Offset: 0x000EAE30
		// Note: this type is marked as 'beforefieldinit'.
		static SecureString()
		{
			Il2CppClassPointerStore<SecureString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecureString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureString>.NativeClassPtr);
			SecureString.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "length");
			SecureString.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "disposed");
			SecureString.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "data");
			SecureString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670738);
			SecureString.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670739);
			SecureString.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670740);
			SecureString.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670741);
			SecureString.NativeMethodInfoPtr_Encrypt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670742);
			SecureString.NativeMethodInfoPtr_Decrypt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670743);
			SecureString.NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670744);
			SecureString.NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100670745);
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x000ECD3C File Offset: 0x000EAF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337377, XrefRangeEnd = 337382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x000ECD78 File Offset: 0x000EAF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337384, RefRangeEnd = 337385, XrefRangeStart = 337382, XrefRangeEnd = 337384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureString(char* value, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x000ECDCC File Offset: 0x000EAFCC
		public unsafe int Length
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 337385, RefRangeEnd = 337387, XrefRangeStart = 337385, XrefRangeEnd = 337385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x000ECE08 File Offset: 0x000EB008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337387, XrefRangeEnd = 337388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x000ECE3C File Offset: 0x000EB03C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331426, RefRangeEnd = 331429, XrefRangeStart = 331426, XrefRangeEnd = 331429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encrypt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Encrypt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x000ECE70 File Offset: 0x000EB070
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331426, RefRangeEnd = 331429, XrefRangeStart = 331426, XrefRangeEnd = 331429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decrypt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Decrypt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x000ECEA4 File Offset: 0x000EB0A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337392, RefRangeEnd = 337393, XrefRangeStart = 337388, XrefRangeEnd = 337392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Alloc(int length, bool realloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realloc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000ECEF0 File Offset: 0x000EB0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337398, RefRangeEnd = 337399, XrefRangeStart = 337393, XrefRangeEnd = 337398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00010612 File Offset: 0x0000E812
		public SecureString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x000ECF30 File Offset: 0x000EB130
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x0001061B File Offset: 0x0000E81B
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x000ECF58 File Offset: 0x000EB158
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x00010636 File Offset: 0x0000E836
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x000ECF80 File Offset: 0x000EB180
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x00010651 File Offset: 0x0000E851
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Private_Void_0;

		// Token: 0x0400289B RID: 10395
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Private_Void_0;

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0;
	}
}
