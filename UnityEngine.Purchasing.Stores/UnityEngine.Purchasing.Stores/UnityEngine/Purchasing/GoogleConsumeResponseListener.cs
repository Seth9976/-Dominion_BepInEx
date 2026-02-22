using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000017 RID: 23
	public class GoogleConsumeResponseListener : AndroidJavaProxy
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x00008194 File Offset: 0x00006394
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleConsumeResponseListener()
		{
			Il2CppClassPointerStore<GoogleConsumeResponseListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GoogleConsumeResponseListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleConsumeResponseListener>.NativeClassPtr);
			GoogleConsumeResponseListener.NativeFieldInfoPtr_m_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleConsumeResponseListener>.NativeClassPtr, "m_Product");
			GoogleConsumeResponseListener.NativeFieldInfoPtr_m_Purchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleConsumeResponseListener>.NativeClassPtr, "m_Purchase");
			GoogleConsumeResponseListener.NativeFieldInfoPtr_m_OnConsumeResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleConsumeResponseListener>.NativeClassPtr, "m_OnConsumeResponse");
			GoogleConsumeResponseListener.NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleConsumeResponseListener>.NativeClassPtr, 100663385);
			GoogleConsumeResponseListener.NativeMethodInfoPtr_onConsumeResponse_Private_Void_AndroidJavaObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleConsumeResponseListener>.NativeClassPtr, 100663386);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00008228 File Offset: 0x00006428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150864, XrefRangeEnd = 150870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleConsumeResponseListener(ProductDefinition product, GooglePurchase purchase, Action<ProductDefinition, GooglePurchase, GoogleBillingResult, string> onConsumeResponseAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleConsumeResponseListener>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onConsumeResponseAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleConsumeResponseListener.NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008298 File Offset: 0x00006498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150870, XrefRangeEnd = 150877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleConsumeResponseListener.NativeMethodInfoPtr_onConsumeResponse_Private_Void_AndroidJavaObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002560 File Offset: 0x00000760
		public GoogleConsumeResponseListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000082EC File Offset: 0x000064EC
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002569 File Offset: 0x00000769
		public unsafe ProductDefinition m_Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleConsumeResponseListener.NativeFieldInfoPtr_m_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleConsumeResponseListener.NativeFieldInfoPtr_m_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000831C File Offset: 0x0000651C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002588 File Offset: 0x00000788
		public unsafe GooglePurchase m_Purchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleConsumeResponseListener.NativeFieldInfoPtr_m_Purchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePurchase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleConsumeResponseListener.NativeFieldInfoPtr_m_Purchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000834C File Offset: 0x0000654C
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000025A7 File Offset: 0x000007A7
		public unsafe Action<ProductDefinition, GooglePurchase, GoogleBillingResult, string> m_OnConsumeResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleConsumeResponseListener.NativeFieldInfoPtr_m_OnConsumeResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition, GooglePurchase, GoogleBillingResult, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleConsumeResponseListener.NativeFieldInfoPtr_m_OnConsumeResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_m_Product;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_m_Purchase;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_m_OnConsumeResponse;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_onConsumeResponse_Private_Void_AndroidJavaObject_String_0;
	}
}
