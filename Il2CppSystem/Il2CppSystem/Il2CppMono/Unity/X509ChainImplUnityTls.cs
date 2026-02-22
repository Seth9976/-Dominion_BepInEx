using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x0200000B RID: 11
	public class X509ChainImplUnityTls : X509ChainImpl
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00012408 File Offset: 0x00010608
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainImplUnityTls()
		{
			Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "X509ChainImplUnityTls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr);
			X509ChainImplUnityTls.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "elements");
			X509ChainImplUnityTls.NativeFieldInfoPtr_nativeCertificateChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "nativeCertificateChain");
			X509ChainImplUnityTls.NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "policy");
			X509ChainImplUnityTls.NativeFieldInfoPtr_chainStatusList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "chainStatusList");
			X509ChainImplUnityTls.NativeMethodInfoPtr__ctor_Internal_Void_unitytls_x509list_ref_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663421);
			X509ChainImplUnityTls.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663422);
			X509ChainImplUnityTls.NativeMethodInfoPtr_get_NativeCertificateChain_Internal_get_unitytls_x509list_ref_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663423);
			X509ChainImplUnityTls.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663424);
			X509ChainImplUnityTls.NativeMethodInfoPtr_set_ChainPolicy_Public_Virtual_set_Void_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663425);
			X509ChainImplUnityTls.NativeMethodInfoPtr_AddStatus_Public_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663426);
			X509ChainImplUnityTls.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663427);
			X509ChainImplUnityTls.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663428);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00012528 File Offset: 0x00010728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32293, RefRangeEnd = 32294, XrefRangeStart = 32287, XrefRangeEnd = 32293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImplUnityTls(UnityTls.unitytls_x509list_ref nativeCertificateChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeCertificateChain;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplUnityTls.NativeMethodInfoPtr__ctor_Internal_Void_unitytls_x509list_ref_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00012570 File Offset: 0x00010770
		public unsafe override bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32294, XrefRangeEnd = 32295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000125B8 File Offset: 0x000107B8
		public unsafe UnityTls.unitytls_x509list_ref NativeCertificateChain
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplUnityTls.NativeMethodInfoPtr_get_NativeCertificateChain_Internal_get_unitytls_x509list_ref_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000125F4 File Offset: 0x000107F4
		public unsafe override X509ChainElementCollection ChainElements
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32295, XrefRangeEnd = 32328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00012640 File Offset: 0x00010840
		public unsafe override X509ChainPolicy ChainPolicy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_set_ChainPolicy_Public_Virtual_set_Void_X509ChainPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00012690 File Offset: 0x00010890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32328, XrefRangeEnd = 32338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStatus(X509ChainStatusFlags errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplUnityTls.NativeMethodInfoPtr_AddStatus_Public_Void_X509ChainStatusFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000126D0 File Offset: 0x000108D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32338, XrefRangeEnd = 32339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0001270C File Offset: 0x0001090C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 16379, RefRangeEnd = 16382, XrefRangeStart = 16379, XrefRangeEnd = 16382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000022FC File Offset: 0x000004FC
		public X509ChainImplUnityTls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00012758 File Offset: 0x00010958
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002305 File Offset: 0x00000505
		public unsafe X509ChainElementCollection elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00012788 File Offset: 0x00010988
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002324 File Offset: 0x00000524
		public unsafe UnityTls.unitytls_x509list_ref nativeCertificateChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_nativeCertificateChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_nativeCertificateChain)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000127B0 File Offset: 0x000109B0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000233F File Offset: 0x0000053F
		public unsafe X509ChainPolicy policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_policy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_policy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000127E0 File Offset: 0x000109E0
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000235E File Offset: 0x0000055E
		public unsafe List<X509ChainStatus> chainStatusList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_chainStatusList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<X509ChainStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_chainStatusList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_nativeCertificateChain;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_policy;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_chainStatusList;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_unitytls_x509list_ref_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeCertificateChain_Internal_get_unitytls_x509list_ref_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_set_ChainPolicy_Public_Virtual_set_Void_X509ChainPolicy_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_AddStatus_Public_Void_X509ChainStatusFlags_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
