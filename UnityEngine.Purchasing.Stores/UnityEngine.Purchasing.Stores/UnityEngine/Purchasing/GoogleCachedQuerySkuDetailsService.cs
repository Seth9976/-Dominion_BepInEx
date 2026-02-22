using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000B RID: 11
	public class GoogleCachedQuerySkuDetailsService : Object
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000065A4 File Offset: 0x000047A4
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleCachedQuerySkuDetailsService()
		{
			Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GoogleCachedQuerySkuDetailsService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr);
			GoogleCachedQuerySkuDetailsService.NativeFieldInfoPtr_m_CachedQueriedSkus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr, "m_CachedQueriedSkus");
			GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_GetCachedQueriedSkus_Public_Virtual_Final_New_HashSet_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr, 100663324);
			GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_ContainsSku_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr, 100663325);
			GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_AddCachedQueriedSkus_Public_Virtual_Final_New_Void_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr, 100663326);
			GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_UpdateCachedQueriedSku_Private_Void_String_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr, 100663327);
			GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr, 100663328);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000664C File Offset: 0x0000484C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual HashSet<AndroidJavaObject> GetCachedQueriedSkus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_GetCachedQueriedSkus_Public_Virtual_Final_New_HashSet_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<AndroidJavaObject>>(intPtr3) : null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000668C File Offset: 0x0000488C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150269, XrefRangeEnd = 150285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsSku(string sku)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sku);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_ContainsSku_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000066DC File Offset: 0x000048DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150285, XrefRangeEnd = 150327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddCachedQueriedSkus(List<AndroidJavaObject> queriedSkus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queriedSkus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_AddCachedQueriedSkus_Public_Virtual_Final_New_Void_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006720 File Offset: 0x00004920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150343, RefRangeEnd = 150344, XrefRangeStart = 150327, XrefRangeEnd = 150343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCachedQueriedSku(string queriedSku, AndroidJavaObject queriedSkuDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(queriedSku);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(queriedSkuDetails);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_UpdateCachedQueriedSku_Private_Void_String_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006774 File Offset: 0x00004974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150344, XrefRangeEnd = 150351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleCachedQuerySkuDetailsService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002145 File Offset: 0x00000345
		public GoogleCachedQuerySkuDetailsService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000067B0 File Offset: 0x000049B0
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000214E File Offset: 0x0000034E
		public unsafe HashSet<AndroidJavaObject> m_CachedQueriedSkus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCachedQuerySkuDetailsService.NativeFieldInfoPtr_m_CachedQueriedSkus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<AndroidJavaObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCachedQuerySkuDetailsService.NativeFieldInfoPtr_m_CachedQueriedSkus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedQueriedSkus;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedQueriedSkus_Public_Virtual_Final_New_HashSet_1_AndroidJavaObject_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_ContainsSku_Private_Boolean_String_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_AddCachedQueriedSkus_Public_Virtual_Final_New_Void_List_1_AndroidJavaObject_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCachedQueriedSku_Private_Void_String_AndroidJavaObject_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200009B RID: 155
		[ObfuscatedName("UnityEngine.Purchasing.GoogleCachedQuerySkuDetailsService+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060005D0 RID: 1488 RVA: 0x00019208 File Offset: 0x00017408
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0>.NativeClassPtr);
				GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0.NativeFieldInfoPtr_sku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0>.NativeClassPtr, "sku");
				GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0>.NativeClassPtr, 100663329);
				GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0.NativeMethodInfoPtr__ContainsSku_b__0_Internal_Boolean_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0>.NativeClassPtr, 100663330);
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x00019270 File Offset: 0x00017470
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x000192AC File Offset: 0x000174AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150249, XrefRangeEnd = 150259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ContainsSku_b__0(AndroidJavaObject skuDetails)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(skuDetails);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0.NativeMethodInfoPtr__ContainsSku_b__0_Internal_Boolean_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x00004ECF File Offset: 0x000030CF
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x060005D4 RID: 1492 RVA: 0x000192FC File Offset: 0x000174FC
			// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00004ED8 File Offset: 0x000030D8
			public unsafe string sku
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0.NativeFieldInfoPtr_sku);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCachedQuerySkuDetailsService.__c__DisplayClass2_0.NativeFieldInfoPtr_sku), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040003E8 RID: 1000
			private static readonly IntPtr NativeFieldInfoPtr_sku;

			// Token: 0x040003E9 RID: 1001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003EA RID: 1002
			private static readonly IntPtr NativeMethodInfoPtr__ContainsSku_b__0_Internal_Boolean_AndroidJavaObject_0;
		}

		// Token: 0x0200009C RID: 156
		[ObfuscatedName("UnityEngine.Purchasing.GoogleCachedQuerySkuDetailsService+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060005D6 RID: 1494 RVA: 0x00019324 File Offset: 0x00017524
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0>.NativeClassPtr);
				GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0.NativeFieldInfoPtr_queriedSku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0>.NativeClassPtr, "queriedSku");
				GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0>.NativeClassPtr, 100663331);
				GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0.NativeMethodInfoPtr__UpdateCachedQueriedSku_b__0_Internal_Boolean_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0>.NativeClassPtr, 100663332);
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x0001938C File Offset: 0x0001758C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x000193C8 File Offset: 0x000175C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150259, XrefRangeEnd = 150269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateCachedQueriedSku_b__0(AndroidJavaObject skuDetails)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(skuDetails);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0.NativeMethodInfoPtr__UpdateCachedQueriedSku_b__0_Internal_Boolean_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x00004EF7 File Offset: 0x000030F7
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x060005DA RID: 1498 RVA: 0x00019418 File Offset: 0x00017618
			// (set) Token: 0x060005DB RID: 1499 RVA: 0x00004F00 File Offset: 0x00003100
			public unsafe string queriedSku
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0.NativeFieldInfoPtr_queriedSku);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCachedQuerySkuDetailsService.__c__DisplayClass4_0.NativeFieldInfoPtr_queriedSku), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040003EB RID: 1003
			private static readonly IntPtr NativeFieldInfoPtr_queriedSku;

			// Token: 0x040003EC RID: 1004
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003ED RID: 1005
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCachedQueriedSku_b__0_Internal_Boolean_AndroidJavaObject_0;
		}
	}
}
