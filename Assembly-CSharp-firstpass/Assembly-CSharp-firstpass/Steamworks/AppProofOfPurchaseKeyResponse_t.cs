using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000175 RID: 373
	public sealed class AppProofOfPurchaseKeyResponse_t : ValueType
	{
		// Token: 0x060020C5 RID: 8389 RVA: 0x0009F788 File Offset: 0x0009D988
		// Note: this type is marked as 'beforefieldinit'.
		static AppProofOfPurchaseKeyResponse_t()
		{
			Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AppProofOfPurchaseKeyResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr);
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "k_iCallback");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "m_eResult");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "m_nAppID");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_cchKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "m_cchKeyLength");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_rgchKey_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "m_rgchKey_");
			AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_get_m_rgchKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, 100668329);
			AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_set_m_rgchKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, 100668330);
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x0009F844 File Offset: 0x0009DA44
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x0009F880 File Offset: 0x0009DA80
		public unsafe string m_rgchKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 206854, RefRangeEnd = 206855, XrefRangeStart = 206853, XrefRangeEnd = 206854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_get_m_rgchKey_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206855, XrefRangeEnd = 206856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_set_m_rgchKey_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0000BC4D File Offset: 0x00009E4D
		public AppProofOfPurchaseKeyResponse_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0000BC56 File Offset: 0x00009E56
		public AppProofOfPurchaseKeyResponse_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr))
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x0009F8C8 File Offset: 0x0009DAC8
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x0000BC68 File Offset: 0x00009E68
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x0009F8E4 File Offset: 0x0009DAE4
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x0000BC76 File Offset: 0x00009E76
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x0009F90C File Offset: 0x0009DB0C
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x0000BC91 File Offset: 0x00009E91
		public unsafe uint m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0009F934 File Offset: 0x0009DB34
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0000BCAC File Offset: 0x00009EAC
		public unsafe uint m_cchKeyLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_cchKeyLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_cchKeyLength)) = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0009F95C File Offset: 0x0009DB5C
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x0000BCC7 File Offset: 0x00009EC7
		public unsafe Il2CppStructArray<byte> m_rgchKey_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_rgchKey_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_rgchKey_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeFieldInfoPtr_m_cchKeyLength;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchKey_;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchKey_Public_get_String_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchKey_Public_set_Void_String_0;
	}
}
