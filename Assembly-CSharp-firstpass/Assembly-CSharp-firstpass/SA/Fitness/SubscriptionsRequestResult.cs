using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x0200034A RID: 842
	public class SubscriptionsRequestResult : Result
	{
		// Token: 0x060032DE RID: 13022 RVA: 0x000D4388 File Offset: 0x000D2588
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriptionsRequestResult()
		{
			Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "SubscriptionsRequestResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr);
			SubscriptionsRequestResult.NativeFieldInfoPtr_subscriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr, "subscriptions");
			SubscriptionsRequestResult.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr, "id");
			SubscriptionsRequestResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr, 100669816);
			SubscriptionsRequestResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr, 100669817);
			SubscriptionsRequestResult.NativeMethodInfoPtr_AddSubscription_Public_Void_Subscription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr, 100669818);
			SubscriptionsRequestResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr, 100669819);
			SubscriptionsRequestResult.NativeMethodInfoPtr_get_Subscriptions_Public_get_List_1_Subscription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr, 100669820);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x000D4444 File Offset: 0x000D2644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222902, RefRangeEnd = 222903, XrefRangeStart = 222895, XrefRangeEnd = 222902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionsRequestResult(int id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequestResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000D448C File Offset: 0x000D268C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222903, XrefRangeEnd = 222914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionsRequestResult(int id, int resultCode, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriptionsRequestResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequestResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000D44F4 File Offset: 0x000D26F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222918, RefRangeEnd = 222919, XrefRangeStart = 222914, XrefRangeEnd = 222918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSubscription(Subscription subscription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subscription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequestResult.NativeMethodInfoPtr_AddSubscription_Public_Void_Subscription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060032E2 RID: 13026 RVA: 0x000D4538 File Offset: 0x000D2738
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequestResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060032E3 RID: 13027 RVA: 0x000D4574 File Offset: 0x000D2774
		public unsafe List<Subscription> Subscriptions
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionsRequestResult.NativeMethodInfoPtr_get_Subscriptions_Public_get_List_1_Subscription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Subscription>>(intPtr3) : null;
			}
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x00013C94 File Offset: 0x00011E94
		public SubscriptionsRequestResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060032E5 RID: 13029 RVA: 0x000D45B4 File Offset: 0x000D27B4
		// (set) Token: 0x060032E6 RID: 13030 RVA: 0x00013C9D File Offset: 0x00011E9D
		public unsafe List<Subscription> subscriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequestResult.NativeFieldInfoPtr_subscriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Subscription>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequestResult.NativeFieldInfoPtr_subscriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060032E7 RID: 13031 RVA: 0x000D45E4 File Offset: 0x000D27E4
		// (set) Token: 0x060032E8 RID: 13032 RVA: 0x00013CBC File Offset: 0x00011EBC
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequestResult.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionsRequestResult.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x04002F78 RID: 12152
		private static readonly IntPtr NativeFieldInfoPtr_subscriptions;

		// Token: 0x04002F79 RID: 12153
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F7A RID: 12154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002F7B RID: 12155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0;

		// Token: 0x04002F7C RID: 12156
		private static readonly IntPtr NativeMethodInfoPtr_AddSubscription_Public_Void_Subscription_0;

		// Token: 0x04002F7D RID: 12157
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F7E RID: 12158
		private static readonly IntPtr NativeMethodInfoPtr_get_Subscriptions_Public_get_List_1_Subscription_0;
	}
}
