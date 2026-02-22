using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000083 RID: 131
	public class GoogleBillingClient : Object
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x00016EC8 File Offset: 0x000150C8
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleBillingClient()
		{
			Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "GoogleBillingClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr);
			GoogleBillingClient.NativeFieldInfoPtr_m_BillingClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, "m_BillingClient");
			GoogleBillingClient.NativeFieldInfoPtr_m_ObfuscatedAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, "m_ObfuscatedAccountId");
			GoogleBillingClient.NativeFieldInfoPtr_m_ObfuscatedProfileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, "m_ObfuscatedProfileId");
			GoogleBillingClient.NativeFieldInfoPtr_m_GooglePurchaseUpdatedListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, "m_GooglePurchaseUpdatedListener");
			GoogleBillingClient.NativeMethodInfoPtr_GetBillingFlowParamClass_Private_Static_AndroidJavaClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663937);
			GoogleBillingClient.NativeMethodInfoPtr_GetConsumeParamsClass_Private_Static_AndroidJavaClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663938);
			GoogleBillingClient.NativeMethodInfoPtr_GetAcknowledgePurchaseParamsClass_Private_Static_AndroidJavaClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663939);
			GoogleBillingClient.NativeMethodInfoPtr_GetBillingClientClass_Private_Static_AndroidJavaClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663940);
			GoogleBillingClient.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePurchaseUpdatedListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663941);
			GoogleBillingClient.NativeMethodInfoPtr_StartConnection_Public_Virtual_Final_New_Void_IBillingClientStateListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663942);
			GoogleBillingClient.NativeMethodInfoPtr_QueryPurchase_Public_Virtual_Final_New_AndroidJavaObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663943);
			GoogleBillingClient.NativeMethodInfoPtr_QuerySkuDetailsAsync_Public_Virtual_Final_New_Void_AndroidJavaObject_SkuDetailsResponseListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663944);
			GoogleBillingClient.NativeMethodInfoPtr_LaunchBillingFlow_Public_Virtual_Final_New_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663945);
			GoogleBillingClient.NativeMethodInfoPtr_MakeBillingFlowParams_Private_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663946);
			GoogleBillingClient.NativeMethodInfoPtr_SetObfuscatedProfileIdIfNeeded_Private_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663947);
			GoogleBillingClient.NativeMethodInfoPtr_SetObfuscatedAccountIdIfNeeded_Private_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663948);
			GoogleBillingClient.NativeMethodInfoPtr_ConsumeAsync_Public_Virtual_Final_New_Void_String_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663949);
			GoogleBillingClient.NativeMethodInfoPtr_AcknowledgePurchase_Public_Virtual_Final_New_Void_String_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr, 100663950);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00017060 File Offset: 0x00015260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156811, XrefRangeEnd = 156817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaClass GetBillingFlowParamClass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_GetBillingFlowParamClass_Private_Static_AndroidJavaClass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr3) : null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00017094 File Offset: 0x00015294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156817, XrefRangeEnd = 156823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaClass GetConsumeParamsClass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_GetConsumeParamsClass_Private_Static_AndroidJavaClass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr3) : null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000170C8 File Offset: 0x000152C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156823, XrefRangeEnd = 156829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaClass GetAcknowledgePurchaseParamsClass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_GetAcknowledgePurchaseParamsClass_Private_Static_AndroidJavaClass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr3) : null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000170FC File Offset: 0x000152FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156829, XrefRangeEnd = 156835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaClass GetBillingClientClass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_GetBillingClientClass_Private_Static_AndroidJavaClass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr3) : null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00017130 File Offset: 0x00015330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156873, RefRangeEnd = 156874, XrefRangeStart = 156835, XrefRangeEnd = 156873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleBillingClient(IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleBillingClient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchaseUpdatedListener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePurchaseUpdatedListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001717C File Offset: 0x0001537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156874, XrefRangeEnd = 156886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartConnection(IBillingClientStateListener billingClientStateListener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingClientStateListener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_StartConnection_Public_Virtual_Final_New_Void_IBillingClientStateListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000171C0 File Offset: 0x000153C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156886, XrefRangeEnd = 156900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AndroidJavaObject QueryPurchase(string skuType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(skuType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_QueryPurchase_Public_Virtual_Final_New_AndroidJavaObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00017210 File Offset: 0x00015410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156900, XrefRangeEnd = 156925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void QuerySkuDetailsAsync(AndroidJavaObject skuDetailsParamsBuilder, SkuDetailsResponseListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skuDetailsParamsBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_QuerySkuDetailsAsync_Public_Virtual_Final_New_Void_AndroidJavaObject_SkuDetailsResponseListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00017264 File Offset: 0x00015464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156925, XrefRangeEnd = 156946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AndroidJavaObject LaunchBillingFlow(AndroidJavaObject sku, string oldSku, string oldPurchaseToken, int prorationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sku);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldSku);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldPurchaseToken);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prorationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_LaunchBillingFlow_Public_Virtual_Final_New_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000172E8 File Offset: 0x000154E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157015, RefRangeEnd = 157016, XrefRangeStart = 156946, XrefRangeEnd = 157015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject sku, string oldSku, string oldPurchaseToken, int prorationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sku);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldSku);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldPurchaseToken);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prorationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_MakeBillingFlowParams_Private_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001736C File Offset: 0x0001556C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157016, XrefRangeEnd = 157025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingFlowParams);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_SetObfuscatedProfileIdIfNeeded_Private_AndroidJavaObject_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000173BC File Offset: 0x000155BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157025, XrefRangeEnd = 157034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingFlowParams);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_SetObfuscatedAccountIdIfNeeded_Private_AndroidJavaObject_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001740C File Offset: 0x0001560C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157034, XrefRangeEnd = 157092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConsumeAsync(string purchaseToken, ProductDefinition product, GooglePurchase googlePurchase, Action<ProductDefinition, GooglePurchase, GoogleBillingResult, string> onConsume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onConsume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_ConsumeAsync_Public_Virtual_Final_New_Void_String_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00017488 File Offset: 0x00015688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157092, XrefRangeEnd = 157150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AcknowledgePurchase(string purchaseToken, ProductDefinition product, GooglePurchase googlePurchase, Action<ProductDefinition, GooglePurchase, GoogleBillingResult> onAcknowledge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onAcknowledge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingClient.NativeMethodInfoPtr_AcknowledgePurchase_Public_Virtual_Final_New_Void_String_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00004A01 File Offset: 0x00002C01
		public GoogleBillingClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00017504 File Offset: 0x00015704
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00004A0A File Offset: 0x00002C0A
		public unsafe AndroidJavaObject m_BillingClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingClient.NativeFieldInfoPtr_m_BillingClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingClient.NativeFieldInfoPtr_m_BillingClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00017534 File Offset: 0x00015734
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00004A29 File Offset: 0x00002C29
		public unsafe string m_ObfuscatedAccountId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingClient.NativeFieldInfoPtr_m_ObfuscatedAccountId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingClient.NativeFieldInfoPtr_m_ObfuscatedAccountId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001755C File Offset: 0x0001575C
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x00004A48 File Offset: 0x00002C48
		public unsafe string m_ObfuscatedProfileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingClient.NativeFieldInfoPtr_m_ObfuscatedProfileId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingClient.NativeFieldInfoPtr_m_ObfuscatedProfileId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00017584 File Offset: 0x00015784
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00004A67 File Offset: 0x00002C67
		public unsafe IGooglePurchaseUpdatedListener m_GooglePurchaseUpdatedListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingClient.NativeFieldInfoPtr_m_GooglePurchaseUpdatedListener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePurchaseUpdatedListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingClient.NativeFieldInfoPtr_m_GooglePurchaseUpdatedListener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_m_BillingClient;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_m_ObfuscatedAccountId;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_m_ObfuscatedProfileId;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePurchaseUpdatedListener;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_GetBillingFlowParamClass_Private_Static_AndroidJavaClass_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_GetConsumeParamsClass_Private_Static_AndroidJavaClass_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_GetAcknowledgePurchaseParamsClass_Private_Static_AndroidJavaClass_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_GetBillingClientClass_Private_Static_AndroidJavaClass_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGooglePurchaseUpdatedListener_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Public_Virtual_Final_New_Void_IBillingClientStateListener_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_QueryPurchase_Public_Virtual_Final_New_AndroidJavaObject_String_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_QuerySkuDetailsAsync_Public_Virtual_Final_New_Void_AndroidJavaObject_SkuDetailsResponseListener_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_LaunchBillingFlow_Public_Virtual_Final_New_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_MakeBillingFlowParams_Private_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_SetObfuscatedProfileIdIfNeeded_Private_AndroidJavaObject_AndroidJavaObject_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_SetObfuscatedAccountIdIfNeeded_Private_AndroidJavaObject_AndroidJavaObject_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeAsync_Public_Virtual_Final_New_Void_String_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_AcknowledgePurchase_Public_Virtual_Final_New_Void_String_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0;
	}
}
