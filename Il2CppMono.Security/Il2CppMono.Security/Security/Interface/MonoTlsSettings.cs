using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000026 RID: 38
	public sealed class MonoTlsSettings : Object
	{
		// Token: 0x060001CF RID: 463 RVA: 0x0000A608 File Offset: 0x00008808
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsSettings()
		{
			Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr);
			MonoTlsSettings.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<RemoteCertificateValidationCallback>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<ClientCertificateSelectionCallback>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__CertificateValidationTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<CertificateValidationTime>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__TrustAnchors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<TrustAnchors>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__UserSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<UserSettings>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<CertificateSearchPaths>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__SendCloseNotify_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<SendCloseNotify>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__EnabledProtocols_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<EnabledProtocols>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__EnabledCiphers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<EnabledCiphers>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr_cloned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "cloned");
			MonoTlsSettings.NativeFieldInfoPtr_checkCertName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "checkCertName");
			MonoTlsSettings.NativeFieldInfoPtr_checkCertRevocationStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "checkCertRevocationStatus");
			MonoTlsSettings.NativeFieldInfoPtr_useServicePointManagerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "useServicePointManagerCallback");
			MonoTlsSettings.NativeFieldInfoPtr_skipSystemValidators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "skipSystemValidators");
			MonoTlsSettings.NativeFieldInfoPtr_callbackNeedsChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "callbackNeedsChain");
			MonoTlsSettings.NativeFieldInfoPtr_certificateValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "certificateValidator");
			MonoTlsSettings.NativeFieldInfoPtr_defaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "defaultSettings");
			MonoTlsSettings.NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663544);
			MonoTlsSettings.NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663545);
			MonoTlsSettings.NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663546);
			MonoTlsSettings.NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663547);
			MonoTlsSettings.NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663548);
			MonoTlsSettings.NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663549);
			MonoTlsSettings.NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663550);
			MonoTlsSettings.NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663551);
			MonoTlsSettings.NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663552);
			MonoTlsSettings.NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663553);
			MonoTlsSettings.NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663554);
			MonoTlsSettings.NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663555);
			MonoTlsSettings.NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663556);
			MonoTlsSettings.NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663557);
			MonoTlsSettings.NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663558);
			MonoTlsSettings.NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663559);
			MonoTlsSettings.NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663560);
			MonoTlsSettings.NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663561);
			MonoTlsSettings.NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663562);
			MonoTlsSettings.NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663563);
			MonoTlsSettings.NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663564);
			MonoTlsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663565);
			MonoTlsSettings.NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663566);
			MonoTlsSettings.NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663567);
			MonoTlsSettings.NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663568);
			MonoTlsSettings.NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663569);
			MonoTlsSettings.NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663570);
			MonoTlsSettings.NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663571);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000A9BC File Offset: 0x00008BBC
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000A9FC File Offset: 0x00008BFC
		public unsafe MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000AA40 File Offset: 0x00008C40
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0000AA80 File Offset: 0x00008C80
		public unsafe MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000AAC4 File Offset: 0x00008CC4
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0000AAFC File Offset: 0x00008CFC
		public unsafe Nullable<bool> UseServicePointManagerCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000AB44 File Offset: 0x00008D44
		public unsafe bool CallbackNeedsCertificateChain
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000AB80 File Offset: 0x00008D80
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		public unsafe Nullable<DateTime> CertificateValidationTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTime>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000AC00 File Offset: 0x00008E00
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000AC40 File Offset: 0x00008E40
		public unsafe X509CertificateCollection TrustAnchors
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000AC84 File Offset: 0x00008E84
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		public unsafe Object UserSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000AD08 File Offset: 0x00008F08
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000AD48 File Offset: 0x00008F48
		public unsafe Il2CppStringArray CertificateSearchPaths
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000AD8C File Offset: 0x00008F8C
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		public unsafe bool SendCloseNotify
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000AE08 File Offset: 0x00009008
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000AE40 File Offset: 0x00009040
		public unsafe Nullable<TlsProtocols> EnabledProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TlsProtocols>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000AE88 File Offset: 0x00009088
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000AEC8 File Offset: 0x000090C8
		public unsafe Il2CppStructArray<CipherSuiteCode> EnabledCiphers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CipherSuiteCode>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000AF0C File Offset: 0x0000910C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10209, XrefRangeEnd = 10210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000AF48 File Offset: 0x00009148
		public unsafe static MonoTlsSettings DefaultSettings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10210, XrefRangeEnd = 10217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AF7C File Offset: 0x0000917C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 10228, RefRangeEnd = 10230, XrefRangeStart = 10217, XrefRangeEnd = 10228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsSettings CopyDefaultSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000AFB0 File Offset: 0x000091B0
		public unsafe ICertificateValidator CertificateValidator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICertificateValidator>(intPtr3) : null;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000AFF0 File Offset: 0x000091F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 10234, RefRangeEnd = 10235, XrefRangeStart = 10230, XrefRangeEnd = 10234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsSettings CloneWithValidator(ICertificateValidator validator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000B040 File Offset: 0x00009240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10235, XrefRangeEnd = 10239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsSettings Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000B080 File Offset: 0x00009280
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 10248, RefRangeEnd = 10251, XrefRangeStart = 10239, XrefRangeEnd = 10248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsSettings(MonoTlsSettings other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002C26 File Offset: 0x00000E26
		public MonoTlsSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000B0CC File Offset: 0x000092CC
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002C2F File Offset: 0x00000E2F
		public unsafe MonoRemoteCertificateValidationCallback _RemoteCertificateValidationCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000B0FC File Offset: 0x000092FC
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002C4E File Offset: 0x00000E4E
		public unsafe MonoLocalCertificateSelectionCallback _ClientCertificateSelectionCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000B12C File Offset: 0x0000932C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002C6D File Offset: 0x00000E6D
		public Nullable<DateTime> _CertificateValidationTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__CertificateValidationTime_k__BackingField);
				return new Nullable<DateTime>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateTime>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__CertificateValidationTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateTime>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000B15C File Offset: 0x0000935C
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002C9B File Offset: 0x00000E9B
		public unsafe X509CertificateCollection _TrustAnchors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__TrustAnchors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__TrustAnchors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000B18C File Offset: 0x0000938C
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002CBA File Offset: 0x00000EBA
		public unsafe Object _UserSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__UserSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__UserSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000B1BC File Offset: 0x000093BC
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002CD9 File Offset: 0x00000ED9
		public unsafe Il2CppStringArray _CertificateSearchPaths_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000B1EC File Offset: 0x000093EC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public unsafe bool _SendCloseNotify_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__SendCloseNotify_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__SendCloseNotify_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000B214 File Offset: 0x00009414
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002D13 File Offset: 0x00000F13
		public Nullable<TlsProtocols> _EnabledProtocols_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__EnabledProtocols_k__BackingField);
				return new Nullable<TlsProtocols>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TlsProtocols>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__EnabledProtocols_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TlsProtocols>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000B244 File Offset: 0x00009444
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002D41 File Offset: 0x00000F41
		public unsafe Il2CppStructArray<CipherSuiteCode> _EnabledCiphers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__EnabledCiphers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CipherSuiteCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__EnabledCiphers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000B274 File Offset: 0x00009474
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002D60 File Offset: 0x00000F60
		public unsafe bool cloned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_cloned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_cloned)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000B29C File Offset: 0x0000949C
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002D7B File Offset: 0x00000F7B
		public unsafe bool checkCertName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_checkCertName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_checkCertName)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000B2C4 File Offset: 0x000094C4
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002D96 File Offset: 0x00000F96
		public unsafe bool checkCertRevocationStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_checkCertRevocationStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_checkCertRevocationStatus)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000B2EC File Offset: 0x000094EC
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002DB1 File Offset: 0x00000FB1
		public Nullable<bool> useServicePointManagerCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_useServicePointManagerCallback);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_useServicePointManagerCallback), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000B31C File Offset: 0x0000951C
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002DDF File Offset: 0x00000FDF
		public unsafe bool skipSystemValidators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_skipSystemValidators);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_skipSystemValidators)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000B344 File Offset: 0x00009544
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002DFA File Offset: 0x00000FFA
		public unsafe bool callbackNeedsChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_callbackNeedsChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_callbackNeedsChain)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000B36C File Offset: 0x0000956C
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002E15 File Offset: 0x00001015
		public unsafe ICertificateValidator certificateValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_certificateValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICertificateValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_certificateValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000B39C File Offset: 0x0000959C
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002E34 File Offset: 0x00001034
		public unsafe static MonoTlsSettings defaultSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsSettings.NativeFieldInfoPtr_defaultSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsSettings.NativeFieldInfoPtr_defaultSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr__CertificateValidationTime_k__BackingField;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr__TrustAnchors_k__BackingField;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr__UserSettings_k__BackingField;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr__SendCloseNotify_k__BackingField;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr__EnabledProtocols_k__BackingField;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr__EnabledCiphers_k__BackingField;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_cloned;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_checkCertName;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_checkCertRevocationStatus;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_useServicePointManagerCallback;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_skipSystemValidators;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_callbackNeedsChain;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_certificateValidator;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_defaultSettings;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0;
	}
}
