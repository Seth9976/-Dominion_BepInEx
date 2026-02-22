using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000018 RID: 24
	public class GooglePriceChangeConfirmationListener : AndroidJavaProxy
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x0000837C File Offset: 0x0000657C
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePriceChangeConfirmationListener()
		{
			Il2CppClassPointerStore<GooglePriceChangeConfirmationListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePriceChangeConfirmationListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePriceChangeConfirmationListener>.NativeClassPtr);
			GooglePriceChangeConfirmationListener.NativeFieldInfoPtr_m_OnPriceChangeConfirmationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePriceChangeConfirmationListener>.NativeClassPtr, "m_OnPriceChangeConfirmationResult");
			GooglePriceChangeConfirmationListener.NativeMethodInfoPtr_onPriceChangeConfirmationResult_Private_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePriceChangeConfirmationListener>.NativeClassPtr, 100663387);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000083D4 File Offset: 0x000065D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150877, XrefRangeEnd = 150885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onPriceChangeConfirmationResult(AndroidJavaObject javaBillingResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(javaBillingResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePriceChangeConfirmationListener.NativeMethodInfoPtr_onPriceChangeConfirmationResult_Private_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000025C6 File Offset: 0x000007C6
		public GooglePriceChangeConfirmationListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00008418 File Offset: 0x00006618
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000025CF File Offset: 0x000007CF
		public unsafe Action<GoogleBillingResult> m_OnPriceChangeConfirmationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePriceChangeConfirmationListener.NativeFieldInfoPtr_m_OnPriceChangeConfirmationResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleBillingResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePriceChangeConfirmationListener.NativeFieldInfoPtr_m_OnPriceChangeConfirmationResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_m_OnPriceChangeConfirmationResult;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_onPriceChangeConfirmationResult_Private_Void_AndroidJavaObject_0;
	}
}
