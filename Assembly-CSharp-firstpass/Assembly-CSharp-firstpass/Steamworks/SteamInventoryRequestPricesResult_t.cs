using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001BA RID: 442
	public sealed class SteamInventoryRequestPricesResult_t : ValueType
	{
		// Token: 0x06002282 RID: 8834 RVA: 0x000A2F88 File Offset: 0x000A1188
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryRequestPricesResult_t()
		{
			Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryRequestPricesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr);
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "m_result");
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_rgchCurrency_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "m_rgchCurrency_");
			SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_get_m_rgchCurrency_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, 100668343);
			SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_set_m_rgchCurrency_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, 100668344);
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x000A301C File Offset: 0x000A121C
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x000A3058 File Offset: 0x000A1258
		public unsafe string m_rgchCurrency
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_get_m_rgchCurrency_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206864, XrefRangeEnd = 206865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_set_m_rgchCurrency_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x0000CDD6 File Offset: 0x0000AFD6
		public SteamInventoryRequestPricesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0000CDDF File Offset: 0x0000AFDF
		public SteamInventoryRequestPricesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x000A30A0 File Offset: 0x000A12A0
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x0000CDF1 File Offset: 0x0000AFF1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x000A30BC File Offset: 0x000A12BC
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x0000CDFF File Offset: 0x0000AFFF
		public unsafe EResult m_result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_result)) = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x000A30E4 File Offset: 0x000A12E4
		// (set) Token: 0x0600228C RID: 8844 RVA: 0x0000CE1A File Offset: 0x0000B01A
		public unsafe Il2CppStructArray<byte> m_rgchCurrency_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_rgchCurrency_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_rgchCurrency_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchCurrency_;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchCurrency_Public_get_String_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchCurrency_Public_set_Void_String_0;
	}
}
