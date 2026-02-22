using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000007 RID: 7
	public class AndroidJavaStore : Object
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000061F0 File Offset: 0x000043F0
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaStore()
		{
			Il2CppClassPointerStore<AndroidJavaStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "AndroidJavaStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaStore>.NativeClassPtr);
			AndroidJavaStore.NativeFieldInfoPtr_m_Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaStore>.NativeClassPtr, "m_Store");
			AndroidJavaStore.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaStore>.NativeClassPtr, 100663316);
			AndroidJavaStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaStore>.NativeClassPtr, 100663317);
			AndroidJavaStore.NativeMethodInfoPtr_Purchase_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaStore>.NativeClassPtr, 100663318);
			AndroidJavaStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaStore>.NativeClassPtr, 100663319);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00006284 File Offset: 0x00004484
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaStore(AndroidJavaObject store)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaStore>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaStore.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000062D0 File Offset: 0x000044D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150148, XrefRangeEnd = 150160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RetrieveProducts(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00006314 File Offset: 0x00004514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150160, XrefRangeEnd = 150177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaStore.NativeMethodInfoPtr_Purchase_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006374 File Offset: 0x00004574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150177, XrefRangeEnd = 150194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000210B File Offset: 0x0000030B
		public AndroidJavaStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000063D4 File Offset: 0x000045D4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002114 File Offset: 0x00000314
		public unsafe AndroidJavaObject m_Store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaStore.NativeFieldInfoPtr_m_Store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaStore.NativeFieldInfoPtr_m_Store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_m_Store;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_New_Void_String_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_New_Void_String_String_0;
	}
}
