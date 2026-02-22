using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000002 RID: 2
	public class iOSStoreBindings : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000205C File Offset: 0x0000025C
		// Note: this type is marked as 'beforefieldinit'.
		static iOSStoreBindings()
		{
			Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.AppleStub.dll", "UnityEngine.Purchasing", "iOSStoreBindings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr);
			iOSStoreBindings.NativeMethodInfoPtr_SetUnityPurchasingCallback_Public_Virtual_Final_New_Void_UnityPurchasingCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663297);
			iOSStoreBindings.NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663298);
			iOSStoreBindings.NativeMethodInfoPtr_AddTransactionObserver_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663299);
			iOSStoreBindings.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663300);
			iOSStoreBindings.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663301);
			iOSStoreBindings.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663302);
			iOSStoreBindings.NativeMethodInfoPtr_get_appReceipt_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663303);
			iOSStoreBindings.NativeMethodInfoPtr_InterceptPromotionalPurchases_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663304);
			iOSStoreBindings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002140 File Offset: 0x00000340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131398, XrefRangeEnd = 131403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(AsyncCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr_SetUnityPurchasingCallback_Public_Virtual_Final_New_Void_UnityPurchasingCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002184 File Offset: 0x00000384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131403, XrefRangeEnd = 131408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RestoreTransactions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021B8 File Offset: 0x000003B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131408, XrefRangeEnd = 131413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddTransactionObserver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr_AddTransactionObserver_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021EC File Offset: 0x000003EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131413, XrefRangeEnd = 131418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RetrieveProducts(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002230 File Offset: 0x00000430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131418, XrefRangeEnd = 131423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Purchase(string productJSON, string developerPayload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productJSON);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002284 File Offset: 0x00000484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131423, XrefRangeEnd = 131428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinishTransaction(string productJSON, string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productJSON);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022D8 File Offset: 0x000004D8
		public unsafe virtual string appReceipt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131428, XrefRangeEnd = 131433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr_get_appReceipt_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002310 File Offset: 0x00000510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131433, XrefRangeEnd = 131438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InterceptPromotionalPurchases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr_InterceptPromotionalPurchases_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002344 File Offset: 0x00000544
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe iOSStoreBindings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<iOSStoreBindings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(iOSStoreBindings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		public iOSStoreBindings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_SetUnityPurchasingCallback_Public_Virtual_Final_New_Void_UnityPurchasingCallback_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_AddTransactionObserver_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_appReceipt_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_InterceptPromotionalPurchases_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
