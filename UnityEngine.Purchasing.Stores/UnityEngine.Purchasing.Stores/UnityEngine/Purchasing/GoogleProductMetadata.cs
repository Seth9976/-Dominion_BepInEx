using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002C RID: 44
	public class GoogleProductMetadata : ProductMetadata
	{
		// Token: 0x06000168 RID: 360 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleProductMetadata()
		{
			Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GoogleProductMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr);
			GoogleProductMetadata.NativeFieldInfoPtr__originalJson_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, "<originalJson>k__BackingField");
			GoogleProductMetadata.NativeFieldInfoPtr__subscriptionPeriod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, "<subscriptionPeriod>k__BackingField");
			GoogleProductMetadata.NativeFieldInfoPtr__freeTrialPeriod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, "<freeTrialPeriod>k__BackingField");
			GoogleProductMetadata.NativeFieldInfoPtr__introductoryPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, "<introductoryPrice>k__BackingField");
			GoogleProductMetadata.NativeFieldInfoPtr__introductoryPricePeriod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, "<introductoryPricePeriod>k__BackingField");
			GoogleProductMetadata.NativeFieldInfoPtr__introductoryPriceCycles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, "<introductoryPriceCycles>k__BackingField");
			GoogleProductMetadata.NativeMethodInfoPtr_set_originalJson_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, 100663467);
			GoogleProductMetadata.NativeMethodInfoPtr_set_subscriptionPeriod_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, 100663468);
			GoogleProductMetadata.NativeMethodInfoPtr_set_freeTrialPeriod_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, 100663469);
			GoogleProductMetadata.NativeMethodInfoPtr_set_introductoryPrice_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, 100663470);
			GoogleProductMetadata.NativeMethodInfoPtr_set_introductoryPricePeriod_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, 100663471);
			GoogleProductMetadata.NativeMethodInfoPtr_set_introductoryPriceCycles_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, 100663472);
			GoogleProductMetadata.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr, 100663473);
		}

		// Token: 0x17000055 RID: 85
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000A9DC File Offset: 0x00008BDC
		public unsafe string originalJson
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductMetadata.NativeMethodInfoPtr_set_originalJson_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0000AA20 File Offset: 0x00008C20
		public unsafe string subscriptionPeriod
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductMetadata.NativeMethodInfoPtr_set_subscriptionPeriod_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000AA64 File Offset: 0x00008C64
		public unsafe string freeTrialPeriod
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductMetadata.NativeMethodInfoPtr_set_freeTrialPeriod_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000AAA8 File Offset: 0x00008CA8
		public unsafe string introductoryPrice
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductMetadata.NativeMethodInfoPtr_set_introductoryPrice_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000AAEC File Offset: 0x00008CEC
		public unsafe string introductoryPricePeriod
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductMetadata.NativeMethodInfoPtr_set_introductoryPricePeriod_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000AB30 File Offset: 0x00008D30
		public unsafe int introductoryPriceCycles
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductMetadata.NativeMethodInfoPtr_set_introductoryPriceCycles_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000AB70 File Offset: 0x00008D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151534, XrefRangeEnd = 151535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleProductMetadata(string priceString, string title, string description, string currencyCode, Decimal localizedPrice)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleProductMetadata>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(priceString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currencyCode);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localizedPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleProductMetadata.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public GoogleProductMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000AC00 File Offset: 0x00008E00
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public unsafe string _originalJson_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__originalJson_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__originalJson_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000AC28 File Offset: 0x00008E28
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public unsafe string _subscriptionPeriod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__subscriptionPeriod_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__subscriptionPeriod_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000AC50 File Offset: 0x00008E50
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002B17 File Offset: 0x00000D17
		public unsafe string _freeTrialPeriod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__freeTrialPeriod_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__freeTrialPeriod_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000AC78 File Offset: 0x00008E78
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002B36 File Offset: 0x00000D36
		public unsafe string _introductoryPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__introductoryPrice_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__introductoryPrice_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002B55 File Offset: 0x00000D55
		public unsafe string _introductoryPricePeriod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__introductoryPricePeriod_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__introductoryPricePeriod_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002B74 File Offset: 0x00000D74
		public unsafe int _introductoryPriceCycles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__introductoryPriceCycles_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleProductMetadata.NativeFieldInfoPtr__introductoryPriceCycles_k__BackingField)) = value;
			}
		}

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr__originalJson_k__BackingField;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr__subscriptionPeriod_k__BackingField;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr__freeTrialPeriod_k__BackingField;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr__introductoryPrice_k__BackingField;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr__introductoryPricePeriod_k__BackingField;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr__introductoryPriceCycles_k__BackingField;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_set_originalJson_Internal_set_Void_String_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_set_subscriptionPeriod_Internal_set_Void_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_set_freeTrialPeriod_Internal_set_Void_String_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_set_introductoryPrice_Internal_set_Void_String_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_set_introductoryPricePeriod_Internal_set_Void_String_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_set_introductoryPriceCycles_Internal_set_Void_Int32_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_Decimal_0;
	}
}
