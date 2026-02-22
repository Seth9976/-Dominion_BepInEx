using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000036 RID: 54
	public class JSONSerializer : Object
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x0000BB10 File Offset: 0x00009D10
		// Note: this type is marked as 'beforefieldinit'.
		static JSONSerializer()
		{
			Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "JSONSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr);
			JSONSerializer.NativeMethodInfoPtr_SerializeProductDef_Public_Static_String_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663509);
			JSONSerializer.NativeMethodInfoPtr_SerializeProductDefs_Public_Static_String_IEnumerable_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663510);
			JSONSerializer.NativeMethodInfoPtr_SerializeProductDescs_Public_Static_String_IEnumerable_1_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663511);
			JSONSerializer.NativeMethodInfoPtr_DeserializeProductDescriptions_Public_Static_List_1_ProductDescription_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663512);
			JSONSerializer.NativeMethodInfoPtr_DeserializeFailureReason_Public_Static_PurchaseFailureDescription_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663513);
			JSONSerializer.NativeMethodInfoPtr_DeserializeMetadata_Private_Static_ProductMetadata_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663514);
			JSONSerializer.NativeMethodInfoPtr_EncodeProductDef_Private_Static_Dictionary_2_String_Object_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663515);
			JSONSerializer.NativeMethodInfoPtr_EncodeProductDesc_Private_Static_Dictionary_2_String_Object_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663516);
			JSONSerializer.NativeMethodInfoPtr_EncodeProductMeta_Private_Static_Dictionary_2_String_Object_ProductMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONSerializer>.NativeClassPtr, 100663517);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151807, XrefRangeEnd = 151809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeProductDef(ProductDefinition product)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_SerializeProductDef_Public_Static_String_ProductDefinition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000BC30 File Offset: 0x00009E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151839, RefRangeEnd = 151840, XrefRangeStart = 151809, XrefRangeEnd = 151839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeProductDefs(IEnumerable<ProductDefinition> products)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_SerializeProductDefs_Public_Static_String_IEnumerable_1_ProductDefinition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000BC6C File Offset: 0x00009E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151870, RefRangeEnd = 151871, XrefRangeStart = 151840, XrefRangeEnd = 151870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeProductDescs(IEnumerable<ProductDescription> products)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_SerializeProductDescs_Public_Static_String_IEnumerable_1_ProductDescription_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000BCA8 File Offset: 0x00009EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151939, RefRangeEnd = 151941, XrefRangeStart = 151871, XrefRangeEnd = 151939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ProductDescription> DeserializeProductDescriptions(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_DeserializeProductDescriptions_Public_Static_List_1_ProductDescription_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDescription>>(intPtr3) : null;
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000BCEC File Offset: 0x00009EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152001, RefRangeEnd = 152003, XrefRangeStart = 151941, XrefRangeEnd = 152001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PurchaseFailureDescription DeserializeFailureReason(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_DeserializeFailureReason_Public_Static_PurchaseFailureDescription_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PurchaseFailureDescription>(intPtr3) : null;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000BD30 File Offset: 0x00009F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152031, RefRangeEnd = 152032, XrefRangeStart = 152003, XrefRangeEnd = 152031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductMetadata DeserializeMetadata(Dictionary<string, Object> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_DeserializeMetadata_Private_Static_ProductMetadata_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductMetadata>(intPtr3) : null;
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000BD74 File Offset: 0x00009F74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 152146, RefRangeEnd = 152150, XrefRangeStart = 152032, XrefRangeEnd = 152146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> EncodeProductDef(ProductDefinition product)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_EncodeProductDef_Private_Static_Dictionary_2_String_Object_ProductDefinition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152220, RefRangeEnd = 152221, XrefRangeStart = 152150, XrefRangeEnd = 152220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> EncodeProductDesc(ProductDescription product)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_EncodeProductDesc_Private_Static_Dictionary_2_String_Object_ProductDescription_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000BDFC File Offset: 0x00009FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152221, XrefRangeEnd = 152255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> EncodeProductMeta(ProductMetadata product)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONSerializer.NativeMethodInfoPtr_EncodeProductMeta_Private_Static_Dictionary_2_String_Object_ProductMetadata_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002DFC File Offset: 0x00000FFC
		public JSONSerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_SerializeProductDef_Public_Static_String_ProductDefinition_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_SerializeProductDefs_Public_Static_String_IEnumerable_1_ProductDefinition_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_SerializeProductDescs_Public_Static_String_IEnumerable_1_ProductDescription_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeProductDescriptions_Public_Static_List_1_ProductDescription_String_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeFailureReason_Public_Static_PurchaseFailureDescription_String_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeMetadata_Private_Static_ProductMetadata_Dictionary_2_String_Object_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_EncodeProductDef_Private_Static_Dictionary_2_String_Object_ProductDefinition_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_EncodeProductDesc_Private_Static_Dictionary_2_String_Object_ProductDescription_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_EncodeProductMeta_Private_Static_Dictionary_2_String_Object_ProductMetadata_0;
	}
}
