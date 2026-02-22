using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000015 RID: 21
	public class BillingClientStateListener : AndroidJavaProxy
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00007D64 File Offset: 0x00005F64
		// Note: this type is marked as 'beforefieldinit'.
		static BillingClientStateListener()
		{
			Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "BillingClientStateListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr);
			BillingClientStateListener.NativeFieldInfoPtr_m_OnConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr, "m_OnConnected");
			BillingClientStateListener.NativeFieldInfoPtr_m_Disconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr, "m_Disconnect");
			BillingClientStateListener.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr, 100663378);
			BillingClientStateListener.NativeMethodInfoPtr_RegisterOnConnected_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr, 100663379);
			BillingClientStateListener.NativeMethodInfoPtr_RegisterOnDisconnected_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr, 100663380);
			BillingClientStateListener.NativeMethodInfoPtr_onBillingSetupFinished_Private_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr, 100663381);
			BillingClientStateListener.NativeMethodInfoPtr_onBillingServiceDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr, 100663382);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007E20 File Offset: 0x00006020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150835, XrefRangeEnd = 150841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BillingClientStateListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillingClientStateListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientStateListener.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007E5C File Offset: 0x0000605C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterOnConnected(Action onConnected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onConnected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientStateListener.NativeMethodInfoPtr_RegisterOnConnected_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007EA0 File Offset: 0x000060A0
		[CallerCount(0)]
		public unsafe virtual void RegisterOnDisconnected(Action onDisconnected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onDisconnected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientStateListener.NativeMethodInfoPtr_RegisterOnDisconnected_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007EE4 File Offset: 0x000060E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150841, XrefRangeEnd = 150849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onBillingSetupFinished(AndroidJavaObject billingResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientStateListener.NativeMethodInfoPtr_onBillingSetupFinished_Private_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007F28 File Offset: 0x00006128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150849, XrefRangeEnd = 150851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onBillingServiceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingClientStateListener.NativeMethodInfoPtr_onBillingServiceDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000024B3 File Offset: 0x000006B3
		public BillingClientStateListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00007F5C File Offset: 0x0000615C
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000024BC File Offset: 0x000006BC
		public unsafe Action m_OnConnected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingClientStateListener.NativeFieldInfoPtr_m_OnConnected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingClientStateListener.NativeFieldInfoPtr_m_OnConnected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00007F8C File Offset: 0x0000618C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000024DB File Offset: 0x000006DB
		public unsafe Action m_Disconnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingClientStateListener.NativeFieldInfoPtr_m_Disconnect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingClientStateListener.NativeFieldInfoPtr_m_Disconnect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_m_OnConnected;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_m_Disconnect;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnConnected_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnDisconnected_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_onBillingSetupFinished_Private_Void_AndroidJavaObject_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_onBillingServiceDisconnected_Private_Void_0;
	}
}
