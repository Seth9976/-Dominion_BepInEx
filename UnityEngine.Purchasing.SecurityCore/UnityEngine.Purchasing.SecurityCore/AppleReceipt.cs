using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Security
{
	// Token: 0x02000002 RID: 2
	public class AppleReceipt : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// Note: this type is marked as 'beforefieldinit'.
		static AppleReceipt()
		{
			Il2CppClassPointerStore<AppleReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.SecurityCore.dll", "UnityEngine.Purchasing.Security", "AppleReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleReceipt>.NativeClassPtr);
			AppleReceipt.NativeFieldInfoPtr_inAppPurchaseReceipts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleReceipt>.NativeClassPtr, "inAppPurchaseReceipts");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002089 File Offset: 0x00000289
		public AppleReceipt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000219C File Offset: 0x0000039C
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002092 File Offset: 0x00000292
		public unsafe Il2CppReferenceArray<AppleInAppPurchaseReceipt> inAppPurchaseReceipts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleReceipt.NativeFieldInfoPtr_inAppPurchaseReceipts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AppleInAppPurchaseReceipt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleReceipt.NativeFieldInfoPtr_inAppPurchaseReceipts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_inAppPurchaseReceipts;
	}
}
