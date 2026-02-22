using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000017 RID: 23
	public class SimpleCatalogProvider : Object
	{
		// Token: 0x060000ED RID: 237 RVA: 0x000063CC File Offset: 0x000045CC
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleCatalogProvider()
		{
			Il2CppClassPointerStore<SimpleCatalogProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "SimpleCatalogProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCatalogProvider>.NativeClassPtr);
			SimpleCatalogProvider.NativeFieldInfoPtr_m_Func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCatalogProvider>.NativeClassPtr, "m_Func");
			SimpleCatalogProvider.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCatalogProvider>.NativeClassPtr, 100663421);
			SimpleCatalogProvider.NativeMethodInfoPtr_FetchProducts_Public_Virtual_Final_New_Void_Action_1_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCatalogProvider>.NativeClassPtr, 100663422);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006438 File Offset: 0x00004638
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCatalogProvider(Action<Action<HashSet<ProductDefinition>>> func)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCatalogProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCatalogProvider.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006484 File Offset: 0x00004684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131085, XrefRangeEnd = 131088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FetchProducts(Action<HashSet<ProductDefinition>> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCatalogProvider.NativeMethodInfoPtr_FetchProducts_Public_Virtual_Final_New_Void_Action_1_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002659 File Offset: 0x00000859
		public SimpleCatalogProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000064C8 File Offset: 0x000046C8
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002662 File Offset: 0x00000862
		public unsafe Action<Action<HashSet<ProductDefinition>>> m_Func
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCatalogProvider.NativeFieldInfoPtr_m_Func);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action<HashSet<ProductDefinition>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCatalogProvider.NativeFieldInfoPtr_m_Func), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_m_Func;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_FetchProducts_Public_Virtual_Final_New_Void_Action_1_HashSet_1_ProductDefinition_0;
	}
}
