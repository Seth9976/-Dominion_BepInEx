using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000088 RID: 136
	public class GooglePurchaseStateEnum : Object
	{
		// Token: 0x06000571 RID: 1393 RVA: 0x00017BC8 File Offset: 0x00015DC8
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePurchaseStateEnum()
		{
			Il2CppClassPointerStore<GooglePurchaseStateEnum>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "GooglePurchaseStateEnum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchaseStateEnum>.NativeClassPtr);
			GooglePurchaseStateEnum.NativeMethodInfoPtr_GetPurchaseStateJavaObject_Private_Static_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseStateEnum>.NativeClassPtr, 100663958);
			GooglePurchaseStateEnum.NativeMethodInfoPtr_Purchased_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseStateEnum>.NativeClassPtr, 100663959);
			GooglePurchaseStateEnum.NativeMethodInfoPtr_Pending_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseStateEnum>.NativeClassPtr, 100663960);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00017C34 File Offset: 0x00015E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157328, XrefRangeEnd = 157334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject GetPurchaseStateJavaObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseStateEnum.NativeMethodInfoPtr_GetPurchaseStateJavaObject_Private_Static_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00017C68 File Offset: 0x00015E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157346, RefRangeEnd = 157347, XrefRangeStart = 157334, XrefRangeEnd = 157346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Purchased()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseStateEnum.NativeMethodInfoPtr_Purchased_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00017C98 File Offset: 0x00015E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157347, XrefRangeEnd = 157359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Pending()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseStateEnum.NativeMethodInfoPtr_Pending_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00004C4B File Offset: 0x00002E4B
		public GooglePurchaseStateEnum(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_GetPurchaseStateJavaObject_Private_Static_AndroidJavaObject_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_Purchased_Internal_Static_Int32_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_Pending_Internal_Static_Int32_0;
	}
}
