using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000016 RID: 22
	public class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00007FBC File Offset: 0x000061BC
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleAcknowledgePurchaseListener()
		{
			Il2CppClassPointerStore<GoogleAcknowledgePurchaseListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GoogleAcknowledgePurchaseListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleAcknowledgePurchaseListener>.NativeClassPtr);
			GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_OnAcknowledgePurchaseResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAcknowledgePurchaseListener>.NativeClassPtr, "m_OnAcknowledgePurchaseResponse");
			GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAcknowledgePurchaseListener>.NativeClassPtr, "m_Product");
			GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_Purchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAcknowledgePurchaseListener>.NativeClassPtr, "m_Purchase");
			GoogleAcknowledgePurchaseListener.NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAcknowledgePurchaseListener>.NativeClassPtr, 100663383);
			GoogleAcknowledgePurchaseListener.NativeMethodInfoPtr_onAcknowledgePurchaseResponse_Private_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAcknowledgePurchaseListener>.NativeClassPtr, 100663384);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00008050 File Offset: 0x00006250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150851, XrefRangeEnd = 150857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleAcknowledgePurchaseListener(ProductDefinition product, GooglePurchase purchase, Action<ProductDefinition, GooglePurchase, GoogleBillingResult> onAcknowledgePurchaseResponseAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleAcknowledgePurchaseListener>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onAcknowledgePurchaseResponseAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAcknowledgePurchaseListener.NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000080C0 File Offset: 0x000062C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150857, XrefRangeEnd = 150864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAcknowledgePurchaseListener.NativeMethodInfoPtr_onAcknowledgePurchaseResponse_Private_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000024FA File Offset: 0x000006FA
		public GoogleAcknowledgePurchaseListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00008104 File Offset: 0x00006304
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002503 File Offset: 0x00000703
		public unsafe Action<ProductDefinition, GooglePurchase, GoogleBillingResult> m_OnAcknowledgePurchaseResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_OnAcknowledgePurchaseResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition, GooglePurchase, GoogleBillingResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_OnAcknowledgePurchaseResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00008134 File Offset: 0x00006334
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002522 File Offset: 0x00000722
		public unsafe ProductDefinition m_Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00008164 File Offset: 0x00006364
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002541 File Offset: 0x00000741
		public unsafe GooglePurchase m_Purchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_Purchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePurchase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAcknowledgePurchaseListener.NativeFieldInfoPtr_m_Purchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_m_OnAcknowledgePurchaseResponse;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_m_Product;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_m_Purchase;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_onAcknowledgePurchaseResponse_Private_Void_AndroidJavaObject_0;
	}
}
