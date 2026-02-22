using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000047 RID: 71
	public class UdpIapBridgeInterface : Object
	{
		// Token: 0x06000244 RID: 580 RVA: 0x0000D698 File Offset: 0x0000B898
		// Note: this type is marked as 'beforefieldinit'.
		static UdpIapBridgeInterface()
		{
			Il2CppClassPointerStore<UdpIapBridgeInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UdpIapBridgeInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UdpIapBridgeInterface>.NativeClassPtr);
			UdpIapBridgeInterface.NativeFieldInfoPtr_s_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpIapBridgeInterface>.NativeClassPtr, "s_typeCache");
			UdpIapBridgeInterface.NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpIapBridgeInterface>.NativeClassPtr, 100663588);
			UdpIapBridgeInterface.NativeMethodInfoPtr_GetInitMethod_Internal_Static_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpIapBridgeInterface>.NativeClassPtr, 100663589);
			UdpIapBridgeInterface.NativeMethodInfoPtr_GetPurchaseMethod_Internal_Static_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpIapBridgeInterface>.NativeClassPtr, 100663590);
			UdpIapBridgeInterface.NativeMethodInfoPtr_GetRetrieveProductsMethod_Internal_Static_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpIapBridgeInterface>.NativeClassPtr, 100663591);
			UdpIapBridgeInterface.NativeMethodInfoPtr_GetFinishTransactionMethod_Internal_Static_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpIapBridgeInterface>.NativeClassPtr, 100663592);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000D740 File Offset: 0x0000B940
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 153074, RefRangeEnd = 153083, XrefRangeStart = 153060, XrefRangeEnd = 153074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetClassType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpIapBridgeInterface.NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000D774 File Offset: 0x0000B974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153083, XrefRangeEnd = 153088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetInitMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpIapBridgeInterface.NativeMethodInfoPtr_GetInitMethod_Internal_Static_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153088, XrefRangeEnd = 153093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetPurchaseMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpIapBridgeInterface.NativeMethodInfoPtr_GetPurchaseMethod_Internal_Static_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153093, XrefRangeEnd = 153098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetRetrieveProductsMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpIapBridgeInterface.NativeMethodInfoPtr_GetRetrieveProductsMethod_Internal_Static_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000D810 File Offset: 0x0000BA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153098, XrefRangeEnd = 153103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetFinishTransactionMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpIapBridgeInterface.NativeMethodInfoPtr_GetFinishTransactionMethod_Internal_Static_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000316D File Offset: 0x0000136D
		public UdpIapBridgeInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000D844 File Offset: 0x0000BA44
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00003176 File Offset: 0x00001376
		public unsafe static Type s_typeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UdpIapBridgeInterface.NativeFieldInfoPtr_s_typeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UdpIapBridgeInterface.NativeFieldInfoPtr_s_typeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_s_typeCache;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_GetInitMethod_Internal_Static_MethodInfo_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_GetPurchaseMethod_Internal_Static_MethodInfo_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_GetRetrieveProductsMethod_Internal_Static_MethodInfo_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_GetFinishTransactionMethod_Internal_Static_MethodInfo_0;
	}
}
