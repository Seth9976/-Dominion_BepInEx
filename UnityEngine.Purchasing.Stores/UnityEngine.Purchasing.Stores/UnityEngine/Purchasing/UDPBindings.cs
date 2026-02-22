using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000041 RID: 65
	public class UDPBindings : Object
	{
		// Token: 0x060001FB RID: 507 RVA: 0x0000C680 File Offset: 0x0000A880
		// Note: this type is marked as 'beforefieldinit'.
		static UDPBindings()
		{
			Il2CppClassPointerStore<UDPBindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UDPBindings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr);
			UDPBindings.NativeFieldInfoPtr_m_Bridge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, "m_Bridge");
			UDPBindings.NativeFieldInfoPtr_m_RetrieveProductsCallbackCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, "m_RetrieveProductsCallbackCache");
			UDPBindings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663545);
			UDPBindings.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663546);
			UDPBindings.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_Action_2_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663547);
			UDPBindings.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663548);
			UDPBindings.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663549);
			UDPBindings.NativeMethodInfoPtr_OnInventoryQueried_Private_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663550);
			UDPBindings.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663551);
			UDPBindings.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663552);
			UDPBindings.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663553);
			UDPBindings.NativeMethodInfoPtr_StringPropertyToDictionary_Internal_Static_Dictionary_2_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr, 100663554);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152384, XrefRangeEnd = 152391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UDPBindings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UDPBindings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152391, XrefRangeEnd = 152416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Action<bool, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_Action_2_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000C820 File Offset: 0x0000AA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152416, XrefRangeEnd = 152451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Purchase(string productId, Action<bool, string> callback, string developerPayload = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_Action_2_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000C888 File Offset: 0x0000AA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152451, XrefRangeEnd = 152501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<bool, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_2_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000C8DC File Offset: 0x0000AADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152501, XrefRangeEnd = 152526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinishTransaction(ProductDefinition productDefinition, string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000C930 File Offset: 0x0000AB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152526, XrefRangeEnd = 152668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInventoryQueried(bool success, Object payload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(payload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_OnInventoryQueried_Private_Void_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000C980 File Offset: 0x0000AB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152668, XrefRangeEnd = 152673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RetrieveProducts(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152673, XrefRangeEnd = 152678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000CA18 File Offset: 0x0000AC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152678, XrefRangeEnd = 152683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152705, RefRangeEnd = 152706, XrefRangeStart = 152683, XrefRangeEnd = 152705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, string> StringPropertyToDictionary(Object info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPBindings.NativeMethodInfoPtr_StringPropertyToDictionary_Internal_Static_Dictionary_2_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002FF6 File Offset: 0x000011F6
		public UDPBindings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002FFF File Offset: 0x000011FF
		public unsafe Object m_Bridge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPBindings.NativeFieldInfoPtr_m_Bridge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPBindings.NativeFieldInfoPtr_m_Bridge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0000301E File Offset: 0x0000121E
		public unsafe Action<bool, string> m_RetrieveProductsCallbackCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPBindings.NativeFieldInfoPtr_m_RetrieveProductsCallbackCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPBindings.NativeFieldInfoPtr_m_RetrieveProductsCallbackCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_m_Bridge;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_m_RetrieveProductsCallbackCache;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_Action_2_Boolean_String_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_Action_2_Boolean_String_String_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_2_Boolean_String_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_OnInventoryQueried_Private_Void_Boolean_Object_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_StringPropertyToDictionary_Internal_Static_Dictionary_2_String_String_Object_0;
	}
}
