using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000311 RID: 785
	public sealed class TripleDESCryptoServiceProvider : TripleDES
	{
		// Token: 0x06003309 RID: 13065 RVA: 0x000FB708 File Offset: 0x000F9908
		// Note: this type is marked as 'beforefieldinit'.
		static TripleDESCryptoServiceProvider()
		{
			Il2CppClassPointerStore<TripleDESCryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "TripleDESCryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TripleDESCryptoServiceProvider>.NativeClassPtr);
			TripleDESCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESCryptoServiceProvider>.NativeClassPtr, 100671242);
			TripleDESCryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESCryptoServiceProvider>.NativeClassPtr, 100671243);
			TripleDESCryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESCryptoServiceProvider>.NativeClassPtr, 100671244);
			TripleDESCryptoServiceProvider.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESCryptoServiceProvider>.NativeClassPtr, 100671245);
			TripleDESCryptoServiceProvider.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESCryptoServiceProvider>.NativeClassPtr, 100671246);
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000FB79C File Offset: 0x000F999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341200, XrefRangeEnd = 341210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TripleDESCryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TripleDESCryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000FB7D8 File Offset: 0x000F99D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341210, XrefRangeEnd = 341218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESCryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000FB83C File Offset: 0x000F9A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341218, XrefRangeEnd = 341226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESCryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000FB8A0 File Offset: 0x000F9AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341226, XrefRangeEnd = 341234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESCryptoServiceProvider.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x000FB8D4 File Offset: 0x000F9AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341234, XrefRangeEnd = 341239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateIV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESCryptoServiceProvider.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0001232D File Offset: 0x0001052D
		public TripleDESCryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B77 RID: 11127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B78 RID: 11128
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B79 RID: 11129
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B7A RID: 11130
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0;

		// Token: 0x04002B7B RID: 11131
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0;
	}
}
