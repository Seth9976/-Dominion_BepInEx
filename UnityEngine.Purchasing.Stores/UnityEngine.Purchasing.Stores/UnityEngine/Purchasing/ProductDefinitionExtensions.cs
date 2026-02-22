using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007C RID: 124
	public static class ProductDefinitionExtensions : Object
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x00004832 File Offset: 0x00002A32
		// Note: this type is marked as 'beforefieldinit'.
		static ProductDefinitionExtensions()
		{
			Il2CppClassPointerStore<ProductDefinitionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ProductDefinitionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductDefinitionExtensions>.NativeClassPtr);
			ProductDefinitionExtensions.NativeMethodInfoPtr_DecodeJSON_Internal_Static_List_1_ProductDefinition_List_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinitionExtensions>.NativeClassPtr, 100663880);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00015CF8 File Offset: 0x00013EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156467, RefRangeEnd = 156468, XrefRangeStart = 156381, XrefRangeEnd = 156467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ProductDefinition> DecodeJSON(this List<Object> productsList, string storeName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(productsList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinitionExtensions.NativeMethodInfoPtr_DecodeJSON_Internal_Static_List_1_ProductDefinition_List_1_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000486B File Offset: 0x00002A6B
		public ProductDefinitionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_DecodeJSON_Internal_Static_List_1_ProductDefinition_List_1_Object_String_0;
	}
}
