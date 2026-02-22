using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200001D RID: 29
public class InitAndroidInventoryTask : MonoBehaviour
{
	// Token: 0x06000273 RID: 627 RVA: 0x00020628 File Offset: 0x0001E828
	// Note: this type is marked as 'beforefieldinit'.
	static InitAndroidInventoryTask()
	{
		Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "InitAndroidInventoryTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr);
		InitAndroidInventoryTask.NativeFieldInfoPtr_ActionComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, "ActionComplete");
		InitAndroidInventoryTask.NativeFieldInfoPtr_ActionFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, "ActionFailed");
		InitAndroidInventoryTask.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663677);
		InitAndroidInventoryTask.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663678);
		InitAndroidInventoryTask.NativeMethodInfoPtr_add_ActionFailed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663679);
		InitAndroidInventoryTask.NativeMethodInfoPtr_remove_ActionFailed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663680);
		InitAndroidInventoryTask.NativeMethodInfoPtr_Create_Public_Static_InitAndroidInventoryTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663681);
		InitAndroidInventoryTask.NativeMethodInfoPtr_Run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663682);
		InitAndroidInventoryTask.NativeMethodInfoPtr_OnBillingConnected_Private_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663683);
		InitAndroidInventoryTask.NativeMethodInfoPtr_OnBillingConnectFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663684);
		InitAndroidInventoryTask.NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663685);
		InitAndroidInventoryTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, 100663686);
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00020748 File Offset: 0x0001E948
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162266, XrefRangeEnd = 162270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionComplete(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0002078C File Offset: 0x0001E98C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162270, XrefRangeEnd = 162274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionComplete(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000276 RID: 630 RVA: 0x000207D0 File Offset: 0x0001E9D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162274, XrefRangeEnd = 162278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionFailed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_add_ActionFailed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00020814 File Offset: 0x0001EA14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162278, XrefRangeEnd = 162282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionFailed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_remove_ActionFailed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00020858 File Offset: 0x0001EA58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162282, XrefRangeEnd = 162292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InitAndroidInventoryTask Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_Create_Public_Static_InitAndroidInventoryTask_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<InitAndroidInventoryTask>(intPtr3) : null;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0002088C File Offset: 0x0001EA8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162292, XrefRangeEnd = 162324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Run()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_Run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600027A RID: 634 RVA: 0x000208C0 File Offset: 0x0001EAC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162324, XrefRangeEnd = 162351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBillingConnected(BillingResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_OnBillingConnected_Private_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00020904 File Offset: 0x0001EB04
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 162384, RefRangeEnd = 162385, XrefRangeStart = 162351, XrefRangeEnd = 162384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBillingConnectFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_OnBillingConnectFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00020938 File Offset: 0x0001EB38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162385, XrefRangeEnd = 162416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRetrieveProductsFinised(BillingResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Void_BillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0002097C File Offset: 0x0001EB7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162416, XrefRangeEnd = 162442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InitAndroidInventoryTask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00002B14 File Offset: 0x00000D14
	public InitAndroidInventoryTask(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600027F RID: 639 RVA: 0x000209B8 File Offset: 0x0001EBB8
	// (set) Token: 0x06000280 RID: 640 RVA: 0x00002B1D File Offset: 0x00000D1D
	public unsafe Action ActionComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitAndroidInventoryTask.NativeFieldInfoPtr_ActionComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitAndroidInventoryTask.NativeFieldInfoPtr_ActionComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000281 RID: 641 RVA: 0x000209E8 File Offset: 0x0001EBE8
	// (set) Token: 0x06000282 RID: 642 RVA: 0x00002B3C File Offset: 0x00000D3C
	public unsafe Action ActionFailed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitAndroidInventoryTask.NativeFieldInfoPtr_ActionFailed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitAndroidInventoryTask.NativeFieldInfoPtr_ActionFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400021C RID: 540
	private static readonly IntPtr NativeFieldInfoPtr_ActionComplete;

	// Token: 0x0400021D RID: 541
	private static readonly IntPtr NativeFieldInfoPtr_ActionFailed;

	// Token: 0x0400021E RID: 542
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_0;

	// Token: 0x0400021F RID: 543
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_0;

	// Token: 0x04000220 RID: 544
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionFailed_Public_add_Void_Action_0;

	// Token: 0x04000221 RID: 545
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionFailed_Public_rem_Void_Action_0;

	// Token: 0x04000222 RID: 546
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_InitAndroidInventoryTask_0;

	// Token: 0x04000223 RID: 547
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_0;

	// Token: 0x04000224 RID: 548
	private static readonly IntPtr NativeMethodInfoPtr_OnBillingConnected_Private_Void_BillingResult_0;

	// Token: 0x04000225 RID: 549
	private static readonly IntPtr NativeMethodInfoPtr_OnBillingConnectFinished_Private_Void_0;

	// Token: 0x04000226 RID: 550
	private static readonly IntPtr NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Void_BillingResult_0;

	// Token: 0x04000227 RID: 551
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000368 RID: 872
	[ObfuscatedName("InitAndroidInventoryTask+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003466 RID: 13414 RVA: 0x000D8BE8 File Offset: 0x000D6DE8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitAndroidInventoryTask>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr);
			InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr, "<>9");
			InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr, "<>9__11_0");
			InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr, "<>9__11_1");
			InitAndroidInventoryTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr, 100669962);
			InitAndroidInventoryTask.__c.NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr, 100669963);
			InitAndroidInventoryTask.__c.NativeMethodInfoPtr___ctor_b__11_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr, 100669964);
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x000D8C8C File Offset: 0x000D6E8C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitAndroidInventoryTask.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x000D8CC8 File Offset: 0x000D6EC8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.__c.NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x000D8CFC File Offset: 0x000D6EFC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitAndroidInventoryTask.__c.NativeMethodInfoPtr___ctor_b__11_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x0001477B File Offset: 0x0001297B
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x000D8D30 File Offset: 0x000D6F30
		// (set) Token: 0x0600346C RID: 13420 RVA: 0x00014784 File Offset: 0x00012984
		public unsafe static InitAndroidInventoryTask.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitAndroidInventoryTask.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x000D8D58 File Offset: 0x000D6F58
		// (set) Token: 0x0600346E RID: 13422 RVA: 0x00014796 File Offset: 0x00012996
		public unsafe static Action __9__11_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x000D8D80 File Offset: 0x000D6F80
		// (set) Token: 0x06003470 RID: 13424 RVA: 0x000147A8 File Offset: 0x000129A8
		public unsafe static Action __9__11_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitAndroidInventoryTask.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_0;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_1_Internal_Void_0;
	}
}
