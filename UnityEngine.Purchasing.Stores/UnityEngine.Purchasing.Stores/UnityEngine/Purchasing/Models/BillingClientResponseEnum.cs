using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000082 RID: 130
	public static class BillingClientResponseEnum : Object
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x00016D84 File Offset: 0x00014F84
		// Note: this type is marked as 'beforefieldinit'.
		static BillingClientResponseEnum()
		{
			Il2CppClassPointerStore<BillingClientResponseEnum>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "BillingClientResponseEnum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillingClientResponseEnum>.NativeClassPtr);
			BillingClientResponseEnum.NativeMethodInfoPtr_GetBillingResponseCodeJavaObject_Private_Static_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientResponseEnum>.NativeClassPtr, 100663933);
			BillingClientResponseEnum.NativeMethodInfoPtr_OK_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientResponseEnum>.NativeClassPtr, 100663934);
			BillingClientResponseEnum.NativeMethodInfoPtr_USER_CANCELED_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientResponseEnum>.NativeClassPtr, 100663935);
			BillingClientResponseEnum.NativeMethodInfoPtr_ITEM_ALREADY_OWNED_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientResponseEnum>.NativeClassPtr, 100663936);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00016E04 File Offset: 0x00015004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156756, XrefRangeEnd = 156762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject GetBillingResponseCodeJavaObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientResponseEnum.NativeMethodInfoPtr_GetBillingResponseCodeJavaObject_Private_Static_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00016E38 File Offset: 0x00015038
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 156774, RefRangeEnd = 156781, XrefRangeStart = 156762, XrefRangeEnd = 156774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OK()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientResponseEnum.NativeMethodInfoPtr_OK_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00016E68 File Offset: 0x00015068
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156793, RefRangeEnd = 156796, XrefRangeStart = 156781, XrefRangeEnd = 156793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int USER_CANCELED()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientResponseEnum.NativeMethodInfoPtr_USER_CANCELED_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00016E98 File Offset: 0x00015098
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156808, RefRangeEnd = 156811, XrefRangeStart = 156796, XrefRangeEnd = 156808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ITEM_ALREADY_OWNED()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientResponseEnum.NativeMethodInfoPtr_ITEM_ALREADY_OWNED_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000049F8 File Offset: 0x00002BF8
		public BillingClientResponseEnum(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_GetBillingResponseCodeJavaObject_Private_Static_AndroidJavaObject_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_OK_Internal_Static_Int32_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_USER_CANCELED_Internal_Static_Int32_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_ITEM_ALREADY_OWNED_Internal_Static_Int32_0;
	}
}
