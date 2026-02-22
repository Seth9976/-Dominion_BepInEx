using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000019 RID: 25
public class AN_InAppClient : Il2CppObjectBase
{
	// Token: 0x0600021E RID: 542 RVA: 0x0001EEBC File Offset: 0x0001D0BC
	// Note: this type is marked as 'beforefieldinit'.
	static AN_InAppClient()
	{
		Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_InAppClient");
		AN_InAppClient.NativeMethodInfoPtr_add_ActionProductPurchased_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663617);
		AN_InAppClient.NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663618);
		AN_InAppClient.NativeMethodInfoPtr_add_ActionProductConsumed_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663619);
		AN_InAppClient.NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663620);
		AN_InAppClient.NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663621);
		AN_InAppClient.NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663622);
		AN_InAppClient.NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663623);
		AN_InAppClient.NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663624);
		AN_InAppClient.NativeMethodInfoPtr_AddProduct_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663625);
		AN_InAppClient.NativeMethodInfoPtr_AddProduct_Public_Abstract_Virtual_New_Void_GoogleProductTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663626);
		AN_InAppClient.NativeMethodInfoPtr_RetrieveProducDetails_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663627);
		AN_InAppClient.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663628);
		AN_InAppClient.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663629);
		AN_InAppClient.NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663630);
		AN_InAppClient.NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663631);
		AN_InAppClient.NativeMethodInfoPtr_Consume_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663632);
		AN_InAppClient.NativeMethodInfoPtr_Connect_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663633);
		AN_InAppClient.NativeMethodInfoPtr_Connect_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663634);
		AN_InAppClient.NativeMethodInfoPtr_LoadStore_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663635);
		AN_InAppClient.NativeMethodInfoPtr_LoadStore_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663636);
		AN_InAppClient.NativeMethodInfoPtr_get_Inventory_Public_Abstract_Virtual_New_get_AndroidInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663637);
		AN_InAppClient.NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663638);
		AN_InAppClient.NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663639);
		AN_InAppClient.NativeMethodInfoPtr_get_IsConnected_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663640);
		AN_InAppClient.NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InAppClient>.NativeClassPtr, 100663641);
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0001F0D8 File Offset: 0x0001D2D8
	[CallerCount(0)]
	public unsafe virtual void add_ActionProductPurchased(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_add_ActionProductPurchased_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0001F128 File Offset: 0x0001D328
	[CallerCount(0)]
	public unsafe virtual void remove_ActionProductPurchased(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0001F178 File Offset: 0x0001D378
	[CallerCount(0)]
	public unsafe virtual void add_ActionProductConsumed(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_add_ActionProductConsumed_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0001F1C8 File Offset: 0x0001D3C8
	[CallerCount(0)]
	public unsafe virtual void remove_ActionProductConsumed(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0001F218 File Offset: 0x0001D418
	[CallerCount(0)]
	public unsafe virtual void add_ActionBillingSetupFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0001F268 File Offset: 0x0001D468
	[CallerCount(0)]
	public unsafe virtual void remove_ActionBillingSetupFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
	[CallerCount(0)]
	public unsafe virtual void add_ActionRetrieveProducsFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0001F308 File Offset: 0x0001D508
	[CallerCount(0)]
	public unsafe virtual void remove_ActionRetrieveProducsFinished(Action<BillingResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0001F358 File Offset: 0x0001D558
	[CallerCount(0)]
	public unsafe virtual void AddProduct(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_AddProduct_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0001F3A8 File Offset: 0x0001D5A8
	[CallerCount(0)]
	public unsafe virtual void AddProduct(GoogleProductTemplate template)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(template);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_AddProduct_Public_Abstract_Virtual_New_Void_GoogleProductTemplate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
	[CallerCount(0)]
	public unsafe virtual void RetrieveProducDetails()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_RetrieveProducDetails_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0001F434 File Offset: 0x0001D634
	[CallerCount(0)]
	public unsafe virtual void Purchase(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0001F484 File Offset: 0x0001D684
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
	[CallerCount(0)]
	public unsafe virtual void Subscribe(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0001F534 File Offset: 0x0001D734
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0001F594 File Offset: 0x0001D794
	[CallerCount(0)]
	public unsafe virtual void Consume(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_Consume_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0001F5E4 File Offset: 0x0001D7E4
	[CallerCount(0)]
	public unsafe virtual void Connect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_Connect_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0001F620 File Offset: 0x0001D820
	[CallerCount(0)]
	public unsafe virtual void Connect(string base64EncodedPublicKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(base64EncodedPublicKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_Connect_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0001F670 File Offset: 0x0001D870
	[CallerCount(0)]
	public unsafe virtual void LoadStore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_LoadStore_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0001F6AC File Offset: 0x0001D8AC
	[CallerCount(0)]
	public unsafe virtual void LoadStore(string base64EncodedPublicKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(base64EncodedPublicKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_LoadStore_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000233 RID: 563 RVA: 0x0001F6FC File Offset: 0x0001D8FC
	public unsafe virtual AndroidInventory Inventory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_get_Inventory_Public_Abstract_Virtual_New_get_AndroidInventory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidInventory>(intPtr3) : null;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000234 RID: 564 RVA: 0x0001F748 File Offset: 0x0001D948
	public unsafe virtual bool IsConnectingToServiceInProcess
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000235 RID: 565 RVA: 0x0001F790 File Offset: 0x0001D990
	public unsafe virtual bool IsProductRetrievingInProcess
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000236 RID: 566 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
	public unsafe virtual bool IsConnected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_get_IsConnected_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000237 RID: 567 RVA: 0x0001F820 File Offset: 0x0001DA20
	public unsafe virtual bool IsInventoryLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AN_InAppClient.NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00002A1E File Offset: 0x00000C1E
	public AN_InAppClient(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040001D8 RID: 472
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProductPurchased_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001D9 RID: 473
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001DA RID: 474
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProductConsumed_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001DB RID: 475
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001DC RID: 476
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001DD RID: 477
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001DE RID: 478
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Abstract_Virtual_New_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001DF RID: 479
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Abstract_Virtual_New_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001E0 RID: 480
	private static readonly IntPtr NativeMethodInfoPtr_AddProduct_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x040001E1 RID: 481
	private static readonly IntPtr NativeMethodInfoPtr_AddProduct_Public_Abstract_Virtual_New_Void_GoogleProductTemplate_0;

	// Token: 0x040001E2 RID: 482
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducDetails_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x040001E3 RID: 483
	private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x040001E4 RID: 484
	private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_String_0;

	// Token: 0x040001E5 RID: 485
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x040001E6 RID: 486
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_Void_String_String_0;

	// Token: 0x040001E7 RID: 487
	private static readonly IntPtr NativeMethodInfoPtr_Consume_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x040001E8 RID: 488
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x040001E9 RID: 489
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x040001EA RID: 490
	private static readonly IntPtr NativeMethodInfoPtr_LoadStore_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x040001EB RID: 491
	private static readonly IntPtr NativeMethodInfoPtr_LoadStore_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x040001EC RID: 492
	private static readonly IntPtr NativeMethodInfoPtr_get_Inventory_Public_Abstract_Virtual_New_get_AndroidInventory_0;

	// Token: 0x040001ED RID: 493
	private static readonly IntPtr NativeMethodInfoPtr_get_IsConnectingToServiceInProcess_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x040001EE RID: 494
	private static readonly IntPtr NativeMethodInfoPtr_get_IsProductRetrievingInProcess_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x040001EF RID: 495
	private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x040001F0 RID: 496
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInventoryLoaded_Public_Abstract_Virtual_New_get_Boolean_0;
}
