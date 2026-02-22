using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000044 RID: 68
	public class InventoryInterface : Object
	{
		// Token: 0x0600022A RID: 554 RVA: 0x0000D16C File Offset: 0x0000B36C
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryInterface()
		{
			Il2CppClassPointerStore<InventoryInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "InventoryInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryInterface>.NativeClassPtr);
			InventoryInterface.NativeFieldInfoPtr_s_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryInterface>.NativeClassPtr, "s_typeCache");
			InventoryInterface.NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryInterface>.NativeClassPtr, 100663574);
			InventoryInterface.NativeMethodInfoPtr_GetProductListMethod_Internal_Static_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryInterface>.NativeClassPtr, 100663575);
			InventoryInterface.NativeMethodInfoPtr_GetPurchaseInfoMethod_Internal_Static_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryInterface>.NativeClassPtr, 100663576);
			InventoryInterface.NativeMethodInfoPtr_HasPurchaseMethod_Internal_Static_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryInterface>.NativeClassPtr, 100663577);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000D200 File Offset: 0x0000B400
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 152931, RefRangeEnd = 152936, XrefRangeStart = 152917, XrefRangeEnd = 152931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetClassType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryInterface.NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000D234 File Offset: 0x0000B434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152936, XrefRangeEnd = 152941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetProductListMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryInterface.NativeMethodInfoPtr_GetProductListMethod_Internal_Static_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000D268 File Offset: 0x0000B468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152946, RefRangeEnd = 152947, XrefRangeStart = 152941, XrefRangeEnd = 152946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetPurchaseInfoMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryInterface.NativeMethodInfoPtr_GetPurchaseInfoMethod_Internal_Static_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000D29C File Offset: 0x0000B49C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152952, RefRangeEnd = 152953, XrefRangeStart = 152947, XrefRangeEnd = 152952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo HasPurchaseMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryInterface.NativeMethodInfoPtr_HasPurchaseMethod_Internal_Static_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000311C File Offset: 0x0000131C
		public InventoryInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000D2D0 File Offset: 0x0000B4D0
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00003125 File Offset: 0x00001325
		public unsafe static Type s_typeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InventoryInterface.NativeFieldInfoPtr_s_typeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InventoryInterface.NativeFieldInfoPtr_s_typeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_s_typeCache;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_GetProductListMethod_Internal_Static_MethodInfo_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_GetPurchaseInfoMethod_Internal_Static_MethodInfo_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_HasPurchaseMethod_Internal_Static_MethodInfo_0;
	}
}
