using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200001A RID: 26
public static class AndroidInAppPurchaseManager : Object
{
	// Token: 0x06000239 RID: 569 RVA: 0x0001F868 File Offset: 0x0001DA68
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidInAppPurchaseManager()
	{
		Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidInAppPurchaseManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr);
		AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionProductPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, "ActionProductPurchased");
		AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionProductConsumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, "ActionProductConsumed");
		AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionBillingSetupFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, "ActionBillingSetupFinished");
		AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionRetrieveProducsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, "ActionRetrieveProducsFinished");
		AndroidInAppPurchaseManager.NativeFieldInfoPtr__Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, "_Client");
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_add_ActionProductPurchased_Public_Static_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663642);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Static_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663643);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_add_ActionProductConsumed_Public_Static_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663644);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Static_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663645);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Static_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663646);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Static_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663647);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Static_add_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663648);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Static_rem_Void_Action_1_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663649);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_get_Client_Public_Static_get_AN_InAppClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663650);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_HandleActionRetrieveProducsFinished_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663651);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_HandleActionProductPurchased_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663652);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_HandleActionProductConsumed_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663653);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_HandleActionBillingSetupFinished_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663654);
		AndroidInAppPurchaseManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_AN_InAppClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, 100663655);
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0001FA14 File Offset: 0x0001DC14
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 161866, RefRangeEnd = 161868, XrefRangeStart = 161855, XrefRangeEnd = 161866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionProductPurchased(Action<BillingResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_add_ActionProductPurchased_Public_Static_add_Void_Action_1_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0001FA4C File Offset: 0x0001DC4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161868, XrefRangeEnd = 161879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionProductPurchased(Action<BillingResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Static_rem_Void_Action_1_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0001FA84 File Offset: 0x0001DC84
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 161890, RefRangeEnd = 161892, XrefRangeStart = 161879, XrefRangeEnd = 161890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionProductConsumed(Action<BillingResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_add_ActionProductConsumed_Public_Static_add_Void_Action_1_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0001FABC File Offset: 0x0001DCBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161892, XrefRangeEnd = 161903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionProductConsumed(Action<BillingResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Static_rem_Void_Action_1_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0001FAF4 File Offset: 0x0001DCF4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 161914, RefRangeEnd = 161917, XrefRangeStart = 161903, XrefRangeEnd = 161914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionBillingSetupFinished(Action<BillingResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Static_add_Void_Action_1_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0001FB2C File Offset: 0x0001DD2C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 161928, RefRangeEnd = 161931, XrefRangeStart = 161917, XrefRangeEnd = 161928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionBillingSetupFinished(Action<BillingResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Static_rem_Void_Action_1_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0001FB64 File Offset: 0x0001DD64
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 161942, RefRangeEnd = 161945, XrefRangeStart = 161931, XrefRangeEnd = 161942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionRetrieveProducsFinished(Action<BillingResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Static_add_Void_Action_1_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0001FB9C File Offset: 0x0001DD9C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 161956, RefRangeEnd = 161959, XrefRangeStart = 161945, XrefRangeEnd = 161956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionRetrieveProducsFinished(Action<BillingResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Static_rem_Void_Action_1_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000242 RID: 578 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
	public unsafe static AN_InAppClient Client
	{
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 162037, RefRangeEnd = 162068, XrefRangeStart = 161959, XrefRangeEnd = 162037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_get_Client_Public_Static_get_AN_InAppClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AN_InAppClient>(intPtr3) : null;
		}
	}

	// Token: 0x06000243 RID: 579 RVA: 0x0001FC08 File Offset: 0x0001DE08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162068, XrefRangeEnd = 162115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleActionRetrieveProducsFinished(BillingResult res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_HandleActionRetrieveProducsFinished_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0001FC40 File Offset: 0x0001DE40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162115, XrefRangeEnd = 162123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleActionProductPurchased(BillingResult res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_HandleActionProductPurchased_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0001FC78 File Offset: 0x0001DE78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162123, XrefRangeEnd = 162131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleActionProductConsumed(BillingResult res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_HandleActionProductConsumed_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162131, XrefRangeEnd = 162139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleActionBillingSetupFinished(BillingResult res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_HandleActionBillingSetupFinished_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000247 RID: 583 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
	public unsafe static AN_InAppClient Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162139, XrefRangeEnd = 162143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_AN_InAppClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AN_InAppClient>(intPtr3) : null;
		}
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00002A27 File Offset: 0x00000C27
	public AndroidInAppPurchaseManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000249 RID: 585 RVA: 0x0001FD1C File Offset: 0x0001DF1C
	// (set) Token: 0x0600024A RID: 586 RVA: 0x00002A30 File Offset: 0x00000C30
	public unsafe static Action<BillingResult> ActionProductPurchased
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionProductPurchased, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionProductPurchased, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x0600024B RID: 587 RVA: 0x0001FD44 File Offset: 0x0001DF44
	// (set) Token: 0x0600024C RID: 588 RVA: 0x00002A42 File Offset: 0x00000C42
	public unsafe static Action<BillingResult> ActionProductConsumed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionProductConsumed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionProductConsumed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x0600024D RID: 589 RVA: 0x0001FD6C File Offset: 0x0001DF6C
	// (set) Token: 0x0600024E RID: 590 RVA: 0x00002A54 File Offset: 0x00000C54
	public unsafe static Action<BillingResult> ActionBillingSetupFinished
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionBillingSetupFinished, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionBillingSetupFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x0600024F RID: 591 RVA: 0x0001FD94 File Offset: 0x0001DF94
	// (set) Token: 0x06000250 RID: 592 RVA: 0x00002A66 File Offset: 0x00000C66
	public unsafe static Action<BillingResult> ActionRetrieveProducsFinished
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionRetrieveProducsFinished, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BillingResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr_ActionRetrieveProducsFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000251 RID: 593 RVA: 0x0001FDBC File Offset: 0x0001DFBC
	// (set) Token: 0x06000252 RID: 594 RVA: 0x00002A78 File Offset: 0x00000C78
	public unsafe static AN_InAppClient _Client
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr__Client, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_InAppClient>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidInAppPurchaseManager.NativeFieldInfoPtr__Client, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040001F1 RID: 497
	private static readonly IntPtr NativeFieldInfoPtr_ActionProductPurchased;

	// Token: 0x040001F2 RID: 498
	private static readonly IntPtr NativeFieldInfoPtr_ActionProductConsumed;

	// Token: 0x040001F3 RID: 499
	private static readonly IntPtr NativeFieldInfoPtr_ActionBillingSetupFinished;

	// Token: 0x040001F4 RID: 500
	private static readonly IntPtr NativeFieldInfoPtr_ActionRetrieveProducsFinished;

	// Token: 0x040001F5 RID: 501
	private static readonly IntPtr NativeFieldInfoPtr__Client;

	// Token: 0x040001F6 RID: 502
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProductPurchased_Public_Static_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001F7 RID: 503
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProductPurchased_Public_Static_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001F8 RID: 504
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProductConsumed_Public_Static_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001F9 RID: 505
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProductConsumed_Public_Static_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001FA RID: 506
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionBillingSetupFinished_Public_Static_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001FB RID: 507
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionBillingSetupFinished_Public_Static_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001FC RID: 508
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRetrieveProducsFinished_Public_Static_add_Void_Action_1_BillingResult_0;

	// Token: 0x040001FD RID: 509
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRetrieveProducsFinished_Public_Static_rem_Void_Action_1_BillingResult_0;

	// Token: 0x040001FE RID: 510
	private static readonly IntPtr NativeMethodInfoPtr_get_Client_Public_Static_get_AN_InAppClient_0;

	// Token: 0x040001FF RID: 511
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionRetrieveProducsFinished_Private_Static_Void_BillingResult_0;

	// Token: 0x04000200 RID: 512
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionProductPurchased_Private_Static_Void_BillingResult_0;

	// Token: 0x04000201 RID: 513
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionProductConsumed_Private_Static_Void_BillingResult_0;

	// Token: 0x04000202 RID: 514
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionBillingSetupFinished_Private_Static_Void_BillingResult_0;

	// Token: 0x04000203 RID: 515
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_AN_InAppClient_0;

	// Token: 0x02000367 RID: 871
	[ObfuscatedName("AndroidInAppPurchaseManager+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x0600345D RID: 13405 RVA: 0x000D89D0 File Offset: 0x000D6BD0
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidInAppPurchaseManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr);
			AndroidInAppPurchaseManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr, "<>9");
			AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr, 100669956);
			AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr___cctor_b__21_0_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr, 100669957);
			AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr___cctor_b__21_1_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr, 100669958);
			AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr___cctor_b__21_2_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr, 100669959);
			AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr___cctor_b__21_3_Internal_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr, 100669960);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x000D8A74 File Offset: 0x000D6C74
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidInAppPurchaseManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x000D8AB0 File Offset: 0x000D6CB0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__21_0(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr___cctor_b__21_0_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x000D8AF4 File Offset: 0x000D6CF4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__21_1(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr___cctor_b__21_1_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x000D8B38 File Offset: 0x000D6D38
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__21_2(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr___cctor_b__21_2_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x000D8B7C File Offset: 0x000D6D7C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__21_3(BillingResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInAppPurchaseManager.__c.NativeMethodInfoPtr___cctor_b__21_3_Internal_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00014760 File Offset: 0x00012960
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x000D8BC0 File Offset: 0x000D6DC0
		// (set) Token: 0x06003465 RID: 13413 RVA: 0x00014769 File Offset: 0x00012969
		public unsafe static AndroidInAppPurchaseManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidInAppPurchaseManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidInAppPurchaseManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidInAppPurchaseManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__21_0_Internal_Void_BillingResult_0;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__21_1_Internal_Void_BillingResult_0;

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__21_2_Internal_Void_BillingResult_0;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__21_3_Internal_Void_BillingResult_0;
	}
}
