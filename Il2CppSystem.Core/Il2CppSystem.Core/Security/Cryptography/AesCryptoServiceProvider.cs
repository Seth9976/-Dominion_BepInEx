using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000004 RID: 4
	public sealed class AesCryptoServiceProvider : Aes
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00003594 File Offset: 0x00001794
		// Note: this type is marked as 'beforefieldinit'.
		static AesCryptoServiceProvider()
		{
			Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Security.Cryptography", "AesCryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr);
			AesCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663317);
			AesCryptoServiceProvider.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663318);
			AesCryptoServiceProvider.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663319);
			AesCryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663320);
			AesCryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663321);
			AesCryptoServiceProvider.NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663322);
			AesCryptoServiceProvider.NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663323);
			AesCryptoServiceProvider.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663324);
			AesCryptoServiceProvider.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663325);
			AesCryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663326);
			AesCryptoServiceProvider.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663327);
			AesCryptoServiceProvider.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663328);
			AesCryptoServiceProvider.NativeMethodInfoPtr_get_Mode_Public_Virtual_get_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663329);
			AesCryptoServiceProvider.NativeMethodInfoPtr_set_Mode_Public_Virtual_set_Void_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663330);
			AesCryptoServiceProvider.NativeMethodInfoPtr_get_Padding_Public_Virtual_get_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663331);
			AesCryptoServiceProvider.NativeMethodInfoPtr_set_Padding_Public_Virtual_set_Void_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663332);
			AesCryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663333);
			AesCryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663334);
			AesCryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr, 100663335);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003740 File Offset: 0x00001940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57793, XrefRangeEnd = 57797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AesCryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AesCryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000377C File Offset: 0x0000197C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57797, XrefRangeEnd = 57798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateIV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000037B0 File Offset: 0x000019B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57798, XrefRangeEnd = 57799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000037E4 File Offset: 0x000019E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57799, XrefRangeEnd = 57803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICryptoTransform CreateDecryptor(Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003848 File Offset: 0x00001A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57803, XrefRangeEnd = 57807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICryptoTransform CreateEncryptor(Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000038AC File Offset: 0x00001AAC
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000038EC File Offset: 0x00001AEC
		public unsafe override Il2CppStructArray<byte> IV
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57807, XrefRangeEnd = 57808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57808, XrefRangeEnd = 57809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003930 File Offset: 0x00001B30
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00003970 File Offset: 0x00001B70
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57809, XrefRangeEnd = 57810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57810, XrefRangeEnd = 57811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000039B4 File Offset: 0x00001BB4
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000039F0 File Offset: 0x00001BF0
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57811, XrefRangeEnd = 57812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003A30 File Offset: 0x00001C30
		public unsafe override int FeedbackSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003A6C File Offset: 0x00001C6C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public unsafe override CipherMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_get_Mode_Public_Virtual_get_CipherMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57812, XrefRangeEnd = 57819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_set_Mode_Public_Virtual_set_Void_CipherMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003AE8 File Offset: 0x00001CE8
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00003B24 File Offset: 0x00001D24
		public unsafe override PaddingMode Padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_get_Padding_Public_Virtual_get_PaddingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57819, XrefRangeEnd = 57820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_set_Padding_Public_Virtual_set_Void_PaddingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003B64 File Offset: 0x00001D64
		[CallerCount(0)]
		public unsafe override ICryptoTransform CreateDecryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003BA4 File Offset: 0x00001DA4
		[CallerCount(0)]
		public unsafe override ICryptoTransform CreateEncryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57820, XrefRangeEnd = 57821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesCryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020BA File Offset: 0x000002BA
		public AesCryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_get_Int32_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_Virtual_get_CipherMode_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_Virtual_set_Void_CipherMode_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_Padding_Public_Virtual_get_PaddingMode_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_set_Padding_Public_Virtual_set_Void_PaddingMode_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
