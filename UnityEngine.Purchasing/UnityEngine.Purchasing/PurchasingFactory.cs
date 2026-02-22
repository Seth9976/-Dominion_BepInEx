using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000015 RID: 21
	public class PurchasingFactory : Object
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x000052B4 File Offset: 0x000034B4
		// Note: this type is marked as 'beforefieldinit'.
		static PurchasingFactory()
		{
			Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "PurchasingFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr);
			PurchasingFactory.NativeFieldInfoPtr_m_ConfigMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, "m_ConfigMap");
			PurchasingFactory.NativeFieldInfoPtr_m_ExtensionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, "m_ExtensionMap");
			PurchasingFactory.NativeFieldInfoPtr_m_Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, "m_Store");
			PurchasingFactory.NativeFieldInfoPtr_m_CatalogProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, "m_CatalogProvider");
			PurchasingFactory.NativeFieldInfoPtr__storeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, "<storeName>k__BackingField");
			PurchasingFactory.NativeMethodInfoPtr__ctor_Public_Void_IPurchasingModule_Il2CppReferenceArray_1_IPurchasingModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663382);
			PurchasingFactory.NativeMethodInfoPtr_get_storeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663383);
			PurchasingFactory.NativeMethodInfoPtr_set_storeName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663384);
			PurchasingFactory.NativeMethodInfoPtr_get_service_Public_get_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663385);
			PurchasingFactory.NativeMethodInfoPtr_set_service_Public_set_Void_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663386);
			PurchasingFactory.NativeMethodInfoPtr_RegisterStore_Public_Virtual_Final_New_Void_String_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663387);
			PurchasingFactory.NativeMethodInfoPtr_RegisterExtension_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663388);
			PurchasingFactory.NativeMethodInfoPtr_RegisterConfiguration_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663389);
			PurchasingFactory.NativeMethodInfoPtr_GetExtension_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663390);
			PurchasingFactory.NativeMethodInfoPtr_SetCatalogProviderFunction_Public_Virtual_Final_New_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663391);
			PurchasingFactory.NativeMethodInfoPtr_GetCatalogProvider_Internal_ICatalogProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr, 100663392);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005424 File Offset: 0x00003624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130745, XrefRangeEnd = 130765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchasingFactory(IPurchasingModule first, [Optional] Il2CppReferenceArray<IPurchasingModule> remainingModules)
		{
			if (remainingModules == null)
			{
				remainingModules = new Il2CppReferenceArray<IPurchasingModule>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remainingModules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.NativeMethodInfoPtr__ctor_Public_Void_IPurchasingModule_Il2CppReferenceArray_1_IPurchasingModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005490 File Offset: 0x00003690
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000054C8 File Offset: 0x000036C8
		public unsafe string storeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.NativeMethodInfoPtr_get_storeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.NativeMethodInfoPtr_set_storeName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000550C File Offset: 0x0000370C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000554C File Offset: 0x0000374C
		public unsafe IStore service
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 130765, RefRangeEnd = 130766, XrefRangeStart = 130765, XrefRangeEnd = 130765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.NativeMethodInfoPtr_get_service_Public_get_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.NativeMethodInfoPtr_set_service_Public_set_Void_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005590 File Offset: 0x00003790
		[CallerCount(0)]
		public unsafe virtual void RegisterStore(string name, IStore s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.NativeMethodInfoPtr_RegisterStore_Public_Virtual_Final_New_Void_String_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000055E4 File Offset: 0x000037E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130766, XrefRangeEnd = 130774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterExtension<T>(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.MethodInfoStoreGeneric_RegisterExtension_Public_Virtual_Final_New_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000565C File Offset: 0x0000385C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130774, XrefRangeEnd = 130782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterConfiguration<T>(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.MethodInfoStoreGeneric_RegisterConfiguration_Public_Virtual_Final_New_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000056D4 File Offset: 0x000038D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130782, XrefRangeEnd = 130796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T GetExtension<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.MethodInfoStoreGeneric_GetExtension_Public_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005710 File Offset: 0x00003910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130796, XrefRangeEnd = 130800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCatalogProviderFunction(Action<Action<HashSet<ProductDefinition>>> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.NativeMethodInfoPtr_SetCatalogProviderFunction_Public_Virtual_Final_New_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005754 File Offset: 0x00003954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICatalogProvider GetCatalogProvider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingFactory.NativeMethodInfoPtr_GetCatalogProvider_Internal_ICatalogProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICatalogProvider>(intPtr3) : null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000246F File Offset: 0x0000066F
		public PurchasingFactory(IPurchasingModule first, params IPurchasingModule[] remainingModules)
			: this(first, new Il2CppReferenceArray<IPurchasingModule>(remainingModules))
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000247E File Offset: 0x0000067E
		public PurchasingFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00005794 File Offset: 0x00003994
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002487 File Offset: 0x00000687
		public unsafe Dictionary<Type, IStoreConfiguration> m_ConfigMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr_m_ConfigMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, IStoreConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr_m_ConfigMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000057C4 File Offset: 0x000039C4
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000024A6 File Offset: 0x000006A6
		public unsafe Dictionary<Type, IStoreExtension> m_ExtensionMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr_m_ExtensionMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, IStoreExtension>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr_m_ExtensionMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000057F4 File Offset: 0x000039F4
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000024C5 File Offset: 0x000006C5
		public unsafe IStore m_Store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr_m_Store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr_m_Store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00005824 File Offset: 0x00003A24
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000024E4 File Offset: 0x000006E4
		public unsafe ICatalogProvider m_CatalogProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr_m_CatalogProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICatalogProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr_m_CatalogProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00005854 File Offset: 0x00003A54
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002503 File Offset: 0x00000703
		public unsafe string _storeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr__storeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingFactory.NativeFieldInfoPtr__storeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfigMap;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtensionMap;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_m_Store;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_m_CatalogProvider;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr__storeName_k__BackingField;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPurchasingModule_Il2CppReferenceArray_1_IPurchasingModule_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_storeName_Public_get_String_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_set_storeName_Private_set_Void_String_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_service_Public_get_IStore_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_set_service_Public_set_Void_IStore_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_RegisterStore_Public_Virtual_Final_New_Void_String_IStore_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_RegisterExtension_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConfiguration_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_Virtual_Final_New_T_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_SetCatalogProviderFunction_Public_Virtual_Final_New_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_GetCatalogProvider_Internal_ICatalogProvider_0;

		// Token: 0x0200002B RID: 43
		private sealed class MethodInfoStoreGeneric_RegisterExtension_Public_Virtual_Final_New_Void_T_0<T>
		{
			// Token: 0x0400010D RID: 269
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PurchasingFactory.NativeMethodInfoPtr_RegisterExtension_Public_Virtual_Final_New_Void_T_0, Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002C RID: 44
		private sealed class MethodInfoStoreGeneric_RegisterConfiguration_Public_Virtual_Final_New_Void_T_0<T>
		{
			// Token: 0x0400010E RID: 270
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PurchasingFactory.NativeMethodInfoPtr_RegisterConfiguration_Public_Virtual_Final_New_Void_T_0, Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002D RID: 45
		private sealed class MethodInfoStoreGeneric_GetExtension_Public_Virtual_Final_New_T_0<T>
		{
			// Token: 0x0400010F RID: 271
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PurchasingFactory.NativeMethodInfoPtr_GetExtension_Public_Virtual_Final_New_T_0, Il2CppClassPointerStore<PurchasingFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
