using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F6 RID: 758
	public sealed class RC2CryptoServiceProvider : RC2
	{
		// Token: 0x06003180 RID: 12672 RVA: 0x000F5E50 File Offset: 0x000F4050
		// Note: this type is marked as 'beforefieldinit'.
		static RC2CryptoServiceProvider()
		{
			Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RC2CryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr);
			RC2CryptoServiceProvider.NativeFieldInfoPtr_m_use40bitSalt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr, "m_use40bitSalt");
			RC2CryptoServiceProvider.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr, "s_legalKeySizes");
			RC2CryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr, 100671059);
			RC2CryptoServiceProvider.NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr, 100671060);
			RC2CryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr, 100671061);
			RC2CryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr, 100671062);
			RC2CryptoServiceProvider.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr, 100671063);
			RC2CryptoServiceProvider.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr, 100671064);
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000F5F20 File Offset: 0x000F4120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339974, RefRangeEnd = 339975, XrefRangeStart = 339959, XrefRangeEnd = 339974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC2CryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC2CryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2CryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x000F5F5C File Offset: 0x000F415C
		public unsafe override int EffectiveKeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2CryptoServiceProvider.NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x000F5F98 File Offset: 0x000F4198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339975, XrefRangeEnd = 339979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICryptoTransform CreateEncryptor(Il2CppStructArray<byte> rgbKey, Il2CppStructArray<byte> rgbIV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2CryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x000F5FFC File Offset: 0x000F41FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339979, XrefRangeEnd = 339983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICryptoTransform CreateDecryptor(Il2CppStructArray<byte> rgbKey, Il2CppStructArray<byte> rgbIV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2CryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000F6060 File Offset: 0x000F4260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339983, XrefRangeEnd = 339998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2CryptoServiceProvider.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x000F6094 File Offset: 0x000F4294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339998, XrefRangeEnd = 340003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateIV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2CryptoServiceProvider.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00011851 File Offset: 0x0000FA51
		public RC2CryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x000F60C8 File Offset: 0x000F42C8
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x0001185A File Offset: 0x0000FA5A
		public unsafe bool m_use40bitSalt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2CryptoServiceProvider.NativeFieldInfoPtr_m_use40bitSalt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2CryptoServiceProvider.NativeFieldInfoPtr_m_use40bitSalt)) = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x000F60F0 File Offset: 0x000F42F0
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x00011875 File Offset: 0x0000FA75
		public new unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2CryptoServiceProvider.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2CryptoServiceProvider.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A72 RID: 10866
		private static readonly IntPtr NativeFieldInfoPtr_m_use40bitSalt;

		// Token: 0x04002A73 RID: 10867
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002A74 RID: 10868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A75 RID: 10869
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04002A76 RID: 10870
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A77 RID: 10871
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A78 RID: 10872
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0;

		// Token: 0x04002A79 RID: 10873
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0;
	}
}
