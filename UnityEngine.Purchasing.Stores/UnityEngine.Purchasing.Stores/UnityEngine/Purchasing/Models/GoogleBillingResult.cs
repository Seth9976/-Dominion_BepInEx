using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000084 RID: 132
	public class GoogleBillingResult : Object
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x000175B4 File Offset: 0x000157B4
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleBillingResult()
		{
			Il2CppClassPointerStore<GoogleBillingResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "GoogleBillingResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleBillingResult>.NativeClassPtr);
			GoogleBillingResult.NativeFieldInfoPtr_responseCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleBillingResult>.NativeClassPtr, "responseCode");
			GoogleBillingResult.NativeFieldInfoPtr_debugMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleBillingResult>.NativeClassPtr, "debugMessage");
			GoogleBillingResult.NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingResult>.NativeClassPtr, 100663951);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00017620 File Offset: 0x00015820
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 157166, RefRangeEnd = 157173, XrefRangeStart = 157150, XrefRangeEnd = 157166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleBillingResult(AndroidJavaObject billingResult)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleBillingResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingResult.NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00004A86 File Offset: 0x00002C86
		public GoogleBillingResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001766C File Offset: 0x0001586C
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00004A8F File Offset: 0x00002C8F
		public unsafe int responseCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingResult.NativeFieldInfoPtr_responseCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingResult.NativeFieldInfoPtr_responseCode)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00017694 File Offset: 0x00015894
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00004AAA File Offset: 0x00002CAA
		public unsafe string debugMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingResult.NativeFieldInfoPtr_debugMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleBillingResult.NativeFieldInfoPtr_debugMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_responseCode;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_debugMessage;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_0;
	}
}
