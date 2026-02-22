using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000018 RID: 24
	public class StoreListenerProxy : Object
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x000064F8 File Offset: 0x000046F8
		// Note: this type is marked as 'beforefieldinit'.
		static StoreListenerProxy()
		{
			Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "StoreListenerProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr);
			StoreListenerProxy.NativeFieldInfoPtr_m_Analytics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr, "m_Analytics");
			StoreListenerProxy.NativeFieldInfoPtr_m_ForwardTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr, "m_ForwardTo");
			StoreListenerProxy.NativeFieldInfoPtr_m_Extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr, "m_Extensions");
			StoreListenerProxy.NativeMethodInfoPtr__ctor_Public_Void_IStoreListener_AnalyticsReporter_IExtensionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr, 100663423);
			StoreListenerProxy.NativeMethodInfoPtr_OnInitialized_Public_Virtual_Final_New_Void_IStoreController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr, 100663424);
			StoreListenerProxy.NativeMethodInfoPtr_OnInitializeFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr, 100663425);
			StoreListenerProxy.NativeMethodInfoPtr_ProcessPurchase_Public_Virtual_Final_New_PurchaseProcessingResult_PurchaseEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr, 100663426);
			StoreListenerProxy.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_Product_PurchaseFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr, 100663427);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000065C8 File Offset: 0x000047C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131088, XrefRangeEnd = 131089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoreListenerProxy(IStoreListener forwardTo, AnalyticsReporter analytics, IExtensionProvider extensions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreListenerProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forwardTo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(analytics);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreListenerProxy.NativeMethodInfoPtr__ctor_Public_Void_IStoreListener_AnalyticsReporter_IExtensionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00006638 File Offset: 0x00004838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131089, XrefRangeEnd = 131094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitialized(IStoreController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreListenerProxy.NativeMethodInfoPtr_OnInitialized_Public_Virtual_Final_New_Void_IStoreController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000667C File Offset: 0x0000487C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131094, XrefRangeEnd = 131098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitializeFailed(InitializationFailureReason error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreListenerProxy.NativeMethodInfoPtr_OnInitializeFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000066BC File Offset: 0x000048BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131098, XrefRangeEnd = 131106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreListenerProxy.NativeMethodInfoPtr_ProcessPurchase_Public_Virtual_Final_New_PurchaseProcessingResult_PurchaseEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000670C File Offset: 0x0000490C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131106, XrefRangeEnd = 131110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPurchaseFailed(Product i, PurchaseFailureReason p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreListenerProxy.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_Product_PurchaseFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002681 File Offset: 0x00000881
		public StoreListenerProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000675C File Offset: 0x0000495C
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000268A File Offset: 0x0000088A
		public unsafe AnalyticsReporter m_Analytics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreListenerProxy.NativeFieldInfoPtr_m_Analytics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsReporter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreListenerProxy.NativeFieldInfoPtr_m_Analytics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000678C File Offset: 0x0000498C
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000026A9 File Offset: 0x000008A9
		public unsafe IStoreListener m_ForwardTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreListenerProxy.NativeFieldInfoPtr_m_ForwardTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreListenerProxy.NativeFieldInfoPtr_m_ForwardTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000067BC File Offset: 0x000049BC
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000026C8 File Offset: 0x000008C8
		public unsafe IExtensionProvider m_Extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreListenerProxy.NativeFieldInfoPtr_m_Extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExtensionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreListenerProxy.NativeFieldInfoPtr_m_Extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_m_Analytics;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_m_ForwardTo;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_m_Extensions;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IStoreListener_AnalyticsReporter_IExtensionProvider_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialized_Public_Virtual_Final_New_Void_IStoreController_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializeFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPurchase_Public_Virtual_Final_New_PurchaseProcessingResult_PurchaseEventArgs_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_Product_PurchaseFailureReason_0;
	}
}
