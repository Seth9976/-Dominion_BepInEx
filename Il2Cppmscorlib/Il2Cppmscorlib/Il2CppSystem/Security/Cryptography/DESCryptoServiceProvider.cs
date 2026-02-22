using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E2 RID: 738
	public sealed class DESCryptoServiceProvider : DES
	{
		// Token: 0x060030AF RID: 12463 RVA: 0x000F2EF4 File Offset: 0x000F10F4
		// Note: this type is marked as 'beforefieldinit'.
		static DESCryptoServiceProvider()
		{
			Il2CppClassPointerStore<DESCryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DESCryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DESCryptoServiceProvider>.NativeClassPtr);
			DESCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESCryptoServiceProvider>.NativeClassPtr, 100670962);
			DESCryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESCryptoServiceProvider>.NativeClassPtr, 100670963);
			DESCryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESCryptoServiceProvider>.NativeClassPtr, 100670964);
			DESCryptoServiceProvider.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESCryptoServiceProvider>.NativeClassPtr, 100670965);
			DESCryptoServiceProvider.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESCryptoServiceProvider>.NativeClassPtr, 100670966);
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000F2F88 File Offset: 0x000F1188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339276, RefRangeEnd = 339277, XrefRangeStart = 339266, XrefRangeEnd = 339276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DESCryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DESCryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x000F2FC4 File Offset: 0x000F11C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339277, XrefRangeEnd = 339288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESCryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000F3028 File Offset: 0x000F1228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339288, XrefRangeEnd = 339299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESCryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000F308C File Offset: 0x000F128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339299, XrefRangeEnd = 339310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESCryptoServiceProvider.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x000F30C0 File Offset: 0x000F12C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339310, XrefRangeEnd = 339315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateIV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESCryptoServiceProvider.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0001137D File Offset: 0x0000F57D
		public DESCryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029EE RID: 10734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029EF RID: 10735
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040029F0 RID: 10736
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040029F1 RID: 10737
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0;

		// Token: 0x040029F2 RID: 10738
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0;
	}
}
