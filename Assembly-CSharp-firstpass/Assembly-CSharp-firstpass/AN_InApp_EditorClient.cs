using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000015 RID: 21
public class AN_InApp_EditorClient : MonoBehaviour
{
	// Token: 0x060001BB RID: 443 RVA: 0x0001DCF4 File Offset: 0x0001BEF4
	// Note: this type is marked as 'beforefieldinit'.
	static AN_InApp_EditorClient()
	{
		Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_InApp_EditorClient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr);
		AN_InApp_EditorClient.NativeFieldInfoPtr_ActionProductPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "ActionProductPurchased");
		AN_InApp_EditorClient.NativeFieldInfoPtr_ActionProductConsumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "ActionProductConsumed");
		AN_InApp_EditorClient.NativeFieldInfoPtr_ActionBillingSetupFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "ActionBillingSetupFinished");
		AN_InApp_EditorClient.NativeFieldInfoPtr_ActionRetrieveProducsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "ActionRetrieveProducsFinished");
		AN_InApp_EditorClient.NativeFieldInfoPtr__processedSKU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "_processedSKU");
		AN_InApp_EditorClient.NativeFieldInfoPtr__inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "_inventory");
		AN_InApp_EditorClient.NativeFieldInfoPtr__IsConnectingToServiceInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "_IsConnectingToServiceInProcess");
		AN_InApp_EditorClient.NativeFieldInfoPtr__IsProductRetrievingInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "_IsProductRetrievingInProcess");
		AN_InApp_EditorClient.NativeFieldInfoPtr__IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "_IsConnected");
		AN_InApp_EditorClient.NativeFieldInfoPtr__IsInventoryLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "_IsInventoryLoaded");
		AN_InApp_EditorClient.NativeFieldInfoPtr__RequestsSuccessRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "_RequestsSuccessRate");
		AN_InApp_EditorClient.NativeFieldInfoPtr__CurrentSKU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "_CurrentSKU");
		AN_InApp_EditorClient.NativeMethodInfoPtr_add_ActionProductPurchased_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663584);
		AN_InApp_EditorClient.NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663585);
		AN_InApp_EditorClient.NativeMethodInfoPtr_add_ActionProductConsumed_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663586);
		AN_InApp_EditorClient.NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663587);
		AN_InApp_EditorClient.NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663588);
		AN_InApp_EditorClient.NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663589);
		AN_InApp_EditorClient.NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663590);
		AN_InApp_EditorClient.NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663591);
		AN_InApp_EditorClient.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663592);
		AN_InApp_EditorClient.NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663593);
		AN_InApp_EditorClient.NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_GoogleProductTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663594);
		AN_InApp_EditorClient.NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663595);
		AN_InApp_EditorClient.NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663596);
		AN_InApp_EditorClient.NativeMethodInfoPtr_GenerateConnectionResult_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663597);
		AN_InApp_EditorClient.NativeMethodInfoPtr_RetrieveProducDetails_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663598);
		AN_InApp_EditorClient.NativeMethodInfoPtr_OnQueryInventoryFinishedCallBack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663599);
		AN_InApp_EditorClient.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663600);
		AN_InApp_EditorClient.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663601);
		AN_InApp_EditorClient.NativeMethodInfoPtr_OnPurchaseComplete_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663602);
		AN_InApp_EditorClient.NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663603);
		AN_InApp_EditorClient.NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663604);
		AN_InApp_EditorClient.NativeMethodInfoPtr_Consume_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663605);
		AN_InApp_EditorClient.NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663606);
		AN_InApp_EditorClient.NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663607);
		AN_InApp_EditorClient.NativeMethodInfoPtr_get_Inventory_Public_Virtual_Final_New_get_AndroidInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663608);
		AN_InApp_EditorClient.NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663609);
		AN_InApp_EditorClient.NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663610);
		AN_InApp_EditorClient.NativeMethodInfoPtr_get_IsConnected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663611);
		AN_InApp_EditorClient.NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663612);
		AN_InApp_EditorClient.NativeMethodInfoPtr_OnPurchaseFinishedCallback_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663613);
		AN_InApp_EditorClient.NativeMethodInfoPtr_OnConsumeFinishedCallBack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663614);
		AN_InApp_EditorClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, 100663615);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0001E094 File Offset: 0x0001C294
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161421, XrefRangeEnd = 161425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_ActionProductPurchased(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_add_ActionProductPurchased_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BD RID: 445 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161425, XrefRangeEnd = 161429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_ActionProductPurchased(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BE RID: 446 RVA: 0x0001E11C File Offset: 0x0001C31C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161429, XrefRangeEnd = 161433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_ActionProductConsumed(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_add_ActionProductConsumed_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0001E160 File Offset: 0x0001C360
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161433, XrefRangeEnd = 161437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_ActionProductConsumed(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161437, XrefRangeEnd = 161441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_ActionBillingSetupFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x0001E1E8 File Offset: 0x0001C3E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161441, XrefRangeEnd = 161445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_ActionBillingSetupFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0001E22C File Offset: 0x0001C42C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161445, XrefRangeEnd = 161449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_ActionRetrieveProducsFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0001E270 File Offset: 0x0001C470
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161449, XrefRangeEnd = 161453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_ActionRetrieveProducsFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0001E2B4 File Offset: 0x0001C4B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161453, XrefRangeEnd = 161461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161461, XrefRangeEnd = 161467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddProduct(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0001E32C File Offset: 0x0001C52C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 161494, RefRangeEnd = 161496, XrefRangeStart = 161467, XrefRangeEnd = 161494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddProduct(GoogleProductTemplate template)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(template);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_GoogleProductTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0001E370 File Offset: 0x0001C570
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161496, XrefRangeEnd = 161523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Connect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0001E3A4 File Offset: 0x0001C5A4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 161546, RefRangeEnd = 161549, XrefRangeStart = 161523, XrefRangeEnd = 161546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Connect(string base64EncodedPublicKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(base64EncodedPublicKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0001E3E8 File Offset: 0x0001C5E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161549, XrefRangeEnd = 161579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateConnectionResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_GenerateConnectionResult_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x0001E41C File Offset: 0x0001C61C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161579, XrefRangeEnd = 161583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RetrieveProducDetails()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_RetrieveProducDetails_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0001E450 File Offset: 0x0001C650
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161583, XrefRangeEnd = 161593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnQueryInventoryFinishedCallBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_OnQueryInventoryFinishedCallBack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0001E484 File Offset: 0x0001C684
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161593, XrefRangeEnd = 161611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Purchase(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161611, XrefRangeEnd = 161628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0001E51C File Offset: 0x0001C71C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161628, XrefRangeEnd = 161648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPurchaseComplete(bool IsSucceeded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref IsSucceeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_OnPurchaseComplete_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0001E55C File Offset: 0x0001C75C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161648, XrefRangeEnd = 161655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Subscribe(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161655, XrefRangeEnd = 161660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0001E5F4 File Offset: 0x0001C7F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161660, XrefRangeEnd = 161674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Consume(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_Consume_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0001E638 File Offset: 0x0001C838
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadStore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0001E66C File Offset: 0x0001C86C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161674, XrefRangeEnd = 161675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadStore(string base64EncodedPublicKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(base64EncodedPublicKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060001D4 RID: 468 RVA: 0x0001E6B0 File Offset: 0x0001C8B0
	public unsafe virtual AndroidInventory Inventory
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_get_Inventory_Public_Virtual_Final_New_get_AndroidInventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidInventory>(intPtr3) : null;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060001D5 RID: 469 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
	public unsafe virtual bool IsConnectingToServiceInProcess
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001E72C File Offset: 0x0001C92C
	public unsafe virtual bool IsProductRetrievingInProcess
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001E768 File Offset: 0x0001C968
	public unsafe virtual bool IsConnected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_get_IsConnected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060001D8 RID: 472 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
	public unsafe virtual bool IsInventoryLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161675, XrefRangeEnd = 161748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPurchaseFinishedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_OnPurchaseFinishedCallback_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0001E824 File Offset: 0x0001CA24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161748, XrefRangeEnd = 161800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConsumeFinishedCallBack(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr_OnConsumeFinishedCallBack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0001E868 File Offset: 0x0001CA68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161800, XrefRangeEnd = 161855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_InApp_EditorClient()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001DC RID: 476 RVA: 0x000027A2 File Offset: 0x000009A2
	public AN_InApp_EditorClient(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060001DD RID: 477 RVA: 0x0001E8A4 File Offset: 0x0001CAA4
	// (set) Token: 0x060001DE RID: 478 RVA: 0x000027AB File Offset: 0x000009AB
	public unsafe Action<BillingResult> ActionProductPurchased
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr_ActionProductPurchased);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr_ActionProductPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060001DF RID: 479 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
	// (set) Token: 0x060001E0 RID: 480 RVA: 0x000027CA File Offset: 0x000009CA
	public unsafe Action<BillingResult> ActionProductConsumed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr_ActionProductConsumed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr_ActionProductConsumed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060001E1 RID: 481 RVA: 0x0001E904 File Offset: 0x0001CB04
	// (set) Token: 0x060001E2 RID: 482 RVA: 0x000027E9 File Offset: 0x000009E9
	public unsafe Action<BillingResult> ActionBillingSetupFinished
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr_ActionBillingSetupFinished);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr_ActionBillingSetupFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060001E3 RID: 483 RVA: 0x0001E934 File Offset: 0x0001CB34
	// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002808 File Offset: 0x00000A08
	public unsafe Action<BillingResult> ActionRetrieveProducsFinished
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr_ActionRetrieveProducsFinished);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr_ActionRetrieveProducsFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001E964 File Offset: 0x0001CB64
	// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002827 File Offset: 0x00000A27
	public unsafe string _processedSKU
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__processedSKU);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__processedSKU), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001E98C File Offset: 0x0001CB8C
	// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002846 File Offset: 0x00000A46
	public unsafe AndroidInventory _inventory
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__inventory);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidInventory>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__inventory), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060001E9 RID: 489 RVA: 0x0001E9BC File Offset: 0x0001CBBC
	// (set) Token: 0x060001EA RID: 490 RVA: 0x00002865 File Offset: 0x00000A65
	public unsafe bool _IsConnectingToServiceInProcess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__IsConnectingToServiceInProcess);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__IsConnectingToServiceInProcess)) = value;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060001EB RID: 491 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
	// (set) Token: 0x060001EC RID: 492 RVA: 0x00002880 File Offset: 0x00000A80
	public unsafe bool _IsProductRetrievingInProcess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__IsProductRetrievingInProcess);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__IsProductRetrievingInProcess)) = value;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060001ED RID: 493 RVA: 0x0001EA0C File Offset: 0x0001CC0C
	// (set) Token: 0x060001EE RID: 494 RVA: 0x0000289B File Offset: 0x00000A9B
	public unsafe bool _IsConnected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__IsConnected);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__IsConnected)) = value;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060001EF RID: 495 RVA: 0x0001EA34 File Offset: 0x0001CC34
	// (set) Token: 0x060001F0 RID: 496 RVA: 0x000028B6 File Offset: 0x00000AB6
	public unsafe bool _IsInventoryLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__IsInventoryLoaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__IsInventoryLoaded)) = value;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060001F1 RID: 497 RVA: 0x0001EA5C File Offset: 0x0001CC5C
	// (set) Token: 0x060001F2 RID: 498 RVA: 0x000028D1 File Offset: 0x00000AD1
	public unsafe float _RequestsSuccessRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__RequestsSuccessRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__RequestsSuccessRate)) = value;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x0001EA84 File Offset: 0x0001CC84
	// (set) Token: 0x060001F4 RID: 500 RVA: 0x000028EC File Offset: 0x00000AEC
	public unsafe string _CurrentSKU
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__CurrentSKU);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InApp_EditorClient.NativeFieldInfoPtr__CurrentSKU), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000190 RID: 400
	private static readonly IntPtr NativeFieldInfoPtr_ActionProductPurchased;

	// Token: 0x04000191 RID: 401
	private static readonly IntPtr NativeFieldInfoPtr_ActionProductConsumed;

	// Token: 0x04000192 RID: 402
	private static readonly IntPtr NativeFieldInfoPtr_ActionBillingSetupFinished;

	// Token: 0x04000193 RID: 403
	private static readonly IntPtr NativeFieldInfoPtr_ActionRetrieveProducsFinished;

	// Token: 0x04000194 RID: 404
	private static readonly IntPtr NativeFieldInfoPtr__processedSKU;

	// Token: 0x04000195 RID: 405
	private static readonly IntPtr NativeFieldInfoPtr__inventory;

	// Token: 0x04000196 RID: 406
	private static readonly IntPtr NativeFieldInfoPtr__IsConnectingToServiceInProcess;

	// Token: 0x04000197 RID: 407
	private static readonly IntPtr NativeFieldInfoPtr__IsProductRetrievingInProcess;

	// Token: 0x04000198 RID: 408
	private static readonly IntPtr NativeFieldInfoPtr__IsConnected;

	// Token: 0x04000199 RID: 409
	private static readonly IntPtr NativeFieldInfoPtr__IsInventoryLoaded;

	// Token: 0x0400019A RID: 410
	private static readonly IntPtr NativeFieldInfoPtr__RequestsSuccessRate;

	// Token: 0x0400019B RID: 411
	private static readonly IntPtr NativeFieldInfoPtr__CurrentSKU;

	// Token: 0x0400019C RID: 412
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProductPurchased_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x0400019D RID: 413
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x0400019E RID: 414
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProductConsumed_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x0400019F RID: 415
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001A0 RID: 416
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001A1 RID: 417
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001A2 RID: 418
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Virtual_Final_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001A3 RID: 419
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Virtual_Final_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001A4 RID: 420
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040001A5 RID: 421
	private static readonly IntPtr NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x040001A6 RID: 422
	private static readonly IntPtr NativeMethodInfoPtr_AddProduct_Public_Virtual_Final_New_Void_GoogleProductTemplate_0;

	// Token: 0x040001A7 RID: 423
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_0;

	// Token: 0x040001A8 RID: 424
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x040001A9 RID: 425
	private static readonly IntPtr NativeMethodInfoPtr_GenerateConnectionResult_Private_Void_0;

	// Token: 0x040001AA RID: 426
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducDetails_Public_Virtual_Final_New_Void_0;

	// Token: 0x040001AB RID: 427
	private static readonly IntPtr NativeMethodInfoPtr_OnQueryInventoryFinishedCallBack_Public_Void_0;

	// Token: 0x040001AC RID: 428
	private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x040001AD RID: 429
	private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0;

	// Token: 0x040001AE RID: 430
	private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseComplete_Private_Void_Boolean_0;

	// Token: 0x040001AF RID: 431
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x040001B0 RID: 432
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_Void_String_String_0;

	// Token: 0x040001B1 RID: 433
	private static readonly IntPtr NativeMethodInfoPtr_Consume_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x040001B2 RID: 434
	private static readonly IntPtr NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_0;

	// Token: 0x040001B3 RID: 435
	private static readonly IntPtr NativeMethodInfoPtr_LoadStore_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x040001B4 RID: 436
	private static readonly IntPtr NativeMethodInfoPtr_get_Inventory_Public_Virtual_Final_New_get_AndroidInventory_0;

	// Token: 0x040001B5 RID: 437
	private static readonly IntPtr NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x040001B6 RID: 438
	private static readonly IntPtr NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x040001B7 RID: 439
	private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x040001B8 RID: 440
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x040001B9 RID: 441
	private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFinishedCallback_Public_Void_String_0;

	// Token: 0x040001BA RID: 442
	private static readonly IntPtr NativeMethodInfoPtr_OnConsumeFinishedCallBack_Public_Void_String_0;

	// Token: 0x040001BB RID: 443
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000366 RID: 870
	[ObfuscatedName("AN_InApp_EditorClient+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600344C RID: 13388 RVA: 0x000D86C8 File Offset: 0x000D68C8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AN_InApp_EditorClient>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr);
			AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, "<>9");
			AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, "<>9__48_0");
			AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, "<>9__48_1");
			AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, "<>9__48_2");
			AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, "<>9__48_3");
			AN_InApp_EditorClient.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, 100669950);
			AN_InApp_EditorClient.__c.NativeMethodInfoPtr___ctor_b__48_0_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, 100669951);
			AN_InApp_EditorClient.__c.NativeMethodInfoPtr___ctor_b__48_1_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, 100669952);
			AN_InApp_EditorClient.__c.NativeMethodInfoPtr___ctor_b__48_2_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, 100669953);
			AN_InApp_EditorClient.__c.NativeMethodInfoPtr___ctor_b__48_3_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr, 100669954);
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x000D87BC File Offset: 0x000D69BC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_InApp_EditorClient.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x000D87F8 File Offset: 0x000D69F8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__48_0(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.__c.NativeMethodInfoPtr___ctor_b__48_0_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x000D883C File Offset: 0x000D6A3C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__48_1(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.__c.NativeMethodInfoPtr___ctor_b__48_1_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x000D8880 File Offset: 0x000D6A80
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__48_2(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.__c.NativeMethodInfoPtr___ctor_b__48_2_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x000D88C4 File Offset: 0x000D6AC4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__48_3(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InApp_EditorClient.__c.NativeMethodInfoPtr___ctor_b__48_3_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x000146FD File Offset: 0x000128FD
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x000D8908 File Offset: 0x000D6B08
		// (set) Token: 0x06003454 RID: 13396 RVA: 0x00014706 File Offset: 0x00012906
		public unsafe static AN_InApp_EditorClient.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_InApp_EditorClient.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x000D8930 File Offset: 0x000D6B30
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x00014718 File Offset: 0x00012918
		public unsafe static Action<BillingResult> __9__48_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x000D8958 File Offset: 0x000D6B58
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x0001472A File Offset: 0x0001292A
		public unsafe static Action<BillingResult> __9__48_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x000D8980 File Offset: 0x000D6B80
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x0001473C File Offset: 0x0001293C
		public unsafe static Action<BillingResult> __9__48_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x000D89A8 File Offset: 0x000D6BA8
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x0001474E File Offset: 0x0001294E
		public unsafe static Action<BillingResult> __9__48_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_InApp_EditorClient.__c.NativeFieldInfoPtr___9__48_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeFieldInfoPtr___9__48_1;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeFieldInfoPtr___9__48_2;

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeFieldInfoPtr___9__48_3;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__48_0_Internal_Void_BillingResult_0;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__48_1_Internal_Void_BillingResult_0;

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__48_2_Internal_Void_BillingResult_0;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__48_3_Internal_Void_BillingResult_0;
	}
}
