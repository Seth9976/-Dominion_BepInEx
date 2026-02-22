using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Utils
{
	// Token: 0x02000099 RID: 153
	public static class SkuDetailsConverter : Object
	{
		// Token: 0x060005C7 RID: 1479 RVA: 0x00019030 File Offset: 0x00017230
		// Note: this type is marked as 'beforefieldinit'.
		static SkuDetailsConverter()
		{
			Il2CppClassPointerStore<SkuDetailsConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Utils", "SkuDetailsConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkuDetailsConverter>.NativeClassPtr);
			SkuDetailsConverter.NativeMethodInfoPtr_ConvertOnQuerySkuDetailsResponse_Internal_Static_Void_List_1_AndroidJavaObject_Action_1_List_1_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkuDetailsConverter>.NativeClassPtr, 100664002);
			SkuDetailsConverter.NativeMethodInfoPtr_ConvertSkusDetailsToProducts_Private_Static_List_1_ProductDescription_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkuDetailsConverter>.NativeClassPtr, 100664003);
			SkuDetailsConverter.NativeMethodInfoPtr_ToListProducts_Private_Static_List_1_ProductDescription_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkuDetailsConverter>.NativeClassPtr, 100664004);
			SkuDetailsConverter.NativeMethodInfoPtr_BuildProductDescription_Internal_Static_ProductDescription_IAndroidJavaObjectWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkuDetailsConverter>.NativeClassPtr, 100664005);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000190B0 File Offset: 0x000172B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157507, RefRangeEnd = 157508, XrefRangeStart = 157502, XrefRangeEnd = 157507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertOnQuerySkuDetailsResponse(List<AndroidJavaObject> skus, Action<List<ProductDescription>> onProductsReceived)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onProductsReceived);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkuDetailsConverter.NativeMethodInfoPtr_ConvertOnQuerySkuDetailsResponse_Internal_Static_Void_List_1_AndroidJavaObject_Action_1_List_1_ProductDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000190F8 File Offset: 0x000172F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157545, RefRangeEnd = 157546, XrefRangeStart = 157508, XrefRangeEnd = 157545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ProductDescription> ConvertSkusDetailsToProducts(List<AndroidJavaObject> skus)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkuDetailsConverter.NativeMethodInfoPtr_ConvertSkusDetailsToProducts_Private_Static_List_1_ProductDescription_List_1_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDescription>>(intPtr3) : null;
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0001913C File Offset: 0x0001733C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157546, XrefRangeEnd = 157560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ProductDescription> ToListProducts(this AndroidJavaObject skusDetails)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skusDetails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkuDetailsConverter.NativeMethodInfoPtr_ToListProducts_Private_Static_List_1_ProductDescription_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDescription>>(intPtr3) : null;
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00019180 File Offset: 0x00017380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157657, RefRangeEnd = 157659, XrefRangeStart = 157560, XrefRangeEnd = 157657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductDescription BuildProductDescription(IAndroidJavaObjectWrapper skuDetails)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skuDetails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkuDetailsConverter.NativeMethodInfoPtr_BuildProductDescription_Internal_Static_ProductDescription_IAndroidJavaObjectWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDescription>(intPtr3) : null;
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00004E8E File Offset: 0x0000308E
		public SkuDetailsConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_ConvertOnQuerySkuDetailsResponse_Internal_Static_Void_List_1_AndroidJavaObject_Action_1_List_1_ProductDescription_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_ConvertSkusDetailsToProducts_Private_Static_List_1_ProductDescription_List_1_AndroidJavaObject_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_ToListProducts_Private_Static_List_1_ProductDescription_AndroidJavaObject_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_BuildProductDescription_Internal_Static_ProductDescription_IAndroidJavaObjectWrapper_0;
	}
}
