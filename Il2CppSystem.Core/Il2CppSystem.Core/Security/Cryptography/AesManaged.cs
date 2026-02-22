using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000003 RID: 3
	public sealed class AesManaged : Aes
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002EC0 File Offset: 0x000010C0
		// Note: this type is marked as 'beforefieldinit'.
		static AesManaged()
		{
			Il2CppClassPointerStore<AesManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Security.Cryptography", "AesManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AesManaged>.NativeClassPtr);
			AesManaged.NativeFieldInfoPtr_m_rijndael = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, "m_rijndael");
			AesManaged.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663298);
			AesManaged.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663299);
			AesManaged.NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663300);
			AesManaged.NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663301);
			AesManaged.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663302);
			AesManaged.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663303);
			AesManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663304);
			AesManaged.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663305);
			AesManaged.NativeMethodInfoPtr_get_Mode_Public_Virtual_get_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663306);
			AesManaged.NativeMethodInfoPtr_set_Mode_Public_Virtual_set_Void_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663307);
			AesManaged.NativeMethodInfoPtr_get_Padding_Public_Virtual_get_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663308);
			AesManaged.NativeMethodInfoPtr_set_Padding_Public_Virtual_set_Void_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663309);
			AesManaged.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663310);
			AesManaged.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663311);
			AesManaged.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663312);
			AesManaged.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663313);
			AesManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663314);
			AesManaged.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663315);
			AesManaged.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesManaged>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00003080 File Offset: 0x00001280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57698, XrefRangeEnd = 57715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AesManaged()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AesManaged>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000030BC File Offset: 0x000012BC
		public unsafe override int FeedbackSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57715, XrefRangeEnd = 57716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000030F8 File Offset: 0x000012F8
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00003138 File Offset: 0x00001338
		public unsafe override Il2CppStructArray<byte> IV
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57716, XrefRangeEnd = 57717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57717, XrefRangeEnd = 57718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000317C File Offset: 0x0000137C
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000031BC File Offset: 0x000013BC
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57718, XrefRangeEnd = 57719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57719, XrefRangeEnd = 57720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00003200 File Offset: 0x00001400
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000323C File Offset: 0x0000143C
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57720, XrefRangeEnd = 57721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57721, XrefRangeEnd = 57722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000327C File Offset: 0x0000147C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000032B8 File Offset: 0x000014B8
		public unsafe override CipherMode Mode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57722, XrefRangeEnd = 57723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_get_Mode_Public_Virtual_get_CipherMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57723, XrefRangeEnd = 57731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_set_Mode_Public_Virtual_set_Void_CipherMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000032F8 File Offset: 0x000014F8
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00003334 File Offset: 0x00001534
		public unsafe override PaddingMode Padding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57731, XrefRangeEnd = 57732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_get_Padding_Public_Virtual_get_PaddingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57732, XrefRangeEnd = 57733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_set_Padding_Public_Virtual_set_Void_PaddingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003374 File Offset: 0x00001574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57733, XrefRangeEnd = 57734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICryptoTransform CreateDecryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000033B4 File Offset: 0x000015B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57734, XrefRangeEnd = 57758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003418 File Offset: 0x00001618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57758, XrefRangeEnd = 57759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICryptoTransform CreateEncryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003458 File Offset: 0x00001658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57759, XrefRangeEnd = 57783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000034BC File Offset: 0x000016BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57783, XrefRangeEnd = 57791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000034FC File Offset: 0x000016FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57791, XrefRangeEnd = 57792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateIV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003530 File Offset: 0x00001730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57792, XrefRangeEnd = 57793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesManaged.NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002092 File Offset: 0x00000292
		public AesManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00003564 File Offset: 0x00001764
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000209B File Offset: 0x0000029B
		public unsafe RijndaelManaged m_rijndael
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesManaged.NativeFieldInfoPtr_m_rijndael);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RijndaelManaged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesManaged.NativeFieldInfoPtr_m_rijndael), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_rijndael;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_get_Int32_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_Virtual_get_CipherMode_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_Virtual_set_Void_CipherMode_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_Padding_Public_Virtual_get_PaddingMode_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_set_Padding_Public_Virtual_set_Void_PaddingMode_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIV_Public_Virtual_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Public_Virtual_Void_0;
	}
}
