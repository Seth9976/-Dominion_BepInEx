using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class AN_InAppAndroidClient : MonoBehaviour
{
	// Token: 0x06000184 RID: 388 RVA: 0x0001CF38 File Offset: 0x0001B138
	// Note: this type is marked as 'beforefieldinit'.
	static AN_InAppAndroidClient()
	{
		Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_InAppAndroidClient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr);
		AN_InAppAndroidClient.NativeFieldInfoPtr_ActionProductPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "ActionProductPurchased");
		AN_InAppAndroidClient.NativeFieldInfoPtr_ActionProductConsumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "ActionProductConsumed");
		AN_InAppAndroidClient.NativeFieldInfoPtr_ActionBillingSetupFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "ActionBillingSetupFinished");
		AN_InAppAndroidClient.NativeFieldInfoPtr_ActionRetrieveProducsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "ActionRetrieveProducsFinished");
		AN_InAppAndroidClient.NativeFieldInfoPtr__processedSKU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "_processedSKU");
		AN_InAppAndroidClient.NativeFieldInfoPtr__inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "_inventory");
		AN_InAppAndroidClient.NativeFieldInfoPtr__IsConnectingToServiceInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "_IsConnectingToServiceInProcess");
		AN_InAppAndroidClient.NativeFieldInfoPtr__IsProductRetrievingInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "_IsProductRetrievingInProcess");
		AN_InAppAndroidClient.NativeFieldInfoPtr__IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "_IsConnected");
		AN_InAppAndroidClient.NativeFieldInfoPtr__IsInventoryLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "_IsInventoryLoaded");
		AN_InAppAndroidClient.NativeMethodInfoPtr_add_ActionProductPurchased_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663551);
		AN_InAppAndroidClient.NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663552);
		AN_InAppAndroidClient.NativeMethodInfoPtr_add_ActionProductConsumed_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663553);
		AN_InAppAndroidClient.NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663554);
		AN_InAppAndroidClient.NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663555);
		AN_InAppAndroidClient.NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663556);
		AN_InAppAndroidClient.NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663557);
		AN_InAppAndroidClient.NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663558);
		AN_InAppAndroidClient.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663559);
		AN_InAppAndroidClient.NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663560);
		AN_InAppAndroidClient.NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_GoogleProductTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663561);
		AN_InAppAndroidClient.NativeMethodInfoPtr_RetrieveProducDetails_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663562);
		AN_InAppAndroidClient.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663563);
		AN_InAppAndroidClient.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663564);
		AN_InAppAndroidClient.NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663565);
		AN_InAppAndroidClient.NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663566);
		AN_InAppAndroidClient.NativeMethodInfoPtr_Consume_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663567);
		AN_InAppAndroidClient.NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663568);
		AN_InAppAndroidClient.NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663569);
		AN_InAppAndroidClient.NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663570);
		AN_InAppAndroidClient.NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663571);
		AN_InAppAndroidClient.NativeMethodInfoPtr_get_Inventory_Public_Virtual_Final_New_get_AndroidInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663572);
		AN_InAppAndroidClient.NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663573);
		AN_InAppAndroidClient.NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663574);
		AN_InAppAndroidClient.NativeMethodInfoPtr_get_IsConnected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663575);
		AN_InAppAndroidClient.NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663576);
		AN_InAppAndroidClient.NativeMethodInfoPtr_OnPurchaseFinishedCallback_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663577);
		AN_InAppAndroidClient.NativeMethodInfoPtr_OnConsumeFinishedCallBack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663578);
		AN_InAppAndroidClient.NativeMethodInfoPtr_OnBillingSetupFinishedCallback_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663579);
		AN_InAppAndroidClient.NativeMethodInfoPtr_OnQueryInventoryFinishedCallBack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663580);
		AN_InAppAndroidClient.NativeMethodInfoPtr_OnPurchasesRecive_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663581);
		AN_InAppAndroidClient.NativeMethodInfoPtr_OnProducttDetailsRecive_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663582);
		AN_InAppAndroidClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, 100663583);
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0001D2C4 File Offset: 0x0001B4C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160916, XrefRangeEnd = 160920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_ActionProductPurchased(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_add_ActionProductPurchased_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0001D308 File Offset: 0x0001B508
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160920, XrefRangeEnd = 160924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_ActionProductPurchased(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0001D34C File Offset: 0x0001B54C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160924, XrefRangeEnd = 160928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_ActionProductConsumed(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_add_ActionProductConsumed_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0001D390 File Offset: 0x0001B590
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160928, XrefRangeEnd = 160932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_ActionProductConsumed(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0001D3D4 File Offset: 0x0001B5D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160932, XrefRangeEnd = 160936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_ActionBillingSetupFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0001D418 File Offset: 0x0001B618
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160936, XrefRangeEnd = 160940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_ActionBillingSetupFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0001D45C File Offset: 0x0001B65C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160940, XrefRangeEnd = 160944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_ActionRetrieveProducsFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0001D4A0 File Offset: 0x0001B6A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160944, XrefRangeEnd = 160948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_ActionRetrieveProducsFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0001D4E4 File Offset: 0x0001B6E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160948, XrefRangeEnd = 160952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0001D518 File Offset: 0x0001B718
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160952, XrefRangeEnd = 160958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddProduct(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0001D55C File Offset: 0x0001B75C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 160985, RefRangeEnd = 160987, XrefRangeStart = 160958, XrefRangeEnd = 160985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddProduct(GoogleProductTemplate template)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(template);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_GoogleProductTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160987, XrefRangeEnd = 160992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RetrieveProducDetails()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_RetrieveProducDetails_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0001D5D4 File Offset: 0x0001B7D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160992, XrefRangeEnd = 161005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Purchase(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0001D618 File Offset: 0x0001B818
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161005, XrefRangeEnd = 161016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Purchase(string SKU, string DeveloperPayload)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(DeveloperPayload);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0001D66C File Offset: 0x0001B86C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161016, XrefRangeEnd = 161023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Subscribe(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0001D6B0 File Offset: 0x0001B8B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161023, XrefRangeEnd = 161028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Subscribe(string SKU, string DeveloperPayload)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(DeveloperPayload);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0001D704 File Offset: 0x0001B904
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161028, XrefRangeEnd = 161034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Consume(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_Consume_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0001D748 File Offset: 0x0001B948
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161034, XrefRangeEnd = 161049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadStore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0001D77C File Offset: 0x0001B97C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161049, XrefRangeEnd = 161050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadStore(string base64EncodedPublicKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(base64EncodedPublicKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Connect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0001D7F4 File Offset: 0x0001B9F4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 161096, RefRangeEnd = 161099, XrefRangeStart = 161050, XrefRangeEnd = 161096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Connect(string base64EncodedPublicKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(base64EncodedPublicKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600019A RID: 410 RVA: 0x0001D838 File Offset: 0x0001BA38
	public unsafe virtual AndroidInventory Inventory
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_get_Inventory_Public_Virtual_Final_New_get_AndroidInventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidInventory>(intPtr3) : null;
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x0600019B RID: 411 RVA: 0x0001D878 File Offset: 0x0001BA78
	public unsafe virtual bool IsConnectingToServiceInProcess
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x0600019C RID: 412 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
	public unsafe virtual bool IsProductRetrievingInProcess
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x0600019D RID: 413 RVA: 0x0001D8F0 File Offset: 0x0001BAF0
	public unsafe virtual bool IsConnected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_get_IsConnected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600019E RID: 414 RVA: 0x0001D92C File Offset: 0x0001BB2C
	public unsafe virtual bool IsInventoryLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0001D968 File Offset: 0x0001BB68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161099, XrefRangeEnd = 161172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPurchaseFinishedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_OnPurchaseFinishedCallback_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0001D9AC File Offset: 0x0001BBAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161172, XrefRangeEnd = 161224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConsumeFinishedCallBack(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_OnConsumeFinishedCallBack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161224, XrefRangeEnd = 161273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBillingSetupFinishedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_OnBillingSetupFinishedCallback_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0001DA34 File Offset: 0x0001BC34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161273, XrefRangeEnd = 161298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnQueryInventoryFinishedCallBack(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_OnQueryInventoryFinishedCallBack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0001DA78 File Offset: 0x0001BC78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161298, XrefRangeEnd = 161330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPurchasesRecive(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_OnPurchasesRecive_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0001DABC File Offset: 0x0001BCBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161330, XrefRangeEnd = 161368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnProducttDetailsRecive(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr_OnProducttDetailsRecive_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x0001DB00 File Offset: 0x0001BD00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161368, XrefRangeEnd = 161421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_InAppAndroidClient()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00002673 File Offset: 0x00000873
	public AN_InAppAndroidClient(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x0001DB3C File Offset: 0x0001BD3C
	// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000267C File Offset: 0x0000087C
	public unsafe Action<BillingResult> ActionProductPurchased
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr_ActionProductPurchased);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr_ActionProductPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x0001DB6C File Offset: 0x0001BD6C
	// (set) Token: 0x060001AA RID: 426 RVA: 0x0000269B File Offset: 0x0000089B
	public unsafe Action<BillingResult> ActionProductConsumed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr_ActionProductConsumed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr_ActionProductConsumed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060001AB RID: 427 RVA: 0x0001DB9C File Offset: 0x0001BD9C
	// (set) Token: 0x060001AC RID: 428 RVA: 0x000026BA File Offset: 0x000008BA
	public unsafe Action<BillingResult> ActionBillingSetupFinished
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr_ActionBillingSetupFinished);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr_ActionBillingSetupFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060001AD RID: 429 RVA: 0x0001DBCC File Offset: 0x0001BDCC
	// (set) Token: 0x060001AE RID: 430 RVA: 0x000026D9 File Offset: 0x000008D9
	public unsafe Action<BillingResult> ActionRetrieveProducsFinished
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr_ActionRetrieveProducsFinished);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr_ActionRetrieveProducsFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060001AF RID: 431 RVA: 0x0001DBFC File Offset: 0x0001BDFC
	// (set) Token: 0x060001B0 RID: 432 RVA: 0x000026F8 File Offset: 0x000008F8
	public unsafe string _processedSKU
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__processedSKU);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__processedSKU), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060001B1 RID: 433 RVA: 0x0001DC24 File Offset: 0x0001BE24
	// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002717 File Offset: 0x00000917
	public unsafe AndroidInventory _inventory
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__inventory);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidInventory>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__inventory), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001DC54 File Offset: 0x0001BE54
	// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002736 File Offset: 0x00000936
	public unsafe bool _IsConnectingToServiceInProcess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__IsConnectingToServiceInProcess);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__IsConnectingToServiceInProcess)) = value;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001DC7C File Offset: 0x0001BE7C
	// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002751 File Offset: 0x00000951
	public unsafe bool _IsProductRetrievingInProcess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__IsProductRetrievingInProcess);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__IsProductRetrievingInProcess)) = value;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060001B7 RID: 439 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
	// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000276C File Offset: 0x0000096C
	public unsafe bool _IsConnected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__IsConnected);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__IsConnected)) = value;
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060001B9 RID: 441 RVA: 0x0001DCCC File Offset: 0x0001BECC
	// (set) Token: 0x060001BA RID: 442 RVA: 0x00002787 File Offset: 0x00000987
	public unsafe bool _IsInventoryLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__IsInventoryLoaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InAppAndroidClient.NativeFieldInfoPtr__IsInventoryLoaded)) = value;
		}
	}

	// Token: 0x04000165 RID: 357
	private static readonly IntPtr NativeFieldInfoPtr_ActionProductPurchased;

	// Token: 0x04000166 RID: 358
	private static readonly IntPtr NativeFieldInfoPtr_ActionProductConsumed;

	// Token: 0x04000167 RID: 359
	private static readonly IntPtr NativeFieldInfoPtr_ActionBillingSetupFinished;

	// Token: 0x04000168 RID: 360
	private static readonly IntPtr NativeFieldInfoPtr_ActionRetrieveProducsFinished;

	// Token: 0x04000169 RID: 361
	private static readonly IntPtr NativeFieldInfoPtr__processedSKU;

	// Token: 0x0400016A RID: 362
	private static readonly IntPtr NativeFieldInfoPtr__inventory;

	// Token: 0x0400016B RID: 363
	private static readonly IntPtr NativeFieldInfoPtr__IsConnectingToServiceInProcess;

	// Token: 0x0400016C RID: 364
	private static readonly IntPtr NativeFieldInfoPtr__IsProductRetrievingInProcess;

	// Token: 0x0400016D RID: 365
	private static readonly IntPtr NativeFieldInfoPtr__IsConnected;

	// Token: 0x0400016E RID: 366
	private static readonly IntPtr NativeFieldInfoPtr__IsInventoryLoaded;

	// Token: 0x0400016F RID: 367
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProductPurchased_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x04000170 RID: 368
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x04000171 RID: 369
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProductConsumed_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x04000172 RID: 370
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x04000173 RID: 371
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x04000174 RID: 372
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x04000175 RID: 373
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x04000176 RID: 374
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x04000177 RID: 375
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000178 RID: 376
	private static readonly IntPtr NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000179 RID: 377
	private static readonly IntPtr NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_GoogleProductTemplate_0;

	// Token: 0x0400017A RID: 378
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducDetails_Public_Virtual_Final_New_Void_0;

	// Token: 0x0400017B RID: 379
	private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x0400017C RID: 380
	private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0;

	// Token: 0x0400017D RID: 381
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x0400017E RID: 382
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_String_0;

	// Token: 0x0400017F RID: 383
	private static readonly IntPtr NativeMethodInfoPtr_Consume_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000180 RID: 384
	private static readonly IntPtr NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000181 RID: 385
	private static readonly IntPtr NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000182 RID: 386
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000183 RID: 387
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000184 RID: 388
	private static readonly IntPtr NativeMethodInfoPtr_get_Inventory_Public_Virtual_Final_New_get_AndroidInventory_0;

	// Token: 0x04000185 RID: 389
	private static readonly IntPtr NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000186 RID: 390
	private static readonly IntPtr NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000187 RID: 391
	private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000188 RID: 392
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000189 RID: 393
	private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFinishedCallback_Public_Void_String_0;

	// Token: 0x0400018A RID: 394
	private static readonly IntPtr NativeMethodInfoPtr_OnConsumeFinishedCallBack_Public_Void_String_0;

	// Token: 0x0400018B RID: 395
	private static readonly IntPtr NativeMethodInfoPtr_OnBillingSetupFinishedCallback_Public_Void_String_0;

	// Token: 0x0400018C RID: 396
	private static readonly IntPtr NativeMethodInfoPtr_OnQueryInventoryFinishedCallBack_Public_Void_String_0;

	// Token: 0x0400018D RID: 397
	private static readonly IntPtr NativeMethodInfoPtr_OnPurchasesRecive_Public_Void_String_0;

	// Token: 0x0400018E RID: 398
	private static readonly IntPtr NativeMethodInfoPtr_OnProducttDetailsRecive_Public_Void_String_0;

	// Token: 0x0400018F RID: 399
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000365 RID: 869
	[ObfuscatedName("AN_InAppAndroidClient+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600343B RID: 13371 RVA: 0x000D83C0 File Offset: 0x000D65C0
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AN_InAppAndroidClient>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr);
			AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, "<>9");
			AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, "<>9__47_0");
			AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, "<>9__47_1");
			AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, "<>9__47_2");
			AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, "<>9__47_3");
			AN_InAppAndroidClient.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, 100669944);
			AN_InAppAndroidClient.__c.NativeMethodInfoPtr___ctor_b__47_0_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, 100669945);
			AN_InAppAndroidClient.__c.NativeMethodInfoPtr___ctor_b__47_1_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, 100669946);
			AN_InAppAndroidClient.__c.NativeMethodInfoPtr___ctor_b__47_2_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, 100669947);
			AN_InAppAndroidClient.__c.NativeMethodInfoPtr___ctor_b__47_3_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr, 100669948);
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x000D84B4 File Offset: 0x000D66B4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_InAppAndroidClient.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x000D84F0 File Offset: 0x000D66F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__47_0(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.__c.NativeMethodInfoPtr___ctor_b__47_0_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x000D8534 File Offset: 0x000D6734
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__47_1(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.__c.NativeMethodInfoPtr___ctor_b__47_1_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x000D8578 File Offset: 0x000D6778
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__47_2(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.__c.NativeMethodInfoPtr___ctor_b__47_2_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x000D85BC File Offset: 0x000D67BC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__47_3(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InAppAndroidClient.__c.NativeMethodInfoPtr___ctor_b__47_3_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x0001469A File Offset: 0x0001289A
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06003442 RID: 13378 RVA: 0x000D8600 File Offset: 0x000D6800
		// (set) Token: 0x06003443 RID: 13379 RVA: 0x000146A3 File Offset: 0x000128A3
		public unsafe static AN_InAppAndroidClient.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_InAppAndroidClient.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x000D8628 File Offset: 0x000D6828
		// (set) Token: 0x06003445 RID: 13381 RVA: 0x000146B5 File Offset: 0x000128B5
		public unsafe static Action<BillingResult> __9__47_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x000D8650 File Offset: 0x000D6850
		// (set) Token: 0x06003447 RID: 13383 RVA: 0x000146C7 File Offset: 0x000128C7
		public unsafe static Action<BillingResult> __9__47_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x000D8678 File Offset: 0x000D6878
		// (set) Token: 0x06003449 RID: 13385 RVA: 0x000146D9 File Offset: 0x000128D9
		public unsafe static Action<BillingResult> __9__47_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x000D86A0 File Offset: 0x000D68A0
		// (set) Token: 0x0600344B RID: 13387 RVA: 0x000146EB File Offset: 0x000128EB
		public unsafe static Action<BillingResult> __9__47_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InAppAndroidClient.__c.NativeFieldInfoPtr___9__47_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400306C RID: 12396
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400306D RID: 12397
		private static readonly IntPtr NativeFieldInfoPtr___9__47_0;

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeFieldInfoPtr___9__47_1;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeFieldInfoPtr___9__47_2;

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeFieldInfoPtr___9__47_3;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__47_0_Internal_Void_BillingResult_0;

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__47_1_Internal_Void_BillingResult_0;

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__47_2_Internal_Void_BillingResult_0;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__47_3_Internal_Void_BillingResult_0;
	}
}
