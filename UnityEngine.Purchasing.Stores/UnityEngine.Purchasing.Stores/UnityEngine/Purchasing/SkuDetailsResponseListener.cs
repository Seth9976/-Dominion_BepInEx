using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001A RID: 26
	public class SkuDetailsResponseListener : AndroidJavaProxy
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x000089EC File Offset: 0x00006BEC
		// Note: this type is marked as 'beforefieldinit'.
		static SkuDetailsResponseListener()
		{
			Il2CppClassPointerStore<SkuDetailsResponseListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "SkuDetailsResponseListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkuDetailsResponseListener>.NativeClassPtr);
			SkuDetailsResponseListener.NativeFieldInfoPtr_m_OnSkuDetailsResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkuDetailsResponseListener>.NativeClassPtr, "m_OnSkuDetailsResponse");
			SkuDetailsResponseListener.NativeMethodInfoPtr__ctor_Internal_Void_Action_2_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkuDetailsResponseListener>.NativeClassPtr, 100663400);
			SkuDetailsResponseListener.NativeMethodInfoPtr_onSkuDetailsResponse_Private_Void_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkuDetailsResponseListener>.NativeClassPtr, 100663401);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00008A58 File Offset: 0x00006C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151125, XrefRangeEnd = 151131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkuDetailsResponseListener(Action<AndroidJavaObject, AndroidJavaObject> onSkuDetailsResponseAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkuDetailsResponseListener>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponseAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkuDetailsResponseListener.NativeMethodInfoPtr__ctor_Internal_Void_Action_2_AndroidJavaObject_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00008AA4 File Offset: 0x00006CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151131, XrefRangeEnd = 151135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onSkuDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject skuDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skuDetails);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkuDetailsResponseListener.NativeMethodInfoPtr_onSkuDetailsResponse_Private_Void_AndroidJavaObject_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002654 File Offset: 0x00000854
		public SkuDetailsResponseListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00008AF8 File Offset: 0x00006CF8
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000265D File Offset: 0x0000085D
		public unsafe Action<AndroidJavaObject, AndroidJavaObject> m_OnSkuDetailsResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkuDetailsResponseListener.NativeFieldInfoPtr_m_OnSkuDetailsResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidJavaObject, AndroidJavaObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkuDetailsResponseListener.NativeFieldInfoPtr_m_OnSkuDetailsResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSkuDetailsResponse;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_2_AndroidJavaObject_AndroidJavaObject_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_onSkuDetailsResponse_Private_Void_AndroidJavaObject_AndroidJavaObject_0;
	}
}
