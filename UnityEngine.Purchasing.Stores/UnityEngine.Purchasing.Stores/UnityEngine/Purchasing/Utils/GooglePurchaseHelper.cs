using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Utils
{
	// Token: 0x02000097 RID: 151
	public static class GooglePurchaseHelper : Object
	{
		// Token: 0x060005C0 RID: 1472 RVA: 0x00004E43 File Offset: 0x00003043
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePurchaseHelper()
		{
			Il2CppClassPointerStore<GooglePurchaseHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Utils", "GooglePurchaseHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchaseHelper>.NativeClassPtr);
			GooglePurchaseHelper.NativeMethodInfoPtr_MakeGooglePurchase_Internal_Static_GooglePurchase_IEnumerable_1_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseHelper>.NativeClassPtr, 100663997);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00018EAC File Offset: 0x000170AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157457, RefRangeEnd = 157460, XrefRangeStart = 157430, XrefRangeEnd = 157457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GooglePurchase MakeGooglePurchase(IEnumerable<AndroidJavaObject> skuDetails, AndroidJavaObject purchase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skuDetails);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseHelper.NativeMethodInfoPtr_MakeGooglePurchase_Internal_Static_GooglePurchase_IEnumerable_1_AndroidJavaObject_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePurchase>(intPtr3) : null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00004E7C File Offset: 0x0000307C
		public GooglePurchaseHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_MakeGooglePurchase_Internal_Static_GooglePurchase_IEnumerable_1_AndroidJavaObject_AndroidJavaObject_0;

		// Token: 0x020000CB RID: 203
		[ObfuscatedName("UnityEngine.Purchasing.Utils.GooglePurchaseHelper+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x0600073C RID: 1852 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<GooglePurchaseHelper.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePurchaseHelper>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchaseHelper.__c__DisplayClass0_0>.NativeClassPtr);
				GooglePurchaseHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_sku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseHelper.__c__DisplayClass0_0>.NativeClassPtr, "sku");
				GooglePurchaseHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseHelper.__c__DisplayClass0_0>.NativeClassPtr, 100663998);
				GooglePurchaseHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__MakeGooglePurchase_b__0_Internal_Boolean_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseHelper.__c__DisplayClass0_0>.NativeClassPtr, 100663999);
			}

			// Token: 0x0600073D RID: 1853 RVA: 0x0001D30C File Offset: 0x0001B50C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePurchaseHelper.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600073E RID: 1854 RVA: 0x0001D348 File Offset: 0x0001B548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157416, XrefRangeEnd = 157430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MakeGooglePurchase_b__0(AndroidJavaObject skuDetailJavaObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(skuDetailJavaObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseHelper.__c__DisplayClass0_0.NativeMethodInfoPtr__MakeGooglePurchase_b__0_Internal_Boolean_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600073F RID: 1855 RVA: 0x00005A32 File Offset: 0x00003C32
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000740 RID: 1856 RVA: 0x0001D398 File Offset: 0x0001B598
			// (set) Token: 0x06000741 RID: 1857 RVA: 0x00005A3B File Offset: 0x00003C3B
			public unsafe string sku
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_sku);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseHelper.__c__DisplayClass0_0.NativeFieldInfoPtr_sku), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004B2 RID: 1202
			private static readonly IntPtr NativeFieldInfoPtr_sku;

			// Token: 0x040004B3 RID: 1203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004B4 RID: 1204
			private static readonly IntPtr NativeMethodInfoPtr__MakeGooglePurchase_b__0_Internal_Boolean_AndroidJavaObject_0;
		}
	}
}
